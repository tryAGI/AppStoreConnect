
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppCustomProductPageLocalizationsResponseIncludedItemDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        AppCustomProductPageVersions,
        /// <summary>
        ///
        /// </summary>
        AppKeywords,
        /// <summary>
        ///
        /// </summary>
        AppPreviewSets,
        /// <summary>
        ///
        /// </summary>
        AppScreenshotSets,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppCustomProductPageLocalizationsResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppCustomProductPageLocalizationsResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                AppCustomProductPageLocalizationsResponseIncludedItemDiscriminatorType.AppCustomProductPageVersions => "appCustomProductPageVersions",
                AppCustomProductPageLocalizationsResponseIncludedItemDiscriminatorType.AppKeywords => "appKeywords",
                AppCustomProductPageLocalizationsResponseIncludedItemDiscriminatorType.AppPreviewSets => "appPreviewSets",
                AppCustomProductPageLocalizationsResponseIncludedItemDiscriminatorType.AppScreenshotSets => "appScreenshotSets",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppCustomProductPageLocalizationsResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "appCustomProductPageVersions" => AppCustomProductPageLocalizationsResponseIncludedItemDiscriminatorType.AppCustomProductPageVersions,
                "appKeywords" => AppCustomProductPageLocalizationsResponseIncludedItemDiscriminatorType.AppKeywords,
                "appPreviewSets" => AppCustomProductPageLocalizationsResponseIncludedItemDiscriminatorType.AppPreviewSets,
                "appScreenshotSets" => AppCustomProductPageLocalizationsResponseIncludedItemDiscriminatorType.AppScreenshotSets,
                _ => null,
            };
        }
    }
}