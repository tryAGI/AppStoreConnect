
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreReviewDetail
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
    public static class BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreReviewDetailExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreReviewDetail value)
        {
            return value switch
            {
                BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreReviewDetail.AppStoreReviewAttachments => "appStoreReviewAttachments",
                BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreReviewDetail.AppStoreVersion => "appStoreVersion",
                BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreReviewDetail.ContactEmail => "contactEmail",
                BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreReviewDetail.ContactFirstName => "contactFirstName",
                BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreReviewDetail.ContactLastName => "contactLastName",
                BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreReviewDetail.ContactPhone => "contactPhone",
                BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreReviewDetail.DemoAccountName => "demoAccountName",
                BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreReviewDetail.DemoAccountPassword => "demoAccountPassword",
                BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreReviewDetail.DemoAccountRequired => "demoAccountRequired",
                BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreReviewDetail.Notes => "notes",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreReviewDetail? ToEnum(string value)
        {
            return value switch
            {
                "appStoreReviewAttachments" => BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreReviewDetail.AppStoreReviewAttachments,
                "appStoreVersion" => BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreReviewDetail.AppStoreVersion,
                "contactEmail" => BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreReviewDetail.ContactEmail,
                "contactFirstName" => BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreReviewDetail.ContactFirstName,
                "contactLastName" => BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreReviewDetail.ContactLastName,
                "contactPhone" => BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreReviewDetail.ContactPhone,
                "demoAccountName" => BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreReviewDetail.DemoAccountName,
                "demoAccountPassword" => BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreReviewDetail.DemoAccountPassword,
                "demoAccountRequired" => BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreReviewDetail.DemoAccountRequired,
                "notes" => BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreReviewDetail.Notes,
                _ => null,
            };
        }
    }
}