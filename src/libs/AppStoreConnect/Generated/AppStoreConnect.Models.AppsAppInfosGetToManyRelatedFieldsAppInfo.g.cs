
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppsAppInfosGetToManyRelatedFieldsAppInfo
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
    public static class AppsAppInfosGetToManyRelatedFieldsAppInfoExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsAppInfosGetToManyRelatedFieldsAppInfo value)
        {
            return value switch
            {
                AppsAppInfosGetToManyRelatedFieldsAppInfo.AgeRatingDeclaration => "ageRatingDeclaration",
                AppsAppInfosGetToManyRelatedFieldsAppInfo.App => "app",
                AppsAppInfosGetToManyRelatedFieldsAppInfo.AppInfoLocalizations => "appInfoLocalizations",
                AppsAppInfosGetToManyRelatedFieldsAppInfo.AppStoreAgeRating => "appStoreAgeRating",
                AppsAppInfosGetToManyRelatedFieldsAppInfo.AppStoreState => "appStoreState",
                AppsAppInfosGetToManyRelatedFieldsAppInfo.AustraliaAgeRating => "australiaAgeRating",
                AppsAppInfosGetToManyRelatedFieldsAppInfo.BrazilAgeRating => "brazilAgeRating",
                AppsAppInfosGetToManyRelatedFieldsAppInfo.BrazilAgeRatingV2 => "brazilAgeRatingV2",
                AppsAppInfosGetToManyRelatedFieldsAppInfo.FranceAgeRating => "franceAgeRating",
                AppsAppInfosGetToManyRelatedFieldsAppInfo.KidsAgeBand => "kidsAgeBand",
                AppsAppInfosGetToManyRelatedFieldsAppInfo.KoreaAgeRating => "koreaAgeRating",
                AppsAppInfosGetToManyRelatedFieldsAppInfo.PrimaryCategory => "primaryCategory",
                AppsAppInfosGetToManyRelatedFieldsAppInfo.PrimarySubcategoryOne => "primarySubcategoryOne",
                AppsAppInfosGetToManyRelatedFieldsAppInfo.PrimarySubcategoryTwo => "primarySubcategoryTwo",
                AppsAppInfosGetToManyRelatedFieldsAppInfo.SecondaryCategory => "secondaryCategory",
                AppsAppInfosGetToManyRelatedFieldsAppInfo.SecondarySubcategoryOne => "secondarySubcategoryOne",
                AppsAppInfosGetToManyRelatedFieldsAppInfo.SecondarySubcategoryTwo => "secondarySubcategoryTwo",
                AppsAppInfosGetToManyRelatedFieldsAppInfo.State => "state",
                AppsAppInfosGetToManyRelatedFieldsAppInfo.TerritoryAgeRatings => "territoryAgeRatings",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsAppInfosGetToManyRelatedFieldsAppInfo? ToEnum(string value)
        {
            return value switch
            {
                "ageRatingDeclaration" => AppsAppInfosGetToManyRelatedFieldsAppInfo.AgeRatingDeclaration,
                "app" => AppsAppInfosGetToManyRelatedFieldsAppInfo.App,
                "appInfoLocalizations" => AppsAppInfosGetToManyRelatedFieldsAppInfo.AppInfoLocalizations,
                "appStoreAgeRating" => AppsAppInfosGetToManyRelatedFieldsAppInfo.AppStoreAgeRating,
                "appStoreState" => AppsAppInfosGetToManyRelatedFieldsAppInfo.AppStoreState,
                "australiaAgeRating" => AppsAppInfosGetToManyRelatedFieldsAppInfo.AustraliaAgeRating,
                "brazilAgeRating" => AppsAppInfosGetToManyRelatedFieldsAppInfo.BrazilAgeRating,
                "brazilAgeRatingV2" => AppsAppInfosGetToManyRelatedFieldsAppInfo.BrazilAgeRatingV2,
                "franceAgeRating" => AppsAppInfosGetToManyRelatedFieldsAppInfo.FranceAgeRating,
                "kidsAgeBand" => AppsAppInfosGetToManyRelatedFieldsAppInfo.KidsAgeBand,
                "koreaAgeRating" => AppsAppInfosGetToManyRelatedFieldsAppInfo.KoreaAgeRating,
                "primaryCategory" => AppsAppInfosGetToManyRelatedFieldsAppInfo.PrimaryCategory,
                "primarySubcategoryOne" => AppsAppInfosGetToManyRelatedFieldsAppInfo.PrimarySubcategoryOne,
                "primarySubcategoryTwo" => AppsAppInfosGetToManyRelatedFieldsAppInfo.PrimarySubcategoryTwo,
                "secondaryCategory" => AppsAppInfosGetToManyRelatedFieldsAppInfo.SecondaryCategory,
                "secondarySubcategoryOne" => AppsAppInfosGetToManyRelatedFieldsAppInfo.SecondarySubcategoryOne,
                "secondarySubcategoryTwo" => AppsAppInfosGetToManyRelatedFieldsAppInfo.SecondarySubcategoryTwo,
                "state" => AppsAppInfosGetToManyRelatedFieldsAppInfo.State,
                "territoryAgeRatings" => AppsAppInfosGetToManyRelatedFieldsAppInfo.TerritoryAgeRatings,
                _ => null,
            };
        }
    }
}