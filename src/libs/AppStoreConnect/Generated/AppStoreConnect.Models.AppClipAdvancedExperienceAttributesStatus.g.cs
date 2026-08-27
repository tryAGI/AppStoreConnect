
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppClipAdvancedExperienceAttributesStatus
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
    public static class AppClipAdvancedExperienceAttributesStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppClipAdvancedExperienceAttributesStatus value)
        {
            return value switch
            {
                AppClipAdvancedExperienceAttributesStatus.AppTransferInProgress => "APP_TRANSFER_IN_PROGRESS",
                AppClipAdvancedExperienceAttributesStatus.Deactivated => "DEACTIVATED",
                AppClipAdvancedExperienceAttributesStatus.Received => "RECEIVED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppClipAdvancedExperienceAttributesStatus? ToEnum(string value)
        {
            return value switch
            {
                "APP_TRANSFER_IN_PROGRESS" => AppClipAdvancedExperienceAttributesStatus.AppTransferInProgress,
                "DEACTIVATED" => AppClipAdvancedExperienceAttributesStatus.Deactivated,
                "RECEIVED" => AppClipAdvancedExperienceAttributesStatus.Received,
                _ => null,
            };
        }
    }
}