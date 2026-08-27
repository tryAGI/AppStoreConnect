
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CiProductsBuildRunsGetToManyRelatedSortItem
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
    public static class CiProductsBuildRunsGetToManyRelatedSortItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiProductsBuildRunsGetToManyRelatedSortItem value)
        {
            return value switch
            {
                CiProductsBuildRunsGetToManyRelatedSortItem.Minusnumber => "-number",
                CiProductsBuildRunsGetToManyRelatedSortItem.Number => "number",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiProductsBuildRunsGetToManyRelatedSortItem? ToEnum(string value)
        {
            return value switch
            {
                "-number" => CiProductsBuildRunsGetToManyRelatedSortItem.Minusnumber,
                "number" => CiProductsBuildRunsGetToManyRelatedSortItem.Number,
                _ => null,
            };
        }
    }
}