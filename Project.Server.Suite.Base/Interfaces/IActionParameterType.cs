
namespace Project.Server.Suite.Base.Interfaces
{
    public interface IActionParameterType
    {
        ICollection<ActionParameter> ActionParameters { get; set; }
        long ActionParameterTypeId { get; set; }
        string Key { get; set; }
        string KeyAlias { get; set; }
        string? KeyCmd { get; set; }
        int ParameterType { get; set; }
        string ToolTip { get; set; }
        int Visibility { get; set; }
    }
}