
namespace Project.Server.Suite.Base.Interfaces
{
    public interface IRevision
    {
        string Author { get; set; }
        int InputNotification { get; set; }
        string LastModified { get; set; }
        string Modified { get; set; }
        string Notice { get; set; }
        int ProjectRevision { get; set; }
        string? RevisionHash { get; set; }
        long RevisionId { get; set; }
        int SendNotification { get; set; }
        ICollection<TaskExecuteRevision> TaskExecuteRevisions { get; set; }
        string Tested { get; set; }
        TiaProject TiaProject { get; set; }
        long TiaProjectId { get; set; }
    }
}