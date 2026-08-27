
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaAppClipInvocationCreateRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        BetaAppClipInvocations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaAppClipInvocationCreateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaAppClipInvocationCreateRequestDataType value)
        {
            return value switch
            {
                BetaAppClipInvocationCreateRequestDataType.BetaAppClipInvocations => "betaAppClipInvocations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaAppClipInvocationCreateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "betaAppClipInvocations" => BetaAppClipInvocationCreateRequestDataType.BetaAppClipInvocations,
                _ => null,
            };
        }
    }
}