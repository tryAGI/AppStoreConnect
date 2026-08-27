
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum NominationRelationshipsCreatedByActorDataType
    {
        /// <summary>
        /// 
        /// </summary>
        Actors,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NominationRelationshipsCreatedByActorDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NominationRelationshipsCreatedByActorDataType value)
        {
            return value switch
            {
                NominationRelationshipsCreatedByActorDataType.Actors => "actors",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NominationRelationshipsCreatedByActorDataType? ToEnum(string value)
        {
            return value switch
            {
                "actors" => NominationRelationshipsCreatedByActorDataType.Actors,
                _ => null,
            };
        }
    }
}