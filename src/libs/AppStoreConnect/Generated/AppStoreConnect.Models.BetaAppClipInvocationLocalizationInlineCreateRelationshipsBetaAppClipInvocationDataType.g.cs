
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaAppClipInvocationLocalizationInlineCreateRelationshipsBetaAppClipInvocationDataType
    {
        /// <summary>
        /// 
        /// </summary>
        BetaAppClipInvocations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaAppClipInvocationLocalizationInlineCreateRelationshipsBetaAppClipInvocationDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaAppClipInvocationLocalizationInlineCreateRelationshipsBetaAppClipInvocationDataType value)
        {
            return value switch
            {
                BetaAppClipInvocationLocalizationInlineCreateRelationshipsBetaAppClipInvocationDataType.BetaAppClipInvocations => "betaAppClipInvocations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaAppClipInvocationLocalizationInlineCreateRelationshipsBetaAppClipInvocationDataType? ToEnum(string value)
        {
            return value switch
            {
                "betaAppClipInvocations" => BetaAppClipInvocationLocalizationInlineCreateRelationshipsBetaAppClipInvocationDataType.BetaAppClipInvocations,
                _ => null,
            };
        }
    }
}