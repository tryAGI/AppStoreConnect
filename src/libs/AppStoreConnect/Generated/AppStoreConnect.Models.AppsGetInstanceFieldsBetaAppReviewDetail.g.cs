
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppsGetInstanceFieldsBetaAppReviewDetail
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
    public static class AppsGetInstanceFieldsBetaAppReviewDetailExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsGetInstanceFieldsBetaAppReviewDetail value)
        {
            return value switch
            {
                AppsGetInstanceFieldsBetaAppReviewDetail.App => "app",
                AppsGetInstanceFieldsBetaAppReviewDetail.ContactEmail => "contactEmail",
                AppsGetInstanceFieldsBetaAppReviewDetail.ContactFirstName => "contactFirstName",
                AppsGetInstanceFieldsBetaAppReviewDetail.ContactLastName => "contactLastName",
                AppsGetInstanceFieldsBetaAppReviewDetail.ContactPhone => "contactPhone",
                AppsGetInstanceFieldsBetaAppReviewDetail.DemoAccountName => "demoAccountName",
                AppsGetInstanceFieldsBetaAppReviewDetail.DemoAccountPassword => "demoAccountPassword",
                AppsGetInstanceFieldsBetaAppReviewDetail.DemoAccountRequired => "demoAccountRequired",
                AppsGetInstanceFieldsBetaAppReviewDetail.Notes => "notes",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsGetInstanceFieldsBetaAppReviewDetail? ToEnum(string value)
        {
            return value switch
            {
                "app" => AppsGetInstanceFieldsBetaAppReviewDetail.App,
                "contactEmail" => AppsGetInstanceFieldsBetaAppReviewDetail.ContactEmail,
                "contactFirstName" => AppsGetInstanceFieldsBetaAppReviewDetail.ContactFirstName,
                "contactLastName" => AppsGetInstanceFieldsBetaAppReviewDetail.ContactLastName,
                "contactPhone" => AppsGetInstanceFieldsBetaAppReviewDetail.ContactPhone,
                "demoAccountName" => AppsGetInstanceFieldsBetaAppReviewDetail.DemoAccountName,
                "demoAccountPassword" => AppsGetInstanceFieldsBetaAppReviewDetail.DemoAccountPassword,
                "demoAccountRequired" => AppsGetInstanceFieldsBetaAppReviewDetail.DemoAccountRequired,
                "notes" => AppsGetInstanceFieldsBetaAppReviewDetail.Notes,
                _ => null,
            };
        }
    }
}