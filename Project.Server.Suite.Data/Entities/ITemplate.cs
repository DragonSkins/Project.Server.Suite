
namespace Project.Server.Suite.Data.Entities
{
    public interface ITemplate
    {
        ActionScript ActionScript { get; set; }
        long ActionScriptId { get; set; }
        string ChangedAt { get; set; }
        string ChangedBy { get; set; }
        string CreatedAt { get; set; }
        string CreatedBy { get; set; }
        string? Description { get; set; }
        int Execution { get; set; }
        string Name { get; set; }
        ICollection<PssTask> PssTasks { get; set; }
        int Status { get; set; }
        ICollection<TaskCollection> TaskCollections { get; set; }
        long TemplateId { get; set; }
        ICollection<TemplateParameter> TemplateParameters { get; set; }
        ICollection<TemplateProject> TemplateProjects { get; set; }
        ICollection<TemplateServer> TemplateServers { get; set; }
        ICollection<TemplateSetting> TemplateSettings { get; set; }
        Trigger Trigger { get; set; }
        long TriggerId { get; set; }
    }
}