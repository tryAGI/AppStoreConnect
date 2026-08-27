
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppEventLocalizationsGetInstanceFieldsAppEvent
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
    public static class AppEventLocalizationsGetInstanceFieldsAppEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppEventLocalizationsGetInstanceFieldsAppEvent value)
        {
            return value switch
            {
                AppEventLocalizationsGetInstanceFieldsAppEvent.ArchivedTerritorySchedules => "archivedTerritorySchedules",
                AppEventLocalizationsGetInstanceFieldsAppEvent.Badge => "badge",
                AppEventLocalizationsGetInstanceFieldsAppEvent.DeepLink => "deepLink",
                AppEventLocalizationsGetInstanceFieldsAppEvent.EventState => "eventState",
                AppEventLocalizationsGetInstanceFieldsAppEvent.Localizations => "localizations",
                AppEventLocalizationsGetInstanceFieldsAppEvent.PrimaryLocale => "primaryLocale",
                AppEventLocalizationsGetInstanceFieldsAppEvent.Priority => "priority",
                AppEventLocalizationsGetInstanceFieldsAppEvent.PurchaseRequirement => "purchaseRequirement",
                AppEventLocalizationsGetInstanceFieldsAppEvent.Purpose => "purpose",
                AppEventLocalizationsGetInstanceFieldsAppEvent.ReferenceName => "referenceName",
                AppEventLocalizationsGetInstanceFieldsAppEvent.TerritorySchedules => "territorySchedules",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppEventLocalizationsGetInstanceFieldsAppEvent? ToEnum(string value)
        {
            return value switch
            {
                "archivedTerritorySchedules" => AppEventLocalizationsGetInstanceFieldsAppEvent.ArchivedTerritorySchedules,
                "badge" => AppEventLocalizationsGetInstanceFieldsAppEvent.Badge,
                "deepLink" => AppEventLocalizationsGetInstanceFieldsAppEvent.DeepLink,
                "eventState" => AppEventLocalizationsGetInstanceFieldsAppEvent.EventState,
                "localizations" => AppEventLocalizationsGetInstanceFieldsAppEvent.Localizations,
                "primaryLocale" => AppEventLocalizationsGetInstanceFieldsAppEvent.PrimaryLocale,
                "priority" => AppEventLocalizationsGetInstanceFieldsAppEvent.Priority,
                "purchaseRequirement" => AppEventLocalizationsGetInstanceFieldsAppEvent.PurchaseRequirement,
                "purpose" => AppEventLocalizationsGetInstanceFieldsAppEvent.Purpose,
                "referenceName" => AppEventLocalizationsGetInstanceFieldsAppEvent.ReferenceName,
                "territorySchedules" => AppEventLocalizationsGetInstanceFieldsAppEvent.TerritorySchedules,
                _ => null,
            };
        }
    }
}