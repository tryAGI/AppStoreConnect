
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppEventsLocalizationsGetToManyRelatedFieldsAppEvent
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
    public static class AppEventsLocalizationsGetToManyRelatedFieldsAppEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppEventsLocalizationsGetToManyRelatedFieldsAppEvent value)
        {
            return value switch
            {
                AppEventsLocalizationsGetToManyRelatedFieldsAppEvent.ArchivedTerritorySchedules => "archivedTerritorySchedules",
                AppEventsLocalizationsGetToManyRelatedFieldsAppEvent.Badge => "badge",
                AppEventsLocalizationsGetToManyRelatedFieldsAppEvent.DeepLink => "deepLink",
                AppEventsLocalizationsGetToManyRelatedFieldsAppEvent.EventState => "eventState",
                AppEventsLocalizationsGetToManyRelatedFieldsAppEvent.Localizations => "localizations",
                AppEventsLocalizationsGetToManyRelatedFieldsAppEvent.PrimaryLocale => "primaryLocale",
                AppEventsLocalizationsGetToManyRelatedFieldsAppEvent.Priority => "priority",
                AppEventsLocalizationsGetToManyRelatedFieldsAppEvent.PurchaseRequirement => "purchaseRequirement",
                AppEventsLocalizationsGetToManyRelatedFieldsAppEvent.Purpose => "purpose",
                AppEventsLocalizationsGetToManyRelatedFieldsAppEvent.ReferenceName => "referenceName",
                AppEventsLocalizationsGetToManyRelatedFieldsAppEvent.TerritorySchedules => "territorySchedules",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppEventsLocalizationsGetToManyRelatedFieldsAppEvent? ToEnum(string value)
        {
            return value switch
            {
                "archivedTerritorySchedules" => AppEventsLocalizationsGetToManyRelatedFieldsAppEvent.ArchivedTerritorySchedules,
                "badge" => AppEventsLocalizationsGetToManyRelatedFieldsAppEvent.Badge,
                "deepLink" => AppEventsLocalizationsGetToManyRelatedFieldsAppEvent.DeepLink,
                "eventState" => AppEventsLocalizationsGetToManyRelatedFieldsAppEvent.EventState,
                "localizations" => AppEventsLocalizationsGetToManyRelatedFieldsAppEvent.Localizations,
                "primaryLocale" => AppEventsLocalizationsGetToManyRelatedFieldsAppEvent.PrimaryLocale,
                "priority" => AppEventsLocalizationsGetToManyRelatedFieldsAppEvent.Priority,
                "purchaseRequirement" => AppEventsLocalizationsGetToManyRelatedFieldsAppEvent.PurchaseRequirement,
                "purpose" => AppEventsLocalizationsGetToManyRelatedFieldsAppEvent.Purpose,
                "referenceName" => AppEventsLocalizationsGetToManyRelatedFieldsAppEvent.ReferenceName,
                "territorySchedules" => AppEventsLocalizationsGetToManyRelatedFieldsAppEvent.TerritorySchedules,
                _ => null,
            };
        }
    }
}