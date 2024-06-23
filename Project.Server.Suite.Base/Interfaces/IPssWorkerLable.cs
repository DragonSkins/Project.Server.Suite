namespace Project.Server.Suite.Base.Interfaces
{
    public interface IPssWorkerLable
    {
        string? Description { get; set; }
        string LableName { get; set; }
        long PssWorkerLableId { get; set; }
    }
}