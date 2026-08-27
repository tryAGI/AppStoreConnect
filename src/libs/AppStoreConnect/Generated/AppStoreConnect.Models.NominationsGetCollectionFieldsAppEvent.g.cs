
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum NominationsGetCollectionFieldsAppEvent
    {
        /// <summary>
        /// 
        /// </summary>
        ArchivedTerritorySchedules,
        /// <summary>
        /// 
        /// </summary>
        Badge,
        /// <summary>
        /// 
        /// </summary>
        DeepLink,
        /// <summary>
        /// 
        /// </summary>
        EventState,
        /// <summary>
        /// 
        /// </summary>
        Localizations,
        /// <summary>
        /// 
        /// </summary>
        PrimaryLocale,
        /// <summary>
        /// 
        /// </summary>
        Priority,
        /// <summary>
        /// 
        /// </summary>
        PurchaseRequirement,
        /// <summary>
        /// 
        /// </summary>
        Purpose,
        /// <summary>
        /// 
        /// </summary>
        ReferenceName,
        /// <summary>
        /// 
        /// </summary>
        TerritorySchedules,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NominationsGetCollectionFieldsAppEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NominationsGetCollectionFieldsAppEvent value)
        {
            return value switch
            {
                NominationsGetCollectionFieldsAppEvent.ArchivedTerritorySchedules => "archivedTerritorySchedules",
                NominationsGetCollectionFieldsAppEvent.Badge => "badge",
                NominationsGetCollectionFieldsAppEvent.DeepLink => "deepLink",
                NominationsGetCollectionFieldsAppEvent.EventState => "eventState",
                NominationsGetCollectionFieldsAppEvent.Localizations => "localizations",
                NominationsGetCollectionFieldsAppEvent.PrimaryLocale => "primaryLocale",
                NominationsGetCollectionFieldsAppEvent.Priority => "priority",
                NominationsGetCollectionFieldsAppEvent.PurchaseRequirement => "purchaseRequirement",
                NominationsGetCollectionFieldsAppEvent.Purpose => "purpose",
                NominationsGetCollectionFieldsAppEvent.ReferenceName => "referenceName",
                NominationsGetCollectionFieldsAppEvent.TerritorySchedules => "territorySchedules",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NominationsGetCollectionFieldsAppEvent? ToEnum(string value)
        {
            return value switch
            {
                "archivedTerritorySchedules" => NominationsGetCollectionFieldsAppEvent.ArchivedTerritorySchedules,
                "badge" => NominationsGetCollectionFieldsAppEvent.Badge,
                "deepLink" => NominationsGetCollectionFieldsAppEvent.DeepLink,
                "eventState" => NominationsGetCollectionFieldsAppEvent.EventState,
                "localizations" => NominationsGetCollectionFieldsAppEvent.Localizations,
                "primaryLocale" => NominationsGetCollectionFieldsAppEvent.PrimaryLocale,
                "priority" => NominationsGetCollectionFieldsAppEvent.Priority,
                "purchaseRequirement" => NominationsGetCollectionFieldsAppEvent.PurchaseRequirement,
                "purpose" => NominationsGetCollectionFieldsAppEvent.Purpose,
                "referenceName" => NominationsGetCollectionFieldsAppEvent.ReferenceName,
                "territorySchedules" => NominationsGetCollectionFieldsAppEvent.TerritorySchedules,
                _ => null,
            };
        }
    }
}