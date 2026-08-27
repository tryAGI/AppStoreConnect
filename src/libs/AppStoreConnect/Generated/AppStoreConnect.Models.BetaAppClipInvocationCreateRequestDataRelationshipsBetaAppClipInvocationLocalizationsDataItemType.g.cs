
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaAppClipInvocationCreateRequestDataRelationshipsBetaAppClipInvocationLocalizationsDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        BetaAppClipInvocationLocalizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaAppClipInvocationCreateRequestDataRelationshipsBetaAppClipInvocationLocalizationsDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaAppClipInvocationCreateRequestDataRelationshipsBetaAppClipInvocationLocalizationsDataItemType value)
        {
            return value switch
            {
                BetaAppClipInvocationCreateRequestDataRelationshipsBetaAppClipInvocationLocalizationsDataItemType.BetaAppClipInvocationLocalizations => "betaAppClipInvocationLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaAppClipInvocationCreateRequestDataRelationshipsBetaAppClipInvocationLocalizationsDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "betaAppClipInvocationLocalizations" => BetaAppClipInvocationCreateRequestDataRelationshipsBetaAppClipInvocationLocalizationsDataItemType.BetaAppClipInvocationLocalizations,
                _ => null,
            };
        }
    }
}