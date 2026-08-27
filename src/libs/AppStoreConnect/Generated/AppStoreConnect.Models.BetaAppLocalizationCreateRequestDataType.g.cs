
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaAppLocalizationCreateRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        BetaAppLocalizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaAppLocalizationCreateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaAppLocalizationCreateRequestDataType value)
        {
            return value switch
            {
                BetaAppLocalizationCreateRequestDataType.BetaAppLocalizations => "betaAppLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaAppLocalizationCreateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "betaAppLocalizations" => BetaAppLocalizationCreateRequestDataType.BetaAppLocalizations,
                _ => null,
            };
        }
    }
}