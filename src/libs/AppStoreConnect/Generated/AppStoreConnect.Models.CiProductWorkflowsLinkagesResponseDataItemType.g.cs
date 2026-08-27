
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum CiProductWorkflowsLinkagesResponseDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        CiWorkflows,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CiProductWorkflowsLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiProductWorkflowsLinkagesResponseDataItemType value)
        {
            return value switch
            {
                CiProductWorkflowsLinkagesResponseDataItemType.CiWorkflows => "ciWorkflows",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiProductWorkflowsLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "ciWorkflows" => CiProductWorkflowsLinkagesResponseDataItemType.CiWorkflows,
                _ => null,
            };
        }
    }
}