
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum CiBuildActionTestResultsLinkagesResponseDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        CiTestResults,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CiBuildActionTestResultsLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiBuildActionTestResultsLinkagesResponseDataItemType value)
        {
            return value switch
            {
                CiBuildActionTestResultsLinkagesResponseDataItemType.CiTestResults => "ciTestResults",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiBuildActionTestResultsLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "ciTestResults" => CiBuildActionTestResultsLinkagesResponseDataItemType.CiTestResults,
                _ => null,
            };
        }
    }
}