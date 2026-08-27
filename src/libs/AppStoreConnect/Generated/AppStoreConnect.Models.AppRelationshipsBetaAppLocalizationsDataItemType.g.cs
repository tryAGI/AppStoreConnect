
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppRelationshipsBetaAppLocalizationsDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        BetaAppLocalizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppRelationshipsBetaAppLocalizationsDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppRelationshipsBetaAppLocalizationsDataItemType value)
        {
            return value switch
            {
                AppRelationshipsBetaAppLocalizationsDataItemType.BetaAppLocalizations => "betaAppLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppRelationshipsBetaAppLocalizationsDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "betaAppLocalizations" => AppRelationshipsBetaAppLocalizationsDataItemType.BetaAppLocalizations,
                _ => null,
            };
        }
    }
}