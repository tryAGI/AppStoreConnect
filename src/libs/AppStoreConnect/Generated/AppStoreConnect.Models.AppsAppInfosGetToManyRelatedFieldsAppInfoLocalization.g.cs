
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppsAppInfosGetToManyRelatedFieldsAppInfoLocalization
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
    public static class AppsAppInfosGetToManyRelatedFieldsAppInfoLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsAppInfosGetToManyRelatedFieldsAppInfoLocalization value)
        {
            return value switch
            {
                AppsAppInfosGetToManyRelatedFieldsAppInfoLocalization.AppInfo => "appInfo",
                AppsAppInfosGetToManyRelatedFieldsAppInfoLocalization.Locale => "locale",
                AppsAppInfosGetToManyRelatedFieldsAppInfoLocalization.Name => "name",
                AppsAppInfosGetToManyRelatedFieldsAppInfoLocalization.PrivacyChoicesUrl => "privacyChoicesUrl",
                AppsAppInfosGetToManyRelatedFieldsAppInfoLocalization.PrivacyPolicyText => "privacyPolicyText",
                AppsAppInfosGetToManyRelatedFieldsAppInfoLocalization.PrivacyPolicyUrl => "privacyPolicyUrl",
                AppsAppInfosGetToManyRelatedFieldsAppInfoLocalization.Subtitle => "subtitle",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsAppInfosGetToManyRelatedFieldsAppInfoLocalization? ToEnum(string value)
        {
            return value switch
            {
                "appInfo" => AppsAppInfosGetToManyRelatedFieldsAppInfoLocalization.AppInfo,
                "locale" => AppsAppInfosGetToManyRelatedFieldsAppInfoLocalization.Locale,
                "name" => AppsAppInfosGetToManyRelatedFieldsAppInfoLocalization.Name,
                "privacyChoicesUrl" => AppsAppInfosGetToManyRelatedFieldsAppInfoLocalization.PrivacyChoicesUrl,
                "privacyPolicyText" => AppsAppInfosGetToManyRelatedFieldsAppInfoLocalization.PrivacyPolicyText,
                "privacyPolicyUrl" => AppsAppInfosGetToManyRelatedFieldsAppInfoLocalization.PrivacyPolicyUrl,
                "subtitle" => AppsAppInfosGetToManyRelatedFieldsAppInfoLocalization.Subtitle,
                _ => null,
            };
        }
    }
}