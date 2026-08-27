
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppStoreVersionAppStoreVersionPhasedReleaseLinkageResponseDataType
    {
        /// <summary>
        ///
        /// </summary>
        AppStoreVersionPhasedReleases,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppStoreVersionAppStoreVersionPhasedReleaseLinkageResponseDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionAppStoreVersionPhasedReleaseLinkageResponseDataType value)
        {
            return value switch
            {
                AppStoreVersionAppStoreVersionPhasedReleaseLinkageResponseDataType.AppStoreVersionPhasedReleases => "appStoreVersionPhasedReleases",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionAppStoreVersionPhasedReleaseLinkageResponseDataType? ToEnum(string value)
        {
            return value switch
            {
                "appStoreVersionPhasedReleases" => AppStoreVersionAppStoreVersionPhasedReleaseLinkageResponseDataType.AppStoreVersionPhasedReleases,
                _ => null,
            };
        }
    }
}