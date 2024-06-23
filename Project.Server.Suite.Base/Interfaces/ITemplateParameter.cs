namespace Project.Server.Suite.Base.Interfaces
{
    public interface ITemplateParameter
    {
        ActionParameter ActionParameter { get; set; }
        long ActionParameterId { get; set; }
        string? ParameterValue { get; set; }
        Template Template { get; set; }
        long TemplateId { get; set; }
        long TemplateParameterId { get; set; }
    }
}