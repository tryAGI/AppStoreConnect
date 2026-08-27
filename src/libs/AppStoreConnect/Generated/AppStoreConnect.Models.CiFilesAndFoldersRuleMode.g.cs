
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CiFilesAndFoldersRuleMode
    {
        /// <summary>
        ///
        /// </summary>
        DoNotStartIfAllFilesMatch,
        /// <summary>
        ///
        /// </summary>
        StartIfAnyFileMatches,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CiFilesAndFoldersRuleModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiFilesAndFoldersRuleMode value)
        {
            return value switch
            {
                CiFilesAndFoldersRuleMode.DoNotStartIfAllFilesMatch => "DO_NOT_START_IF_ALL_FILES_MATCH",
                CiFilesAndFoldersRuleMode.StartIfAnyFileMatches => "START_IF_ANY_FILE_MATCHES",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiFilesAndFoldersRuleMode? ToEnum(string value)
        {
            return value switch
            {
                "DO_NOT_START_IF_ALL_FILES_MATCH" => CiFilesAndFoldersRuleMode.DoNotStartIfAllFilesMatch,
                "START_IF_ANY_FILE_MATCHES" => CiFilesAndFoldersRuleMode.StartIfAnyFileMatches,
                _ => null,
            };
        }
    }
}