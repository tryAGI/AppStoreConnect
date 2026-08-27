
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppClipRelationshipsAppClipDefaultExperiencesDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        AppClipDefaultExperiences,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppClipRelationshipsAppClipDefaultExperiencesDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppClipRelationshipsAppClipDefaultExperiencesDataItemType value)
        {
            return value switch
            {
                AppClipRelationshipsAppClipDefaultExperiencesDataItemType.AppClipDefaultExperiences => "appClipDefaultExperiences",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppClipRelationshipsAppClipDefaultExperiencesDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "appClipDefaultExperiences" => AppClipRelationshipsAppClipDefaultExperiencesDataItemType.AppClipDefaultExperiences,
                _ => null,
            };
        }
    }
}