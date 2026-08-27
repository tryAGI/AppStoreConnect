
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppClipsAppClipAdvancedExperiencesGetToManyRelatedFilterStatu
    {
        /// <summary>
        ///
        /// </summary>
        AppTransferInProgress,
        /// <summary>
        ///
        /// </summary>
        Deactivated,
        /// <summary>
        ///
        /// </summary>
        Received,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppClipsAppClipAdvancedExperiencesGetToManyRelatedFilterStatuExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppClipsAppClipAdvancedExperiencesGetToManyRelatedFilterStatu value)
        {
            return value switch
            {
                AppClipsAppClipAdvancedExperiencesGetToManyRelatedFilterStatu.AppTransferInProgress => "APP_TRANSFER_IN_PROGRESS",
                AppClipsAppClipAdvancedExperiencesGetToManyRelatedFilterStatu.Deactivated => "DEACTIVATED",
                AppClipsAppClipAdvancedExperiencesGetToManyRelatedFilterStatu.Received => "RECEIVED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppClipsAppClipAdvancedExperiencesGetToManyRelatedFilterStatu? ToEnum(string value)
        {
            return value switch
            {
                "APP_TRANSFER_IN_PROGRESS" => AppClipsAppClipAdvancedExperiencesGetToManyRelatedFilterStatu.AppTransferInProgress,
                "DEACTIVATED" => AppClipsAppClipAdvancedExperiencesGetToManyRelatedFilterStatu.Deactivated,
                "RECEIVED" => AppClipsAppClipAdvancedExperiencesGetToManyRelatedFilterStatu.Received,
                _ => null,
            };
        }
    }
}