
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChecksumAlgorithm
    {
        /// <summary>
        /// 
        /// </summary>
        Md5,
        /// <summary>
        /// 
        /// </summary>
        Sha256,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChecksumAlgorithmExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChecksumAlgorithm value)
        {
            return value switch
            {
                ChecksumAlgorithm.Md5 => "MD5",
                ChecksumAlgorithm.Sha256 => "SHA_256",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChecksumAlgorithm? ToEnum(string value)
        {
            return value switch
            {
                "MD5" => ChecksumAlgorithm.Md5,
                "SHA_256" => ChecksumAlgorithm.Sha256,
                _ => null,
            };
        }
    }
}