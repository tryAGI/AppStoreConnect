
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum NominationsGetCollectionIncludeItem
    {
        /// <summary>
        /// 
        /// </summary>
        CreatedByActor,
        /// <summary>
        /// 
        /// </summary>
        InAppEvents,
        /// <summary>
        /// 
        /// </summary>
        LastModifiedByActor,
        /// <summary>
        /// 
        /// </summary>
        RelatedApps,
        /// <summary>
        /// 
        /// </summary>
        SubmittedByActor,
        /// <summary>
        /// 
        /// </summary>
        SupportedTerritories,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NominationsGetCollectionIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NominationsGetCollectionIncludeItem value)
        {
            return value switch
            {
                NominationsGetCollectionIncludeItem.CreatedByActor => "createdByActor",
                NominationsGetCollectionIncludeItem.InAppEvents => "inAppEvents",
                NominationsGetCollectionIncludeItem.LastModifiedByActor => "lastModifiedByActor",
                NominationsGetCollectionIncludeItem.RelatedApps => "relatedApps",
                NominationsGetCollectionIncludeItem.SubmittedByActor => "submittedByActor",
                NominationsGetCollectionIncludeItem.SupportedTerritories => "supportedTerritories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NominationsGetCollectionIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "createdByActor" => NominationsGetCollectionIncludeItem.CreatedByActor,
                "inAppEvents" => NominationsGetCollectionIncludeItem.InAppEvents,
                "lastModifiedByActor" => NominationsGetCollectionIncludeItem.LastModifiedByActor,
                "relatedApps" => NominationsGetCollectionIncludeItem.RelatedApps,
                "submittedByActor" => NominationsGetCollectionIncludeItem.SubmittedByActor,
                "supportedTerritories" => NominationsGetCollectionIncludeItem.SupportedTerritories,
                _ => null,
            };
        }
    }
}