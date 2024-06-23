namespace Project.Server.Suite.Base.Interfaces
{
    public interface ITemplateSetting
    {
        Setting Setting { get; set; }
        long SettingId { get; set; }
        Template Template { get; set; }
        long TemplateId { get; set; }
        long TemplateSettingId { get; set; }
    }
}