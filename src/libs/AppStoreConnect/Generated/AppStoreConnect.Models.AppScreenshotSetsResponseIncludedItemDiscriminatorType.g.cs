
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppScreenshotSetsResponseIncludedItemDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        AppCustomProductPageLocalizations,
        /// <summary>
        ///
        /// </summary>
        AppScreenshots,
        /// <summary>
        ///
        /// </summary>
        AppStoreVersionExperimentTreatmentLocalizations,
        /// <summary>
        ///
        /// </summary>
        AppStoreVersionLocalizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppScreenshotSetsResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppScreenshotSetsResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                AppScreenshotSetsResponseIncludedItemDiscriminatorType.AppCustomProductPageLocalizations => "appCustomProductPageLocalizations",
                AppScreenshotSetsResponseIncludedItemDiscriminatorType.AppScreenshots => "appScreenshots",
                AppScreenshotSetsResponseIncludedItemDiscriminatorType.AppStoreVersionExperimentTreatmentLocalizations => "appStoreVersionExperimentTreatmentLocalizations",
                AppScreenshotSetsResponseIncludedItemDiscriminatorType.AppStoreVersionLocalizations => "appStoreVersionLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppScreenshotSetsResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "appCustomProductPageLocalizations" => AppScreenshotSetsResponseIncludedItemDiscriminatorType.AppCustomProductPageLocalizations,
                "appScreenshots" => AppScreenshotSetsResponseIncludedItemDiscriminatorType.AppScreenshots,
                "appStoreVersionExperimentTreatmentLocalizations" => AppScreenshotSetsResponseIncludedItemDiscriminatorType.AppStoreVersionExperimentTreatmentLocalizations,
                "appStoreVersionLocalizations" => AppScreenshotSetsResponseIncludedItemDiscriminatorType.AppStoreVersionLocalizations,
                _ => null,
            };
        }
    }
}