namespace Project.Server.Suite.Base.Interfaces
{
    public interface ITaskParameter
    {
        ActionParameter ActionParameter { get; set; }
        long ActionParameterId { get; set; }
        string? ParameterValue { get; set; }
        PssTask PssTask { get; set; }
        long PssTaskId { get; set; }
        long TaskParameterId { get; set; }
    }
}