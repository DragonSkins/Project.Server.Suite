
namespace Project.Server.Suite.Base.Interfaces
{
    public interface ITaskSettingType
    {
        int DefaultSelection { get; set; }
        string? Description { get; set; }
        string Name { get; set; }
        ICollection<Setting> Settings { get; set; }
        long TaskSettingTypeId { get; set; }
    }
}