
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppCustomProductPageVersionsGetInstanceFieldsAppCustomProductPageVersion
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
    public static class AppCustomProductPageVersionsGetInstanceFieldsAppCustomProductPageVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppCustomProductPageVersionsGetInstanceFieldsAppCustomProductPageVersion value)
        {
            return value switch
            {
                AppCustomProductPageVersionsGetInstanceFieldsAppCustomProductPageVersion.AppCustomProductPage => "appCustomProductPage",
                AppCustomProductPageVersionsGetInstanceFieldsAppCustomProductPageVersion.AppCustomProductPageLocalizations => "appCustomProductPageLocalizations",
                AppCustomProductPageVersionsGetInstanceFieldsAppCustomProductPageVersion.DeepLink => "deepLink",
                AppCustomProductPageVersionsGetInstanceFieldsAppCustomProductPageVersion.State => "state",
                AppCustomProductPageVersionsGetInstanceFieldsAppCustomProductPageVersion.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppCustomProductPageVersionsGetInstanceFieldsAppCustomProductPageVersion? ToEnum(string value)
        {
            return value switch
            {
                "appCustomProductPage" => AppCustomProductPageVersionsGetInstanceFieldsAppCustomProductPageVersion.AppCustomProductPage,
                "appCustomProductPageLocalizations" => AppCustomProductPageVersionsGetInstanceFieldsAppCustomProductPageVersion.AppCustomProductPageLocalizations,
                "deepLink" => AppCustomProductPageVersionsGetInstanceFieldsAppCustomProductPageVersion.DeepLink,
                "state" => AppCustomProductPageVersionsGetInstanceFieldsAppCustomProductPageVersion.State,
                "version" => AppCustomProductPageVersionsGetInstanceFieldsAppCustomProductPageVersion.Version,
                _ => null,
            };
        }
    }
}