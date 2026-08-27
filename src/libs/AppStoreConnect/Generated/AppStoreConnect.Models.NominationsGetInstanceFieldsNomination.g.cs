
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum NominationsGetInstanceFieldsNomination
    {
        /// <summary>
        /// 
        /// </summary>
        CreatedByActor,
        /// <summary>
        /// 
        /// </summary>
        CreatedDate,
        /// <summary>
        /// 
        /// </summary>
        Description,
        /// <summary>
        /// 
        /// </summary>
        DeviceFamilies,
        /// <summary>
        /// 
        /// </summary>
        HasInAppEvents,
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
        LastModifiedDate,
        /// <summary>
        /// 
        /// </summary>
        LaunchInSelectMarketsFirst,
        /// <summary>
        /// 
        /// </summary>
        Locales,
        /// <summary>
        /// 
        /// </summary>
        Name,
        /// <summary>
        /// 
        /// </summary>
        Notes,
        /// <summary>
        /// 
        /// </summary>
        PreOrderEnabled,
        /// <summary>
        /// 
        /// </summary>
        PublishEndDate,
        /// <summary>
        /// 
        /// </summary>
        PublishStartDate,
        /// <summary>
        /// 
        /// </summary>
        RelatedApps,
        /// <summary>
        /// 
        /// </summary>
        State,
        /// <summary>
        /// 
        /// </summary>
        SubmittedByActor,
        /// <summary>
        /// 
        /// </summary>
        SubmittedDate,
        /// <summary>
        /// 
        /// </summary>
        SupplementalMaterialsUris,
        /// <summary>
        /// 
        /// </summary>
        SupportedTerritories,
        /// <summary>
        /// 
        /// </summary>
        Type,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NominationsGetInstanceFieldsNominationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NominationsGetInstanceFieldsNomination value)
        {
            return value switch
            {
                NominationsGetInstanceFieldsNomination.CreatedByActor => "createdByActor",
                NominationsGetInstanceFieldsNomination.CreatedDate => "createdDate",
                NominationsGetInstanceFieldsNomination.Description => "description",
                NominationsGetInstanceFieldsNomination.DeviceFamilies => "deviceFamilies",
                NominationsGetInstanceFieldsNomination.HasInAppEvents => "hasInAppEvents",
                NominationsGetInstanceFieldsNomination.InAppEvents => "inAppEvents",
                NominationsGetInstanceFieldsNomination.LastModifiedByActor => "lastModifiedByActor",
                NominationsGetInstanceFieldsNomination.LastModifiedDate => "lastModifiedDate",
                NominationsGetInstanceFieldsNomination.LaunchInSelectMarketsFirst => "launchInSelectMarketsFirst",
                NominationsGetInstanceFieldsNomination.Locales => "locales",
                NominationsGetInstanceFieldsNomination.Name => "name",
                NominationsGetInstanceFieldsNomination.Notes => "notes",
                NominationsGetInstanceFieldsNomination.PreOrderEnabled => "preOrderEnabled",
                NominationsGetInstanceFieldsNomination.PublishEndDate => "publishEndDate",
                NominationsGetInstanceFieldsNomination.PublishStartDate => "publishStartDate",
                NominationsGetInstanceFieldsNomination.RelatedApps => "relatedApps",
                NominationsGetInstanceFieldsNomination.State => "state",
                NominationsGetInstanceFieldsNomination.SubmittedByActor => "submittedByActor",
                NominationsGetInstanceFieldsNomination.SubmittedDate => "submittedDate",
                NominationsGetInstanceFieldsNomination.SupplementalMaterialsUris => "supplementalMaterialsUris",
                NominationsGetInstanceFieldsNomination.SupportedTerritories => "supportedTerritories",
                NominationsGetInstanceFieldsNomination.Type => "type",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NominationsGetInstanceFieldsNomination? ToEnum(string value)
        {
            return value switch
            {
                "createdByActor" => NominationsGetInstanceFieldsNomination.CreatedByActor,
                "createdDate" => NominationsGetInstanceFieldsNomination.CreatedDate,
                "description" => NominationsGetInstanceFieldsNomination.Description,
                "deviceFamilies" => NominationsGetInstanceFieldsNomination.DeviceFamilies,
                "hasInAppEvents" => NominationsGetInstanceFieldsNomination.HasInAppEvents,
                "inAppEvents" => NominationsGetInstanceFieldsNomination.InAppEvents,
                "lastModifiedByActor" => NominationsGetInstanceFieldsNomination.LastModifiedByActor,
                "lastModifiedDate" => NominationsGetInstanceFieldsNomination.LastModifiedDate,
                "launchInSelectMarketsFirst" => NominationsGetInstanceFieldsNomination.LaunchInSelectMarketsFirst,
                "locales" => NominationsGetInstanceFieldsNomination.Locales,
                "name" => NominationsGetInstanceFieldsNomination.Name,
                "notes" => NominationsGetInstanceFieldsNomination.Notes,
                "preOrderEnabled" => NominationsGetInstanceFieldsNomination.PreOrderEnabled,
                "publishEndDate" => NominationsGetInstanceFieldsNomination.PublishEndDate,
                "publishStartDate" => NominationsGetInstanceFieldsNomination.PublishStartDate,
                "relatedApps" => NominationsGetInstanceFieldsNomination.RelatedApps,
                "state" => NominationsGetInstanceFieldsNomination.State,
                "submittedByActor" => NominationsGetInstanceFieldsNomination.SubmittedByActor,
                "submittedDate" => NominationsGetInstanceFieldsNomination.SubmittedDate,
                "supplementalMaterialsUris" => NominationsGetInstanceFieldsNomination.SupplementalMaterialsUris,
                "supportedTerritories" => NominationsGetInstanceFieldsNomination.SupportedTerritories,
                "type" => NominationsGetInstanceFieldsNomination.Type,
                _ => null,
            };
        }
    }
}