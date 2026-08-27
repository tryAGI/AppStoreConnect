
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaBuildLocalizationRelationshipsBuildDataType
    {
        /// <summary>
        /// 
        /// </summary>
        Builds,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaBuildLocalizationRelationshipsBuildDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaBuildLocalizationRelationshipsBuildDataType value)
        {
            return value switch
            {
                BetaBuildLocalizationRelationshipsBuildDataType.Builds => "builds",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaBuildLocalizationRelationshipsBuildDataType? ToEnum(string value)
        {
            return value switch
            {
                "builds" => BetaBuildLocalizationRelationshipsBuildDataType.Builds,
                _ => null,
            };
        }
    }
}