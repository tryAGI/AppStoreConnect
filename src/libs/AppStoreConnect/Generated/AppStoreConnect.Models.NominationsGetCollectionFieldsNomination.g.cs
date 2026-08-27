
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum NominationsGetCollectionFieldsNomination
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
    public static class NominationsGetCollectionFieldsNominationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NominationsGetCollectionFieldsNomination value)
        {
            return value switch
            {
                NominationsGetCollectionFieldsNomination.CreatedByActor => "createdByActor",
                NominationsGetCollectionFieldsNomination.CreatedDate => "createdDate",
                NominationsGetCollectionFieldsNomination.Description => "description",
                NominationsGetCollectionFieldsNomination.DeviceFamilies => "deviceFamilies",
                NominationsGetCollectionFieldsNomination.HasInAppEvents => "hasInAppEvents",
                NominationsGetCollectionFieldsNomination.InAppEvents => "inAppEvents",
                NominationsGetCollectionFieldsNomination.LastModifiedByActor => "lastModifiedByActor",
                NominationsGetCollectionFieldsNomination.LastModifiedDate => "lastModifiedDate",
                NominationsGetCollectionFieldsNomination.LaunchInSelectMarketsFirst => "launchInSelectMarketsFirst",
                NominationsGetCollectionFieldsNomination.Locales => "locales",
                NominationsGetCollectionFieldsNomination.Name => "name",
                NominationsGetCollectionFieldsNomination.Notes => "notes",
                NominationsGetCollectionFieldsNomination.PreOrderEnabled => "preOrderEnabled",
                NominationsGetCollectionFieldsNomination.PublishEndDate => "publishEndDate",
                NominationsGetCollectionFieldsNomination.PublishStartDate => "publishStartDate",
                NominationsGetCollectionFieldsNomination.RelatedApps => "relatedApps",
                NominationsGetCollectionFieldsNomination.State => "state",
                NominationsGetCollectionFieldsNomination.SubmittedByActor => "submittedByActor",
                NominationsGetCollectionFieldsNomination.SubmittedDate => "submittedDate",
                NominationsGetCollectionFieldsNomination.SupplementalMaterialsUris => "supplementalMaterialsUris",
                NominationsGetCollectionFieldsNomination.SupportedTerritories => "supportedTerritories",
                NominationsGetCollectionFieldsNomination.Type => "type",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NominationsGetCollectionFieldsNomination? ToEnum(string value)
        {
            return value switch
            {
                "createdByActor" => NominationsGetCollectionFieldsNomination.CreatedByActor,
                "createdDate" => NominationsGetCollectionFieldsNomination.CreatedDate,
                "description" => NominationsGetCollectionFieldsNomination.Description,
                "deviceFamilies" => NominationsGetCollectionFieldsNomination.DeviceFamilies,
                "hasInAppEvents" => NominationsGetCollectionFieldsNomination.HasInAppEvents,
                "inAppEvents" => NominationsGetCollectionFieldsNomination.InAppEvents,
                "lastModifiedByActor" => NominationsGetCollectionFieldsNomination.LastModifiedByActor,
                "lastModifiedDate" => NominationsGetCollectionFieldsNomination.LastModifiedDate,
                "launchInSelectMarketsFirst" => NominationsGetCollectionFieldsNomination.LaunchInSelectMarketsFirst,
                "locales" => NominationsGetCollectionFieldsNomination.Locales,
                "name" => NominationsGetCollectionFieldsNomination.Name,
                "notes" => NominationsGetCollectionFieldsNomination.Notes,
                "preOrderEnabled" => NominationsGetCollectionFieldsNomination.PreOrderEnabled,
                "publishEndDate" => NominationsGetCollectionFieldsNomination.PublishEndDate,
                "publishStartDate" => NominationsGetCollectionFieldsNomination.PublishStartDate,
                "relatedApps" => NominationsGetCollectionFieldsNomination.RelatedApps,
                "state" => NominationsGetCollectionFieldsNomination.State,
                "submittedByActor" => NominationsGetCollectionFieldsNomination.SubmittedByActor,
                "submittedDate" => NominationsGetCollectionFieldsNomination.SubmittedDate,
                "supplementalMaterialsUris" => NominationsGetCollectionFieldsNomination.SupplementalMaterialsUris,
                "supportedTerritories" => NominationsGetCollectionFieldsNomination.SupportedTerritories,
                "type" => NominationsGetCollectionFieldsNomination.Type,
                _ => null,
            };
        }
    }
}