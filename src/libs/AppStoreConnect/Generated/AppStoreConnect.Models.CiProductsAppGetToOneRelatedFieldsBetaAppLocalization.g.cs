
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CiProductsAppGetToOneRelatedFieldsBetaAppLocalization
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
    public static class CiProductsAppGetToOneRelatedFieldsBetaAppLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiProductsAppGetToOneRelatedFieldsBetaAppLocalization value)
        {
            return value switch
            {
                CiProductsAppGetToOneRelatedFieldsBetaAppLocalization.App => "app",
                CiProductsAppGetToOneRelatedFieldsBetaAppLocalization.Description => "description",
                CiProductsAppGetToOneRelatedFieldsBetaAppLocalization.FeedbackEmail => "feedbackEmail",
                CiProductsAppGetToOneRelatedFieldsBetaAppLocalization.Locale => "locale",
                CiProductsAppGetToOneRelatedFieldsBetaAppLocalization.MarketingUrl => "marketingUrl",
                CiProductsAppGetToOneRelatedFieldsBetaAppLocalization.PrivacyPolicyUrl => "privacyPolicyUrl",
                CiProductsAppGetToOneRelatedFieldsBetaAppLocalization.TvOsPrivacyPolicy => "tvOsPrivacyPolicy",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiProductsAppGetToOneRelatedFieldsBetaAppLocalization? ToEnum(string value)
        {
            return value switch
            {
                "app" => CiProductsAppGetToOneRelatedFieldsBetaAppLocalization.App,
                "description" => CiProductsAppGetToOneRelatedFieldsBetaAppLocalization.Description,
                "feedbackEmail" => CiProductsAppGetToOneRelatedFieldsBetaAppLocalization.FeedbackEmail,
                "locale" => CiProductsAppGetToOneRelatedFieldsBetaAppLocalization.Locale,
                "marketingUrl" => CiProductsAppGetToOneRelatedFieldsBetaAppLocalization.MarketingUrl,
                "privacyPolicyUrl" => CiProductsAppGetToOneRelatedFieldsBetaAppLocalization.PrivacyPolicyUrl,
                "tvOsPrivacyPolicy" => CiProductsAppGetToOneRelatedFieldsBetaAppLocalization.TvOsPrivacyPolicy,
                _ => null,
            };
        }
    }
}