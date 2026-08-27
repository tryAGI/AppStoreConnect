
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppsGetCollectionFieldsAppCustomProductPage
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
    public static class AppsGetCollectionFieldsAppCustomProductPageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsGetCollectionFieldsAppCustomProductPage value)
        {
            return value switch
            {
                AppsGetCollectionFieldsAppCustomProductPage.App => "app",
                AppsGetCollectionFieldsAppCustomProductPage.AppCustomProductPageVersions => "appCustomProductPageVersions",
                AppsGetCollectionFieldsAppCustomProductPage.Name => "name",
                AppsGetCollectionFieldsAppCustomProductPage.Url => "url",
                AppsGetCollectionFieldsAppCustomProductPage.Visible => "visible",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsGetCollectionFieldsAppCustomProductPage? ToEnum(string value)
        {
            return value switch
            {
                "app" => AppsGetCollectionFieldsAppCustomProductPage.App,
                "appCustomProductPageVersions" => AppsGetCollectionFieldsAppCustomProductPage.AppCustomProductPageVersions,
                "name" => AppsGetCollectionFieldsAppCustomProductPage.Name,
                "url" => AppsGetCollectionFieldsAppCustomProductPage.Url,
                "visible" => AppsGetCollectionFieldsAppCustomProductPage.Visible,
                _ => null,
            };
        }
    }
}