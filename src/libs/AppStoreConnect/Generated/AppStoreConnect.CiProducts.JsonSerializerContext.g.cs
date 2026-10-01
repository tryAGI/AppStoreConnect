
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull
    )]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsResponseIncludedItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsResponseIncludedItemDiscriminatorType), TypeInfoPropertyName = "CiProductsResponseIncludedItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiWorkflowsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiWorkflowsResponseIncludedItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiWorkflowsResponseIncludedItemDiscriminatorType), TypeInfoPropertyName = "CiWorkflowsResponseIncludedItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductAdditionalRepositoriesLinkagesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductAdditionalRepositoriesLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductAdditionalRepositoriesLinkagesResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductAdditionalRepositoriesLinkagesResponseDataItemType), TypeInfoPropertyName = "CiProductAdditionalRepositoriesLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductAppLinkageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductAppLinkageResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductAppLinkageResponseDataType), TypeInfoPropertyName = "CiProductAppLinkageResponseDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductBuildRunsLinkagesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductBuildRunsLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductBuildRunsLinkagesResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductBuildRunsLinkagesResponseDataItemType), TypeInfoPropertyName = "CiProductBuildRunsLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductPrimaryRepositoriesLinkagesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductPrimaryRepositoriesLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductPrimaryRepositoriesLinkagesResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductPrimaryRepositoriesLinkagesResponseDataItemType), TypeInfoPropertyName = "CiProductPrimaryRepositoriesLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductWorkflowsLinkagesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductWorkflowsLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductWorkflowsLinkagesResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductWorkflowsLinkagesResponseDataItemType), TypeInfoPropertyName = "CiProductWorkflowsLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsGetCollectionFilterProductTypeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsGetCollectionFilterProductTypeItem), TypeInfoPropertyName = "CiProductsGetCollectionFilterProductTypeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsGetCollectionFieldsCiProduct>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsGetCollectionFieldsCiProduct), TypeInfoPropertyName = "CiProductsGetCollectionFieldsCiProduct2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsGetCollectionFieldsApp>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsGetCollectionFieldsApp), TypeInfoPropertyName = "CiProductsGetCollectionFieldsApp2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsGetCollectionFieldsBundleId>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsGetCollectionFieldsBundleId), TypeInfoPropertyName = "CiProductsGetCollectionFieldsBundleId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsGetCollectionFieldsScmRepositorie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsGetCollectionFieldsScmRepositorie), TypeInfoPropertyName = "CiProductsGetCollectionFieldsScmRepositorie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsGetCollectionIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsGetCollectionIncludeItem), TypeInfoPropertyName = "CiProductsGetCollectionIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsGetInstanceFieldsCiProduct>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsGetInstanceFieldsCiProduct), TypeInfoPropertyName = "CiProductsGetInstanceFieldsCiProduct2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsGetInstanceFieldsApp>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsGetInstanceFieldsApp), TypeInfoPropertyName = "CiProductsGetInstanceFieldsApp2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsGetInstanceFieldsBundleId>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsGetInstanceFieldsBundleId), TypeInfoPropertyName = "CiProductsGetInstanceFieldsBundleId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsGetInstanceFieldsScmRepositorie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsGetInstanceFieldsScmRepositorie), TypeInfoPropertyName = "CiProductsGetInstanceFieldsScmRepositorie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsGetInstanceIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsGetInstanceIncludeItem), TypeInfoPropertyName = "CiProductsGetInstanceIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAdditionalRepositoriesGetToManyRelatedFieldsScmRepositorie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsAdditionalRepositoriesGetToManyRelatedFieldsScmRepositorie), TypeInfoPropertyName = "CiProductsAdditionalRepositoriesGetToManyRelatedFieldsScmRepositorie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAdditionalRepositoriesGetToManyRelatedFieldsScmProvider>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsAdditionalRepositoriesGetToManyRelatedFieldsScmProvider), TypeInfoPropertyName = "CiProductsAdditionalRepositoriesGetToManyRelatedFieldsScmProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAdditionalRepositoriesGetToManyRelatedFieldsScmGitReference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsAdditionalRepositoriesGetToManyRelatedFieldsScmGitReference), TypeInfoPropertyName = "CiProductsAdditionalRepositoriesGetToManyRelatedFieldsScmGitReference2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAdditionalRepositoriesGetToManyRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsAdditionalRepositoriesGetToManyRelatedIncludeItem), TypeInfoPropertyName = "CiProductsAdditionalRepositoriesGetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsApp>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsApp), TypeInfoPropertyName = "CiProductsAppGetToOneRelatedFieldsApp2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppEncryptionDeclaration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppEncryptionDeclaration), TypeInfoPropertyName = "CiProductsAppGetToOneRelatedFieldsAppEncryptionDeclaration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBuildIcon>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBuildIcon), TypeInfoPropertyName = "CiProductsAppGetToOneRelatedFieldsBuildIcon2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsCiProduct>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsCiProduct), TypeInfoPropertyName = "CiProductsAppGetToOneRelatedFieldsCiProduct2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBetaGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBetaGroup), TypeInfoPropertyName = "CiProductsAppGetToOneRelatedFieldsBetaGroup2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppStoreVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppStoreVersion), TypeInfoPropertyName = "CiProductsAppGetToOneRelatedFieldsAppStoreVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsPreReleaseVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsPreReleaseVersion), TypeInfoPropertyName = "CiProductsAppGetToOneRelatedFieldsPreReleaseVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBetaAppLocalization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBetaAppLocalization), TypeInfoPropertyName = "CiProductsAppGetToOneRelatedFieldsBetaAppLocalization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBuild>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBuild), TypeInfoPropertyName = "CiProductsAppGetToOneRelatedFieldsBuild2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBetaLicenseAgreement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBetaLicenseAgreement), TypeInfoPropertyName = "CiProductsAppGetToOneRelatedFieldsBetaLicenseAgreement2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBetaAppReviewDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBetaAppReviewDetail), TypeInfoPropertyName = "CiProductsAppGetToOneRelatedFieldsBetaAppReviewDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppInfo), TypeInfoPropertyName = "CiProductsAppGetToOneRelatedFieldsAppInfo2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppClip>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppClip), TypeInfoPropertyName = "CiProductsAppGetToOneRelatedFieldsAppClip2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsEndUserLicenseAgreement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsEndUserLicenseAgreement), TypeInfoPropertyName = "CiProductsAppGetToOneRelatedFieldsEndUserLicenseAgreement2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsInAppPurchase>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsInAppPurchase), TypeInfoPropertyName = "CiProductsAppGetToOneRelatedFieldsInAppPurchase2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsSubscriptionGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsSubscriptionGroup), TypeInfoPropertyName = "CiProductsAppGetToOneRelatedFieldsSubscriptionGroup2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsGameCenterEnabledVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsGameCenterEnabledVersion), TypeInfoPropertyName = "CiProductsAppGetToOneRelatedFieldsGameCenterEnabledVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppCustomProductPage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppCustomProductPage), TypeInfoPropertyName = "CiProductsAppGetToOneRelatedFieldsAppCustomProductPage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsPromotedPurchase>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsPromotedPurchase), TypeInfoPropertyName = "CiProductsAppGetToOneRelatedFieldsPromotedPurchase2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppEvent), TypeInfoPropertyName = "CiProductsAppGetToOneRelatedFieldsAppEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsReviewSubmission>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsReviewSubmission), TypeInfoPropertyName = "CiProductsAppGetToOneRelatedFieldsReviewSubmission2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsSubscriptionGracePeriod>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsSubscriptionGracePeriod), TypeInfoPropertyName = "CiProductsAppGetToOneRelatedFieldsSubscriptionGracePeriod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsGameCenterDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsGameCenterDetail), TypeInfoPropertyName = "CiProductsAppGetToOneRelatedFieldsGameCenterDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppStoreVersionExperiment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppStoreVersionExperiment), TypeInfoPropertyName = "CiProductsAppGetToOneRelatedFieldsAppStoreVersionExperiment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAndroidToIosAppMappingDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAndroidToIosAppMappingDetail), TypeInfoPropertyName = "CiProductsAppGetToOneRelatedFieldsAndroidToIosAppMappingDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedIncludeItem), TypeInfoPropertyName = "CiProductsAppGetToOneRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedSortItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedSortItem), TypeInfoPropertyName = "CiProductsBuildRunsGetToManyRelatedSortItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsCiBuildRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsCiBuildRun), TypeInfoPropertyName = "CiProductsBuildRunsGetToManyRelatedFieldsCiBuildRun2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsBuild>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsBuild), TypeInfoPropertyName = "CiProductsBuildRunsGetToManyRelatedFieldsBuild2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsCiWorkflow>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsCiWorkflow), TypeInfoPropertyName = "CiProductsBuildRunsGetToManyRelatedFieldsCiWorkflow2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsCiProduct>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsCiProduct), TypeInfoPropertyName = "CiProductsBuildRunsGetToManyRelatedFieldsCiProduct2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsScmGitReference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsScmGitReference), TypeInfoPropertyName = "CiProductsBuildRunsGetToManyRelatedFieldsScmGitReference2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsScmPullRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsScmPullRequest), TypeInfoPropertyName = "CiProductsBuildRunsGetToManyRelatedFieldsScmPullRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedIncludeItem), TypeInfoPropertyName = "CiProductsBuildRunsGetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsPrimaryRepositoriesGetToManyRelatedFieldsScmRepositorie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsPrimaryRepositoriesGetToManyRelatedFieldsScmRepositorie), TypeInfoPropertyName = "CiProductsPrimaryRepositoriesGetToManyRelatedFieldsScmRepositorie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsPrimaryRepositoriesGetToManyRelatedFieldsScmProvider>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsPrimaryRepositoriesGetToManyRelatedFieldsScmProvider), TypeInfoPropertyName = "CiProductsPrimaryRepositoriesGetToManyRelatedFieldsScmProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsPrimaryRepositoriesGetToManyRelatedFieldsScmGitReference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsPrimaryRepositoriesGetToManyRelatedFieldsScmGitReference), TypeInfoPropertyName = "CiProductsPrimaryRepositoriesGetToManyRelatedFieldsScmGitReference2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsPrimaryRepositoriesGetToManyRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsPrimaryRepositoriesGetToManyRelatedIncludeItem), TypeInfoPropertyName = "CiProductsPrimaryRepositoriesGetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsWorkflowsGetToManyRelatedFieldsCiWorkflow>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsWorkflowsGetToManyRelatedFieldsCiWorkflow), TypeInfoPropertyName = "CiProductsWorkflowsGetToManyRelatedFieldsCiWorkflow2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsWorkflowsGetToManyRelatedFieldsCiProduct>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsWorkflowsGetToManyRelatedFieldsCiProduct), TypeInfoPropertyName = "CiProductsWorkflowsGetToManyRelatedFieldsCiProduct2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsWorkflowsGetToManyRelatedFieldsScmRepositorie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsWorkflowsGetToManyRelatedFieldsScmRepositorie), TypeInfoPropertyName = "CiProductsWorkflowsGetToManyRelatedFieldsScmRepositorie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsWorkflowsGetToManyRelatedFieldsCiXcodeVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsWorkflowsGetToManyRelatedFieldsCiXcodeVersion), TypeInfoPropertyName = "CiProductsWorkflowsGetToManyRelatedFieldsCiXcodeVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsWorkflowsGetToManyRelatedFieldsCiMacOsVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsWorkflowsGetToManyRelatedFieldsCiMacOsVersion), TypeInfoPropertyName = "CiProductsWorkflowsGetToManyRelatedFieldsCiMacOsVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsWorkflowsGetToManyRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsWorkflowsGetToManyRelatedIncludeItem), TypeInfoPropertyName = "CiProductsWorkflowsGetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsResponseIncludedItemDiscriminatorType?), TypeInfoPropertyName = "NullableCiProductsResponseIncludedItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiWorkflowsResponseIncludedItemDiscriminatorType?), TypeInfoPropertyName = "NullableCiWorkflowsResponseIncludedItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductAdditionalRepositoriesLinkagesResponseDataItemType?), TypeInfoPropertyName = "NullableCiProductAdditionalRepositoriesLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductAppLinkageResponseDataType?), TypeInfoPropertyName = "NullableCiProductAppLinkageResponseDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductBuildRunsLinkagesResponseDataItemType?), TypeInfoPropertyName = "NullableCiProductBuildRunsLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductPrimaryRepositoriesLinkagesResponseDataItemType?), TypeInfoPropertyName = "NullableCiProductPrimaryRepositoriesLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductWorkflowsLinkagesResponseDataItemType?), TypeInfoPropertyName = "NullableCiProductWorkflowsLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsGetCollectionFilterProductTypeItem?), TypeInfoPropertyName = "NullableCiProductsGetCollectionFilterProductTypeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsGetCollectionFieldsCiProduct?), TypeInfoPropertyName = "NullableCiProductsGetCollectionFieldsCiProduct2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsGetCollectionFieldsApp?), TypeInfoPropertyName = "NullableCiProductsGetCollectionFieldsApp2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsGetCollectionFieldsBundleId?), TypeInfoPropertyName = "NullableCiProductsGetCollectionFieldsBundleId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsGetCollectionFieldsScmRepositorie?), TypeInfoPropertyName = "NullableCiProductsGetCollectionFieldsScmRepositorie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsGetCollectionIncludeItem?), TypeInfoPropertyName = "NullableCiProductsGetCollectionIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsGetInstanceFieldsCiProduct?), TypeInfoPropertyName = "NullableCiProductsGetInstanceFieldsCiProduct2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsGetInstanceFieldsApp?), TypeInfoPropertyName = "NullableCiProductsGetInstanceFieldsApp2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsGetInstanceFieldsBundleId?), TypeInfoPropertyName = "NullableCiProductsGetInstanceFieldsBundleId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsGetInstanceFieldsScmRepositorie?), TypeInfoPropertyName = "NullableCiProductsGetInstanceFieldsScmRepositorie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsGetInstanceIncludeItem?), TypeInfoPropertyName = "NullableCiProductsGetInstanceIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsAdditionalRepositoriesGetToManyRelatedFieldsScmRepositorie?), TypeInfoPropertyName = "NullableCiProductsAdditionalRepositoriesGetToManyRelatedFieldsScmRepositorie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsAdditionalRepositoriesGetToManyRelatedFieldsScmProvider?), TypeInfoPropertyName = "NullableCiProductsAdditionalRepositoriesGetToManyRelatedFieldsScmProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsAdditionalRepositoriesGetToManyRelatedFieldsScmGitReference?), TypeInfoPropertyName = "NullableCiProductsAdditionalRepositoriesGetToManyRelatedFieldsScmGitReference2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsAdditionalRepositoriesGetToManyRelatedIncludeItem?), TypeInfoPropertyName = "NullableCiProductsAdditionalRepositoriesGetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsApp?), TypeInfoPropertyName = "NullableCiProductsAppGetToOneRelatedFieldsApp2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppEncryptionDeclaration?), TypeInfoPropertyName = "NullableCiProductsAppGetToOneRelatedFieldsAppEncryptionDeclaration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBuildIcon?), TypeInfoPropertyName = "NullableCiProductsAppGetToOneRelatedFieldsBuildIcon2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsCiProduct?), TypeInfoPropertyName = "NullableCiProductsAppGetToOneRelatedFieldsCiProduct2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBetaGroup?), TypeInfoPropertyName = "NullableCiProductsAppGetToOneRelatedFieldsBetaGroup2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppStoreVersion?), TypeInfoPropertyName = "NullableCiProductsAppGetToOneRelatedFieldsAppStoreVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsPreReleaseVersion?), TypeInfoPropertyName = "NullableCiProductsAppGetToOneRelatedFieldsPreReleaseVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBetaAppLocalization?), TypeInfoPropertyName = "NullableCiProductsAppGetToOneRelatedFieldsBetaAppLocalization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBuild?), TypeInfoPropertyName = "NullableCiProductsAppGetToOneRelatedFieldsBuild2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBetaLicenseAgreement?), TypeInfoPropertyName = "NullableCiProductsAppGetToOneRelatedFieldsBetaLicenseAgreement2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBetaAppReviewDetail?), TypeInfoPropertyName = "NullableCiProductsAppGetToOneRelatedFieldsBetaAppReviewDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppInfo?), TypeInfoPropertyName = "NullableCiProductsAppGetToOneRelatedFieldsAppInfo2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppClip?), TypeInfoPropertyName = "NullableCiProductsAppGetToOneRelatedFieldsAppClip2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsEndUserLicenseAgreement?), TypeInfoPropertyName = "NullableCiProductsAppGetToOneRelatedFieldsEndUserLicenseAgreement2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsInAppPurchase?), TypeInfoPropertyName = "NullableCiProductsAppGetToOneRelatedFieldsInAppPurchase2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsSubscriptionGroup?), TypeInfoPropertyName = "NullableCiProductsAppGetToOneRelatedFieldsSubscriptionGroup2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsGameCenterEnabledVersion?), TypeInfoPropertyName = "NullableCiProductsAppGetToOneRelatedFieldsGameCenterEnabledVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppCustomProductPage?), TypeInfoPropertyName = "NullableCiProductsAppGetToOneRelatedFieldsAppCustomProductPage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsPromotedPurchase?), TypeInfoPropertyName = "NullableCiProductsAppGetToOneRelatedFieldsPromotedPurchase2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppEvent?), TypeInfoPropertyName = "NullableCiProductsAppGetToOneRelatedFieldsAppEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsReviewSubmission?), TypeInfoPropertyName = "NullableCiProductsAppGetToOneRelatedFieldsReviewSubmission2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsSubscriptionGracePeriod?), TypeInfoPropertyName = "NullableCiProductsAppGetToOneRelatedFieldsSubscriptionGracePeriod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsGameCenterDetail?), TypeInfoPropertyName = "NullableCiProductsAppGetToOneRelatedFieldsGameCenterDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppStoreVersionExperiment?), TypeInfoPropertyName = "NullableCiProductsAppGetToOneRelatedFieldsAppStoreVersionExperiment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAndroidToIosAppMappingDetail?), TypeInfoPropertyName = "NullableCiProductsAppGetToOneRelatedFieldsAndroidToIosAppMappingDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedIncludeItem?), TypeInfoPropertyName = "NullableCiProductsAppGetToOneRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedSortItem?), TypeInfoPropertyName = "NullableCiProductsBuildRunsGetToManyRelatedSortItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsCiBuildRun?), TypeInfoPropertyName = "NullableCiProductsBuildRunsGetToManyRelatedFieldsCiBuildRun2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsBuild?), TypeInfoPropertyName = "NullableCiProductsBuildRunsGetToManyRelatedFieldsBuild2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsCiWorkflow?), TypeInfoPropertyName = "NullableCiProductsBuildRunsGetToManyRelatedFieldsCiWorkflow2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsCiProduct?), TypeInfoPropertyName = "NullableCiProductsBuildRunsGetToManyRelatedFieldsCiProduct2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsScmGitReference?), TypeInfoPropertyName = "NullableCiProductsBuildRunsGetToManyRelatedFieldsScmGitReference2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsScmPullRequest?), TypeInfoPropertyName = "NullableCiProductsBuildRunsGetToManyRelatedFieldsScmPullRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedIncludeItem?), TypeInfoPropertyName = "NullableCiProductsBuildRunsGetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsPrimaryRepositoriesGetToManyRelatedFieldsScmRepositorie?), TypeInfoPropertyName = "NullableCiProductsPrimaryRepositoriesGetToManyRelatedFieldsScmRepositorie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsPrimaryRepositoriesGetToManyRelatedFieldsScmProvider?), TypeInfoPropertyName = "NullableCiProductsPrimaryRepositoriesGetToManyRelatedFieldsScmProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsPrimaryRepositoriesGetToManyRelatedFieldsScmGitReference?), TypeInfoPropertyName = "NullableCiProductsPrimaryRepositoriesGetToManyRelatedFieldsScmGitReference2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsPrimaryRepositoriesGetToManyRelatedIncludeItem?), TypeInfoPropertyName = "NullableCiProductsPrimaryRepositoriesGetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsWorkflowsGetToManyRelatedFieldsCiWorkflow?), TypeInfoPropertyName = "NullableCiProductsWorkflowsGetToManyRelatedFieldsCiWorkflow2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsWorkflowsGetToManyRelatedFieldsCiProduct?), TypeInfoPropertyName = "NullableCiProductsWorkflowsGetToManyRelatedFieldsCiProduct2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsWorkflowsGetToManyRelatedFieldsScmRepositorie?), TypeInfoPropertyName = "NullableCiProductsWorkflowsGetToManyRelatedFieldsScmRepositorie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsWorkflowsGetToManyRelatedFieldsCiXcodeVersion?), TypeInfoPropertyName = "NullableCiProductsWorkflowsGetToManyRelatedFieldsCiXcodeVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsWorkflowsGetToManyRelatedFieldsCiMacOsVersion?), TypeInfoPropertyName = "NullableCiProductsWorkflowsGetToManyRelatedFieldsCiMacOsVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsWorkflowsGetToManyRelatedIncludeItem?), TypeInfoPropertyName = "NullableCiProductsWorkflowsGetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductAdditionalRepositoriesLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductBuildRunsLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductPrimaryRepositoriesLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductWorkflowsLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsGetCollectionFilterProductTypeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsGetCollectionFieldsCiProduct>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsGetCollectionFieldsApp>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsGetCollectionFieldsBundleId>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsGetCollectionFieldsScmRepositorie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsGetCollectionIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsGetInstanceFieldsCiProduct>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsGetInstanceFieldsApp>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsGetInstanceFieldsBundleId>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsGetInstanceFieldsScmRepositorie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsGetInstanceIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsAdditionalRepositoriesGetToManyRelatedFieldsScmRepositorie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsAdditionalRepositoriesGetToManyRelatedFieldsScmProvider>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsAdditionalRepositoriesGetToManyRelatedFieldsScmGitReference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsAdditionalRepositoriesGetToManyRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsApp>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppEncryptionDeclaration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBuildIcon>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsCiProduct>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBetaGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppStoreVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsPreReleaseVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBetaAppLocalization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBuild>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBetaLicenseAgreement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBetaAppReviewDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppClip>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsEndUserLicenseAgreement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsInAppPurchase>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsSubscriptionGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsGameCenterEnabledVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppCustomProductPage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsPromotedPurchase>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsReviewSubmission>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsSubscriptionGracePeriod>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsGameCenterDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppStoreVersionExperiment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAndroidToIosAppMappingDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsAppGetToOneRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedSortItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsCiBuildRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsBuild>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsCiWorkflow>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsCiProduct>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsScmGitReference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsScmPullRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsPrimaryRepositoriesGetToManyRelatedFieldsScmRepositorie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsPrimaryRepositoriesGetToManyRelatedFieldsScmProvider>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsPrimaryRepositoriesGetToManyRelatedFieldsScmGitReference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsPrimaryRepositoriesGetToManyRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsWorkflowsGetToManyRelatedFieldsCiWorkflow>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsWorkflowsGetToManyRelatedFieldsCiProduct>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsWorkflowsGetToManyRelatedFieldsScmRepositorie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsWorkflowsGetToManyRelatedFieldsCiXcodeVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsWorkflowsGetToManyRelatedFieldsCiMacOsVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsWorkflowsGetToManyRelatedIncludeItem>))]
    internal sealed partial class CiProductsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CiProductsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static CiProductsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private CiProductsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            global::AppStoreConnect.PartitionCoreSourceGenerationContext.AddConverters(options);
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::AppStoreConnect.CiProductsResponseIncludedItemDiscriminatorType)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsResponseIncludedItemDiscriminatorType?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsResponseIncludedItemDiscriminatorType)

                    || typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsResponseIncludedItemDiscriminatorType?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductAdditionalRepositoriesLinkagesResponseDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductAdditionalRepositoriesLinkagesResponseDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductAppLinkageResponseDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductAppLinkageResponseDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductBuildRunsLinkagesResponseDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductBuildRunsLinkagesResponseDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductPrimaryRepositoriesLinkagesResponseDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductPrimaryRepositoriesLinkagesResponseDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductWorkflowsLinkagesResponseDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductWorkflowsLinkagesResponseDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsGetCollectionFilterProductTypeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsGetCollectionFilterProductTypeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsGetCollectionFieldsCiProduct)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsGetCollectionFieldsCiProduct?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsGetCollectionFieldsApp)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsGetCollectionFieldsApp?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsGetCollectionFieldsBundleId)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsGetCollectionFieldsBundleId?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsGetCollectionFieldsScmRepositorie)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsGetCollectionFieldsScmRepositorie?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsGetCollectionIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsGetCollectionIncludeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsGetInstanceFieldsCiProduct)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsGetInstanceFieldsCiProduct?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsGetInstanceFieldsApp)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsGetInstanceFieldsApp?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsGetInstanceFieldsBundleId)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsGetInstanceFieldsBundleId?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsGetInstanceFieldsScmRepositorie)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsGetInstanceFieldsScmRepositorie?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsGetInstanceIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsGetInstanceIncludeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAdditionalRepositoriesGetToManyRelatedFieldsScmRepositorie)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAdditionalRepositoriesGetToManyRelatedFieldsScmRepositorie?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAdditionalRepositoriesGetToManyRelatedFieldsScmProvider)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAdditionalRepositoriesGetToManyRelatedFieldsScmProvider?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAdditionalRepositoriesGetToManyRelatedFieldsScmGitReference)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAdditionalRepositoriesGetToManyRelatedFieldsScmGitReference?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAdditionalRepositoriesGetToManyRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAdditionalRepositoriesGetToManyRelatedIncludeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsApp)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsApp?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppEncryptionDeclaration)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppEncryptionDeclaration?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBuildIcon)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBuildIcon?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsCiProduct)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsCiProduct?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBetaGroup)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBetaGroup?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppStoreVersion)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppStoreVersion?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsPreReleaseVersion)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsPreReleaseVersion?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBetaAppLocalization)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBetaAppLocalization?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBuild)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBuild?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBetaLicenseAgreement)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBetaLicenseAgreement?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBetaAppReviewDetail)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBetaAppReviewDetail?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppInfo)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppInfo?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppClip)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppClip?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsEndUserLicenseAgreement)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsEndUserLicenseAgreement?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsInAppPurchase)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsInAppPurchase?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsSubscriptionGroup)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsSubscriptionGroup?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsGameCenterEnabledVersion)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsGameCenterEnabledVersion?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppCustomProductPage)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppCustomProductPage?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsPromotedPurchase)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsPromotedPurchase?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppEvent)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppEvent?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsReviewSubmission)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsReviewSubmission?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsSubscriptionGracePeriod)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsSubscriptionGracePeriod?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsGameCenterDetail)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsGameCenterDetail?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppStoreVersionExperiment)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppStoreVersionExperiment?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAndroidToIosAppMappingDetail)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAndroidToIosAppMappingDetail?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedIncludeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedSortItem)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedSortItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsCiBuildRun)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsCiBuildRun?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsBuild)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsBuild?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsCiWorkflow)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsCiWorkflow?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsCiProduct)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsCiProduct?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsScmGitReference)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsScmGitReference?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsScmPullRequest)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsScmPullRequest?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedIncludeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsPrimaryRepositoriesGetToManyRelatedFieldsScmRepositorie)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsPrimaryRepositoriesGetToManyRelatedFieldsScmRepositorie?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsPrimaryRepositoriesGetToManyRelatedFieldsScmProvider)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsPrimaryRepositoriesGetToManyRelatedFieldsScmProvider?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsPrimaryRepositoriesGetToManyRelatedFieldsScmGitReference)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsPrimaryRepositoriesGetToManyRelatedFieldsScmGitReference?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsPrimaryRepositoriesGetToManyRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsPrimaryRepositoriesGetToManyRelatedIncludeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsWorkflowsGetToManyRelatedFieldsCiWorkflow)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsWorkflowsGetToManyRelatedFieldsCiWorkflow?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsWorkflowsGetToManyRelatedFieldsCiProduct)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsWorkflowsGetToManyRelatedFieldsCiProduct?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsWorkflowsGetToManyRelatedFieldsScmRepositorie)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsWorkflowsGetToManyRelatedFieldsScmRepositorie?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsWorkflowsGetToManyRelatedFieldsCiXcodeVersion)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsWorkflowsGetToManyRelatedFieldsCiXcodeVersion?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsWorkflowsGetToManyRelatedFieldsCiMacOsVersion)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsWorkflowsGetToManyRelatedFieldsCiMacOsVersion?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsWorkflowsGetToManyRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsWorkflowsGetToManyRelatedIncludeItem?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsResponseIncludedItemDiscriminatorType))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsResponseIncludedItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsResponseIncludedItemDiscriminatorType?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsResponseIncludedItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsResponseIncludedItemDiscriminatorType))
                {
                    return new global::AppStoreConnect.JsonConverters.CiWorkflowsResponseIncludedItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsResponseIncludedItemDiscriminatorType?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiWorkflowsResponseIncludedItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductAdditionalRepositoriesLinkagesResponseDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductAdditionalRepositoriesLinkagesResponseDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductAdditionalRepositoriesLinkagesResponseDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductAdditionalRepositoriesLinkagesResponseDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductAppLinkageResponseDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductAppLinkageResponseDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductAppLinkageResponseDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductAppLinkageResponseDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductBuildRunsLinkagesResponseDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductBuildRunsLinkagesResponseDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductBuildRunsLinkagesResponseDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductBuildRunsLinkagesResponseDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductPrimaryRepositoriesLinkagesResponseDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductPrimaryRepositoriesLinkagesResponseDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductPrimaryRepositoriesLinkagesResponseDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductPrimaryRepositoriesLinkagesResponseDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductWorkflowsLinkagesResponseDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductWorkflowsLinkagesResponseDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductWorkflowsLinkagesResponseDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductWorkflowsLinkagesResponseDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsGetCollectionFilterProductTypeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsGetCollectionFilterProductTypeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsGetCollectionFilterProductTypeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsGetCollectionFilterProductTypeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsGetCollectionFieldsCiProduct))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsGetCollectionFieldsCiProductJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsGetCollectionFieldsCiProduct?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsGetCollectionFieldsCiProductNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsGetCollectionFieldsApp))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsGetCollectionFieldsAppJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsGetCollectionFieldsApp?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsGetCollectionFieldsAppNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsGetCollectionFieldsBundleId))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsGetCollectionFieldsBundleIdJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsGetCollectionFieldsBundleId?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsGetCollectionFieldsBundleIdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsGetCollectionFieldsScmRepositorie))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsGetCollectionFieldsScmRepositorieJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsGetCollectionFieldsScmRepositorie?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsGetCollectionFieldsScmRepositorieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsGetCollectionIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsGetCollectionIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsGetCollectionIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsGetCollectionIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsGetInstanceFieldsCiProduct))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsGetInstanceFieldsCiProductJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsGetInstanceFieldsCiProduct?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsGetInstanceFieldsCiProductNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsGetInstanceFieldsApp))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsGetInstanceFieldsAppJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsGetInstanceFieldsApp?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsGetInstanceFieldsAppNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsGetInstanceFieldsBundleId))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsGetInstanceFieldsBundleIdJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsGetInstanceFieldsBundleId?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsGetInstanceFieldsBundleIdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsGetInstanceFieldsScmRepositorie))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsGetInstanceFieldsScmRepositorieJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsGetInstanceFieldsScmRepositorie?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsGetInstanceFieldsScmRepositorieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsGetInstanceIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsGetInstanceIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsGetInstanceIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsGetInstanceIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAdditionalRepositoriesGetToManyRelatedFieldsScmRepositorie))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAdditionalRepositoriesGetToManyRelatedFieldsScmRepositorieJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAdditionalRepositoriesGetToManyRelatedFieldsScmRepositorie?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAdditionalRepositoriesGetToManyRelatedFieldsScmRepositorieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAdditionalRepositoriesGetToManyRelatedFieldsScmProvider))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAdditionalRepositoriesGetToManyRelatedFieldsScmProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAdditionalRepositoriesGetToManyRelatedFieldsScmProvider?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAdditionalRepositoriesGetToManyRelatedFieldsScmProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAdditionalRepositoriesGetToManyRelatedFieldsScmGitReference))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAdditionalRepositoriesGetToManyRelatedFieldsScmGitReferenceJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAdditionalRepositoriesGetToManyRelatedFieldsScmGitReference?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAdditionalRepositoriesGetToManyRelatedFieldsScmGitReferenceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAdditionalRepositoriesGetToManyRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAdditionalRepositoriesGetToManyRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAdditionalRepositoriesGetToManyRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAdditionalRepositoriesGetToManyRelatedIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsApp))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsAppJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsApp?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsAppNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppEncryptionDeclaration))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsAppEncryptionDeclarationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppEncryptionDeclaration?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsAppEncryptionDeclarationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBuildIcon))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsBuildIconJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBuildIcon?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsBuildIconNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsCiProduct))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsCiProductJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsCiProduct?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsCiProductNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBetaGroup))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsBetaGroupJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBetaGroup?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsBetaGroupNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppStoreVersion))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsAppStoreVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppStoreVersion?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsAppStoreVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsPreReleaseVersion))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsPreReleaseVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsPreReleaseVersion?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsPreReleaseVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBetaAppLocalization))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsBetaAppLocalizationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBetaAppLocalization?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsBetaAppLocalizationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBuild))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsBuildJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBuild?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsBuildNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBetaLicenseAgreement))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsBetaLicenseAgreementJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBetaLicenseAgreement?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsBetaLicenseAgreementNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBetaAppReviewDetail))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsBetaAppReviewDetailJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBetaAppReviewDetail?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsBetaAppReviewDetailNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppInfo))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsAppInfoJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppInfo?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsAppInfoNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppClip))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsAppClipJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppClip?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsAppClipNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsEndUserLicenseAgreement))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsEndUserLicenseAgreementJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsEndUserLicenseAgreement?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsEndUserLicenseAgreementNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsInAppPurchase))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsInAppPurchaseJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsInAppPurchase?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsInAppPurchaseNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsSubscriptionGroup))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsSubscriptionGroupJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsSubscriptionGroup?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsSubscriptionGroupNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsGameCenterEnabledVersion))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsGameCenterEnabledVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsGameCenterEnabledVersion?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsGameCenterEnabledVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppCustomProductPage))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsAppCustomProductPageJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppCustomProductPage?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsAppCustomProductPageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsPromotedPurchase))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsPromotedPurchaseJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsPromotedPurchase?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsPromotedPurchaseNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppEvent))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsAppEventJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppEvent?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsAppEventNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsReviewSubmission))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsReviewSubmissionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsReviewSubmission?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsReviewSubmissionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsSubscriptionGracePeriod))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsSubscriptionGracePeriodJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsSubscriptionGracePeriod?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsSubscriptionGracePeriodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsGameCenterDetail))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsGameCenterDetailJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsGameCenterDetail?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsGameCenterDetailNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppStoreVersionExperiment))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsAppStoreVersionExperimentJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppStoreVersionExperiment?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsAppStoreVersionExperimentNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAndroidToIosAppMappingDetail))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsAndroidToIosAppMappingDetailJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAndroidToIosAppMappingDetail?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsAndroidToIosAppMappingDetailNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedSortItem))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsBuildRunsGetToManyRelatedSortItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedSortItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsBuildRunsGetToManyRelatedSortItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsCiBuildRun))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsBuildRunsGetToManyRelatedFieldsCiBuildRunJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsCiBuildRun?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsBuildRunsGetToManyRelatedFieldsCiBuildRunNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsBuild))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsBuildRunsGetToManyRelatedFieldsBuildJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsBuild?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsBuildRunsGetToManyRelatedFieldsBuildNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsCiWorkflow))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsBuildRunsGetToManyRelatedFieldsCiWorkflowJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsCiWorkflow?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsBuildRunsGetToManyRelatedFieldsCiWorkflowNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsCiProduct))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsBuildRunsGetToManyRelatedFieldsCiProductJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsCiProduct?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsBuildRunsGetToManyRelatedFieldsCiProductNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsScmGitReference))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsBuildRunsGetToManyRelatedFieldsScmGitReferenceJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsScmGitReference?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsBuildRunsGetToManyRelatedFieldsScmGitReferenceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsScmPullRequest))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsBuildRunsGetToManyRelatedFieldsScmPullRequestJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsScmPullRequest?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsBuildRunsGetToManyRelatedFieldsScmPullRequestNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsBuildRunsGetToManyRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsBuildRunsGetToManyRelatedIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsPrimaryRepositoriesGetToManyRelatedFieldsScmRepositorie))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsPrimaryRepositoriesGetToManyRelatedFieldsScmRepositorieJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsPrimaryRepositoriesGetToManyRelatedFieldsScmRepositorie?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsPrimaryRepositoriesGetToManyRelatedFieldsScmRepositorieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsPrimaryRepositoriesGetToManyRelatedFieldsScmProvider))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsPrimaryRepositoriesGetToManyRelatedFieldsScmProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsPrimaryRepositoriesGetToManyRelatedFieldsScmProvider?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsPrimaryRepositoriesGetToManyRelatedFieldsScmProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsPrimaryRepositoriesGetToManyRelatedFieldsScmGitReference))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsPrimaryRepositoriesGetToManyRelatedFieldsScmGitReferenceJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsPrimaryRepositoriesGetToManyRelatedFieldsScmGitReference?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsPrimaryRepositoriesGetToManyRelatedFieldsScmGitReferenceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsPrimaryRepositoriesGetToManyRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsPrimaryRepositoriesGetToManyRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsPrimaryRepositoriesGetToManyRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsPrimaryRepositoriesGetToManyRelatedIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsWorkflowsGetToManyRelatedFieldsCiWorkflow))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsWorkflowsGetToManyRelatedFieldsCiWorkflowJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsWorkflowsGetToManyRelatedFieldsCiWorkflow?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsWorkflowsGetToManyRelatedFieldsCiWorkflowNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsWorkflowsGetToManyRelatedFieldsCiProduct))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsWorkflowsGetToManyRelatedFieldsCiProductJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsWorkflowsGetToManyRelatedFieldsCiProduct?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsWorkflowsGetToManyRelatedFieldsCiProductNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsWorkflowsGetToManyRelatedFieldsScmRepositorie))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsWorkflowsGetToManyRelatedFieldsScmRepositorieJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsWorkflowsGetToManyRelatedFieldsScmRepositorie?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsWorkflowsGetToManyRelatedFieldsScmRepositorieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsWorkflowsGetToManyRelatedFieldsCiXcodeVersion))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsWorkflowsGetToManyRelatedFieldsCiXcodeVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsWorkflowsGetToManyRelatedFieldsCiXcodeVersion?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsWorkflowsGetToManyRelatedFieldsCiXcodeVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsWorkflowsGetToManyRelatedFieldsCiMacOsVersion))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsWorkflowsGetToManyRelatedFieldsCiMacOsVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsWorkflowsGetToManyRelatedFieldsCiMacOsVersion?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsWorkflowsGetToManyRelatedFieldsCiMacOsVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsWorkflowsGetToManyRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsWorkflowsGetToManyRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsWorkflowsGetToManyRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsWorkflowsGetToManyRelatedIncludeItemNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[2];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new CiProductsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),

                    1 => global::AppStoreConnect.PartitionCoreSourceGenerationContext.TypeInfoResolver,
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}