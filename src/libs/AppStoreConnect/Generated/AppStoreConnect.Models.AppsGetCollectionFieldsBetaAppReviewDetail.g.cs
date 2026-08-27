
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppsGetCollectionFieldsBetaAppReviewDetail
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
    public static class AppsGetCollectionFieldsBetaAppReviewDetailExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsGetCollectionFieldsBetaAppReviewDetail value)
        {
            return value switch
            {
                AppsGetCollectionFieldsBetaAppReviewDetail.App => "app",
                AppsGetCollectionFieldsBetaAppReviewDetail.ContactEmail => "contactEmail",
                AppsGetCollectionFieldsBetaAppReviewDetail.ContactFirstName => "contactFirstName",
                AppsGetCollectionFieldsBetaAppReviewDetail.ContactLastName => "contactLastName",
                AppsGetCollectionFieldsBetaAppReviewDetail.ContactPhone => "contactPhone",
                AppsGetCollectionFieldsBetaAppReviewDetail.DemoAccountName => "demoAccountName",
                AppsGetCollectionFieldsBetaAppReviewDetail.DemoAccountPassword => "demoAccountPassword",
                AppsGetCollectionFieldsBetaAppReviewDetail.DemoAccountRequired => "demoAccountRequired",
                AppsGetCollectionFieldsBetaAppReviewDetail.Notes => "notes",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsGetCollectionFieldsBetaAppReviewDetail? ToEnum(string value)
        {
            return value switch
            {
                "app" => AppsGetCollectionFieldsBetaAppReviewDetail.App,
                "contactEmail" => AppsGetCollectionFieldsBetaAppReviewDetail.ContactEmail,
                "contactFirstName" => AppsGetCollectionFieldsBetaAppReviewDetail.ContactFirstName,
                "contactLastName" => AppsGetCollectionFieldsBetaAppReviewDetail.ContactLastName,
                "contactPhone" => AppsGetCollectionFieldsBetaAppReviewDetail.ContactPhone,
                "demoAccountName" => AppsGetCollectionFieldsBetaAppReviewDetail.DemoAccountName,
                "demoAccountPassword" => AppsGetCollectionFieldsBetaAppReviewDetail.DemoAccountPassword,
                "demoAccountRequired" => AppsGetCollectionFieldsBetaAppReviewDetail.DemoAccountRequired,
                "notes" => AppsGetCollectionFieldsBetaAppReviewDetail.Notes,
                _ => null,
            };
        }
    }
}