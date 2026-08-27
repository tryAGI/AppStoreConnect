
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppsGetInstanceFieldsAppInfo
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
    public static class AppsGetInstanceFieldsAppInfoExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsGetInstanceFieldsAppInfo value)
        {
            return value switch
            {
                AppsGetInstanceFieldsAppInfo.AgeRatingDeclaration => "ageRatingDeclaration",
                AppsGetInstanceFieldsAppInfo.App => "app",
                AppsGetInstanceFieldsAppInfo.AppInfoLocalizations => "appInfoLocalizations",
                AppsGetInstanceFieldsAppInfo.AppStoreAgeRating => "appStoreAgeRating",
                AppsGetInstanceFieldsAppInfo.AppStoreState => "appStoreState",
                AppsGetInstanceFieldsAppInfo.AustraliaAgeRating => "australiaAgeRating",
                AppsGetInstanceFieldsAppInfo.BrazilAgeRating => "brazilAgeRating",
                AppsGetInstanceFieldsAppInfo.BrazilAgeRatingV2 => "brazilAgeRatingV2",
                AppsGetInstanceFieldsAppInfo.FranceAgeRating => "franceAgeRating",
                AppsGetInstanceFieldsAppInfo.KidsAgeBand => "kidsAgeBand",
                AppsGetInstanceFieldsAppInfo.KoreaAgeRating => "koreaAgeRating",
                AppsGetInstanceFieldsAppInfo.PrimaryCategory => "primaryCategory",
                AppsGetInstanceFieldsAppInfo.PrimarySubcategoryOne => "primarySubcategoryOne",
                AppsGetInstanceFieldsAppInfo.PrimarySubcategoryTwo => "primarySubcategoryTwo",
                AppsGetInstanceFieldsAppInfo.SecondaryCategory => "secondaryCategory",
                AppsGetInstanceFieldsAppInfo.SecondarySubcategoryOne => "secondarySubcategoryOne",
                AppsGetInstanceFieldsAppInfo.SecondarySubcategoryTwo => "secondarySubcategoryTwo",
                AppsGetInstanceFieldsAppInfo.State => "state",
                AppsGetInstanceFieldsAppInfo.TerritoryAgeRatings => "territoryAgeRatings",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsGetInstanceFieldsAppInfo? ToEnum(string value)
        {
            return value switch
            {
                "ageRatingDeclaration" => AppsGetInstanceFieldsAppInfo.AgeRatingDeclaration,
                "app" => AppsGetInstanceFieldsAppInfo.App,
                "appInfoLocalizations" => AppsGetInstanceFieldsAppInfo.AppInfoLocalizations,
                "appStoreAgeRating" => AppsGetInstanceFieldsAppInfo.AppStoreAgeRating,
                "appStoreState" => AppsGetInstanceFieldsAppInfo.AppStoreState,
                "australiaAgeRating" => AppsGetInstanceFieldsAppInfo.AustraliaAgeRating,
                "brazilAgeRating" => AppsGetInstanceFieldsAppInfo.BrazilAgeRating,
                "brazilAgeRatingV2" => AppsGetInstanceFieldsAppInfo.BrazilAgeRatingV2,
                "franceAgeRating" => AppsGetInstanceFieldsAppInfo.FranceAgeRating,
                "kidsAgeBand" => AppsGetInstanceFieldsAppInfo.KidsAgeBand,
                "koreaAgeRating" => AppsGetInstanceFieldsAppInfo.KoreaAgeRating,
                "primaryCategory" => AppsGetInstanceFieldsAppInfo.PrimaryCategory,
                "primarySubcategoryOne" => AppsGetInstanceFieldsAppInfo.PrimarySubcategoryOne,
                "primarySubcategoryTwo" => AppsGetInstanceFieldsAppInfo.PrimarySubcategoryTwo,
                "secondaryCategory" => AppsGetInstanceFieldsAppInfo.SecondaryCategory,
                "secondarySubcategoryOne" => AppsGetInstanceFieldsAppInfo.SecondarySubcategoryOne,
                "secondarySubcategoryTwo" => AppsGetInstanceFieldsAppInfo.SecondarySubcategoryTwo,
                "state" => AppsGetInstanceFieldsAppInfo.State,
                "territoryAgeRatings" => AppsGetInstanceFieldsAppInfo.TerritoryAgeRatings,
                _ => null,
            };
        }
    }
}