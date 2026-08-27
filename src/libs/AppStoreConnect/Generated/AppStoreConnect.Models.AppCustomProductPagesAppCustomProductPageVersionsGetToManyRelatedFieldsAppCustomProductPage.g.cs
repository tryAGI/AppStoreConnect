
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppCustomProductPagesAppCustomProductPageVersionsGetToManyRelatedFieldsAppCustomProductPage
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
    public static class AppCustomProductPagesAppCustomProductPageVersionsGetToManyRelatedFieldsAppCustomProductPageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppCustomProductPagesAppCustomProductPageVersionsGetToManyRelatedFieldsAppCustomProductPage value)
        {
            return value switch
            {
                AppCustomProductPagesAppCustomProductPageVersionsGetToManyRelatedFieldsAppCustomProductPage.App => "app",
                AppCustomProductPagesAppCustomProductPageVersionsGetToManyRelatedFieldsAppCustomProductPage.AppCustomProductPageVersions => "appCustomProductPageVersions",
                AppCustomProductPagesAppCustomProductPageVersionsGetToManyRelatedFieldsAppCustomProductPage.Name => "name",
                AppCustomProductPagesAppCustomProductPageVersionsGetToManyRelatedFieldsAppCustomProductPage.Url => "url",
                AppCustomProductPagesAppCustomProductPageVersionsGetToManyRelatedFieldsAppCustomProductPage.Visible => "visible",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppCustomProductPagesAppCustomProductPageVersionsGetToManyRelatedFieldsAppCustomProductPage? ToEnum(string value)
        {
            return value switch
            {
                "app" => AppCustomProductPagesAppCustomProductPageVersionsGetToManyRelatedFieldsAppCustomProductPage.App,
                "appCustomProductPageVersions" => AppCustomProductPagesAppCustomProductPageVersionsGetToManyRelatedFieldsAppCustomProductPage.AppCustomProductPageVersions,
                "name" => AppCustomProductPagesAppCustomProductPageVersionsGetToManyRelatedFieldsAppCustomProductPage.Name,
                "url" => AppCustomProductPagesAppCustomProductPageVersionsGetToManyRelatedFieldsAppCustomProductPage.Url,
                "visible" => AppCustomProductPagesAppCustomProductPageVersionsGetToManyRelatedFieldsAppCustomProductPage.Visible,
                _ => null,
            };
        }
    }
}