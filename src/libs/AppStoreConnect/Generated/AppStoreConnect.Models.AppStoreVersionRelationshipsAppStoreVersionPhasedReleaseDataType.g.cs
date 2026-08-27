
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppStoreVersionRelationshipsAppStoreVersionPhasedReleaseDataType
    {
        /// <summary>
        ///
        /// </summary>
        AppStoreVersionPhasedReleases,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppStoreVersionRelationshipsAppStoreVersionPhasedReleaseDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionRelationshipsAppStoreVersionPhasedReleaseDataType value)
        {
            return value switch
            {
                AppStoreVersionRelationshipsAppStoreVersionPhasedReleaseDataType.AppStoreVersionPhasedReleases => "appStoreVersionPhasedReleases",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionRelationshipsAppStoreVersionPhasedReleaseDataType? ToEnum(string value)
        {
            return value switch
            {
                "appStoreVersionPhasedReleases" => AppStoreVersionRelationshipsAppStoreVersionPhasedReleaseDataType.AppStoreVersionPhasedReleases,
                _ => null,
            };
        }
    }
}