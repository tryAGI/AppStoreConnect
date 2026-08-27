
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BuildBundlesBetaAppClipInvocationsGetToManyRelatedFieldsBetaAppClipInvocation
    {
        /// <summary>
        ///
        /// </summary>
        BetaAppClipInvocationLocalizations,
        /// <summary>
        ///
        /// </summary>
        Url,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BuildBundlesBetaAppClipInvocationsGetToManyRelatedFieldsBetaAppClipInvocationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildBundlesBetaAppClipInvocationsGetToManyRelatedFieldsBetaAppClipInvocation value)
        {
            return value switch
            {
                BuildBundlesBetaAppClipInvocationsGetToManyRelatedFieldsBetaAppClipInvocation.BetaAppClipInvocationLocalizations => "betaAppClipInvocationLocalizations",
                BuildBundlesBetaAppClipInvocationsGetToManyRelatedFieldsBetaAppClipInvocation.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildBundlesBetaAppClipInvocationsGetToManyRelatedFieldsBetaAppClipInvocation? ToEnum(string value)
        {
            return value switch
            {
                "betaAppClipInvocationLocalizations" => BuildBundlesBetaAppClipInvocationsGetToManyRelatedFieldsBetaAppClipInvocation.BetaAppClipInvocationLocalizations,
                "url" => BuildBundlesBetaAppClipInvocationsGetToManyRelatedFieldsBetaAppClipInvocation.Url,
                _ => null,
            };
        }
    }
}