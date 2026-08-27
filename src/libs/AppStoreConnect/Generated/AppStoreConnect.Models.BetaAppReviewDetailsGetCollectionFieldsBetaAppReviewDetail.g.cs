
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaAppReviewDetailsGetCollectionFieldsBetaAppReviewDetail
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
    public static class BetaAppReviewDetailsGetCollectionFieldsBetaAppReviewDetailExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaAppReviewDetailsGetCollectionFieldsBetaAppReviewDetail value)
        {
            return value switch
            {
                BetaAppReviewDetailsGetCollectionFieldsBetaAppReviewDetail.App => "app",
                BetaAppReviewDetailsGetCollectionFieldsBetaAppReviewDetail.ContactEmail => "contactEmail",
                BetaAppReviewDetailsGetCollectionFieldsBetaAppReviewDetail.ContactFirstName => "contactFirstName",
                BetaAppReviewDetailsGetCollectionFieldsBetaAppReviewDetail.ContactLastName => "contactLastName",
                BetaAppReviewDetailsGetCollectionFieldsBetaAppReviewDetail.ContactPhone => "contactPhone",
                BetaAppReviewDetailsGetCollectionFieldsBetaAppReviewDetail.DemoAccountName => "demoAccountName",
                BetaAppReviewDetailsGetCollectionFieldsBetaAppReviewDetail.DemoAccountPassword => "demoAccountPassword",
                BetaAppReviewDetailsGetCollectionFieldsBetaAppReviewDetail.DemoAccountRequired => "demoAccountRequired",
                BetaAppReviewDetailsGetCollectionFieldsBetaAppReviewDetail.Notes => "notes",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaAppReviewDetailsGetCollectionFieldsBetaAppReviewDetail? ToEnum(string value)
        {
            return value switch
            {
                "app" => BetaAppReviewDetailsGetCollectionFieldsBetaAppReviewDetail.App,
                "contactEmail" => BetaAppReviewDetailsGetCollectionFieldsBetaAppReviewDetail.ContactEmail,
                "contactFirstName" => BetaAppReviewDetailsGetCollectionFieldsBetaAppReviewDetail.ContactFirstName,
                "contactLastName" => BetaAppReviewDetailsGetCollectionFieldsBetaAppReviewDetail.ContactLastName,
                "contactPhone" => BetaAppReviewDetailsGetCollectionFieldsBetaAppReviewDetail.ContactPhone,
                "demoAccountName" => BetaAppReviewDetailsGetCollectionFieldsBetaAppReviewDetail.DemoAccountName,
                "demoAccountPassword" => BetaAppReviewDetailsGetCollectionFieldsBetaAppReviewDetail.DemoAccountPassword,
                "demoAccountRequired" => BetaAppReviewDetailsGetCollectionFieldsBetaAppReviewDetail.DemoAccountRequired,
                "notes" => BetaAppReviewDetailsGetCollectionFieldsBetaAppReviewDetail.Notes,
                _ => null,
            };
        }
    }
}