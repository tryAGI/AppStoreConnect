
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppStoreReviewDetailRelationshipsAppStoreVersionDataType
    {
        /// <summary>
        ///
        /// </summary>
        AppStoreVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppStoreReviewDetailRelationshipsAppStoreVersionDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreReviewDetailRelationshipsAppStoreVersionDataType value)
        {
            return value switch
            {
                AppStoreReviewDetailRelationshipsAppStoreVersionDataType.AppStoreVersions => "appStoreVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreReviewDetailRelationshipsAppStoreVersionDataType? ToEnum(string value)
        {
            return value switch
            {
                "appStoreVersions" => AppStoreReviewDetailRelationshipsAppStoreVersionDataType.AppStoreVersions,
                _ => null,
            };
        }
    }
}