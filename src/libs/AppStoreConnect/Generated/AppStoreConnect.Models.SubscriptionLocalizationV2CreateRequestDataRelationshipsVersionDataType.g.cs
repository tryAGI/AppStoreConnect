
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionLocalizationV2CreateRequestDataRelationshipsVersionDataType
    {
        /// <summary>
        ///
        /// </summary>
        SubscriptionVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionLocalizationV2CreateRequestDataRelationshipsVersionDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionLocalizationV2CreateRequestDataRelationshipsVersionDataType value)
        {
            return value switch
            {
                SubscriptionLocalizationV2CreateRequestDataRelationshipsVersionDataType.SubscriptionVersions => "subscriptionVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionLocalizationV2CreateRequestDataRelationshipsVersionDataType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionVersions" => SubscriptionLocalizationV2CreateRequestDataRelationshipsVersionDataType.SubscriptionVersions,
                _ => null,
            };
        }
    }
}