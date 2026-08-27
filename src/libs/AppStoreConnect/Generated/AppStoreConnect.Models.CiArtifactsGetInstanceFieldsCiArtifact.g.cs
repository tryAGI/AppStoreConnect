
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum CiArtifactsGetInstanceFieldsCiArtifact
    {
        /// <summary>
        /// 
        /// </summary>
        DownloadUrl,
        /// <summary>
        /// 
        /// </summary>
        FileName,
        /// <summary>
        /// 
        /// </summary>
        FileSize,
        /// <summary>
        /// 
        /// </summary>
        FileType,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CiArtifactsGetInstanceFieldsCiArtifactExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiArtifactsGetInstanceFieldsCiArtifact value)
        {
            return value switch
            {
                CiArtifactsGetInstanceFieldsCiArtifact.DownloadUrl => "downloadUrl",
                CiArtifactsGetInstanceFieldsCiArtifact.FileName => "fileName",
                CiArtifactsGetInstanceFieldsCiArtifact.FileSize => "fileSize",
                CiArtifactsGetInstanceFieldsCiArtifact.FileType => "fileType",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiArtifactsGetInstanceFieldsCiArtifact? ToEnum(string value)
        {
            return value switch
            {
                "downloadUrl" => CiArtifactsGetInstanceFieldsCiArtifact.DownloadUrl,
                "fileName" => CiArtifactsGetInstanceFieldsCiArtifact.FileName,
                "fileSize" => CiArtifactsGetInstanceFieldsCiArtifact.FileSize,
                "fileType" => CiArtifactsGetInstanceFieldsCiArtifact.FileType,
                _ => null,
            };
        }
    }
}