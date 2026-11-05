
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppsGetCollectionFieldsRetentionMessage
    {
        /// <summary>
        ///
        /// </summary>
        ReferenceName,
        /// <summary>
        ///
        /// </summary>
        Subscriptions,
        /// <summary>
        ///
        /// </summary>
        Versions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppsGetCollectionFieldsRetentionMessageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsGetCollectionFieldsRetentionMessage value)
        {
            return value switch
            {
                AppsGetCollectionFieldsRetentionMessage.ReferenceName => "referenceName",
                AppsGetCollectionFieldsRetentionMessage.Subscriptions => "subscriptions",
                AppsGetCollectionFieldsRetentionMessage.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsGetCollectionFieldsRetentionMessage? ToEnum(string value)
        {
            return value switch
            {
                "referenceName" => AppsGetCollectionFieldsRetentionMessage.ReferenceName,
                "subscriptions" => AppsGetCollectionFieldsRetentionMessage.Subscriptions,
                "versions" => AppsGetCollectionFieldsRetentionMessage.Versions,
                _ => null,
            };
        }
    }
}