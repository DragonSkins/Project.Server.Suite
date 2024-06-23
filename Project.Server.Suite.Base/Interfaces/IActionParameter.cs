
namespace Project.Server.Suite.Base.Interfaces
{
    public interface IActionParameter
    {
        long ActionParameterId { get; set; }
        ActionParameterType? ActionParameterType { get; set; }
        long? ActionParameterTypeId { get; set; }
        string? Key { get; set; }
        ICollection<TaskParameter> TaskParameters { get; set; }
        ICollection<TemplateParameter> TemplateParameters { get; set; }
        int Value { get; set; }
    }
}