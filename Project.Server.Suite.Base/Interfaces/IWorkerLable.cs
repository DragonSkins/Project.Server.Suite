
namespace Project.Server.Suite.Base.Interfaces
{
    public interface IWorkerLable
    {
        string? Description { get; set; }
        string LableName { get; set; }
        WorkerAssignedLable WorkerAssignedLables { get; set; }
        long WorkerLableId { get; set; }
    }
}