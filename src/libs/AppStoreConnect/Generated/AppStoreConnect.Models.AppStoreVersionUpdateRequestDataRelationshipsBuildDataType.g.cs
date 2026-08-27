
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppStoreVersionUpdateRequestDataRelationshipsBuildDataType
    {
        /// <summary>
        ///
        /// </summary>
        Builds,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppStoreVersionUpdateRequestDataRelationshipsBuildDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionUpdateRequestDataRelationshipsBuildDataType value)
        {
            return value switch
            {
                AppStoreVersionUpdateRequestDataRelationshipsBuildDataType.Builds => "builds",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionUpdateRequestDataRelationshipsBuildDataType? ToEnum(string value)
        {
            return value switch
            {
                "builds" => AppStoreVersionUpdateRequestDataRelationshipsBuildDataType.Builds,
                _ => null,
            };
        }
    }
}