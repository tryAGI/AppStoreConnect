
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppsGetInstanceFieldsAppEvent
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
    public static class AppsGetInstanceFieldsAppEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsGetInstanceFieldsAppEvent value)
        {
            return value switch
            {
                AppsGetInstanceFieldsAppEvent.ArchivedTerritorySchedules => "archivedTerritorySchedules",
                AppsGetInstanceFieldsAppEvent.Badge => "badge",
                AppsGetInstanceFieldsAppEvent.DeepLink => "deepLink",
                AppsGetInstanceFieldsAppEvent.EventState => "eventState",
                AppsGetInstanceFieldsAppEvent.Localizations => "localizations",
                AppsGetInstanceFieldsAppEvent.PrimaryLocale => "primaryLocale",
                AppsGetInstanceFieldsAppEvent.Priority => "priority",
                AppsGetInstanceFieldsAppEvent.PurchaseRequirement => "purchaseRequirement",
                AppsGetInstanceFieldsAppEvent.Purpose => "purpose",
                AppsGetInstanceFieldsAppEvent.ReferenceName => "referenceName",
                AppsGetInstanceFieldsAppEvent.TerritorySchedules => "territorySchedules",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsGetInstanceFieldsAppEvent? ToEnum(string value)
        {
            return value switch
            {
                "archivedTerritorySchedules" => AppsGetInstanceFieldsAppEvent.ArchivedTerritorySchedules,
                "badge" => AppsGetInstanceFieldsAppEvent.Badge,
                "deepLink" => AppsGetInstanceFieldsAppEvent.DeepLink,
                "eventState" => AppsGetInstanceFieldsAppEvent.EventState,
                "localizations" => AppsGetInstanceFieldsAppEvent.Localizations,
                "primaryLocale" => AppsGetInstanceFieldsAppEvent.PrimaryLocale,
                "priority" => AppsGetInstanceFieldsAppEvent.Priority,
                "purchaseRequirement" => AppsGetInstanceFieldsAppEvent.PurchaseRequirement,
                "purpose" => AppsGetInstanceFieldsAppEvent.Purpose,
                "referenceName" => AppsGetInstanceFieldsAppEvent.ReferenceName,
                "territorySchedules" => AppsGetInstanceFieldsAppEvent.TerritorySchedules,
                _ => null,
            };
        }
    }
}