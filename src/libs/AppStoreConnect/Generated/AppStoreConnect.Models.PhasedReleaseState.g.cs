
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum PhasedReleaseState
    {
        /// <summary>
        ///
        /// </summary>
        Active,
        /// <summary>
        ///
        /// </summary>
        Complete,
        /// <summary>
        ///
        /// </summary>
        Inactive,
        /// <summary>
        ///
        /// </summary>
        Paused,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PhasedReleaseStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PhasedReleaseState value)
        {
            return value switch
            {
                PhasedReleaseState.Active => "ACTIVE",
                PhasedReleaseState.Complete => "COMPLETE",
                PhasedReleaseState.Inactive => "INACTIVE",
                PhasedReleaseState.Paused => "PAUSED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PhasedReleaseState? ToEnum(string value)
        {
            return value switch
            {
                "ACTIVE" => PhasedReleaseState.Active,
                "COMPLETE" => PhasedReleaseState.Complete,
                "INACTIVE" => PhasedReleaseState.Inactive,
                "PAUSED" => PhasedReleaseState.Paused,
                _ => null,
            };
        }
    }
}