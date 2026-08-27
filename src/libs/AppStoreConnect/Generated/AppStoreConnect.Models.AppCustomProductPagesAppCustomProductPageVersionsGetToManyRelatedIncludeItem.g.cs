
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppCustomProductPagesAppCustomProductPageVersionsGetToManyRelatedIncludeItem
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
    public static class AppCustomProductPagesAppCustomProductPageVersionsGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppCustomProductPagesAppCustomProductPageVersionsGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                AppCustomProductPagesAppCustomProductPageVersionsGetToManyRelatedIncludeItem.AppCustomProductPage => "appCustomProductPage",
                AppCustomProductPagesAppCustomProductPageVersionsGetToManyRelatedIncludeItem.AppCustomProductPageLocalizations => "appCustomProductPageLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppCustomProductPagesAppCustomProductPageVersionsGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "appCustomProductPage" => AppCustomProductPagesAppCustomProductPageVersionsGetToManyRelatedIncludeItem.AppCustomProductPage,
                "appCustomProductPageLocalizations" => AppCustomProductPagesAppCustomProductPageVersionsGetToManyRelatedIncludeItem.AppCustomProductPageLocalizations,
                _ => null,
            };
        }
    }
}