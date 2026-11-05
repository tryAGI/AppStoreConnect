
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppAssetLibraryPlacementsGetInstanceFieldsRetentionMessageVersion
    {
        /// <summary>
        ///
        /// </summary>
        Localizations,
        /// <summary>
        ///
        /// </summary>
        Placement,
        /// <summary>
        ///
        /// </summary>
        RetentionMessage,
        /// <summary>
        ///
        /// </summary>
        State,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppAssetLibraryPlacementsGetInstanceFieldsRetentionMessageVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppAssetLibraryPlacementsGetInstanceFieldsRetentionMessageVersion value)
        {
            return value switch
            {
                AppAssetLibraryPlacementsGetInstanceFieldsRetentionMessageVersion.Localizations => "localizations",
                AppAssetLibraryPlacementsGetInstanceFieldsRetentionMessageVersion.Placement => "placement",
                AppAssetLibraryPlacementsGetInstanceFieldsRetentionMessageVersion.RetentionMessage => "retentionMessage",
                AppAssetLibraryPlacementsGetInstanceFieldsRetentionMessageVersion.State => "state",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppAssetLibraryPlacementsGetInstanceFieldsRetentionMessageVersion? ToEnum(string value)
        {
            return value switch
            {
                "localizations" => AppAssetLibraryPlacementsGetInstanceFieldsRetentionMessageVersion.Localizations,
                "placement" => AppAssetLibraryPlacementsGetInstanceFieldsRetentionMessageVersion.Placement,
                "retentionMessage" => AppAssetLibraryPlacementsGetInstanceFieldsRetentionMessageVersion.RetentionMessage,
                "state" => AppAssetLibraryPlacementsGetInstanceFieldsRetentionMessageVersion.State,
                _ => null,
            };
        }
    }
}