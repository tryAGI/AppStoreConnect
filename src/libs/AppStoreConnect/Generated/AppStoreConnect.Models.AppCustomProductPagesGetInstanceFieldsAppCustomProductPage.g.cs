
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppCustomProductPagesGetInstanceFieldsAppCustomProductPage
    {
        /// <summary>
        ///
        /// </summary>
        App,
        /// <summary>
        ///
        /// </summary>
        AppCustomProductPageVersions,
        /// <summary>
        ///
        /// </summary>
        Name,
        /// <summary>
        ///
        /// </summary>
        Url,
        /// <summary>
        ///
        /// </summary>
        Visible,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppCustomProductPagesGetInstanceFieldsAppCustomProductPageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppCustomProductPagesGetInstanceFieldsAppCustomProductPage value)
        {
            return value switch
            {
                AppCustomProductPagesGetInstanceFieldsAppCustomProductPage.App => "app",
                AppCustomProductPagesGetInstanceFieldsAppCustomProductPage.AppCustomProductPageVersions => "appCustomProductPageVersions",
                AppCustomProductPagesGetInstanceFieldsAppCustomProductPage.Name => "name",
                AppCustomProductPagesGetInstanceFieldsAppCustomProductPage.Url => "url",
                AppCustomProductPagesGetInstanceFieldsAppCustomProductPage.Visible => "visible",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppCustomProductPagesGetInstanceFieldsAppCustomProductPage? ToEnum(string value)
        {
            return value switch
            {
                "app" => AppCustomProductPagesGetInstanceFieldsAppCustomProductPage.App,
                "appCustomProductPageVersions" => AppCustomProductPagesGetInstanceFieldsAppCustomProductPage.AppCustomProductPageVersions,
                "name" => AppCustomProductPagesGetInstanceFieldsAppCustomProductPage.Name,
                "url" => AppCustomProductPagesGetInstanceFieldsAppCustomProductPage.Url,
                "visible" => AppCustomProductPagesGetInstanceFieldsAppCustomProductPage.Visible,
                _ => null,
            };
        }
    }
}