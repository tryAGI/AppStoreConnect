
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsRetentionMessageVersion
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
    public static class AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsRetentionMessageVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsRetentionMessageVersion value)
        {
            return value switch
            {
                AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsRetentionMessageVersion.Localizations => "localizations",
                AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsRetentionMessageVersion.Placement => "placement",
                AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsRetentionMessageVersion.RetentionMessage => "retentionMessage",
                AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsRetentionMessageVersion.State => "state",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsRetentionMessageVersion? ToEnum(string value)
        {
            return value switch
            {
                "localizations" => AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsRetentionMessageVersion.Localizations,
                "placement" => AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsRetentionMessageVersion.Placement,
                "retentionMessage" => AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsRetentionMessageVersion.RetentionMessage,
                "state" => AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsRetentionMessageVersion.State,
                _ => null,
            };
        }
    }
}