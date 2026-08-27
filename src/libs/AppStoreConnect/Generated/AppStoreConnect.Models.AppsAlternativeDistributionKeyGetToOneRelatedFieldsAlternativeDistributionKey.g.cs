
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppsAlternativeDistributionKeyGetToOneRelatedFieldsAlternativeDistributionKey
    {
        /// <summary>
        /// 
        /// </summary>
        PublicKey,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppsAlternativeDistributionKeyGetToOneRelatedFieldsAlternativeDistributionKeyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsAlternativeDistributionKeyGetToOneRelatedFieldsAlternativeDistributionKey value)
        {
            return value switch
            {
                AppsAlternativeDistributionKeyGetToOneRelatedFieldsAlternativeDistributionKey.PublicKey => "publicKey",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsAlternativeDistributionKeyGetToOneRelatedFieldsAlternativeDistributionKey? ToEnum(string value)
        {
            return value switch
            {
                "publicKey" => AppsAlternativeDistributionKeyGetToOneRelatedFieldsAlternativeDistributionKey.PublicKey,
                _ => null,
            };
        }
    }
}