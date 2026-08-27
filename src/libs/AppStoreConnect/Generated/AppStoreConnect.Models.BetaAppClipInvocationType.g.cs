
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaAppClipInvocationType
    {
        /// <summary>
        /// 
        /// </summary>
        BetaAppClipInvocations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaAppClipInvocationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaAppClipInvocationType value)
        {
            return value switch
            {
                BetaAppClipInvocationType.BetaAppClipInvocations => "betaAppClipInvocations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaAppClipInvocationType? ToEnum(string value)
        {
            return value switch
            {
                "betaAppClipInvocations" => BetaAppClipInvocationType.BetaAppClipInvocations,
                _ => null,
            };
        }
    }
}