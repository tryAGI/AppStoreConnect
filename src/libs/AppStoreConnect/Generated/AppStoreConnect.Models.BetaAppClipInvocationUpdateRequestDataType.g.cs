
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaAppClipInvocationUpdateRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        BetaAppClipInvocations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaAppClipInvocationUpdateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaAppClipInvocationUpdateRequestDataType value)
        {
            return value switch
            {
                BetaAppClipInvocationUpdateRequestDataType.BetaAppClipInvocations => "betaAppClipInvocations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaAppClipInvocationUpdateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "betaAppClipInvocations" => BetaAppClipInvocationUpdateRequestDataType.BetaAppClipInvocations,
                _ => null,
            };
        }
    }
}