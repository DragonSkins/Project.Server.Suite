
namespace Project.Server.Suite.Base.Interfaces
{
    public interface ISetting
    {
        long SettingId { get; set; }
        ICollection<TaskSetting> TaskSettings { get; set; }
        TaskSettingType? TaskSettingType { get; set; }
        long? TaskSettingTypeId { get; set; }
        ICollection<TemplateSetting> TemplateSettings { get; set; }
        int Value { get; set; }
    }
}