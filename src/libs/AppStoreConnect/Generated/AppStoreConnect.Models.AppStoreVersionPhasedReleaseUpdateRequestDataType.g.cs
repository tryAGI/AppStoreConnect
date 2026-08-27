
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppStoreVersionPhasedReleaseUpdateRequestDataType
    {
        /// <summary>
        /// 
        /// </summary>
        AppStoreVersionPhasedReleases,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppStoreVersionPhasedReleaseUpdateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionPhasedReleaseUpdateRequestDataType value)
        {
            return value switch
            {
                AppStoreVersionPhasedReleaseUpdateRequestDataType.AppStoreVersionPhasedReleases => "appStoreVersionPhasedReleases",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionPhasedReleaseUpdateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "appStoreVersionPhasedReleases" => AppStoreVersionPhasedReleaseUpdateRequestDataType.AppStoreVersionPhasedReleases,
                _ => null,
            };
        }
    }
}