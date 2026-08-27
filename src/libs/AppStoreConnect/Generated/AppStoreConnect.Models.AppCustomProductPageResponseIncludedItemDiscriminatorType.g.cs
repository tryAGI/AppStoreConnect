
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppCustomProductPageResponseIncludedItemDiscriminatorType
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
    public static class AppCustomProductPageResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppCustomProductPageResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                AppCustomProductPageResponseIncludedItemDiscriminatorType.AppCustomProductPageLocalizations => "appCustomProductPageLocalizations",
                AppCustomProductPageResponseIncludedItemDiscriminatorType.AppCustomProductPageVersions => "appCustomProductPageVersions",
                AppCustomProductPageResponseIncludedItemDiscriminatorType.Apps => "apps",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppCustomProductPageResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "appCustomProductPageLocalizations" => AppCustomProductPageResponseIncludedItemDiscriminatorType.AppCustomProductPageLocalizations,
                "appCustomProductPageVersions" => AppCustomProductPageResponseIncludedItemDiscriminatorType.AppCustomProductPageVersions,
                "apps" => AppCustomProductPageResponseIncludedItemDiscriminatorType.Apps,
                _ => null,
            };
        }
    }
}