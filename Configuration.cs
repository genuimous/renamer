using System.Configuration;

namespace Renamer
{
    public static class Configuration
    {
        public static string GetValue(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }

        public static void SetValue(string key, string value)
        {
            var configurationFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var settings = configurationFile.AppSettings.Settings;

            if (settings[key] == null)
            {
                settings.Add(key, value);
            }
            else
            {
                settings[key].Value = value;
            }

            configurationFile.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection(configurationFile.AppSettings.SectionInformation.Name);
        }
    }
}
