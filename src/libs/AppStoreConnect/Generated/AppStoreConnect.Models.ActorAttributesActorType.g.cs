
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum ActorAttributesActorType
    {
        /// <summary>
        ///
        /// </summary>
        ApiKey,
        /// <summary>
        ///
        /// </summary>
        Apple,
        /// <summary>
        ///
        /// </summary>
        User,
        /// <summary>
        ///
        /// </summary>
        XcodeCloud,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ActorAttributesActorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ActorAttributesActorType value)
        {
            return value switch
            {
                ActorAttributesActorType.ApiKey => "API_KEY",
                ActorAttributesActorType.Apple => "APPLE",
                ActorAttributesActorType.User => "USER",
                ActorAttributesActorType.XcodeCloud => "XCODE_CLOUD",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ActorAttributesActorType? ToEnum(string value)
        {
            return value switch
            {
                "API_KEY" => ActorAttributesActorType.ApiKey,
                "APPLE" => ActorAttributesActorType.Apple,
                "USER" => ActorAttributesActorType.User,
                "XCODE_CLOUD" => ActorAttributesActorType.XcodeCloud,
                _ => null,
            };
        }
    }
}