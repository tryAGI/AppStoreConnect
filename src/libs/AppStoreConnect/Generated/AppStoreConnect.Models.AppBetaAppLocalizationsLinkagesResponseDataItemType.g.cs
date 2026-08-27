
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppBetaAppLocalizationsLinkagesResponseDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        BetaAppLocalizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppBetaAppLocalizationsLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppBetaAppLocalizationsLinkagesResponseDataItemType value)
        {
            return value switch
            {
                AppBetaAppLocalizationsLinkagesResponseDataItemType.BetaAppLocalizations => "betaAppLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppBetaAppLocalizationsLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "betaAppLocalizations" => AppBetaAppLocalizationsLinkagesResponseDataItemType.BetaAppLocalizations,
                _ => null,
            };
        }
    }
}