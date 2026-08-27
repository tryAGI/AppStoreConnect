
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppInfosGetInstanceFieldsAppInfo
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
    public static class AppInfosGetInstanceFieldsAppInfoExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppInfosGetInstanceFieldsAppInfo value)
        {
            return value switch
            {
                AppInfosGetInstanceFieldsAppInfo.AgeRatingDeclaration => "ageRatingDeclaration",
                AppInfosGetInstanceFieldsAppInfo.App => "app",
                AppInfosGetInstanceFieldsAppInfo.AppInfoLocalizations => "appInfoLocalizations",
                AppInfosGetInstanceFieldsAppInfo.AppStoreAgeRating => "appStoreAgeRating",
                AppInfosGetInstanceFieldsAppInfo.AppStoreState => "appStoreState",
                AppInfosGetInstanceFieldsAppInfo.AustraliaAgeRating => "australiaAgeRating",
                AppInfosGetInstanceFieldsAppInfo.BrazilAgeRating => "brazilAgeRating",
                AppInfosGetInstanceFieldsAppInfo.BrazilAgeRatingV2 => "brazilAgeRatingV2",
                AppInfosGetInstanceFieldsAppInfo.FranceAgeRating => "franceAgeRating",
                AppInfosGetInstanceFieldsAppInfo.KidsAgeBand => "kidsAgeBand",
                AppInfosGetInstanceFieldsAppInfo.KoreaAgeRating => "koreaAgeRating",
                AppInfosGetInstanceFieldsAppInfo.PrimaryCategory => "primaryCategory",
                AppInfosGetInstanceFieldsAppInfo.PrimarySubcategoryOne => "primarySubcategoryOne",
                AppInfosGetInstanceFieldsAppInfo.PrimarySubcategoryTwo => "primarySubcategoryTwo",
                AppInfosGetInstanceFieldsAppInfo.SecondaryCategory => "secondaryCategory",
                AppInfosGetInstanceFieldsAppInfo.SecondarySubcategoryOne => "secondarySubcategoryOne",
                AppInfosGetInstanceFieldsAppInfo.SecondarySubcategoryTwo => "secondarySubcategoryTwo",
                AppInfosGetInstanceFieldsAppInfo.State => "state",
                AppInfosGetInstanceFieldsAppInfo.TerritoryAgeRatings => "territoryAgeRatings",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppInfosGetInstanceFieldsAppInfo? ToEnum(string value)
        {
            return value switch
            {
                "ageRatingDeclaration" => AppInfosGetInstanceFieldsAppInfo.AgeRatingDeclaration,
                "app" => AppInfosGetInstanceFieldsAppInfo.App,
                "appInfoLocalizations" => AppInfosGetInstanceFieldsAppInfo.AppInfoLocalizations,
                "appStoreAgeRating" => AppInfosGetInstanceFieldsAppInfo.AppStoreAgeRating,
                "appStoreState" => AppInfosGetInstanceFieldsAppInfo.AppStoreState,
                "australiaAgeRating" => AppInfosGetInstanceFieldsAppInfo.AustraliaAgeRating,
                "brazilAgeRating" => AppInfosGetInstanceFieldsAppInfo.BrazilAgeRating,
                "brazilAgeRatingV2" => AppInfosGetInstanceFieldsAppInfo.BrazilAgeRatingV2,
                "franceAgeRating" => AppInfosGetInstanceFieldsAppInfo.FranceAgeRating,
                "kidsAgeBand" => AppInfosGetInstanceFieldsAppInfo.KidsAgeBand,
                "koreaAgeRating" => AppInfosGetInstanceFieldsAppInfo.KoreaAgeRating,
                "primaryCategory" => AppInfosGetInstanceFieldsAppInfo.PrimaryCategory,
                "primarySubcategoryOne" => AppInfosGetInstanceFieldsAppInfo.PrimarySubcategoryOne,
                "primarySubcategoryTwo" => AppInfosGetInstanceFieldsAppInfo.PrimarySubcategoryTwo,
                "secondaryCategory" => AppInfosGetInstanceFieldsAppInfo.SecondaryCategory,
                "secondarySubcategoryOne" => AppInfosGetInstanceFieldsAppInfo.SecondarySubcategoryOne,
                "secondarySubcategoryTwo" => AppInfosGetInstanceFieldsAppInfo.SecondarySubcategoryTwo,
                "state" => AppInfosGetInstanceFieldsAppInfo.State,
                "territoryAgeRatings" => AppInfosGetInstanceFieldsAppInfo.TerritoryAgeRatings,
                _ => null,
            };
        }
    }
}