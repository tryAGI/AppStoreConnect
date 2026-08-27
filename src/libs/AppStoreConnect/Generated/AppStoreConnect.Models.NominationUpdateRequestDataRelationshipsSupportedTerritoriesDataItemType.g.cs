
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum NominationUpdateRequestDataRelationshipsSupportedTerritoriesDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        Territories,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NominationUpdateRequestDataRelationshipsSupportedTerritoriesDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NominationUpdateRequestDataRelationshipsSupportedTerritoriesDataItemType value)
        {
            return value switch
            {
                NominationUpdateRequestDataRelationshipsSupportedTerritoriesDataItemType.Territories => "territories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NominationUpdateRequestDataRelationshipsSupportedTerritoriesDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "territories" => NominationUpdateRequestDataRelationshipsSupportedTerritoriesDataItemType.Territories,
                _ => null,
            };
        }
    }
}