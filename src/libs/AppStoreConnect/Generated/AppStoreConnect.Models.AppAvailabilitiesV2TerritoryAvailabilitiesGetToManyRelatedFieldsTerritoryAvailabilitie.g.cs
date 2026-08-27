
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppAvailabilitiesV2TerritoryAvailabilitiesGetToManyRelatedFieldsTerritoryAvailabilitie
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
    public static class AppAvailabilitiesV2TerritoryAvailabilitiesGetToManyRelatedFieldsTerritoryAvailabilitieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppAvailabilitiesV2TerritoryAvailabilitiesGetToManyRelatedFieldsTerritoryAvailabilitie value)
        {
            return value switch
            {
                AppAvailabilitiesV2TerritoryAvailabilitiesGetToManyRelatedFieldsTerritoryAvailabilitie.Available => "available",
                AppAvailabilitiesV2TerritoryAvailabilitiesGetToManyRelatedFieldsTerritoryAvailabilitie.ContentStatuses => "contentStatuses",
                AppAvailabilitiesV2TerritoryAvailabilitiesGetToManyRelatedFieldsTerritoryAvailabilitie.PreOrderEnabled => "preOrderEnabled",
                AppAvailabilitiesV2TerritoryAvailabilitiesGetToManyRelatedFieldsTerritoryAvailabilitie.PreOrderPublishDate => "preOrderPublishDate",
                AppAvailabilitiesV2TerritoryAvailabilitiesGetToManyRelatedFieldsTerritoryAvailabilitie.ReleaseDate => "releaseDate",
                AppAvailabilitiesV2TerritoryAvailabilitiesGetToManyRelatedFieldsTerritoryAvailabilitie.Territory => "territory",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppAvailabilitiesV2TerritoryAvailabilitiesGetToManyRelatedFieldsTerritoryAvailabilitie? ToEnum(string value)
        {
            return value switch
            {
                "available" => AppAvailabilitiesV2TerritoryAvailabilitiesGetToManyRelatedFieldsTerritoryAvailabilitie.Available,
                "contentStatuses" => AppAvailabilitiesV2TerritoryAvailabilitiesGetToManyRelatedFieldsTerritoryAvailabilitie.ContentStatuses,
                "preOrderEnabled" => AppAvailabilitiesV2TerritoryAvailabilitiesGetToManyRelatedFieldsTerritoryAvailabilitie.PreOrderEnabled,
                "preOrderPublishDate" => AppAvailabilitiesV2TerritoryAvailabilitiesGetToManyRelatedFieldsTerritoryAvailabilitie.PreOrderPublishDate,
                "releaseDate" => AppAvailabilitiesV2TerritoryAvailabilitiesGetToManyRelatedFieldsTerritoryAvailabilitie.ReleaseDate,
                "territory" => AppAvailabilitiesV2TerritoryAvailabilitiesGetToManyRelatedFieldsTerritoryAvailabilitie.Territory,
                _ => null,
            };
        }
    }
}