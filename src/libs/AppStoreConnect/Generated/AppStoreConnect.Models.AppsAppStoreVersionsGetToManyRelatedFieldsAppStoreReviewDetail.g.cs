
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreReviewDetail
    {
        /// <summary>
        ///
        /// </summary>
        AppStoreReviewAttachments,
        /// <summary>
        ///
        /// </summary>
        AppStoreVersion,
        /// <summary>
        ///
        /// </summary>
        ContactEmail,
        /// <summary>
        ///
        /// </summary>
        ContactFirstName,
        /// <summary>
        ///
        /// </summary>
        ContactLastName,
        /// <summary>
        ///
        /// </summary>
        ContactPhone,
        /// <summary>
        ///
        /// </summary>
        DemoAccountName,
        /// <summary>
        ///
        /// </summary>
        DemoAccountPassword,
        /// <summary>
        ///
        /// </summary>
        DemoAccountRequired,
        /// <summary>
        ///
        /// </summary>
        Notes,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreReviewDetailExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreReviewDetail value)
        {
            return value switch
            {
                AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreReviewDetail.AppStoreReviewAttachments => "appStoreReviewAttachments",
                AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreReviewDetail.AppStoreVersion => "appStoreVersion",
                AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreReviewDetail.ContactEmail => "contactEmail",
                AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreReviewDetail.ContactFirstName => "contactFirstName",
                AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreReviewDetail.ContactLastName => "contactLastName",
                AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreReviewDetail.ContactPhone => "contactPhone",
                AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreReviewDetail.DemoAccountName => "demoAccountName",
                AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreReviewDetail.DemoAccountPassword => "demoAccountPassword",
                AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreReviewDetail.DemoAccountRequired => "demoAccountRequired",
                AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreReviewDetail.Notes => "notes",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreReviewDetail? ToEnum(string value)
        {
            return value switch
            {
                "appStoreReviewAttachments" => AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreReviewDetail.AppStoreReviewAttachments,
                "appStoreVersion" => AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreReviewDetail.AppStoreVersion,
                "contactEmail" => AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreReviewDetail.ContactEmail,
                "contactFirstName" => AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreReviewDetail.ContactFirstName,
                "contactLastName" => AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreReviewDetail.ContactLastName,
                "contactPhone" => AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreReviewDetail.ContactPhone,
                "demoAccountName" => AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreReviewDetail.DemoAccountName,
                "demoAccountPassword" => AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreReviewDetail.DemoAccountPassword,
                "demoAccountRequired" => AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreReviewDetail.DemoAccountRequired,
                "notes" => AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreReviewDetail.Notes,
                _ => null,
            };
        }
    }
}