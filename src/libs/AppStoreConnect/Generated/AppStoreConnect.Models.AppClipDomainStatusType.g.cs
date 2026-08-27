
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppClipDomainStatusType
    {
        /// <summary>
        /// 
        /// </summary>
        AppClipDomainStatuses,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppClipDomainStatusTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppClipDomainStatusType value)
        {
            return value switch
            {
                AppClipDomainStatusType.AppClipDomainStatuses => "appClipDomainStatuses",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppClipDomainStatusType? ToEnum(string value)
        {
            return value switch
            {
                "appClipDomainStatuses" => AppClipDomainStatusType.AppClipDomainStatuses,
                _ => null,
            };
        }
    }
}