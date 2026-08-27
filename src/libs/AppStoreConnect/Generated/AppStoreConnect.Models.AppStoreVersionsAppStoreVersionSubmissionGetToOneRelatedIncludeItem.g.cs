
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppStoreVersionsAppStoreVersionSubmissionGetToOneRelatedIncludeItem
    {
        /// <summary>
        /// 
        /// </summary>
        AppStoreVersion,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppStoreVersionsAppStoreVersionSubmissionGetToOneRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionsAppStoreVersionSubmissionGetToOneRelatedIncludeItem value)
        {
            return value switch
            {
                AppStoreVersionsAppStoreVersionSubmissionGetToOneRelatedIncludeItem.AppStoreVersion => "appStoreVersion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionsAppStoreVersionSubmissionGetToOneRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "appStoreVersion" => AppStoreVersionsAppStoreVersionSubmissionGetToOneRelatedIncludeItem.AppStoreVersion,
                _ => null,
            };
        }
    }
}