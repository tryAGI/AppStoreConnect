
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaAppClipInvocationLocalizationCreateRequestDataRelationshipsBetaAppClipInvocationDataType
    {
        /// <summary>
        ///
        /// </summary>
        BetaAppClipInvocations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaAppClipInvocationLocalizationCreateRequestDataRelationshipsBetaAppClipInvocationDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaAppClipInvocationLocalizationCreateRequestDataRelationshipsBetaAppClipInvocationDataType value)
        {
            return value switch
            {
                BetaAppClipInvocationLocalizationCreateRequestDataRelationshipsBetaAppClipInvocationDataType.BetaAppClipInvocations => "betaAppClipInvocations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaAppClipInvocationLocalizationCreateRequestDataRelationshipsBetaAppClipInvocationDataType? ToEnum(string value)
        {
            return value switch
            {
                "betaAppClipInvocations" => BetaAppClipInvocationLocalizationCreateRequestDataRelationshipsBetaAppClipInvocationDataType.BetaAppClipInvocations,
                _ => null,
            };
        }
    }
}