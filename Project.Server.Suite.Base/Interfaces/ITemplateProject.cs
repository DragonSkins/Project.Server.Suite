namespace Project.Server.Suite.Base.Interfaces
{
    public interface ITemplateProject
    {
        int Destination { get; set; }
        Template Template { get; set; }
        long TemplateId { get; set; }
        long TemplateProjectId { get; set; }
        TiaProject TiaProject { get; set; }
        long TiaProjectId { get; set; }
    }
}