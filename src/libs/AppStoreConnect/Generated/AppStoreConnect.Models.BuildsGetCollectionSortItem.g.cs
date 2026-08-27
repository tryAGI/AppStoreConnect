
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BuildsGetCollectionSortItem
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
    public static class BuildsGetCollectionSortItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildsGetCollectionSortItem value)
        {
            return value switch
            {
                BuildsGetCollectionSortItem.MinuspreReleaseVersion => "-preReleaseVersion",
                BuildsGetCollectionSortItem.MinusuploadedDate => "-uploadedDate",
                BuildsGetCollectionSortItem.Minusversion => "-version",
                BuildsGetCollectionSortItem.PreReleaseVersion => "preReleaseVersion",
                BuildsGetCollectionSortItem.UploadedDate => "uploadedDate",
                BuildsGetCollectionSortItem.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildsGetCollectionSortItem? ToEnum(string value)
        {
            return value switch
            {
                "-preReleaseVersion" => BuildsGetCollectionSortItem.MinuspreReleaseVersion,
                "-uploadedDate" => BuildsGetCollectionSortItem.MinusuploadedDate,
                "-version" => BuildsGetCollectionSortItem.Minusversion,
                "preReleaseVersion" => BuildsGetCollectionSortItem.PreReleaseVersion,
                "uploadedDate" => BuildsGetCollectionSortItem.UploadedDate,
                "version" => BuildsGetCollectionSortItem.Version,
                _ => null,
            };
        }
    }
}