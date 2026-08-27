
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppStoreVersionAppStoreVersionSubmissionLinkageResponseDataType
    {
        /// <summary>
        /// 
        /// </summary>
        AppStoreVersionSubmissions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppStoreVersionAppStoreVersionSubmissionLinkageResponseDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionAppStoreVersionSubmissionLinkageResponseDataType value)
        {
            return value switch
            {
                AppStoreVersionAppStoreVersionSubmissionLinkageResponseDataType.AppStoreVersionSubmissions => "appStoreVersionSubmissions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionAppStoreVersionSubmissionLinkageResponseDataType? ToEnum(string value)
        {
            return value switch
            {
                "appStoreVersionSubmissions" => AppStoreVersionAppStoreVersionSubmissionLinkageResponseDataType.AppStoreVersionSubmissions,
                _ => null,
            };
        }
    }
}