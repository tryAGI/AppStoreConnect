
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum InAppPurchaseVersionRelationshipsImagesDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        InAppPurchaseImages,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchaseVersionRelationshipsImagesDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseVersionRelationshipsImagesDataItemType value)
        {
            return value switch
            {
                InAppPurchaseVersionRelationshipsImagesDataItemType.InAppPurchaseImages => "inAppPurchaseImages",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseVersionRelationshipsImagesDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "inAppPurchaseImages" => InAppPurchaseVersionRelationshipsImagesDataItemType.InAppPurchaseImages,
                _ => null,
            };
        }
    }
}