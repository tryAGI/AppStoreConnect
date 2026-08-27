
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CiActionType
    {
        /// <summary>
        ///
        /// </summary>
        Analyze,
        /// <summary>
        ///
        /// </summary>
        Archive,
        /// <summary>
        ///
        /// </summary>
        Build,
        /// <summary>
        ///
        /// </summary>
        Test,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CiActionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiActionType value)
        {
            return value switch
            {
                CiActionType.Analyze => "ANALYZE",
                CiActionType.Archive => "ARCHIVE",
                CiActionType.Build => "BUILD",
                CiActionType.Test => "TEST",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiActionType? ToEnum(string value)
        {
            return value switch
            {
                "ANALYZE" => CiActionType.Analyze,
                "ARCHIVE" => CiActionType.Archive,
                "BUILD" => CiActionType.Build,
                "TEST" => CiActionType.Test,
                _ => null,
            };
        }
    }
}