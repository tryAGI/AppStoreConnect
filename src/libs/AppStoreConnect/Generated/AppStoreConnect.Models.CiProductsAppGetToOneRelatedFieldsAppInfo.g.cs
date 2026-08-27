
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CiProductsAppGetToOneRelatedFieldsAppInfo
    {
        /// <summary>
        ///
        /// </summary>
        AgeRatingDeclaration,
        /// <summary>
        ///
        /// </summary>
        App,
        /// <summary>
        ///
        /// </summary>
        AppInfoLocalizations,
        /// <summary>
        ///
        /// </summary>
        AppStoreAgeRating,
        /// <summary>
        ///
        /// </summary>
        AppStoreState,
        /// <summary>
        ///
        /// </summary>
        AustraliaAgeRating,
        /// <summary>
        ///
        /// </summary>
        BrazilAgeRating,
        /// <summary>
        ///
        /// </summary>
        BrazilAgeRatingV2,
        /// <summary>
        ///
        /// </summary>
        FranceAgeRating,
        /// <summary>
        ///
        /// </summary>
        KidsAgeBand,
        /// <summary>
        ///
        /// </summary>
        KoreaAgeRating,
        /// <summary>
        ///
        /// </summary>
        PrimaryCategory,
        /// <summary>
        ///
        /// </summary>
        PrimarySubcategoryOne,
        /// <summary>
        ///
        /// </summary>
        PrimarySubcategoryTwo,
        /// <summary>
        ///
        /// </summary>
        SecondaryCategory,
        /// <summary>
        ///
        /// </summary>
        SecondarySubcategoryOne,
        /// <summary>
        ///
        /// </summary>
        SecondarySubcategoryTwo,
        /// <summary>
        ///
        /// </summary>
        State,
        /// <summary>
        ///
        /// </summary>
        TerritoryAgeRatings,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CiProductsAppGetToOneRelatedFieldsAppInfoExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiProductsAppGetToOneRelatedFieldsAppInfo value)
        {
            return value switch
            {
                CiProductsAppGetToOneRelatedFieldsAppInfo.AgeRatingDeclaration => "ageRatingDeclaration",
                CiProductsAppGetToOneRelatedFieldsAppInfo.App => "app",
                CiProductsAppGetToOneRelatedFieldsAppInfo.AppInfoLocalizations => "appInfoLocalizations",
                CiProductsAppGetToOneRelatedFieldsAppInfo.AppStoreAgeRating => "appStoreAgeRating",
                CiProductsAppGetToOneRelatedFieldsAppInfo.AppStoreState => "appStoreState",
                CiProductsAppGetToOneRelatedFieldsAppInfo.AustraliaAgeRating => "australiaAgeRating",
                CiProductsAppGetToOneRelatedFieldsAppInfo.BrazilAgeRating => "brazilAgeRating",
                CiProductsAppGetToOneRelatedFieldsAppInfo.BrazilAgeRatingV2 => "brazilAgeRatingV2",
                CiProductsAppGetToOneRelatedFieldsAppInfo.FranceAgeRating => "franceAgeRating",
                CiProductsAppGetToOneRelatedFieldsAppInfo.KidsAgeBand => "kidsAgeBand",
                CiProductsAppGetToOneRelatedFieldsAppInfo.KoreaAgeRating => "koreaAgeRating",
                CiProductsAppGetToOneRelatedFieldsAppInfo.PrimaryCategory => "primaryCategory",
                CiProductsAppGetToOneRelatedFieldsAppInfo.PrimarySubcategoryOne => "primarySubcategoryOne",
                CiProductsAppGetToOneRelatedFieldsAppInfo.PrimarySubcategoryTwo => "primarySubcategoryTwo",
                CiProductsAppGetToOneRelatedFieldsAppInfo.SecondaryCategory => "secondaryCategory",
                CiProductsAppGetToOneRelatedFieldsAppInfo.SecondarySubcategoryOne => "secondarySubcategoryOne",
                CiProductsAppGetToOneRelatedFieldsAppInfo.SecondarySubcategoryTwo => "secondarySubcategoryTwo",
                CiProductsAppGetToOneRelatedFieldsAppInfo.State => "state",
                CiProductsAppGetToOneRelatedFieldsAppInfo.TerritoryAgeRatings => "territoryAgeRatings",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiProductsAppGetToOneRelatedFieldsAppInfo? ToEnum(string value)
        {
            return value switch
            {
                "ageRatingDeclaration" => CiProductsAppGetToOneRelatedFieldsAppInfo.AgeRatingDeclaration,
                "app" => CiProductsAppGetToOneRelatedFieldsAppInfo.App,
                "appInfoLocalizations" => CiProductsAppGetToOneRelatedFieldsAppInfo.AppInfoLocalizations,
                "appStoreAgeRating" => CiProductsAppGetToOneRelatedFieldsAppInfo.AppStoreAgeRating,
                "appStoreState" => CiProductsAppGetToOneRelatedFieldsAppInfo.AppStoreState,
                "australiaAgeRating" => CiProductsAppGetToOneRelatedFieldsAppInfo.AustraliaAgeRating,
                "brazilAgeRating" => CiProductsAppGetToOneRelatedFieldsAppInfo.BrazilAgeRating,
                "brazilAgeRatingV2" => CiProductsAppGetToOneRelatedFieldsAppInfo.BrazilAgeRatingV2,
                "franceAgeRating" => CiProductsAppGetToOneRelatedFieldsAppInfo.FranceAgeRating,
                "kidsAgeBand" => CiProductsAppGetToOneRelatedFieldsAppInfo.KidsAgeBand,
                "koreaAgeRating" => CiProductsAppGetToOneRelatedFieldsAppInfo.KoreaAgeRating,
                "primaryCategory" => CiProductsAppGetToOneRelatedFieldsAppInfo.PrimaryCategory,
                "primarySubcategoryOne" => CiProductsAppGetToOneRelatedFieldsAppInfo.PrimarySubcategoryOne,
                "primarySubcategoryTwo" => CiProductsAppGetToOneRelatedFieldsAppInfo.PrimarySubcategoryTwo,
                "secondaryCategory" => CiProductsAppGetToOneRelatedFieldsAppInfo.SecondaryCategory,
                "secondarySubcategoryOne" => CiProductsAppGetToOneRelatedFieldsAppInfo.SecondarySubcategoryOne,
                "secondarySubcategoryTwo" => CiProductsAppGetToOneRelatedFieldsAppInfo.SecondarySubcategoryTwo,
                "state" => CiProductsAppGetToOneRelatedFieldsAppInfo.State,
                "territoryAgeRatings" => CiProductsAppGetToOneRelatedFieldsAppInfo.TerritoryAgeRatings,
                _ => null,
            };
        }
    }
}