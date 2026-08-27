
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppCustomProductPagesAppCustomProductPageVersionsGetToManyRelatedFieldsAppCustomProductPageVersion
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
    public static class AppCustomProductPagesAppCustomProductPageVersionsGetToManyRelatedFieldsAppCustomProductPageVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppCustomProductPagesAppCustomProductPageVersionsGetToManyRelatedFieldsAppCustomProductPageVersion value)
        {
            return value switch
            {
                AppCustomProductPagesAppCustomProductPageVersionsGetToManyRelatedFieldsAppCustomProductPageVersion.AppCustomProductPage => "appCustomProductPage",
                AppCustomProductPagesAppCustomProductPageVersionsGetToManyRelatedFieldsAppCustomProductPageVersion.AppCustomProductPageLocalizations => "appCustomProductPageLocalizations",
                AppCustomProductPagesAppCustomProductPageVersionsGetToManyRelatedFieldsAppCustomProductPageVersion.DeepLink => "deepLink",
                AppCustomProductPagesAppCustomProductPageVersionsGetToManyRelatedFieldsAppCustomProductPageVersion.State => "state",
                AppCustomProductPagesAppCustomProductPageVersionsGetToManyRelatedFieldsAppCustomProductPageVersion.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppCustomProductPagesAppCustomProductPageVersionsGetToManyRelatedFieldsAppCustomProductPageVersion? ToEnum(string value)
        {
            return value switch
            {
                "appCustomProductPage" => AppCustomProductPagesAppCustomProductPageVersionsGetToManyRelatedFieldsAppCustomProductPageVersion.AppCustomProductPage,
                "appCustomProductPageLocalizations" => AppCustomProductPagesAppCustomProductPageVersionsGetToManyRelatedFieldsAppCustomProductPageVersion.AppCustomProductPageLocalizations,
                "deepLink" => AppCustomProductPagesAppCustomProductPageVersionsGetToManyRelatedFieldsAppCustomProductPageVersion.DeepLink,
                "state" => AppCustomProductPagesAppCustomProductPageVersionsGetToManyRelatedFieldsAppCustomProductPageVersion.State,
                "version" => AppCustomProductPagesAppCustomProductPageVersionsGetToManyRelatedFieldsAppCustomProductPageVersion.Version,
                _ => null,
            };
        }
    }
}