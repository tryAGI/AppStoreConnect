
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem8), TypeInfoPropertyName = "IncludedItem82")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementLocalization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementImageV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem75), TypeInfoPropertyName = "IncludedItem752")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementVersionV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem76), TypeInfoPropertyName = "IncludedItem762")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem77), TypeInfoPropertyName = "IncludedItem772")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievement))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem78), TypeInfoPropertyName = "IncludedItem782")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementRelease))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem79), TypeInfoPropertyName = "IncludedItem792")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem80), TypeInfoPropertyName = "IncludedItem802")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterVersionState), TypeInfoPropertyName = "GameCenterVersionState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem83), TypeInfoPropertyName = "IncludedItem832")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterActivity))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroup))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem84), TypeInfoPropertyName = "IncludedItem842")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem85), TypeInfoPropertyName = "IncludedItem852")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem86), TypeInfoPropertyName = "IncludedItem862")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterChallengeType), TypeInfoPropertyName = "GameCenterChallengeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterChallengeAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterChallengeAttributesChallengeType), TypeInfoPropertyName = "GameCenterChallengeAttributesChallengeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterChallengeRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterChallengeRelationshipsGameCenterDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterChallengeRelationshipsGameCenterDetailData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterChallengeRelationshipsGameCenterDetailDataType), TypeInfoPropertyName = "GameCenterChallengeRelationshipsGameCenterDetailDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterChallengeRelationshipsGameCenterGroup))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterChallengeRelationshipsGameCenterGroupData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterChallengeRelationshipsGameCenterGroupDataType), TypeInfoPropertyName = "GameCenterChallengeRelationshipsGameCenterGroupDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterChallengeRelationshipsVersions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterChallengeRelationshipsVersionsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterChallengeRelationshipsVersionsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterChallengeRelationshipsVersionsDataItemType), TypeInfoPropertyName = "GameCenterChallengeRelationshipsVersionsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterChallengeRelationshipsLeaderboard))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterChallengeRelationshipsLeaderboardData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterChallengeRelationshipsLeaderboardDataType), TypeInfoPropertyName = "GameCenterChallengeRelationshipsLeaderboardDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterChallengeRelationshipsLeaderboardV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterChallengeRelationshipsLeaderboardV2Data))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterChallengeRelationshipsLeaderboardV2DataType), TypeInfoPropertyName = "GameCenterChallengeRelationshipsLeaderboardV2DataType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardLocalizationType), TypeInfoPropertyName = "GameCenterLeaderboardLocalizationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardLocalizationAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardFormatter), TypeInfoPropertyName = "GameCenterLeaderboardFormatter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardLocalizationRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardLocalizationRelationshipsGameCenterLeaderboard))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardLocalizationRelationshipsGameCenterLeaderboardData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardLocalizationRelationshipsGameCenterLeaderboardDataType), TypeInfoPropertyName = "GameCenterLeaderboardLocalizationRelationshipsGameCenterLeaderboardDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardLocalizationRelationshipsGameCenterLeaderboardImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardLocalizationRelationshipsGameCenterLeaderboardImageData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardLocalizationRelationshipsGameCenterLeaderboardImageDataType), TypeInfoPropertyName = "GameCenterLeaderboardLocalizationRelationshipsGameCenterLeaderboardImageDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem106), TypeInfoPropertyName = "IncludedItem1062")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem107), TypeInfoPropertyName = "IncludedItem1072")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem108), TypeInfoPropertyName = "IncludedItem1082")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardVersionV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem109), TypeInfoPropertyName = "IncludedItem1092")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardReleaseType), TypeInfoPropertyName = "GameCenterLeaderboardReleaseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardReleaseAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardReleaseRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardReleaseRelationshipsGameCenterDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardReleaseRelationshipsGameCenterDetailData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardReleaseRelationshipsGameCenterDetailDataType), TypeInfoPropertyName = "GameCenterLeaderboardReleaseRelationshipsGameCenterDetailDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardReleaseRelationshipsGameCenterLeaderboard))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardReleaseRelationshipsGameCenterLeaderboardData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardReleaseRelationshipsGameCenterLeaderboardDataType), TypeInfoPropertyName = "GameCenterLeaderboardReleaseRelationshipsGameCenterLeaderboardDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem110), TypeInfoPropertyName = "IncludedItem1102")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem111), TypeInfoPropertyName = "IncludedItem1112")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetImageType), TypeInfoPropertyName = "GameCenterLeaderboardSetImageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetImageAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetImageRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetImageRelationshipsGameCenterLeaderboardSetLocalization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetImageRelationshipsGameCenterLeaderboardSetLocalizationData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetImageRelationshipsGameCenterLeaderboardSetLocalizationDataType), TypeInfoPropertyName = "GameCenterLeaderboardSetImageRelationshipsGameCenterLeaderboardSetLocalizationDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardSetLocalization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetLocalization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetImageV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetLocalizationV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetLocalizationType), TypeInfoPropertyName = "GameCenterLeaderboardSetLocalizationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetLocalizationAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetLocalizationRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetLocalizationRelationshipsGameCenterLeaderboardSet))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetLocalizationRelationshipsGameCenterLeaderboardSetData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetLocalizationRelationshipsGameCenterLeaderboardSetDataType), TypeInfoPropertyName = "GameCenterLeaderboardSetLocalizationRelationshipsGameCenterLeaderboardSetDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetLocalizationRelationshipsGameCenterLeaderboardSetImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetLocalizationRelationshipsGameCenterLeaderboardSetImageData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetLocalizationRelationshipsGameCenterLeaderboardSetImageDataType), TypeInfoPropertyName = "GameCenterLeaderboardSetLocalizationRelationshipsGameCenterLeaderboardSetImageDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetLocalizationsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.IncludedItem112>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem112), TypeInfoPropertyName = "IncludedItem1122")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetLocalizationsResponseIncludedItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetLocalizationsResponseIncludedItemDiscriminatorType), TypeInfoPropertyName = "GameCenterLeaderboardSetLocalizationsResponseIncludedItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem113), TypeInfoPropertyName = "IncludedItem1132")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetLocalizationV2Type), TypeInfoPropertyName = "GameCenterLeaderboardSetLocalizationV2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetLocalizationV2Attributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetLocalizationV2Relationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetLocalizationV2RelationshipsVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetLocalizationV2RelationshipsVersionData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetLocalizationV2RelationshipsVersionDataType), TypeInfoPropertyName = "GameCenterLeaderboardSetLocalizationV2RelationshipsVersionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetLocalizationV2RelationshipsImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetLocalizationV2RelationshipsImageData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetLocalizationV2RelationshipsImageDataType), TypeInfoPropertyName = "GameCenterLeaderboardSetLocalizationV2RelationshipsImageDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem114), TypeInfoPropertyName = "IncludedItem1142")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetVersionV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem115), TypeInfoPropertyName = "IncludedItem1152")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem116), TypeInfoPropertyName = "IncludedItem1162")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem117), TypeInfoPropertyName = "IncludedItem1172")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetReleaseType), TypeInfoPropertyName = "GameCenterLeaderboardSetReleaseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetReleaseAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetReleaseRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetReleaseRelationshipsGameCenterDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetReleaseRelationshipsGameCenterDetailData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetReleaseRelationshipsGameCenterDetailDataType), TypeInfoPropertyName = "GameCenterLeaderboardSetReleaseRelationshipsGameCenterDetailDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetReleaseRelationshipsGameCenterLeaderboardSet))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetReleaseRelationshipsGameCenterLeaderboardSetData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetReleaseRelationshipsGameCenterLeaderboardSetDataType), TypeInfoPropertyName = "GameCenterLeaderboardSetReleaseRelationshipsGameCenterLeaderboardSetDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetReleasesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardSetRelease>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.IncludedItem118>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem118), TypeInfoPropertyName = "IncludedItem1182")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetReleasesResponseIncludedItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetReleasesResponseIncludedItemDiscriminatorType), TypeInfoPropertyName = "GameCenterLeaderboardSetReleasesResponseIncludedItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem119), TypeInfoPropertyName = "IncludedItem1192")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetVersionV2Type), TypeInfoPropertyName = "GameCenterLeaderboardSetVersionV2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetVersionV2Attributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetVersionV2Relationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetVersionV2RelationshipsLeaderboardSet))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetVersionV2RelationshipsLeaderboardSetData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetVersionV2RelationshipsLeaderboardSetDataType), TypeInfoPropertyName = "GameCenterLeaderboardSetVersionV2RelationshipsLeaderboardSetDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetVersionV2RelationshipsLocalizations))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardSetVersionV2RelationshipsLocalizationsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetVersionV2RelationshipsLocalizationsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetVersionV2RelationshipsLocalizationsDataItemType), TypeInfoPropertyName = "GameCenterLeaderboardSetVersionV2RelationshipsLocalizationsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetVersionV2InlineCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetVersionV2InlineCreateType), TypeInfoPropertyName = "GameCenterLeaderboardSetVersionV2InlineCreateType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetVersionV2InlineCreateRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetVersionV2InlineCreateRelationshipsLeaderboardSet))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetVersionV2InlineCreateRelationshipsLeaderboardSetData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetVersionV2InlineCreateRelationshipsLeaderboardSetDataType), TypeInfoPropertyName = "GameCenterLeaderboardSetVersionV2InlineCreateRelationshipsLeaderboardSetDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetVersionsV2Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardSetVersionV2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.IncludedItem120>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem120), TypeInfoPropertyName = "IncludedItem1202")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetVersionsV2ResponseIncludedItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetVersionsV2ResponseIncludedItemDiscriminatorType), TypeInfoPropertyName = "GameCenterLeaderboardSetVersionsV2ResponseIncludedItemDiscriminatorType2")]
    internal sealed partial class GameCenterLeaderboardSetsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem121), TypeInfoPropertyName = "IncludedItem1212")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2Type), TypeInfoPropertyName = "GameCenterLeaderboardSetV2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2Attributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2Relationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2RelationshipsGameCenterDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2RelationshipsGameCenterDetailData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2RelationshipsGameCenterDetailDataType), TypeInfoPropertyName = "GameCenterLeaderboardSetV2RelationshipsGameCenterDetailDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2RelationshipsGameCenterGroup))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2RelationshipsGameCenterGroupData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2RelationshipsGameCenterGroupDataType), TypeInfoPropertyName = "GameCenterLeaderboardSetV2RelationshipsGameCenterGroupDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2RelationshipsGameCenterLeaderboards))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardSetV2RelationshipsGameCenterLeaderboardsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2RelationshipsGameCenterLeaderboardsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2RelationshipsGameCenterLeaderboardsDataItemType), TypeInfoPropertyName = "GameCenterLeaderboardSetV2RelationshipsGameCenterLeaderboardsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2RelationshipsVersions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardSetV2RelationshipsVersionsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2RelationshipsVersionsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2RelationshipsVersionsDataItemType), TypeInfoPropertyName = "GameCenterLeaderboardSetV2RelationshipsVersionsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem122), TypeInfoPropertyName = "IncludedItem1222")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.IncludedItem123>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem123), TypeInfoPropertyName = "IncludedItem1232")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2ResponseIncludedItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2ResponseIncludedItemDiscriminatorType), TypeInfoPropertyName = "GameCenterLeaderboardSetV2ResponseIncludedItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2CreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2CreateRequestData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2CreateRequestDataType), TypeInfoPropertyName = "GameCenterLeaderboardSetV2CreateRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2CreateRequestDataAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2CreateRequestDataRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2CreateRequestDataRelationshipsGameCenterDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2CreateRequestDataRelationshipsGameCenterDetailData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2CreateRequestDataRelationshipsGameCenterDetailDataType), TypeInfoPropertyName = "GameCenterLeaderboardSetV2CreateRequestDataRelationshipsGameCenterDetailDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2CreateRequestDataRelationshipsGameCenterGroup))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2CreateRequestDataRelationshipsGameCenterGroupData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2CreateRequestDataRelationshipsGameCenterGroupDataType), TypeInfoPropertyName = "GameCenterLeaderboardSetV2CreateRequestDataRelationshipsGameCenterGroupDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2CreateRequestDataRelationshipsGameCenterLeaderboards))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardSetV2CreateRequestDataRelationshipsGameCenterLeaderboardsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2CreateRequestDataRelationshipsGameCenterLeaderboardsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2CreateRequestDataRelationshipsGameCenterLeaderboardsDataItemType), TypeInfoPropertyName = "GameCenterLeaderboardSetV2CreateRequestDataRelationshipsGameCenterLeaderboardsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2CreateRequestDataRelationshipsVersions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardSetV2CreateRequestDataRelationshipsVersionsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2CreateRequestDataRelationshipsVersionsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2CreateRequestDataRelationshipsVersionsDataItemType), TypeInfoPropertyName = "GameCenterLeaderboardSetV2CreateRequestDataRelationshipsVersionsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardSetVersionV2InlineCreate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2UpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2UpdateRequestData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2UpdateRequestDataType), TypeInfoPropertyName = "GameCenterLeaderboardSetV2UpdateRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2UpdateRequestDataAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetType), TypeInfoPropertyName = "GameCenterLeaderboardSetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetRelationshipsGameCenterDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetRelationshipsGameCenterDetailData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetRelationshipsGameCenterDetailDataType), TypeInfoPropertyName = "GameCenterLeaderboardSetRelationshipsGameCenterDetailDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetRelationshipsGameCenterGroup))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetRelationshipsGameCenterGroupData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetRelationshipsGameCenterGroupDataType), TypeInfoPropertyName = "GameCenterLeaderboardSetRelationshipsGameCenterGroupDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetRelationshipsGroupLeaderboardSet))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetRelationshipsGroupLeaderboardSetData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetRelationshipsGroupLeaderboardSetDataType), TypeInfoPropertyName = "GameCenterLeaderboardSetRelationshipsGroupLeaderboardSetDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetRelationshipsLocalizations))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardSetRelationshipsLocalizationsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetRelationshipsLocalizationsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetRelationshipsLocalizationsDataItemType), TypeInfoPropertyName = "GameCenterLeaderboardSetRelationshipsLocalizationsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetRelationshipsGameCenterLeaderboards))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardSetRelationshipsGameCenterLeaderboardsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetRelationshipsGameCenterLeaderboardsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetRelationshipsGameCenterLeaderboardsDataItemType), TypeInfoPropertyName = "GameCenterLeaderboardSetRelationshipsGameCenterLeaderboardsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetRelationshipsReleases))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardSetRelationshipsReleasesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetRelationshipsReleasesDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetRelationshipsReleasesDataItemType), TypeInfoPropertyName = "GameCenterLeaderboardSetRelationshipsReleasesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem124), TypeInfoPropertyName = "IncludedItem1242")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.IncludedItem125>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem125), TypeInfoPropertyName = "IncludedItem1252")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetResponseIncludedItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetResponseIncludedItemDiscriminatorType), TypeInfoPropertyName = "GameCenterLeaderboardSetResponseIncludedItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetCreateRequestData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetCreateRequestDataType), TypeInfoPropertyName = "GameCenterLeaderboardSetCreateRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetCreateRequestDataAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetCreateRequestDataRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetCreateRequestDataRelationshipsGameCenterDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetCreateRequestDataRelationshipsGameCenterDetailData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetCreateRequestDataRelationshipsGameCenterDetailDataType), TypeInfoPropertyName = "GameCenterLeaderboardSetCreateRequestDataRelationshipsGameCenterDetailDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetCreateRequestDataRelationshipsGameCenterGroup))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetCreateRequestDataRelationshipsGameCenterGroupData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetCreateRequestDataRelationshipsGameCenterGroupDataType), TypeInfoPropertyName = "GameCenterLeaderboardSetCreateRequestDataRelationshipsGameCenterGroupDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetCreateRequestDataRelationshipsGameCenterLeaderboards))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardSetCreateRequestDataRelationshipsGameCenterLeaderboardsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetCreateRequestDataRelationshipsGameCenterLeaderboardsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetCreateRequestDataRelationshipsGameCenterLeaderboardsDataItemType), TypeInfoPropertyName = "GameCenterLeaderboardSetCreateRequestDataRelationshipsGameCenterLeaderboardsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetUpdateRequestData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetUpdateRequestDataType), TypeInfoPropertyName = "GameCenterLeaderboardSetUpdateRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetUpdateRequestDataAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardVersionV2Type), TypeInfoPropertyName = "GameCenterLeaderboardVersionV2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardVersionV2Attributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardVersionV2Relationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardVersionV2RelationshipsLeaderboard))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardVersionV2RelationshipsLeaderboardData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardVersionV2RelationshipsLeaderboardDataType), TypeInfoPropertyName = "GameCenterLeaderboardVersionV2RelationshipsLeaderboardDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardVersionV2RelationshipsLocalizations))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardVersionV2RelationshipsLocalizationsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardVersionV2RelationshipsLocalizationsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardVersionV2RelationshipsLocalizationsDataItemType), TypeInfoPropertyName = "GameCenterLeaderboardVersionV2RelationshipsLocalizationsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem126), TypeInfoPropertyName = "IncludedItem1262")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem127), TypeInfoPropertyName = "IncludedItem1272")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardType), TypeInfoPropertyName = "GameCenterLeaderboardType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardAttributesSubmissionType), TypeInfoPropertyName = "GameCenterLeaderboardAttributesSubmissionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardAttributesScoreSortType), TypeInfoPropertyName = "GameCenterLeaderboardAttributesScoreSortType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardAttributesVisibility), TypeInfoPropertyName = "GameCenterLeaderboardAttributesVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardRelationshipsGameCenterDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardRelationshipsGameCenterDetailData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardRelationshipsGameCenterDetailDataType), TypeInfoPropertyName = "GameCenterLeaderboardRelationshipsGameCenterDetailDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardRelationshipsGameCenterGroup))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardRelationshipsGameCenterGroupData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardRelationshipsGameCenterGroupDataType), TypeInfoPropertyName = "GameCenterLeaderboardRelationshipsGameCenterGroupDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardRelationshipsGroupLeaderboard))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardRelationshipsGroupLeaderboardData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardRelationshipsGroupLeaderboardDataType), TypeInfoPropertyName = "GameCenterLeaderboardRelationshipsGroupLeaderboardDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardRelationshipsGameCenterLeaderboardSets))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardRelationshipsGameCenterLeaderboardSetsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardRelationshipsGameCenterLeaderboardSetsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardRelationshipsGameCenterLeaderboardSetsDataItemType), TypeInfoPropertyName = "GameCenterLeaderboardRelationshipsGameCenterLeaderboardSetsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardRelationshipsLocalizations))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardRelationshipsLocalizationsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardRelationshipsLocalizationsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardRelationshipsLocalizationsDataItemType), TypeInfoPropertyName = "GameCenterLeaderboardRelationshipsLocalizationsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardRelationshipsReleases))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardRelationshipsReleasesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardRelationshipsReleasesDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardRelationshipsReleasesDataItemType), TypeInfoPropertyName = "GameCenterLeaderboardRelationshipsReleasesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardRelationshipsActivity))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardRelationshipsActivityData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardRelationshipsActivityDataType), TypeInfoPropertyName = "GameCenterLeaderboardRelationshipsActivityDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardRelationshipsChallenge))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardRelationshipsChallengeData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardRelationshipsChallengeDataType), TypeInfoPropertyName = "GameCenterLeaderboardRelationshipsChallengeDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboard>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.IncludedItem128>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem128), TypeInfoPropertyName = "IncludedItem1282")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardsResponseIncludedItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardsResponseIncludedItemDiscriminatorType), TypeInfoPropertyName = "GameCenterLeaderboardsResponseIncludedItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem129), TypeInfoPropertyName = "IncludedItem1292")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardV2Type), TypeInfoPropertyName = "GameCenterLeaderboardV2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardV2Attributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardV2AttributesSubmissionType), TypeInfoPropertyName = "GameCenterLeaderboardV2AttributesSubmissionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardV2AttributesScoreSortType), TypeInfoPropertyName = "GameCenterLeaderboardV2AttributesScoreSortType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardV2AttributesVisibility), TypeInfoPropertyName = "GameCenterLeaderboardV2AttributesVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardV2Relationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsGameCenterDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsGameCenterDetailData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsGameCenterDetailDataType), TypeInfoPropertyName = "GameCenterLeaderboardV2RelationshipsGameCenterDetailDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsGameCenterGroup))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsGameCenterGroupData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsGameCenterGroupDataType), TypeInfoPropertyName = "GameCenterLeaderboardV2RelationshipsGameCenterGroupDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsGameCenterLeaderboardSets))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsGameCenterLeaderboardSetsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsGameCenterLeaderboardSetsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsGameCenterLeaderboardSetsDataItemType), TypeInfoPropertyName = "GameCenterLeaderboardV2RelationshipsGameCenterLeaderboardSetsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsActivity))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsActivityData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsActivityDataType), TypeInfoPropertyName = "GameCenterLeaderboardV2RelationshipsActivityDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsChallenge))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsChallengeData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsChallengeDataType), TypeInfoPropertyName = "GameCenterLeaderboardV2RelationshipsChallengeDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsVersions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsVersionsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsVersionsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsVersionsDataItemType), TypeInfoPropertyName = "GameCenterLeaderboardV2RelationshipsVersionsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardsV2Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardV2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.IncludedItem130>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem130), TypeInfoPropertyName = "IncludedItem1302")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardsV2ResponseIncludedItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardsV2ResponseIncludedItemDiscriminatorType), TypeInfoPropertyName = "GameCenterLeaderboardsV2ResponseIncludedItemDiscriminatorType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2GameCenterLeaderboardsLinkagesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardSetV2GameCenterLeaderboardsLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2GameCenterLeaderboardsLinkagesResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2GameCenterLeaderboardsLinkagesResponseDataItemType), TypeInfoPropertyName = "GameCenterLeaderboardSetV2GameCenterLeaderboardsLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2GameCenterLeaderboardsLinkagesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardSetV2GameCenterLeaderboardsLinkagesRequestDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2GameCenterLeaderboardsLinkagesRequestDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2GameCenterLeaderboardsLinkagesRequestDataItemType), TypeInfoPropertyName = "GameCenterLeaderboardSetV2GameCenterLeaderboardsLinkagesRequestDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2VersionsLinkagesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardSetV2VersionsLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2VersionsLinkagesResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2VersionsLinkagesResponseDataItemType), TypeInfoPropertyName = "GameCenterLeaderboardSetV2VersionsLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetGameCenterLeaderboardsLinkagesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardSetGameCenterLeaderboardsLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetGameCenterLeaderboardsLinkagesResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetGameCenterLeaderboardsLinkagesResponseDataItemType), TypeInfoPropertyName = "GameCenterLeaderboardSetGameCenterLeaderboardsLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetGameCenterLeaderboardsLinkagesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardSetGameCenterLeaderboardsLinkagesRequestDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetGameCenterLeaderboardsLinkagesRequestDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetGameCenterLeaderboardsLinkagesRequestDataItemType), TypeInfoPropertyName = "GameCenterLeaderboardSetGameCenterLeaderboardsLinkagesRequestDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetGroupLeaderboardSetLinkageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetGroupLeaderboardSetLinkageResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetGroupLeaderboardSetLinkageResponseDataType), TypeInfoPropertyName = "GameCenterLeaderboardSetGroupLeaderboardSetLinkageResponseDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetGroupLeaderboardSetLinkageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetGroupLeaderboardSetLinkageRequestData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetGroupLeaderboardSetLinkageRequestDataType), TypeInfoPropertyName = "GameCenterLeaderboardSetGroupLeaderboardSetLinkageRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetLocalizationsLinkagesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardSetLocalizationsLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetLocalizationsLinkagesResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetLocalizationsLinkagesResponseDataItemType), TypeInfoPropertyName = "GameCenterLeaderboardSetLocalizationsLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetReleasesLinkagesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardSetReleasesLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetReleasesLinkagesResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetReleasesLinkagesResponseDataItemType), TypeInfoPropertyName = "GameCenterLeaderboardSetReleasesLinkagesResponseDataItemType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterLeaderboardSet>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterLeaderboardSet), TypeInfoPropertyName = "GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterLeaderboardSet2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterDetail), TypeInfoPropertyName = "GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterGroup), TypeInfoPropertyName = "GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterGroup2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterLeaderboard>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterLeaderboard), TypeInfoPropertyName = "GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterLeaderboard2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterLeaderboardSetVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterLeaderboardSetVersion), TypeInfoPropertyName = "GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterLeaderboardSetVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardSetsV2GetInstanceIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetsV2GetInstanceIncludeItem), TypeInfoPropertyName = "GameCenterLeaderboardSetsV2GetInstanceIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardSetsGetInstanceFieldsGameCenterLeaderboardSet>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGetInstanceFieldsGameCenterLeaderboardSet), TypeInfoPropertyName = "GameCenterLeaderboardSetsGetInstanceFieldsGameCenterLeaderboardSet2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardSetsGetInstanceFieldsGameCenterDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGetInstanceFieldsGameCenterDetail), TypeInfoPropertyName = "GameCenterLeaderboardSetsGetInstanceFieldsGameCenterDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardSetsGetInstanceFieldsGameCenterGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGetInstanceFieldsGameCenterGroup), TypeInfoPropertyName = "GameCenterLeaderboardSetsGetInstanceFieldsGameCenterGroup2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardSetsGetInstanceFieldsGameCenterLeaderboardSetLocalization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGetInstanceFieldsGameCenterLeaderboardSetLocalization), TypeInfoPropertyName = "GameCenterLeaderboardSetsGetInstanceFieldsGameCenterLeaderboardSetLocalization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardSetsGetInstanceFieldsGameCenterLeaderboard>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGetInstanceFieldsGameCenterLeaderboard), TypeInfoPropertyName = "GameCenterLeaderboardSetsGetInstanceFieldsGameCenterLeaderboard2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardSetsGetInstanceFieldsGameCenterLeaderboardSetRelease>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGetInstanceFieldsGameCenterLeaderboardSetRelease), TypeInfoPropertyName = "GameCenterLeaderboardSetsGetInstanceFieldsGameCenterLeaderboardSetRelease2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardSetsGetInstanceIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGetInstanceIncludeItem), TypeInfoPropertyName = "GameCenterLeaderboardSetsGetInstanceIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboard>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboard), TypeInfoPropertyName = "GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboard2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterDetail), TypeInfoPropertyName = "GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterGroup), TypeInfoPropertyName = "GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterGroup2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardSet>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardSet), TypeInfoPropertyName = "GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardSet2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie), TypeInfoPropertyName = "GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterChallenge>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterChallenge), TypeInfoPropertyName = "GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterChallenge2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardVersion), TypeInfoPropertyName = "GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedIncludeItem), TypeInfoPropertyName = "GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardSetsV2VersionsGetToManyRelatedFieldsGameCenterLeaderboardSetVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetsV2VersionsGetToManyRelatedFieldsGameCenterLeaderboardSetVersion), TypeInfoPropertyName = "GameCenterLeaderboardSetsV2VersionsGetToManyRelatedFieldsGameCenterLeaderboardSetVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardSetsV2VersionsGetToManyRelatedFieldsGameCenterLeaderboardSet>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetsV2VersionsGetToManyRelatedFieldsGameCenterLeaderboardSet), TypeInfoPropertyName = "GameCenterLeaderboardSetsV2VersionsGetToManyRelatedFieldsGameCenterLeaderboardSet2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardSetsV2VersionsGetToManyRelatedFieldsGameCenterLeaderboardSetLocalization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetsV2VersionsGetToManyRelatedFieldsGameCenterLeaderboardSetLocalization), TypeInfoPropertyName = "GameCenterLeaderboardSetsV2VersionsGetToManyRelatedFieldsGameCenterLeaderboardSetLocalization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardSetsV2VersionsGetToManyRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetsV2VersionsGetToManyRelatedIncludeItem), TypeInfoPropertyName = "GameCenterLeaderboardSetsV2VersionsGetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboard>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboard), TypeInfoPropertyName = "GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboard2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterDetail), TypeInfoPropertyName = "GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterGroup), TypeInfoPropertyName = "GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterGroup2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardSet>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardSet), TypeInfoPropertyName = "GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardSet2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardLocalization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardLocalization), TypeInfoPropertyName = "GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardLocalization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardRelease>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardRelease), TypeInfoPropertyName = "GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardRelease2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie), TypeInfoPropertyName = "GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterChallenge>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterChallenge), TypeInfoPropertyName = "GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterChallenge2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedIncludeItem), TypeInfoPropertyName = "GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboardSet>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboardSet), TypeInfoPropertyName = "GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboardSet2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterDetail), TypeInfoPropertyName = "GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterGroup), TypeInfoPropertyName = "GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterGroup2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboardSetLocalization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboardSetLocalization), TypeInfoPropertyName = "GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboardSetLocalization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboard>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboard), TypeInfoPropertyName = "GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboard2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboardSetRelease>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboardSetRelease), TypeInfoPropertyName = "GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboardSetRelease2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedIncludeItem), TypeInfoPropertyName = "GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardSetsLocalizationsGetToManyRelatedFieldsGameCenterLeaderboardSetLocalization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetsLocalizationsGetToManyRelatedFieldsGameCenterLeaderboardSetLocalization), TypeInfoPropertyName = "GameCenterLeaderboardSetsLocalizationsGetToManyRelatedFieldsGameCenterLeaderboardSetLocalization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardSetsLocalizationsGetToManyRelatedFieldsGameCenterLeaderboardSet>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetsLocalizationsGetToManyRelatedFieldsGameCenterLeaderboardSet), TypeInfoPropertyName = "GameCenterLeaderboardSetsLocalizationsGetToManyRelatedFieldsGameCenterLeaderboardSet2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardSetsLocalizationsGetToManyRelatedFieldsGameCenterLeaderboardSetImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetsLocalizationsGetToManyRelatedFieldsGameCenterLeaderboardSetImage), TypeInfoPropertyName = "GameCenterLeaderboardSetsLocalizationsGetToManyRelatedFieldsGameCenterLeaderboardSetImage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardSetsLocalizationsGetToManyRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetsLocalizationsGetToManyRelatedIncludeItem), TypeInfoPropertyName = "GameCenterLeaderboardSetsLocalizationsGetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardSetsReleasesGetToManyRelatedFieldsGameCenterLeaderboardSetRelease>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetsReleasesGetToManyRelatedFieldsGameCenterLeaderboardSetRelease), TypeInfoPropertyName = "GameCenterLeaderboardSetsReleasesGetToManyRelatedFieldsGameCenterLeaderboardSetRelease2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardSetsReleasesGetToManyRelatedFieldsGameCenterDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetsReleasesGetToManyRelatedFieldsGameCenterDetail), TypeInfoPropertyName = "GameCenterLeaderboardSetsReleasesGetToManyRelatedFieldsGameCenterDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardSetsReleasesGetToManyRelatedFieldsGameCenterLeaderboardSet>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetsReleasesGetToManyRelatedFieldsGameCenterLeaderboardSet), TypeInfoPropertyName = "GameCenterLeaderboardSetsReleasesGetToManyRelatedFieldsGameCenterLeaderboardSet2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardSetsReleasesGetToManyRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetsReleasesGetToManyRelatedIncludeItem), TypeInfoPropertyName = "GameCenterLeaderboardSetsReleasesGetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem?), TypeInfoPropertyName = "NullableIncludedItem2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem2?), TypeInfoPropertyName = "NullableIncludedItem22_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem3?), TypeInfoPropertyName = "NullableIncludedItem32_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem4?), TypeInfoPropertyName = "NullableIncludedItem42_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem5?), TypeInfoPropertyName = "NullableIncludedItem52_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem6?), TypeInfoPropertyName = "NullableIncludedItem62_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem7?), TypeInfoPropertyName = "NullableIncludedItem72_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem8?), TypeInfoPropertyName = "NullableIncludedItem82")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem75?), TypeInfoPropertyName = "NullableIncludedItem752")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem76?), TypeInfoPropertyName = "NullableIncludedItem762")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem77?), TypeInfoPropertyName = "NullableIncludedItem772")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem78?), TypeInfoPropertyName = "NullableIncludedItem782")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem79?), TypeInfoPropertyName = "NullableIncludedItem792")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem80?), TypeInfoPropertyName = "NullableIncludedItem802")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterVersionState?), TypeInfoPropertyName = "NullableGameCenterVersionState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem83?), TypeInfoPropertyName = "NullableIncludedItem832")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem84?), TypeInfoPropertyName = "NullableIncludedItem842")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem85?), TypeInfoPropertyName = "NullableIncludedItem852")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem86?), TypeInfoPropertyName = "NullableIncludedItem862")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterActivityType?), TypeInfoPropertyName = "NullableGameCenterActivityType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterActivityAttributesPlayStyle?), TypeInfoPropertyName = "NullableGameCenterActivityAttributesPlayStyle2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterActivityRelationshipsGameCenterDetailDataType?), TypeInfoPropertyName = "NullableGameCenterActivityRelationshipsGameCenterDetailDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterActivityRelationshipsGameCenterGroupDataType?), TypeInfoPropertyName = "NullableGameCenterActivityRelationshipsGameCenterGroupDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterActivityRelationshipsAchievementsDataItemType?), TypeInfoPropertyName = "NullableGameCenterActivityRelationshipsAchievementsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterActivityRelationshipsAchievementsV2DataItemType?), TypeInfoPropertyName = "NullableGameCenterActivityRelationshipsAchievementsV2DataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterActivityRelationshipsLeaderboardsDataItemType?), TypeInfoPropertyName = "NullableGameCenterActivityRelationshipsLeaderboardsDataItemType2")]
    internal sealed partial class GameCenterLeaderboardSetsSourceGenerationContextChunk1 : global::System.Text.Json.Serialization.JsonSerializerContext
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterChallengeType?), TypeInfoPropertyName = "NullableGameCenterChallengeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterChallengeAttributesChallengeType?), TypeInfoPropertyName = "NullableGameCenterChallengeAttributesChallengeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterChallengeRelationshipsGameCenterDetailDataType?), TypeInfoPropertyName = "NullableGameCenterChallengeRelationshipsGameCenterDetailDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterChallengeRelationshipsGameCenterGroupDataType?), TypeInfoPropertyName = "NullableGameCenterChallengeRelationshipsGameCenterGroupDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterChallengeRelationshipsVersionsDataItemType?), TypeInfoPropertyName = "NullableGameCenterChallengeRelationshipsVersionsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterChallengeRelationshipsLeaderboardDataType?), TypeInfoPropertyName = "NullableGameCenterChallengeRelationshipsLeaderboardDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterChallengeRelationshipsLeaderboardV2DataType?), TypeInfoPropertyName = "NullableGameCenterChallengeRelationshipsLeaderboardV2DataType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardLocalizationType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardLocalizationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardFormatter?), TypeInfoPropertyName = "NullableGameCenterLeaderboardFormatter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardLocalizationRelationshipsGameCenterLeaderboardDataType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardLocalizationRelationshipsGameCenterLeaderboardDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardLocalizationRelationshipsGameCenterLeaderboardImageDataType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardLocalizationRelationshipsGameCenterLeaderboardImageDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem106?), TypeInfoPropertyName = "NullableIncludedItem1062")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem107?), TypeInfoPropertyName = "NullableIncludedItem1072")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem108?), TypeInfoPropertyName = "NullableIncludedItem1082")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem109?), TypeInfoPropertyName = "NullableIncludedItem1092")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardReleaseType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardReleaseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardReleaseRelationshipsGameCenterDetailDataType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardReleaseRelationshipsGameCenterDetailDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardReleaseRelationshipsGameCenterLeaderboardDataType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardReleaseRelationshipsGameCenterLeaderboardDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem110?), TypeInfoPropertyName = "NullableIncludedItem1102")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem111?), TypeInfoPropertyName = "NullableIncludedItem1112")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetImageType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardSetImageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetImageRelationshipsGameCenterLeaderboardSetLocalizationDataType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardSetImageRelationshipsGameCenterLeaderboardSetLocalizationDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetLocalizationType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardSetLocalizationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetLocalizationRelationshipsGameCenterLeaderboardSetDataType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardSetLocalizationRelationshipsGameCenterLeaderboardSetDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetLocalizationRelationshipsGameCenterLeaderboardSetImageDataType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardSetLocalizationRelationshipsGameCenterLeaderboardSetImageDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem112?), TypeInfoPropertyName = "NullableIncludedItem1122")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetLocalizationsResponseIncludedItemDiscriminatorType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardSetLocalizationsResponseIncludedItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem113?), TypeInfoPropertyName = "NullableIncludedItem1132")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetLocalizationV2Type?), TypeInfoPropertyName = "NullableGameCenterLeaderboardSetLocalizationV2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetLocalizationV2RelationshipsVersionDataType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardSetLocalizationV2RelationshipsVersionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetLocalizationV2RelationshipsImageDataType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardSetLocalizationV2RelationshipsImageDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem114?), TypeInfoPropertyName = "NullableIncludedItem1142")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem115?), TypeInfoPropertyName = "NullableIncludedItem1152")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem116?), TypeInfoPropertyName = "NullableIncludedItem1162")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem117?), TypeInfoPropertyName = "NullableIncludedItem1172")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetReleaseType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardSetReleaseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetReleaseRelationshipsGameCenterDetailDataType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardSetReleaseRelationshipsGameCenterDetailDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetReleaseRelationshipsGameCenterLeaderboardSetDataType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardSetReleaseRelationshipsGameCenterLeaderboardSetDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem118?), TypeInfoPropertyName = "NullableIncludedItem1182")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetReleasesResponseIncludedItemDiscriminatorType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardSetReleasesResponseIncludedItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem119?), TypeInfoPropertyName = "NullableIncludedItem1192")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetVersionV2Type?), TypeInfoPropertyName = "NullableGameCenterLeaderboardSetVersionV2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetVersionV2RelationshipsLeaderboardSetDataType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardSetVersionV2RelationshipsLeaderboardSetDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetVersionV2RelationshipsLocalizationsDataItemType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardSetVersionV2RelationshipsLocalizationsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetVersionV2InlineCreateType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardSetVersionV2InlineCreateType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetVersionV2InlineCreateRelationshipsLeaderboardSetDataType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardSetVersionV2InlineCreateRelationshipsLeaderboardSetDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem120?), TypeInfoPropertyName = "NullableIncludedItem1202")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetVersionsV2ResponseIncludedItemDiscriminatorType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardSetVersionsV2ResponseIncludedItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem121?), TypeInfoPropertyName = "NullableIncludedItem1212")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2Type?), TypeInfoPropertyName = "NullableGameCenterLeaderboardSetV2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2RelationshipsGameCenterDetailDataType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardSetV2RelationshipsGameCenterDetailDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2RelationshipsGameCenterGroupDataType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardSetV2RelationshipsGameCenterGroupDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2RelationshipsGameCenterLeaderboardsDataItemType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardSetV2RelationshipsGameCenterLeaderboardsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2RelationshipsVersionsDataItemType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardSetV2RelationshipsVersionsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem122?), TypeInfoPropertyName = "NullableIncludedItem1222")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem123?), TypeInfoPropertyName = "NullableIncludedItem1232")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2ResponseIncludedItemDiscriminatorType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardSetV2ResponseIncludedItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2CreateRequestDataType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardSetV2CreateRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2CreateRequestDataRelationshipsGameCenterDetailDataType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardSetV2CreateRequestDataRelationshipsGameCenterDetailDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2CreateRequestDataRelationshipsGameCenterGroupDataType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardSetV2CreateRequestDataRelationshipsGameCenterGroupDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2CreateRequestDataRelationshipsGameCenterLeaderboardsDataItemType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardSetV2CreateRequestDataRelationshipsGameCenterLeaderboardsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2CreateRequestDataRelationshipsVersionsDataItemType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardSetV2CreateRequestDataRelationshipsVersionsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2UpdateRequestDataType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardSetV2UpdateRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardSetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetRelationshipsGameCenterDetailDataType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardSetRelationshipsGameCenterDetailDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetRelationshipsGameCenterGroupDataType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardSetRelationshipsGameCenterGroupDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetRelationshipsGroupLeaderboardSetDataType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardSetRelationshipsGroupLeaderboardSetDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetRelationshipsLocalizationsDataItemType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardSetRelationshipsLocalizationsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetRelationshipsGameCenterLeaderboardsDataItemType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardSetRelationshipsGameCenterLeaderboardsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetRelationshipsReleasesDataItemType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardSetRelationshipsReleasesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem124?), TypeInfoPropertyName = "NullableIncludedItem1242")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem125?), TypeInfoPropertyName = "NullableIncludedItem1252")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetResponseIncludedItemDiscriminatorType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardSetResponseIncludedItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetCreateRequestDataType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardSetCreateRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetCreateRequestDataRelationshipsGameCenterDetailDataType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardSetCreateRequestDataRelationshipsGameCenterDetailDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetCreateRequestDataRelationshipsGameCenterGroupDataType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardSetCreateRequestDataRelationshipsGameCenterGroupDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetCreateRequestDataRelationshipsGameCenterLeaderboardsDataItemType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardSetCreateRequestDataRelationshipsGameCenterLeaderboardsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetUpdateRequestDataType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardSetUpdateRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardVersionV2Type?), TypeInfoPropertyName = "NullableGameCenterLeaderboardVersionV2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardVersionV2RelationshipsLeaderboardDataType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardVersionV2RelationshipsLeaderboardDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardVersionV2RelationshipsLocalizationsDataItemType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardVersionV2RelationshipsLocalizationsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem126?), TypeInfoPropertyName = "NullableIncludedItem1262")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem127?), TypeInfoPropertyName = "NullableIncludedItem1272")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardAttributesSubmissionType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardAttributesSubmissionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardAttributesScoreSortType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardAttributesScoreSortType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardAttributesVisibility?), TypeInfoPropertyName = "NullableGameCenterLeaderboardAttributesVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardRelationshipsGameCenterDetailDataType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardRelationshipsGameCenterDetailDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardRelationshipsGameCenterGroupDataType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardRelationshipsGameCenterGroupDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardRelationshipsGroupLeaderboardDataType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardRelationshipsGroupLeaderboardDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardRelationshipsGameCenterLeaderboardSetsDataItemType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardRelationshipsGameCenterLeaderboardSetsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardRelationshipsLocalizationsDataItemType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardRelationshipsLocalizationsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardRelationshipsReleasesDataItemType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardRelationshipsReleasesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardRelationshipsActivityDataType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardRelationshipsActivityDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardRelationshipsChallengeDataType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardRelationshipsChallengeDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem128?), TypeInfoPropertyName = "NullableIncludedItem1282")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardsResponseIncludedItemDiscriminatorType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardsResponseIncludedItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem129?), TypeInfoPropertyName = "NullableIncludedItem1292")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardV2Type?), TypeInfoPropertyName = "NullableGameCenterLeaderboardV2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardV2AttributesSubmissionType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardV2AttributesSubmissionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardV2AttributesScoreSortType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardV2AttributesScoreSortType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardV2AttributesVisibility?), TypeInfoPropertyName = "NullableGameCenterLeaderboardV2AttributesVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsGameCenterDetailDataType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardV2RelationshipsGameCenterDetailDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsGameCenterGroupDataType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardV2RelationshipsGameCenterGroupDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsGameCenterLeaderboardSetsDataItemType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardV2RelationshipsGameCenterLeaderboardSetsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsActivityDataType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardV2RelationshipsActivityDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsChallengeDataType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardV2RelationshipsChallengeDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsVersionsDataItemType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardV2RelationshipsVersionsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem130?), TypeInfoPropertyName = "NullableIncludedItem1302")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardsV2ResponseIncludedItemDiscriminatorType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardsV2ResponseIncludedItemDiscriminatorType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2GameCenterLeaderboardsLinkagesResponseDataItemType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardSetV2GameCenterLeaderboardsLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2GameCenterLeaderboardsLinkagesRequestDataItemType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardSetV2GameCenterLeaderboardsLinkagesRequestDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2VersionsLinkagesResponseDataItemType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardSetV2VersionsLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetGameCenterLeaderboardsLinkagesResponseDataItemType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardSetGameCenterLeaderboardsLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetGameCenterLeaderboardsLinkagesRequestDataItemType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardSetGameCenterLeaderboardsLinkagesRequestDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetGroupLeaderboardSetLinkageResponseDataType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardSetGroupLeaderboardSetLinkageResponseDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetGroupLeaderboardSetLinkageRequestDataType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardSetGroupLeaderboardSetLinkageRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetLocalizationsLinkagesResponseDataItemType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardSetLocalizationsLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetReleasesLinkagesResponseDataItemType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardSetReleasesLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.OneOf<global::AppStoreConnect.ErrorSourcePointer, global::AppStoreConnect.ErrorSourceParameter>?), TypeInfoPropertyName = "NullableOneOfErrorSourcePointerErrorSourceParameter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.OneOf<string, global::AppStoreConnect.ErrorLinksAssociated>?), TypeInfoPropertyName = "NullableOneOfStringErrorLinksAssociated2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppMediaAssetStateState?), TypeInfoPropertyName = "NullableAppMediaAssetStateState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterLeaderboardSet?), TypeInfoPropertyName = "NullableGameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterLeaderboardSet2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterDetail?), TypeInfoPropertyName = "NullableGameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterGroup?), TypeInfoPropertyName = "NullableGameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterGroup2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterLeaderboard?), TypeInfoPropertyName = "NullableGameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterLeaderboard2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterLeaderboardSetVersion?), TypeInfoPropertyName = "NullableGameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterLeaderboardSetVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetsV2GetInstanceIncludeItem?), TypeInfoPropertyName = "NullableGameCenterLeaderboardSetsV2GetInstanceIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGetInstanceFieldsGameCenterLeaderboardSet?), TypeInfoPropertyName = "NullableGameCenterLeaderboardSetsGetInstanceFieldsGameCenterLeaderboardSet2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGetInstanceFieldsGameCenterDetail?), TypeInfoPropertyName = "NullableGameCenterLeaderboardSetsGetInstanceFieldsGameCenterDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGetInstanceFieldsGameCenterGroup?), TypeInfoPropertyName = "NullableGameCenterLeaderboardSetsGetInstanceFieldsGameCenterGroup2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGetInstanceFieldsGameCenterLeaderboardSetLocalization?), TypeInfoPropertyName = "NullableGameCenterLeaderboardSetsGetInstanceFieldsGameCenterLeaderboardSetLocalization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGetInstanceFieldsGameCenterLeaderboard?), TypeInfoPropertyName = "NullableGameCenterLeaderboardSetsGetInstanceFieldsGameCenterLeaderboard2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGetInstanceFieldsGameCenterLeaderboardSetRelease?), TypeInfoPropertyName = "NullableGameCenterLeaderboardSetsGetInstanceFieldsGameCenterLeaderboardSetRelease2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGetInstanceIncludeItem?), TypeInfoPropertyName = "NullableGameCenterLeaderboardSetsGetInstanceIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboard?), TypeInfoPropertyName = "NullableGameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboard2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterDetail?), TypeInfoPropertyName = "NullableGameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterGroup?), TypeInfoPropertyName = "NullableGameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterGroup2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardSet?), TypeInfoPropertyName = "NullableGameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardSet2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie?), TypeInfoPropertyName = "NullableGameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterChallenge?), TypeInfoPropertyName = "NullableGameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterChallenge2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardVersion?), TypeInfoPropertyName = "NullableGameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedIncludeItem?), TypeInfoPropertyName = "NullableGameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetsV2VersionsGetToManyRelatedFieldsGameCenterLeaderboardSetVersion?), TypeInfoPropertyName = "NullableGameCenterLeaderboardSetsV2VersionsGetToManyRelatedFieldsGameCenterLeaderboardSetVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetsV2VersionsGetToManyRelatedFieldsGameCenterLeaderboardSet?), TypeInfoPropertyName = "NullableGameCenterLeaderboardSetsV2VersionsGetToManyRelatedFieldsGameCenterLeaderboardSet2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetsV2VersionsGetToManyRelatedFieldsGameCenterLeaderboardSetLocalization?), TypeInfoPropertyName = "NullableGameCenterLeaderboardSetsV2VersionsGetToManyRelatedFieldsGameCenterLeaderboardSetLocalization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetsV2VersionsGetToManyRelatedIncludeItem?), TypeInfoPropertyName = "NullableGameCenterLeaderboardSetsV2VersionsGetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboard?), TypeInfoPropertyName = "NullableGameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboard2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterDetail?), TypeInfoPropertyName = "NullableGameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterGroup?), TypeInfoPropertyName = "NullableGameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterGroup2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardSet?), TypeInfoPropertyName = "NullableGameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardSet2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardLocalization?), TypeInfoPropertyName = "NullableGameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardLocalization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardRelease?), TypeInfoPropertyName = "NullableGameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardRelease2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie?), TypeInfoPropertyName = "NullableGameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterChallenge?), TypeInfoPropertyName = "NullableGameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterChallenge2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedIncludeItem?), TypeInfoPropertyName = "NullableGameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboardSet?), TypeInfoPropertyName = "NullableGameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboardSet2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterDetail?), TypeInfoPropertyName = "NullableGameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterGroup?), TypeInfoPropertyName = "NullableGameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterGroup2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboardSetLocalization?), TypeInfoPropertyName = "NullableGameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboardSetLocalization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboard?), TypeInfoPropertyName = "NullableGameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboard2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboardSetRelease?), TypeInfoPropertyName = "NullableGameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboardSetRelease2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedIncludeItem?), TypeInfoPropertyName = "NullableGameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetsLocalizationsGetToManyRelatedFieldsGameCenterLeaderboardSetLocalization?), TypeInfoPropertyName = "NullableGameCenterLeaderboardSetsLocalizationsGetToManyRelatedFieldsGameCenterLeaderboardSetLocalization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetsLocalizationsGetToManyRelatedFieldsGameCenterLeaderboardSet?), TypeInfoPropertyName = "NullableGameCenterLeaderboardSetsLocalizationsGetToManyRelatedFieldsGameCenterLeaderboardSet2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetsLocalizationsGetToManyRelatedFieldsGameCenterLeaderboardSetImage?), TypeInfoPropertyName = "NullableGameCenterLeaderboardSetsLocalizationsGetToManyRelatedFieldsGameCenterLeaderboardSetImage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetsLocalizationsGetToManyRelatedIncludeItem?), TypeInfoPropertyName = "NullableGameCenterLeaderboardSetsLocalizationsGetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetsReleasesGetToManyRelatedFieldsGameCenterLeaderboardSetRelease?), TypeInfoPropertyName = "NullableGameCenterLeaderboardSetsReleasesGetToManyRelatedFieldsGameCenterLeaderboardSetRelease2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetsReleasesGetToManyRelatedFieldsGameCenterDetail?), TypeInfoPropertyName = "NullableGameCenterLeaderboardSetsReleasesGetToManyRelatedFieldsGameCenterDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetsReleasesGetToManyRelatedFieldsGameCenterLeaderboardSet?), TypeInfoPropertyName = "NullableGameCenterLeaderboardSetsReleasesGetToManyRelatedFieldsGameCenterLeaderboardSet2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetsReleasesGetToManyRelatedIncludeItem?), TypeInfoPropertyName = "NullableGameCenterLeaderboardSetsReleasesGetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.UploadOperation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterActivityRelationshipsAchievementsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterActivityRelationshipsAchievementsV2DataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterActivityRelationshipsLeaderboardsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterActivityRelationshipsLeaderboardsV2DataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterActivityRelationshipsVersionsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterChallengeRelationshipsVersionsDataItem>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterLeaderboardSetLocalization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.IncludedItem112>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterLeaderboardSetRelease>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.IncludedItem118>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterLeaderboardSetVersionV2RelationshipsLocalizationsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterLeaderboardSetVersionV2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.IncludedItem120>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterLeaderboardSetV2RelationshipsGameCenterLeaderboardsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterLeaderboardSetV2RelationshipsVersionsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.IncludedItem123>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterLeaderboardSetV2CreateRequestDataRelationshipsGameCenterLeaderboardsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterLeaderboardSetV2CreateRequestDataRelationshipsVersionsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterLeaderboardSetVersionV2InlineCreate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterLeaderboardSetRelationshipsLocalizationsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterLeaderboardSetRelationshipsGameCenterLeaderboardsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterLeaderboardSetRelationshipsReleasesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.IncludedItem125>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterLeaderboardSetCreateRequestDataRelationshipsGameCenterLeaderboardsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterLeaderboardVersionV2RelationshipsLocalizationsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterLeaderboardRelationshipsGameCenterLeaderboardSetsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterLeaderboardRelationshipsLocalizationsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterLeaderboardRelationshipsReleasesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterLeaderboard>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.IncludedItem128>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsGameCenterLeaderboardSetsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsVersionsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterLeaderboardV2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.IncludedItem130>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterLeaderboardSetV2GameCenterLeaderboardsLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterLeaderboardSetV2GameCenterLeaderboardsLinkagesRequestDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterLeaderboardSetV2VersionsLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterLeaderboardSetGameCenterLeaderboardsLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterLeaderboardSetGameCenterLeaderboardsLinkagesRequestDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterLeaderboardSetLocalizationsLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterLeaderboardSetReleasesLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.ErrorResponseError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppMediaStateError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.HttpHeader>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterLeaderboardSet>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterLeaderboard>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterLeaderboardSetVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterLeaderboardSetsV2GetInstanceIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterLeaderboardSetsGetInstanceFieldsGameCenterLeaderboardSet>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterLeaderboardSetsGetInstanceFieldsGameCenterDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterLeaderboardSetsGetInstanceFieldsGameCenterGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterLeaderboardSetsGetInstanceFieldsGameCenterLeaderboardSetLocalization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterLeaderboardSetsGetInstanceFieldsGameCenterLeaderboard>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterLeaderboardSetsGetInstanceFieldsGameCenterLeaderboardSetRelease>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterLeaderboardSetsGetInstanceIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboard>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardSet>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterChallenge>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterLeaderboardSetsV2VersionsGetToManyRelatedFieldsGameCenterLeaderboardSetVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterLeaderboardSetsV2VersionsGetToManyRelatedFieldsGameCenterLeaderboardSet>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterLeaderboardSetsV2VersionsGetToManyRelatedFieldsGameCenterLeaderboardSetLocalization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterLeaderboardSetsV2VersionsGetToManyRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboard>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardSet>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardLocalization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardRelease>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterChallenge>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboardSet>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboardSetLocalization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboard>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboardSetRelease>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterLeaderboardSetsLocalizationsGetToManyRelatedFieldsGameCenterLeaderboardSetLocalization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterLeaderboardSetsLocalizationsGetToManyRelatedFieldsGameCenterLeaderboardSet>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterLeaderboardSetsLocalizationsGetToManyRelatedFieldsGameCenterLeaderboardSetImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterLeaderboardSetsLocalizationsGetToManyRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterLeaderboardSetsReleasesGetToManyRelatedFieldsGameCenterLeaderboardSetRelease>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterLeaderboardSetsReleasesGetToManyRelatedFieldsGameCenterDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterLeaderboardSetsReleasesGetToManyRelatedFieldsGameCenterLeaderboardSet>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterLeaderboardSetsReleasesGetToManyRelatedIncludeItem>))]
    internal sealed partial class GameCenterLeaderboardSetsSourceGenerationContextChunk2 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GameCenterLeaderboardSetsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static GameCenterLeaderboardSetsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private GameCenterLeaderboardSetsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.GameCenterActivityType)

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

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeAttributesChallengeType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeAttributesChallengeType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeRelationshipsGameCenterDetailDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeRelationshipsGameCenterDetailDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeRelationshipsGameCenterGroupDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeRelationshipsGameCenterGroupDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeRelationshipsVersionsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeRelationshipsVersionsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeRelationshipsLeaderboardDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeRelationshipsLeaderboardDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeRelationshipsLeaderboardV2DataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeRelationshipsLeaderboardV2DataType?)

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

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardLocalizationType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardLocalizationType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardLocalizationRelationshipsGameCenterLeaderboardDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardLocalizationRelationshipsGameCenterLeaderboardDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardLocalizationRelationshipsGameCenterLeaderboardImageDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardLocalizationRelationshipsGameCenterLeaderboardImageDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardReleaseType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardReleaseType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardReleaseRelationshipsGameCenterDetailDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardReleaseRelationshipsGameCenterDetailDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardReleaseRelationshipsGameCenterLeaderboardDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardReleaseRelationshipsGameCenterLeaderboardDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetImageType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetImageType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetImageRelationshipsGameCenterLeaderboardSetLocalizationDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetImageRelationshipsGameCenterLeaderboardSetLocalizationDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetLocalizationType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetLocalizationType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetLocalizationRelationshipsGameCenterLeaderboardSetDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetLocalizationRelationshipsGameCenterLeaderboardSetDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetLocalizationRelationshipsGameCenterLeaderboardSetImageDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetLocalizationRelationshipsGameCenterLeaderboardSetImageDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetLocalizationsResponseIncludedItemDiscriminatorType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetLocalizationsResponseIncludedItemDiscriminatorType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetLocalizationV2Type)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetLocalizationV2Type?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetLocalizationV2RelationshipsVersionDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetLocalizationV2RelationshipsVersionDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetLocalizationV2RelationshipsImageDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetLocalizationV2RelationshipsImageDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetReleaseType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetReleaseType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetReleaseRelationshipsGameCenterDetailDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetReleaseRelationshipsGameCenterDetailDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetReleaseRelationshipsGameCenterLeaderboardSetDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetReleaseRelationshipsGameCenterLeaderboardSetDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetReleasesResponseIncludedItemDiscriminatorType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetReleasesResponseIncludedItemDiscriminatorType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetVersionV2Type)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetVersionV2Type?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetVersionV2RelationshipsLeaderboardSetDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetVersionV2RelationshipsLeaderboardSetDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetVersionV2RelationshipsLocalizationsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetVersionV2RelationshipsLocalizationsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetVersionV2InlineCreateType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetVersionV2InlineCreateType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetVersionV2InlineCreateRelationshipsLeaderboardSetDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetVersionV2InlineCreateRelationshipsLeaderboardSetDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetVersionsV2ResponseIncludedItemDiscriminatorType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetVersionsV2ResponseIncludedItemDiscriminatorType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2Type)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2Type?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2RelationshipsGameCenterDetailDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2RelationshipsGameCenterDetailDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2RelationshipsGameCenterGroupDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2RelationshipsGameCenterGroupDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2RelationshipsGameCenterLeaderboardsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2RelationshipsGameCenterLeaderboardsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2RelationshipsVersionsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2RelationshipsVersionsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2ResponseIncludedItemDiscriminatorType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2ResponseIncludedItemDiscriminatorType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2CreateRequestDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2CreateRequestDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2CreateRequestDataRelationshipsGameCenterDetailDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2CreateRequestDataRelationshipsGameCenterDetailDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2CreateRequestDataRelationshipsGameCenterGroupDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2CreateRequestDataRelationshipsGameCenterGroupDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2CreateRequestDataRelationshipsGameCenterLeaderboardsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2CreateRequestDataRelationshipsGameCenterLeaderboardsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2CreateRequestDataRelationshipsVersionsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2CreateRequestDataRelationshipsVersionsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2UpdateRequestDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2UpdateRequestDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetRelationshipsGameCenterDetailDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetRelationshipsGameCenterDetailDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetRelationshipsGameCenterGroupDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetRelationshipsGameCenterGroupDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetRelationshipsGroupLeaderboardSetDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetRelationshipsGroupLeaderboardSetDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetRelationshipsLocalizationsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetRelationshipsLocalizationsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetRelationshipsGameCenterLeaderboardsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetRelationshipsGameCenterLeaderboardsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetRelationshipsReleasesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetRelationshipsReleasesDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetResponseIncludedItemDiscriminatorType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetResponseIncludedItemDiscriminatorType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetCreateRequestDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetCreateRequestDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetCreateRequestDataRelationshipsGameCenterDetailDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetCreateRequestDataRelationshipsGameCenterDetailDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetCreateRequestDataRelationshipsGameCenterGroupDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetCreateRequestDataRelationshipsGameCenterGroupDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetCreateRequestDataRelationshipsGameCenterLeaderboardsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetCreateRequestDataRelationshipsGameCenterLeaderboardsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetUpdateRequestDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetUpdateRequestDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardVersionV2Type)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardVersionV2Type?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardVersionV2RelationshipsLeaderboardDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardVersionV2RelationshipsLeaderboardDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardVersionV2RelationshipsLocalizationsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardVersionV2RelationshipsLocalizationsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardAttributesSubmissionType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardAttributesSubmissionType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardAttributesScoreSortType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardAttributesScoreSortType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardAttributesVisibility)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardAttributesVisibility?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardRelationshipsGameCenterDetailDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardRelationshipsGameCenterDetailDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardRelationshipsGameCenterGroupDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardRelationshipsGameCenterGroupDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardRelationshipsGroupLeaderboardDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardRelationshipsGroupLeaderboardDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardRelationshipsGameCenterLeaderboardSetsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardRelationshipsGameCenterLeaderboardSetsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardRelationshipsLocalizationsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardRelationshipsLocalizationsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardRelationshipsReleasesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardRelationshipsReleasesDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardRelationshipsActivityDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardRelationshipsActivityDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardRelationshipsChallengeDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardRelationshipsChallengeDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardsResponseIncludedItemDiscriminatorType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardsResponseIncludedItemDiscriminatorType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardV2Type)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardV2Type?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardV2AttributesSubmissionType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardV2AttributesSubmissionType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardV2AttributesScoreSortType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardV2AttributesScoreSortType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardV2AttributesVisibility)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardV2AttributesVisibility?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsGameCenterDetailDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsGameCenterDetailDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsGameCenterGroupDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsGameCenterGroupDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsGameCenterLeaderboardSetsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsGameCenterLeaderboardSetsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsActivityDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsActivityDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsChallengeDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsChallengeDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsVersionsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsVersionsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardsV2ResponseIncludedItemDiscriminatorType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardsV2ResponseIncludedItemDiscriminatorType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2GameCenterLeaderboardsLinkagesResponseDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2GameCenterLeaderboardsLinkagesResponseDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2GameCenterLeaderboardsLinkagesRequestDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2GameCenterLeaderboardsLinkagesRequestDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2VersionsLinkagesResponseDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2VersionsLinkagesResponseDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetGameCenterLeaderboardsLinkagesResponseDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetGameCenterLeaderboardsLinkagesResponseDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetGameCenterLeaderboardsLinkagesRequestDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetGameCenterLeaderboardsLinkagesRequestDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetGroupLeaderboardSetLinkageResponseDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetGroupLeaderboardSetLinkageResponseDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetGroupLeaderboardSetLinkageRequestDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetGroupLeaderboardSetLinkageRequestDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetLocalizationsLinkagesResponseDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetLocalizationsLinkagesResponseDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetReleasesLinkagesResponseDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetReleasesLinkagesResponseDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppMediaAssetStateState)

                    || typeToConvert == typeof(global::AppStoreConnect.AppMediaAssetStateState?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardFormatter)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardFormatter?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterVersionState)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterVersionState?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterLeaderboardSet)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterLeaderboardSet?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterDetail)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterDetail?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterGroup)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterGroup?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterLeaderboard)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterLeaderboard?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterLeaderboardSetVersion)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterLeaderboardSetVersion?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsV2GetInstanceIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsV2GetInstanceIncludeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGetInstanceFieldsGameCenterLeaderboardSet)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGetInstanceFieldsGameCenterLeaderboardSet?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGetInstanceFieldsGameCenterDetail)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGetInstanceFieldsGameCenterDetail?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGetInstanceFieldsGameCenterGroup)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGetInstanceFieldsGameCenterGroup?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGetInstanceFieldsGameCenterLeaderboardSetLocalization)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGetInstanceFieldsGameCenterLeaderboardSetLocalization?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGetInstanceFieldsGameCenterLeaderboard)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGetInstanceFieldsGameCenterLeaderboard?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGetInstanceFieldsGameCenterLeaderboardSetRelease)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGetInstanceFieldsGameCenterLeaderboardSetRelease?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGetInstanceIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGetInstanceIncludeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboard)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboard?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterDetail)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterDetail?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterGroup)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterGroup?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardSet)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardSet?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterChallenge)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterChallenge?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardVersion)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardVersion?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedIncludeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsV2VersionsGetToManyRelatedFieldsGameCenterLeaderboardSetVersion)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsV2VersionsGetToManyRelatedFieldsGameCenterLeaderboardSetVersion?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsV2VersionsGetToManyRelatedFieldsGameCenterLeaderboardSet)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsV2VersionsGetToManyRelatedFieldsGameCenterLeaderboardSet?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsV2VersionsGetToManyRelatedFieldsGameCenterLeaderboardSetLocalization)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsV2VersionsGetToManyRelatedFieldsGameCenterLeaderboardSetLocalization?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsV2VersionsGetToManyRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsV2VersionsGetToManyRelatedIncludeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboard)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboard?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterDetail)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterDetail?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterGroup)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterGroup?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardSet)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardSet?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardLocalization)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardLocalization?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardRelease)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardRelease?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterChallenge)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterChallenge?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedIncludeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboardSet)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboardSet?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterDetail)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterDetail?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterGroup)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterGroup?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboardSetLocalization)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboardSetLocalization?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboard)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboard?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboardSetRelease)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboardSetRelease?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedIncludeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsLocalizationsGetToManyRelatedFieldsGameCenterLeaderboardSetLocalization)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsLocalizationsGetToManyRelatedFieldsGameCenterLeaderboardSetLocalization?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsLocalizationsGetToManyRelatedFieldsGameCenterLeaderboardSet)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsLocalizationsGetToManyRelatedFieldsGameCenterLeaderboardSet?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsLocalizationsGetToManyRelatedFieldsGameCenterLeaderboardSetImage)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsLocalizationsGetToManyRelatedFieldsGameCenterLeaderboardSetImage?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsLocalizationsGetToManyRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsLocalizationsGetToManyRelatedIncludeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsReleasesGetToManyRelatedFieldsGameCenterLeaderboardSetRelease)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsReleasesGetToManyRelatedFieldsGameCenterLeaderboardSetRelease?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsReleasesGetToManyRelatedFieldsGameCenterDetail)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsReleasesGetToManyRelatedFieldsGameCenterDetail?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsReleasesGetToManyRelatedFieldsGameCenterLeaderboardSet)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsReleasesGetToManyRelatedFieldsGameCenterLeaderboardSet?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsReleasesGetToManyRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsReleasesGetToManyRelatedIncludeItem?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
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

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterChallengeTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterChallengeTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeAttributesChallengeType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterChallengeAttributesChallengeTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeAttributesChallengeType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterChallengeAttributesChallengeTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeRelationshipsGameCenterDetailDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterChallengeRelationshipsGameCenterDetailDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeRelationshipsGameCenterDetailDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterChallengeRelationshipsGameCenterDetailDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeRelationshipsGameCenterGroupDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterChallengeRelationshipsGameCenterGroupDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeRelationshipsGameCenterGroupDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterChallengeRelationshipsGameCenterGroupDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeRelationshipsVersionsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterChallengeRelationshipsVersionsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeRelationshipsVersionsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterChallengeRelationshipsVersionsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeRelationshipsLeaderboardDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterChallengeRelationshipsLeaderboardDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeRelationshipsLeaderboardDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterChallengeRelationshipsLeaderboardDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeRelationshipsLeaderboardV2DataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterChallengeRelationshipsLeaderboardV2DataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeRelationshipsLeaderboardV2DataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterChallengeRelationshipsLeaderboardV2DataTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardLocalizationType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardLocalizationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardLocalizationType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardLocalizationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardLocalizationRelationshipsGameCenterLeaderboardDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardLocalizationRelationshipsGameCenterLeaderboardDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardLocalizationRelationshipsGameCenterLeaderboardDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardLocalizationRelationshipsGameCenterLeaderboardDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardLocalizationRelationshipsGameCenterLeaderboardImageDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardLocalizationRelationshipsGameCenterLeaderboardImageDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardLocalizationRelationshipsGameCenterLeaderboardImageDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardLocalizationRelationshipsGameCenterLeaderboardImageDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardReleaseType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardReleaseTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardReleaseType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardReleaseTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardReleaseRelationshipsGameCenterDetailDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardReleaseRelationshipsGameCenterDetailDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardReleaseRelationshipsGameCenterDetailDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardReleaseRelationshipsGameCenterDetailDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardReleaseRelationshipsGameCenterLeaderboardDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardReleaseRelationshipsGameCenterLeaderboardDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardReleaseRelationshipsGameCenterLeaderboardDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardReleaseRelationshipsGameCenterLeaderboardDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetImageType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetImageTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetImageType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetImageTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetImageRelationshipsGameCenterLeaderboardSetLocalizationDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetImageRelationshipsGameCenterLeaderboardSetLocalizationDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetImageRelationshipsGameCenterLeaderboardSetLocalizationDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetImageRelationshipsGameCenterLeaderboardSetLocalizationDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetLocalizationType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetLocalizationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetLocalizationType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetLocalizationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetLocalizationRelationshipsGameCenterLeaderboardSetDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetLocalizationRelationshipsGameCenterLeaderboardSetDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetLocalizationRelationshipsGameCenterLeaderboardSetDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetLocalizationRelationshipsGameCenterLeaderboardSetDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetLocalizationRelationshipsGameCenterLeaderboardSetImageDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetLocalizationRelationshipsGameCenterLeaderboardSetImageDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetLocalizationRelationshipsGameCenterLeaderboardSetImageDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetLocalizationRelationshipsGameCenterLeaderboardSetImageDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetLocalizationsResponseIncludedItemDiscriminatorType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetLocalizationsResponseIncludedItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetLocalizationsResponseIncludedItemDiscriminatorType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetLocalizationsResponseIncludedItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetLocalizationV2Type))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetLocalizationV2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetLocalizationV2Type?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetLocalizationV2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetLocalizationV2RelationshipsVersionDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetLocalizationV2RelationshipsVersionDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetLocalizationV2RelationshipsVersionDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetLocalizationV2RelationshipsVersionDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetLocalizationV2RelationshipsImageDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetLocalizationV2RelationshipsImageDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetLocalizationV2RelationshipsImageDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetLocalizationV2RelationshipsImageDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetReleaseType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetReleaseTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetReleaseType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetReleaseTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetReleaseRelationshipsGameCenterDetailDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetReleaseRelationshipsGameCenterDetailDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetReleaseRelationshipsGameCenterDetailDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetReleaseRelationshipsGameCenterDetailDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetReleaseRelationshipsGameCenterLeaderboardSetDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetReleaseRelationshipsGameCenterLeaderboardSetDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetReleaseRelationshipsGameCenterLeaderboardSetDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetReleaseRelationshipsGameCenterLeaderboardSetDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetReleasesResponseIncludedItemDiscriminatorType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetReleasesResponseIncludedItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetReleasesResponseIncludedItemDiscriminatorType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetReleasesResponseIncludedItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetVersionV2Type))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetVersionV2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetVersionV2Type?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetVersionV2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetVersionV2RelationshipsLeaderboardSetDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetVersionV2RelationshipsLeaderboardSetDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetVersionV2RelationshipsLeaderboardSetDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetVersionV2RelationshipsLeaderboardSetDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetVersionV2RelationshipsLocalizationsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetVersionV2RelationshipsLocalizationsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetVersionV2RelationshipsLocalizationsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetVersionV2RelationshipsLocalizationsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetVersionV2InlineCreateType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetVersionV2InlineCreateTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetVersionV2InlineCreateType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetVersionV2InlineCreateTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetVersionV2InlineCreateRelationshipsLeaderboardSetDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetVersionV2InlineCreateRelationshipsLeaderboardSetDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetVersionV2InlineCreateRelationshipsLeaderboardSetDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetVersionV2InlineCreateRelationshipsLeaderboardSetDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetVersionsV2ResponseIncludedItemDiscriminatorType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetVersionsV2ResponseIncludedItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetVersionsV2ResponseIncludedItemDiscriminatorType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetVersionsV2ResponseIncludedItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2Type))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetV2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2Type?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetV2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2RelationshipsGameCenterDetailDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetV2RelationshipsGameCenterDetailDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2RelationshipsGameCenterDetailDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetV2RelationshipsGameCenterDetailDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2RelationshipsGameCenterGroupDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetV2RelationshipsGameCenterGroupDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2RelationshipsGameCenterGroupDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetV2RelationshipsGameCenterGroupDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2RelationshipsGameCenterLeaderboardsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetV2RelationshipsGameCenterLeaderboardsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2RelationshipsGameCenterLeaderboardsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetV2RelationshipsGameCenterLeaderboardsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2RelationshipsVersionsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetV2RelationshipsVersionsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2RelationshipsVersionsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetV2RelationshipsVersionsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2ResponseIncludedItemDiscriminatorType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetV2ResponseIncludedItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2ResponseIncludedItemDiscriminatorType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetV2ResponseIncludedItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2CreateRequestDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetV2CreateRequestDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2CreateRequestDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetV2CreateRequestDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2CreateRequestDataRelationshipsGameCenterDetailDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetV2CreateRequestDataRelationshipsGameCenterDetailDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2CreateRequestDataRelationshipsGameCenterDetailDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetV2CreateRequestDataRelationshipsGameCenterDetailDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2CreateRequestDataRelationshipsGameCenterGroupDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetV2CreateRequestDataRelationshipsGameCenterGroupDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2CreateRequestDataRelationshipsGameCenterGroupDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetV2CreateRequestDataRelationshipsGameCenterGroupDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2CreateRequestDataRelationshipsGameCenterLeaderboardsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetV2CreateRequestDataRelationshipsGameCenterLeaderboardsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2CreateRequestDataRelationshipsGameCenterLeaderboardsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetV2CreateRequestDataRelationshipsGameCenterLeaderboardsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2CreateRequestDataRelationshipsVersionsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetV2CreateRequestDataRelationshipsVersionsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2CreateRequestDataRelationshipsVersionsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetV2CreateRequestDataRelationshipsVersionsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2UpdateRequestDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetV2UpdateRequestDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2UpdateRequestDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetV2UpdateRequestDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetRelationshipsGameCenterDetailDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetRelationshipsGameCenterDetailDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetRelationshipsGameCenterDetailDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetRelationshipsGameCenterDetailDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetRelationshipsGameCenterGroupDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetRelationshipsGameCenterGroupDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetRelationshipsGameCenterGroupDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetRelationshipsGameCenterGroupDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetRelationshipsGroupLeaderboardSetDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetRelationshipsGroupLeaderboardSetDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetRelationshipsGroupLeaderboardSetDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetRelationshipsGroupLeaderboardSetDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetRelationshipsLocalizationsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetRelationshipsLocalizationsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetRelationshipsLocalizationsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetRelationshipsLocalizationsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetRelationshipsGameCenterLeaderboardsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetRelationshipsGameCenterLeaderboardsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetRelationshipsGameCenterLeaderboardsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetRelationshipsGameCenterLeaderboardsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetRelationshipsReleasesDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetRelationshipsReleasesDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetRelationshipsReleasesDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetRelationshipsReleasesDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetResponseIncludedItemDiscriminatorType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetResponseIncludedItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetResponseIncludedItemDiscriminatorType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetResponseIncludedItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetCreateRequestDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetCreateRequestDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetCreateRequestDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetCreateRequestDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetCreateRequestDataRelationshipsGameCenterDetailDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetCreateRequestDataRelationshipsGameCenterDetailDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetCreateRequestDataRelationshipsGameCenterDetailDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetCreateRequestDataRelationshipsGameCenterDetailDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetCreateRequestDataRelationshipsGameCenterGroupDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetCreateRequestDataRelationshipsGameCenterGroupDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetCreateRequestDataRelationshipsGameCenterGroupDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetCreateRequestDataRelationshipsGameCenterGroupDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetCreateRequestDataRelationshipsGameCenterLeaderboardsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetCreateRequestDataRelationshipsGameCenterLeaderboardsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetCreateRequestDataRelationshipsGameCenterLeaderboardsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetCreateRequestDataRelationshipsGameCenterLeaderboardsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetUpdateRequestDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetUpdateRequestDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetUpdateRequestDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetUpdateRequestDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardVersionV2Type))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardVersionV2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardVersionV2Type?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardVersionV2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardVersionV2RelationshipsLeaderboardDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardVersionV2RelationshipsLeaderboardDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardVersionV2RelationshipsLeaderboardDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardVersionV2RelationshipsLeaderboardDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardVersionV2RelationshipsLocalizationsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardVersionV2RelationshipsLocalizationsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardVersionV2RelationshipsLocalizationsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardVersionV2RelationshipsLocalizationsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardAttributesSubmissionType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardAttributesSubmissionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardAttributesSubmissionType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardAttributesSubmissionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardAttributesScoreSortType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardAttributesScoreSortTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardAttributesScoreSortType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardAttributesScoreSortTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardAttributesVisibility))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardAttributesVisibilityJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardAttributesVisibility?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardAttributesVisibilityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardRelationshipsGameCenterDetailDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardRelationshipsGameCenterDetailDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardRelationshipsGameCenterDetailDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardRelationshipsGameCenterDetailDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardRelationshipsGameCenterGroupDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardRelationshipsGameCenterGroupDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardRelationshipsGameCenterGroupDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardRelationshipsGameCenterGroupDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardRelationshipsGroupLeaderboardDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardRelationshipsGroupLeaderboardDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardRelationshipsGroupLeaderboardDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardRelationshipsGroupLeaderboardDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardRelationshipsGameCenterLeaderboardSetsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardRelationshipsGameCenterLeaderboardSetsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardRelationshipsGameCenterLeaderboardSetsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardRelationshipsGameCenterLeaderboardSetsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardRelationshipsLocalizationsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardRelationshipsLocalizationsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardRelationshipsLocalizationsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardRelationshipsLocalizationsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardRelationshipsReleasesDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardRelationshipsReleasesDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardRelationshipsReleasesDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardRelationshipsReleasesDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardRelationshipsActivityDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardRelationshipsActivityDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardRelationshipsActivityDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardRelationshipsActivityDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardRelationshipsChallengeDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardRelationshipsChallengeDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardRelationshipsChallengeDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardRelationshipsChallengeDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardsResponseIncludedItemDiscriminatorType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardsResponseIncludedItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardsResponseIncludedItemDiscriminatorType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardsResponseIncludedItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardV2Type))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardV2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardV2Type?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardV2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardV2AttributesSubmissionType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardV2AttributesSubmissionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardV2AttributesSubmissionType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardV2AttributesSubmissionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardV2AttributesScoreSortType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardV2AttributesScoreSortTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardV2AttributesScoreSortType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardV2AttributesScoreSortTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardV2AttributesVisibility))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardV2AttributesVisibilityJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardV2AttributesVisibility?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardV2AttributesVisibilityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsGameCenterDetailDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardV2RelationshipsGameCenterDetailDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsGameCenterDetailDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardV2RelationshipsGameCenterDetailDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsGameCenterGroupDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardV2RelationshipsGameCenterGroupDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsGameCenterGroupDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardV2RelationshipsGameCenterGroupDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsGameCenterLeaderboardSetsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardV2RelationshipsGameCenterLeaderboardSetsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsGameCenterLeaderboardSetsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardV2RelationshipsGameCenterLeaderboardSetsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsActivityDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardV2RelationshipsActivityDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsActivityDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardV2RelationshipsActivityDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsChallengeDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardV2RelationshipsChallengeDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsChallengeDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardV2RelationshipsChallengeDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsVersionsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardV2RelationshipsVersionsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsVersionsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardV2RelationshipsVersionsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardsV2ResponseIncludedItemDiscriminatorType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardsV2ResponseIncludedItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardsV2ResponseIncludedItemDiscriminatorType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardsV2ResponseIncludedItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2GameCenterLeaderboardsLinkagesResponseDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetV2GameCenterLeaderboardsLinkagesResponseDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2GameCenterLeaderboardsLinkagesResponseDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetV2GameCenterLeaderboardsLinkagesResponseDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2GameCenterLeaderboardsLinkagesRequestDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetV2GameCenterLeaderboardsLinkagesRequestDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2GameCenterLeaderboardsLinkagesRequestDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetV2GameCenterLeaderboardsLinkagesRequestDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2VersionsLinkagesResponseDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetV2VersionsLinkagesResponseDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2VersionsLinkagesResponseDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetV2VersionsLinkagesResponseDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetGameCenterLeaderboardsLinkagesResponseDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetGameCenterLeaderboardsLinkagesResponseDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetGameCenterLeaderboardsLinkagesResponseDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetGameCenterLeaderboardsLinkagesResponseDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetGameCenterLeaderboardsLinkagesRequestDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetGameCenterLeaderboardsLinkagesRequestDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetGameCenterLeaderboardsLinkagesRequestDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetGameCenterLeaderboardsLinkagesRequestDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetGroupLeaderboardSetLinkageResponseDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetGroupLeaderboardSetLinkageResponseDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetGroupLeaderboardSetLinkageResponseDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetGroupLeaderboardSetLinkageResponseDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetGroupLeaderboardSetLinkageRequestDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetGroupLeaderboardSetLinkageRequestDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetGroupLeaderboardSetLinkageRequestDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetGroupLeaderboardSetLinkageRequestDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetLocalizationsLinkagesResponseDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetLocalizationsLinkagesResponseDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetLocalizationsLinkagesResponseDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetLocalizationsLinkagesResponseDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetReleasesLinkagesResponseDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetReleasesLinkagesResponseDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetReleasesLinkagesResponseDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetReleasesLinkagesResponseDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppMediaAssetStateState))
                {
                    return new global::AppStoreConnect.JsonConverters.AppMediaAssetStateStateJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppMediaAssetStateState?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppMediaAssetStateStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardFormatter))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardFormatterJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardFormatter?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardFormatterNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterVersionState))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterVersionStateJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterVersionState?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterVersionStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterLeaderboardSet))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterLeaderboardSetJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterLeaderboardSet?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterLeaderboardSetNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterDetail))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterDetailJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterDetail?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterDetailNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterGroup))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterGroupJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterGroup?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterGroupNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterLeaderboard))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterLeaderboardJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterLeaderboard?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterLeaderboardNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterLeaderboardSetVersion))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterLeaderboardSetVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterLeaderboardSetVersion?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterLeaderboardSetVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsV2GetInstanceIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetsV2GetInstanceIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsV2GetInstanceIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetsV2GetInstanceIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGetInstanceFieldsGameCenterLeaderboardSet))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetsGetInstanceFieldsGameCenterLeaderboardSetJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGetInstanceFieldsGameCenterLeaderboardSet?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetsGetInstanceFieldsGameCenterLeaderboardSetNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGetInstanceFieldsGameCenterDetail))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetsGetInstanceFieldsGameCenterDetailJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGetInstanceFieldsGameCenterDetail?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetsGetInstanceFieldsGameCenterDetailNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGetInstanceFieldsGameCenterGroup))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetsGetInstanceFieldsGameCenterGroupJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGetInstanceFieldsGameCenterGroup?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetsGetInstanceFieldsGameCenterGroupNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGetInstanceFieldsGameCenterLeaderboardSetLocalization))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetsGetInstanceFieldsGameCenterLeaderboardSetLocalizationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGetInstanceFieldsGameCenterLeaderboardSetLocalization?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetsGetInstanceFieldsGameCenterLeaderboardSetLocalizationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGetInstanceFieldsGameCenterLeaderboard))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetsGetInstanceFieldsGameCenterLeaderboardJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGetInstanceFieldsGameCenterLeaderboard?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetsGetInstanceFieldsGameCenterLeaderboardNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGetInstanceFieldsGameCenterLeaderboardSetRelease))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetsGetInstanceFieldsGameCenterLeaderboardSetReleaseJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGetInstanceFieldsGameCenterLeaderboardSetRelease?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetsGetInstanceFieldsGameCenterLeaderboardSetReleaseNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGetInstanceIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetsGetInstanceIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGetInstanceIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetsGetInstanceIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboard))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboard?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterDetail))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterDetailJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterDetail?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterDetailNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterGroup))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterGroupJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterGroup?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterGroupNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardSet))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardSetJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardSet?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardSetNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitieJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterChallenge))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterChallengeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterChallenge?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterChallengeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardVersion))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardVersion?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsV2VersionsGetToManyRelatedFieldsGameCenterLeaderboardSetVersion))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetsV2VersionsGetToManyRelatedFieldsGameCenterLeaderboardSetVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsV2VersionsGetToManyRelatedFieldsGameCenterLeaderboardSetVersion?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetsV2VersionsGetToManyRelatedFieldsGameCenterLeaderboardSetVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsV2VersionsGetToManyRelatedFieldsGameCenterLeaderboardSet))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetsV2VersionsGetToManyRelatedFieldsGameCenterLeaderboardSetJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsV2VersionsGetToManyRelatedFieldsGameCenterLeaderboardSet?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetsV2VersionsGetToManyRelatedFieldsGameCenterLeaderboardSetNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsV2VersionsGetToManyRelatedFieldsGameCenterLeaderboardSetLocalization))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetsV2VersionsGetToManyRelatedFieldsGameCenterLeaderboardSetLocalizationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsV2VersionsGetToManyRelatedFieldsGameCenterLeaderboardSetLocalization?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetsV2VersionsGetToManyRelatedFieldsGameCenterLeaderboardSetLocalizationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsV2VersionsGetToManyRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetsV2VersionsGetToManyRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsV2VersionsGetToManyRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetsV2VersionsGetToManyRelatedIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboard))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboard?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterDetail))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterDetailJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterDetail?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterDetailNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterGroup))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterGroupJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterGroup?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterGroupNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardSet))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardSetJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardSet?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardSetNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardLocalization))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardLocalizationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardLocalization?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardLocalizationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardRelease))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardReleaseJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardRelease?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardReleaseNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitieJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterChallenge))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterChallengeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterChallenge?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterChallengeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboardSet))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboardSetJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboardSet?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboardSetNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterDetail))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterDetailJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterDetail?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterDetailNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterGroup))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterGroupJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterGroup?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterGroupNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboardSetLocalization))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboardSetLocalizationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboardSetLocalization?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboardSetLocalizationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboard))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboardJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboard?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboardNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboardSetRelease))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboardSetReleaseJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboardSetRelease?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboardSetReleaseNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsLocalizationsGetToManyRelatedFieldsGameCenterLeaderboardSetLocalization))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetsLocalizationsGetToManyRelatedFieldsGameCenterLeaderboardSetLocalizationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsLocalizationsGetToManyRelatedFieldsGameCenterLeaderboardSetLocalization?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetsLocalizationsGetToManyRelatedFieldsGameCenterLeaderboardSetLocalizationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsLocalizationsGetToManyRelatedFieldsGameCenterLeaderboardSet))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetsLocalizationsGetToManyRelatedFieldsGameCenterLeaderboardSetJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsLocalizationsGetToManyRelatedFieldsGameCenterLeaderboardSet?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetsLocalizationsGetToManyRelatedFieldsGameCenterLeaderboardSetNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsLocalizationsGetToManyRelatedFieldsGameCenterLeaderboardSetImage))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetsLocalizationsGetToManyRelatedFieldsGameCenterLeaderboardSetImageJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsLocalizationsGetToManyRelatedFieldsGameCenterLeaderboardSetImage?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetsLocalizationsGetToManyRelatedFieldsGameCenterLeaderboardSetImageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsLocalizationsGetToManyRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetsLocalizationsGetToManyRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsLocalizationsGetToManyRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetsLocalizationsGetToManyRelatedIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsReleasesGetToManyRelatedFieldsGameCenterLeaderboardSetRelease))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetsReleasesGetToManyRelatedFieldsGameCenterLeaderboardSetReleaseJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsReleasesGetToManyRelatedFieldsGameCenterLeaderboardSetRelease?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetsReleasesGetToManyRelatedFieldsGameCenterLeaderboardSetReleaseNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsReleasesGetToManyRelatedFieldsGameCenterDetail))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetsReleasesGetToManyRelatedFieldsGameCenterDetailJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsReleasesGetToManyRelatedFieldsGameCenterDetail?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetsReleasesGetToManyRelatedFieldsGameCenterDetailNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsReleasesGetToManyRelatedFieldsGameCenterLeaderboardSet))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetsReleasesGetToManyRelatedFieldsGameCenterLeaderboardSetJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsReleasesGetToManyRelatedFieldsGameCenterLeaderboardSet?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetsReleasesGetToManyRelatedFieldsGameCenterLeaderboardSetNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsReleasesGetToManyRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetsReleasesGetToManyRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsReleasesGetToManyRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetsReleasesGetToManyRelatedIncludeItemNullableJsonConverter();
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
                    0 => new GameCenterLeaderboardSetsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),

                    1 => new GameCenterLeaderboardSetsSourceGenerationContextChunk1(new global::System.Text.Json.JsonSerializerOptions()),

                    2 => new GameCenterLeaderboardSetsSourceGenerationContextChunk2(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}