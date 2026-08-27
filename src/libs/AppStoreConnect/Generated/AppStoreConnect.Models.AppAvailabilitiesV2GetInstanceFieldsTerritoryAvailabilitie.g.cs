
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppAvailabilitiesV2GetInstanceFieldsTerritoryAvailabilitie
    {
        /// <summary>
        ///
        /// </summary>
        Available,
        /// <summary>
        ///
        /// </summary>
        ContentStatuses,
        /// <summary>
        ///
        /// </summary>
        PreOrderEnabled,
        /// <summary>
        ///
        /// </summary>
        PreOrderPublishDate,
        /// <summary>
        ///
        /// </summary>
        ReleaseDate,
        /// <summary>
        ///
        /// </summary>
        Territory,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppAvailabilitiesV2GetInstanceFieldsTerritoryAvailabilitieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppAvailabilitiesV2GetInstanceFieldsTerritoryAvailabilitie value)
        {
            return value switch
            {
                AppAvailabilitiesV2GetInstanceFieldsTerritoryAvailabilitie.Available => "available",
                AppAvailabilitiesV2GetInstanceFieldsTerritoryAvailabilitie.ContentStatuses => "contentStatuses",
                AppAvailabilitiesV2GetInstanceFieldsTerritoryAvailabilitie.PreOrderEnabled => "preOrderEnabled",
                AppAvailabilitiesV2GetInstanceFieldsTerritoryAvailabilitie.PreOrderPublishDate => "preOrderPublishDate",
                AppAvailabilitiesV2GetInstanceFieldsTerritoryAvailabilitie.ReleaseDate => "releaseDate",
                AppAvailabilitiesV2GetInstanceFieldsTerritoryAvailabilitie.Territory => "territory",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppAvailabilitiesV2GetInstanceFieldsTerritoryAvailabilitie? ToEnum(string value)
        {
            return value switch
            {
                "available" => AppAvailabilitiesV2GetInstanceFieldsTerritoryAvailabilitie.Available,
                "contentStatuses" => AppAvailabilitiesV2GetInstanceFieldsTerritoryAvailabilitie.ContentStatuses,
                "preOrderEnabled" => AppAvailabilitiesV2GetInstanceFieldsTerritoryAvailabilitie.PreOrderEnabled,
                "preOrderPublishDate" => AppAvailabilitiesV2GetInstanceFieldsTerritoryAvailabilitie.PreOrderPublishDate,
                "releaseDate" => AppAvailabilitiesV2GetInstanceFieldsTerritoryAvailabilitie.ReleaseDate,
                "territory" => AppAvailabilitiesV2GetInstanceFieldsTerritoryAvailabilitie.Territory,
                _ => null,
            };
        }
    }
}