
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum NominationsGetInstanceFieldsAppEvent
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
    public static class NominationsGetInstanceFieldsAppEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NominationsGetInstanceFieldsAppEvent value)
        {
            return value switch
            {
                NominationsGetInstanceFieldsAppEvent.ArchivedTerritorySchedules => "archivedTerritorySchedules",
                NominationsGetInstanceFieldsAppEvent.Badge => "badge",
                NominationsGetInstanceFieldsAppEvent.DeepLink => "deepLink",
                NominationsGetInstanceFieldsAppEvent.EventState => "eventState",
                NominationsGetInstanceFieldsAppEvent.Localizations => "localizations",
                NominationsGetInstanceFieldsAppEvent.PrimaryLocale => "primaryLocale",
                NominationsGetInstanceFieldsAppEvent.Priority => "priority",
                NominationsGetInstanceFieldsAppEvent.PurchaseRequirement => "purchaseRequirement",
                NominationsGetInstanceFieldsAppEvent.Purpose => "purpose",
                NominationsGetInstanceFieldsAppEvent.ReferenceName => "referenceName",
                NominationsGetInstanceFieldsAppEvent.TerritorySchedules => "territorySchedules",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NominationsGetInstanceFieldsAppEvent? ToEnum(string value)
        {
            return value switch
            {
                "archivedTerritorySchedules" => NominationsGetInstanceFieldsAppEvent.ArchivedTerritorySchedules,
                "badge" => NominationsGetInstanceFieldsAppEvent.Badge,
                "deepLink" => NominationsGetInstanceFieldsAppEvent.DeepLink,
                "eventState" => NominationsGetInstanceFieldsAppEvent.EventState,
                "localizations" => NominationsGetInstanceFieldsAppEvent.Localizations,
                "primaryLocale" => NominationsGetInstanceFieldsAppEvent.PrimaryLocale,
                "priority" => NominationsGetInstanceFieldsAppEvent.Priority,
                "purchaseRequirement" => NominationsGetInstanceFieldsAppEvent.PurchaseRequirement,
                "purpose" => NominationsGetInstanceFieldsAppEvent.Purpose,
                "referenceName" => NominationsGetInstanceFieldsAppEvent.ReferenceName,
                "territorySchedules" => NominationsGetInstanceFieldsAppEvent.TerritorySchedules,
                _ => null,
            };
        }
    }
}