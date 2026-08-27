
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppScreenshotSetResponseIncludedItemDiscriminatorType
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
    public static class AppScreenshotSetResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppScreenshotSetResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                AppScreenshotSetResponseIncludedItemDiscriminatorType.AppCustomProductPageLocalizations => "appCustomProductPageLocalizations",
                AppScreenshotSetResponseIncludedItemDiscriminatorType.AppScreenshots => "appScreenshots",
                AppScreenshotSetResponseIncludedItemDiscriminatorType.AppStoreVersionExperimentTreatmentLocalizations => "appStoreVersionExperimentTreatmentLocalizations",
                AppScreenshotSetResponseIncludedItemDiscriminatorType.AppStoreVersionLocalizations => "appStoreVersionLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppScreenshotSetResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "appCustomProductPageLocalizations" => AppScreenshotSetResponseIncludedItemDiscriminatorType.AppCustomProductPageLocalizations,
                "appScreenshots" => AppScreenshotSetResponseIncludedItemDiscriminatorType.AppScreenshots,
                "appStoreVersionExperimentTreatmentLocalizations" => AppScreenshotSetResponseIncludedItemDiscriminatorType.AppStoreVersionExperimentTreatmentLocalizations,
                "appStoreVersionLocalizations" => AppScreenshotSetResponseIncludedItemDiscriminatorType.AppStoreVersionLocalizations,
                _ => null,
            };
        }
    }
}