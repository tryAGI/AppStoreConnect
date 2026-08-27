
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum NominationRelationshipsSubmittedByActorDataType
    {
        /// <summary>
        ///
        /// </summary>
        Actors,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NominationRelationshipsSubmittedByActorDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NominationRelationshipsSubmittedByActorDataType value)
        {
            return value switch
            {
                NominationRelationshipsSubmittedByActorDataType.Actors => "actors",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NominationRelationshipsSubmittedByActorDataType? ToEnum(string value)
        {
            return value switch
            {
                "actors" => NominationRelationshipsSubmittedByActorDataType.Actors,
                _ => null,
            };
        }
    }
}