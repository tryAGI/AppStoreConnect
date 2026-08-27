
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppsAppCustomProductPagesGetToManyRelatedFieldsAppCustomProductPage
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
    public static class AppsAppCustomProductPagesGetToManyRelatedFieldsAppCustomProductPageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsAppCustomProductPagesGetToManyRelatedFieldsAppCustomProductPage value)
        {
            return value switch
            {
                AppsAppCustomProductPagesGetToManyRelatedFieldsAppCustomProductPage.App => "app",
                AppsAppCustomProductPagesGetToManyRelatedFieldsAppCustomProductPage.AppCustomProductPageVersions => "appCustomProductPageVersions",
                AppsAppCustomProductPagesGetToManyRelatedFieldsAppCustomProductPage.Name => "name",
                AppsAppCustomProductPagesGetToManyRelatedFieldsAppCustomProductPage.Url => "url",
                AppsAppCustomProductPagesGetToManyRelatedFieldsAppCustomProductPage.Visible => "visible",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsAppCustomProductPagesGetToManyRelatedFieldsAppCustomProductPage? ToEnum(string value)
        {
            return value switch
            {
                "app" => AppsAppCustomProductPagesGetToManyRelatedFieldsAppCustomProductPage.App,
                "appCustomProductPageVersions" => AppsAppCustomProductPagesGetToManyRelatedFieldsAppCustomProductPage.AppCustomProductPageVersions,
                "name" => AppsAppCustomProductPagesGetToManyRelatedFieldsAppCustomProductPage.Name,
                "url" => AppsAppCustomProductPagesGetToManyRelatedFieldsAppCustomProductPage.Url,
                "visible" => AppsAppCustomProductPagesGetToManyRelatedFieldsAppCustomProductPage.Visible,
                _ => null,
            };
        }
    }
}