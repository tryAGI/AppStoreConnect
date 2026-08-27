
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppsGetInstanceFieldsBetaAppLocalization
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
    public static class AppsGetInstanceFieldsBetaAppLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsGetInstanceFieldsBetaAppLocalization value)
        {
            return value switch
            {
                AppsGetInstanceFieldsBetaAppLocalization.App => "app",
                AppsGetInstanceFieldsBetaAppLocalization.Description => "description",
                AppsGetInstanceFieldsBetaAppLocalization.FeedbackEmail => "feedbackEmail",
                AppsGetInstanceFieldsBetaAppLocalization.Locale => "locale",
                AppsGetInstanceFieldsBetaAppLocalization.MarketingUrl => "marketingUrl",
                AppsGetInstanceFieldsBetaAppLocalization.PrivacyPolicyUrl => "privacyPolicyUrl",
                AppsGetInstanceFieldsBetaAppLocalization.TvOsPrivacyPolicy => "tvOsPrivacyPolicy",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsGetInstanceFieldsBetaAppLocalization? ToEnum(string value)
        {
            return value switch
            {
                "app" => AppsGetInstanceFieldsBetaAppLocalization.App,
                "description" => AppsGetInstanceFieldsBetaAppLocalization.Description,
                "feedbackEmail" => AppsGetInstanceFieldsBetaAppLocalization.FeedbackEmail,
                "locale" => AppsGetInstanceFieldsBetaAppLocalization.Locale,
                "marketingUrl" => AppsGetInstanceFieldsBetaAppLocalization.MarketingUrl,
                "privacyPolicyUrl" => AppsGetInstanceFieldsBetaAppLocalization.PrivacyPolicyUrl,
                "tvOsPrivacyPolicy" => AppsGetInstanceFieldsBetaAppLocalization.TvOsPrivacyPolicy,
                _ => null,
            };
        }
    }
}