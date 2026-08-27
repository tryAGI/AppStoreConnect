
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppInfoLocalizationsGetInstanceFieldsAppInfo
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
    public static class AppInfoLocalizationsGetInstanceFieldsAppInfoExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppInfoLocalizationsGetInstanceFieldsAppInfo value)
        {
            return value switch
            {
                AppInfoLocalizationsGetInstanceFieldsAppInfo.AgeRatingDeclaration => "ageRatingDeclaration",
                AppInfoLocalizationsGetInstanceFieldsAppInfo.App => "app",
                AppInfoLocalizationsGetInstanceFieldsAppInfo.AppInfoLocalizations => "appInfoLocalizations",
                AppInfoLocalizationsGetInstanceFieldsAppInfo.AppStoreAgeRating => "appStoreAgeRating",
                AppInfoLocalizationsGetInstanceFieldsAppInfo.AppStoreState => "appStoreState",
                AppInfoLocalizationsGetInstanceFieldsAppInfo.AustraliaAgeRating => "australiaAgeRating",
                AppInfoLocalizationsGetInstanceFieldsAppInfo.BrazilAgeRating => "brazilAgeRating",
                AppInfoLocalizationsGetInstanceFieldsAppInfo.BrazilAgeRatingV2 => "brazilAgeRatingV2",
                AppInfoLocalizationsGetInstanceFieldsAppInfo.FranceAgeRating => "franceAgeRating",
                AppInfoLocalizationsGetInstanceFieldsAppInfo.KidsAgeBand => "kidsAgeBand",
                AppInfoLocalizationsGetInstanceFieldsAppInfo.KoreaAgeRating => "koreaAgeRating",
                AppInfoLocalizationsGetInstanceFieldsAppInfo.PrimaryCategory => "primaryCategory",
                AppInfoLocalizationsGetInstanceFieldsAppInfo.PrimarySubcategoryOne => "primarySubcategoryOne",
                AppInfoLocalizationsGetInstanceFieldsAppInfo.PrimarySubcategoryTwo => "primarySubcategoryTwo",
                AppInfoLocalizationsGetInstanceFieldsAppInfo.SecondaryCategory => "secondaryCategory",
                AppInfoLocalizationsGetInstanceFieldsAppInfo.SecondarySubcategoryOne => "secondarySubcategoryOne",
                AppInfoLocalizationsGetInstanceFieldsAppInfo.SecondarySubcategoryTwo => "secondarySubcategoryTwo",
                AppInfoLocalizationsGetInstanceFieldsAppInfo.State => "state",
                AppInfoLocalizationsGetInstanceFieldsAppInfo.TerritoryAgeRatings => "territoryAgeRatings",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppInfoLocalizationsGetInstanceFieldsAppInfo? ToEnum(string value)
        {
            return value switch
            {
                "ageRatingDeclaration" => AppInfoLocalizationsGetInstanceFieldsAppInfo.AgeRatingDeclaration,
                "app" => AppInfoLocalizationsGetInstanceFieldsAppInfo.App,
                "appInfoLocalizations" => AppInfoLocalizationsGetInstanceFieldsAppInfo.AppInfoLocalizations,
                "appStoreAgeRating" => AppInfoLocalizationsGetInstanceFieldsAppInfo.AppStoreAgeRating,
                "appStoreState" => AppInfoLocalizationsGetInstanceFieldsAppInfo.AppStoreState,
                "australiaAgeRating" => AppInfoLocalizationsGetInstanceFieldsAppInfo.AustraliaAgeRating,
                "brazilAgeRating" => AppInfoLocalizationsGetInstanceFieldsAppInfo.BrazilAgeRating,
                "brazilAgeRatingV2" => AppInfoLocalizationsGetInstanceFieldsAppInfo.BrazilAgeRatingV2,
                "franceAgeRating" => AppInfoLocalizationsGetInstanceFieldsAppInfo.FranceAgeRating,
                "kidsAgeBand" => AppInfoLocalizationsGetInstanceFieldsAppInfo.KidsAgeBand,
                "koreaAgeRating" => AppInfoLocalizationsGetInstanceFieldsAppInfo.KoreaAgeRating,
                "primaryCategory" => AppInfoLocalizationsGetInstanceFieldsAppInfo.PrimaryCategory,
                "primarySubcategoryOne" => AppInfoLocalizationsGetInstanceFieldsAppInfo.PrimarySubcategoryOne,
                "primarySubcategoryTwo" => AppInfoLocalizationsGetInstanceFieldsAppInfo.PrimarySubcategoryTwo,
                "secondaryCategory" => AppInfoLocalizationsGetInstanceFieldsAppInfo.SecondaryCategory,
                "secondarySubcategoryOne" => AppInfoLocalizationsGetInstanceFieldsAppInfo.SecondarySubcategoryOne,
                "secondarySubcategoryTwo" => AppInfoLocalizationsGetInstanceFieldsAppInfo.SecondarySubcategoryTwo,
                "state" => AppInfoLocalizationsGetInstanceFieldsAppInfo.State,
                "territoryAgeRatings" => AppInfoLocalizationsGetInstanceFieldsAppInfo.TerritoryAgeRatings,
                _ => null,
            };
        }
    }
}