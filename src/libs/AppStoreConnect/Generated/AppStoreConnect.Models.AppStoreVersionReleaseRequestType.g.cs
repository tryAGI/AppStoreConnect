
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppStoreVersionReleaseRequestType
    {
        /// <summary>
        /// 
        /// </summary>
        AppStoreVersionReleaseRequests,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppStoreVersionReleaseRequestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionReleaseRequestType value)
        {
            return value switch
            {
                AppStoreVersionReleaseRequestType.AppStoreVersionReleaseRequests => "appStoreVersionReleaseRequests",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionReleaseRequestType? ToEnum(string value)
        {
            return value switch
            {
                "appStoreVersionReleaseRequests" => AppStoreVersionReleaseRequestType.AppStoreVersionReleaseRequests,
                _ => null,
            };
        }
    }
}