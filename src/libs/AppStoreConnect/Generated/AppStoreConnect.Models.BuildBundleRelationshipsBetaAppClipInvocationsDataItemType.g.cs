
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BuildBundleRelationshipsBetaAppClipInvocationsDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        BetaAppClipInvocations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BuildBundleRelationshipsBetaAppClipInvocationsDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildBundleRelationshipsBetaAppClipInvocationsDataItemType value)
        {
            return value switch
            {
                BuildBundleRelationshipsBetaAppClipInvocationsDataItemType.BetaAppClipInvocations => "betaAppClipInvocations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildBundleRelationshipsBetaAppClipInvocationsDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "betaAppClipInvocations" => BuildBundleRelationshipsBetaAppClipInvocationsDataItemType.BetaAppClipInvocations,
                _ => null,
            };
        }
    }
}