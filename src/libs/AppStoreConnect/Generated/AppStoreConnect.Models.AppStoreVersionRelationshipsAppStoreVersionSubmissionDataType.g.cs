
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppStoreVersionRelationshipsAppStoreVersionSubmissionDataType
    {
        /// <summary>
        /// 
        /// </summary>
        AppStoreVersionSubmissions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppStoreVersionRelationshipsAppStoreVersionSubmissionDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionRelationshipsAppStoreVersionSubmissionDataType value)
        {
            return value switch
            {
                AppStoreVersionRelationshipsAppStoreVersionSubmissionDataType.AppStoreVersionSubmissions => "appStoreVersionSubmissions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionRelationshipsAppStoreVersionSubmissionDataType? ToEnum(string value)
        {
            return value switch
            {
                "appStoreVersionSubmissions" => AppStoreVersionRelationshipsAppStoreVersionSubmissionDataType.AppStoreVersionSubmissions,
                _ => null,
            };
        }
    }
}