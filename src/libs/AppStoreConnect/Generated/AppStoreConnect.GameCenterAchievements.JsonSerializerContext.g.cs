
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ResourceLinks))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.PagedDocumentLinks))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.PagingInformation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.DocumentLinks))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.Actor))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AgeRatingDeclaration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AlternativeDistributionPackageDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AlternativeDistributionPackageVariant))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.RelationshipLinks))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem), TypeInfoPropertyName = "IncludedItem2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AlternativeDistributionPackage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem2), TypeInfoPropertyName = "IncludedItem22_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AndroidToIosAppMappingDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppCategory))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppClipAdvancedExperienceImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ImageAsset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.UploadOperation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.UploadOperation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppMediaAssetState))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppClipAdvancedExperienceLocalization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem3), TypeInfoPropertyName = "IncludedItem32_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppClip))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem4), TypeInfoPropertyName = "IncludedItem42_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppClipAppStoreReviewDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppClipDefaultExperience))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppClipDefaultExperienceLocalization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem5), TypeInfoPropertyName = "IncludedItem52_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppClipHeaderImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem6), TypeInfoPropertyName = "IncludedItem62_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem7), TypeInfoPropertyName = "IncludedItem72_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem8), TypeInfoPropertyName = "IncludedItem82_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem9), TypeInfoPropertyName = "IncludedItem92_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.App))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem10), TypeInfoPropertyName = "IncludedItem102_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppCustomProductPageLocalization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem11), TypeInfoPropertyName = "IncludedItem112_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppCustomProductPageVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppKeyword))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPreviewSet))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppScreenshotSet))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem12), TypeInfoPropertyName = "IncludedItem122_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem13), TypeInfoPropertyName = "IncludedItem132")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppCustomProductPage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem14), TypeInfoPropertyName = "IncludedItem142_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem15), TypeInfoPropertyName = "IncludedItem152_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem16), TypeInfoPropertyName = "IncludedItem162_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppEncryptionDeclarationDocument))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppEncryptionDeclaration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem18), TypeInfoPropertyName = "IncludedItem182")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.Build))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem19), TypeInfoPropertyName = "IncludedItem192")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem20), TypeInfoPropertyName = "IncludedItem202")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppEventScreenshot))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppEventVideoClip))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem21), TypeInfoPropertyName = "IncludedItem212")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfoLocalization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem22), TypeInfoPropertyName = "IncludedItem222")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem23), TypeInfoPropertyName = "IncludedItem232")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem24), TypeInfoPropertyName = "IncludedItem242")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPreview))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionLocalization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem25), TypeInfoPropertyName = "IncludedItem252")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPricePointV3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem26), TypeInfoPropertyName = "IncludedItem262")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.Territory))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem27), TypeInfoPropertyName = "IncludedItem272")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem28), TypeInfoPropertyName = "IncludedItem282")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPriceV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem30), TypeInfoPropertyName = "IncludedItem302")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem31), TypeInfoPropertyName = "IncludedItem312")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppScreenshot))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem32), TypeInfoPropertyName = "IncludedItem322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreReviewAttachment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreReviewDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem33), TypeInfoPropertyName = "IncludedItem332")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem34), TypeInfoPropertyName = "IncludedItem342")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem35), TypeInfoPropertyName = "IncludedItem352")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem36), TypeInfoPropertyName = "IncludedItem362")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionExperiment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem37), TypeInfoPropertyName = "IncludedItem372")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionExperimentV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem38), TypeInfoPropertyName = "IncludedItem382")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem39), TypeInfoPropertyName = "IncludedItem392")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem40), TypeInfoPropertyName = "IncludedItem402")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem41), TypeInfoPropertyName = "IncludedItem412")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem42), TypeInfoPropertyName = "IncludedItem422")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem43), TypeInfoPropertyName = "IncludedItem432")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionPhasedRelease))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionSubmission))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem44), TypeInfoPropertyName = "IncludedItem442")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAppVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.RoutingAppCoverage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem45), TypeInfoPropertyName = "IncludedItem452")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem46), TypeInfoPropertyName = "IncludedItem462")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaAppLocalization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaAppReviewDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaGroup))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaLicenseAgreement))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildIcon))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProduct))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.EndUserLicenseAgreement))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterEnabledVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.InAppPurchase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.PrereleaseVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.PromotedPurchase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmission))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGracePeriod))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroup))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem47), TypeInfoPropertyName = "IncludedItem472")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BackgroundAssetVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem50), TypeInfoPropertyName = "IncludedItem502")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem51), TypeInfoPropertyName = "IncludedItem512")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaAppReviewSubmission))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaBuildLocalization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem52), TypeInfoPropertyName = "IncludedItem522")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaTester))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem53), TypeInfoPropertyName = "IncludedItem532")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem54), TypeInfoPropertyName = "IncludedItem542")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem55), TypeInfoPropertyName = "IncludedItem552")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem56), TypeInfoPropertyName = "IncludedItem562")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaRecruitmentCriterion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem57), TypeInfoPropertyName = "IncludedItem572")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem58), TypeInfoPropertyName = "IncludedItem582")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem59), TypeInfoPropertyName = "IncludedItem592")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildBetaDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildBundle))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildUploadFile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildUpload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem60), TypeInfoPropertyName = "IncludedItem602")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem61), TypeInfoPropertyName = "IncludedItem612")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem62), TypeInfoPropertyName = "IncludedItem622")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem63), TypeInfoPropertyName = "IncludedItem632")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BundleIdCapability))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BundleId))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem64), TypeInfoPropertyName = "IncludedItem642")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.Profile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem65), TypeInfoPropertyName = "IncludedItem652")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.Certificate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem66), TypeInfoPropertyName = "IncludedItem662")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiWorkflow))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ScmGitReference))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ScmPullRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem67), TypeInfoPropertyName = "IncludedItem672")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiMacOsVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiXcodeVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem68), TypeInfoPropertyName = "IncludedItem682")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ScmRepository))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem69), TypeInfoPropertyName = "IncludedItem692")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem70), TypeInfoPropertyName = "IncludedItem702")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem71), TypeInfoPropertyName = "IncludedItem712")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CustomerReviewResponseV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem72), TypeInfoPropertyName = "IncludedItem722")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem73), TypeInfoPropertyName = "IncludedItem732")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.Device))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem74), TypeInfoPropertyName = "IncludedItem742")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementImageType), TypeInfoPropertyName = "GameCenterAchievementImageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementImageAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementImageRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementImageRelationshipsGameCenterAchievementLocalization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementImageRelationshipsGameCenterAchievementLocalizationData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementImageRelationshipsGameCenterAchievementLocalizationDataType), TypeInfoPropertyName = "GameCenterAchievementImageRelationshipsGameCenterAchievementLocalizationDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAchievementLocalization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementLocalization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementImageV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementLocalizationV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementLocalizationV2Type), TypeInfoPropertyName = "GameCenterAchievementLocalizationV2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementLocalizationV2Attributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementLocalizationV2Relationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementLocalizationV2RelationshipsVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementLocalizationV2RelationshipsVersionData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementLocalizationV2RelationshipsVersionDataType), TypeInfoPropertyName = "GameCenterAchievementLocalizationV2RelationshipsVersionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementLocalizationV2RelationshipsImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementLocalizationV2RelationshipsImageData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementLocalizationV2RelationshipsImageDataType), TypeInfoPropertyName = "GameCenterAchievementLocalizationV2RelationshipsImageDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem75), TypeInfoPropertyName = "IncludedItem752")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementVersionV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem76), TypeInfoPropertyName = "IncludedItem762")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementLocalizationType), TypeInfoPropertyName = "GameCenterAchievementLocalizationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementLocalizationAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementLocalizationRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementLocalizationRelationshipsGameCenterAchievement))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementLocalizationRelationshipsGameCenterAchievementData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementLocalizationRelationshipsGameCenterAchievementDataType), TypeInfoPropertyName = "GameCenterAchievementLocalizationRelationshipsGameCenterAchievementDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementLocalizationRelationshipsGameCenterAchievementImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementLocalizationRelationshipsGameCenterAchievementImageData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementLocalizationRelationshipsGameCenterAchievementImageDataType), TypeInfoPropertyName = "GameCenterAchievementLocalizationRelationshipsGameCenterAchievementImageDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementLocalizationsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.IncludedItem77>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem77), TypeInfoPropertyName = "IncludedItem772")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievement))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementLocalizationsResponseIncludedItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementLocalizationsResponseIncludedItemDiscriminatorType), TypeInfoPropertyName = "GameCenterAchievementLocalizationsResponseIncludedItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem78), TypeInfoPropertyName = "IncludedItem782")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementRelease))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementReleaseType), TypeInfoPropertyName = "GameCenterAchievementReleaseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementReleaseAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementReleaseRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementReleaseRelationshipsGameCenterDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementReleaseRelationshipsGameCenterDetailData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementReleaseRelationshipsGameCenterDetailDataType), TypeInfoPropertyName = "GameCenterAchievementReleaseRelationshipsGameCenterDetailDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementReleaseRelationshipsGameCenterAchievement))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementReleaseRelationshipsGameCenterAchievementData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementReleaseRelationshipsGameCenterAchievementDataType), TypeInfoPropertyName = "GameCenterAchievementReleaseRelationshipsGameCenterAchievementDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementReleasesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAchievementRelease>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.IncludedItem79>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem79), TypeInfoPropertyName = "IncludedItem792")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementReleasesResponseIncludedItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementReleasesResponseIncludedItemDiscriminatorType), TypeInfoPropertyName = "GameCenterAchievementReleasesResponseIncludedItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem80), TypeInfoPropertyName = "IncludedItem802")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementVersionV2Type), TypeInfoPropertyName = "GameCenterAchievementVersionV2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementVersionV2Attributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterVersionState), TypeInfoPropertyName = "GameCenterVersionState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementVersionV2Relationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementVersionV2RelationshipsAchievement))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementVersionV2RelationshipsAchievementData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementVersionV2RelationshipsAchievementDataType), TypeInfoPropertyName = "GameCenterAchievementVersionV2RelationshipsAchievementDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementVersionV2RelationshipsLocalizations))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAchievementVersionV2RelationshipsLocalizationsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementVersionV2RelationshipsLocalizationsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementVersionV2RelationshipsLocalizationsDataItemType), TypeInfoPropertyName = "GameCenterAchievementVersionV2RelationshipsLocalizationsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementVersionV2InlineCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementVersionV2InlineCreateType), TypeInfoPropertyName = "GameCenterAchievementVersionV2InlineCreateType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementVersionV2InlineCreateRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementVersionV2InlineCreateRelationshipsAchievement))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementVersionV2InlineCreateRelationshipsAchievementData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementVersionV2InlineCreateRelationshipsAchievementDataType), TypeInfoPropertyName = "GameCenterAchievementVersionV2InlineCreateRelationshipsAchievementDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementVersionsV2Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAchievementVersionV2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.IncludedItem81>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem81), TypeInfoPropertyName = "IncludedItem812")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementVersionsV2ResponseIncludedItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementVersionsV2ResponseIncludedItemDiscriminatorType), TypeInfoPropertyName = "GameCenterAchievementVersionsV2ResponseIncludedItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem82), TypeInfoPropertyName = "IncludedItem822")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementV2Type), TypeInfoPropertyName = "GameCenterAchievementV2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementV2Attributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementV2Relationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementV2RelationshipsGameCenterDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementV2RelationshipsGameCenterDetailData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementV2RelationshipsGameCenterDetailDataType), TypeInfoPropertyName = "GameCenterAchievementV2RelationshipsGameCenterDetailDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementV2RelationshipsGameCenterGroup))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementV2RelationshipsGameCenterGroupData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementV2RelationshipsGameCenterGroupDataType), TypeInfoPropertyName = "GameCenterAchievementV2RelationshipsGameCenterGroupDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementV2RelationshipsActivity))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementV2RelationshipsActivityData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementV2RelationshipsActivityDataType), TypeInfoPropertyName = "GameCenterAchievementV2RelationshipsActivityDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementV2RelationshipsVersions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAchievementV2RelationshipsVersionsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementV2RelationshipsVersionsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementV2RelationshipsVersionsDataItemType), TypeInfoPropertyName = "GameCenterAchievementV2RelationshipsVersionsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem83), TypeInfoPropertyName = "IncludedItem832")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterActivity))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroup))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementV2Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.IncludedItem84>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem84), TypeInfoPropertyName = "IncludedItem842")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementV2ResponseIncludedItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementV2ResponseIncludedItemDiscriminatorType), TypeInfoPropertyName = "GameCenterAchievementV2ResponseIncludedItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementV2CreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementV2CreateRequestData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementV2CreateRequestDataType), TypeInfoPropertyName = "GameCenterAchievementV2CreateRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementV2CreateRequestDataAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementV2CreateRequestDataRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementV2CreateRequestDataRelationshipsGameCenterDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementV2CreateRequestDataRelationshipsGameCenterDetailData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementV2CreateRequestDataRelationshipsGameCenterDetailDataType), TypeInfoPropertyName = "GameCenterAchievementV2CreateRequestDataRelationshipsGameCenterDetailDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementV2CreateRequestDataRelationshipsGameCenterGroup))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementV2CreateRequestDataRelationshipsGameCenterGroupData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementV2CreateRequestDataRelationshipsGameCenterGroupDataType), TypeInfoPropertyName = "GameCenterAchievementV2CreateRequestDataRelationshipsGameCenterGroupDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementV2CreateRequestDataRelationshipsVersions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAchievementV2CreateRequestDataRelationshipsVersionsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementV2CreateRequestDataRelationshipsVersionsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementV2CreateRequestDataRelationshipsVersionsDataItemType), TypeInfoPropertyName = "GameCenterAchievementV2CreateRequestDataRelationshipsVersionsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAchievementVersionV2InlineCreate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementV2UpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementV2UpdateRequestData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementV2UpdateRequestDataType), TypeInfoPropertyName = "GameCenterAchievementV2UpdateRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementV2UpdateRequestDataAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementType), TypeInfoPropertyName = "GameCenterAchievementType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementRelationshipsGameCenterDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementRelationshipsGameCenterDetailData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementRelationshipsGameCenterDetailDataType), TypeInfoPropertyName = "GameCenterAchievementRelationshipsGameCenterDetailDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementRelationshipsGameCenterGroup))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementRelationshipsGameCenterGroupData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementRelationshipsGameCenterGroupDataType), TypeInfoPropertyName = "GameCenterAchievementRelationshipsGameCenterGroupDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementRelationshipsGroupAchievement))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementRelationshipsGroupAchievementData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementRelationshipsGroupAchievementDataType), TypeInfoPropertyName = "GameCenterAchievementRelationshipsGroupAchievementDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementRelationshipsLocalizations))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAchievementRelationshipsLocalizationsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementRelationshipsLocalizationsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementRelationshipsLocalizationsDataItemType), TypeInfoPropertyName = "GameCenterAchievementRelationshipsLocalizationsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementRelationshipsReleases))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAchievementRelationshipsReleasesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementRelationshipsReleasesDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementRelationshipsReleasesDataItemType), TypeInfoPropertyName = "GameCenterAchievementRelationshipsReleasesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementRelationshipsActivity))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementRelationshipsActivityData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementRelationshipsActivityDataType), TypeInfoPropertyName = "GameCenterAchievementRelationshipsActivityDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem85), TypeInfoPropertyName = "IncludedItem852")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.IncludedItem86>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem86), TypeInfoPropertyName = "IncludedItem862")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementResponseIncludedItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementResponseIncludedItemDiscriminatorType), TypeInfoPropertyName = "GameCenterAchievementResponseIncludedItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementCreateRequestData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementCreateRequestDataType), TypeInfoPropertyName = "GameCenterAchievementCreateRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementCreateRequestDataAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementCreateRequestDataRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementCreateRequestDataRelationshipsGameCenterDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementCreateRequestDataRelationshipsGameCenterDetailData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementCreateRequestDataRelationshipsGameCenterDetailDataType), TypeInfoPropertyName = "GameCenterAchievementCreateRequestDataRelationshipsGameCenterDetailDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementCreateRequestDataRelationshipsGameCenterGroup))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementCreateRequestDataRelationshipsGameCenterGroupData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementCreateRequestDataRelationshipsGameCenterGroupDataType), TypeInfoPropertyName = "GameCenterAchievementCreateRequestDataRelationshipsGameCenterGroupDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementUpdateRequestData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementUpdateRequestDataType), TypeInfoPropertyName = "GameCenterAchievementUpdateRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementUpdateRequestDataAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterActivityType), TypeInfoPropertyName = "GameCenterActivityType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterActivityAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterActivityAttributesPlayStyle), TypeInfoPropertyName = "GameCenterActivityAttributesPlayStyle2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterActivityRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterActivityRelationshipsGameCenterDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterActivityRelationshipsGameCenterDetailData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterActivityRelationshipsGameCenterDetailDataType), TypeInfoPropertyName = "GameCenterActivityRelationshipsGameCenterDetailDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterActivityRelationshipsGameCenterGroup))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterActivityRelationshipsGameCenterGroupData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterActivityRelationshipsGameCenterGroupDataType), TypeInfoPropertyName = "GameCenterActivityRelationshipsGameCenterGroupDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterActivityRelationshipsAchievements))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterActivityRelationshipsAchievementsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterActivityRelationshipsAchievementsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterActivityRelationshipsAchievementsDataItemType), TypeInfoPropertyName = "GameCenterActivityRelationshipsAchievementsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterActivityRelationshipsAchievementsV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterActivityRelationshipsAchievementsV2DataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterActivityRelationshipsAchievementsV2DataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterActivityRelationshipsAchievementsV2DataItemType), TypeInfoPropertyName = "GameCenterActivityRelationshipsAchievementsV2DataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterActivityRelationshipsLeaderboards))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterActivityRelationshipsLeaderboardsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterActivityRelationshipsLeaderboardsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterActivityRelationshipsLeaderboardsDataItemType), TypeInfoPropertyName = "GameCenterActivityRelationshipsLeaderboardsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterActivityRelationshipsLeaderboardsV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterActivityRelationshipsLeaderboardsV2DataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterActivityRelationshipsLeaderboardsV2DataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterActivityRelationshipsLeaderboardsV2DataItemType), TypeInfoPropertyName = "GameCenterActivityRelationshipsLeaderboardsV2DataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterActivityRelationshipsVersions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterActivityRelationshipsVersionsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterActivityRelationshipsVersionsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterActivityRelationshipsVersionsDataItemType), TypeInfoPropertyName = "GameCenterActivityRelationshipsVersionsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem87), TypeInfoPropertyName = "IncludedItem872")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterActivityVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboard))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem88), TypeInfoPropertyName = "IncludedItem882")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterActivityImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterActivityLocalization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem89), TypeInfoPropertyName = "IncludedItem892")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem90), TypeInfoPropertyName = "IncludedItem902")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterActivityVersionRelease))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem91), TypeInfoPropertyName = "IncludedItem912")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem92), TypeInfoPropertyName = "IncludedItem922")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem93), TypeInfoPropertyName = "IncludedItem932")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem94), TypeInfoPropertyName = "IncludedItem942")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterChallengeImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterChallengeLocalization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem95), TypeInfoPropertyName = "IncludedItem952")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterChallengeVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem96), TypeInfoPropertyName = "IncludedItem962")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterChallengeVersionRelease))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem97), TypeInfoPropertyName = "IncludedItem972")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterChallenge))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem98), TypeInfoPropertyName = "IncludedItem982")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem99), TypeInfoPropertyName = "IncludedItem992")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem100), TypeInfoPropertyName = "IncludedItem1002")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailType), TypeInfoPropertyName = "GameCenterDetailType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsApp))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsAppData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsAppDataType), TypeInfoPropertyName = "GameCenterDetailRelationshipsAppDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterAppVersions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterAppVersionsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterAppVersionsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterAppVersionsDataItemType), TypeInfoPropertyName = "GameCenterDetailRelationshipsGameCenterAppVersionsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterGroup))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterGroupData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterGroupDataType), TypeInfoPropertyName = "GameCenterDetailRelationshipsGameCenterGroupDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterLeaderboards))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterLeaderboardsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterLeaderboardsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterLeaderboardsDataItemType), TypeInfoPropertyName = "GameCenterDetailRelationshipsGameCenterLeaderboardsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterLeaderboardsV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterLeaderboardsV2DataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterLeaderboardsV2DataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterLeaderboardsV2DataItemType), TypeInfoPropertyName = "GameCenterDetailRelationshipsGameCenterLeaderboardsV2DataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterLeaderboardSets))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterLeaderboardSetsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterLeaderboardSetsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterLeaderboardSetsDataItemType), TypeInfoPropertyName = "GameCenterDetailRelationshipsGameCenterLeaderboardSetsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterLeaderboardSetsV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterLeaderboardSetsV2DataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterLeaderboardSetsV2DataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterLeaderboardSetsV2DataItemType), TypeInfoPropertyName = "GameCenterDetailRelationshipsGameCenterLeaderboardSetsV2DataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterAchievements))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterAchievementsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterAchievementsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterAchievementsDataItemType), TypeInfoPropertyName = "GameCenterDetailRelationshipsGameCenterAchievementsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterAchievementsV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterAchievementsV2DataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterAchievementsV2DataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterAchievementsV2DataItemType), TypeInfoPropertyName = "GameCenterDetailRelationshipsGameCenterAchievementsV2DataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterActivities))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterActivitiesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterActivitiesDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterActivitiesDataItemType), TypeInfoPropertyName = "GameCenterDetailRelationshipsGameCenterActivitiesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterChallenges))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterChallengesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterChallengesDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterChallengesDataItemType), TypeInfoPropertyName = "GameCenterDetailRelationshipsGameCenterChallengesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsDefaultLeaderboard))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsDefaultLeaderboardData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsDefaultLeaderboardDataType), TypeInfoPropertyName = "GameCenterDetailRelationshipsDefaultLeaderboardDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsDefaultLeaderboardV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsDefaultLeaderboardV2Data))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsDefaultLeaderboardV2DataType), TypeInfoPropertyName = "GameCenterDetailRelationshipsDefaultLeaderboardV2DataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsDefaultGroupLeaderboard))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsDefaultGroupLeaderboardData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsDefaultGroupLeaderboardDataType), TypeInfoPropertyName = "GameCenterDetailRelationshipsDefaultGroupLeaderboardDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsDefaultGroupLeaderboardV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsDefaultGroupLeaderboardV2Data))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsDefaultGroupLeaderboardV2DataType), TypeInfoPropertyName = "GameCenterDetailRelationshipsDefaultGroupLeaderboardV2DataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsAchievementReleases))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailRelationshipsAchievementReleasesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsAchievementReleasesDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsAchievementReleasesDataItemType), TypeInfoPropertyName = "GameCenterDetailRelationshipsAchievementReleasesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsActivityReleases))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailRelationshipsActivityReleasesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsActivityReleasesDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsActivityReleasesDataItemType), TypeInfoPropertyName = "GameCenterDetailRelationshipsActivityReleasesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsChallengeReleases))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailRelationshipsChallengeReleasesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsChallengeReleasesDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsChallengeReleasesDataItemType), TypeInfoPropertyName = "GameCenterDetailRelationshipsChallengeReleasesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsLeaderboardReleases))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailRelationshipsLeaderboardReleasesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsLeaderboardReleasesDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsLeaderboardReleasesDataItemType), TypeInfoPropertyName = "GameCenterDetailRelationshipsLeaderboardReleasesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsLeaderboardSetReleases))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailRelationshipsLeaderboardSetReleasesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsLeaderboardSetReleasesDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsLeaderboardSetReleasesDataItemType), TypeInfoPropertyName = "GameCenterDetailRelationshipsLeaderboardSetReleasesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsBlockedPlayers))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsChallengesMinimumPlatformVersions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailRelationshipsChallengesMinimumPlatformVersionsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsChallengesMinimumPlatformVersionsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsChallengesMinimumPlatformVersionsDataItemType), TypeInfoPropertyName = "GameCenterDetailRelationshipsChallengesMinimumPlatformVersionsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem101), TypeInfoPropertyName = "IncludedItem1012")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardRelease))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetRelease))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSet))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem102), TypeInfoPropertyName = "IncludedItem1022")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem103), TypeInfoPropertyName = "IncludedItem1032")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupType), TypeInfoPropertyName = "GameCenterGroupType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterDetailsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterDetailsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterDetailsDataItemType), TypeInfoPropertyName = "GameCenterGroupRelationshipsGameCenterDetailsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterLeaderboards))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterLeaderboardsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterLeaderboardsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterLeaderboardsDataItemType), TypeInfoPropertyName = "GameCenterGroupRelationshipsGameCenterLeaderboardsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterLeaderboardsV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterLeaderboardsV2DataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterLeaderboardsV2DataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterLeaderboardsV2DataItemType), TypeInfoPropertyName = "GameCenterGroupRelationshipsGameCenterLeaderboardsV2DataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterLeaderboardSets))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterLeaderboardSetsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterLeaderboardSetsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterLeaderboardSetsDataItemType), TypeInfoPropertyName = "GameCenterGroupRelationshipsGameCenterLeaderboardSetsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterLeaderboardSetsV2))]
    internal sealed partial class GameCenterAchievementsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }

    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterLeaderboardSetsV2DataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterLeaderboardSetsV2DataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterLeaderboardSetsV2DataItemType), TypeInfoPropertyName = "GameCenterGroupRelationshipsGameCenterLeaderboardSetsV2DataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterAchievements))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterAchievementsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterAchievementsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterAchievementsDataItemType), TypeInfoPropertyName = "GameCenterGroupRelationshipsGameCenterAchievementsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterAchievementsV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterAchievementsV2DataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterAchievementsV2DataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterAchievementsV2DataItemType), TypeInfoPropertyName = "GameCenterGroupRelationshipsGameCenterAchievementsV2DataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterActivities))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterActivitiesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterActivitiesDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterActivitiesDataItemType), TypeInfoPropertyName = "GameCenterGroupRelationshipsGameCenterActivitiesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterChallenges))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterChallengesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterChallengesDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterChallengesDataItemType), TypeInfoPropertyName = "GameCenterGroupRelationshipsGameCenterChallengesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem104), TypeInfoPropertyName = "IncludedItem1042")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem105), TypeInfoPropertyName = "IncludedItem1052")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardLocalization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardImageV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardLocalizationV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem106), TypeInfoPropertyName = "IncludedItem1062")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem107), TypeInfoPropertyName = "IncludedItem1072")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem108), TypeInfoPropertyName = "IncludedItem1082")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardVersionV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem109), TypeInfoPropertyName = "IncludedItem1092")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem110), TypeInfoPropertyName = "IncludedItem1102")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem111), TypeInfoPropertyName = "IncludedItem1112")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetLocalization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetImageV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetLocalizationV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem112), TypeInfoPropertyName = "IncludedItem1122")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem113), TypeInfoPropertyName = "IncludedItem1132")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem114), TypeInfoPropertyName = "IncludedItem1142")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetVersionV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem115), TypeInfoPropertyName = "IncludedItem1152")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem116), TypeInfoPropertyName = "IncludedItem1162")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem117), TypeInfoPropertyName = "IncludedItem1172")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem118), TypeInfoPropertyName = "IncludedItem1182")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem119), TypeInfoPropertyName = "IncludedItem1192")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem120), TypeInfoPropertyName = "IncludedItem1202")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem121), TypeInfoPropertyName = "IncludedItem1212")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem122), TypeInfoPropertyName = "IncludedItem1222")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem123), TypeInfoPropertyName = "IncludedItem1232")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem124), TypeInfoPropertyName = "IncludedItem1242")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem125), TypeInfoPropertyName = "IncludedItem1252")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem126), TypeInfoPropertyName = "IncludedItem1262")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem127), TypeInfoPropertyName = "IncludedItem1272")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem128), TypeInfoPropertyName = "IncludedItem1282")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem129), TypeInfoPropertyName = "IncludedItem1292")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem130), TypeInfoPropertyName = "IncludedItem1302")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem131), TypeInfoPropertyName = "IncludedItem1312")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.InAppPurchaseAppStoreReviewScreenshot))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.InAppPurchaseV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.InAppPurchaseAvailability))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.InAppPurchaseContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.InAppPurchaseImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.InAppPurchaseImageV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.InAppPurchaseLocalization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.InAppPurchaseLocalizationV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.InAppPurchaseVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.InAppPurchaseOfferCode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem138), TypeInfoPropertyName = "IncludedItem1382")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.InAppPurchasePricePoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.InAppPurchasePriceSchedule))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem139), TypeInfoPropertyName = "IncludedItem1392")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.InAppPurchasePrice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem141), TypeInfoPropertyName = "IncludedItem1412")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem142), TypeInfoPropertyName = "IncludedItem1422")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem143), TypeInfoPropertyName = "IncludedItem1432")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem144), TypeInfoPropertyName = "IncludedItem1442")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem145), TypeInfoPropertyName = "IncludedItem1452")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem146), TypeInfoPropertyName = "IncludedItem1462")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem147), TypeInfoPropertyName = "IncludedItem1472")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem148), TypeInfoPropertyName = "IncludedItem1482")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem149), TypeInfoPropertyName = "IncludedItem1492")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem150), TypeInfoPropertyName = "IncludedItem1502")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem151), TypeInfoPropertyName = "IncludedItem1512")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem152), TypeInfoPropertyName = "IncludedItem1522")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.Subscription))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem153), TypeInfoPropertyName = "IncludedItem1532")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem154), TypeInfoPropertyName = "IncludedItem1542")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem155), TypeInfoPropertyName = "IncludedItem1552")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem156), TypeInfoPropertyName = "IncludedItem1562")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem157), TypeInfoPropertyName = "IncludedItem1572")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ScmProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem158), TypeInfoPropertyName = "IncludedItem1582")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem159), TypeInfoPropertyName = "IncludedItem1592")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionAppStoreReviewScreenshot))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionAvailability))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupLocalizationV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupLocalization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem160), TypeInfoPropertyName = "IncludedItem1602")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem161), TypeInfoPropertyName = "IncludedItem1612")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem162), TypeInfoPropertyName = "IncludedItem1622")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem163), TypeInfoPropertyName = "IncludedItem1632")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionImageV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionIntroductoryOffer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem164), TypeInfoPropertyName = "IncludedItem1642")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPricePoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem165), TypeInfoPropertyName = "IncludedItem1652")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionLocalizationV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionLocalization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionOfferCodeCustomCode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionOfferCode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionOfferCodeOneTimeUseCode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionOfferCodePrice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem166), TypeInfoPropertyName = "IncludedItem1662")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem167), TypeInfoPropertyName = "IncludedItem1672")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem168), TypeInfoPropertyName = "IncludedItem1682")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPlanAvailability))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPrice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem169), TypeInfoPropertyName = "IncludedItem1692")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem170), TypeInfoPropertyName = "IncludedItem1702")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPromotionalOfferPrice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem171), TypeInfoPropertyName = "IncludedItem1712")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPromotionalOffer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem172), TypeInfoPropertyName = "IncludedItem1722")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem173), TypeInfoPropertyName = "IncludedItem1732")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem174), TypeInfoPropertyName = "IncludedItem1742")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem175), TypeInfoPropertyName = "IncludedItem1752")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem176), TypeInfoPropertyName = "IncludedItem1762")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.WinBackOffer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem177), TypeInfoPropertyName = "IncludedItem1772")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem179), TypeInfoPropertyName = "IncludedItem1792")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementV2ActivityLinkageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementV2ActivityLinkageRequestData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementV2ActivityLinkageRequestDataType), TypeInfoPropertyName = "GameCenterAchievementV2ActivityLinkageRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementV2VersionsLinkagesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAchievementV2VersionsLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementV2VersionsLinkagesResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementV2VersionsLinkagesResponseDataItemType), TypeInfoPropertyName = "GameCenterAchievementV2VersionsLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementActivityLinkageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementActivityLinkageRequestData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementActivityLinkageRequestDataType), TypeInfoPropertyName = "GameCenterAchievementActivityLinkageRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementGroupAchievementLinkageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementGroupAchievementLinkageResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementGroupAchievementLinkageResponseDataType), TypeInfoPropertyName = "GameCenterAchievementGroupAchievementLinkageResponseDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementGroupAchievementLinkageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementGroupAchievementLinkageRequestData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementGroupAchievementLinkageRequestDataType), TypeInfoPropertyName = "GameCenterAchievementGroupAchievementLinkageRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementLocalizationsLinkagesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAchievementLocalizationsLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementLocalizationsLinkagesResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementLocalizationsLinkagesResponseDataItemType), TypeInfoPropertyName = "GameCenterAchievementLocalizationsLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementReleasesLinkagesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAchievementReleasesLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementReleasesLinkagesResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementReleasesLinkagesResponseDataItemType), TypeInfoPropertyName = "GameCenterAchievementReleasesLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.ErrorResponseError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ErrorResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.OneOf<global::AppStoreConnect.ErrorSourcePointer, global::AppStoreConnect.ErrorSourceParameter>), TypeInfoPropertyName = "OneOfErrorSourcePointerErrorSourceParameter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ErrorSourcePointer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ErrorSourceParameter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ErrorLinks))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.OneOf<string, global::AppStoreConnect.ErrorLinksAssociated>), TypeInfoPropertyName = "OneOfStringErrorLinksAssociated2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ErrorLinksAssociated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ErrorLinksAssociatedMeta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.PagingInformationPaging))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppMediaStateError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppMediaStateError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppMediaAssetStateState), TypeInfoPropertyName = "AppMediaAssetStateState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.HttpHeader>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.HttpHeader))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAchievementsV2GetInstanceFieldsGameCenterAchievement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementsV2GetInstanceFieldsGameCenterAchievement), TypeInfoPropertyName = "GameCenterAchievementsV2GetInstanceFieldsGameCenterAchievement2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAchievementsV2GetInstanceFieldsGameCenterDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementsV2GetInstanceFieldsGameCenterDetail), TypeInfoPropertyName = "GameCenterAchievementsV2GetInstanceFieldsGameCenterDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAchievementsV2GetInstanceFieldsGameCenterGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementsV2GetInstanceFieldsGameCenterGroup), TypeInfoPropertyName = "GameCenterAchievementsV2GetInstanceFieldsGameCenterGroup2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAchievementsV2GetInstanceFieldsGameCenterActivitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementsV2GetInstanceFieldsGameCenterActivitie), TypeInfoPropertyName = "GameCenterAchievementsV2GetInstanceFieldsGameCenterActivitie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAchievementsV2GetInstanceFieldsGameCenterAchievementVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementsV2GetInstanceFieldsGameCenterAchievementVersion), TypeInfoPropertyName = "GameCenterAchievementsV2GetInstanceFieldsGameCenterAchievementVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAchievementsV2GetInstanceIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementsV2GetInstanceIncludeItem), TypeInfoPropertyName = "GameCenterAchievementsV2GetInstanceIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAchievementsGetInstanceFieldsGameCenterAchievement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementsGetInstanceFieldsGameCenterAchievement), TypeInfoPropertyName = "GameCenterAchievementsGetInstanceFieldsGameCenterAchievement2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAchievementsGetInstanceFieldsGameCenterDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementsGetInstanceFieldsGameCenterDetail), TypeInfoPropertyName = "GameCenterAchievementsGetInstanceFieldsGameCenterDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAchievementsGetInstanceFieldsGameCenterGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementsGetInstanceFieldsGameCenterGroup), TypeInfoPropertyName = "GameCenterAchievementsGetInstanceFieldsGameCenterGroup2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAchievementsGetInstanceFieldsGameCenterAchievementLocalization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementsGetInstanceFieldsGameCenterAchievementLocalization), TypeInfoPropertyName = "GameCenterAchievementsGetInstanceFieldsGameCenterAchievementLocalization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAchievementsGetInstanceFieldsGameCenterAchievementRelease>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementsGetInstanceFieldsGameCenterAchievementRelease), TypeInfoPropertyName = "GameCenterAchievementsGetInstanceFieldsGameCenterAchievementRelease2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAchievementsGetInstanceFieldsGameCenterActivitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementsGetInstanceFieldsGameCenterActivitie), TypeInfoPropertyName = "GameCenterAchievementsGetInstanceFieldsGameCenterActivitie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAchievementsGetInstanceIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementsGetInstanceIncludeItem), TypeInfoPropertyName = "GameCenterAchievementsGetInstanceIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievementVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievementVersion), TypeInfoPropertyName = "GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievementVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievement), TypeInfoPropertyName = "GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievement2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievementLocalization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievementLocalization), TypeInfoPropertyName = "GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievementLocalization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAchievementsV2VersionsGetToManyRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementsV2VersionsGetToManyRelatedIncludeItem), TypeInfoPropertyName = "GameCenterAchievementsV2VersionsGetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterAchievement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterAchievement), TypeInfoPropertyName = "GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterAchievement2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterDetail), TypeInfoPropertyName = "GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterGroup), TypeInfoPropertyName = "GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterGroup2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterAchievementLocalization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterAchievementLocalization), TypeInfoPropertyName = "GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterAchievementLocalization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterAchievementRelease>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterAchievementRelease), TypeInfoPropertyName = "GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterAchievementRelease2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterActivitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterActivitie), TypeInfoPropertyName = "GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterActivitie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAchievementsGroupAchievementGetToOneRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementsGroupAchievementGetToOneRelatedIncludeItem), TypeInfoPropertyName = "GameCenterAchievementsGroupAchievementGetToOneRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAchievementsLocalizationsGetToManyRelatedFieldsGameCenterAchievementLocalization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementsLocalizationsGetToManyRelatedFieldsGameCenterAchievementLocalization), TypeInfoPropertyName = "GameCenterAchievementsLocalizationsGetToManyRelatedFieldsGameCenterAchievementLocalization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAchievementsLocalizationsGetToManyRelatedFieldsGameCenterAchievement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementsLocalizationsGetToManyRelatedFieldsGameCenterAchievement), TypeInfoPropertyName = "GameCenterAchievementsLocalizationsGetToManyRelatedFieldsGameCenterAchievement2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAchievementsLocalizationsGetToManyRelatedFieldsGameCenterAchievementImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementsLocalizationsGetToManyRelatedFieldsGameCenterAchievementImage), TypeInfoPropertyName = "GameCenterAchievementsLocalizationsGetToManyRelatedFieldsGameCenterAchievementImage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAchievementsLocalizationsGetToManyRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementsLocalizationsGetToManyRelatedIncludeItem), TypeInfoPropertyName = "GameCenterAchievementsLocalizationsGetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAchievementsReleasesGetToManyRelatedFieldsGameCenterAchievementRelease>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementsReleasesGetToManyRelatedFieldsGameCenterAchievementRelease), TypeInfoPropertyName = "GameCenterAchievementsReleasesGetToManyRelatedFieldsGameCenterAchievementRelease2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAchievementsReleasesGetToManyRelatedFieldsGameCenterDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementsReleasesGetToManyRelatedFieldsGameCenterDetail), TypeInfoPropertyName = "GameCenterAchievementsReleasesGetToManyRelatedFieldsGameCenterDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAchievementsReleasesGetToManyRelatedFieldsGameCenterAchievement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementsReleasesGetToManyRelatedFieldsGameCenterAchievement), TypeInfoPropertyName = "GameCenterAchievementsReleasesGetToManyRelatedFieldsGameCenterAchievement2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAchievementsReleasesGetToManyRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementsReleasesGetToManyRelatedIncludeItem), TypeInfoPropertyName = "GameCenterAchievementsReleasesGetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem?), TypeInfoPropertyName = "NullableIncludedItem2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem2?), TypeInfoPropertyName = "NullableIncludedItem22_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem3?), TypeInfoPropertyName = "NullableIncludedItem32_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem4?), TypeInfoPropertyName = "NullableIncludedItem42_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem5?), TypeInfoPropertyName = "NullableIncludedItem52_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem6?), TypeInfoPropertyName = "NullableIncludedItem62_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem7?), TypeInfoPropertyName = "NullableIncludedItem72_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem8?), TypeInfoPropertyName = "NullableIncludedItem82_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem9?), TypeInfoPropertyName = "NullableIncludedItem92_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem10?), TypeInfoPropertyName = "NullableIncludedItem102_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem11?), TypeInfoPropertyName = "NullableIncludedItem112_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem12?), TypeInfoPropertyName = "NullableIncludedItem122_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem13?), TypeInfoPropertyName = "NullableIncludedItem132")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem14?), TypeInfoPropertyName = "NullableIncludedItem142_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem15?), TypeInfoPropertyName = "NullableIncludedItem152_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem16?), TypeInfoPropertyName = "NullableIncludedItem162_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem18?), TypeInfoPropertyName = "NullableIncludedItem182")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem19?), TypeInfoPropertyName = "NullableIncludedItem192")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem20?), TypeInfoPropertyName = "NullableIncludedItem202")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem21?), TypeInfoPropertyName = "NullableIncludedItem212")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem22?), TypeInfoPropertyName = "NullableIncludedItem222")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem23?), TypeInfoPropertyName = "NullableIncludedItem232")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem24?), TypeInfoPropertyName = "NullableIncludedItem242")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem25?), TypeInfoPropertyName = "NullableIncludedItem252")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem26?), TypeInfoPropertyName = "NullableIncludedItem262")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem27?), TypeInfoPropertyName = "NullableIncludedItem272")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem28?), TypeInfoPropertyName = "NullableIncludedItem282")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem30?), TypeInfoPropertyName = "NullableIncludedItem302")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem31?), TypeInfoPropertyName = "NullableIncludedItem312")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem32?), TypeInfoPropertyName = "NullableIncludedItem322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem33?), TypeInfoPropertyName = "NullableIncludedItem332")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem34?), TypeInfoPropertyName = "NullableIncludedItem342")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem35?), TypeInfoPropertyName = "NullableIncludedItem352")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem36?), TypeInfoPropertyName = "NullableIncludedItem362")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem37?), TypeInfoPropertyName = "NullableIncludedItem372")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem38?), TypeInfoPropertyName = "NullableIncludedItem382")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem39?), TypeInfoPropertyName = "NullableIncludedItem392")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem40?), TypeInfoPropertyName = "NullableIncludedItem402")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem41?), TypeInfoPropertyName = "NullableIncludedItem412")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem42?), TypeInfoPropertyName = "NullableIncludedItem422")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem43?), TypeInfoPropertyName = "NullableIncludedItem432")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem44?), TypeInfoPropertyName = "NullableIncludedItem442")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem45?), TypeInfoPropertyName = "NullableIncludedItem452")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem46?), TypeInfoPropertyName = "NullableIncludedItem462")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem47?), TypeInfoPropertyName = "NullableIncludedItem472")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem50?), TypeInfoPropertyName = "NullableIncludedItem502")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem51?), TypeInfoPropertyName = "NullableIncludedItem512")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem52?), TypeInfoPropertyName = "NullableIncludedItem522")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem53?), TypeInfoPropertyName = "NullableIncludedItem532")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem54?), TypeInfoPropertyName = "NullableIncludedItem542")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem55?), TypeInfoPropertyName = "NullableIncludedItem552")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem56?), TypeInfoPropertyName = "NullableIncludedItem562")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem57?), TypeInfoPropertyName = "NullableIncludedItem572")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem58?), TypeInfoPropertyName = "NullableIncludedItem582")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem59?), TypeInfoPropertyName = "NullableIncludedItem592")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem60?), TypeInfoPropertyName = "NullableIncludedItem602")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem61?), TypeInfoPropertyName = "NullableIncludedItem612")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem62?), TypeInfoPropertyName = "NullableIncludedItem622")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem63?), TypeInfoPropertyName = "NullableIncludedItem632")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem64?), TypeInfoPropertyName = "NullableIncludedItem642")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem65?), TypeInfoPropertyName = "NullableIncludedItem652")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem66?), TypeInfoPropertyName = "NullableIncludedItem662")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem67?), TypeInfoPropertyName = "NullableIncludedItem672")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem68?), TypeInfoPropertyName = "NullableIncludedItem682")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem69?), TypeInfoPropertyName = "NullableIncludedItem692")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem70?), TypeInfoPropertyName = "NullableIncludedItem702")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem71?), TypeInfoPropertyName = "NullableIncludedItem712")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem72?), TypeInfoPropertyName = "NullableIncludedItem722")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem73?), TypeInfoPropertyName = "NullableIncludedItem732")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem74?), TypeInfoPropertyName = "NullableIncludedItem742")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementImageType?), TypeInfoPropertyName = "NullableGameCenterAchievementImageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementImageRelationshipsGameCenterAchievementLocalizationDataType?), TypeInfoPropertyName = "NullableGameCenterAchievementImageRelationshipsGameCenterAchievementLocalizationDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementLocalizationV2Type?), TypeInfoPropertyName = "NullableGameCenterAchievementLocalizationV2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementLocalizationV2RelationshipsVersionDataType?), TypeInfoPropertyName = "NullableGameCenterAchievementLocalizationV2RelationshipsVersionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementLocalizationV2RelationshipsImageDataType?), TypeInfoPropertyName = "NullableGameCenterAchievementLocalizationV2RelationshipsImageDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem75?), TypeInfoPropertyName = "NullableIncludedItem752")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem76?), TypeInfoPropertyName = "NullableIncludedItem762")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementLocalizationType?), TypeInfoPropertyName = "NullableGameCenterAchievementLocalizationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementLocalizationRelationshipsGameCenterAchievementDataType?), TypeInfoPropertyName = "NullableGameCenterAchievementLocalizationRelationshipsGameCenterAchievementDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementLocalizationRelationshipsGameCenterAchievementImageDataType?), TypeInfoPropertyName = "NullableGameCenterAchievementLocalizationRelationshipsGameCenterAchievementImageDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem77?), TypeInfoPropertyName = "NullableIncludedItem772")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementLocalizationsResponseIncludedItemDiscriminatorType?), TypeInfoPropertyName = "NullableGameCenterAchievementLocalizationsResponseIncludedItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem78?), TypeInfoPropertyName = "NullableIncludedItem782")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementReleaseType?), TypeInfoPropertyName = "NullableGameCenterAchievementReleaseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementReleaseRelationshipsGameCenterDetailDataType?), TypeInfoPropertyName = "NullableGameCenterAchievementReleaseRelationshipsGameCenterDetailDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementReleaseRelationshipsGameCenterAchievementDataType?), TypeInfoPropertyName = "NullableGameCenterAchievementReleaseRelationshipsGameCenterAchievementDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem79?), TypeInfoPropertyName = "NullableIncludedItem792")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementReleasesResponseIncludedItemDiscriminatorType?), TypeInfoPropertyName = "NullableGameCenterAchievementReleasesResponseIncludedItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem80?), TypeInfoPropertyName = "NullableIncludedItem802")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementVersionV2Type?), TypeInfoPropertyName = "NullableGameCenterAchievementVersionV2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterVersionState?), TypeInfoPropertyName = "NullableGameCenterVersionState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementVersionV2RelationshipsAchievementDataType?), TypeInfoPropertyName = "NullableGameCenterAchievementVersionV2RelationshipsAchievementDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementVersionV2RelationshipsLocalizationsDataItemType?), TypeInfoPropertyName = "NullableGameCenterAchievementVersionV2RelationshipsLocalizationsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementVersionV2InlineCreateType?), TypeInfoPropertyName = "NullableGameCenterAchievementVersionV2InlineCreateType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementVersionV2InlineCreateRelationshipsAchievementDataType?), TypeInfoPropertyName = "NullableGameCenterAchievementVersionV2InlineCreateRelationshipsAchievementDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem81?), TypeInfoPropertyName = "NullableIncludedItem812")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementVersionsV2ResponseIncludedItemDiscriminatorType?), TypeInfoPropertyName = "NullableGameCenterAchievementVersionsV2ResponseIncludedItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem82?), TypeInfoPropertyName = "NullableIncludedItem822")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementV2Type?), TypeInfoPropertyName = "NullableGameCenterAchievementV2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementV2RelationshipsGameCenterDetailDataType?), TypeInfoPropertyName = "NullableGameCenterAchievementV2RelationshipsGameCenterDetailDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementV2RelationshipsGameCenterGroupDataType?), TypeInfoPropertyName = "NullableGameCenterAchievementV2RelationshipsGameCenterGroupDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementV2RelationshipsActivityDataType?), TypeInfoPropertyName = "NullableGameCenterAchievementV2RelationshipsActivityDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementV2RelationshipsVersionsDataItemType?), TypeInfoPropertyName = "NullableGameCenterAchievementV2RelationshipsVersionsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem83?), TypeInfoPropertyName = "NullableIncludedItem832")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem84?), TypeInfoPropertyName = "NullableIncludedItem842")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementV2ResponseIncludedItemDiscriminatorType?), TypeInfoPropertyName = "NullableGameCenterAchievementV2ResponseIncludedItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementV2CreateRequestDataType?), TypeInfoPropertyName = "NullableGameCenterAchievementV2CreateRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementV2CreateRequestDataRelationshipsGameCenterDetailDataType?), TypeInfoPropertyName = "NullableGameCenterAchievementV2CreateRequestDataRelationshipsGameCenterDetailDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementV2CreateRequestDataRelationshipsGameCenterGroupDataType?), TypeInfoPropertyName = "NullableGameCenterAchievementV2CreateRequestDataRelationshipsGameCenterGroupDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementV2CreateRequestDataRelationshipsVersionsDataItemType?), TypeInfoPropertyName = "NullableGameCenterAchievementV2CreateRequestDataRelationshipsVersionsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementV2UpdateRequestDataType?), TypeInfoPropertyName = "NullableGameCenterAchievementV2UpdateRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementType?), TypeInfoPropertyName = "NullableGameCenterAchievementType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementRelationshipsGameCenterDetailDataType?), TypeInfoPropertyName = "NullableGameCenterAchievementRelationshipsGameCenterDetailDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementRelationshipsGameCenterGroupDataType?), TypeInfoPropertyName = "NullableGameCenterAchievementRelationshipsGameCenterGroupDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementRelationshipsGroupAchievementDataType?), TypeInfoPropertyName = "NullableGameCenterAchievementRelationshipsGroupAchievementDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementRelationshipsLocalizationsDataItemType?), TypeInfoPropertyName = "NullableGameCenterAchievementRelationshipsLocalizationsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementRelationshipsReleasesDataItemType?), TypeInfoPropertyName = "NullableGameCenterAchievementRelationshipsReleasesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementRelationshipsActivityDataType?), TypeInfoPropertyName = "NullableGameCenterAchievementRelationshipsActivityDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem85?), TypeInfoPropertyName = "NullableIncludedItem852")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem86?), TypeInfoPropertyName = "NullableIncludedItem862")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementResponseIncludedItemDiscriminatorType?), TypeInfoPropertyName = "NullableGameCenterAchievementResponseIncludedItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementCreateRequestDataType?), TypeInfoPropertyName = "NullableGameCenterAchievementCreateRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementCreateRequestDataRelationshipsGameCenterDetailDataType?), TypeInfoPropertyName = "NullableGameCenterAchievementCreateRequestDataRelationshipsGameCenterDetailDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementCreateRequestDataRelationshipsGameCenterGroupDataType?), TypeInfoPropertyName = "NullableGameCenterAchievementCreateRequestDataRelationshipsGameCenterGroupDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementUpdateRequestDataType?), TypeInfoPropertyName = "NullableGameCenterAchievementUpdateRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterActivityType?), TypeInfoPropertyName = "NullableGameCenterActivityType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterActivityAttributesPlayStyle?), TypeInfoPropertyName = "NullableGameCenterActivityAttributesPlayStyle2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterActivityRelationshipsGameCenterDetailDataType?), TypeInfoPropertyName = "NullableGameCenterActivityRelationshipsGameCenterDetailDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterActivityRelationshipsGameCenterGroupDataType?), TypeInfoPropertyName = "NullableGameCenterActivityRelationshipsGameCenterGroupDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterActivityRelationshipsAchievementsDataItemType?), TypeInfoPropertyName = "NullableGameCenterActivityRelationshipsAchievementsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterActivityRelationshipsAchievementsV2DataItemType?), TypeInfoPropertyName = "NullableGameCenterActivityRelationshipsAchievementsV2DataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterActivityRelationshipsLeaderboardsDataItemType?), TypeInfoPropertyName = "NullableGameCenterActivityRelationshipsLeaderboardsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterActivityRelationshipsLeaderboardsV2DataItemType?), TypeInfoPropertyName = "NullableGameCenterActivityRelationshipsLeaderboardsV2DataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterActivityRelationshipsVersionsDataItemType?), TypeInfoPropertyName = "NullableGameCenterActivityRelationshipsVersionsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem87?), TypeInfoPropertyName = "NullableIncludedItem872")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem88?), TypeInfoPropertyName = "NullableIncludedItem882")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem89?), TypeInfoPropertyName = "NullableIncludedItem892")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem90?), TypeInfoPropertyName = "NullableIncludedItem902")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem91?), TypeInfoPropertyName = "NullableIncludedItem912")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem92?), TypeInfoPropertyName = "NullableIncludedItem922")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem93?), TypeInfoPropertyName = "NullableIncludedItem932")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem94?), TypeInfoPropertyName = "NullableIncludedItem942")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem95?), TypeInfoPropertyName = "NullableIncludedItem952")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem96?), TypeInfoPropertyName = "NullableIncludedItem962")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem97?), TypeInfoPropertyName = "NullableIncludedItem972")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem98?), TypeInfoPropertyName = "NullableIncludedItem982")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem99?), TypeInfoPropertyName = "NullableIncludedItem992")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem100?), TypeInfoPropertyName = "NullableIncludedItem1002")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailType?), TypeInfoPropertyName = "NullableGameCenterDetailType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsAppDataType?), TypeInfoPropertyName = "NullableGameCenterDetailRelationshipsAppDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterAppVersionsDataItemType?), TypeInfoPropertyName = "NullableGameCenterDetailRelationshipsGameCenterAppVersionsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterGroupDataType?), TypeInfoPropertyName = "NullableGameCenterDetailRelationshipsGameCenterGroupDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterLeaderboardsDataItemType?), TypeInfoPropertyName = "NullableGameCenterDetailRelationshipsGameCenterLeaderboardsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterLeaderboardsV2DataItemType?), TypeInfoPropertyName = "NullableGameCenterDetailRelationshipsGameCenterLeaderboardsV2DataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterLeaderboardSetsDataItemType?), TypeInfoPropertyName = "NullableGameCenterDetailRelationshipsGameCenterLeaderboardSetsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterLeaderboardSetsV2DataItemType?), TypeInfoPropertyName = "NullableGameCenterDetailRelationshipsGameCenterLeaderboardSetsV2DataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterAchievementsDataItemType?), TypeInfoPropertyName = "NullableGameCenterDetailRelationshipsGameCenterAchievementsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterAchievementsV2DataItemType?), TypeInfoPropertyName = "NullableGameCenterDetailRelationshipsGameCenterAchievementsV2DataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterActivitiesDataItemType?), TypeInfoPropertyName = "NullableGameCenterDetailRelationshipsGameCenterActivitiesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterChallengesDataItemType?), TypeInfoPropertyName = "NullableGameCenterDetailRelationshipsGameCenterChallengesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsDefaultLeaderboardDataType?), TypeInfoPropertyName = "NullableGameCenterDetailRelationshipsDefaultLeaderboardDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsDefaultLeaderboardV2DataType?), TypeInfoPropertyName = "NullableGameCenterDetailRelationshipsDefaultLeaderboardV2DataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsDefaultGroupLeaderboardDataType?), TypeInfoPropertyName = "NullableGameCenterDetailRelationshipsDefaultGroupLeaderboardDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsDefaultGroupLeaderboardV2DataType?), TypeInfoPropertyName = "NullableGameCenterDetailRelationshipsDefaultGroupLeaderboardV2DataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsAchievementReleasesDataItemType?), TypeInfoPropertyName = "NullableGameCenterDetailRelationshipsAchievementReleasesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsActivityReleasesDataItemType?), TypeInfoPropertyName = "NullableGameCenterDetailRelationshipsActivityReleasesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsChallengeReleasesDataItemType?), TypeInfoPropertyName = "NullableGameCenterDetailRelationshipsChallengeReleasesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsLeaderboardReleasesDataItemType?), TypeInfoPropertyName = "NullableGameCenterDetailRelationshipsLeaderboardReleasesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsLeaderboardSetReleasesDataItemType?), TypeInfoPropertyName = "NullableGameCenterDetailRelationshipsLeaderboardSetReleasesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsChallengesMinimumPlatformVersionsDataItemType?), TypeInfoPropertyName = "NullableGameCenterDetailRelationshipsChallengesMinimumPlatformVersionsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem101?), TypeInfoPropertyName = "NullableIncludedItem1012")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem102?), TypeInfoPropertyName = "NullableIncludedItem1022")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem103?), TypeInfoPropertyName = "NullableIncludedItem1032")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupType?), TypeInfoPropertyName = "NullableGameCenterGroupType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterDetailsDataItemType?), TypeInfoPropertyName = "NullableGameCenterGroupRelationshipsGameCenterDetailsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterLeaderboardsDataItemType?), TypeInfoPropertyName = "NullableGameCenterGroupRelationshipsGameCenterLeaderboardsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterLeaderboardsV2DataItemType?), TypeInfoPropertyName = "NullableGameCenterGroupRelationshipsGameCenterLeaderboardsV2DataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterLeaderboardSetsDataItemType?), TypeInfoPropertyName = "NullableGameCenterGroupRelationshipsGameCenterLeaderboardSetsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterLeaderboardSetsV2DataItemType?), TypeInfoPropertyName = "NullableGameCenterGroupRelationshipsGameCenterLeaderboardSetsV2DataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterAchievementsDataItemType?), TypeInfoPropertyName = "NullableGameCenterGroupRelationshipsGameCenterAchievementsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterAchievementsV2DataItemType?), TypeInfoPropertyName = "NullableGameCenterGroupRelationshipsGameCenterAchievementsV2DataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterActivitiesDataItemType?), TypeInfoPropertyName = "NullableGameCenterGroupRelationshipsGameCenterActivitiesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterChallengesDataItemType?), TypeInfoPropertyName = "NullableGameCenterGroupRelationshipsGameCenterChallengesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem104?), TypeInfoPropertyName = "NullableIncludedItem1042")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem105?), TypeInfoPropertyName = "NullableIncludedItem1052")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem106?), TypeInfoPropertyName = "NullableIncludedItem1062")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem107?), TypeInfoPropertyName = "NullableIncludedItem1072")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem108?), TypeInfoPropertyName = "NullableIncludedItem1082")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem109?), TypeInfoPropertyName = "NullableIncludedItem1092")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem110?), TypeInfoPropertyName = "NullableIncludedItem1102")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem111?), TypeInfoPropertyName = "NullableIncludedItem1112")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem112?), TypeInfoPropertyName = "NullableIncludedItem1122")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem113?), TypeInfoPropertyName = "NullableIncludedItem1132")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem114?), TypeInfoPropertyName = "NullableIncludedItem1142")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem115?), TypeInfoPropertyName = "NullableIncludedItem1152")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem116?), TypeInfoPropertyName = "NullableIncludedItem1162")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem117?), TypeInfoPropertyName = "NullableIncludedItem1172")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem118?), TypeInfoPropertyName = "NullableIncludedItem1182")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem119?), TypeInfoPropertyName = "NullableIncludedItem1192")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem120?), TypeInfoPropertyName = "NullableIncludedItem1202")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem121?), TypeInfoPropertyName = "NullableIncludedItem1212")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem122?), TypeInfoPropertyName = "NullableIncludedItem1222")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem123?), TypeInfoPropertyName = "NullableIncludedItem1232")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem124?), TypeInfoPropertyName = "NullableIncludedItem1242")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem125?), TypeInfoPropertyName = "NullableIncludedItem1252")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem126?), TypeInfoPropertyName = "NullableIncludedItem1262")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem127?), TypeInfoPropertyName = "NullableIncludedItem1272")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem128?), TypeInfoPropertyName = "NullableIncludedItem1282")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem129?), TypeInfoPropertyName = "NullableIncludedItem1292")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem130?), TypeInfoPropertyName = "NullableIncludedItem1302")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem131?), TypeInfoPropertyName = "NullableIncludedItem1312")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem138?), TypeInfoPropertyName = "NullableIncludedItem1382")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem139?), TypeInfoPropertyName = "NullableIncludedItem1392")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem141?), TypeInfoPropertyName = "NullableIncludedItem1412")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem142?), TypeInfoPropertyName = "NullableIncludedItem1422")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem143?), TypeInfoPropertyName = "NullableIncludedItem1432")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem144?), TypeInfoPropertyName = "NullableIncludedItem1442")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem145?), TypeInfoPropertyName = "NullableIncludedItem1452")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem146?), TypeInfoPropertyName = "NullableIncludedItem1462")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem147?), TypeInfoPropertyName = "NullableIncludedItem1472")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem148?), TypeInfoPropertyName = "NullableIncludedItem1482")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem149?), TypeInfoPropertyName = "NullableIncludedItem1492")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem150?), TypeInfoPropertyName = "NullableIncludedItem1502")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem151?), TypeInfoPropertyName = "NullableIncludedItem1512")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem152?), TypeInfoPropertyName = "NullableIncludedItem1522")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem153?), TypeInfoPropertyName = "NullableIncludedItem1532")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem154?), TypeInfoPropertyName = "NullableIncludedItem1542")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem155?), TypeInfoPropertyName = "NullableIncludedItem1552")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem156?), TypeInfoPropertyName = "NullableIncludedItem1562")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem157?), TypeInfoPropertyName = "NullableIncludedItem1572")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem158?), TypeInfoPropertyName = "NullableIncludedItem1582")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem159?), TypeInfoPropertyName = "NullableIncludedItem1592")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem160?), TypeInfoPropertyName = "NullableIncludedItem1602")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem161?), TypeInfoPropertyName = "NullableIncludedItem1612")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem162?), TypeInfoPropertyName = "NullableIncludedItem1622")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem163?), TypeInfoPropertyName = "NullableIncludedItem1632")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem164?), TypeInfoPropertyName = "NullableIncludedItem1642")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem165?), TypeInfoPropertyName = "NullableIncludedItem1652")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem166?), TypeInfoPropertyName = "NullableIncludedItem1662")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem167?), TypeInfoPropertyName = "NullableIncludedItem1672")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem168?), TypeInfoPropertyName = "NullableIncludedItem1682")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem169?), TypeInfoPropertyName = "NullableIncludedItem1692")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem170?), TypeInfoPropertyName = "NullableIncludedItem1702")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem171?), TypeInfoPropertyName = "NullableIncludedItem1712")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem172?), TypeInfoPropertyName = "NullableIncludedItem1722")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem173?), TypeInfoPropertyName = "NullableIncludedItem1732")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem174?), TypeInfoPropertyName = "NullableIncludedItem1742")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem175?), TypeInfoPropertyName = "NullableIncludedItem1752")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem176?), TypeInfoPropertyName = "NullableIncludedItem1762")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem177?), TypeInfoPropertyName = "NullableIncludedItem1772")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem179?), TypeInfoPropertyName = "NullableIncludedItem1792")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementV2ActivityLinkageRequestDataType?), TypeInfoPropertyName = "NullableGameCenterAchievementV2ActivityLinkageRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementV2VersionsLinkagesResponseDataItemType?), TypeInfoPropertyName = "NullableGameCenterAchievementV2VersionsLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementActivityLinkageRequestDataType?), TypeInfoPropertyName = "NullableGameCenterAchievementActivityLinkageRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementGroupAchievementLinkageResponseDataType?), TypeInfoPropertyName = "NullableGameCenterAchievementGroupAchievementLinkageResponseDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementGroupAchievementLinkageRequestDataType?), TypeInfoPropertyName = "NullableGameCenterAchievementGroupAchievementLinkageRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementLocalizationsLinkagesResponseDataItemType?), TypeInfoPropertyName = "NullableGameCenterAchievementLocalizationsLinkagesResponseDataItemType2")]
    internal sealed partial class GameCenterAchievementsSourceGenerationContextChunk1 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }

    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementReleasesLinkagesResponseDataItemType?), TypeInfoPropertyName = "NullableGameCenterAchievementReleasesLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.OneOf<global::AppStoreConnect.ErrorSourcePointer, global::AppStoreConnect.ErrorSourceParameter>?), TypeInfoPropertyName = "NullableOneOfErrorSourcePointerErrorSourceParameter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.OneOf<string, global::AppStoreConnect.ErrorLinksAssociated>?), TypeInfoPropertyName = "NullableOneOfStringErrorLinksAssociated2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppMediaAssetStateState?), TypeInfoPropertyName = "NullableAppMediaAssetStateState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementsV2GetInstanceFieldsGameCenterAchievement?), TypeInfoPropertyName = "NullableGameCenterAchievementsV2GetInstanceFieldsGameCenterAchievement2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementsV2GetInstanceFieldsGameCenterDetail?), TypeInfoPropertyName = "NullableGameCenterAchievementsV2GetInstanceFieldsGameCenterDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementsV2GetInstanceFieldsGameCenterGroup?), TypeInfoPropertyName = "NullableGameCenterAchievementsV2GetInstanceFieldsGameCenterGroup2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementsV2GetInstanceFieldsGameCenterActivitie?), TypeInfoPropertyName = "NullableGameCenterAchievementsV2GetInstanceFieldsGameCenterActivitie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementsV2GetInstanceFieldsGameCenterAchievementVersion?), TypeInfoPropertyName = "NullableGameCenterAchievementsV2GetInstanceFieldsGameCenterAchievementVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementsV2GetInstanceIncludeItem?), TypeInfoPropertyName = "NullableGameCenterAchievementsV2GetInstanceIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementsGetInstanceFieldsGameCenterAchievement?), TypeInfoPropertyName = "NullableGameCenterAchievementsGetInstanceFieldsGameCenterAchievement2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementsGetInstanceFieldsGameCenterDetail?), TypeInfoPropertyName = "NullableGameCenterAchievementsGetInstanceFieldsGameCenterDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementsGetInstanceFieldsGameCenterGroup?), TypeInfoPropertyName = "NullableGameCenterAchievementsGetInstanceFieldsGameCenterGroup2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementsGetInstanceFieldsGameCenterAchievementLocalization?), TypeInfoPropertyName = "NullableGameCenterAchievementsGetInstanceFieldsGameCenterAchievementLocalization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementsGetInstanceFieldsGameCenterAchievementRelease?), TypeInfoPropertyName = "NullableGameCenterAchievementsGetInstanceFieldsGameCenterAchievementRelease2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementsGetInstanceFieldsGameCenterActivitie?), TypeInfoPropertyName = "NullableGameCenterAchievementsGetInstanceFieldsGameCenterActivitie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementsGetInstanceIncludeItem?), TypeInfoPropertyName = "NullableGameCenterAchievementsGetInstanceIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievementVersion?), TypeInfoPropertyName = "NullableGameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievementVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievement?), TypeInfoPropertyName = "NullableGameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievement2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievementLocalization?), TypeInfoPropertyName = "NullableGameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievementLocalization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementsV2VersionsGetToManyRelatedIncludeItem?), TypeInfoPropertyName = "NullableGameCenterAchievementsV2VersionsGetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterAchievement?), TypeInfoPropertyName = "NullableGameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterAchievement2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterDetail?), TypeInfoPropertyName = "NullableGameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterGroup?), TypeInfoPropertyName = "NullableGameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterGroup2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterAchievementLocalization?), TypeInfoPropertyName = "NullableGameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterAchievementLocalization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterAchievementRelease?), TypeInfoPropertyName = "NullableGameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterAchievementRelease2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterActivitie?), TypeInfoPropertyName = "NullableGameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterActivitie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementsGroupAchievementGetToOneRelatedIncludeItem?), TypeInfoPropertyName = "NullableGameCenterAchievementsGroupAchievementGetToOneRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementsLocalizationsGetToManyRelatedFieldsGameCenterAchievementLocalization?), TypeInfoPropertyName = "NullableGameCenterAchievementsLocalizationsGetToManyRelatedFieldsGameCenterAchievementLocalization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementsLocalizationsGetToManyRelatedFieldsGameCenterAchievement?), TypeInfoPropertyName = "NullableGameCenterAchievementsLocalizationsGetToManyRelatedFieldsGameCenterAchievement2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementsLocalizationsGetToManyRelatedFieldsGameCenterAchievementImage?), TypeInfoPropertyName = "NullableGameCenterAchievementsLocalizationsGetToManyRelatedFieldsGameCenterAchievementImage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementsLocalizationsGetToManyRelatedIncludeItem?), TypeInfoPropertyName = "NullableGameCenterAchievementsLocalizationsGetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementsReleasesGetToManyRelatedFieldsGameCenterAchievementRelease?), TypeInfoPropertyName = "NullableGameCenterAchievementsReleasesGetToManyRelatedFieldsGameCenterAchievementRelease2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementsReleasesGetToManyRelatedFieldsGameCenterDetail?), TypeInfoPropertyName = "NullableGameCenterAchievementsReleasesGetToManyRelatedFieldsGameCenterDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementsReleasesGetToManyRelatedFieldsGameCenterAchievement?), TypeInfoPropertyName = "NullableGameCenterAchievementsReleasesGetToManyRelatedFieldsGameCenterAchievement2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementsReleasesGetToManyRelatedIncludeItem?), TypeInfoPropertyName = "NullableGameCenterAchievementsReleasesGetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.UploadOperation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterAchievementLocalization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.IncludedItem77>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterAchievementRelease>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.IncludedItem79>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterAchievementVersionV2RelationshipsLocalizationsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterAchievementVersionV2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.IncludedItem81>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterAchievementV2RelationshipsVersionsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.IncludedItem84>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterAchievementV2CreateRequestDataRelationshipsVersionsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterAchievementVersionV2InlineCreate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterAchievementRelationshipsLocalizationsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterAchievementRelationshipsReleasesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.IncludedItem86>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterActivityRelationshipsAchievementsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterActivityRelationshipsAchievementsV2DataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterActivityRelationshipsLeaderboardsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterActivityRelationshipsLeaderboardsV2DataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterActivityRelationshipsVersionsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterAppVersionsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterLeaderboardsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterLeaderboardsV2DataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterLeaderboardSetsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterLeaderboardSetsV2DataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterAchievementsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterAchievementsV2DataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterActivitiesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterChallengesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailRelationshipsAchievementReleasesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailRelationshipsActivityReleasesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailRelationshipsChallengeReleasesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailRelationshipsLeaderboardReleasesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailRelationshipsLeaderboardSetReleasesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailRelationshipsChallengesMinimumPlatformVersionsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterDetailsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterLeaderboardsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterLeaderboardsV2DataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterLeaderboardSetsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterLeaderboardSetsV2DataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterAchievementsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterAchievementsV2DataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterActivitiesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterChallengesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterAchievementV2VersionsLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterAchievementLocalizationsLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterAchievementReleasesLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.ErrorResponseError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppMediaStateError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.HttpHeader>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterAchievementsV2GetInstanceFieldsGameCenterAchievement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterAchievementsV2GetInstanceFieldsGameCenterDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterAchievementsV2GetInstanceFieldsGameCenterGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterAchievementsV2GetInstanceFieldsGameCenterActivitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterAchievementsV2GetInstanceFieldsGameCenterAchievementVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterAchievementsV2GetInstanceIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterAchievementsGetInstanceFieldsGameCenterAchievement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterAchievementsGetInstanceFieldsGameCenterDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterAchievementsGetInstanceFieldsGameCenterGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterAchievementsGetInstanceFieldsGameCenterAchievementLocalization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterAchievementsGetInstanceFieldsGameCenterAchievementRelease>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterAchievementsGetInstanceFieldsGameCenterActivitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterAchievementsGetInstanceIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievementVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievementLocalization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterAchievementsV2VersionsGetToManyRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterAchievement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterAchievementLocalization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterAchievementRelease>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterActivitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterAchievementsGroupAchievementGetToOneRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterAchievementsLocalizationsGetToManyRelatedFieldsGameCenterAchievementLocalization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterAchievementsLocalizationsGetToManyRelatedFieldsGameCenterAchievement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterAchievementsLocalizationsGetToManyRelatedFieldsGameCenterAchievementImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterAchievementsLocalizationsGetToManyRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterAchievementsReleasesGetToManyRelatedFieldsGameCenterAchievementRelease>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterAchievementsReleasesGetToManyRelatedFieldsGameCenterDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterAchievementsReleasesGetToManyRelatedFieldsGameCenterAchievement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterAchievementsReleasesGetToManyRelatedIncludeItem>))]
    internal sealed partial class GameCenterAchievementsSourceGenerationContextChunk2 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GameCenterAchievementsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static GameCenterAchievementsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private GameCenterAchievementsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItemJsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem2JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem3JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem4JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem5JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem6JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem7JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem8JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem9JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem10JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem11JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem12JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem13JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem14JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem15JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem16JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem18JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem19JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem20JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem21JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem22JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem23JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem24JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem25JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem26JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem27JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem28JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem30JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem31JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem32JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem33JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem34JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem35JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem36JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem37JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem38JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem39JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem40JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem41JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem42JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem43JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem44JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem45JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem46JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem47JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem50JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem51JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem52JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem53JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem54JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem55JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem56JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem57JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem58JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem59JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem60JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem61JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem62JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem63JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem64JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem65JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem66JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem67JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem68JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem69JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem70JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem71JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem72JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem73JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem74JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem75JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem76JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem77JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem78JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem79JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem80JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem81JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem82JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem83JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem84JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem85JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem86JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem87JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem88JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem89JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem90JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem91JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem92JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem93JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem94JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem95JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem96JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem97JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem98JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem99JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem100JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem101JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem102JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem103JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem104JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem105JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem106JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem107JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem108JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem109JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem110JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem111JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem112JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem113JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem114JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem115JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem116JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem117JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem118JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem119JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem120JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem121JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem122JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem123JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem124JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem125JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem126JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem127JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem128JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem129JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem130JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem131JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem138JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem139JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem141JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem142JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem143JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem144JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem145JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem146JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem147JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem148JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem149JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem150JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem151JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem152JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem153JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem154JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem155JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem156JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem157JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem158JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem159JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem160JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem161JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem162JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem163JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem164JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem165JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem166JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem167JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem168JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem169JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem170JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem171JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem172JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem173JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem174JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem175JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem176JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem177JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem179JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.OneOfJsonConverter<global::AppStoreConnect.ErrorSourcePointer, global::AppStoreConnect.ErrorSourceParameter>());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.OneOfJsonConverter<string, global::AppStoreConnect.ErrorLinksAssociated>());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.UnixTimestampJsonConverter());
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
                    typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementImageType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementImageType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementImageRelationshipsGameCenterAchievementLocalizationDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementImageRelationshipsGameCenterAchievementLocalizationDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementLocalizationV2Type)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementLocalizationV2Type?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementLocalizationV2RelationshipsVersionDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementLocalizationV2RelationshipsVersionDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementLocalizationV2RelationshipsImageDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementLocalizationV2RelationshipsImageDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementLocalizationType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementLocalizationType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementLocalizationRelationshipsGameCenterAchievementDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementLocalizationRelationshipsGameCenterAchievementDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementLocalizationRelationshipsGameCenterAchievementImageDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementLocalizationRelationshipsGameCenterAchievementImageDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementLocalizationsResponseIncludedItemDiscriminatorType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementLocalizationsResponseIncludedItemDiscriminatorType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementReleaseType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementReleaseType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementReleaseRelationshipsGameCenterDetailDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementReleaseRelationshipsGameCenterDetailDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementReleaseRelationshipsGameCenterAchievementDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementReleaseRelationshipsGameCenterAchievementDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementReleasesResponseIncludedItemDiscriminatorType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementReleasesResponseIncludedItemDiscriminatorType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementVersionV2Type)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementVersionV2Type?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementVersionV2RelationshipsAchievementDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementVersionV2RelationshipsAchievementDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementVersionV2RelationshipsLocalizationsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementVersionV2RelationshipsLocalizationsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementVersionV2InlineCreateType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementVersionV2InlineCreateType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementVersionV2InlineCreateRelationshipsAchievementDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementVersionV2InlineCreateRelationshipsAchievementDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementVersionsV2ResponseIncludedItemDiscriminatorType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementVersionsV2ResponseIncludedItemDiscriminatorType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementV2Type)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementV2Type?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementV2RelationshipsGameCenterDetailDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementV2RelationshipsGameCenterDetailDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementV2RelationshipsGameCenterGroupDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementV2RelationshipsGameCenterGroupDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementV2RelationshipsActivityDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementV2RelationshipsActivityDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementV2RelationshipsVersionsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementV2RelationshipsVersionsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementV2ResponseIncludedItemDiscriminatorType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementV2ResponseIncludedItemDiscriminatorType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementV2CreateRequestDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementV2CreateRequestDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementV2CreateRequestDataRelationshipsGameCenterDetailDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementV2CreateRequestDataRelationshipsGameCenterDetailDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementV2CreateRequestDataRelationshipsGameCenterGroupDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementV2CreateRequestDataRelationshipsGameCenterGroupDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementV2CreateRequestDataRelationshipsVersionsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementV2CreateRequestDataRelationshipsVersionsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementV2UpdateRequestDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementV2UpdateRequestDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementRelationshipsGameCenterDetailDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementRelationshipsGameCenterDetailDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementRelationshipsGameCenterGroupDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementRelationshipsGameCenterGroupDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementRelationshipsGroupAchievementDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementRelationshipsGroupAchievementDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementRelationshipsLocalizationsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementRelationshipsLocalizationsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementRelationshipsReleasesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementRelationshipsReleasesDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementRelationshipsActivityDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementRelationshipsActivityDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementResponseIncludedItemDiscriminatorType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementResponseIncludedItemDiscriminatorType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementCreateRequestDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementCreateRequestDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementCreateRequestDataRelationshipsGameCenterDetailDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementCreateRequestDataRelationshipsGameCenterDetailDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementCreateRequestDataRelationshipsGameCenterGroupDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementCreateRequestDataRelationshipsGameCenterGroupDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementUpdateRequestDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementUpdateRequestDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterActivityType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterActivityType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterActivityAttributesPlayStyle)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterActivityAttributesPlayStyle?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterActivityRelationshipsGameCenterDetailDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterActivityRelationshipsGameCenterDetailDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterActivityRelationshipsGameCenterGroupDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterActivityRelationshipsGameCenterGroupDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterActivityRelationshipsAchievementsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterActivityRelationshipsAchievementsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterActivityRelationshipsAchievementsV2DataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterActivityRelationshipsAchievementsV2DataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterActivityRelationshipsLeaderboardsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterActivityRelationshipsLeaderboardsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterActivityRelationshipsLeaderboardsV2DataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterActivityRelationshipsLeaderboardsV2DataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterActivityRelationshipsVersionsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterActivityRelationshipsVersionsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsAppDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsAppDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterAppVersionsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterAppVersionsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterGroupDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterGroupDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterLeaderboardsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterLeaderboardsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterLeaderboardsV2DataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterLeaderboardsV2DataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterLeaderboardSetsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterLeaderboardSetsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterLeaderboardSetsV2DataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterLeaderboardSetsV2DataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterAchievementsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterAchievementsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterAchievementsV2DataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterAchievementsV2DataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterActivitiesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterActivitiesDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterChallengesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterChallengesDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsDefaultLeaderboardDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsDefaultLeaderboardDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsDefaultLeaderboardV2DataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsDefaultLeaderboardV2DataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsDefaultGroupLeaderboardDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsDefaultGroupLeaderboardDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsDefaultGroupLeaderboardV2DataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsDefaultGroupLeaderboardV2DataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsAchievementReleasesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsAchievementReleasesDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsActivityReleasesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsActivityReleasesDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsChallengeReleasesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsChallengeReleasesDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsLeaderboardReleasesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsLeaderboardReleasesDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsLeaderboardSetReleasesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsLeaderboardSetReleasesDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsChallengesMinimumPlatformVersionsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsChallengesMinimumPlatformVersionsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterDetailsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterDetailsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterLeaderboardsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterLeaderboardsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterLeaderboardsV2DataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterLeaderboardsV2DataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterLeaderboardSetsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterLeaderboardSetsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterLeaderboardSetsV2DataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterLeaderboardSetsV2DataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterAchievementsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterAchievementsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterAchievementsV2DataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterAchievementsV2DataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterActivitiesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterActivitiesDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterChallengesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterChallengesDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementV2ActivityLinkageRequestDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementV2ActivityLinkageRequestDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementV2VersionsLinkagesResponseDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementV2VersionsLinkagesResponseDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementActivityLinkageRequestDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementActivityLinkageRequestDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementGroupAchievementLinkageResponseDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementGroupAchievementLinkageResponseDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementGroupAchievementLinkageRequestDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementGroupAchievementLinkageRequestDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementLocalizationsLinkagesResponseDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementLocalizationsLinkagesResponseDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementReleasesLinkagesResponseDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementReleasesLinkagesResponseDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppMediaAssetStateState)

                    || typeToConvert == typeof(global::AppStoreConnect.AppMediaAssetStateState?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterVersionState)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterVersionState?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsV2GetInstanceFieldsGameCenterAchievement)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsV2GetInstanceFieldsGameCenterAchievement?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsV2GetInstanceFieldsGameCenterDetail)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsV2GetInstanceFieldsGameCenterDetail?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsV2GetInstanceFieldsGameCenterGroup)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsV2GetInstanceFieldsGameCenterGroup?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsV2GetInstanceFieldsGameCenterActivitie)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsV2GetInstanceFieldsGameCenterActivitie?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsV2GetInstanceFieldsGameCenterAchievementVersion)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsV2GetInstanceFieldsGameCenterAchievementVersion?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsV2GetInstanceIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsV2GetInstanceIncludeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsGetInstanceFieldsGameCenterAchievement)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsGetInstanceFieldsGameCenterAchievement?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsGetInstanceFieldsGameCenterDetail)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsGetInstanceFieldsGameCenterDetail?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsGetInstanceFieldsGameCenterGroup)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsGetInstanceFieldsGameCenterGroup?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsGetInstanceFieldsGameCenterAchievementLocalization)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsGetInstanceFieldsGameCenterAchievementLocalization?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsGetInstanceFieldsGameCenterAchievementRelease)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsGetInstanceFieldsGameCenterAchievementRelease?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsGetInstanceFieldsGameCenterActivitie)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsGetInstanceFieldsGameCenterActivitie?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsGetInstanceIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsGetInstanceIncludeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievementVersion)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievementVersion?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievement)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievement?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievementLocalization)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievementLocalization?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsV2VersionsGetToManyRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsV2VersionsGetToManyRelatedIncludeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterAchievement)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterAchievement?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterDetail)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterDetail?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterGroup)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterGroup?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterAchievementLocalization)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterAchievementLocalization?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterAchievementRelease)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterAchievementRelease?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterActivitie)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterActivitie?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsGroupAchievementGetToOneRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsGroupAchievementGetToOneRelatedIncludeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsLocalizationsGetToManyRelatedFieldsGameCenterAchievementLocalization)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsLocalizationsGetToManyRelatedFieldsGameCenterAchievementLocalization?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsLocalizationsGetToManyRelatedFieldsGameCenterAchievement)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsLocalizationsGetToManyRelatedFieldsGameCenterAchievement?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsLocalizationsGetToManyRelatedFieldsGameCenterAchievementImage)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsLocalizationsGetToManyRelatedFieldsGameCenterAchievementImage?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsLocalizationsGetToManyRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsLocalizationsGetToManyRelatedIncludeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsReleasesGetToManyRelatedFieldsGameCenterAchievementRelease)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsReleasesGetToManyRelatedFieldsGameCenterAchievementRelease?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsReleasesGetToManyRelatedFieldsGameCenterDetail)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsReleasesGetToManyRelatedFieldsGameCenterDetail?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsReleasesGetToManyRelatedFieldsGameCenterAchievement)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsReleasesGetToManyRelatedFieldsGameCenterAchievement?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsReleasesGetToManyRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsReleasesGetToManyRelatedIncludeItem?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementImageType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementImageTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementImageType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementImageTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementImageRelationshipsGameCenterAchievementLocalizationDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementImageRelationshipsGameCenterAchievementLocalizationDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementImageRelationshipsGameCenterAchievementLocalizationDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementImageRelationshipsGameCenterAchievementLocalizationDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementLocalizationV2Type))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementLocalizationV2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementLocalizationV2Type?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementLocalizationV2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementLocalizationV2RelationshipsVersionDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementLocalizationV2RelationshipsVersionDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementLocalizationV2RelationshipsVersionDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementLocalizationV2RelationshipsVersionDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementLocalizationV2RelationshipsImageDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementLocalizationV2RelationshipsImageDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementLocalizationV2RelationshipsImageDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementLocalizationV2RelationshipsImageDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementLocalizationType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementLocalizationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementLocalizationType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementLocalizationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementLocalizationRelationshipsGameCenterAchievementDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementLocalizationRelationshipsGameCenterAchievementDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementLocalizationRelationshipsGameCenterAchievementDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementLocalizationRelationshipsGameCenterAchievementDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementLocalizationRelationshipsGameCenterAchievementImageDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementLocalizationRelationshipsGameCenterAchievementImageDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementLocalizationRelationshipsGameCenterAchievementImageDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementLocalizationRelationshipsGameCenterAchievementImageDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementLocalizationsResponseIncludedItemDiscriminatorType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementLocalizationsResponseIncludedItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementLocalizationsResponseIncludedItemDiscriminatorType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementLocalizationsResponseIncludedItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementReleaseType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementReleaseTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementReleaseType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementReleaseTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementReleaseRelationshipsGameCenterDetailDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementReleaseRelationshipsGameCenterDetailDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementReleaseRelationshipsGameCenterDetailDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementReleaseRelationshipsGameCenterDetailDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementReleaseRelationshipsGameCenterAchievementDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementReleaseRelationshipsGameCenterAchievementDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementReleaseRelationshipsGameCenterAchievementDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementReleaseRelationshipsGameCenterAchievementDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementReleasesResponseIncludedItemDiscriminatorType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementReleasesResponseIncludedItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementReleasesResponseIncludedItemDiscriminatorType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementReleasesResponseIncludedItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementVersionV2Type))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementVersionV2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementVersionV2Type?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementVersionV2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementVersionV2RelationshipsAchievementDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementVersionV2RelationshipsAchievementDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementVersionV2RelationshipsAchievementDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementVersionV2RelationshipsAchievementDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementVersionV2RelationshipsLocalizationsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementVersionV2RelationshipsLocalizationsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementVersionV2RelationshipsLocalizationsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementVersionV2RelationshipsLocalizationsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementVersionV2InlineCreateType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementVersionV2InlineCreateTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementVersionV2InlineCreateType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementVersionV2InlineCreateTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementVersionV2InlineCreateRelationshipsAchievementDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementVersionV2InlineCreateRelationshipsAchievementDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementVersionV2InlineCreateRelationshipsAchievementDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementVersionV2InlineCreateRelationshipsAchievementDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementVersionsV2ResponseIncludedItemDiscriminatorType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementVersionsV2ResponseIncludedItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementVersionsV2ResponseIncludedItemDiscriminatorType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementVersionsV2ResponseIncludedItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementV2Type))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementV2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementV2Type?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementV2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementV2RelationshipsGameCenterDetailDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementV2RelationshipsGameCenterDetailDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementV2RelationshipsGameCenterDetailDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementV2RelationshipsGameCenterDetailDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementV2RelationshipsGameCenterGroupDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementV2RelationshipsGameCenterGroupDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementV2RelationshipsGameCenterGroupDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementV2RelationshipsGameCenterGroupDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementV2RelationshipsActivityDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementV2RelationshipsActivityDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementV2RelationshipsActivityDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementV2RelationshipsActivityDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementV2RelationshipsVersionsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementV2RelationshipsVersionsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementV2RelationshipsVersionsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementV2RelationshipsVersionsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementV2ResponseIncludedItemDiscriminatorType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementV2ResponseIncludedItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementV2ResponseIncludedItemDiscriminatorType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementV2ResponseIncludedItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementV2CreateRequestDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementV2CreateRequestDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementV2CreateRequestDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementV2CreateRequestDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementV2CreateRequestDataRelationshipsGameCenterDetailDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementV2CreateRequestDataRelationshipsGameCenterDetailDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementV2CreateRequestDataRelationshipsGameCenterDetailDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementV2CreateRequestDataRelationshipsGameCenterDetailDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementV2CreateRequestDataRelationshipsGameCenterGroupDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementV2CreateRequestDataRelationshipsGameCenterGroupDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementV2CreateRequestDataRelationshipsGameCenterGroupDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementV2CreateRequestDataRelationshipsGameCenterGroupDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementV2CreateRequestDataRelationshipsVersionsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementV2CreateRequestDataRelationshipsVersionsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementV2CreateRequestDataRelationshipsVersionsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementV2CreateRequestDataRelationshipsVersionsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementV2UpdateRequestDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementV2UpdateRequestDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementV2UpdateRequestDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementV2UpdateRequestDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementRelationshipsGameCenterDetailDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementRelationshipsGameCenterDetailDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementRelationshipsGameCenterDetailDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementRelationshipsGameCenterDetailDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementRelationshipsGameCenterGroupDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementRelationshipsGameCenterGroupDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementRelationshipsGameCenterGroupDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementRelationshipsGameCenterGroupDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementRelationshipsGroupAchievementDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementRelationshipsGroupAchievementDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementRelationshipsGroupAchievementDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementRelationshipsGroupAchievementDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementRelationshipsLocalizationsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementRelationshipsLocalizationsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementRelationshipsLocalizationsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementRelationshipsLocalizationsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementRelationshipsReleasesDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementRelationshipsReleasesDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementRelationshipsReleasesDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementRelationshipsReleasesDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementRelationshipsActivityDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementRelationshipsActivityDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementRelationshipsActivityDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementRelationshipsActivityDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementResponseIncludedItemDiscriminatorType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementResponseIncludedItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementResponseIncludedItemDiscriminatorType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementResponseIncludedItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementCreateRequestDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementCreateRequestDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementCreateRequestDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementCreateRequestDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementCreateRequestDataRelationshipsGameCenterDetailDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementCreateRequestDataRelationshipsGameCenterDetailDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementCreateRequestDataRelationshipsGameCenterDetailDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementCreateRequestDataRelationshipsGameCenterDetailDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementCreateRequestDataRelationshipsGameCenterGroupDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementCreateRequestDataRelationshipsGameCenterGroupDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementCreateRequestDataRelationshipsGameCenterGroupDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementCreateRequestDataRelationshipsGameCenterGroupDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementUpdateRequestDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementUpdateRequestDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementUpdateRequestDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementUpdateRequestDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterActivityType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterActivityTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterActivityType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterActivityTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterActivityAttributesPlayStyle))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterActivityAttributesPlayStyleJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterActivityAttributesPlayStyle?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterActivityAttributesPlayStyleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterActivityRelationshipsGameCenterDetailDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterActivityRelationshipsGameCenterDetailDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterActivityRelationshipsGameCenterDetailDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterActivityRelationshipsGameCenterDetailDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterActivityRelationshipsGameCenterGroupDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterActivityRelationshipsGameCenterGroupDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterActivityRelationshipsGameCenterGroupDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterActivityRelationshipsGameCenterGroupDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterActivityRelationshipsAchievementsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterActivityRelationshipsAchievementsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterActivityRelationshipsAchievementsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterActivityRelationshipsAchievementsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterActivityRelationshipsAchievementsV2DataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterActivityRelationshipsAchievementsV2DataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterActivityRelationshipsAchievementsV2DataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterActivityRelationshipsAchievementsV2DataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterActivityRelationshipsLeaderboardsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterActivityRelationshipsLeaderboardsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterActivityRelationshipsLeaderboardsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterActivityRelationshipsLeaderboardsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterActivityRelationshipsLeaderboardsV2DataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterActivityRelationshipsLeaderboardsV2DataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterActivityRelationshipsLeaderboardsV2DataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterActivityRelationshipsLeaderboardsV2DataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterActivityRelationshipsVersionsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterActivityRelationshipsVersionsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterActivityRelationshipsVersionsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterActivityRelationshipsVersionsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsAppDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailRelationshipsAppDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsAppDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailRelationshipsAppDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterAppVersionsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailRelationshipsGameCenterAppVersionsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterAppVersionsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailRelationshipsGameCenterAppVersionsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterGroupDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailRelationshipsGameCenterGroupDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterGroupDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailRelationshipsGameCenterGroupDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterLeaderboardsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailRelationshipsGameCenterLeaderboardsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterLeaderboardsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailRelationshipsGameCenterLeaderboardsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterLeaderboardsV2DataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailRelationshipsGameCenterLeaderboardsV2DataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterLeaderboardsV2DataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailRelationshipsGameCenterLeaderboardsV2DataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterLeaderboardSetsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailRelationshipsGameCenterLeaderboardSetsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterLeaderboardSetsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailRelationshipsGameCenterLeaderboardSetsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterLeaderboardSetsV2DataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailRelationshipsGameCenterLeaderboardSetsV2DataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterLeaderboardSetsV2DataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailRelationshipsGameCenterLeaderboardSetsV2DataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterAchievementsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailRelationshipsGameCenterAchievementsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterAchievementsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailRelationshipsGameCenterAchievementsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterAchievementsV2DataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailRelationshipsGameCenterAchievementsV2DataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterAchievementsV2DataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailRelationshipsGameCenterAchievementsV2DataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterActivitiesDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailRelationshipsGameCenterActivitiesDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterActivitiesDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailRelationshipsGameCenterActivitiesDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterChallengesDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailRelationshipsGameCenterChallengesDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterChallengesDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailRelationshipsGameCenterChallengesDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsDefaultLeaderboardDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailRelationshipsDefaultLeaderboardDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsDefaultLeaderboardDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailRelationshipsDefaultLeaderboardDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsDefaultLeaderboardV2DataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailRelationshipsDefaultLeaderboardV2DataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsDefaultLeaderboardV2DataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailRelationshipsDefaultLeaderboardV2DataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsDefaultGroupLeaderboardDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailRelationshipsDefaultGroupLeaderboardDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsDefaultGroupLeaderboardDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailRelationshipsDefaultGroupLeaderboardDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsDefaultGroupLeaderboardV2DataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailRelationshipsDefaultGroupLeaderboardV2DataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsDefaultGroupLeaderboardV2DataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailRelationshipsDefaultGroupLeaderboardV2DataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsAchievementReleasesDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailRelationshipsAchievementReleasesDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsAchievementReleasesDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailRelationshipsAchievementReleasesDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsActivityReleasesDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailRelationshipsActivityReleasesDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsActivityReleasesDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailRelationshipsActivityReleasesDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsChallengeReleasesDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailRelationshipsChallengeReleasesDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsChallengeReleasesDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailRelationshipsChallengeReleasesDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsLeaderboardReleasesDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailRelationshipsLeaderboardReleasesDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsLeaderboardReleasesDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailRelationshipsLeaderboardReleasesDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsLeaderboardSetReleasesDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailRelationshipsLeaderboardSetReleasesDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsLeaderboardSetReleasesDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailRelationshipsLeaderboardSetReleasesDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsChallengesMinimumPlatformVersionsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailRelationshipsChallengesMinimumPlatformVersionsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsChallengesMinimumPlatformVersionsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailRelationshipsChallengesMinimumPlatformVersionsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterDetailsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupRelationshipsGameCenterDetailsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterDetailsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupRelationshipsGameCenterDetailsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterLeaderboardsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupRelationshipsGameCenterLeaderboardsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterLeaderboardsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupRelationshipsGameCenterLeaderboardsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterLeaderboardsV2DataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupRelationshipsGameCenterLeaderboardsV2DataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterLeaderboardsV2DataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupRelationshipsGameCenterLeaderboardsV2DataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterLeaderboardSetsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupRelationshipsGameCenterLeaderboardSetsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterLeaderboardSetsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupRelationshipsGameCenterLeaderboardSetsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterLeaderboardSetsV2DataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupRelationshipsGameCenterLeaderboardSetsV2DataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterLeaderboardSetsV2DataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupRelationshipsGameCenterLeaderboardSetsV2DataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterAchievementsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupRelationshipsGameCenterAchievementsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterAchievementsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupRelationshipsGameCenterAchievementsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterAchievementsV2DataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupRelationshipsGameCenterAchievementsV2DataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterAchievementsV2DataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupRelationshipsGameCenterAchievementsV2DataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterActivitiesDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupRelationshipsGameCenterActivitiesDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterActivitiesDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupRelationshipsGameCenterActivitiesDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterChallengesDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupRelationshipsGameCenterChallengesDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterChallengesDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupRelationshipsGameCenterChallengesDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementV2ActivityLinkageRequestDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementV2ActivityLinkageRequestDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementV2ActivityLinkageRequestDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementV2ActivityLinkageRequestDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementV2VersionsLinkagesResponseDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementV2VersionsLinkagesResponseDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementV2VersionsLinkagesResponseDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementV2VersionsLinkagesResponseDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementActivityLinkageRequestDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementActivityLinkageRequestDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementActivityLinkageRequestDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementActivityLinkageRequestDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementGroupAchievementLinkageResponseDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementGroupAchievementLinkageResponseDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementGroupAchievementLinkageResponseDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementGroupAchievementLinkageResponseDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementGroupAchievementLinkageRequestDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementGroupAchievementLinkageRequestDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementGroupAchievementLinkageRequestDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementGroupAchievementLinkageRequestDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementLocalizationsLinkagesResponseDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementLocalizationsLinkagesResponseDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementLocalizationsLinkagesResponseDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementLocalizationsLinkagesResponseDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementReleasesLinkagesResponseDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementReleasesLinkagesResponseDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementReleasesLinkagesResponseDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementReleasesLinkagesResponseDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppMediaAssetStateState))
                {
                    return new global::AppStoreConnect.JsonConverters.AppMediaAssetStateStateJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppMediaAssetStateState?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppMediaAssetStateStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterVersionState))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterVersionStateJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterVersionState?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterVersionStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsV2GetInstanceFieldsGameCenterAchievement))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementsV2GetInstanceFieldsGameCenterAchievementJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsV2GetInstanceFieldsGameCenterAchievement?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementsV2GetInstanceFieldsGameCenterAchievementNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsV2GetInstanceFieldsGameCenterDetail))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementsV2GetInstanceFieldsGameCenterDetailJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsV2GetInstanceFieldsGameCenterDetail?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementsV2GetInstanceFieldsGameCenterDetailNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsV2GetInstanceFieldsGameCenterGroup))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementsV2GetInstanceFieldsGameCenterGroupJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsV2GetInstanceFieldsGameCenterGroup?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementsV2GetInstanceFieldsGameCenterGroupNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsV2GetInstanceFieldsGameCenterActivitie))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementsV2GetInstanceFieldsGameCenterActivitieJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsV2GetInstanceFieldsGameCenterActivitie?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementsV2GetInstanceFieldsGameCenterActivitieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsV2GetInstanceFieldsGameCenterAchievementVersion))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementsV2GetInstanceFieldsGameCenterAchievementVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsV2GetInstanceFieldsGameCenterAchievementVersion?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementsV2GetInstanceFieldsGameCenterAchievementVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsV2GetInstanceIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementsV2GetInstanceIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsV2GetInstanceIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementsV2GetInstanceIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsGetInstanceFieldsGameCenterAchievement))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementsGetInstanceFieldsGameCenterAchievementJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsGetInstanceFieldsGameCenterAchievement?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementsGetInstanceFieldsGameCenterAchievementNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsGetInstanceFieldsGameCenterDetail))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementsGetInstanceFieldsGameCenterDetailJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsGetInstanceFieldsGameCenterDetail?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementsGetInstanceFieldsGameCenterDetailNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsGetInstanceFieldsGameCenterGroup))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementsGetInstanceFieldsGameCenterGroupJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsGetInstanceFieldsGameCenterGroup?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementsGetInstanceFieldsGameCenterGroupNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsGetInstanceFieldsGameCenterAchievementLocalization))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementsGetInstanceFieldsGameCenterAchievementLocalizationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsGetInstanceFieldsGameCenterAchievementLocalization?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementsGetInstanceFieldsGameCenterAchievementLocalizationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsGetInstanceFieldsGameCenterAchievementRelease))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementsGetInstanceFieldsGameCenterAchievementReleaseJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsGetInstanceFieldsGameCenterAchievementRelease?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementsGetInstanceFieldsGameCenterAchievementReleaseNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsGetInstanceFieldsGameCenterActivitie))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementsGetInstanceFieldsGameCenterActivitieJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsGetInstanceFieldsGameCenterActivitie?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementsGetInstanceFieldsGameCenterActivitieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsGetInstanceIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementsGetInstanceIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsGetInstanceIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementsGetInstanceIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievementVersion))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievementVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievementVersion?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievementVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievement))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievementJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievement?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievementNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievementLocalization))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievementLocalizationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievementLocalization?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievementLocalizationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsV2VersionsGetToManyRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementsV2VersionsGetToManyRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsV2VersionsGetToManyRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementsV2VersionsGetToManyRelatedIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterAchievement))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterAchievementJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterAchievement?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterAchievementNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterDetail))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterDetailJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterDetail?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterDetailNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterGroup))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterGroupJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterGroup?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterGroupNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterAchievementLocalization))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterAchievementLocalizationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterAchievementLocalization?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterAchievementLocalizationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterAchievementRelease))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterAchievementReleaseJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterAchievementRelease?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterAchievementReleaseNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterActivitie))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterActivitieJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterActivitie?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterActivitieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsGroupAchievementGetToOneRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementsGroupAchievementGetToOneRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsGroupAchievementGetToOneRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementsGroupAchievementGetToOneRelatedIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsLocalizationsGetToManyRelatedFieldsGameCenterAchievementLocalization))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementsLocalizationsGetToManyRelatedFieldsGameCenterAchievementLocalizationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsLocalizationsGetToManyRelatedFieldsGameCenterAchievementLocalization?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementsLocalizationsGetToManyRelatedFieldsGameCenterAchievementLocalizationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsLocalizationsGetToManyRelatedFieldsGameCenterAchievement))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementsLocalizationsGetToManyRelatedFieldsGameCenterAchievementJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsLocalizationsGetToManyRelatedFieldsGameCenterAchievement?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementsLocalizationsGetToManyRelatedFieldsGameCenterAchievementNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsLocalizationsGetToManyRelatedFieldsGameCenterAchievementImage))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementsLocalizationsGetToManyRelatedFieldsGameCenterAchievementImageJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsLocalizationsGetToManyRelatedFieldsGameCenterAchievementImage?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementsLocalizationsGetToManyRelatedFieldsGameCenterAchievementImageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsLocalizationsGetToManyRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementsLocalizationsGetToManyRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsLocalizationsGetToManyRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementsLocalizationsGetToManyRelatedIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsReleasesGetToManyRelatedFieldsGameCenterAchievementRelease))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementsReleasesGetToManyRelatedFieldsGameCenterAchievementReleaseJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsReleasesGetToManyRelatedFieldsGameCenterAchievementRelease?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementsReleasesGetToManyRelatedFieldsGameCenterAchievementReleaseNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsReleasesGetToManyRelatedFieldsGameCenterDetail))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementsReleasesGetToManyRelatedFieldsGameCenterDetailJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsReleasesGetToManyRelatedFieldsGameCenterDetail?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementsReleasesGetToManyRelatedFieldsGameCenterDetailNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsReleasesGetToManyRelatedFieldsGameCenterAchievement))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementsReleasesGetToManyRelatedFieldsGameCenterAchievementJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsReleasesGetToManyRelatedFieldsGameCenterAchievement?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementsReleasesGetToManyRelatedFieldsGameCenterAchievementNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsReleasesGetToManyRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementsReleasesGetToManyRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsReleasesGetToManyRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementsReleasesGetToManyRelatedIncludeItemNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[3];

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
                    0 => new GameCenterAchievementsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),

                    1 => new GameCenterAchievementsSourceGenerationContextChunk1(new global::System.Text.Json.JsonSerializerOptions()),

                    2 => new GameCenterAchievementsSourceGenerationContextChunk2(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}