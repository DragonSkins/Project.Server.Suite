
namespace Project.Server.Suite.Data.Entities
{
    public interface IActionScript
    {
        long ActionScriptId { get; set; }
        string ChangedAt { get; set; }
        string ChangedBy { get; set; }
        string CreatedAt { get; set; }
        string CreatedBy { get; set; }
        string? Description { get; set; }
        string? Extension { get; set; }
        string Path { get; set; }
        ICollection<PssTask> PssTasks { get; set; }
        string ScriptName { get; set; }
        ICollection<Template> Templates { get; set; }
    }
}