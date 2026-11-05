
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CiProductsAppGetToOneRelatedFieldsRetentionMessage
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
    public static class CiProductsAppGetToOneRelatedFieldsRetentionMessageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiProductsAppGetToOneRelatedFieldsRetentionMessage value)
        {
            return value switch
            {
                CiProductsAppGetToOneRelatedFieldsRetentionMessage.ReferenceName => "referenceName",
                CiProductsAppGetToOneRelatedFieldsRetentionMessage.Subscriptions => "subscriptions",
                CiProductsAppGetToOneRelatedFieldsRetentionMessage.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiProductsAppGetToOneRelatedFieldsRetentionMessage? ToEnum(string value)
        {
            return value switch
            {
                "referenceName" => CiProductsAppGetToOneRelatedFieldsRetentionMessage.ReferenceName,
                "subscriptions" => CiProductsAppGetToOneRelatedFieldsRetentionMessage.Subscriptions,
                "versions" => CiProductsAppGetToOneRelatedFieldsRetentionMessage.Versions,
                _ => null,
            };
        }
    }
}