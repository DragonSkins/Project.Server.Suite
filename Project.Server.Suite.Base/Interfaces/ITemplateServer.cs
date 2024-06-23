namespace Project.Server.Suite.Base.Interfaces
{
    public interface ITemplateServer
    {
        int Destination { get; set; }
        ProjectServer ProjectServer { get; set; }
        long ProjectServerId { get; set; }
        //Template Template { get; set; }
        long TemplateId { get; set; }
        long TemplateServerId { get; set; }
    }
}