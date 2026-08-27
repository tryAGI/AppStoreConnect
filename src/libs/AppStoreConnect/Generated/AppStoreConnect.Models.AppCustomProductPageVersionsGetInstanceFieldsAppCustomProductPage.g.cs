
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppCustomProductPageVersionsGetInstanceFieldsAppCustomProductPage
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
    public static class AppCustomProductPageVersionsGetInstanceFieldsAppCustomProductPageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppCustomProductPageVersionsGetInstanceFieldsAppCustomProductPage value)
        {
            return value switch
            {
                AppCustomProductPageVersionsGetInstanceFieldsAppCustomProductPage.App => "app",
                AppCustomProductPageVersionsGetInstanceFieldsAppCustomProductPage.AppCustomProductPageVersions => "appCustomProductPageVersions",
                AppCustomProductPageVersionsGetInstanceFieldsAppCustomProductPage.Name => "name",
                AppCustomProductPageVersionsGetInstanceFieldsAppCustomProductPage.Url => "url",
                AppCustomProductPageVersionsGetInstanceFieldsAppCustomProductPage.Visible => "visible",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppCustomProductPageVersionsGetInstanceFieldsAppCustomProductPage? ToEnum(string value)
        {
            return value switch
            {
                "app" => AppCustomProductPageVersionsGetInstanceFieldsAppCustomProductPage.App,
                "appCustomProductPageVersions" => AppCustomProductPageVersionsGetInstanceFieldsAppCustomProductPage.AppCustomProductPageVersions,
                "name" => AppCustomProductPageVersionsGetInstanceFieldsAppCustomProductPage.Name,
                "url" => AppCustomProductPageVersionsGetInstanceFieldsAppCustomProductPage.Url,
                "visible" => AppCustomProductPageVersionsGetInstanceFieldsAppCustomProductPage.Visible,
                _ => null,
            };
        }
    }
}