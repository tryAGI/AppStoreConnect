
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppsBuildUploadsGetToManyRelatedSortItem
    {
        /// <summary>
        ///
        /// </summary>
        MinuscfBundleVersion,
        /// <summary>
        ///
        /// </summary>
        MinusuploadedDate,
        /// <summary>
        ///
        /// </summary>
        CfBundleVersion,
        /// <summary>
        ///
        /// </summary>
        UploadedDate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppsBuildUploadsGetToManyRelatedSortItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsBuildUploadsGetToManyRelatedSortItem value)
        {
            return value switch
            {
                AppsBuildUploadsGetToManyRelatedSortItem.MinuscfBundleVersion => "-cfBundleVersion",
                AppsBuildUploadsGetToManyRelatedSortItem.MinusuploadedDate => "-uploadedDate",
                AppsBuildUploadsGetToManyRelatedSortItem.CfBundleVersion => "cfBundleVersion",
                AppsBuildUploadsGetToManyRelatedSortItem.UploadedDate => "uploadedDate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsBuildUploadsGetToManyRelatedSortItem? ToEnum(string value)
        {
            return value switch
            {
                "-cfBundleVersion" => AppsBuildUploadsGetToManyRelatedSortItem.MinuscfBundleVersion,
                "-uploadedDate" => AppsBuildUploadsGetToManyRelatedSortItem.MinusuploadedDate,
                "cfBundleVersion" => AppsBuildUploadsGetToManyRelatedSortItem.CfBundleVersion,
                "uploadedDate" => AppsBuildUploadsGetToManyRelatedSortItem.UploadedDate,
                _ => null,
            };
        }
    }
}