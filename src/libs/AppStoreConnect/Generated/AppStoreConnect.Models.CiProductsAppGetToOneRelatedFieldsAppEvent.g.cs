
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CiProductsAppGetToOneRelatedFieldsAppEvent
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
    public static class CiProductsAppGetToOneRelatedFieldsAppEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiProductsAppGetToOneRelatedFieldsAppEvent value)
        {
            return value switch
            {
                CiProductsAppGetToOneRelatedFieldsAppEvent.ArchivedTerritorySchedules => "archivedTerritorySchedules",
                CiProductsAppGetToOneRelatedFieldsAppEvent.Badge => "badge",
                CiProductsAppGetToOneRelatedFieldsAppEvent.DeepLink => "deepLink",
                CiProductsAppGetToOneRelatedFieldsAppEvent.EventState => "eventState",
                CiProductsAppGetToOneRelatedFieldsAppEvent.Localizations => "localizations",
                CiProductsAppGetToOneRelatedFieldsAppEvent.PrimaryLocale => "primaryLocale",
                CiProductsAppGetToOneRelatedFieldsAppEvent.Priority => "priority",
                CiProductsAppGetToOneRelatedFieldsAppEvent.PurchaseRequirement => "purchaseRequirement",
                CiProductsAppGetToOneRelatedFieldsAppEvent.Purpose => "purpose",
                CiProductsAppGetToOneRelatedFieldsAppEvent.ReferenceName => "referenceName",
                CiProductsAppGetToOneRelatedFieldsAppEvent.TerritorySchedules => "territorySchedules",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiProductsAppGetToOneRelatedFieldsAppEvent? ToEnum(string value)
        {
            return value switch
            {
                "archivedTerritorySchedules" => CiProductsAppGetToOneRelatedFieldsAppEvent.ArchivedTerritorySchedules,
                "badge" => CiProductsAppGetToOneRelatedFieldsAppEvent.Badge,
                "deepLink" => CiProductsAppGetToOneRelatedFieldsAppEvent.DeepLink,
                "eventState" => CiProductsAppGetToOneRelatedFieldsAppEvent.EventState,
                "localizations" => CiProductsAppGetToOneRelatedFieldsAppEvent.Localizations,
                "primaryLocale" => CiProductsAppGetToOneRelatedFieldsAppEvent.PrimaryLocale,
                "priority" => CiProductsAppGetToOneRelatedFieldsAppEvent.Priority,
                "purchaseRequirement" => CiProductsAppGetToOneRelatedFieldsAppEvent.PurchaseRequirement,
                "purpose" => CiProductsAppGetToOneRelatedFieldsAppEvent.Purpose,
                "referenceName" => CiProductsAppGetToOneRelatedFieldsAppEvent.ReferenceName,
                "territorySchedules" => CiProductsAppGetToOneRelatedFieldsAppEvent.TerritorySchedules,
                _ => null,
            };
        }
    }
}