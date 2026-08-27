
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaFeedbackScreenshotSubmissionsResponseIncludedItemDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        BetaTesters,
        /// <summary>
        /// 
        /// </summary>
        Builds,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaFeedbackScreenshotSubmissionsResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaFeedbackScreenshotSubmissionsResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                BetaFeedbackScreenshotSubmissionsResponseIncludedItemDiscriminatorType.BetaTesters => "betaTesters",
                BetaFeedbackScreenshotSubmissionsResponseIncludedItemDiscriminatorType.Builds => "builds",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaFeedbackScreenshotSubmissionsResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "betaTesters" => BetaFeedbackScreenshotSubmissionsResponseIncludedItemDiscriminatorType.BetaTesters,
                "builds" => BetaFeedbackScreenshotSubmissionsResponseIncludedItemDiscriminatorType.Builds,
                _ => null,
            };
        }
    }
}