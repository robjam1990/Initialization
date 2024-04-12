using Newtonsoft.Json;

public class GameConfigBase
{
    public string? Genre { get; set; }
    public string? Name { get; set; }
    public string? Setting { get; set; }
    public string? Version { get; set; }

    public bool WindowTitle { get; private set; }

    public void UpdateConfig(dynamic configData)
    {
        // Validate and update configData dynamically
        foreach (var property in configData)
        {
            string propertyName = ((Newtonsoft.Json.Linq.JProperty)property).Name;
            object propertyValue = ((Newtonsoft.Json.Linq.JProperty)property).Value;
            typeof(GameConfig).GetProperty(propertyName)?.SetValue(this, propertyValue, null);
        }
    }
}