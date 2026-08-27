
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CiTestResultsGetInstanceFieldsCiTestResult
    {
        /// <summary>
        ///
        /// </summary>
        ClassName,
        /// <summary>
        ///
        /// </summary>
        DestinationTestResults,
        /// <summary>
        ///
        /// </summary>
        FileSource,
        /// <summary>
        ///
        /// </summary>
        Message,
        /// <summary>
        ///
        /// </summary>
        Name,
        /// <summary>
        ///
        /// </summary>
        Status,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CiTestResultsGetInstanceFieldsCiTestResultExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiTestResultsGetInstanceFieldsCiTestResult value)
        {
            return value switch
            {
                CiTestResultsGetInstanceFieldsCiTestResult.ClassName => "className",
                CiTestResultsGetInstanceFieldsCiTestResult.DestinationTestResults => "destinationTestResults",
                CiTestResultsGetInstanceFieldsCiTestResult.FileSource => "fileSource",
                CiTestResultsGetInstanceFieldsCiTestResult.Message => "message",
                CiTestResultsGetInstanceFieldsCiTestResult.Name => "name",
                CiTestResultsGetInstanceFieldsCiTestResult.Status => "status",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiTestResultsGetInstanceFieldsCiTestResult? ToEnum(string value)
        {
            return value switch
            {
                "className" => CiTestResultsGetInstanceFieldsCiTestResult.ClassName,
                "destinationTestResults" => CiTestResultsGetInstanceFieldsCiTestResult.DestinationTestResults,
                "fileSource" => CiTestResultsGetInstanceFieldsCiTestResult.FileSource,
                "message" => CiTestResultsGetInstanceFieldsCiTestResult.Message,
                "name" => CiTestResultsGetInstanceFieldsCiTestResult.Name,
                "status" => CiTestResultsGetInstanceFieldsCiTestResult.Status,
                _ => null,
            };
        }
    }
}