
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionGroupVersionType
    {
        /// <summary>
        ///
        /// </summary>
        SubscriptionGroupVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionGroupVersionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionGroupVersionType value)
        {
            return value switch
            {
                SubscriptionGroupVersionType.SubscriptionGroupVersions => "subscriptionGroupVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionGroupVersionType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionGroupVersions" => SubscriptionGroupVersionType.SubscriptionGroupVersions,
                _ => null,
            };
        }
    }
}