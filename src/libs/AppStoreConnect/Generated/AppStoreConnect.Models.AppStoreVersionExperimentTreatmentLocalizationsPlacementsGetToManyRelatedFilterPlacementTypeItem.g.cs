
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFilterPlacementTypeItem
    {
        /// <summary>
        ///
        /// </summary>
        AppPreview,
        /// <summary>
        ///
        /// </summary>
        AppScreenshot,
        /// <summary>
        ///
        /// </summary>
        AppStoreSearchResultsAsset,
        /// <summary>
        ///
        /// </summary>
        EventCardAsset,
        /// <summary>
        ///
        /// </summary>
        EventDetailsPageAsset,
        /// <summary>
        ///
        /// </summary>
        ImessageAppScreenshot,
        /// <summary>
        ///
        /// </summary>
        ProductPageHeaderAsset,
        /// <summary>
        ///
        /// </summary>
        RetentionMessageAsset,
        /// <summary>
        ///
        /// </summary>
        SearchResultsAdsAsset,
        /// <summary>
        ///
        /// </summary>
        TodayTabAdsAsset,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFilterPlacementTypeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFilterPlacementTypeItem value)
        {
            return value switch
            {
                AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFilterPlacementTypeItem.AppPreview => "APP_PREVIEW",
                AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFilterPlacementTypeItem.AppScreenshot => "APP_SCREENSHOT",
                AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFilterPlacementTypeItem.AppStoreSearchResultsAsset => "APP_STORE_SEARCH_RESULTS_ASSET",
                AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFilterPlacementTypeItem.EventCardAsset => "EVENT_CARD_ASSET",
                AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFilterPlacementTypeItem.EventDetailsPageAsset => "EVENT_DETAILS_PAGE_ASSET",
                AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFilterPlacementTypeItem.ImessageAppScreenshot => "IMESSAGE_APP_SCREENSHOT",
                AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFilterPlacementTypeItem.ProductPageHeaderAsset => "PRODUCT_PAGE_HEADER_ASSET",
                AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFilterPlacementTypeItem.RetentionMessageAsset => "RETENTION_MESSAGE_ASSET",
                AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFilterPlacementTypeItem.SearchResultsAdsAsset => "SEARCH_RESULTS_ADS_ASSET",
                AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFilterPlacementTypeItem.TodayTabAdsAsset => "TODAY_TAB_ADS_ASSET",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFilterPlacementTypeItem? ToEnum(string value)
        {
            return value switch
            {
                "APP_PREVIEW" => AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFilterPlacementTypeItem.AppPreview,
                "APP_SCREENSHOT" => AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFilterPlacementTypeItem.AppScreenshot,
                "APP_STORE_SEARCH_RESULTS_ASSET" => AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFilterPlacementTypeItem.AppStoreSearchResultsAsset,
                "EVENT_CARD_ASSET" => AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFilterPlacementTypeItem.EventCardAsset,
                "EVENT_DETAILS_PAGE_ASSET" => AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFilterPlacementTypeItem.EventDetailsPageAsset,
                "IMESSAGE_APP_SCREENSHOT" => AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFilterPlacementTypeItem.ImessageAppScreenshot,
                "PRODUCT_PAGE_HEADER_ASSET" => AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFilterPlacementTypeItem.ProductPageHeaderAsset,
                "RETENTION_MESSAGE_ASSET" => AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFilterPlacementTypeItem.RetentionMessageAsset,
                "SEARCH_RESULTS_ADS_ASSET" => AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFilterPlacementTypeItem.SearchResultsAdsAsset,
                "TODAY_TAB_ADS_ASSET" => AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFilterPlacementTypeItem.TodayTabAdsAsset,
                _ => null,
            };
        }
    }
}