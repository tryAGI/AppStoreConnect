
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SandboxTestersClearPurchaseHistoryRequestV2Type
    {
        /// <summary>
        ///
        /// </summary>
        SandboxTestersClearPurchaseHistoryRequest,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SandboxTestersClearPurchaseHistoryRequestV2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SandboxTestersClearPurchaseHistoryRequestV2Type value)
        {
            return value switch
            {
                SandboxTestersClearPurchaseHistoryRequestV2Type.SandboxTestersClearPurchaseHistoryRequest => "sandboxTestersClearPurchaseHistoryRequest",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SandboxTestersClearPurchaseHistoryRequestV2Type? ToEnum(string value)
        {
            return value switch
            {
                "sandboxTestersClearPurchaseHistoryRequest" => SandboxTestersClearPurchaseHistoryRequestV2Type.SandboxTestersClearPurchaseHistoryRequest,
                _ => null,
            };
        }
    }
}