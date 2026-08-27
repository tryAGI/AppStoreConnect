
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionStatusUrlVersion
    {
        /// <summary>
        ///
        /// </summary>
        V1,
        /// <summary>
        ///
        /// </summary>
        V2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionStatusUrlVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionStatusUrlVersion value)
        {
            return value switch
            {
                SubscriptionStatusUrlVersion.V1 => "V1",
                SubscriptionStatusUrlVersion.V2 => "V2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionStatusUrlVersion? ToEnum(string value)
        {
            return value switch
            {
                "V1" => SubscriptionStatusUrlVersion.V1,
                "V2" => SubscriptionStatusUrlVersion.V2,
                _ => null,
            };
        }
    }
}