
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BuildAppLinkageResponseDataType
    {
        /// <summary>
        /// 
        /// </summary>
        Apps,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BuildAppLinkageResponseDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildAppLinkageResponseDataType value)
        {
            return value switch
            {
                BuildAppLinkageResponseDataType.Apps => "apps",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildAppLinkageResponseDataType? ToEnum(string value)
        {
            return value switch
            {
                "apps" => BuildAppLinkageResponseDataType.Apps,
                _ => null,
            };
        }
    }
}