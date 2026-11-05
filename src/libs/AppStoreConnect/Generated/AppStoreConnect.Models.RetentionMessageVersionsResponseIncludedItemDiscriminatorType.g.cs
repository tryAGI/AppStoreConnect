
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum RetentionMessageVersionsResponseIncludedItemDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        AppAssetLibraryPlacements,
        /// <summary>
        ///
        /// </summary>
        RetentionMessageLocalizations,
        /// <summary>
        ///
        /// </summary>
        RetentionMessages,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RetentionMessageVersionsResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RetentionMessageVersionsResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                RetentionMessageVersionsResponseIncludedItemDiscriminatorType.AppAssetLibraryPlacements => "appAssetLibraryPlacements",
                RetentionMessageVersionsResponseIncludedItemDiscriminatorType.RetentionMessageLocalizations => "retentionMessageLocalizations",
                RetentionMessageVersionsResponseIncludedItemDiscriminatorType.RetentionMessages => "retentionMessages",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RetentionMessageVersionsResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "appAssetLibraryPlacements" => RetentionMessageVersionsResponseIncludedItemDiscriminatorType.AppAssetLibraryPlacements,
                "retentionMessageLocalizations" => RetentionMessageVersionsResponseIncludedItemDiscriminatorType.RetentionMessageLocalizations,
                "retentionMessages" => RetentionMessageVersionsResponseIncludedItemDiscriminatorType.RetentionMessages,
                _ => null,
            };
        }
    }
}