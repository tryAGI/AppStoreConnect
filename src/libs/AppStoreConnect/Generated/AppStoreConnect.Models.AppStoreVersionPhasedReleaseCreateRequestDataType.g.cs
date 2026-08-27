
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppStoreVersionPhasedReleaseCreateRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        AppStoreVersionPhasedReleases,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppStoreVersionPhasedReleaseCreateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionPhasedReleaseCreateRequestDataType value)
        {
            return value switch
            {
                AppStoreVersionPhasedReleaseCreateRequestDataType.AppStoreVersionPhasedReleases => "appStoreVersionPhasedReleases",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionPhasedReleaseCreateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "appStoreVersionPhasedReleases" => AppStoreVersionPhasedReleaseCreateRequestDataType.AppStoreVersionPhasedReleases,
                _ => null,
            };
        }
    }
}