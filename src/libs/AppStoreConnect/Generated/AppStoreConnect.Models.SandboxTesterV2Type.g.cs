
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SandboxTesterV2Type
    {
        /// <summary>
        /// 
        /// </summary>
        SandboxTesters,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SandboxTesterV2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SandboxTesterV2Type value)
        {
            return value switch
            {
                SandboxTesterV2Type.SandboxTesters => "sandboxTesters",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SandboxTesterV2Type? ToEnum(string value)
        {
            return value switch
            {
                "sandboxTesters" => SandboxTesterV2Type.SandboxTesters,
                _ => null,
            };
        }
    }
}