
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppsBetaAppReviewDetailGetToOneRelatedFieldsBetaAppReviewDetail
    {
        /// <summary>
        ///
        /// </summary>
        App,
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
    public static class AppsBetaAppReviewDetailGetToOneRelatedFieldsBetaAppReviewDetailExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsBetaAppReviewDetailGetToOneRelatedFieldsBetaAppReviewDetail value)
        {
            return value switch
            {
                AppsBetaAppReviewDetailGetToOneRelatedFieldsBetaAppReviewDetail.App => "app",
                AppsBetaAppReviewDetailGetToOneRelatedFieldsBetaAppReviewDetail.ContactEmail => "contactEmail",
                AppsBetaAppReviewDetailGetToOneRelatedFieldsBetaAppReviewDetail.ContactFirstName => "contactFirstName",
                AppsBetaAppReviewDetailGetToOneRelatedFieldsBetaAppReviewDetail.ContactLastName => "contactLastName",
                AppsBetaAppReviewDetailGetToOneRelatedFieldsBetaAppReviewDetail.ContactPhone => "contactPhone",
                AppsBetaAppReviewDetailGetToOneRelatedFieldsBetaAppReviewDetail.DemoAccountName => "demoAccountName",
                AppsBetaAppReviewDetailGetToOneRelatedFieldsBetaAppReviewDetail.DemoAccountPassword => "demoAccountPassword",
                AppsBetaAppReviewDetailGetToOneRelatedFieldsBetaAppReviewDetail.DemoAccountRequired => "demoAccountRequired",
                AppsBetaAppReviewDetailGetToOneRelatedFieldsBetaAppReviewDetail.Notes => "notes",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsBetaAppReviewDetailGetToOneRelatedFieldsBetaAppReviewDetail? ToEnum(string value)
        {
            return value switch
            {
                "app" => AppsBetaAppReviewDetailGetToOneRelatedFieldsBetaAppReviewDetail.App,
                "contactEmail" => AppsBetaAppReviewDetailGetToOneRelatedFieldsBetaAppReviewDetail.ContactEmail,
                "contactFirstName" => AppsBetaAppReviewDetailGetToOneRelatedFieldsBetaAppReviewDetail.ContactFirstName,
                "contactLastName" => AppsBetaAppReviewDetailGetToOneRelatedFieldsBetaAppReviewDetail.ContactLastName,
                "contactPhone" => AppsBetaAppReviewDetailGetToOneRelatedFieldsBetaAppReviewDetail.ContactPhone,
                "demoAccountName" => AppsBetaAppReviewDetailGetToOneRelatedFieldsBetaAppReviewDetail.DemoAccountName,
                "demoAccountPassword" => AppsBetaAppReviewDetailGetToOneRelatedFieldsBetaAppReviewDetail.DemoAccountPassword,
                "demoAccountRequired" => AppsBetaAppReviewDetailGetToOneRelatedFieldsBetaAppReviewDetail.DemoAccountRequired,
                "notes" => AppsBetaAppReviewDetailGetToOneRelatedFieldsBetaAppReviewDetail.Notes,
                _ => null,
            };
        }
    }
}