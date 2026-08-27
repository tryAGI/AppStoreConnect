
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CiBuildRunAttributesCancelReason
    {
        /// <summary>
        ///
        /// </summary>
        AutomaticallyByNewerBuild,
        /// <summary>
        ///
        /// </summary>
        ManuallyByUser,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CiBuildRunAttributesCancelReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiBuildRunAttributesCancelReason value)
        {
            return value switch
            {
                CiBuildRunAttributesCancelReason.AutomaticallyByNewerBuild => "AUTOMATICALLY_BY_NEWER_BUILD",
                CiBuildRunAttributesCancelReason.ManuallyByUser => "MANUALLY_BY_USER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiBuildRunAttributesCancelReason? ToEnum(string value)
        {
            return value switch
            {
                "AUTOMATICALLY_BY_NEWER_BUILD" => CiBuildRunAttributesCancelReason.AutomaticallyByNewerBuild,
                "MANUALLY_BY_USER" => CiBuildRunAttributesCancelReason.ManuallyByUser,
                _ => null,
            };
        }
    }
}