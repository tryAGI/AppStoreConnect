
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppsGetInstanceFieldsAppCustomProductPage
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
    public static class AppsGetInstanceFieldsAppCustomProductPageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsGetInstanceFieldsAppCustomProductPage value)
        {
            return value switch
            {
                AppsGetInstanceFieldsAppCustomProductPage.App => "app",
                AppsGetInstanceFieldsAppCustomProductPage.AppCustomProductPageVersions => "appCustomProductPageVersions",
                AppsGetInstanceFieldsAppCustomProductPage.Name => "name",
                AppsGetInstanceFieldsAppCustomProductPage.Url => "url",
                AppsGetInstanceFieldsAppCustomProductPage.Visible => "visible",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsGetInstanceFieldsAppCustomProductPage? ToEnum(string value)
        {
            return value switch
            {
                "app" => AppsGetInstanceFieldsAppCustomProductPage.App,
                "appCustomProductPageVersions" => AppsGetInstanceFieldsAppCustomProductPage.AppCustomProductPageVersions,
                "name" => AppsGetInstanceFieldsAppCustomProductPage.Name,
                "url" => AppsGetInstanceFieldsAppCustomProductPage.Url,
                "visible" => AppsGetInstanceFieldsAppCustomProductPage.Visible,
                _ => null,
            };
        }
    }
}