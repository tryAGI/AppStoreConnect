
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum ActorType
    {
        /// <summary>
        ///
        /// </summary>
        Actors,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ActorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ActorType value)
        {
            return value switch
            {
                ActorType.Actors => "actors",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ActorType? ToEnum(string value)
        {
            return value switch
            {
                "actors" => ActorType.Actors,
                _ => null,
            };
        }
    }
}