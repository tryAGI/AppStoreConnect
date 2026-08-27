
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CiTestResultType
    {
        /// <summary>
        ///
        /// </summary>
        CiTestResults,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CiTestResultTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiTestResultType value)
        {
            return value switch
            {
                CiTestResultType.CiTestResults => "ciTestResults",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiTestResultType? ToEnum(string value)
        {
            return value switch
            {
                "ciTestResults" => CiTestResultType.CiTestResults,
                _ => null,
            };
        }
    }
}