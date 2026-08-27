
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppStoreVersionCreateRequestDataAttributesReleaseType
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
    public static class AppStoreVersionCreateRequestDataAttributesReleaseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionCreateRequestDataAttributesReleaseType value)
        {
            return value switch
            {
                AppStoreVersionCreateRequestDataAttributesReleaseType.AfterApproval => "AFTER_APPROVAL",
                AppStoreVersionCreateRequestDataAttributesReleaseType.Manual => "MANUAL",
                AppStoreVersionCreateRequestDataAttributesReleaseType.Scheduled => "SCHEDULED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionCreateRequestDataAttributesReleaseType? ToEnum(string value)
        {
            return value switch
            {
                "AFTER_APPROVAL" => AppStoreVersionCreateRequestDataAttributesReleaseType.AfterApproval,
                "MANUAL" => AppStoreVersionCreateRequestDataAttributesReleaseType.Manual,
                "SCHEDULED" => AppStoreVersionCreateRequestDataAttributesReleaseType.Scheduled,
                _ => null,
            };
        }
    }
}