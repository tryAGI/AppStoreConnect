
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum NominationRelationshipsSupportedTerritoriesDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        Territories,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NominationRelationshipsSupportedTerritoriesDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NominationRelationshipsSupportedTerritoriesDataItemType value)
        {
            return value switch
            {
                NominationRelationshipsSupportedTerritoriesDataItemType.Territories => "territories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NominationRelationshipsSupportedTerritoriesDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "territories" => NominationRelationshipsSupportedTerritoriesDataItemType.Territories,
                _ => null,
            };
        }
    }
}