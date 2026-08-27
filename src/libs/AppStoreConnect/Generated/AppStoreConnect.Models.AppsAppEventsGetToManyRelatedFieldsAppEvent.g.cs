
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppsAppEventsGetToManyRelatedFieldsAppEvent
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
    public static class AppsAppEventsGetToManyRelatedFieldsAppEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsAppEventsGetToManyRelatedFieldsAppEvent value)
        {
            return value switch
            {
                AppsAppEventsGetToManyRelatedFieldsAppEvent.ArchivedTerritorySchedules => "archivedTerritorySchedules",
                AppsAppEventsGetToManyRelatedFieldsAppEvent.Badge => "badge",
                AppsAppEventsGetToManyRelatedFieldsAppEvent.DeepLink => "deepLink",
                AppsAppEventsGetToManyRelatedFieldsAppEvent.EventState => "eventState",
                AppsAppEventsGetToManyRelatedFieldsAppEvent.Localizations => "localizations",
                AppsAppEventsGetToManyRelatedFieldsAppEvent.PrimaryLocale => "primaryLocale",
                AppsAppEventsGetToManyRelatedFieldsAppEvent.Priority => "priority",
                AppsAppEventsGetToManyRelatedFieldsAppEvent.PurchaseRequirement => "purchaseRequirement",
                AppsAppEventsGetToManyRelatedFieldsAppEvent.Purpose => "purpose",
                AppsAppEventsGetToManyRelatedFieldsAppEvent.ReferenceName => "referenceName",
                AppsAppEventsGetToManyRelatedFieldsAppEvent.TerritorySchedules => "territorySchedules",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsAppEventsGetToManyRelatedFieldsAppEvent? ToEnum(string value)
        {
            return value switch
            {
                "archivedTerritorySchedules" => AppsAppEventsGetToManyRelatedFieldsAppEvent.ArchivedTerritorySchedules,
                "badge" => AppsAppEventsGetToManyRelatedFieldsAppEvent.Badge,
                "deepLink" => AppsAppEventsGetToManyRelatedFieldsAppEvent.DeepLink,
                "eventState" => AppsAppEventsGetToManyRelatedFieldsAppEvent.EventState,
                "localizations" => AppsAppEventsGetToManyRelatedFieldsAppEvent.Localizations,
                "primaryLocale" => AppsAppEventsGetToManyRelatedFieldsAppEvent.PrimaryLocale,
                "priority" => AppsAppEventsGetToManyRelatedFieldsAppEvent.Priority,
                "purchaseRequirement" => AppsAppEventsGetToManyRelatedFieldsAppEvent.PurchaseRequirement,
                "purpose" => AppsAppEventsGetToManyRelatedFieldsAppEvent.Purpose,
                "referenceName" => AppsAppEventsGetToManyRelatedFieldsAppEvent.ReferenceName,
                "territorySchedules" => AppsAppEventsGetToManyRelatedFieldsAppEvent.TerritorySchedules,
                _ => null,
            };
        }
    }
}