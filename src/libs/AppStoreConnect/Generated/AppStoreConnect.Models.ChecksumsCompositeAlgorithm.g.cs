
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum ChecksumsCompositeAlgorithm
    {
        /// <summary>
        ///
        /// </summary>
        Md5,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChecksumsCompositeAlgorithmExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChecksumsCompositeAlgorithm value)
        {
            return value switch
            {
                ChecksumsCompositeAlgorithm.Md5 => "MD5",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChecksumsCompositeAlgorithm? ToEnum(string value)
        {
            return value switch
            {
                "MD5" => ChecksumsCompositeAlgorithm.Md5,
                _ => null,
            };
        }
    }
}