
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaAppClipInvocationLocalizationInlineCreateType
    {
        /// <summary>
        /// 
        /// </summary>
        BetaAppClipInvocationLocalizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaAppClipInvocationLocalizationInlineCreateTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaAppClipInvocationLocalizationInlineCreateType value)
        {
            return value switch
            {
                BetaAppClipInvocationLocalizationInlineCreateType.BetaAppClipInvocationLocalizations => "betaAppClipInvocationLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaAppClipInvocationLocalizationInlineCreateType? ToEnum(string value)
        {
            return value switch
            {
                "betaAppClipInvocationLocalizations" => BetaAppClipInvocationLocalizationInlineCreateType.BetaAppClipInvocationLocalizations,
                _ => null,
            };
        }
    }
}