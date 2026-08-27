
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppStoreVersionPhasedReleaseType
    {
        /// <summary>
        /// 
        /// </summary>
        AppStoreVersionPhasedReleases,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppStoreVersionPhasedReleaseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionPhasedReleaseType value)
        {
            return value switch
            {
                AppStoreVersionPhasedReleaseType.AppStoreVersionPhasedReleases => "appStoreVersionPhasedReleases",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionPhasedReleaseType? ToEnum(string value)
        {
            return value switch
            {
                "appStoreVersionPhasedReleases" => AppStoreVersionPhasedReleaseType.AppStoreVersionPhasedReleases,
                _ => null,
            };
        }
    }
}