
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionGroupVersionsLocalizationsGetToManyRelatedIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        Version,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionGroupVersionsLocalizationsGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionGroupVersionsLocalizationsGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                SubscriptionGroupVersionsLocalizationsGetToManyRelatedIncludeItem.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionGroupVersionsLocalizationsGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "version" => SubscriptionGroupVersionsLocalizationsGetToManyRelatedIncludeItem.Version,
                _ => null,
            };
        }
    }
}