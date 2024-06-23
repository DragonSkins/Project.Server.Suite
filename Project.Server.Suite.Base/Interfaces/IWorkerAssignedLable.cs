namespace Project.Server.Suite.Base.Interfaces
{
    public interface IWorkerAssignedLable
    {
        Worker Worker { get; set; }
        long WorkerAssignedLableId { get; set; }
        long WorkerId { get; set; }
        WorkerLable WorkerLable { get; set; }
        long WorkerLableId { get; set; }
    }
}