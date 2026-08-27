
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppInfosAppInfoLocalizationsGetToManyRelatedFieldsAppInfo
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
    public static class AppInfosAppInfoLocalizationsGetToManyRelatedFieldsAppInfoExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppInfosAppInfoLocalizationsGetToManyRelatedFieldsAppInfo value)
        {
            return value switch
            {
                AppInfosAppInfoLocalizationsGetToManyRelatedFieldsAppInfo.AgeRatingDeclaration => "ageRatingDeclaration",
                AppInfosAppInfoLocalizationsGetToManyRelatedFieldsAppInfo.App => "app",
                AppInfosAppInfoLocalizationsGetToManyRelatedFieldsAppInfo.AppInfoLocalizations => "appInfoLocalizations",
                AppInfosAppInfoLocalizationsGetToManyRelatedFieldsAppInfo.AppStoreAgeRating => "appStoreAgeRating",
                AppInfosAppInfoLocalizationsGetToManyRelatedFieldsAppInfo.AppStoreState => "appStoreState",
                AppInfosAppInfoLocalizationsGetToManyRelatedFieldsAppInfo.AustraliaAgeRating => "australiaAgeRating",
                AppInfosAppInfoLocalizationsGetToManyRelatedFieldsAppInfo.BrazilAgeRating => "brazilAgeRating",
                AppInfosAppInfoLocalizationsGetToManyRelatedFieldsAppInfo.BrazilAgeRatingV2 => "brazilAgeRatingV2",
                AppInfosAppInfoLocalizationsGetToManyRelatedFieldsAppInfo.FranceAgeRating => "franceAgeRating",
                AppInfosAppInfoLocalizationsGetToManyRelatedFieldsAppInfo.KidsAgeBand => "kidsAgeBand",
                AppInfosAppInfoLocalizationsGetToManyRelatedFieldsAppInfo.KoreaAgeRating => "koreaAgeRating",
                AppInfosAppInfoLocalizationsGetToManyRelatedFieldsAppInfo.PrimaryCategory => "primaryCategory",
                AppInfosAppInfoLocalizationsGetToManyRelatedFieldsAppInfo.PrimarySubcategoryOne => "primarySubcategoryOne",
                AppInfosAppInfoLocalizationsGetToManyRelatedFieldsAppInfo.PrimarySubcategoryTwo => "primarySubcategoryTwo",
                AppInfosAppInfoLocalizationsGetToManyRelatedFieldsAppInfo.SecondaryCategory => "secondaryCategory",
                AppInfosAppInfoLocalizationsGetToManyRelatedFieldsAppInfo.SecondarySubcategoryOne => "secondarySubcategoryOne",
                AppInfosAppInfoLocalizationsGetToManyRelatedFieldsAppInfo.SecondarySubcategoryTwo => "secondarySubcategoryTwo",
                AppInfosAppInfoLocalizationsGetToManyRelatedFieldsAppInfo.State => "state",
                AppInfosAppInfoLocalizationsGetToManyRelatedFieldsAppInfo.TerritoryAgeRatings => "territoryAgeRatings",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppInfosAppInfoLocalizationsGetToManyRelatedFieldsAppInfo? ToEnum(string value)
        {
            return value switch
            {
                "ageRatingDeclaration" => AppInfosAppInfoLocalizationsGetToManyRelatedFieldsAppInfo.AgeRatingDeclaration,
                "app" => AppInfosAppInfoLocalizationsGetToManyRelatedFieldsAppInfo.App,
                "appInfoLocalizations" => AppInfosAppInfoLocalizationsGetToManyRelatedFieldsAppInfo.AppInfoLocalizations,
                "appStoreAgeRating" => AppInfosAppInfoLocalizationsGetToManyRelatedFieldsAppInfo.AppStoreAgeRating,
                "appStoreState" => AppInfosAppInfoLocalizationsGetToManyRelatedFieldsAppInfo.AppStoreState,
                "australiaAgeRating" => AppInfosAppInfoLocalizationsGetToManyRelatedFieldsAppInfo.AustraliaAgeRating,
                "brazilAgeRating" => AppInfosAppInfoLocalizationsGetToManyRelatedFieldsAppInfo.BrazilAgeRating,
                "brazilAgeRatingV2" => AppInfosAppInfoLocalizationsGetToManyRelatedFieldsAppInfo.BrazilAgeRatingV2,
                "franceAgeRating" => AppInfosAppInfoLocalizationsGetToManyRelatedFieldsAppInfo.FranceAgeRating,
                "kidsAgeBand" => AppInfosAppInfoLocalizationsGetToManyRelatedFieldsAppInfo.KidsAgeBand,
                "koreaAgeRating" => AppInfosAppInfoLocalizationsGetToManyRelatedFieldsAppInfo.KoreaAgeRating,
                "primaryCategory" => AppInfosAppInfoLocalizationsGetToManyRelatedFieldsAppInfo.PrimaryCategory,
                "primarySubcategoryOne" => AppInfosAppInfoLocalizationsGetToManyRelatedFieldsAppInfo.PrimarySubcategoryOne,
                "primarySubcategoryTwo" => AppInfosAppInfoLocalizationsGetToManyRelatedFieldsAppInfo.PrimarySubcategoryTwo,
                "secondaryCategory" => AppInfosAppInfoLocalizationsGetToManyRelatedFieldsAppInfo.SecondaryCategory,
                "secondarySubcategoryOne" => AppInfosAppInfoLocalizationsGetToManyRelatedFieldsAppInfo.SecondarySubcategoryOne,
                "secondarySubcategoryTwo" => AppInfosAppInfoLocalizationsGetToManyRelatedFieldsAppInfo.SecondarySubcategoryTwo,
                "state" => AppInfosAppInfoLocalizationsGetToManyRelatedFieldsAppInfo.State,
                "territoryAgeRatings" => AppInfosAppInfoLocalizationsGetToManyRelatedFieldsAppInfo.TerritoryAgeRatings,
                _ => null,
            };
        }
    }
}