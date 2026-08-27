
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaAppClipInvocationsGetInstanceFieldsBetaAppClipInvocationLocalization
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
    public static class BetaAppClipInvocationsGetInstanceFieldsBetaAppClipInvocationLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaAppClipInvocationsGetInstanceFieldsBetaAppClipInvocationLocalization value)
        {
            return value switch
            {
                BetaAppClipInvocationsGetInstanceFieldsBetaAppClipInvocationLocalization.Locale => "locale",
                BetaAppClipInvocationsGetInstanceFieldsBetaAppClipInvocationLocalization.Title => "title",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaAppClipInvocationsGetInstanceFieldsBetaAppClipInvocationLocalization? ToEnum(string value)
        {
            return value switch
            {
                "locale" => BetaAppClipInvocationsGetInstanceFieldsBetaAppClipInvocationLocalization.Locale,
                "title" => BetaAppClipInvocationsGetInstanceFieldsBetaAppClipInvocationLocalization.Title,
                _ => null,
            };
        }
    }
}