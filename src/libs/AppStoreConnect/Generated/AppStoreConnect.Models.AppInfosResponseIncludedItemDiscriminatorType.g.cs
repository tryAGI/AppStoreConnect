
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppInfosResponseIncludedItemDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        AgeRatingDeclarations,
        /// <summary>
        ///
        /// </summary>
        AppCategories,
        /// <summary>
        ///
        /// </summary>
        AppInfoLocalizations,
        /// <summary>
        ///
        /// </summary>
        Apps,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppInfosResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppInfosResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                AppInfosResponseIncludedItemDiscriminatorType.AgeRatingDeclarations => "ageRatingDeclarations",
                AppInfosResponseIncludedItemDiscriminatorType.AppCategories => "appCategories",
                AppInfosResponseIncludedItemDiscriminatorType.AppInfoLocalizations => "appInfoLocalizations",
                AppInfosResponseIncludedItemDiscriminatorType.Apps => "apps",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppInfosResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "ageRatingDeclarations" => AppInfosResponseIncludedItemDiscriminatorType.AgeRatingDeclarations,
                "appCategories" => AppInfosResponseIncludedItemDiscriminatorType.AppCategories,
                "appInfoLocalizations" => AppInfosResponseIncludedItemDiscriminatorType.AppInfoLocalizations,
                "apps" => AppInfosResponseIncludedItemDiscriminatorType.Apps,
                _ => null,
            };
        }
    }
}