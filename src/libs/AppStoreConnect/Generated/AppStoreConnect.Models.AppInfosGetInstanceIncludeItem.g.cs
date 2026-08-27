
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppInfosGetInstanceIncludeItem
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
    public static class AppInfosGetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppInfosGetInstanceIncludeItem value)
        {
            return value switch
            {
                AppInfosGetInstanceIncludeItem.AgeRatingDeclaration => "ageRatingDeclaration",
                AppInfosGetInstanceIncludeItem.App => "app",
                AppInfosGetInstanceIncludeItem.AppInfoLocalizations => "appInfoLocalizations",
                AppInfosGetInstanceIncludeItem.PrimaryCategory => "primaryCategory",
                AppInfosGetInstanceIncludeItem.PrimarySubcategoryOne => "primarySubcategoryOne",
                AppInfosGetInstanceIncludeItem.PrimarySubcategoryTwo => "primarySubcategoryTwo",
                AppInfosGetInstanceIncludeItem.SecondaryCategory => "secondaryCategory",
                AppInfosGetInstanceIncludeItem.SecondarySubcategoryOne => "secondarySubcategoryOne",
                AppInfosGetInstanceIncludeItem.SecondarySubcategoryTwo => "secondarySubcategoryTwo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppInfosGetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "ageRatingDeclaration" => AppInfosGetInstanceIncludeItem.AgeRatingDeclaration,
                "app" => AppInfosGetInstanceIncludeItem.App,
                "appInfoLocalizations" => AppInfosGetInstanceIncludeItem.AppInfoLocalizations,
                "primaryCategory" => AppInfosGetInstanceIncludeItem.PrimaryCategory,
                "primarySubcategoryOne" => AppInfosGetInstanceIncludeItem.PrimarySubcategoryOne,
                "primarySubcategoryTwo" => AppInfosGetInstanceIncludeItem.PrimarySubcategoryTwo,
                "secondaryCategory" => AppInfosGetInstanceIncludeItem.SecondaryCategory,
                "secondarySubcategoryOne" => AppInfosGetInstanceIncludeItem.SecondarySubcategoryOne,
                "secondarySubcategoryTwo" => AppInfosGetInstanceIncludeItem.SecondarySubcategoryTwo,
                _ => null,
            };
        }
    }
}