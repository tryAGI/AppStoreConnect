
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionPriceChangePreviewAttributesChangeResultChangeType
    {
        /// <summary>
        ///
        /// </summary>
        DecreaseNotPreservable,
        /// <summary>
        ///
        /// </summary>
        IncreasePreservable,
        /// <summary>
        ///
        /// </summary>
        MixedNotPreservable,
        /// <summary>
        ///
        /// </summary>
        NoChange,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionPriceChangePreviewAttributesChangeResultChangeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionPriceChangePreviewAttributesChangeResultChangeType value)
        {
            return value switch
            {
                SubscriptionPriceChangePreviewAttributesChangeResultChangeType.DecreaseNotPreservable => "DECREASE_NOT_PRESERVABLE",
                SubscriptionPriceChangePreviewAttributesChangeResultChangeType.IncreasePreservable => "INCREASE_PRESERVABLE",
                SubscriptionPriceChangePreviewAttributesChangeResultChangeType.MixedNotPreservable => "MIXED_NOT_PRESERVABLE",
                SubscriptionPriceChangePreviewAttributesChangeResultChangeType.NoChange => "NO_CHANGE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionPriceChangePreviewAttributesChangeResultChangeType? ToEnum(string value)
        {
            return value switch
            {
                "DECREASE_NOT_PRESERVABLE" => SubscriptionPriceChangePreviewAttributesChangeResultChangeType.DecreaseNotPreservable,
                "INCREASE_PRESERVABLE" => SubscriptionPriceChangePreviewAttributesChangeResultChangeType.IncreasePreservable,
                "MIXED_NOT_PRESERVABLE" => SubscriptionPriceChangePreviewAttributesChangeResultChangeType.MixedNotPreservable,
                "NO_CHANGE" => SubscriptionPriceChangePreviewAttributesChangeResultChangeType.NoChange,
                _ => null,
            };
        }
    }
}