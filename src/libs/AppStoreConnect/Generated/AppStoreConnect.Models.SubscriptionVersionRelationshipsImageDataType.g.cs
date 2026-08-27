
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionVersionRelationshipsImageDataType
    {
        /// <summary>
        /// 
        /// </summary>
        SubscriptionImages,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionVersionRelationshipsImageDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionVersionRelationshipsImageDataType value)
        {
            return value switch
            {
                SubscriptionVersionRelationshipsImageDataType.SubscriptionImages => "subscriptionImages",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionVersionRelationshipsImageDataType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionImages" => SubscriptionVersionRelationshipsImageDataType.SubscriptionImages,
                _ => null,
            };
        }
    }
}