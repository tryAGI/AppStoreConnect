
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppStoreVersionSubmissionType
    {
        /// <summary>
        ///
        /// </summary>
        AppStoreVersionSubmissions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppStoreVersionSubmissionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionSubmissionType value)
        {
            return value switch
            {
                AppStoreVersionSubmissionType.AppStoreVersionSubmissions => "appStoreVersionSubmissions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionSubmissionType? ToEnum(string value)
        {
            return value switch
            {
                "appStoreVersionSubmissions" => AppStoreVersionSubmissionType.AppStoreVersionSubmissions,
                _ => null,
            };
        }
    }
}