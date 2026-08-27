
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppInfoLocalizationsGetInstanceFieldsAppInfoLocalization
    {
        /// <summary>
        ///
        /// </summary>
        AppInfo,
        /// <summary>
        ///
        /// </summary>
        Locale,
        /// <summary>
        ///
        /// </summary>
        Name,
        /// <summary>
        ///
        /// </summary>
        PrivacyChoicesUrl,
        /// <summary>
        ///
        /// </summary>
        PrivacyPolicyText,
        /// <summary>
        ///
        /// </summary>
        PrivacyPolicyUrl,
        /// <summary>
        ///
        /// </summary>
        Subtitle,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppInfoLocalizationsGetInstanceFieldsAppInfoLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppInfoLocalizationsGetInstanceFieldsAppInfoLocalization value)
        {
            return value switch
            {
                AppInfoLocalizationsGetInstanceFieldsAppInfoLocalization.AppInfo => "appInfo",
                AppInfoLocalizationsGetInstanceFieldsAppInfoLocalization.Locale => "locale",
                AppInfoLocalizationsGetInstanceFieldsAppInfoLocalization.Name => "name",
                AppInfoLocalizationsGetInstanceFieldsAppInfoLocalization.PrivacyChoicesUrl => "privacyChoicesUrl",
                AppInfoLocalizationsGetInstanceFieldsAppInfoLocalization.PrivacyPolicyText => "privacyPolicyText",
                AppInfoLocalizationsGetInstanceFieldsAppInfoLocalization.PrivacyPolicyUrl => "privacyPolicyUrl",
                AppInfoLocalizationsGetInstanceFieldsAppInfoLocalization.Subtitle => "subtitle",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppInfoLocalizationsGetInstanceFieldsAppInfoLocalization? ToEnum(string value)
        {
            return value switch
            {
                "appInfo" => AppInfoLocalizationsGetInstanceFieldsAppInfoLocalization.AppInfo,
                "locale" => AppInfoLocalizationsGetInstanceFieldsAppInfoLocalization.Locale,
                "name" => AppInfoLocalizationsGetInstanceFieldsAppInfoLocalization.Name,
                "privacyChoicesUrl" => AppInfoLocalizationsGetInstanceFieldsAppInfoLocalization.PrivacyChoicesUrl,
                "privacyPolicyText" => AppInfoLocalizationsGetInstanceFieldsAppInfoLocalization.PrivacyPolicyText,
                "privacyPolicyUrl" => AppInfoLocalizationsGetInstanceFieldsAppInfoLocalization.PrivacyPolicyUrl,
                "subtitle" => AppInfoLocalizationsGetInstanceFieldsAppInfoLocalization.Subtitle,
                _ => null,
            };
        }
    }
}