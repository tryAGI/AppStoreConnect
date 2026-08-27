
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum NominationCreateRequestDataRelationshipsSupportedTerritoriesDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        Territories,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NominationCreateRequestDataRelationshipsSupportedTerritoriesDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NominationCreateRequestDataRelationshipsSupportedTerritoriesDataItemType value)
        {
            return value switch
            {
                NominationCreateRequestDataRelationshipsSupportedTerritoriesDataItemType.Territories => "territories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NominationCreateRequestDataRelationshipsSupportedTerritoriesDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "territories" => NominationCreateRequestDataRelationshipsSupportedTerritoriesDataItemType.Territories,
                _ => null,
            };
        }
    }
}