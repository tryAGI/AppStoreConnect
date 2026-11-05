
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum RetentionMessageCreateRequestDataRelationshipsAppDataType
    {
        /// <summary>
        ///
        /// </summary>
        Apps,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RetentionMessageCreateRequestDataRelationshipsAppDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RetentionMessageCreateRequestDataRelationshipsAppDataType value)
        {
            return value switch
            {
                RetentionMessageCreateRequestDataRelationshipsAppDataType.Apps => "apps",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RetentionMessageCreateRequestDataRelationshipsAppDataType? ToEnum(string value)
        {
            return value switch
            {
                "apps" => RetentionMessageCreateRequestDataRelationshipsAppDataType.Apps,
                _ => null,
            };
        }
    }
}