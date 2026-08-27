
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppCustomProductPageVersionsGetInstanceIncludeItem
    {
        /// <summary>
        /// 
        /// </summary>
        AppCustomProductPage,
        /// <summary>
        /// 
        /// </summary>
        AppCustomProductPageLocalizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppCustomProductPageVersionsGetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppCustomProductPageVersionsGetInstanceIncludeItem value)
        {
            return value switch
            {
                AppCustomProductPageVersionsGetInstanceIncludeItem.AppCustomProductPage => "appCustomProductPage",
                AppCustomProductPageVersionsGetInstanceIncludeItem.AppCustomProductPageLocalizations => "appCustomProductPageLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppCustomProductPageVersionsGetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "appCustomProductPage" => AppCustomProductPageVersionsGetInstanceIncludeItem.AppCustomProductPage,
                "appCustomProductPageLocalizations" => AppCustomProductPageVersionsGetInstanceIncludeItem.AppCustomProductPageLocalizations,
                _ => null,
            };
        }
    }
}