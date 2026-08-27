
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppPreviewSetsResponseIncludedItemDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        AppCustomProductPageLocalizations,
        /// <summary>
        ///
        /// </summary>
        AppPreviews,
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
    public static class AppPreviewSetsResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppPreviewSetsResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                AppPreviewSetsResponseIncludedItemDiscriminatorType.AppCustomProductPageLocalizations => "appCustomProductPageLocalizations",
                AppPreviewSetsResponseIncludedItemDiscriminatorType.AppPreviews => "appPreviews",
                AppPreviewSetsResponseIncludedItemDiscriminatorType.AppStoreVersionExperimentTreatmentLocalizations => "appStoreVersionExperimentTreatmentLocalizations",
                AppPreviewSetsResponseIncludedItemDiscriminatorType.AppStoreVersionLocalizations => "appStoreVersionLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppPreviewSetsResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "appCustomProductPageLocalizations" => AppPreviewSetsResponseIncludedItemDiscriminatorType.AppCustomProductPageLocalizations,
                "appPreviews" => AppPreviewSetsResponseIncludedItemDiscriminatorType.AppPreviews,
                "appStoreVersionExperimentTreatmentLocalizations" => AppPreviewSetsResponseIncludedItemDiscriminatorType.AppStoreVersionExperimentTreatmentLocalizations,
                "appStoreVersionLocalizations" => AppPreviewSetsResponseIncludedItemDiscriminatorType.AppStoreVersionLocalizations,
                _ => null,
            };
        }
    }
}