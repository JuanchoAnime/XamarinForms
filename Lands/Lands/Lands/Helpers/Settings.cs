namespace Lands.Helpers
{
    using Plugin.Settings;
    using Plugin.Settings.Abstractions;

    public static class Settings
    {
        private const string _land = "LAND";
        private const string _lands = "LANDS";

        private static readonly string _settingDefault = string.Empty;

        public static ISettings AppSettings => CrossSettings.Current;

        public static string Land
        {
            get => AppSettings.GetValueOrDefault(_land, _settingDefault);
            set => AppSettings.AddOrUpdateValue(_land, value);
        }

        public static string Lands
        {
            get => AppSettings.GetValueOrDefault(_lands, _settingDefault);
            set => AppSettings.AddOrUpdateValue(_lands, value);
        }
    }
}
