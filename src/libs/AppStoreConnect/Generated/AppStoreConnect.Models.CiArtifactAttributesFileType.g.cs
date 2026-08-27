
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum CiArtifactAttributesFileType
    {
        /// <summary>
        /// 
        /// </summary>
        Archive,
        /// <summary>
        /// 
        /// </summary>
        ArchiveExport,
        /// <summary>
        /// 
        /// </summary>
        LogBundle,
        /// <summary>
        /// 
        /// </summary>
        ResultBundle,
        /// <summary>
        /// 
        /// </summary>
        StapledNotarizedArchive,
        /// <summary>
        /// 
        /// </summary>
        TestProducts,
        /// <summary>
        /// 
        /// </summary>
        XcodebuildProducts,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CiArtifactAttributesFileTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiArtifactAttributesFileType value)
        {
            return value switch
            {
                CiArtifactAttributesFileType.Archive => "ARCHIVE",
                CiArtifactAttributesFileType.ArchiveExport => "ARCHIVE_EXPORT",
                CiArtifactAttributesFileType.LogBundle => "LOG_BUNDLE",
                CiArtifactAttributesFileType.ResultBundle => "RESULT_BUNDLE",
                CiArtifactAttributesFileType.StapledNotarizedArchive => "STAPLED_NOTARIZED_ARCHIVE",
                CiArtifactAttributesFileType.TestProducts => "TEST_PRODUCTS",
                CiArtifactAttributesFileType.XcodebuildProducts => "XCODEBUILD_PRODUCTS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiArtifactAttributesFileType? ToEnum(string value)
        {
            return value switch
            {
                "ARCHIVE" => CiArtifactAttributesFileType.Archive,
                "ARCHIVE_EXPORT" => CiArtifactAttributesFileType.ArchiveExport,
                "LOG_BUNDLE" => CiArtifactAttributesFileType.LogBundle,
                "RESULT_BUNDLE" => CiArtifactAttributesFileType.ResultBundle,
                "STAPLED_NOTARIZED_ARCHIVE" => CiArtifactAttributesFileType.StapledNotarizedArchive,
                "TEST_PRODUCTS" => CiArtifactAttributesFileType.TestProducts,
                "XCODEBUILD_PRODUCTS" => CiArtifactAttributesFileType.XcodebuildProducts,
                _ => null,
            };
        }
    }
}