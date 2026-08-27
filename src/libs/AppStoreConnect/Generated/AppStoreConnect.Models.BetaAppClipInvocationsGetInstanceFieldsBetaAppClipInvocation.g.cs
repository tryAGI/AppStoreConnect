
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaAppClipInvocationsGetInstanceFieldsBetaAppClipInvocation
    {
        /// <summary>
        ///
        /// </summary>
        BetaAppClipInvocationLocalizations,
        /// <summary>
        ///
        /// </summary>
        Url,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaAppClipInvocationsGetInstanceFieldsBetaAppClipInvocationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaAppClipInvocationsGetInstanceFieldsBetaAppClipInvocation value)
        {
            return value switch
            {
                BetaAppClipInvocationsGetInstanceFieldsBetaAppClipInvocation.BetaAppClipInvocationLocalizations => "betaAppClipInvocationLocalizations",
                BetaAppClipInvocationsGetInstanceFieldsBetaAppClipInvocation.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaAppClipInvocationsGetInstanceFieldsBetaAppClipInvocation? ToEnum(string value)
        {
            return value switch
            {
                "betaAppClipInvocationLocalizations" => BetaAppClipInvocationsGetInstanceFieldsBetaAppClipInvocation.BetaAppClipInvocationLocalizations,
                "url" => BetaAppClipInvocationsGetInstanceFieldsBetaAppClipInvocation.Url,
                _ => null,
            };
        }
    }
}