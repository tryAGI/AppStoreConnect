
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppPreviewSetResponseIncludedItemDiscriminatorType
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
    public static class AppPreviewSetResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppPreviewSetResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                AppPreviewSetResponseIncludedItemDiscriminatorType.AppCustomProductPageLocalizations => "appCustomProductPageLocalizations",
                AppPreviewSetResponseIncludedItemDiscriminatorType.AppPreviews => "appPreviews",
                AppPreviewSetResponseIncludedItemDiscriminatorType.AppStoreVersionExperimentTreatmentLocalizations => "appStoreVersionExperimentTreatmentLocalizations",
                AppPreviewSetResponseIncludedItemDiscriminatorType.AppStoreVersionLocalizations => "appStoreVersionLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppPreviewSetResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "appCustomProductPageLocalizations" => AppPreviewSetResponseIncludedItemDiscriminatorType.AppCustomProductPageLocalizations,
                "appPreviews" => AppPreviewSetResponseIncludedItemDiscriminatorType.AppPreviews,
                "appStoreVersionExperimentTreatmentLocalizations" => AppPreviewSetResponseIncludedItemDiscriminatorType.AppStoreVersionExperimentTreatmentLocalizations,
                "appStoreVersionLocalizations" => AppPreviewSetResponseIncludedItemDiscriminatorType.AppStoreVersionLocalizations,
                _ => null,
            };
        }
    }
}