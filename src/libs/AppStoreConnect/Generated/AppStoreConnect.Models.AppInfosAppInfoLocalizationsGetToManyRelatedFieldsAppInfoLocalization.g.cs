
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppInfosAppInfoLocalizationsGetToManyRelatedFieldsAppInfoLocalization
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
    public static class AppInfosAppInfoLocalizationsGetToManyRelatedFieldsAppInfoLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppInfosAppInfoLocalizationsGetToManyRelatedFieldsAppInfoLocalization value)
        {
            return value switch
            {
                AppInfosAppInfoLocalizationsGetToManyRelatedFieldsAppInfoLocalization.AppInfo => "appInfo",
                AppInfosAppInfoLocalizationsGetToManyRelatedFieldsAppInfoLocalization.Locale => "locale",
                AppInfosAppInfoLocalizationsGetToManyRelatedFieldsAppInfoLocalization.Name => "name",
                AppInfosAppInfoLocalizationsGetToManyRelatedFieldsAppInfoLocalization.PrivacyChoicesUrl => "privacyChoicesUrl",
                AppInfosAppInfoLocalizationsGetToManyRelatedFieldsAppInfoLocalization.PrivacyPolicyText => "privacyPolicyText",
                AppInfosAppInfoLocalizationsGetToManyRelatedFieldsAppInfoLocalization.PrivacyPolicyUrl => "privacyPolicyUrl",
                AppInfosAppInfoLocalizationsGetToManyRelatedFieldsAppInfoLocalization.Subtitle => "subtitle",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppInfosAppInfoLocalizationsGetToManyRelatedFieldsAppInfoLocalization? ToEnum(string value)
        {
            return value switch
            {
                "appInfo" => AppInfosAppInfoLocalizationsGetToManyRelatedFieldsAppInfoLocalization.AppInfo,
                "locale" => AppInfosAppInfoLocalizationsGetToManyRelatedFieldsAppInfoLocalization.Locale,
                "name" => AppInfosAppInfoLocalizationsGetToManyRelatedFieldsAppInfoLocalization.Name,
                "privacyChoicesUrl" => AppInfosAppInfoLocalizationsGetToManyRelatedFieldsAppInfoLocalization.PrivacyChoicesUrl,
                "privacyPolicyText" => AppInfosAppInfoLocalizationsGetToManyRelatedFieldsAppInfoLocalization.PrivacyPolicyText,
                "privacyPolicyUrl" => AppInfosAppInfoLocalizationsGetToManyRelatedFieldsAppInfoLocalization.PrivacyPolicyUrl,
                "subtitle" => AppInfosAppInfoLocalizationsGetToManyRelatedFieldsAppInfoLocalization.Subtitle,
                _ => null,
            };
        }
    }
}