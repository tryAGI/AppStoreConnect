
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppsGetCollectionFieldsAppEvent
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
    public static class AppsGetCollectionFieldsAppEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsGetCollectionFieldsAppEvent value)
        {
            return value switch
            {
                AppsGetCollectionFieldsAppEvent.ArchivedTerritorySchedules => "archivedTerritorySchedules",
                AppsGetCollectionFieldsAppEvent.Badge => "badge",
                AppsGetCollectionFieldsAppEvent.DeepLink => "deepLink",
                AppsGetCollectionFieldsAppEvent.EventState => "eventState",
                AppsGetCollectionFieldsAppEvent.Localizations => "localizations",
                AppsGetCollectionFieldsAppEvent.PrimaryLocale => "primaryLocale",
                AppsGetCollectionFieldsAppEvent.Priority => "priority",
                AppsGetCollectionFieldsAppEvent.PurchaseRequirement => "purchaseRequirement",
                AppsGetCollectionFieldsAppEvent.Purpose => "purpose",
                AppsGetCollectionFieldsAppEvent.ReferenceName => "referenceName",
                AppsGetCollectionFieldsAppEvent.TerritorySchedules => "territorySchedules",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsGetCollectionFieldsAppEvent? ToEnum(string value)
        {
            return value switch
            {
                "archivedTerritorySchedules" => AppsGetCollectionFieldsAppEvent.ArchivedTerritorySchedules,
                "badge" => AppsGetCollectionFieldsAppEvent.Badge,
                "deepLink" => AppsGetCollectionFieldsAppEvent.DeepLink,
                "eventState" => AppsGetCollectionFieldsAppEvent.EventState,
                "localizations" => AppsGetCollectionFieldsAppEvent.Localizations,
                "primaryLocale" => AppsGetCollectionFieldsAppEvent.PrimaryLocale,
                "priority" => AppsGetCollectionFieldsAppEvent.Priority,
                "purchaseRequirement" => AppsGetCollectionFieldsAppEvent.PurchaseRequirement,
                "purpose" => AppsGetCollectionFieldsAppEvent.Purpose,
                "referenceName" => AppsGetCollectionFieldsAppEvent.ReferenceName,
                "territorySchedules" => AppsGetCollectionFieldsAppEvent.TerritorySchedules,
                _ => null,
            };
        }
    }
}