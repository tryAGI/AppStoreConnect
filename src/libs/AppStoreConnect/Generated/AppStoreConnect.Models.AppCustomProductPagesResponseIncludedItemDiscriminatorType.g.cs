
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppCustomProductPagesResponseIncludedItemDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        AppCustomProductPageLocalizations,
        /// <summary>
        ///
        /// </summary>
        AppCustomProductPageVersions,
        /// <summary>
        ///
        /// </summary>
        Apps,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppCustomProductPagesResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppCustomProductPagesResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                AppCustomProductPagesResponseIncludedItemDiscriminatorType.AppCustomProductPageLocalizations => "appCustomProductPageLocalizations",
                AppCustomProductPagesResponseIncludedItemDiscriminatorType.AppCustomProductPageVersions => "appCustomProductPageVersions",
                AppCustomProductPagesResponseIncludedItemDiscriminatorType.Apps => "apps",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppCustomProductPagesResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "appCustomProductPageLocalizations" => AppCustomProductPagesResponseIncludedItemDiscriminatorType.AppCustomProductPageLocalizations,
                "appCustomProductPageVersions" => AppCustomProductPagesResponseIncludedItemDiscriminatorType.AppCustomProductPageVersions,
                "apps" => AppCustomProductPagesResponseIncludedItemDiscriminatorType.Apps,
                _ => null,
            };
        }
    }
}