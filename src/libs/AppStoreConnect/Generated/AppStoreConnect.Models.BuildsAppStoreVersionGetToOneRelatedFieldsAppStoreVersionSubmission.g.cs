
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionSubmission
    {
        /// <summary>
        /// 
        /// </summary>
        AppStoreVersion,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionSubmissionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionSubmission value)
        {
            return value switch
            {
                BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionSubmission.AppStoreVersion => "appStoreVersion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionSubmission? ToEnum(string value)
        {
            return value switch
            {
                "appStoreVersion" => BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionSubmission.AppStoreVersion,
                _ => null,
            };
        }
    }
}