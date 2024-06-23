namespace Project.Server.Suite.Base.Interfaces
{
    public interface ITaskExecuteRevision
    {
        PssTask? PssTask { get; set; }
        long? PssTaskId { get; set; }
        Revision? Revision { get; set; }
        long? RevisionId { get; set; }
        int Status { get; set; }
        long TaskExecuteRevisionId { get; set; }
    }
}