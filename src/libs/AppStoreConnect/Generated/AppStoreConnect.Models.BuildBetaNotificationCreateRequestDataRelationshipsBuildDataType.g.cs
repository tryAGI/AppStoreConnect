
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BuildBetaNotificationCreateRequestDataRelationshipsBuildDataType
    {
        /// <summary>
        ///
        /// </summary>
        Builds,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BuildBetaNotificationCreateRequestDataRelationshipsBuildDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildBetaNotificationCreateRequestDataRelationshipsBuildDataType value)
        {
            return value switch
            {
                BuildBetaNotificationCreateRequestDataRelationshipsBuildDataType.Builds => "builds",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildBetaNotificationCreateRequestDataRelationshipsBuildDataType? ToEnum(string value)
        {
            return value switch
            {
                "builds" => BuildBetaNotificationCreateRequestDataRelationshipsBuildDataType.Builds,
                _ => null,
            };
        }
    }
}