
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CiBuildRunsActionsGetToManyRelatedIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        BuildRun,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CiBuildRunsActionsGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiBuildRunsActionsGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                CiBuildRunsActionsGetToManyRelatedIncludeItem.BuildRun => "buildRun",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiBuildRunsActionsGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "buildRun" => CiBuildRunsActionsGetToManyRelatedIncludeItem.BuildRun,
                _ => null,
            };
        }
    }
}