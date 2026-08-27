
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BuildBundlesBetaAppClipInvocationsGetToManyRelatedFieldsBetaAppClipInvocationLocalization
    {
        /// <summary>
        /// 
        /// </summary>
        Locale,
        /// <summary>
        /// 
        /// </summary>
        Title,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BuildBundlesBetaAppClipInvocationsGetToManyRelatedFieldsBetaAppClipInvocationLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildBundlesBetaAppClipInvocationsGetToManyRelatedFieldsBetaAppClipInvocationLocalization value)
        {
            return value switch
            {
                BuildBundlesBetaAppClipInvocationsGetToManyRelatedFieldsBetaAppClipInvocationLocalization.Locale => "locale",
                BuildBundlesBetaAppClipInvocationsGetToManyRelatedFieldsBetaAppClipInvocationLocalization.Title => "title",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildBundlesBetaAppClipInvocationsGetToManyRelatedFieldsBetaAppClipInvocationLocalization? ToEnum(string value)
        {
            return value switch
            {
                "locale" => BuildBundlesBetaAppClipInvocationsGetToManyRelatedFieldsBetaAppClipInvocationLocalization.Locale,
                "title" => BuildBundlesBetaAppClipInvocationsGetToManyRelatedFieldsBetaAppClipInvocationLocalization.Title,
                _ => null,
            };
        }
    }
}