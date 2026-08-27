
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppCustomProductPagesGetInstanceFieldsAppCustomProductPageVersion
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
    public static class AppCustomProductPagesGetInstanceFieldsAppCustomProductPageVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppCustomProductPagesGetInstanceFieldsAppCustomProductPageVersion value)
        {
            return value switch
            {
                AppCustomProductPagesGetInstanceFieldsAppCustomProductPageVersion.AppCustomProductPage => "appCustomProductPage",
                AppCustomProductPagesGetInstanceFieldsAppCustomProductPageVersion.AppCustomProductPageLocalizations => "appCustomProductPageLocalizations",
                AppCustomProductPagesGetInstanceFieldsAppCustomProductPageVersion.DeepLink => "deepLink",
                AppCustomProductPagesGetInstanceFieldsAppCustomProductPageVersion.State => "state",
                AppCustomProductPagesGetInstanceFieldsAppCustomProductPageVersion.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppCustomProductPagesGetInstanceFieldsAppCustomProductPageVersion? ToEnum(string value)
        {
            return value switch
            {
                "appCustomProductPage" => AppCustomProductPagesGetInstanceFieldsAppCustomProductPageVersion.AppCustomProductPage,
                "appCustomProductPageLocalizations" => AppCustomProductPagesGetInstanceFieldsAppCustomProductPageVersion.AppCustomProductPageLocalizations,
                "deepLink" => AppCustomProductPagesGetInstanceFieldsAppCustomProductPageVersion.DeepLink,
                "state" => AppCustomProductPagesGetInstanceFieldsAppCustomProductPageVersion.State,
                "version" => AppCustomProductPagesGetInstanceFieldsAppCustomProductPageVersion.Version,
                _ => null,
            };
        }
    }
}