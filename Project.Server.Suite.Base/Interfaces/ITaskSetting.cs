namespace Project.Server.Suite.Base.Interfaces
{
    public interface ITaskSetting
    {
        PssTask PssTask { get; set; }
        long PssTaskId { get; set; }
        Setting Setting { get; set; }
        long SettingId { get; set; }
        long TaskSettingId { get; set; }
    }
}