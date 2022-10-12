using System.Text.RegularExpressions;
using EasyNetQ;
using Microsoft.Extensions.Configuration;
using Spectre.Console;

namespace WackyChat;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        Application.Run(new MainForm());
    }
}

