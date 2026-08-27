
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum CiBuildActionsTestResultsGetToManyRelatedFieldsCiTestResult
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
    public static class CiBuildActionsTestResultsGetToManyRelatedFieldsCiTestResultExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiBuildActionsTestResultsGetToManyRelatedFieldsCiTestResult value)
        {
            return value switch
            {
                CiBuildActionsTestResultsGetToManyRelatedFieldsCiTestResult.ClassName => "className",
                CiBuildActionsTestResultsGetToManyRelatedFieldsCiTestResult.DestinationTestResults => "destinationTestResults",
                CiBuildActionsTestResultsGetToManyRelatedFieldsCiTestResult.FileSource => "fileSource",
                CiBuildActionsTestResultsGetToManyRelatedFieldsCiTestResult.Message => "message",
                CiBuildActionsTestResultsGetToManyRelatedFieldsCiTestResult.Name => "name",
                CiBuildActionsTestResultsGetToManyRelatedFieldsCiTestResult.Status => "status",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiBuildActionsTestResultsGetToManyRelatedFieldsCiTestResult? ToEnum(string value)
        {
            return value switch
            {
                "className" => CiBuildActionsTestResultsGetToManyRelatedFieldsCiTestResult.ClassName,
                "destinationTestResults" => CiBuildActionsTestResultsGetToManyRelatedFieldsCiTestResult.DestinationTestResults,
                "fileSource" => CiBuildActionsTestResultsGetToManyRelatedFieldsCiTestResult.FileSource,
                "message" => CiBuildActionsTestResultsGetToManyRelatedFieldsCiTestResult.Message,
                "name" => CiBuildActionsTestResultsGetToManyRelatedFieldsCiTestResult.Name,
                "status" => CiBuildActionsTestResultsGetToManyRelatedFieldsCiTestResult.Status,
                _ => null,
            };
        }
    }
}