
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppStoreVersionReleaseRequestCreateRequestDataType
    {
        /// <summary>
        /// 
        /// </summary>
        AppStoreVersionReleaseRequests,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppStoreVersionReleaseRequestCreateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionReleaseRequestCreateRequestDataType value)
        {
            return value switch
            {
                AppStoreVersionReleaseRequestCreateRequestDataType.AppStoreVersionReleaseRequests => "appStoreVersionReleaseRequests",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionReleaseRequestCreateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "appStoreVersionReleaseRequests" => AppStoreVersionReleaseRequestCreateRequestDataType.AppStoreVersionReleaseRequests,
                _ => null,
            };
        }
    }
}