
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreReviewDetail
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
    public static class GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreReviewDetailExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreReviewDetail value)
        {
            return value switch
            {
                GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreReviewDetail.AppStoreReviewAttachments => "appStoreReviewAttachments",
                GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreReviewDetail.AppStoreVersion => "appStoreVersion",
                GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreReviewDetail.ContactEmail => "contactEmail",
                GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreReviewDetail.ContactFirstName => "contactFirstName",
                GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreReviewDetail.ContactLastName => "contactLastName",
                GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreReviewDetail.ContactPhone => "contactPhone",
                GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreReviewDetail.DemoAccountName => "demoAccountName",
                GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreReviewDetail.DemoAccountPassword => "demoAccountPassword",
                GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreReviewDetail.DemoAccountRequired => "demoAccountRequired",
                GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreReviewDetail.Notes => "notes",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreReviewDetail? ToEnum(string value)
        {
            return value switch
            {
                "appStoreReviewAttachments" => GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreReviewDetail.AppStoreReviewAttachments,
                "appStoreVersion" => GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreReviewDetail.AppStoreVersion,
                "contactEmail" => GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreReviewDetail.ContactEmail,
                "contactFirstName" => GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreReviewDetail.ContactFirstName,
                "contactLastName" => GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreReviewDetail.ContactLastName,
                "contactPhone" => GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreReviewDetail.ContactPhone,
                "demoAccountName" => GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreReviewDetail.DemoAccountName,
                "demoAccountPassword" => GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreReviewDetail.DemoAccountPassword,
                "demoAccountRequired" => GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreReviewDetail.DemoAccountRequired,
                "notes" => GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreReviewDetail.Notes,
                _ => null,
            };
        }
    }
}