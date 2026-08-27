
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppStoreVersionAttributesReleaseType
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
    public static class AppStoreVersionAttributesReleaseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionAttributesReleaseType value)
        {
            return value switch
            {
                AppStoreVersionAttributesReleaseType.AfterApproval => "AFTER_APPROVAL",
                AppStoreVersionAttributesReleaseType.Manual => "MANUAL",
                AppStoreVersionAttributesReleaseType.Scheduled => "SCHEDULED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionAttributesReleaseType? ToEnum(string value)
        {
            return value switch
            {
                "AFTER_APPROVAL" => AppStoreVersionAttributesReleaseType.AfterApproval,
                "MANUAL" => AppStoreVersionAttributesReleaseType.Manual,
                "SCHEDULED" => AppStoreVersionAttributesReleaseType.Scheduled,
                _ => null,
            };
        }
    }
}