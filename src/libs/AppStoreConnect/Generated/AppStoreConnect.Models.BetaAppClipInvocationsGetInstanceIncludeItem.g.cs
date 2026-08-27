
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaAppClipInvocationsGetInstanceIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        BetaAppClipInvocationLocalizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaAppClipInvocationsGetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaAppClipInvocationsGetInstanceIncludeItem value)
        {
            return value switch
            {
                BetaAppClipInvocationsGetInstanceIncludeItem.BetaAppClipInvocationLocalizations => "betaAppClipInvocationLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaAppClipInvocationsGetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "betaAppClipInvocationLocalizations" => BetaAppClipInvocationsGetInstanceIncludeItem.BetaAppClipInvocationLocalizations,
                _ => null,
            };
        }
    }
}