
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum InAppPurchasePriceSchedulesGetInstanceFieldsInAppPurchasePrice
    {
        /// <summary>
        /// 
        /// </summary>
        EndDate,
        /// <summary>
        /// 
        /// </summary>
        InAppPurchasePricePoint,
        /// <summary>
        /// 
        /// </summary>
        Manual,
        /// <summary>
        /// 
        /// </summary>
        StartDate,
        /// <summary>
        /// 
        /// </summary>
        Territory,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchasePriceSchedulesGetInstanceFieldsInAppPurchasePriceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchasePriceSchedulesGetInstanceFieldsInAppPurchasePrice value)
        {
            return value switch
            {
                InAppPurchasePriceSchedulesGetInstanceFieldsInAppPurchasePrice.EndDate => "endDate",
                InAppPurchasePriceSchedulesGetInstanceFieldsInAppPurchasePrice.InAppPurchasePricePoint => "inAppPurchasePricePoint",
                InAppPurchasePriceSchedulesGetInstanceFieldsInAppPurchasePrice.Manual => "manual",
                InAppPurchasePriceSchedulesGetInstanceFieldsInAppPurchasePrice.StartDate => "startDate",
                InAppPurchasePriceSchedulesGetInstanceFieldsInAppPurchasePrice.Territory => "territory",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchasePriceSchedulesGetInstanceFieldsInAppPurchasePrice? ToEnum(string value)
        {
            return value switch
            {
                "endDate" => InAppPurchasePriceSchedulesGetInstanceFieldsInAppPurchasePrice.EndDate,
                "inAppPurchasePricePoint" => InAppPurchasePriceSchedulesGetInstanceFieldsInAppPurchasePrice.InAppPurchasePricePoint,
                "manual" => InAppPurchasePriceSchedulesGetInstanceFieldsInAppPurchasePrice.Manual,
                "startDate" => InAppPurchasePriceSchedulesGetInstanceFieldsInAppPurchasePrice.StartDate,
                "territory" => InAppPurchasePriceSchedulesGetInstanceFieldsInAppPurchasePrice.Territory,
                _ => null,
            };
        }
    }
}