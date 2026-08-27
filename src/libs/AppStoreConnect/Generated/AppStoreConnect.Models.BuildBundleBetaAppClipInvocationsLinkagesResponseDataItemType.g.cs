
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BuildBundleBetaAppClipInvocationsLinkagesResponseDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        BetaAppClipInvocations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BuildBundleBetaAppClipInvocationsLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildBundleBetaAppClipInvocationsLinkagesResponseDataItemType value)
        {
            return value switch
            {
                BuildBundleBetaAppClipInvocationsLinkagesResponseDataItemType.BetaAppClipInvocations => "betaAppClipInvocations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildBundleBetaAppClipInvocationsLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "betaAppClipInvocations" => BuildBundleBetaAppClipInvocationsLinkagesResponseDataItemType.BetaAppClipInvocations,
                _ => null,
            };
        }
    }
}