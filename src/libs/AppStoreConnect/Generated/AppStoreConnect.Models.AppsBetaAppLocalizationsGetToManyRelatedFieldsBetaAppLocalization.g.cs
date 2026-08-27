
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppsBetaAppLocalizationsGetToManyRelatedFieldsBetaAppLocalization
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
    public static class AppsBetaAppLocalizationsGetToManyRelatedFieldsBetaAppLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsBetaAppLocalizationsGetToManyRelatedFieldsBetaAppLocalization value)
        {
            return value switch
            {
                AppsBetaAppLocalizationsGetToManyRelatedFieldsBetaAppLocalization.App => "app",
                AppsBetaAppLocalizationsGetToManyRelatedFieldsBetaAppLocalization.Description => "description",
                AppsBetaAppLocalizationsGetToManyRelatedFieldsBetaAppLocalization.FeedbackEmail => "feedbackEmail",
                AppsBetaAppLocalizationsGetToManyRelatedFieldsBetaAppLocalization.Locale => "locale",
                AppsBetaAppLocalizationsGetToManyRelatedFieldsBetaAppLocalization.MarketingUrl => "marketingUrl",
                AppsBetaAppLocalizationsGetToManyRelatedFieldsBetaAppLocalization.PrivacyPolicyUrl => "privacyPolicyUrl",
                AppsBetaAppLocalizationsGetToManyRelatedFieldsBetaAppLocalization.TvOsPrivacyPolicy => "tvOsPrivacyPolicy",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsBetaAppLocalizationsGetToManyRelatedFieldsBetaAppLocalization? ToEnum(string value)
        {
            return value switch
            {
                "app" => AppsBetaAppLocalizationsGetToManyRelatedFieldsBetaAppLocalization.App,
                "description" => AppsBetaAppLocalizationsGetToManyRelatedFieldsBetaAppLocalization.Description,
                "feedbackEmail" => AppsBetaAppLocalizationsGetToManyRelatedFieldsBetaAppLocalization.FeedbackEmail,
                "locale" => AppsBetaAppLocalizationsGetToManyRelatedFieldsBetaAppLocalization.Locale,
                "marketingUrl" => AppsBetaAppLocalizationsGetToManyRelatedFieldsBetaAppLocalization.MarketingUrl,
                "privacyPolicyUrl" => AppsBetaAppLocalizationsGetToManyRelatedFieldsBetaAppLocalization.PrivacyPolicyUrl,
                "tvOsPrivacyPolicy" => AppsBetaAppLocalizationsGetToManyRelatedFieldsBetaAppLocalization.TvOsPrivacyPolicy,
                _ => null,
            };
        }
    }
}