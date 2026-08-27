
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppEventsGetInstanceFieldsAppEvent
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
    public static class AppEventsGetInstanceFieldsAppEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppEventsGetInstanceFieldsAppEvent value)
        {
            return value switch
            {
                AppEventsGetInstanceFieldsAppEvent.ArchivedTerritorySchedules => "archivedTerritorySchedules",
                AppEventsGetInstanceFieldsAppEvent.Badge => "badge",
                AppEventsGetInstanceFieldsAppEvent.DeepLink => "deepLink",
                AppEventsGetInstanceFieldsAppEvent.EventState => "eventState",
                AppEventsGetInstanceFieldsAppEvent.Localizations => "localizations",
                AppEventsGetInstanceFieldsAppEvent.PrimaryLocale => "primaryLocale",
                AppEventsGetInstanceFieldsAppEvent.Priority => "priority",
                AppEventsGetInstanceFieldsAppEvent.PurchaseRequirement => "purchaseRequirement",
                AppEventsGetInstanceFieldsAppEvent.Purpose => "purpose",
                AppEventsGetInstanceFieldsAppEvent.ReferenceName => "referenceName",
                AppEventsGetInstanceFieldsAppEvent.TerritorySchedules => "territorySchedules",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppEventsGetInstanceFieldsAppEvent? ToEnum(string value)
        {
            return value switch
            {
                "archivedTerritorySchedules" => AppEventsGetInstanceFieldsAppEvent.ArchivedTerritorySchedules,
                "badge" => AppEventsGetInstanceFieldsAppEvent.Badge,
                "deepLink" => AppEventsGetInstanceFieldsAppEvent.DeepLink,
                "eventState" => AppEventsGetInstanceFieldsAppEvent.EventState,
                "localizations" => AppEventsGetInstanceFieldsAppEvent.Localizations,
                "primaryLocale" => AppEventsGetInstanceFieldsAppEvent.PrimaryLocale,
                "priority" => AppEventsGetInstanceFieldsAppEvent.Priority,
                "purchaseRequirement" => AppEventsGetInstanceFieldsAppEvent.PurchaseRequirement,
                "purpose" => AppEventsGetInstanceFieldsAppEvent.Purpose,
                "referenceName" => AppEventsGetInstanceFieldsAppEvent.ReferenceName,
                "territorySchedules" => AppEventsGetInstanceFieldsAppEvent.TerritorySchedules,
                _ => null,
            };
        }
    }
}