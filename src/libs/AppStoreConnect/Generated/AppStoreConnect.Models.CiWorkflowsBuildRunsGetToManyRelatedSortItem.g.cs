
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CiWorkflowsBuildRunsGetToManyRelatedSortItem
    {
        /// <summary>
        ///
        /// </summary>
        Minusnumber,
        /// <summary>
        ///
        /// </summary>
        Number,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CiWorkflowsBuildRunsGetToManyRelatedSortItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiWorkflowsBuildRunsGetToManyRelatedSortItem value)
        {
            return value switch
            {
                CiWorkflowsBuildRunsGetToManyRelatedSortItem.Minusnumber => "-number",
                CiWorkflowsBuildRunsGetToManyRelatedSortItem.Number => "number",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiWorkflowsBuildRunsGetToManyRelatedSortItem? ToEnum(string value)
        {
            return value switch
            {
                "-number" => CiWorkflowsBuildRunsGetToManyRelatedSortItem.Minusnumber,
                "number" => CiWorkflowsBuildRunsGetToManyRelatedSortItem.Number,
                _ => null,
            };
        }
    }
}