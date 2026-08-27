
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppsAppCustomProductPagesGetToManyRelatedFieldsAppCustomProductPageVersion
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
    public static class AppsAppCustomProductPagesGetToManyRelatedFieldsAppCustomProductPageVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsAppCustomProductPagesGetToManyRelatedFieldsAppCustomProductPageVersion value)
        {
            return value switch
            {
                AppsAppCustomProductPagesGetToManyRelatedFieldsAppCustomProductPageVersion.AppCustomProductPage => "appCustomProductPage",
                AppsAppCustomProductPagesGetToManyRelatedFieldsAppCustomProductPageVersion.AppCustomProductPageLocalizations => "appCustomProductPageLocalizations",
                AppsAppCustomProductPagesGetToManyRelatedFieldsAppCustomProductPageVersion.DeepLink => "deepLink",
                AppsAppCustomProductPagesGetToManyRelatedFieldsAppCustomProductPageVersion.State => "state",
                AppsAppCustomProductPagesGetToManyRelatedFieldsAppCustomProductPageVersion.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsAppCustomProductPagesGetToManyRelatedFieldsAppCustomProductPageVersion? ToEnum(string value)
        {
            return value switch
            {
                "appCustomProductPage" => AppsAppCustomProductPagesGetToManyRelatedFieldsAppCustomProductPageVersion.AppCustomProductPage,
                "appCustomProductPageLocalizations" => AppsAppCustomProductPagesGetToManyRelatedFieldsAppCustomProductPageVersion.AppCustomProductPageLocalizations,
                "deepLink" => AppsAppCustomProductPagesGetToManyRelatedFieldsAppCustomProductPageVersion.DeepLink,
                "state" => AppsAppCustomProductPagesGetToManyRelatedFieldsAppCustomProductPageVersion.State,
                "version" => AppsAppCustomProductPagesGetToManyRelatedFieldsAppCustomProductPageVersion.Version,
                _ => null,
            };
        }
    }
}