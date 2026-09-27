
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem83), TypeInfoPropertyName = "IncludedItem832")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterActivity))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroup))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem84), TypeInfoPropertyName = "IncludedItem842")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem85), TypeInfoPropertyName = "IncludedItem852")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem86), TypeInfoPropertyName = "IncludedItem862")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem101), TypeInfoPropertyName = "IncludedItem1012")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardRelease))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetRelease))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSet))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem102), TypeInfoPropertyName = "IncludedItem1022")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem103), TypeInfoPropertyName = "IncludedItem1032")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.PromotedPurchaseType), TypeInfoPropertyName = "PromotedPurchaseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.PromotedPurchaseAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.PromotedPurchaseAttributesState), TypeInfoPropertyName = "PromotedPurchaseAttributesState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.PromotedPurchaseRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.PromotedPurchaseRelationshipsInAppPurchaseV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.PromotedPurchaseRelationshipsInAppPurchaseV2Data))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.PromotedPurchaseRelationshipsInAppPurchaseV2DataType), TypeInfoPropertyName = "PromotedPurchaseRelationshipsInAppPurchaseV2DataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.PromotedPurchaseRelationshipsSubscription))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.PromotedPurchaseRelationshipsSubscriptionData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.PromotedPurchaseRelationshipsSubscriptionDataType), TypeInfoPropertyName = "PromotedPurchaseRelationshipsSubscriptionDataType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionAppStoreReviewScreenshotType), TypeInfoPropertyName = "SubscriptionAppStoreReviewScreenshotType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionAppStoreReviewScreenshotAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionAppStoreReviewScreenshotRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionAppStoreReviewScreenshotRelationshipsSubscription))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionAppStoreReviewScreenshotRelationshipsSubscriptionData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionAppStoreReviewScreenshotRelationshipsSubscriptionDataType), TypeInfoPropertyName = "SubscriptionAppStoreReviewScreenshotRelationshipsSubscriptionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.Subscription>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionAvailability))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionAvailabilityType), TypeInfoPropertyName = "SubscriptionAvailabilityType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionAvailabilityAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionAvailabilityRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionAvailabilityRelationshipsAvailableTerritories))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionAvailabilityRelationshipsAvailableTerritoriesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionAvailabilityRelationshipsAvailableTerritoriesDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionAvailabilityRelationshipsAvailableTerritoriesDataItemType), TypeInfoPropertyName = "SubscriptionAvailabilityRelationshipsAvailableTerritoriesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupLocalizationV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupLocalizationV2Type), TypeInfoPropertyName = "SubscriptionGroupLocalizationV2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupLocalizationV2Attributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupLocalizationV2Relationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupLocalizationV2RelationshipsVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupLocalizationV2RelationshipsVersionData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupLocalizationV2RelationshipsVersionDataType), TypeInfoPropertyName = "SubscriptionGroupLocalizationV2RelationshipsVersionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionGroupVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupLocalization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupLocalizationType), TypeInfoPropertyName = "SubscriptionGroupLocalizationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupLocalizationAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupLocalizationAttributesState), TypeInfoPropertyName = "SubscriptionGroupLocalizationAttributesState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupLocalizationRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupLocalizationRelationshipsSubscriptionGroup))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupLocalizationRelationshipsSubscriptionGroupData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupLocalizationRelationshipsSubscriptionGroupDataType), TypeInfoPropertyName = "SubscriptionGroupLocalizationRelationshipsSubscriptionGroupDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupLocalizationsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionGroupLocalization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupVersionType), TypeInfoPropertyName = "SubscriptionGroupVersionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupVersionAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupVersionAttributesState), TypeInfoPropertyName = "SubscriptionGroupVersionAttributesState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupVersionRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupVersionRelationshipsSubscriptionGroup))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupVersionRelationshipsSubscriptionGroupData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupVersionRelationshipsSubscriptionGroupDataType), TypeInfoPropertyName = "SubscriptionGroupVersionRelationshipsSubscriptionGroupDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupVersionRelationshipsLocalizations))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionGroupVersionRelationshipsLocalizationsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupVersionRelationshipsLocalizationsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupVersionRelationshipsLocalizationsDataItemType), TypeInfoPropertyName = "SubscriptionGroupVersionRelationshipsLocalizationsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupVersionsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.IncludedItem160>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem160), TypeInfoPropertyName = "IncludedItem1602")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupVersionsResponseIncludedItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupVersionsResponseIncludedItemDiscriminatorType), TypeInfoPropertyName = "SubscriptionGroupVersionsResponseIncludedItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem161), TypeInfoPropertyName = "IncludedItem1612")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupType), TypeInfoPropertyName = "SubscriptionGroupType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupRelationshipsSubscriptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionGroupRelationshipsSubscriptionsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupRelationshipsSubscriptionsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupRelationshipsSubscriptionsDataItemType), TypeInfoPropertyName = "SubscriptionGroupRelationshipsSubscriptionsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupRelationshipsSubscriptionGroupLocalizations))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionGroupRelationshipsSubscriptionGroupLocalizationsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupRelationshipsSubscriptionGroupLocalizationsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupRelationshipsSubscriptionGroupLocalizationsDataItemType), TypeInfoPropertyName = "SubscriptionGroupRelationshipsSubscriptionGroupLocalizationsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupRelationshipsVersions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionGroupRelationshipsVersionsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupRelationshipsVersionsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupRelationshipsVersionsDataItemType), TypeInfoPropertyName = "SubscriptionGroupRelationshipsVersionsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem162), TypeInfoPropertyName = "IncludedItem1622")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.IncludedItem163>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem163), TypeInfoPropertyName = "IncludedItem1632")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupResponseIncludedItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupResponseIncludedItemDiscriminatorType), TypeInfoPropertyName = "SubscriptionGroupResponseIncludedItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupCreateRequestData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupCreateRequestDataType), TypeInfoPropertyName = "SubscriptionGroupCreateRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupCreateRequestDataAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupCreateRequestDataRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupCreateRequestDataRelationshipsApp))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupCreateRequestDataRelationshipsAppData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupCreateRequestDataRelationshipsAppDataType), TypeInfoPropertyName = "SubscriptionGroupCreateRequestDataRelationshipsAppDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupUpdateRequestData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupUpdateRequestDataType), TypeInfoPropertyName = "SubscriptionGroupUpdateRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupUpdateRequestDataAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionImageType), TypeInfoPropertyName = "SubscriptionImageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionImageAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionImageAttributesState), TypeInfoPropertyName = "SubscriptionImageAttributesState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionImageRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionImageRelationshipsSubscription))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionImageRelationshipsSubscriptionData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionImageRelationshipsSubscriptionDataType), TypeInfoPropertyName = "SubscriptionImageRelationshipsSubscriptionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionImageV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionIntroductoryOffer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionIntroductoryOfferType), TypeInfoPropertyName = "SubscriptionIntroductoryOfferType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionIntroductoryOfferAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionOfferDuration), TypeInfoPropertyName = "SubscriptionOfferDuration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionOfferMode), TypeInfoPropertyName = "SubscriptionOfferMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPlanType), TypeInfoPropertyName = "SubscriptionPlanType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionIntroductoryOfferRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionIntroductoryOfferRelationshipsSubscription))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionIntroductoryOfferRelationshipsSubscriptionData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionIntroductoryOfferRelationshipsSubscriptionDataType), TypeInfoPropertyName = "SubscriptionIntroductoryOfferRelationshipsSubscriptionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionIntroductoryOfferRelationshipsTerritory))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionIntroductoryOfferRelationshipsTerritoryData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionIntroductoryOfferRelationshipsTerritoryDataType), TypeInfoPropertyName = "SubscriptionIntroductoryOfferRelationshipsTerritoryDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionIntroductoryOfferRelationshipsSubscriptionPricePoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionIntroductoryOfferRelationshipsSubscriptionPricePointData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionIntroductoryOfferRelationshipsSubscriptionPricePointDataType), TypeInfoPropertyName = "SubscriptionIntroductoryOfferRelationshipsSubscriptionPricePointDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem164), TypeInfoPropertyName = "IncludedItem1642")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPricePoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem165), TypeInfoPropertyName = "IncludedItem1652")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionLocalizationV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionLocalization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionLocalizationType), TypeInfoPropertyName = "SubscriptionLocalizationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionLocalizationAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionLocalizationAttributesState), TypeInfoPropertyName = "SubscriptionLocalizationAttributesState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionLocalizationRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionLocalizationRelationshipsSubscription))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionLocalizationRelationshipsSubscriptionData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionLocalizationRelationshipsSubscriptionDataType), TypeInfoPropertyName = "SubscriptionLocalizationRelationshipsSubscriptionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionOfferCodeCustomCode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionOfferCode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionOfferCodeOneTimeUseCode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionOfferCodePrice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem166), TypeInfoPropertyName = "IncludedItem1662")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionOfferCodeType), TypeInfoPropertyName = "SubscriptionOfferCodeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionOfferCodeAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionCustomerEligibility>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionCustomerEligibility), TypeInfoPropertyName = "SubscriptionCustomerEligibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionOfferEligibility), TypeInfoPropertyName = "SubscriptionOfferEligibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionOfferCodeRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionOfferCodeRelationshipsSubscription))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionOfferCodeRelationshipsSubscriptionData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionOfferCodeRelationshipsSubscriptionDataType), TypeInfoPropertyName = "SubscriptionOfferCodeRelationshipsSubscriptionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionOfferCodeRelationshipsOneTimeUseCodes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionOfferCodeRelationshipsOneTimeUseCodesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionOfferCodeRelationshipsOneTimeUseCodesDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionOfferCodeRelationshipsOneTimeUseCodesDataItemType), TypeInfoPropertyName = "SubscriptionOfferCodeRelationshipsOneTimeUseCodesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionOfferCodeRelationshipsCustomCodes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionOfferCodeRelationshipsCustomCodesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionOfferCodeRelationshipsCustomCodesDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionOfferCodeRelationshipsCustomCodesDataItemType), TypeInfoPropertyName = "SubscriptionOfferCodeRelationshipsCustomCodesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionOfferCodeRelationshipsPrices))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionOfferCodeRelationshipsPricesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionOfferCodeRelationshipsPricesDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionOfferCodeRelationshipsPricesDataItemType), TypeInfoPropertyName = "SubscriptionOfferCodeRelationshipsPricesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem167), TypeInfoPropertyName = "IncludedItem1672")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem168), TypeInfoPropertyName = "IncludedItem1682")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPlanAvailability))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPlanAvailabilityType), TypeInfoPropertyName = "SubscriptionPlanAvailabilityType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPlanAvailabilityAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPlanAvailabilityRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPlanAvailabilityRelationshipsAvailableTerritories))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionPlanAvailabilityRelationshipsAvailableTerritoriesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPlanAvailabilityRelationshipsAvailableTerritoriesDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPlanAvailabilityRelationshipsAvailableTerritoriesDataItemType), TypeInfoPropertyName = "SubscriptionPlanAvailabilityRelationshipsAvailableTerritoriesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPrice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPriceType), TypeInfoPropertyName = "SubscriptionPriceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPriceAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPriceRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPriceRelationshipsTerritory))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPriceRelationshipsTerritoryData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPriceRelationshipsTerritoryDataType), TypeInfoPropertyName = "SubscriptionPriceRelationshipsTerritoryDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPriceRelationshipsSubscriptionPricePoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPriceRelationshipsSubscriptionPricePointData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPriceRelationshipsSubscriptionPricePointDataType), TypeInfoPropertyName = "SubscriptionPriceRelationshipsSubscriptionPricePointDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem169), TypeInfoPropertyName = "IncludedItem1692")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem170), TypeInfoPropertyName = "IncludedItem1702")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPromotionalOfferPrice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem171), TypeInfoPropertyName = "IncludedItem1712")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPromotionalOffer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPromotionalOfferType), TypeInfoPropertyName = "SubscriptionPromotionalOfferType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPromotionalOfferAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPromotionalOfferRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPromotionalOfferRelationshipsSubscription))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPromotionalOfferRelationshipsSubscriptionData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPromotionalOfferRelationshipsSubscriptionDataType), TypeInfoPropertyName = "SubscriptionPromotionalOfferRelationshipsSubscriptionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPromotionalOfferRelationshipsPrices))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionPromotionalOfferRelationshipsPricesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPromotionalOfferRelationshipsPricesDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPromotionalOfferRelationshipsPricesDataItemType), TypeInfoPropertyName = "SubscriptionPromotionalOfferRelationshipsPricesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem172), TypeInfoPropertyName = "IncludedItem1722")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem173), TypeInfoPropertyName = "IncludedItem1732")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionVersionType), TypeInfoPropertyName = "SubscriptionVersionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionVersionAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionVersionAttributesState), TypeInfoPropertyName = "SubscriptionVersionAttributesState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionVersionRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionVersionRelationshipsSubscription))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionVersionRelationshipsSubscriptionData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionVersionRelationshipsSubscriptionDataType), TypeInfoPropertyName = "SubscriptionVersionRelationshipsSubscriptionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionVersionRelationshipsImage))]
    internal sealed partial class SubscriptionGroupsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionVersionRelationshipsImageData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionVersionRelationshipsImageDataType), TypeInfoPropertyName = "SubscriptionVersionRelationshipsImageDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionVersionRelationshipsImages))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionVersionRelationshipsImagesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionVersionRelationshipsImagesDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionVersionRelationshipsImagesDataItemType), TypeInfoPropertyName = "SubscriptionVersionRelationshipsImagesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionVersionRelationshipsLocalizations))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionVersionRelationshipsLocalizationsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionVersionRelationshipsLocalizationsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionVersionRelationshipsLocalizationsDataItemType), TypeInfoPropertyName = "SubscriptionVersionRelationshipsLocalizationsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem174), TypeInfoPropertyName = "IncludedItem1742")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem175), TypeInfoPropertyName = "IncludedItem1752")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionType), TypeInfoPropertyName = "SubscriptionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionAttributesState), TypeInfoPropertyName = "SubscriptionAttributesState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionAttributesSubscriptionPeriod), TypeInfoPropertyName = "SubscriptionAttributesSubscriptionPeriod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionAttributesMultiSeatStatus), TypeInfoPropertyName = "SubscriptionAttributesMultiSeatStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionAttributesMarketSetting>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionAttributesMarketSetting), TypeInfoPropertyName = "SubscriptionAttributesMarketSetting2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionRelationshipsSubscriptionLocalizations))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionRelationshipsSubscriptionLocalizationsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionRelationshipsSubscriptionLocalizationsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionRelationshipsSubscriptionLocalizationsDataItemType), TypeInfoPropertyName = "SubscriptionRelationshipsSubscriptionLocalizationsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionRelationshipsAppStoreReviewScreenshot))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionRelationshipsAppStoreReviewScreenshotData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionRelationshipsAppStoreReviewScreenshotDataType), TypeInfoPropertyName = "SubscriptionRelationshipsAppStoreReviewScreenshotDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionRelationshipsGroup))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionRelationshipsGroupData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionRelationshipsGroupDataType), TypeInfoPropertyName = "SubscriptionRelationshipsGroupDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionRelationshipsIntroductoryOffers))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionRelationshipsIntroductoryOffersDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionRelationshipsIntroductoryOffersDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionRelationshipsIntroductoryOffersDataItemType), TypeInfoPropertyName = "SubscriptionRelationshipsIntroductoryOffersDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionRelationshipsPromotionalOffers))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionRelationshipsPromotionalOffersDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionRelationshipsPromotionalOffersDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionRelationshipsPromotionalOffersDataItemType), TypeInfoPropertyName = "SubscriptionRelationshipsPromotionalOffersDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionRelationshipsOfferCodes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionRelationshipsOfferCodesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionRelationshipsOfferCodesDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionRelationshipsOfferCodesDataItemType), TypeInfoPropertyName = "SubscriptionRelationshipsOfferCodesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionRelationshipsPrices))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionRelationshipsPricesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionRelationshipsPricesDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionRelationshipsPricesDataItemType), TypeInfoPropertyName = "SubscriptionRelationshipsPricesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionRelationshipsPricePoints))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionRelationshipsPromotedPurchase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionRelationshipsPromotedPurchaseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionRelationshipsPromotedPurchaseDataType), TypeInfoPropertyName = "SubscriptionRelationshipsPromotedPurchaseDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionRelationshipsSubscriptionAvailability))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionRelationshipsSubscriptionAvailabilityData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionRelationshipsSubscriptionAvailabilityDataType), TypeInfoPropertyName = "SubscriptionRelationshipsSubscriptionAvailabilityDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionRelationshipsWinBackOffers))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionRelationshipsWinBackOffersDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionRelationshipsWinBackOffersDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionRelationshipsWinBackOffersDataItemType), TypeInfoPropertyName = "SubscriptionRelationshipsWinBackOffersDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionRelationshipsImages))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionRelationshipsImagesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionRelationshipsImagesDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionRelationshipsImagesDataItemType), TypeInfoPropertyName = "SubscriptionRelationshipsImagesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionRelationshipsPlanAvailabilities))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionRelationshipsPlanAvailabilitiesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionRelationshipsPlanAvailabilitiesDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionRelationshipsPlanAvailabilitiesDataItemType), TypeInfoPropertyName = "SubscriptionRelationshipsPlanAvailabilitiesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionRelationshipsVersions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionRelationshipsVersionsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionRelationshipsVersionsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionRelationshipsVersionsDataItemType), TypeInfoPropertyName = "SubscriptionRelationshipsVersionsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.IncludedItem176>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem176), TypeInfoPropertyName = "IncludedItem1762")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.WinBackOffer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsResponseIncludedItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsResponseIncludedItemDiscriminatorType), TypeInfoPropertyName = "SubscriptionsResponseIncludedItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem177), TypeInfoPropertyName = "IncludedItem1772")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem179), TypeInfoPropertyName = "IncludedItem1792")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.WinBackOfferType), TypeInfoPropertyName = "WinBackOfferType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.WinBackOfferAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IntegerRange))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.WinBackOfferAttributesPriority), TypeInfoPropertyName = "WinBackOfferAttributesPriority2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.WinBackOfferAttributesPromotionIntent), TypeInfoPropertyName = "WinBackOfferAttributesPromotionIntent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.WinBackOfferRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.WinBackOfferRelationshipsPrices))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.WinBackOfferRelationshipsPricesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.WinBackOfferRelationshipsPricesDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.WinBackOfferRelationshipsPricesDataItemType), TypeInfoPropertyName = "WinBackOfferRelationshipsPricesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupSubscriptionGroupLocalizationsLinkagesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionGroupSubscriptionGroupLocalizationsLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupSubscriptionGroupLocalizationsLinkagesResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupSubscriptionGroupLocalizationsLinkagesResponseDataItemType), TypeInfoPropertyName = "SubscriptionGroupSubscriptionGroupLocalizationsLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupSubscriptionsLinkagesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionGroupSubscriptionsLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupSubscriptionsLinkagesResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupSubscriptionsLinkagesResponseDataItemType), TypeInfoPropertyName = "SubscriptionGroupSubscriptionsLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupVersionsLinkagesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionGroupVersionsLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupVersionsLinkagesResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupVersionsLinkagesResponseDataItemType), TypeInfoPropertyName = "SubscriptionGroupVersionsLinkagesResponseDataItemType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionGroupsGetInstanceFieldsSubscriptionGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupsGetInstanceFieldsSubscriptionGroup), TypeInfoPropertyName = "SubscriptionGroupsGetInstanceFieldsSubscriptionGroup2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionGroupsGetInstanceFieldsSubscription>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupsGetInstanceFieldsSubscription), TypeInfoPropertyName = "SubscriptionGroupsGetInstanceFieldsSubscription2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionGroupsGetInstanceFieldsSubscriptionGroupLocalization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupsGetInstanceFieldsSubscriptionGroupLocalization), TypeInfoPropertyName = "SubscriptionGroupsGetInstanceFieldsSubscriptionGroupLocalization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionGroupsGetInstanceFieldsSubscriptionGroupVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupsGetInstanceFieldsSubscriptionGroupVersion), TypeInfoPropertyName = "SubscriptionGroupsGetInstanceFieldsSubscriptionGroupVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionGroupsGetInstanceIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupsGetInstanceIncludeItem), TypeInfoPropertyName = "SubscriptionGroupsGetInstanceIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionGroupsSubscriptionGroupLocalizationsGetToManyRelatedFieldsSubscriptionGroupLocalization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupsSubscriptionGroupLocalizationsGetToManyRelatedFieldsSubscriptionGroupLocalization), TypeInfoPropertyName = "SubscriptionGroupsSubscriptionGroupLocalizationsGetToManyRelatedFieldsSubscriptionGroupLocalization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionGroupsSubscriptionGroupLocalizationsGetToManyRelatedFieldsSubscriptionGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupsSubscriptionGroupLocalizationsGetToManyRelatedFieldsSubscriptionGroup), TypeInfoPropertyName = "SubscriptionGroupsSubscriptionGroupLocalizationsGetToManyRelatedFieldsSubscriptionGroup2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionGroupsSubscriptionGroupLocalizationsGetToManyRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupsSubscriptionGroupLocalizationsGetToManyRelatedIncludeItem), TypeInfoPropertyName = "SubscriptionGroupsSubscriptionGroupLocalizationsGetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFilterStateItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFilterStateItem), TypeInfoPropertyName = "SubscriptionGroupsSubscriptionsGetToManyRelatedFilterStateItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedSortItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedSortItem), TypeInfoPropertyName = "SubscriptionGroupsSubscriptionsGetToManyRelatedSortItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscription>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscription), TypeInfoPropertyName = "SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscription2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionLocalization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionLocalization), TypeInfoPropertyName = "SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionLocalization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionAppStoreReviewScreenshot>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionAppStoreReviewScreenshot), TypeInfoPropertyName = "SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionAppStoreReviewScreenshot2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionGroup), TypeInfoPropertyName = "SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionGroup2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionIntroductoryOffer>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionIntroductoryOffer), TypeInfoPropertyName = "SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionIntroductoryOffer2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionPromotionalOffer>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionPromotionalOffer), TypeInfoPropertyName = "SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionPromotionalOffer2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionOfferCode>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionOfferCode), TypeInfoPropertyName = "SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionOfferCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionPrice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionPrice), TypeInfoPropertyName = "SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionPrice2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsPromotedPurchase>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsPromotedPurchase), TypeInfoPropertyName = "SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsPromotedPurchase2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionAvailabilitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionAvailabilitie), TypeInfoPropertyName = "SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionAvailabilitie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsWinBackOffer>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsWinBackOffer), TypeInfoPropertyName = "SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsWinBackOffer2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionImage), TypeInfoPropertyName = "SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionImage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionPlanAvailabilitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionPlanAvailabilitie), TypeInfoPropertyName = "SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionPlanAvailabilitie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionVersion), TypeInfoPropertyName = "SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedIncludeItem), TypeInfoPropertyName = "SubscriptionGroupsSubscriptionsGetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionGroupsVersionsGetToManyRelatedFilterStateItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupsVersionsGetToManyRelatedFilterStateItem), TypeInfoPropertyName = "SubscriptionGroupsVersionsGetToManyRelatedFilterStateItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionGroupsVersionsGetToManyRelatedFieldsSubscriptionGroupVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupsVersionsGetToManyRelatedFieldsSubscriptionGroupVersion), TypeInfoPropertyName = "SubscriptionGroupsVersionsGetToManyRelatedFieldsSubscriptionGroupVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionGroupsVersionsGetToManyRelatedFieldsSubscriptionGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupsVersionsGetToManyRelatedFieldsSubscriptionGroup), TypeInfoPropertyName = "SubscriptionGroupsVersionsGetToManyRelatedFieldsSubscriptionGroup2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionGroupsVersionsGetToManyRelatedFieldsSubscriptionGroupLocalization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupsVersionsGetToManyRelatedFieldsSubscriptionGroupLocalization), TypeInfoPropertyName = "SubscriptionGroupsVersionsGetToManyRelatedFieldsSubscriptionGroupLocalization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionGroupsVersionsGetToManyRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupsVersionsGetToManyRelatedIncludeItem), TypeInfoPropertyName = "SubscriptionGroupsVersionsGetToManyRelatedIncludeItem2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem83?), TypeInfoPropertyName = "NullableIncludedItem832")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem84?), TypeInfoPropertyName = "NullableIncludedItem842")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem85?), TypeInfoPropertyName = "NullableIncludedItem852")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem86?), TypeInfoPropertyName = "NullableIncludedItem862")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem101?), TypeInfoPropertyName = "NullableIncludedItem1012")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem102?), TypeInfoPropertyName = "NullableIncludedItem1022")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem103?), TypeInfoPropertyName = "NullableIncludedItem1032")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.PromotedPurchaseType?), TypeInfoPropertyName = "NullablePromotedPurchaseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.PromotedPurchaseAttributesState?), TypeInfoPropertyName = "NullablePromotedPurchaseAttributesState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.PromotedPurchaseRelationshipsInAppPurchaseV2DataType?), TypeInfoPropertyName = "NullablePromotedPurchaseRelationshipsInAppPurchaseV2DataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.PromotedPurchaseRelationshipsSubscriptionDataType?), TypeInfoPropertyName = "NullablePromotedPurchaseRelationshipsSubscriptionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem152?), TypeInfoPropertyName = "NullableIncludedItem1522")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem153?), TypeInfoPropertyName = "NullableIncludedItem1532")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem154?), TypeInfoPropertyName = "NullableIncludedItem1542")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem155?), TypeInfoPropertyName = "NullableIncludedItem1552")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem156?), TypeInfoPropertyName = "NullableIncludedItem1562")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem157?), TypeInfoPropertyName = "NullableIncludedItem1572")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem158?), TypeInfoPropertyName = "NullableIncludedItem1582")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem159?), TypeInfoPropertyName = "NullableIncludedItem1592")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionAppStoreReviewScreenshotType?), TypeInfoPropertyName = "NullableSubscriptionAppStoreReviewScreenshotType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionAppStoreReviewScreenshotRelationshipsSubscriptionDataType?), TypeInfoPropertyName = "NullableSubscriptionAppStoreReviewScreenshotRelationshipsSubscriptionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionAvailabilityType?), TypeInfoPropertyName = "NullableSubscriptionAvailabilityType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionAvailabilityRelationshipsAvailableTerritoriesDataItemType?), TypeInfoPropertyName = "NullableSubscriptionAvailabilityRelationshipsAvailableTerritoriesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupLocalizationV2Type?), TypeInfoPropertyName = "NullableSubscriptionGroupLocalizationV2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupLocalizationV2RelationshipsVersionDataType?), TypeInfoPropertyName = "NullableSubscriptionGroupLocalizationV2RelationshipsVersionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupLocalizationType?), TypeInfoPropertyName = "NullableSubscriptionGroupLocalizationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupLocalizationAttributesState?), TypeInfoPropertyName = "NullableSubscriptionGroupLocalizationAttributesState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupLocalizationRelationshipsSubscriptionGroupDataType?), TypeInfoPropertyName = "NullableSubscriptionGroupLocalizationRelationshipsSubscriptionGroupDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupVersionType?), TypeInfoPropertyName = "NullableSubscriptionGroupVersionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupVersionAttributesState?), TypeInfoPropertyName = "NullableSubscriptionGroupVersionAttributesState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupVersionRelationshipsSubscriptionGroupDataType?), TypeInfoPropertyName = "NullableSubscriptionGroupVersionRelationshipsSubscriptionGroupDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupVersionRelationshipsLocalizationsDataItemType?), TypeInfoPropertyName = "NullableSubscriptionGroupVersionRelationshipsLocalizationsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem160?), TypeInfoPropertyName = "NullableIncludedItem1602")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupVersionsResponseIncludedItemDiscriminatorType?), TypeInfoPropertyName = "NullableSubscriptionGroupVersionsResponseIncludedItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem161?), TypeInfoPropertyName = "NullableIncludedItem1612")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupType?), TypeInfoPropertyName = "NullableSubscriptionGroupType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupRelationshipsSubscriptionsDataItemType?), TypeInfoPropertyName = "NullableSubscriptionGroupRelationshipsSubscriptionsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupRelationshipsSubscriptionGroupLocalizationsDataItemType?), TypeInfoPropertyName = "NullableSubscriptionGroupRelationshipsSubscriptionGroupLocalizationsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupRelationshipsVersionsDataItemType?), TypeInfoPropertyName = "NullableSubscriptionGroupRelationshipsVersionsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem162?), TypeInfoPropertyName = "NullableIncludedItem1622")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem163?), TypeInfoPropertyName = "NullableIncludedItem1632")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupResponseIncludedItemDiscriminatorType?), TypeInfoPropertyName = "NullableSubscriptionGroupResponseIncludedItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupCreateRequestDataType?), TypeInfoPropertyName = "NullableSubscriptionGroupCreateRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupCreateRequestDataRelationshipsAppDataType?), TypeInfoPropertyName = "NullableSubscriptionGroupCreateRequestDataRelationshipsAppDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupUpdateRequestDataType?), TypeInfoPropertyName = "NullableSubscriptionGroupUpdateRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionImageType?), TypeInfoPropertyName = "NullableSubscriptionImageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionImageAttributesState?), TypeInfoPropertyName = "NullableSubscriptionImageAttributesState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionImageRelationshipsSubscriptionDataType?), TypeInfoPropertyName = "NullableSubscriptionImageRelationshipsSubscriptionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionIntroductoryOfferType?), TypeInfoPropertyName = "NullableSubscriptionIntroductoryOfferType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionOfferDuration?), TypeInfoPropertyName = "NullableSubscriptionOfferDuration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionOfferMode?), TypeInfoPropertyName = "NullableSubscriptionOfferMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPlanType?), TypeInfoPropertyName = "NullableSubscriptionPlanType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionIntroductoryOfferRelationshipsSubscriptionDataType?), TypeInfoPropertyName = "NullableSubscriptionIntroductoryOfferRelationshipsSubscriptionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionIntroductoryOfferRelationshipsTerritoryDataType?), TypeInfoPropertyName = "NullableSubscriptionIntroductoryOfferRelationshipsTerritoryDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionIntroductoryOfferRelationshipsSubscriptionPricePointDataType?), TypeInfoPropertyName = "NullableSubscriptionIntroductoryOfferRelationshipsSubscriptionPricePointDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem164?), TypeInfoPropertyName = "NullableIncludedItem1642")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem165?), TypeInfoPropertyName = "NullableIncludedItem1652")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionLocalizationType?), TypeInfoPropertyName = "NullableSubscriptionLocalizationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionLocalizationAttributesState?), TypeInfoPropertyName = "NullableSubscriptionLocalizationAttributesState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionLocalizationRelationshipsSubscriptionDataType?), TypeInfoPropertyName = "NullableSubscriptionLocalizationRelationshipsSubscriptionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem166?), TypeInfoPropertyName = "NullableIncludedItem1662")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionOfferCodeType?), TypeInfoPropertyName = "NullableSubscriptionOfferCodeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionCustomerEligibility?), TypeInfoPropertyName = "NullableSubscriptionCustomerEligibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionOfferEligibility?), TypeInfoPropertyName = "NullableSubscriptionOfferEligibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionOfferCodeRelationshipsSubscriptionDataType?), TypeInfoPropertyName = "NullableSubscriptionOfferCodeRelationshipsSubscriptionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionOfferCodeRelationshipsOneTimeUseCodesDataItemType?), TypeInfoPropertyName = "NullableSubscriptionOfferCodeRelationshipsOneTimeUseCodesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionOfferCodeRelationshipsCustomCodesDataItemType?), TypeInfoPropertyName = "NullableSubscriptionOfferCodeRelationshipsCustomCodesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionOfferCodeRelationshipsPricesDataItemType?), TypeInfoPropertyName = "NullableSubscriptionOfferCodeRelationshipsPricesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem167?), TypeInfoPropertyName = "NullableIncludedItem1672")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem168?), TypeInfoPropertyName = "NullableIncludedItem1682")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPlanAvailabilityType?), TypeInfoPropertyName = "NullableSubscriptionPlanAvailabilityType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPlanAvailabilityRelationshipsAvailableTerritoriesDataItemType?), TypeInfoPropertyName = "NullableSubscriptionPlanAvailabilityRelationshipsAvailableTerritoriesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPriceType?), TypeInfoPropertyName = "NullableSubscriptionPriceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPriceRelationshipsTerritoryDataType?), TypeInfoPropertyName = "NullableSubscriptionPriceRelationshipsTerritoryDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPriceRelationshipsSubscriptionPricePointDataType?), TypeInfoPropertyName = "NullableSubscriptionPriceRelationshipsSubscriptionPricePointDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem169?), TypeInfoPropertyName = "NullableIncludedItem1692")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem170?), TypeInfoPropertyName = "NullableIncludedItem1702")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem171?), TypeInfoPropertyName = "NullableIncludedItem1712")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPromotionalOfferType?), TypeInfoPropertyName = "NullableSubscriptionPromotionalOfferType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPromotionalOfferRelationshipsSubscriptionDataType?), TypeInfoPropertyName = "NullableSubscriptionPromotionalOfferRelationshipsSubscriptionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPromotionalOfferRelationshipsPricesDataItemType?), TypeInfoPropertyName = "NullableSubscriptionPromotionalOfferRelationshipsPricesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem172?), TypeInfoPropertyName = "NullableIncludedItem1722")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem173?), TypeInfoPropertyName = "NullableIncludedItem1732")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionVersionType?), TypeInfoPropertyName = "NullableSubscriptionVersionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionVersionAttributesState?), TypeInfoPropertyName = "NullableSubscriptionVersionAttributesState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionVersionRelationshipsSubscriptionDataType?), TypeInfoPropertyName = "NullableSubscriptionVersionRelationshipsSubscriptionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionVersionRelationshipsImageDataType?), TypeInfoPropertyName = "NullableSubscriptionVersionRelationshipsImageDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionVersionRelationshipsImagesDataItemType?), TypeInfoPropertyName = "NullableSubscriptionVersionRelationshipsImagesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionVersionRelationshipsLocalizationsDataItemType?), TypeInfoPropertyName = "NullableSubscriptionVersionRelationshipsLocalizationsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem174?), TypeInfoPropertyName = "NullableIncludedItem1742")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem175?), TypeInfoPropertyName = "NullableIncludedItem1752")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionType?), TypeInfoPropertyName = "NullableSubscriptionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionAttributesState?), TypeInfoPropertyName = "NullableSubscriptionAttributesState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionAttributesSubscriptionPeriod?), TypeInfoPropertyName = "NullableSubscriptionAttributesSubscriptionPeriod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionAttributesMultiSeatStatus?), TypeInfoPropertyName = "NullableSubscriptionAttributesMultiSeatStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionAttributesMarketSetting?), TypeInfoPropertyName = "NullableSubscriptionAttributesMarketSetting2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionRelationshipsSubscriptionLocalizationsDataItemType?), TypeInfoPropertyName = "NullableSubscriptionRelationshipsSubscriptionLocalizationsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionRelationshipsAppStoreReviewScreenshotDataType?), TypeInfoPropertyName = "NullableSubscriptionRelationshipsAppStoreReviewScreenshotDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionRelationshipsGroupDataType?), TypeInfoPropertyName = "NullableSubscriptionRelationshipsGroupDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionRelationshipsIntroductoryOffersDataItemType?), TypeInfoPropertyName = "NullableSubscriptionRelationshipsIntroductoryOffersDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionRelationshipsPromotionalOffersDataItemType?), TypeInfoPropertyName = "NullableSubscriptionRelationshipsPromotionalOffersDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionRelationshipsOfferCodesDataItemType?), TypeInfoPropertyName = "NullableSubscriptionRelationshipsOfferCodesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionRelationshipsPricesDataItemType?), TypeInfoPropertyName = "NullableSubscriptionRelationshipsPricesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionRelationshipsPromotedPurchaseDataType?), TypeInfoPropertyName = "NullableSubscriptionRelationshipsPromotedPurchaseDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionRelationshipsSubscriptionAvailabilityDataType?), TypeInfoPropertyName = "NullableSubscriptionRelationshipsSubscriptionAvailabilityDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionRelationshipsWinBackOffersDataItemType?), TypeInfoPropertyName = "NullableSubscriptionRelationshipsWinBackOffersDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionRelationshipsImagesDataItemType?), TypeInfoPropertyName = "NullableSubscriptionRelationshipsImagesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionRelationshipsPlanAvailabilitiesDataItemType?), TypeInfoPropertyName = "NullableSubscriptionRelationshipsPlanAvailabilitiesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionRelationshipsVersionsDataItemType?), TypeInfoPropertyName = "NullableSubscriptionRelationshipsVersionsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem176?), TypeInfoPropertyName = "NullableIncludedItem1762")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsResponseIncludedItemDiscriminatorType?), TypeInfoPropertyName = "NullableSubscriptionsResponseIncludedItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem177?), TypeInfoPropertyName = "NullableIncludedItem1772")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem179?), TypeInfoPropertyName = "NullableIncludedItem1792")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.WinBackOfferType?), TypeInfoPropertyName = "NullableWinBackOfferType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.WinBackOfferAttributesPriority?), TypeInfoPropertyName = "NullableWinBackOfferAttributesPriority2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.WinBackOfferAttributesPromotionIntent?), TypeInfoPropertyName = "NullableWinBackOfferAttributesPromotionIntent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.WinBackOfferRelationshipsPricesDataItemType?), TypeInfoPropertyName = "NullableWinBackOfferRelationshipsPricesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupSubscriptionGroupLocalizationsLinkagesResponseDataItemType?), TypeInfoPropertyName = "NullableSubscriptionGroupSubscriptionGroupLocalizationsLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupSubscriptionsLinkagesResponseDataItemType?), TypeInfoPropertyName = "NullableSubscriptionGroupSubscriptionsLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupVersionsLinkagesResponseDataItemType?), TypeInfoPropertyName = "NullableSubscriptionGroupVersionsLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.OneOf<global::AppStoreConnect.ErrorSourcePointer, global::AppStoreConnect.ErrorSourceParameter>?), TypeInfoPropertyName = "NullableOneOfErrorSourcePointerErrorSourceParameter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.OneOf<string, global::AppStoreConnect.ErrorLinksAssociated>?), TypeInfoPropertyName = "NullableOneOfStringErrorLinksAssociated2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppMediaAssetStateState?), TypeInfoPropertyName = "NullableAppMediaAssetStateState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupsGetInstanceFieldsSubscriptionGroup?), TypeInfoPropertyName = "NullableSubscriptionGroupsGetInstanceFieldsSubscriptionGroup2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupsGetInstanceFieldsSubscription?), TypeInfoPropertyName = "NullableSubscriptionGroupsGetInstanceFieldsSubscription2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupsGetInstanceFieldsSubscriptionGroupLocalization?), TypeInfoPropertyName = "NullableSubscriptionGroupsGetInstanceFieldsSubscriptionGroupLocalization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupsGetInstanceFieldsSubscriptionGroupVersion?), TypeInfoPropertyName = "NullableSubscriptionGroupsGetInstanceFieldsSubscriptionGroupVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupsGetInstanceIncludeItem?), TypeInfoPropertyName = "NullableSubscriptionGroupsGetInstanceIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupsSubscriptionGroupLocalizationsGetToManyRelatedFieldsSubscriptionGroupLocalization?), TypeInfoPropertyName = "NullableSubscriptionGroupsSubscriptionGroupLocalizationsGetToManyRelatedFieldsSubscriptionGroupLocalization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupsSubscriptionGroupLocalizationsGetToManyRelatedFieldsSubscriptionGroup?), TypeInfoPropertyName = "NullableSubscriptionGroupsSubscriptionGroupLocalizationsGetToManyRelatedFieldsSubscriptionGroup2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupsSubscriptionGroupLocalizationsGetToManyRelatedIncludeItem?), TypeInfoPropertyName = "NullableSubscriptionGroupsSubscriptionGroupLocalizationsGetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFilterStateItem?), TypeInfoPropertyName = "NullableSubscriptionGroupsSubscriptionsGetToManyRelatedFilterStateItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedSortItem?), TypeInfoPropertyName = "NullableSubscriptionGroupsSubscriptionsGetToManyRelatedSortItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscription?), TypeInfoPropertyName = "NullableSubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscription2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionLocalization?), TypeInfoPropertyName = "NullableSubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionLocalization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionAppStoreReviewScreenshot?), TypeInfoPropertyName = "NullableSubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionAppStoreReviewScreenshot2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionGroup?), TypeInfoPropertyName = "NullableSubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionGroup2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionIntroductoryOffer?), TypeInfoPropertyName = "NullableSubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionIntroductoryOffer2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionPromotionalOffer?), TypeInfoPropertyName = "NullableSubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionPromotionalOffer2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionOfferCode?), TypeInfoPropertyName = "NullableSubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionOfferCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionPrice?), TypeInfoPropertyName = "NullableSubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionPrice2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsPromotedPurchase?), TypeInfoPropertyName = "NullableSubscriptionGroupsSubscriptionsGetToManyRelatedFieldsPromotedPurchase2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionAvailabilitie?), TypeInfoPropertyName = "NullableSubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionAvailabilitie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsWinBackOffer?), TypeInfoPropertyName = "NullableSubscriptionGroupsSubscriptionsGetToManyRelatedFieldsWinBackOffer2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionImage?), TypeInfoPropertyName = "NullableSubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionImage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionPlanAvailabilitie?), TypeInfoPropertyName = "NullableSubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionPlanAvailabilitie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionVersion?), TypeInfoPropertyName = "NullableSubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedIncludeItem?), TypeInfoPropertyName = "NullableSubscriptionGroupsSubscriptionsGetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupsVersionsGetToManyRelatedFilterStateItem?), TypeInfoPropertyName = "NullableSubscriptionGroupsVersionsGetToManyRelatedFilterStateItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupsVersionsGetToManyRelatedFieldsSubscriptionGroupVersion?), TypeInfoPropertyName = "NullableSubscriptionGroupsVersionsGetToManyRelatedFieldsSubscriptionGroupVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupsVersionsGetToManyRelatedFieldsSubscriptionGroup?), TypeInfoPropertyName = "NullableSubscriptionGroupsVersionsGetToManyRelatedFieldsSubscriptionGroup2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupsVersionsGetToManyRelatedFieldsSubscriptionGroupLocalization?), TypeInfoPropertyName = "NullableSubscriptionGroupsVersionsGetToManyRelatedFieldsSubscriptionGroupLocalization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupsVersionsGetToManyRelatedIncludeItem?), TypeInfoPropertyName = "NullableSubscriptionGroupsVersionsGetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.UploadOperation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.Subscription>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionAvailabilityRelationshipsAvailableTerritoriesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionGroupVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionGroupLocalization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionGroupVersionRelationshipsLocalizationsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.IncludedItem160>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionGroupRelationshipsSubscriptionsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionGroupRelationshipsSubscriptionGroupLocalizationsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionGroupRelationshipsVersionsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.IncludedItem163>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionCustomerEligibility>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionOfferCodeRelationshipsOneTimeUseCodesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionOfferCodeRelationshipsCustomCodesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionOfferCodeRelationshipsPricesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionPlanAvailabilityRelationshipsAvailableTerritoriesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionPromotionalOfferRelationshipsPricesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionVersionRelationshipsImagesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionVersionRelationshipsLocalizationsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionAttributesMarketSetting>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionRelationshipsSubscriptionLocalizationsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionRelationshipsIntroductoryOffersDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionRelationshipsPromotionalOffersDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionRelationshipsOfferCodesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionRelationshipsPricesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionRelationshipsWinBackOffersDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionRelationshipsImagesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionRelationshipsPlanAvailabilitiesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionRelationshipsVersionsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.IncludedItem176>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.WinBackOfferRelationshipsPricesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionGroupSubscriptionGroupLocalizationsLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionGroupSubscriptionsLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionGroupVersionsLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.ErrorResponseError>))]
    internal sealed partial class SubscriptionGroupsSourceGenerationContextChunk1 : global::System.Text.Json.Serialization.JsonSerializerContext
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppMediaStateError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.HttpHeader>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionGroupsGetInstanceFieldsSubscriptionGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionGroupsGetInstanceFieldsSubscription>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionGroupsGetInstanceFieldsSubscriptionGroupLocalization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionGroupsGetInstanceFieldsSubscriptionGroupVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionGroupsGetInstanceIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionGroupsSubscriptionGroupLocalizationsGetToManyRelatedFieldsSubscriptionGroupLocalization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionGroupsSubscriptionGroupLocalizationsGetToManyRelatedFieldsSubscriptionGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionGroupsSubscriptionGroupLocalizationsGetToManyRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFilterStateItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedSortItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscription>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionLocalization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionAppStoreReviewScreenshot>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionIntroductoryOffer>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionPromotionalOffer>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionOfferCode>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionPrice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsPromotedPurchase>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionAvailabilitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsWinBackOffer>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionPlanAvailabilitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionGroupsVersionsGetToManyRelatedFilterStateItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionGroupsVersionsGetToManyRelatedFieldsSubscriptionGroupVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionGroupsVersionsGetToManyRelatedFieldsSubscriptionGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionGroupsVersionsGetToManyRelatedFieldsSubscriptionGroupLocalization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionGroupsVersionsGetToManyRelatedIncludeItem>))]
    internal sealed partial class SubscriptionGroupsSourceGenerationContextChunk2 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SubscriptionGroupsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SubscriptionGroupsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private SubscriptionGroupsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.PromotedPurchaseType)

                    || typeToConvert == typeof(global::AppStoreConnect.PromotedPurchaseType?)

                    || typeToConvert == typeof(global::AppStoreConnect.PromotedPurchaseAttributesState)

                    || typeToConvert == typeof(global::AppStoreConnect.PromotedPurchaseAttributesState?)

                    || typeToConvert == typeof(global::AppStoreConnect.PromotedPurchaseRelationshipsInAppPurchaseV2DataType)

                    || typeToConvert == typeof(global::AppStoreConnect.PromotedPurchaseRelationshipsInAppPurchaseV2DataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.PromotedPurchaseRelationshipsSubscriptionDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.PromotedPurchaseRelationshipsSubscriptionDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionAppStoreReviewScreenshotType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionAppStoreReviewScreenshotType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionAppStoreReviewScreenshotRelationshipsSubscriptionDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionAppStoreReviewScreenshotRelationshipsSubscriptionDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionAvailabilityType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionAvailabilityType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionAvailabilityRelationshipsAvailableTerritoriesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionAvailabilityRelationshipsAvailableTerritoriesDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupLocalizationV2Type)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupLocalizationV2Type?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupLocalizationV2RelationshipsVersionDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupLocalizationV2RelationshipsVersionDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupLocalizationType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupLocalizationType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupLocalizationAttributesState)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupLocalizationAttributesState?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupLocalizationRelationshipsSubscriptionGroupDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupLocalizationRelationshipsSubscriptionGroupDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupVersionType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupVersionType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupVersionAttributesState)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupVersionAttributesState?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupVersionRelationshipsSubscriptionGroupDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupVersionRelationshipsSubscriptionGroupDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupVersionRelationshipsLocalizationsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupVersionRelationshipsLocalizationsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupVersionsResponseIncludedItemDiscriminatorType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupVersionsResponseIncludedItemDiscriminatorType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupRelationshipsSubscriptionsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupRelationshipsSubscriptionsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupRelationshipsSubscriptionGroupLocalizationsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupRelationshipsSubscriptionGroupLocalizationsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupRelationshipsVersionsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupRelationshipsVersionsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupResponseIncludedItemDiscriminatorType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupResponseIncludedItemDiscriminatorType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupCreateRequestDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupCreateRequestDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupCreateRequestDataRelationshipsAppDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupCreateRequestDataRelationshipsAppDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupUpdateRequestDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupUpdateRequestDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionImageType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionImageType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionImageAttributesState)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionImageAttributesState?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionImageRelationshipsSubscriptionDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionImageRelationshipsSubscriptionDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionIntroductoryOfferType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionIntroductoryOfferType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionIntroductoryOfferRelationshipsSubscriptionDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionIntroductoryOfferRelationshipsSubscriptionDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionIntroductoryOfferRelationshipsTerritoryDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionIntroductoryOfferRelationshipsTerritoryDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionIntroductoryOfferRelationshipsSubscriptionPricePointDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionIntroductoryOfferRelationshipsSubscriptionPricePointDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionLocalizationType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionLocalizationType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionLocalizationAttributesState)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionLocalizationAttributesState?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionLocalizationRelationshipsSubscriptionDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionLocalizationRelationshipsSubscriptionDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferCodeType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferCodeType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferCodeRelationshipsSubscriptionDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferCodeRelationshipsSubscriptionDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferCodeRelationshipsOneTimeUseCodesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferCodeRelationshipsOneTimeUseCodesDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferCodeRelationshipsCustomCodesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferCodeRelationshipsCustomCodesDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferCodeRelationshipsPricesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferCodeRelationshipsPricesDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionPlanAvailabilityType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionPlanAvailabilityType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionPlanAvailabilityRelationshipsAvailableTerritoriesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionPlanAvailabilityRelationshipsAvailableTerritoriesDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionPriceType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionPriceType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionPriceRelationshipsTerritoryDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionPriceRelationshipsTerritoryDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionPriceRelationshipsSubscriptionPricePointDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionPriceRelationshipsSubscriptionPricePointDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionPromotionalOfferType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionPromotionalOfferType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionPromotionalOfferRelationshipsSubscriptionDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionPromotionalOfferRelationshipsSubscriptionDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionPromotionalOfferRelationshipsPricesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionPromotionalOfferRelationshipsPricesDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionVersionType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionVersionType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionVersionAttributesState)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionVersionAttributesState?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionVersionRelationshipsSubscriptionDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionVersionRelationshipsSubscriptionDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionVersionRelationshipsImageDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionVersionRelationshipsImageDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionVersionRelationshipsImagesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionVersionRelationshipsImagesDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionVersionRelationshipsLocalizationsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionVersionRelationshipsLocalizationsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionAttributesState)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionAttributesState?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionAttributesSubscriptionPeriod)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionAttributesSubscriptionPeriod?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionAttributesMultiSeatStatus)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionAttributesMultiSeatStatus?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionAttributesMarketSetting)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionAttributesMarketSetting?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionRelationshipsSubscriptionLocalizationsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionRelationshipsSubscriptionLocalizationsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionRelationshipsAppStoreReviewScreenshotDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionRelationshipsAppStoreReviewScreenshotDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionRelationshipsGroupDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionRelationshipsGroupDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionRelationshipsIntroductoryOffersDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionRelationshipsIntroductoryOffersDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionRelationshipsPromotionalOffersDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionRelationshipsPromotionalOffersDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionRelationshipsOfferCodesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionRelationshipsOfferCodesDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionRelationshipsPricesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionRelationshipsPricesDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionRelationshipsPromotedPurchaseDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionRelationshipsPromotedPurchaseDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionRelationshipsSubscriptionAvailabilityDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionRelationshipsSubscriptionAvailabilityDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionRelationshipsWinBackOffersDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionRelationshipsWinBackOffersDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionRelationshipsImagesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionRelationshipsImagesDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionRelationshipsPlanAvailabilitiesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionRelationshipsPlanAvailabilitiesDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionRelationshipsVersionsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionRelationshipsVersionsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsResponseIncludedItemDiscriminatorType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsResponseIncludedItemDiscriminatorType?)

                    || typeToConvert == typeof(global::AppStoreConnect.WinBackOfferType)

                    || typeToConvert == typeof(global::AppStoreConnect.WinBackOfferType?)

                    || typeToConvert == typeof(global::AppStoreConnect.WinBackOfferAttributesPriority)

                    || typeToConvert == typeof(global::AppStoreConnect.WinBackOfferAttributesPriority?)

                    || typeToConvert == typeof(global::AppStoreConnect.WinBackOfferAttributesPromotionIntent)

                    || typeToConvert == typeof(global::AppStoreConnect.WinBackOfferAttributesPromotionIntent?)

                    || typeToConvert == typeof(global::AppStoreConnect.WinBackOfferRelationshipsPricesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.WinBackOfferRelationshipsPricesDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupSubscriptionGroupLocalizationsLinkagesResponseDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupSubscriptionGroupLocalizationsLinkagesResponseDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupSubscriptionsLinkagesResponseDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupSubscriptionsLinkagesResponseDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupVersionsLinkagesResponseDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupVersionsLinkagesResponseDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppMediaAssetStateState)

                    || typeToConvert == typeof(global::AppStoreConnect.AppMediaAssetStateState?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionCustomerEligibility)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionCustomerEligibility?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferDuration)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferDuration?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferEligibility)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferEligibility?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferMode)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferMode?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionPlanType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionPlanType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupsGetInstanceFieldsSubscriptionGroup)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupsGetInstanceFieldsSubscriptionGroup?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupsGetInstanceFieldsSubscription)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupsGetInstanceFieldsSubscription?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupsGetInstanceFieldsSubscriptionGroupLocalization)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupsGetInstanceFieldsSubscriptionGroupLocalization?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupsGetInstanceFieldsSubscriptionGroupVersion)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupsGetInstanceFieldsSubscriptionGroupVersion?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupsGetInstanceIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupsGetInstanceIncludeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupsSubscriptionGroupLocalizationsGetToManyRelatedFieldsSubscriptionGroupLocalization)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupsSubscriptionGroupLocalizationsGetToManyRelatedFieldsSubscriptionGroupLocalization?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupsSubscriptionGroupLocalizationsGetToManyRelatedFieldsSubscriptionGroup)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupsSubscriptionGroupLocalizationsGetToManyRelatedFieldsSubscriptionGroup?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupsSubscriptionGroupLocalizationsGetToManyRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupsSubscriptionGroupLocalizationsGetToManyRelatedIncludeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFilterStateItem)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFilterStateItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedSortItem)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedSortItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscription)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscription?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionLocalization)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionLocalization?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionAppStoreReviewScreenshot)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionAppStoreReviewScreenshot?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionGroup)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionGroup?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionIntroductoryOffer)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionIntroductoryOffer?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionPromotionalOffer)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionPromotionalOffer?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionOfferCode)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionOfferCode?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionPrice)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionPrice?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsPromotedPurchase)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsPromotedPurchase?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionAvailabilitie)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionAvailabilitie?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsWinBackOffer)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsWinBackOffer?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionImage)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionImage?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionPlanAvailabilitie)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionPlanAvailabilitie?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionVersion)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionVersion?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedIncludeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupsVersionsGetToManyRelatedFilterStateItem)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupsVersionsGetToManyRelatedFilterStateItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupsVersionsGetToManyRelatedFieldsSubscriptionGroupVersion)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupsVersionsGetToManyRelatedFieldsSubscriptionGroupVersion?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupsVersionsGetToManyRelatedFieldsSubscriptionGroup)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupsVersionsGetToManyRelatedFieldsSubscriptionGroup?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupsVersionsGetToManyRelatedFieldsSubscriptionGroupLocalization)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupsVersionsGetToManyRelatedFieldsSubscriptionGroupLocalization?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupsVersionsGetToManyRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupsVersionsGetToManyRelatedIncludeItem?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.PromotedPurchaseType))
                {
                    return new global::AppStoreConnect.JsonConverters.PromotedPurchaseTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.PromotedPurchaseType?))
                {
                    return new global::AppStoreConnect.JsonConverters.PromotedPurchaseTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.PromotedPurchaseAttributesState))
                {
                    return new global::AppStoreConnect.JsonConverters.PromotedPurchaseAttributesStateJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.PromotedPurchaseAttributesState?))
                {
                    return new global::AppStoreConnect.JsonConverters.PromotedPurchaseAttributesStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.PromotedPurchaseRelationshipsInAppPurchaseV2DataType))
                {
                    return new global::AppStoreConnect.JsonConverters.PromotedPurchaseRelationshipsInAppPurchaseV2DataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.PromotedPurchaseRelationshipsInAppPurchaseV2DataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.PromotedPurchaseRelationshipsInAppPurchaseV2DataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.PromotedPurchaseRelationshipsSubscriptionDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.PromotedPurchaseRelationshipsSubscriptionDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.PromotedPurchaseRelationshipsSubscriptionDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.PromotedPurchaseRelationshipsSubscriptionDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionAppStoreReviewScreenshotType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionAppStoreReviewScreenshotTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionAppStoreReviewScreenshotType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionAppStoreReviewScreenshotTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionAppStoreReviewScreenshotRelationshipsSubscriptionDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionAppStoreReviewScreenshotRelationshipsSubscriptionDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionAppStoreReviewScreenshotRelationshipsSubscriptionDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionAppStoreReviewScreenshotRelationshipsSubscriptionDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionAvailabilityType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionAvailabilityTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionAvailabilityType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionAvailabilityTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionAvailabilityRelationshipsAvailableTerritoriesDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionAvailabilityRelationshipsAvailableTerritoriesDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionAvailabilityRelationshipsAvailableTerritoriesDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionAvailabilityRelationshipsAvailableTerritoriesDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupLocalizationV2Type))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupLocalizationV2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupLocalizationV2Type?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupLocalizationV2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupLocalizationV2RelationshipsVersionDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupLocalizationV2RelationshipsVersionDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupLocalizationV2RelationshipsVersionDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupLocalizationV2RelationshipsVersionDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupLocalizationType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupLocalizationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupLocalizationType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupLocalizationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupLocalizationAttributesState))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupLocalizationAttributesStateJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupLocalizationAttributesState?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupLocalizationAttributesStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupLocalizationRelationshipsSubscriptionGroupDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupLocalizationRelationshipsSubscriptionGroupDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupLocalizationRelationshipsSubscriptionGroupDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupLocalizationRelationshipsSubscriptionGroupDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupVersionType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupVersionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupVersionType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupVersionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupVersionAttributesState))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupVersionAttributesStateJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupVersionAttributesState?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupVersionAttributesStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupVersionRelationshipsSubscriptionGroupDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupVersionRelationshipsSubscriptionGroupDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupVersionRelationshipsSubscriptionGroupDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupVersionRelationshipsSubscriptionGroupDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupVersionRelationshipsLocalizationsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupVersionRelationshipsLocalizationsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupVersionRelationshipsLocalizationsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupVersionRelationshipsLocalizationsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupVersionsResponseIncludedItemDiscriminatorType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupVersionsResponseIncludedItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupVersionsResponseIncludedItemDiscriminatorType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupVersionsResponseIncludedItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupRelationshipsSubscriptionsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupRelationshipsSubscriptionsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupRelationshipsSubscriptionsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupRelationshipsSubscriptionsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupRelationshipsSubscriptionGroupLocalizationsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupRelationshipsSubscriptionGroupLocalizationsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupRelationshipsSubscriptionGroupLocalizationsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupRelationshipsSubscriptionGroupLocalizationsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupRelationshipsVersionsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupRelationshipsVersionsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupRelationshipsVersionsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupRelationshipsVersionsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupResponseIncludedItemDiscriminatorType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupResponseIncludedItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupResponseIncludedItemDiscriminatorType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupResponseIncludedItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupCreateRequestDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupCreateRequestDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupCreateRequestDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupCreateRequestDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupCreateRequestDataRelationshipsAppDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupCreateRequestDataRelationshipsAppDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupCreateRequestDataRelationshipsAppDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupCreateRequestDataRelationshipsAppDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupUpdateRequestDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupUpdateRequestDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupUpdateRequestDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupUpdateRequestDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionImageType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionImageTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionImageType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionImageTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionImageAttributesState))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionImageAttributesStateJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionImageAttributesState?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionImageAttributesStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionImageRelationshipsSubscriptionDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionImageRelationshipsSubscriptionDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionImageRelationshipsSubscriptionDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionImageRelationshipsSubscriptionDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionIntroductoryOfferType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionIntroductoryOfferTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionIntroductoryOfferType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionIntroductoryOfferTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionIntroductoryOfferRelationshipsSubscriptionDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionIntroductoryOfferRelationshipsSubscriptionDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionIntroductoryOfferRelationshipsSubscriptionDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionIntroductoryOfferRelationshipsSubscriptionDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionIntroductoryOfferRelationshipsTerritoryDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionIntroductoryOfferRelationshipsTerritoryDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionIntroductoryOfferRelationshipsTerritoryDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionIntroductoryOfferRelationshipsTerritoryDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionIntroductoryOfferRelationshipsSubscriptionPricePointDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionIntroductoryOfferRelationshipsSubscriptionPricePointDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionIntroductoryOfferRelationshipsSubscriptionPricePointDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionIntroductoryOfferRelationshipsSubscriptionPricePointDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionLocalizationType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionLocalizationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionLocalizationType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionLocalizationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionLocalizationAttributesState))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionLocalizationAttributesStateJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionLocalizationAttributesState?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionLocalizationAttributesStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionLocalizationRelationshipsSubscriptionDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionLocalizationRelationshipsSubscriptionDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionLocalizationRelationshipsSubscriptionDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionLocalizationRelationshipsSubscriptionDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferCodeType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionOfferCodeTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferCodeType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionOfferCodeTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferCodeRelationshipsSubscriptionDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionOfferCodeRelationshipsSubscriptionDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferCodeRelationshipsSubscriptionDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionOfferCodeRelationshipsSubscriptionDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferCodeRelationshipsOneTimeUseCodesDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionOfferCodeRelationshipsOneTimeUseCodesDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferCodeRelationshipsOneTimeUseCodesDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionOfferCodeRelationshipsOneTimeUseCodesDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferCodeRelationshipsCustomCodesDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionOfferCodeRelationshipsCustomCodesDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferCodeRelationshipsCustomCodesDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionOfferCodeRelationshipsCustomCodesDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferCodeRelationshipsPricesDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionOfferCodeRelationshipsPricesDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferCodeRelationshipsPricesDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionOfferCodeRelationshipsPricesDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionPlanAvailabilityType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionPlanAvailabilityTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionPlanAvailabilityType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionPlanAvailabilityTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionPlanAvailabilityRelationshipsAvailableTerritoriesDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionPlanAvailabilityRelationshipsAvailableTerritoriesDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionPlanAvailabilityRelationshipsAvailableTerritoriesDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionPlanAvailabilityRelationshipsAvailableTerritoriesDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionPriceType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionPriceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionPriceType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionPriceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionPriceRelationshipsTerritoryDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionPriceRelationshipsTerritoryDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionPriceRelationshipsTerritoryDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionPriceRelationshipsTerritoryDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionPriceRelationshipsSubscriptionPricePointDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionPriceRelationshipsSubscriptionPricePointDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionPriceRelationshipsSubscriptionPricePointDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionPriceRelationshipsSubscriptionPricePointDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionPromotionalOfferType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionPromotionalOfferTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionPromotionalOfferType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionPromotionalOfferTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionPromotionalOfferRelationshipsSubscriptionDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionPromotionalOfferRelationshipsSubscriptionDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionPromotionalOfferRelationshipsSubscriptionDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionPromotionalOfferRelationshipsSubscriptionDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionPromotionalOfferRelationshipsPricesDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionPromotionalOfferRelationshipsPricesDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionPromotionalOfferRelationshipsPricesDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionPromotionalOfferRelationshipsPricesDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionVersionType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionVersionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionVersionType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionVersionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionVersionAttributesState))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionVersionAttributesStateJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionVersionAttributesState?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionVersionAttributesStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionVersionRelationshipsSubscriptionDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionVersionRelationshipsSubscriptionDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionVersionRelationshipsSubscriptionDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionVersionRelationshipsSubscriptionDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionVersionRelationshipsImageDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionVersionRelationshipsImageDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionVersionRelationshipsImageDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionVersionRelationshipsImageDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionVersionRelationshipsImagesDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionVersionRelationshipsImagesDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionVersionRelationshipsImagesDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionVersionRelationshipsImagesDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionVersionRelationshipsLocalizationsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionVersionRelationshipsLocalizationsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionVersionRelationshipsLocalizationsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionVersionRelationshipsLocalizationsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionAttributesState))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionAttributesStateJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionAttributesState?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionAttributesStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionAttributesSubscriptionPeriod))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionAttributesSubscriptionPeriodJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionAttributesSubscriptionPeriod?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionAttributesSubscriptionPeriodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionAttributesMultiSeatStatus))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionAttributesMultiSeatStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionAttributesMultiSeatStatus?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionAttributesMultiSeatStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionAttributesMarketSetting))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionAttributesMarketSettingJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionAttributesMarketSetting?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionAttributesMarketSettingNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionRelationshipsSubscriptionLocalizationsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionRelationshipsSubscriptionLocalizationsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionRelationshipsSubscriptionLocalizationsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionRelationshipsSubscriptionLocalizationsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionRelationshipsAppStoreReviewScreenshotDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionRelationshipsAppStoreReviewScreenshotDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionRelationshipsAppStoreReviewScreenshotDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionRelationshipsAppStoreReviewScreenshotDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionRelationshipsGroupDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionRelationshipsGroupDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionRelationshipsGroupDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionRelationshipsGroupDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionRelationshipsIntroductoryOffersDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionRelationshipsIntroductoryOffersDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionRelationshipsIntroductoryOffersDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionRelationshipsIntroductoryOffersDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionRelationshipsPromotionalOffersDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionRelationshipsPromotionalOffersDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionRelationshipsPromotionalOffersDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionRelationshipsPromotionalOffersDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionRelationshipsOfferCodesDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionRelationshipsOfferCodesDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionRelationshipsOfferCodesDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionRelationshipsOfferCodesDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionRelationshipsPricesDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionRelationshipsPricesDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionRelationshipsPricesDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionRelationshipsPricesDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionRelationshipsPromotedPurchaseDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionRelationshipsPromotedPurchaseDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionRelationshipsPromotedPurchaseDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionRelationshipsPromotedPurchaseDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionRelationshipsSubscriptionAvailabilityDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionRelationshipsSubscriptionAvailabilityDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionRelationshipsSubscriptionAvailabilityDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionRelationshipsSubscriptionAvailabilityDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionRelationshipsWinBackOffersDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionRelationshipsWinBackOffersDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionRelationshipsWinBackOffersDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionRelationshipsWinBackOffersDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionRelationshipsImagesDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionRelationshipsImagesDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionRelationshipsImagesDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionRelationshipsImagesDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionRelationshipsPlanAvailabilitiesDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionRelationshipsPlanAvailabilitiesDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionRelationshipsPlanAvailabilitiesDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionRelationshipsPlanAvailabilitiesDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionRelationshipsVersionsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionRelationshipsVersionsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionRelationshipsVersionsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionRelationshipsVersionsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsResponseIncludedItemDiscriminatorType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsResponseIncludedItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsResponseIncludedItemDiscriminatorType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsResponseIncludedItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.WinBackOfferType))
                {
                    return new global::AppStoreConnect.JsonConverters.WinBackOfferTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.WinBackOfferType?))
                {
                    return new global::AppStoreConnect.JsonConverters.WinBackOfferTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.WinBackOfferAttributesPriority))
                {
                    return new global::AppStoreConnect.JsonConverters.WinBackOfferAttributesPriorityJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.WinBackOfferAttributesPriority?))
                {
                    return new global::AppStoreConnect.JsonConverters.WinBackOfferAttributesPriorityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.WinBackOfferAttributesPromotionIntent))
                {
                    return new global::AppStoreConnect.JsonConverters.WinBackOfferAttributesPromotionIntentJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.WinBackOfferAttributesPromotionIntent?))
                {
                    return new global::AppStoreConnect.JsonConverters.WinBackOfferAttributesPromotionIntentNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.WinBackOfferRelationshipsPricesDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.WinBackOfferRelationshipsPricesDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.WinBackOfferRelationshipsPricesDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.WinBackOfferRelationshipsPricesDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupSubscriptionGroupLocalizationsLinkagesResponseDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupSubscriptionGroupLocalizationsLinkagesResponseDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupSubscriptionGroupLocalizationsLinkagesResponseDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupSubscriptionGroupLocalizationsLinkagesResponseDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupSubscriptionsLinkagesResponseDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupSubscriptionsLinkagesResponseDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupSubscriptionsLinkagesResponseDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupSubscriptionsLinkagesResponseDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupVersionsLinkagesResponseDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupVersionsLinkagesResponseDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupVersionsLinkagesResponseDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupVersionsLinkagesResponseDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppMediaAssetStateState))
                {
                    return new global::AppStoreConnect.JsonConverters.AppMediaAssetStateStateJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppMediaAssetStateState?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppMediaAssetStateStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionCustomerEligibility))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionCustomerEligibilityJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionCustomerEligibility?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionCustomerEligibilityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferDuration))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionOfferDurationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferDuration?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionOfferDurationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferEligibility))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionOfferEligibilityJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferEligibility?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionOfferEligibilityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferMode))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionOfferModeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferMode?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionOfferModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionPlanType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionPlanTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionPlanType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionPlanTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupsGetInstanceFieldsSubscriptionGroup))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupsGetInstanceFieldsSubscriptionGroupJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupsGetInstanceFieldsSubscriptionGroup?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupsGetInstanceFieldsSubscriptionGroupNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupsGetInstanceFieldsSubscription))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupsGetInstanceFieldsSubscriptionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupsGetInstanceFieldsSubscription?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupsGetInstanceFieldsSubscriptionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupsGetInstanceFieldsSubscriptionGroupLocalization))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupsGetInstanceFieldsSubscriptionGroupLocalizationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupsGetInstanceFieldsSubscriptionGroupLocalization?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupsGetInstanceFieldsSubscriptionGroupLocalizationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupsGetInstanceFieldsSubscriptionGroupVersion))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupsGetInstanceFieldsSubscriptionGroupVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupsGetInstanceFieldsSubscriptionGroupVersion?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupsGetInstanceFieldsSubscriptionGroupVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupsGetInstanceIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupsGetInstanceIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupsGetInstanceIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupsGetInstanceIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupsSubscriptionGroupLocalizationsGetToManyRelatedFieldsSubscriptionGroupLocalization))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupsSubscriptionGroupLocalizationsGetToManyRelatedFieldsSubscriptionGroupLocalizationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupsSubscriptionGroupLocalizationsGetToManyRelatedFieldsSubscriptionGroupLocalization?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupsSubscriptionGroupLocalizationsGetToManyRelatedFieldsSubscriptionGroupLocalizationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupsSubscriptionGroupLocalizationsGetToManyRelatedFieldsSubscriptionGroup))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupsSubscriptionGroupLocalizationsGetToManyRelatedFieldsSubscriptionGroupJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupsSubscriptionGroupLocalizationsGetToManyRelatedFieldsSubscriptionGroup?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupsSubscriptionGroupLocalizationsGetToManyRelatedFieldsSubscriptionGroupNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupsSubscriptionGroupLocalizationsGetToManyRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupsSubscriptionGroupLocalizationsGetToManyRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupsSubscriptionGroupLocalizationsGetToManyRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupsSubscriptionGroupLocalizationsGetToManyRelatedIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFilterStateItem))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupsSubscriptionsGetToManyRelatedFilterStateItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFilterStateItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupsSubscriptionsGetToManyRelatedFilterStateItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedSortItem))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupsSubscriptionsGetToManyRelatedSortItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedSortItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupsSubscriptionsGetToManyRelatedSortItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscription))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscription?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionLocalization))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionLocalizationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionLocalization?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionLocalizationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionAppStoreReviewScreenshot))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionAppStoreReviewScreenshotJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionAppStoreReviewScreenshot?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionAppStoreReviewScreenshotNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionGroup))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionGroupJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionGroup?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionGroupNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionIntroductoryOffer))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionIntroductoryOfferJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionIntroductoryOffer?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionIntroductoryOfferNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionPromotionalOffer))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionPromotionalOfferJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionPromotionalOffer?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionPromotionalOfferNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionOfferCode))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionOfferCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionOfferCode?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionOfferCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionPrice))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionPriceJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionPrice?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionPriceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsPromotedPurchase))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsPromotedPurchaseJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsPromotedPurchase?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsPromotedPurchaseNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionAvailabilitie))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionAvailabilitieJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionAvailabilitie?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionAvailabilitieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsWinBackOffer))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsWinBackOfferJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsWinBackOffer?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsWinBackOfferNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionImage))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionImageJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionImage?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionImageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionPlanAvailabilitie))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionPlanAvailabilitieJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionPlanAvailabilitie?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionPlanAvailabilitieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionVersion))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionVersion?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupsSubscriptionsGetToManyRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupsSubscriptionsGetToManyRelatedIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupsVersionsGetToManyRelatedFilterStateItem))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupsVersionsGetToManyRelatedFilterStateItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupsVersionsGetToManyRelatedFilterStateItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupsVersionsGetToManyRelatedFilterStateItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupsVersionsGetToManyRelatedFieldsSubscriptionGroupVersion))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupsVersionsGetToManyRelatedFieldsSubscriptionGroupVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupsVersionsGetToManyRelatedFieldsSubscriptionGroupVersion?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupsVersionsGetToManyRelatedFieldsSubscriptionGroupVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupsVersionsGetToManyRelatedFieldsSubscriptionGroup))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupsVersionsGetToManyRelatedFieldsSubscriptionGroupJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupsVersionsGetToManyRelatedFieldsSubscriptionGroup?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupsVersionsGetToManyRelatedFieldsSubscriptionGroupNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupsVersionsGetToManyRelatedFieldsSubscriptionGroupLocalization))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupsVersionsGetToManyRelatedFieldsSubscriptionGroupLocalizationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupsVersionsGetToManyRelatedFieldsSubscriptionGroupLocalization?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupsVersionsGetToManyRelatedFieldsSubscriptionGroupLocalizationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupsVersionsGetToManyRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupsVersionsGetToManyRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupsVersionsGetToManyRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupsVersionsGetToManyRelatedIncludeItemNullableJsonConverter();
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
                    0 => new SubscriptionGroupsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),

                    1 => new SubscriptionGroupsSourceGenerationContextChunk1(new global::System.Text.Json.JsonSerializerOptions()),

                    2 => new SubscriptionGroupsSourceGenerationContextChunk2(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}