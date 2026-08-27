
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppStoreVersionUpdateRequestDataAttributesReleaseType
    {
        /// <summary>
        ///
        /// </summary>
        AfterApproval,
        /// <summary>
        ///
        /// </summary>
        Manual,
        /// <summary>
        ///
        /// </summary>
        Scheduled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppStoreVersionUpdateRequestDataAttributesReleaseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionUpdateRequestDataAttributesReleaseType value)
        {
            return value switch
            {
                AppStoreVersionUpdateRequestDataAttributesReleaseType.AfterApproval => "AFTER_APPROVAL",
                AppStoreVersionUpdateRequestDataAttributesReleaseType.Manual => "MANUAL",
                AppStoreVersionUpdateRequestDataAttributesReleaseType.Scheduled => "SCHEDULED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionUpdateRequestDataAttributesReleaseType? ToEnum(string value)
        {
            return value switch
            {
                "AFTER_APPROVAL" => AppStoreVersionUpdateRequestDataAttributesReleaseType.AfterApproval,
                "MANUAL" => AppStoreVersionUpdateRequestDataAttributesReleaseType.Manual,
                "SCHEDULED" => AppStoreVersionUpdateRequestDataAttributesReleaseType.Scheduled,
                _ => null,
            };
        }
    }
}