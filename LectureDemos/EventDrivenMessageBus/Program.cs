using System.Text.RegularExpressions;
using EasyNetQ;
using Microsoft.Extensions.Configuration;
using Spectre.Console;

namespace EventDrivenMessageBus;

internal static class Program
{
    private static async Task Main(string[] args)
    {
        var validRegex = new Regex(@"[^a-zA-Z0-9 \.!]");
        var rabbitConfig = GetRabbitConfig();

        using var bus = RabbitHutch.CreateBus(rabbitConfig.ConnectionString);

        await bus.PubSub.SubscribeAsync<WackyChatMessage>(rabbitConfig.WhoAmI, HandleInboundMessage);

        var continueSending = true;
        while (continueSending)
        {
            var outboundMsg = AnsiConsole.Ask<string>("Message?");
            outboundMsg = validRegex.Replace((outboundMsg ?? "").Trim(),"");
            continueSending = !string.IsNullOrWhiteSpace(outboundMsg);
            if (!continueSending) continue;
            var msg = new WackyChatMessage { Text = outboundMsg, From = rabbitConfig.WhoAmI };
            await bus.PubSub.PublishAsync(msg);
        }
    }

    private static void HandleInboundMessage(WackyChatMessage wackyChatMessage)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(wackyChatMessage.FormattedMessage);
        Console.ResetColor();
    }

    private static RabbitMqConfig GetRabbitConfig()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", false);

        IConfiguration config = builder.Build();

        return config.GetSection("RabbitMq").Get<RabbitMqConfig>();
    }
}

public class RabbitMqConfig
{
    public string User { get; set; } = "UserNotSet";
    public string Password { get; set; } = "PasswordNotSet";
    public string Host { get; set; } = "HostNotSet";
    public string ConnectionString => $"host={Host};virtualHost={User};username={User};password={Password}";
    public string WhoAmI => $"{Environment.MachineName}.{Environment.UserName}";
}

public class WackyChatMessage
{
    public DateTime SentAt { get; set; } = DateTime.Now;
    public string From { get; set; } = "FromNotSet";
    public string Text { get; set; } = "TextNotSet";
    public string FormattedMessage => $"-> \r\n{From} at {SentAt}\r\n {Text}\r\n";
}