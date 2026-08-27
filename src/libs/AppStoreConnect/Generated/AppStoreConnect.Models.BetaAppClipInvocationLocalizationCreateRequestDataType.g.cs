
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaAppClipInvocationLocalizationCreateRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        BetaAppClipInvocationLocalizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaAppClipInvocationLocalizationCreateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaAppClipInvocationLocalizationCreateRequestDataType value)
        {
            return value switch
            {
                BetaAppClipInvocationLocalizationCreateRequestDataType.BetaAppClipInvocationLocalizations => "betaAppClipInvocationLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaAppClipInvocationLocalizationCreateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "betaAppClipInvocationLocalizations" => BetaAppClipInvocationLocalizationCreateRequestDataType.BetaAppClipInvocationLocalizations,
                _ => null,
            };
        }
    }
}