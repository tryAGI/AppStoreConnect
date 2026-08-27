
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaAppLocalizationsGetCollectionFieldsBetaAppLocalization
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
    public static class BetaAppLocalizationsGetCollectionFieldsBetaAppLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaAppLocalizationsGetCollectionFieldsBetaAppLocalization value)
        {
            return value switch
            {
                BetaAppLocalizationsGetCollectionFieldsBetaAppLocalization.App => "app",
                BetaAppLocalizationsGetCollectionFieldsBetaAppLocalization.Description => "description",
                BetaAppLocalizationsGetCollectionFieldsBetaAppLocalization.FeedbackEmail => "feedbackEmail",
                BetaAppLocalizationsGetCollectionFieldsBetaAppLocalization.Locale => "locale",
                BetaAppLocalizationsGetCollectionFieldsBetaAppLocalization.MarketingUrl => "marketingUrl",
                BetaAppLocalizationsGetCollectionFieldsBetaAppLocalization.PrivacyPolicyUrl => "privacyPolicyUrl",
                BetaAppLocalizationsGetCollectionFieldsBetaAppLocalization.TvOsPrivacyPolicy => "tvOsPrivacyPolicy",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaAppLocalizationsGetCollectionFieldsBetaAppLocalization? ToEnum(string value)
        {
            return value switch
            {
                "app" => BetaAppLocalizationsGetCollectionFieldsBetaAppLocalization.App,
                "description" => BetaAppLocalizationsGetCollectionFieldsBetaAppLocalization.Description,
                "feedbackEmail" => BetaAppLocalizationsGetCollectionFieldsBetaAppLocalization.FeedbackEmail,
                "locale" => BetaAppLocalizationsGetCollectionFieldsBetaAppLocalization.Locale,
                "marketingUrl" => BetaAppLocalizationsGetCollectionFieldsBetaAppLocalization.MarketingUrl,
                "privacyPolicyUrl" => BetaAppLocalizationsGetCollectionFieldsBetaAppLocalization.PrivacyPolicyUrl,
                "tvOsPrivacyPolicy" => BetaAppLocalizationsGetCollectionFieldsBetaAppLocalization.TvOsPrivacyPolicy,
                _ => null,
            };
        }
    }
}