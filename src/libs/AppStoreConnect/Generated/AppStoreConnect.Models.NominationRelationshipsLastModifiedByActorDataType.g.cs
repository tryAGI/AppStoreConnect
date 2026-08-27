
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum NominationRelationshipsLastModifiedByActorDataType
    {
        /// <summary>
        ///
        /// </summary>
        Actors,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NominationRelationshipsLastModifiedByActorDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NominationRelationshipsLastModifiedByActorDataType value)
        {
            return value switch
            {
                NominationRelationshipsLastModifiedByActorDataType.Actors => "actors",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NominationRelationshipsLastModifiedByActorDataType? ToEnum(string value)
        {
            return value switch
            {
                "actors" => NominationRelationshipsLastModifiedByActorDataType.Actors,
                _ => null,
            };
        }
    }
}