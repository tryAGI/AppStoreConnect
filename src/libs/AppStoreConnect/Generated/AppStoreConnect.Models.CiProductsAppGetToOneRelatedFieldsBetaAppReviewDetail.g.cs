
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CiProductsAppGetToOneRelatedFieldsBetaAppReviewDetail
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
    public static class CiProductsAppGetToOneRelatedFieldsBetaAppReviewDetailExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiProductsAppGetToOneRelatedFieldsBetaAppReviewDetail value)
        {
            return value switch
            {
                CiProductsAppGetToOneRelatedFieldsBetaAppReviewDetail.App => "app",
                CiProductsAppGetToOneRelatedFieldsBetaAppReviewDetail.ContactEmail => "contactEmail",
                CiProductsAppGetToOneRelatedFieldsBetaAppReviewDetail.ContactFirstName => "contactFirstName",
                CiProductsAppGetToOneRelatedFieldsBetaAppReviewDetail.ContactLastName => "contactLastName",
                CiProductsAppGetToOneRelatedFieldsBetaAppReviewDetail.ContactPhone => "contactPhone",
                CiProductsAppGetToOneRelatedFieldsBetaAppReviewDetail.DemoAccountName => "demoAccountName",
                CiProductsAppGetToOneRelatedFieldsBetaAppReviewDetail.DemoAccountPassword => "demoAccountPassword",
                CiProductsAppGetToOneRelatedFieldsBetaAppReviewDetail.DemoAccountRequired => "demoAccountRequired",
                CiProductsAppGetToOneRelatedFieldsBetaAppReviewDetail.Notes => "notes",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiProductsAppGetToOneRelatedFieldsBetaAppReviewDetail? ToEnum(string value)
        {
            return value switch
            {
                "app" => CiProductsAppGetToOneRelatedFieldsBetaAppReviewDetail.App,
                "contactEmail" => CiProductsAppGetToOneRelatedFieldsBetaAppReviewDetail.ContactEmail,
                "contactFirstName" => CiProductsAppGetToOneRelatedFieldsBetaAppReviewDetail.ContactFirstName,
                "contactLastName" => CiProductsAppGetToOneRelatedFieldsBetaAppReviewDetail.ContactLastName,
                "contactPhone" => CiProductsAppGetToOneRelatedFieldsBetaAppReviewDetail.ContactPhone,
                "demoAccountName" => CiProductsAppGetToOneRelatedFieldsBetaAppReviewDetail.DemoAccountName,
                "demoAccountPassword" => CiProductsAppGetToOneRelatedFieldsBetaAppReviewDetail.DemoAccountPassword,
                "demoAccountRequired" => CiProductsAppGetToOneRelatedFieldsBetaAppReviewDetail.DemoAccountRequired,
                "notes" => CiProductsAppGetToOneRelatedFieldsBetaAppReviewDetail.Notes,
                _ => null,
            };
        }
    }
}