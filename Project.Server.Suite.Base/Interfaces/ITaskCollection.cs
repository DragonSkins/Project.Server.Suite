namespace Project.Server.Suite.Base.Interfaces
{
    public interface ITaskCollection
    {
        PssTask PssTask { get; set; }
        long PssTaskId { get; set; }
        long TaskCollectionId { get; set; }
        Template Template { get; set; }
        long TemplateId { get; set; }
    }
}