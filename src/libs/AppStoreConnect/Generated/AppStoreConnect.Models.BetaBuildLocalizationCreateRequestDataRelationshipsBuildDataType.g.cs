
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaBuildLocalizationCreateRequestDataRelationshipsBuildDataType
    {
        /// <summary>
        ///
        /// </summary>
        Builds,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaBuildLocalizationCreateRequestDataRelationshipsBuildDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaBuildLocalizationCreateRequestDataRelationshipsBuildDataType value)
        {
            return value switch
            {
                BetaBuildLocalizationCreateRequestDataRelationshipsBuildDataType.Builds => "builds",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaBuildLocalizationCreateRequestDataRelationshipsBuildDataType? ToEnum(string value)
        {
            return value switch
            {
                "builds" => BetaBuildLocalizationCreateRequestDataRelationshipsBuildDataType.Builds,
                _ => null,
            };
        }
    }
}