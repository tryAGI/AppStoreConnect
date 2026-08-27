
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum ReviewSubmissionsItemsGetToManyRelatedFieldsAppEvent
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
    public static class ReviewSubmissionsItemsGetToManyRelatedFieldsAppEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReviewSubmissionsItemsGetToManyRelatedFieldsAppEvent value)
        {
            return value switch
            {
                ReviewSubmissionsItemsGetToManyRelatedFieldsAppEvent.ArchivedTerritorySchedules => "archivedTerritorySchedules",
                ReviewSubmissionsItemsGetToManyRelatedFieldsAppEvent.Badge => "badge",
                ReviewSubmissionsItemsGetToManyRelatedFieldsAppEvent.DeepLink => "deepLink",
                ReviewSubmissionsItemsGetToManyRelatedFieldsAppEvent.EventState => "eventState",
                ReviewSubmissionsItemsGetToManyRelatedFieldsAppEvent.Localizations => "localizations",
                ReviewSubmissionsItemsGetToManyRelatedFieldsAppEvent.PrimaryLocale => "primaryLocale",
                ReviewSubmissionsItemsGetToManyRelatedFieldsAppEvent.Priority => "priority",
                ReviewSubmissionsItemsGetToManyRelatedFieldsAppEvent.PurchaseRequirement => "purchaseRequirement",
                ReviewSubmissionsItemsGetToManyRelatedFieldsAppEvent.Purpose => "purpose",
                ReviewSubmissionsItemsGetToManyRelatedFieldsAppEvent.ReferenceName => "referenceName",
                ReviewSubmissionsItemsGetToManyRelatedFieldsAppEvent.TerritorySchedules => "territorySchedules",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReviewSubmissionsItemsGetToManyRelatedFieldsAppEvent? ToEnum(string value)
        {
            return value switch
            {
                "archivedTerritorySchedules" => ReviewSubmissionsItemsGetToManyRelatedFieldsAppEvent.ArchivedTerritorySchedules,
                "badge" => ReviewSubmissionsItemsGetToManyRelatedFieldsAppEvent.Badge,
                "deepLink" => ReviewSubmissionsItemsGetToManyRelatedFieldsAppEvent.DeepLink,
                "eventState" => ReviewSubmissionsItemsGetToManyRelatedFieldsAppEvent.EventState,
                "localizations" => ReviewSubmissionsItemsGetToManyRelatedFieldsAppEvent.Localizations,
                "primaryLocale" => ReviewSubmissionsItemsGetToManyRelatedFieldsAppEvent.PrimaryLocale,
                "priority" => ReviewSubmissionsItemsGetToManyRelatedFieldsAppEvent.Priority,
                "purchaseRequirement" => ReviewSubmissionsItemsGetToManyRelatedFieldsAppEvent.PurchaseRequirement,
                "purpose" => ReviewSubmissionsItemsGetToManyRelatedFieldsAppEvent.Purpose,
                "referenceName" => ReviewSubmissionsItemsGetToManyRelatedFieldsAppEvent.ReferenceName,
                "territorySchedules" => ReviewSubmissionsItemsGetToManyRelatedFieldsAppEvent.TerritorySchedules,
                _ => null,
            };
        }
    }
}