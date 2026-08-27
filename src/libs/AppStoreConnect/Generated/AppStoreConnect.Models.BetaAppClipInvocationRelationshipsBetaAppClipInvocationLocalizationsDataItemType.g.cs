
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaAppClipInvocationRelationshipsBetaAppClipInvocationLocalizationsDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        BetaAppClipInvocationLocalizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaAppClipInvocationRelationshipsBetaAppClipInvocationLocalizationsDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaAppClipInvocationRelationshipsBetaAppClipInvocationLocalizationsDataItemType value)
        {
            return value switch
            {
                BetaAppClipInvocationRelationshipsBetaAppClipInvocationLocalizationsDataItemType.BetaAppClipInvocationLocalizations => "betaAppClipInvocationLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaAppClipInvocationRelationshipsBetaAppClipInvocationLocalizationsDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "betaAppClipInvocationLocalizations" => BetaAppClipInvocationRelationshipsBetaAppClipInvocationLocalizationsDataItemType.BetaAppClipInvocationLocalizations,
                _ => null,
            };
        }
    }
}