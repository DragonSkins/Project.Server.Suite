namespace Project.Server.Suite.Base.Interfaces
{
    public interface ITaskServer
    {
        int Destination { get; set; }
        ProjectServer ProjectServer { get; set; }
        long ProjectServerId { get; set; }
        //PssTask PssTask { get; set; }
        long PssTaskId { get; set; }
        long TaskServerId { get; set; }
    }
}