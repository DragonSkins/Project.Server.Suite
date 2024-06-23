namespace Project.Server.Suite.Base.Interfaces
{
    public interface ITaskProject
    {
        int Destination { get; set; }
        PssTask PssTask { get; set; }
        long PssTaskId { get; set; }
        long TaskProjectId { get; set; }
        TiaProject TiaProject { get; set; }
        long TiaProjectId { get; set; }
    }
}