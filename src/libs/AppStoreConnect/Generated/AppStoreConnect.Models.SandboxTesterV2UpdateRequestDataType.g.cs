
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SandboxTesterV2UpdateRequestDataType
    {
        /// <summary>
        /// 
        /// </summary>
        SandboxTesters,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SandboxTesterV2UpdateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SandboxTesterV2UpdateRequestDataType value)
        {
            return value switch
            {
                SandboxTesterV2UpdateRequestDataType.SandboxTesters => "sandboxTesters",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SandboxTesterV2UpdateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "sandboxTesters" => SandboxTesterV2UpdateRequestDataType.SandboxTesters,
                _ => null,
            };
        }
    }
}