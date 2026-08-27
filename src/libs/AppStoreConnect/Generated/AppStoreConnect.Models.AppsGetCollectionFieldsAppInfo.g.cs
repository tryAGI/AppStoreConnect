
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppsGetCollectionFieldsAppInfo
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
    public static class AppsGetCollectionFieldsAppInfoExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsGetCollectionFieldsAppInfo value)
        {
            return value switch
            {
                AppsGetCollectionFieldsAppInfo.AgeRatingDeclaration => "ageRatingDeclaration",
                AppsGetCollectionFieldsAppInfo.App => "app",
                AppsGetCollectionFieldsAppInfo.AppInfoLocalizations => "appInfoLocalizations",
                AppsGetCollectionFieldsAppInfo.AppStoreAgeRating => "appStoreAgeRating",
                AppsGetCollectionFieldsAppInfo.AppStoreState => "appStoreState",
                AppsGetCollectionFieldsAppInfo.AustraliaAgeRating => "australiaAgeRating",
                AppsGetCollectionFieldsAppInfo.BrazilAgeRating => "brazilAgeRating",
                AppsGetCollectionFieldsAppInfo.BrazilAgeRatingV2 => "brazilAgeRatingV2",
                AppsGetCollectionFieldsAppInfo.FranceAgeRating => "franceAgeRating",
                AppsGetCollectionFieldsAppInfo.KidsAgeBand => "kidsAgeBand",
                AppsGetCollectionFieldsAppInfo.KoreaAgeRating => "koreaAgeRating",
                AppsGetCollectionFieldsAppInfo.PrimaryCategory => "primaryCategory",
                AppsGetCollectionFieldsAppInfo.PrimarySubcategoryOne => "primarySubcategoryOne",
                AppsGetCollectionFieldsAppInfo.PrimarySubcategoryTwo => "primarySubcategoryTwo",
                AppsGetCollectionFieldsAppInfo.SecondaryCategory => "secondaryCategory",
                AppsGetCollectionFieldsAppInfo.SecondarySubcategoryOne => "secondarySubcategoryOne",
                AppsGetCollectionFieldsAppInfo.SecondarySubcategoryTwo => "secondarySubcategoryTwo",
                AppsGetCollectionFieldsAppInfo.State => "state",
                AppsGetCollectionFieldsAppInfo.TerritoryAgeRatings => "territoryAgeRatings",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsGetCollectionFieldsAppInfo? ToEnum(string value)
        {
            return value switch
            {
                "ageRatingDeclaration" => AppsGetCollectionFieldsAppInfo.AgeRatingDeclaration,
                "app" => AppsGetCollectionFieldsAppInfo.App,
                "appInfoLocalizations" => AppsGetCollectionFieldsAppInfo.AppInfoLocalizations,
                "appStoreAgeRating" => AppsGetCollectionFieldsAppInfo.AppStoreAgeRating,
                "appStoreState" => AppsGetCollectionFieldsAppInfo.AppStoreState,
                "australiaAgeRating" => AppsGetCollectionFieldsAppInfo.AustraliaAgeRating,
                "brazilAgeRating" => AppsGetCollectionFieldsAppInfo.BrazilAgeRating,
                "brazilAgeRatingV2" => AppsGetCollectionFieldsAppInfo.BrazilAgeRatingV2,
                "franceAgeRating" => AppsGetCollectionFieldsAppInfo.FranceAgeRating,
                "kidsAgeBand" => AppsGetCollectionFieldsAppInfo.KidsAgeBand,
                "koreaAgeRating" => AppsGetCollectionFieldsAppInfo.KoreaAgeRating,
                "primaryCategory" => AppsGetCollectionFieldsAppInfo.PrimaryCategory,
                "primarySubcategoryOne" => AppsGetCollectionFieldsAppInfo.PrimarySubcategoryOne,
                "primarySubcategoryTwo" => AppsGetCollectionFieldsAppInfo.PrimarySubcategoryTwo,
                "secondaryCategory" => AppsGetCollectionFieldsAppInfo.SecondaryCategory,
                "secondarySubcategoryOne" => AppsGetCollectionFieldsAppInfo.SecondarySubcategoryOne,
                "secondarySubcategoryTwo" => AppsGetCollectionFieldsAppInfo.SecondarySubcategoryTwo,
                "state" => AppsGetCollectionFieldsAppInfo.State,
                "territoryAgeRatings" => AppsGetCollectionFieldsAppInfo.TerritoryAgeRatings,
                _ => null,
            };
        }
    }
}