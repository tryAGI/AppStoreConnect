
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaAppLocalizationsGetInstanceFieldsBetaAppLocalization
    {
        /// <summary>
        ///
        /// </summary>
        App,
        /// <summary>
        ///
        /// </summary>
        Description,
        /// <summary>
        ///
        /// </summary>
        FeedbackEmail,
        /// <summary>
        ///
        /// </summary>
        Locale,
        /// <summary>
        ///
        /// </summary>
        MarketingUrl,
        /// <summary>
        ///
        /// </summary>
        PrivacyPolicyUrl,
        /// <summary>
        ///
        /// </summary>
        TvOsPrivacyPolicy,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaAppLocalizationsGetInstanceFieldsBetaAppLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaAppLocalizationsGetInstanceFieldsBetaAppLocalization value)
        {
            return value switch
            {
                BetaAppLocalizationsGetInstanceFieldsBetaAppLocalization.App => "app",
                BetaAppLocalizationsGetInstanceFieldsBetaAppLocalization.Description => "description",
                BetaAppLocalizationsGetInstanceFieldsBetaAppLocalization.FeedbackEmail => "feedbackEmail",
                BetaAppLocalizationsGetInstanceFieldsBetaAppLocalization.Locale => "locale",
                BetaAppLocalizationsGetInstanceFieldsBetaAppLocalization.MarketingUrl => "marketingUrl",
                BetaAppLocalizationsGetInstanceFieldsBetaAppLocalization.PrivacyPolicyUrl => "privacyPolicyUrl",
                BetaAppLocalizationsGetInstanceFieldsBetaAppLocalization.TvOsPrivacyPolicy => "tvOsPrivacyPolicy",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaAppLocalizationsGetInstanceFieldsBetaAppLocalization? ToEnum(string value)
        {
            return value switch
            {
                "app" => BetaAppLocalizationsGetInstanceFieldsBetaAppLocalization.App,
                "description" => BetaAppLocalizationsGetInstanceFieldsBetaAppLocalization.Description,
                "feedbackEmail" => BetaAppLocalizationsGetInstanceFieldsBetaAppLocalization.FeedbackEmail,
                "locale" => BetaAppLocalizationsGetInstanceFieldsBetaAppLocalization.Locale,
                "marketingUrl" => BetaAppLocalizationsGetInstanceFieldsBetaAppLocalization.MarketingUrl,
                "privacyPolicyUrl" => BetaAppLocalizationsGetInstanceFieldsBetaAppLocalization.PrivacyPolicyUrl,
                "tvOsPrivacyPolicy" => BetaAppLocalizationsGetInstanceFieldsBetaAppLocalization.TvOsPrivacyPolicy,
                _ => null,
            };
        }
    }
}