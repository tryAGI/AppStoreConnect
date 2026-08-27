
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppsGetCollectionFieldsBetaAppLocalization
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
    public static class AppsGetCollectionFieldsBetaAppLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsGetCollectionFieldsBetaAppLocalization value)
        {
            return value switch
            {
                AppsGetCollectionFieldsBetaAppLocalization.App => "app",
                AppsGetCollectionFieldsBetaAppLocalization.Description => "description",
                AppsGetCollectionFieldsBetaAppLocalization.FeedbackEmail => "feedbackEmail",
                AppsGetCollectionFieldsBetaAppLocalization.Locale => "locale",
                AppsGetCollectionFieldsBetaAppLocalization.MarketingUrl => "marketingUrl",
                AppsGetCollectionFieldsBetaAppLocalization.PrivacyPolicyUrl => "privacyPolicyUrl",
                AppsGetCollectionFieldsBetaAppLocalization.TvOsPrivacyPolicy => "tvOsPrivacyPolicy",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsGetCollectionFieldsBetaAppLocalization? ToEnum(string value)
        {
            return value switch
            {
                "app" => AppsGetCollectionFieldsBetaAppLocalization.App,
                "description" => AppsGetCollectionFieldsBetaAppLocalization.Description,
                "feedbackEmail" => AppsGetCollectionFieldsBetaAppLocalization.FeedbackEmail,
                "locale" => AppsGetCollectionFieldsBetaAppLocalization.Locale,
                "marketingUrl" => AppsGetCollectionFieldsBetaAppLocalization.MarketingUrl,
                "privacyPolicyUrl" => AppsGetCollectionFieldsBetaAppLocalization.PrivacyPolicyUrl,
                "tvOsPrivacyPolicy" => AppsGetCollectionFieldsBetaAppLocalization.TvOsPrivacyPolicy,
                _ => null,
            };
        }
    }
}