
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppStoreVersionCreateRequestDataRelationshipsBuildDataType
    {
        /// <summary>
        ///
        /// </summary>
        Builds,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppStoreVersionCreateRequestDataRelationshipsBuildDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionCreateRequestDataRelationshipsBuildDataType value)
        {
            return value switch
            {
                AppStoreVersionCreateRequestDataRelationshipsBuildDataType.Builds => "builds",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionCreateRequestDataRelationshipsBuildDataType? ToEnum(string value)
        {
            return value switch
            {
                "builds" => AppStoreVersionCreateRequestDataRelationshipsBuildDataType.Builds,
                _ => null,
            };
        }
    }
}