
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionLocalizationV2RelationshipsVersionDataType
    {
        /// <summary>
        ///
        /// </summary>
        SubscriptionVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionLocalizationV2RelationshipsVersionDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionLocalizationV2RelationshipsVersionDataType value)
        {
            return value switch
            {
                SubscriptionLocalizationV2RelationshipsVersionDataType.SubscriptionVersions => "subscriptionVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionLocalizationV2RelationshipsVersionDataType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionVersions" => SubscriptionLocalizationV2RelationshipsVersionDataType.SubscriptionVersions,
                _ => null,
            };
        }
    }
}