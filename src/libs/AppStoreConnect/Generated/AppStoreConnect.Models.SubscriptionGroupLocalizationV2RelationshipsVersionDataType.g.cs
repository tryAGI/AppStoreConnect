
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionGroupLocalizationV2RelationshipsVersionDataType
    {
        /// <summary>
        /// 
        /// </summary>
        SubscriptionGroupVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionGroupLocalizationV2RelationshipsVersionDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionGroupLocalizationV2RelationshipsVersionDataType value)
        {
            return value switch
            {
                SubscriptionGroupLocalizationV2RelationshipsVersionDataType.SubscriptionGroupVersions => "subscriptionGroupVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionGroupLocalizationV2RelationshipsVersionDataType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionGroupVersions" => SubscriptionGroupLocalizationV2RelationshipsVersionDataType.SubscriptionGroupVersions,
                _ => null,
            };
        }
    }
}