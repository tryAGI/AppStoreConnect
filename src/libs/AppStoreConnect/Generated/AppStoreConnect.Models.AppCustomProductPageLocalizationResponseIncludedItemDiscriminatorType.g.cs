
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppCustomProductPageLocalizationResponseIncludedItemDiscriminatorType
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
    public static class AppCustomProductPageLocalizationResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppCustomProductPageLocalizationResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                AppCustomProductPageLocalizationResponseIncludedItemDiscriminatorType.AppCustomProductPageVersions => "appCustomProductPageVersions",
                AppCustomProductPageLocalizationResponseIncludedItemDiscriminatorType.AppKeywords => "appKeywords",
                AppCustomProductPageLocalizationResponseIncludedItemDiscriminatorType.AppPreviewSets => "appPreviewSets",
                AppCustomProductPageLocalizationResponseIncludedItemDiscriminatorType.AppScreenshotSets => "appScreenshotSets",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppCustomProductPageLocalizationResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "appCustomProductPageVersions" => AppCustomProductPageLocalizationResponseIncludedItemDiscriminatorType.AppCustomProductPageVersions,
                "appKeywords" => AppCustomProductPageLocalizationResponseIncludedItemDiscriminatorType.AppKeywords,
                "appPreviewSets" => AppCustomProductPageLocalizationResponseIncludedItemDiscriminatorType.AppPreviewSets,
                "appScreenshotSets" => AppCustomProductPageLocalizationResponseIncludedItemDiscriminatorType.AppScreenshotSets,
                _ => null,
            };
        }
    }
}