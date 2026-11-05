
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum RetentionMessageVersionResponseIncludedItemDiscriminatorType
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
    public static class RetentionMessageVersionResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RetentionMessageVersionResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                RetentionMessageVersionResponseIncludedItemDiscriminatorType.AppAssetLibraryPlacements => "appAssetLibraryPlacements",
                RetentionMessageVersionResponseIncludedItemDiscriminatorType.RetentionMessageLocalizations => "retentionMessageLocalizations",
                RetentionMessageVersionResponseIncludedItemDiscriminatorType.RetentionMessages => "retentionMessages",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RetentionMessageVersionResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "appAssetLibraryPlacements" => RetentionMessageVersionResponseIncludedItemDiscriminatorType.AppAssetLibraryPlacements,
                "retentionMessageLocalizations" => RetentionMessageVersionResponseIncludedItemDiscriminatorType.RetentionMessageLocalizations,
                "retentionMessages" => RetentionMessageVersionResponseIncludedItemDiscriminatorType.RetentionMessages,
                _ => null,
            };
        }
    }
}