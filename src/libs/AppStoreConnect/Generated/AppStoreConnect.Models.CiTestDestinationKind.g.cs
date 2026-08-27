
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CiTestDestinationKind
    {
        /// <summary>
        ///
        /// </summary>
        Mac,
        /// <summary>
        ///
        /// </summary>
        Simulator,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CiTestDestinationKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiTestDestinationKind value)
        {
            return value switch
            {
                CiTestDestinationKind.Mac => "MAC",
                CiTestDestinationKind.Simulator => "SIMULATOR",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiTestDestinationKind? ToEnum(string value)
        {
            return value switch
            {
                "MAC" => CiTestDestinationKind.Mac,
                "SIMULATOR" => CiTestDestinationKind.Simulator,
                _ => null,
            };
        }
    }
}