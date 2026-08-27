
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppsAppAvailabilityV2GetToOneRelatedFieldsTerritoryAvailabilitie
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
    public static class AppsAppAvailabilityV2GetToOneRelatedFieldsTerritoryAvailabilitieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsAppAvailabilityV2GetToOneRelatedFieldsTerritoryAvailabilitie value)
        {
            return value switch
            {
                AppsAppAvailabilityV2GetToOneRelatedFieldsTerritoryAvailabilitie.Available => "available",
                AppsAppAvailabilityV2GetToOneRelatedFieldsTerritoryAvailabilitie.ContentStatuses => "contentStatuses",
                AppsAppAvailabilityV2GetToOneRelatedFieldsTerritoryAvailabilitie.PreOrderEnabled => "preOrderEnabled",
                AppsAppAvailabilityV2GetToOneRelatedFieldsTerritoryAvailabilitie.PreOrderPublishDate => "preOrderPublishDate",
                AppsAppAvailabilityV2GetToOneRelatedFieldsTerritoryAvailabilitie.ReleaseDate => "releaseDate",
                AppsAppAvailabilityV2GetToOneRelatedFieldsTerritoryAvailabilitie.Territory => "territory",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsAppAvailabilityV2GetToOneRelatedFieldsTerritoryAvailabilitie? ToEnum(string value)
        {
            return value switch
            {
                "available" => AppsAppAvailabilityV2GetToOneRelatedFieldsTerritoryAvailabilitie.Available,
                "contentStatuses" => AppsAppAvailabilityV2GetToOneRelatedFieldsTerritoryAvailabilitie.ContentStatuses,
                "preOrderEnabled" => AppsAppAvailabilityV2GetToOneRelatedFieldsTerritoryAvailabilitie.PreOrderEnabled,
                "preOrderPublishDate" => AppsAppAvailabilityV2GetToOneRelatedFieldsTerritoryAvailabilitie.PreOrderPublishDate,
                "releaseDate" => AppsAppAvailabilityV2GetToOneRelatedFieldsTerritoryAvailabilitie.ReleaseDate,
                "territory" => AppsAppAvailabilityV2GetToOneRelatedFieldsTerritoryAvailabilitie.Territory,
                _ => null,
            };
        }
    }
}