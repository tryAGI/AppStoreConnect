
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaAppClipInvocationLocalizationUpdateRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        BetaAppClipInvocationLocalizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaAppClipInvocationLocalizationUpdateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaAppClipInvocationLocalizationUpdateRequestDataType value)
        {
            return value switch
            {
                BetaAppClipInvocationLocalizationUpdateRequestDataType.BetaAppClipInvocationLocalizations => "betaAppClipInvocationLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaAppClipInvocationLocalizationUpdateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "betaAppClipInvocationLocalizations" => BetaAppClipInvocationLocalizationUpdateRequestDataType.BetaAppClipInvocationLocalizations,
                _ => null,
            };
        }
    }
}