
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaAppClipInvocationLocalizationType
    {
        /// <summary>
        /// 
        /// </summary>
        BetaAppClipInvocationLocalizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaAppClipInvocationLocalizationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaAppClipInvocationLocalizationType value)
        {
            return value switch
            {
                BetaAppClipInvocationLocalizationType.BetaAppClipInvocationLocalizations => "betaAppClipInvocationLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaAppClipInvocationLocalizationType? ToEnum(string value)
        {
            return value switch
            {
                "betaAppClipInvocationLocalizations" => BetaAppClipInvocationLocalizationType.BetaAppClipInvocationLocalizations,
                _ => null,
            };
        }
    }
}