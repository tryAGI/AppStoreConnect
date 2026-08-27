
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AlternativeDistributionKeysGetInstanceFieldsAlternativeDistributionKey
    {
        /// <summary>
        /// 
        /// </summary>
        PublicKey,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AlternativeDistributionKeysGetInstanceFieldsAlternativeDistributionKeyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AlternativeDistributionKeysGetInstanceFieldsAlternativeDistributionKey value)
        {
            return value switch
            {
                AlternativeDistributionKeysGetInstanceFieldsAlternativeDistributionKey.PublicKey => "publicKey",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AlternativeDistributionKeysGetInstanceFieldsAlternativeDistributionKey? ToEnum(string value)
        {
            return value switch
            {
                "publicKey" => AlternativeDistributionKeysGetInstanceFieldsAlternativeDistributionKey.PublicKey,
                _ => null,
            };
        }
    }
}