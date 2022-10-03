using Newtonsoft.Json;

namespace JsonDemo;

public class Enrollment
{
    private static readonly object Synchronized = new();
    private static int _uniqueIdGenerator = 1;

    private static readonly DateTime EpochOffset = new(1970, 1, 1);

    public Enrollment()
    {
        UniqueId = CreateUniqueId();
    }

    [JsonProperty("uniqueId")] public int UniqueId { get; set; }

    [JsonProperty("studentId")] public int StudentId { get; set; }

    [JsonProperty("courseId")] public int CourseId { get; set; }

    [JsonIgnore] public DateTime EnrolledOn { get; set; }

    [JsonProperty("enrolledOn")]
    public long EnrolledOnNumeric
    {
        get => (long)(EnrolledOn - EpochOffset).TotalMilliseconds; //convert to unix time
        set => EnrolledOn = EpochOffset.AddMilliseconds(value);
    }

    private static int CreateUniqueId()
    {
        lock (Synchronized)
        {
            _uniqueIdGenerator++;
            return _uniqueIdGenerator;
        }
    }

    public override string ToString()
    {
        if (StudentId > 0) return $"StudentId {StudentId} enrolled in CourseId {CourseId} on {EnrolledOn}";
        return "Empty enrollment";
    }
}