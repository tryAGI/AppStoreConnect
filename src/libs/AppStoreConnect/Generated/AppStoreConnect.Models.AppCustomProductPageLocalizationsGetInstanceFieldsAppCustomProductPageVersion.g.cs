
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppCustomProductPageLocalizationsGetInstanceFieldsAppCustomProductPageVersion
    {
        /// <summary>
        ///
        /// </summary>
        AppCustomProductPage,
        /// <summary>
        ///
        /// </summary>
        AppCustomProductPageLocalizations,
        /// <summary>
        ///
        /// </summary>
        DeepLink,
        /// <summary>
        ///
        /// </summary>
        State,
        /// <summary>
        ///
        /// </summary>
        Version,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppCustomProductPageLocalizationsGetInstanceFieldsAppCustomProductPageVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppCustomProductPageLocalizationsGetInstanceFieldsAppCustomProductPageVersion value)
        {
            return value switch
            {
                AppCustomProductPageLocalizationsGetInstanceFieldsAppCustomProductPageVersion.AppCustomProductPage => "appCustomProductPage",
                AppCustomProductPageLocalizationsGetInstanceFieldsAppCustomProductPageVersion.AppCustomProductPageLocalizations => "appCustomProductPageLocalizations",
                AppCustomProductPageLocalizationsGetInstanceFieldsAppCustomProductPageVersion.DeepLink => "deepLink",
                AppCustomProductPageLocalizationsGetInstanceFieldsAppCustomProductPageVersion.State => "state",
                AppCustomProductPageLocalizationsGetInstanceFieldsAppCustomProductPageVersion.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppCustomProductPageLocalizationsGetInstanceFieldsAppCustomProductPageVersion? ToEnum(string value)
        {
            return value switch
            {
                "appCustomProductPage" => AppCustomProductPageLocalizationsGetInstanceFieldsAppCustomProductPageVersion.AppCustomProductPage,
                "appCustomProductPageLocalizations" => AppCustomProductPageLocalizationsGetInstanceFieldsAppCustomProductPageVersion.AppCustomProductPageLocalizations,
                "deepLink" => AppCustomProductPageLocalizationsGetInstanceFieldsAppCustomProductPageVersion.DeepLink,
                "state" => AppCustomProductPageLocalizationsGetInstanceFieldsAppCustomProductPageVersion.State,
                "version" => AppCustomProductPageLocalizationsGetInstanceFieldsAppCustomProductPageVersion.Version,
                _ => null,
            };
        }
    }
}