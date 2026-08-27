
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppInfosGetInstanceFieldsAppInfoLocalization
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
    public static class AppInfosGetInstanceFieldsAppInfoLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppInfosGetInstanceFieldsAppInfoLocalization value)
        {
            return value switch
            {
                AppInfosGetInstanceFieldsAppInfoLocalization.AppInfo => "appInfo",
                AppInfosGetInstanceFieldsAppInfoLocalization.Locale => "locale",
                AppInfosGetInstanceFieldsAppInfoLocalization.Name => "name",
                AppInfosGetInstanceFieldsAppInfoLocalization.PrivacyChoicesUrl => "privacyChoicesUrl",
                AppInfosGetInstanceFieldsAppInfoLocalization.PrivacyPolicyText => "privacyPolicyText",
                AppInfosGetInstanceFieldsAppInfoLocalization.PrivacyPolicyUrl => "privacyPolicyUrl",
                AppInfosGetInstanceFieldsAppInfoLocalization.Subtitle => "subtitle",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppInfosGetInstanceFieldsAppInfoLocalization? ToEnum(string value)
        {
            return value switch
            {
                "appInfo" => AppInfosGetInstanceFieldsAppInfoLocalization.AppInfo,
                "locale" => AppInfosGetInstanceFieldsAppInfoLocalization.Locale,
                "name" => AppInfosGetInstanceFieldsAppInfoLocalization.Name,
                "privacyChoicesUrl" => AppInfosGetInstanceFieldsAppInfoLocalization.PrivacyChoicesUrl,
                "privacyPolicyText" => AppInfosGetInstanceFieldsAppInfoLocalization.PrivacyPolicyText,
                "privacyPolicyUrl" => AppInfosGetInstanceFieldsAppInfoLocalization.PrivacyPolicyUrl,
                "subtitle" => AppInfosGetInstanceFieldsAppInfoLocalization.Subtitle,
                _ => null,
            };
        }
    }
}