
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppStoreVersionRelationshipsBuildDataType
    {
        /// <summary>
        /// 
        /// </summary>
        Builds,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppStoreVersionRelationshipsBuildDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionRelationshipsBuildDataType value)
        {
            return value switch
            {
                AppStoreVersionRelationshipsBuildDataType.Builds => "builds",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionRelationshipsBuildDataType? ToEnum(string value)
        {
            return value switch
            {
                "builds" => AppStoreVersionRelationshipsBuildDataType.Builds,
                _ => null,
            };
        }
    }
}