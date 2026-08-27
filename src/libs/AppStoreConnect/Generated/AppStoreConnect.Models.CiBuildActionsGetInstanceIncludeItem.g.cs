
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CiBuildActionsGetInstanceIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        BuildRun,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CiBuildActionsGetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiBuildActionsGetInstanceIncludeItem value)
        {
            return value switch
            {
                CiBuildActionsGetInstanceIncludeItem.BuildRun => "buildRun",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiBuildActionsGetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "buildRun" => CiBuildActionsGetInstanceIncludeItem.BuildRun,
                _ => null,
            };
        }
    }
}