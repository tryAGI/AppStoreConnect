
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum CiBuildRunsBuildsGetToManyRelatedSortItem
    {
        /// <summary>
        /// 
        /// </summary>
        MinuspreReleaseVersion,
        /// <summary>
        /// 
        /// </summary>
        MinusuploadedDate,
        /// <summary>
        /// 
        /// </summary>
        Minusversion,
        /// <summary>
        /// 
        /// </summary>
        PreReleaseVersion,
        /// <summary>
        /// 
        /// </summary>
        UploadedDate,
        /// <summary>
        /// 
        /// </summary>
        Version,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CiBuildRunsBuildsGetToManyRelatedSortItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiBuildRunsBuildsGetToManyRelatedSortItem value)
        {
            return value switch
            {
                CiBuildRunsBuildsGetToManyRelatedSortItem.MinuspreReleaseVersion => "-preReleaseVersion",
                CiBuildRunsBuildsGetToManyRelatedSortItem.MinusuploadedDate => "-uploadedDate",
                CiBuildRunsBuildsGetToManyRelatedSortItem.Minusversion => "-version",
                CiBuildRunsBuildsGetToManyRelatedSortItem.PreReleaseVersion => "preReleaseVersion",
                CiBuildRunsBuildsGetToManyRelatedSortItem.UploadedDate => "uploadedDate",
                CiBuildRunsBuildsGetToManyRelatedSortItem.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiBuildRunsBuildsGetToManyRelatedSortItem? ToEnum(string value)
        {
            return value switch
            {
                "-preReleaseVersion" => CiBuildRunsBuildsGetToManyRelatedSortItem.MinuspreReleaseVersion,
                "-uploadedDate" => CiBuildRunsBuildsGetToManyRelatedSortItem.MinusuploadedDate,
                "-version" => CiBuildRunsBuildsGetToManyRelatedSortItem.Minusversion,
                "preReleaseVersion" => CiBuildRunsBuildsGetToManyRelatedSortItem.PreReleaseVersion,
                "uploadedDate" => CiBuildRunsBuildsGetToManyRelatedSortItem.UploadedDate,
                "version" => CiBuildRunsBuildsGetToManyRelatedSortItem.Version,
                _ => null,
            };
        }
    }
}