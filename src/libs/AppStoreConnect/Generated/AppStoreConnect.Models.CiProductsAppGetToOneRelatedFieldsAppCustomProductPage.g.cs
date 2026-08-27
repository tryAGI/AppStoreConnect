
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CiProductsAppGetToOneRelatedFieldsAppCustomProductPage
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
    public static class CiProductsAppGetToOneRelatedFieldsAppCustomProductPageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiProductsAppGetToOneRelatedFieldsAppCustomProductPage value)
        {
            return value switch
            {
                CiProductsAppGetToOneRelatedFieldsAppCustomProductPage.App => "app",
                CiProductsAppGetToOneRelatedFieldsAppCustomProductPage.AppCustomProductPageVersions => "appCustomProductPageVersions",
                CiProductsAppGetToOneRelatedFieldsAppCustomProductPage.Name => "name",
                CiProductsAppGetToOneRelatedFieldsAppCustomProductPage.Url => "url",
                CiProductsAppGetToOneRelatedFieldsAppCustomProductPage.Visible => "visible",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiProductsAppGetToOneRelatedFieldsAppCustomProductPage? ToEnum(string value)
        {
            return value switch
            {
                "app" => CiProductsAppGetToOneRelatedFieldsAppCustomProductPage.App,
                "appCustomProductPageVersions" => CiProductsAppGetToOneRelatedFieldsAppCustomProductPage.AppCustomProductPageVersions,
                "name" => CiProductsAppGetToOneRelatedFieldsAppCustomProductPage.Name,
                "url" => CiProductsAppGetToOneRelatedFieldsAppCustomProductPage.Url,
                "visible" => CiProductsAppGetToOneRelatedFieldsAppCustomProductPage.Visible,
                _ => null,
            };
        }
    }
}