
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaAppReviewDetailsGetInstanceFieldsBetaAppReviewDetail
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
    public static class BetaAppReviewDetailsGetInstanceFieldsBetaAppReviewDetailExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaAppReviewDetailsGetInstanceFieldsBetaAppReviewDetail value)
        {
            return value switch
            {
                BetaAppReviewDetailsGetInstanceFieldsBetaAppReviewDetail.App => "app",
                BetaAppReviewDetailsGetInstanceFieldsBetaAppReviewDetail.ContactEmail => "contactEmail",
                BetaAppReviewDetailsGetInstanceFieldsBetaAppReviewDetail.ContactFirstName => "contactFirstName",
                BetaAppReviewDetailsGetInstanceFieldsBetaAppReviewDetail.ContactLastName => "contactLastName",
                BetaAppReviewDetailsGetInstanceFieldsBetaAppReviewDetail.ContactPhone => "contactPhone",
                BetaAppReviewDetailsGetInstanceFieldsBetaAppReviewDetail.DemoAccountName => "demoAccountName",
                BetaAppReviewDetailsGetInstanceFieldsBetaAppReviewDetail.DemoAccountPassword => "demoAccountPassword",
                BetaAppReviewDetailsGetInstanceFieldsBetaAppReviewDetail.DemoAccountRequired => "demoAccountRequired",
                BetaAppReviewDetailsGetInstanceFieldsBetaAppReviewDetail.Notes => "notes",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaAppReviewDetailsGetInstanceFieldsBetaAppReviewDetail? ToEnum(string value)
        {
            return value switch
            {
                "app" => BetaAppReviewDetailsGetInstanceFieldsBetaAppReviewDetail.App,
                "contactEmail" => BetaAppReviewDetailsGetInstanceFieldsBetaAppReviewDetail.ContactEmail,
                "contactFirstName" => BetaAppReviewDetailsGetInstanceFieldsBetaAppReviewDetail.ContactFirstName,
                "contactLastName" => BetaAppReviewDetailsGetInstanceFieldsBetaAppReviewDetail.ContactLastName,
                "contactPhone" => BetaAppReviewDetailsGetInstanceFieldsBetaAppReviewDetail.ContactPhone,
                "demoAccountName" => BetaAppReviewDetailsGetInstanceFieldsBetaAppReviewDetail.DemoAccountName,
                "demoAccountPassword" => BetaAppReviewDetailsGetInstanceFieldsBetaAppReviewDetail.DemoAccountPassword,
                "demoAccountRequired" => BetaAppReviewDetailsGetInstanceFieldsBetaAppReviewDetail.DemoAccountRequired,
                "notes" => BetaAppReviewDetailsGetInstanceFieldsBetaAppReviewDetail.Notes,
                _ => null,
            };
        }
    }
}