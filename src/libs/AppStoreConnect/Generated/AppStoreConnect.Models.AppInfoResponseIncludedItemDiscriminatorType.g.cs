
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppInfoResponseIncludedItemDiscriminatorType
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
    public static class AppInfoResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppInfoResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                AppInfoResponseIncludedItemDiscriminatorType.AgeRatingDeclarations => "ageRatingDeclarations",
                AppInfoResponseIncludedItemDiscriminatorType.AppCategories => "appCategories",
                AppInfoResponseIncludedItemDiscriminatorType.AppInfoLocalizations => "appInfoLocalizations",
                AppInfoResponseIncludedItemDiscriminatorType.Apps => "apps",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppInfoResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "ageRatingDeclarations" => AppInfoResponseIncludedItemDiscriminatorType.AgeRatingDeclarations,
                "appCategories" => AppInfoResponseIncludedItemDiscriminatorType.AppCategories,
                "appInfoLocalizations" => AppInfoResponseIncludedItemDiscriminatorType.AppInfoLocalizations,
                "apps" => AppInfoResponseIncludedItemDiscriminatorType.Apps,
                _ => null,
            };
        }
    }
}