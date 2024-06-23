
namespace Project.Server.Suite.Base.Interfaces
{
    public interface IWorker
    {
        string? Description { get; set; }
        string KeepAlive { get; set; }
        int Status { get; set; }
        ICollection<WorkerAssignedLable> WorkerAssignedLables { get; set; }
        long WorkerId { get; set; }
        string WorkerName { get; set; }
    }
}