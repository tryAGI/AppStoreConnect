
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaAppLocalizationUpdateRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        BetaAppLocalizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaAppLocalizationUpdateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaAppLocalizationUpdateRequestDataType value)
        {
            return value switch
            {
                BetaAppLocalizationUpdateRequestDataType.BetaAppLocalizations => "betaAppLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaAppLocalizationUpdateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "betaAppLocalizations" => BetaAppLocalizationUpdateRequestDataType.BetaAppLocalizations,
                _ => null,
            };
        }
    }
}