
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppsAppInfosGetToManyRelatedIncludeItem
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppsAppInfosGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsAppInfosGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                AppsAppInfosGetToManyRelatedIncludeItem.AgeRatingDeclaration => "ageRatingDeclaration",
                AppsAppInfosGetToManyRelatedIncludeItem.App => "app",
                AppsAppInfosGetToManyRelatedIncludeItem.AppInfoLocalizations => "appInfoLocalizations",
                AppsAppInfosGetToManyRelatedIncludeItem.PrimaryCategory => "primaryCategory",
                AppsAppInfosGetToManyRelatedIncludeItem.PrimarySubcategoryOne => "primarySubcategoryOne",
                AppsAppInfosGetToManyRelatedIncludeItem.PrimarySubcategoryTwo => "primarySubcategoryTwo",
                AppsAppInfosGetToManyRelatedIncludeItem.SecondaryCategory => "secondaryCategory",
                AppsAppInfosGetToManyRelatedIncludeItem.SecondarySubcategoryOne => "secondarySubcategoryOne",
                AppsAppInfosGetToManyRelatedIncludeItem.SecondarySubcategoryTwo => "secondarySubcategoryTwo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsAppInfosGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "ageRatingDeclaration" => AppsAppInfosGetToManyRelatedIncludeItem.AgeRatingDeclaration,
                "app" => AppsAppInfosGetToManyRelatedIncludeItem.App,
                "appInfoLocalizations" => AppsAppInfosGetToManyRelatedIncludeItem.AppInfoLocalizations,
                "primaryCategory" => AppsAppInfosGetToManyRelatedIncludeItem.PrimaryCategory,
                "primarySubcategoryOne" => AppsAppInfosGetToManyRelatedIncludeItem.PrimarySubcategoryOne,
                "primarySubcategoryTwo" => AppsAppInfosGetToManyRelatedIncludeItem.PrimarySubcategoryTwo,
                "secondaryCategory" => AppsAppInfosGetToManyRelatedIncludeItem.SecondaryCategory,
                "secondarySubcategoryOne" => AppsAppInfosGetToManyRelatedIncludeItem.SecondarySubcategoryOne,
                "secondarySubcategoryTwo" => AppsAppInfosGetToManyRelatedIncludeItem.SecondarySubcategoryTwo,
                _ => null,
            };
        }
    }
}