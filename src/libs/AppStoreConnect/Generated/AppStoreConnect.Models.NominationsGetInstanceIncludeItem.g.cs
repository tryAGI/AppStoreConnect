
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum NominationsGetInstanceIncludeItem
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
    public static class NominationsGetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NominationsGetInstanceIncludeItem value)
        {
            return value switch
            {
                NominationsGetInstanceIncludeItem.CreatedByActor => "createdByActor",
                NominationsGetInstanceIncludeItem.InAppEvents => "inAppEvents",
                NominationsGetInstanceIncludeItem.LastModifiedByActor => "lastModifiedByActor",
                NominationsGetInstanceIncludeItem.RelatedApps => "relatedApps",
                NominationsGetInstanceIncludeItem.SubmittedByActor => "submittedByActor",
                NominationsGetInstanceIncludeItem.SupportedTerritories => "supportedTerritories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NominationsGetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "createdByActor" => NominationsGetInstanceIncludeItem.CreatedByActor,
                "inAppEvents" => NominationsGetInstanceIncludeItem.InAppEvents,
                "lastModifiedByActor" => NominationsGetInstanceIncludeItem.LastModifiedByActor,
                "relatedApps" => NominationsGetInstanceIncludeItem.RelatedApps,
                "submittedByActor" => NominationsGetInstanceIncludeItem.SubmittedByActor,
                "supportedTerritories" => NominationsGetInstanceIncludeItem.SupportedTerritories,
                _ => null,
            };
        }
    }
}