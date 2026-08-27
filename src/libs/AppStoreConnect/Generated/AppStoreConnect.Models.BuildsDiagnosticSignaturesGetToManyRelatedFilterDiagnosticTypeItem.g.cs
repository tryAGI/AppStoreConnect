
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BuildsDiagnosticSignaturesGetToManyRelatedFilterDiagnosticTypeItem
    {
        /// <summary>
        ///
        /// </summary>
        DiskWrites,
        /// <summary>
        ///
        /// </summary>
        Hangs,
        /// <summary>
        ///
        /// </summary>
        Launches,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BuildsDiagnosticSignaturesGetToManyRelatedFilterDiagnosticTypeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildsDiagnosticSignaturesGetToManyRelatedFilterDiagnosticTypeItem value)
        {
            return value switch
            {
                BuildsDiagnosticSignaturesGetToManyRelatedFilterDiagnosticTypeItem.DiskWrites => "DISK_WRITES",
                BuildsDiagnosticSignaturesGetToManyRelatedFilterDiagnosticTypeItem.Hangs => "HANGS",
                BuildsDiagnosticSignaturesGetToManyRelatedFilterDiagnosticTypeItem.Launches => "LAUNCHES",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildsDiagnosticSignaturesGetToManyRelatedFilterDiagnosticTypeItem? ToEnum(string value)
        {
            return value switch
            {
                "DISK_WRITES" => BuildsDiagnosticSignaturesGetToManyRelatedFilterDiagnosticTypeItem.DiskWrites,
                "HANGS" => BuildsDiagnosticSignaturesGetToManyRelatedFilterDiagnosticTypeItem.Hangs,
                "LAUNCHES" => BuildsDiagnosticSignaturesGetToManyRelatedFilterDiagnosticTypeItem.Launches,
                _ => null,
            };
        }
    }
}