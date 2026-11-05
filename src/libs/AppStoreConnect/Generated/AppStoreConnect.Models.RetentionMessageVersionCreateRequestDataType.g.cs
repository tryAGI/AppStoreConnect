
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum RetentionMessageVersionCreateRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        RetentionMessageVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RetentionMessageVersionCreateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RetentionMessageVersionCreateRequestDataType value)
        {
            return value switch
            {
                RetentionMessageVersionCreateRequestDataType.RetentionMessageVersions => "retentionMessageVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RetentionMessageVersionCreateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "retentionMessageVersions" => RetentionMessageVersionCreateRequestDataType.RetentionMessageVersions,
                _ => null,
            };
        }
    }
}