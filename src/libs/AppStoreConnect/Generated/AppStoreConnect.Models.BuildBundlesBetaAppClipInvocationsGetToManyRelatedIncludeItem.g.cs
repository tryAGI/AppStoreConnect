
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BuildBundlesBetaAppClipInvocationsGetToManyRelatedIncludeItem
    {
        /// <summary>
        /// 
        /// </summary>
        BetaAppClipInvocationLocalizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BuildBundlesBetaAppClipInvocationsGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildBundlesBetaAppClipInvocationsGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                BuildBundlesBetaAppClipInvocationsGetToManyRelatedIncludeItem.BetaAppClipInvocationLocalizations => "betaAppClipInvocationLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildBundlesBetaAppClipInvocationsGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "betaAppClipInvocationLocalizations" => BuildBundlesBetaAppClipInvocationsGetToManyRelatedIncludeItem.BetaAppClipInvocationLocalizations,
                _ => null,
            };
        }
    }
}