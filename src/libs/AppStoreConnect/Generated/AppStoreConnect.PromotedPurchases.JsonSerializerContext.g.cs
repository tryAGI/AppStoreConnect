
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppCategory))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppClipAdvancedExperienceImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.InAppPurchaseV2Type), TypeInfoPropertyName = "InAppPurchaseV2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.InAppPurchaseV2Attributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.InAppPurchaseType2), TypeInfoPropertyName = "InAppPurchaseType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.InAppPurchaseState), TypeInfoPropertyName = "InAppPurchaseState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.InAppPurchaseV2Relationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsInAppPurchaseLocalizations))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchaseV2RelationshipsInAppPurchaseLocalizationsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsInAppPurchaseLocalizationsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsInAppPurchaseLocalizationsDataItemType), TypeInfoPropertyName = "InAppPurchaseV2RelationshipsInAppPurchaseLocalizationsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsPricePoints))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchaseV2RelationshipsPricePointsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsPricePointsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsPricePointsDataItemType), TypeInfoPropertyName = "InAppPurchaseV2RelationshipsPricePointsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsContentData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsContentDataType), TypeInfoPropertyName = "InAppPurchaseV2RelationshipsContentDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsAppStoreReviewScreenshot))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsAppStoreReviewScreenshotData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsAppStoreReviewScreenshotDataType), TypeInfoPropertyName = "InAppPurchaseV2RelationshipsAppStoreReviewScreenshotDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsPromotedPurchase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsPromotedPurchaseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsPromotedPurchaseDataType), TypeInfoPropertyName = "InAppPurchaseV2RelationshipsPromotedPurchaseDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsIapPriceSchedule))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsIapPriceScheduleData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsIapPriceScheduleDataType), TypeInfoPropertyName = "InAppPurchaseV2RelationshipsIapPriceScheduleDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsInAppPurchaseAvailability))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsInAppPurchaseAvailabilityData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsInAppPurchaseAvailabilityDataType), TypeInfoPropertyName = "InAppPurchaseV2RelationshipsInAppPurchaseAvailabilityDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsImages))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchaseV2RelationshipsImagesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsImagesDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsImagesDataItemType), TypeInfoPropertyName = "InAppPurchaseV2RelationshipsImagesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsOfferCodes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchaseV2RelationshipsOfferCodesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsOfferCodesDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsOfferCodesDataItemType), TypeInfoPropertyName = "InAppPurchaseV2RelationshipsOfferCodesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsVersions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchaseV2RelationshipsVersionsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsVersionsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsVersionsDataItemType), TypeInfoPropertyName = "InAppPurchaseV2RelationshipsVersionsDataItemType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.PromotedPurchaseResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.IncludedItem153>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem153), TypeInfoPropertyName = "IncludedItem1532")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.PromotedPurchaseResponseIncludedItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.PromotedPurchaseResponseIncludedItemDiscriminatorType), TypeInfoPropertyName = "PromotedPurchaseResponseIncludedItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.PromotedPurchaseCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.PromotedPurchaseCreateRequestData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.PromotedPurchaseCreateRequestDataType), TypeInfoPropertyName = "PromotedPurchaseCreateRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.PromotedPurchaseCreateRequestDataAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.PromotedPurchaseCreateRequestDataRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.PromotedPurchaseCreateRequestDataRelationshipsApp))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.PromotedPurchaseCreateRequestDataRelationshipsAppData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.PromotedPurchaseCreateRequestDataRelationshipsAppDataType), TypeInfoPropertyName = "PromotedPurchaseCreateRequestDataRelationshipsAppDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.PromotedPurchaseCreateRequestDataRelationshipsInAppPurchaseV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.PromotedPurchaseCreateRequestDataRelationshipsInAppPurchaseV2Data))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.PromotedPurchaseCreateRequestDataRelationshipsInAppPurchaseV2DataType), TypeInfoPropertyName = "PromotedPurchaseCreateRequestDataRelationshipsInAppPurchaseV2DataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.PromotedPurchaseCreateRequestDataRelationshipsSubscription))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.PromotedPurchaseCreateRequestDataRelationshipsSubscriptionData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.PromotedPurchaseCreateRequestDataRelationshipsSubscriptionDataType), TypeInfoPropertyName = "PromotedPurchaseCreateRequestDataRelationshipsSubscriptionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.PromotedPurchaseUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.PromotedPurchaseUpdateRequestData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.PromotedPurchaseUpdateRequestDataType), TypeInfoPropertyName = "PromotedPurchaseUpdateRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.PromotedPurchaseUpdateRequestDataAttributes))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem176), TypeInfoPropertyName = "IncludedItem1762")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.WinBackOffer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem177), TypeInfoPropertyName = "IncludedItem1772")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem179), TypeInfoPropertyName = "IncludedItem1792")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.PromotedPurchasesGetInstanceFieldsPromotedPurchase>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.PromotedPurchasesGetInstanceFieldsPromotedPurchase), TypeInfoPropertyName = "PromotedPurchasesGetInstanceFieldsPromotedPurchase2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.PromotedPurchasesGetInstanceFieldsInAppPurchase>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.PromotedPurchasesGetInstanceFieldsInAppPurchase), TypeInfoPropertyName = "PromotedPurchasesGetInstanceFieldsInAppPurchase2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.PromotedPurchasesGetInstanceFieldsSubscription>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.PromotedPurchasesGetInstanceFieldsSubscription), TypeInfoPropertyName = "PromotedPurchasesGetInstanceFieldsSubscription2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.PromotedPurchasesGetInstanceIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.PromotedPurchasesGetInstanceIncludeItem), TypeInfoPropertyName = "PromotedPurchasesGetInstanceIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
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
    internal sealed partial class PromotedPurchasesSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.InAppPurchaseV2Type?), TypeInfoPropertyName = "NullableInAppPurchaseV2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.InAppPurchaseType2?), TypeInfoPropertyName = "NullableInAppPurchaseType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.InAppPurchaseState?), TypeInfoPropertyName = "NullableInAppPurchaseState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsInAppPurchaseLocalizationsDataItemType?), TypeInfoPropertyName = "NullableInAppPurchaseV2RelationshipsInAppPurchaseLocalizationsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsPricePointsDataItemType?), TypeInfoPropertyName = "NullableInAppPurchaseV2RelationshipsPricePointsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsContentDataType?), TypeInfoPropertyName = "NullableInAppPurchaseV2RelationshipsContentDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsAppStoreReviewScreenshotDataType?), TypeInfoPropertyName = "NullableInAppPurchaseV2RelationshipsAppStoreReviewScreenshotDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsPromotedPurchaseDataType?), TypeInfoPropertyName = "NullableInAppPurchaseV2RelationshipsPromotedPurchaseDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsIapPriceScheduleDataType?), TypeInfoPropertyName = "NullableInAppPurchaseV2RelationshipsIapPriceScheduleDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsInAppPurchaseAvailabilityDataType?), TypeInfoPropertyName = "NullableInAppPurchaseV2RelationshipsInAppPurchaseAvailabilityDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsImagesDataItemType?), TypeInfoPropertyName = "NullableInAppPurchaseV2RelationshipsImagesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsOfferCodesDataItemType?), TypeInfoPropertyName = "NullableInAppPurchaseV2RelationshipsOfferCodesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsVersionsDataItemType?), TypeInfoPropertyName = "NullableInAppPurchaseV2RelationshipsVersionsDataItemType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.PromotedPurchaseResponseIncludedItemDiscriminatorType?), TypeInfoPropertyName = "NullablePromotedPurchaseResponseIncludedItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.PromotedPurchaseCreateRequestDataType?), TypeInfoPropertyName = "NullablePromotedPurchaseCreateRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.PromotedPurchaseCreateRequestDataRelationshipsAppDataType?), TypeInfoPropertyName = "NullablePromotedPurchaseCreateRequestDataRelationshipsAppDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.PromotedPurchaseCreateRequestDataRelationshipsInAppPurchaseV2DataType?), TypeInfoPropertyName = "NullablePromotedPurchaseCreateRequestDataRelationshipsInAppPurchaseV2DataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.PromotedPurchaseCreateRequestDataRelationshipsSubscriptionDataType?), TypeInfoPropertyName = "NullablePromotedPurchaseCreateRequestDataRelationshipsSubscriptionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.PromotedPurchaseUpdateRequestDataType?), TypeInfoPropertyName = "NullablePromotedPurchaseUpdateRequestDataType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem177?), TypeInfoPropertyName = "NullableIncludedItem1772")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem179?), TypeInfoPropertyName = "NullableIncludedItem1792")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.OneOf<global::AppStoreConnect.ErrorSourcePointer, global::AppStoreConnect.ErrorSourceParameter>?), TypeInfoPropertyName = "NullableOneOfErrorSourcePointerErrorSourceParameter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.OneOf<string, global::AppStoreConnect.ErrorLinksAssociated>?), TypeInfoPropertyName = "NullableOneOfStringErrorLinksAssociated2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.PromotedPurchasesGetInstanceFieldsPromotedPurchase?), TypeInfoPropertyName = "NullablePromotedPurchasesGetInstanceFieldsPromotedPurchase2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.PromotedPurchasesGetInstanceFieldsInAppPurchase?), TypeInfoPropertyName = "NullablePromotedPurchasesGetInstanceFieldsInAppPurchase2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.PromotedPurchasesGetInstanceFieldsSubscription?), TypeInfoPropertyName = "NullablePromotedPurchasesGetInstanceFieldsSubscription2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.PromotedPurchasesGetInstanceIncludeItem?), TypeInfoPropertyName = "NullablePromotedPurchasesGetInstanceIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.InAppPurchaseV2RelationshipsInAppPurchaseLocalizationsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.InAppPurchaseV2RelationshipsPricePointsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.InAppPurchaseV2RelationshipsImagesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.InAppPurchaseV2RelationshipsOfferCodesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.InAppPurchaseV2RelationshipsVersionsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.IncludedItem153>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.ErrorResponseError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.PromotedPurchasesGetInstanceFieldsPromotedPurchase>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.PromotedPurchasesGetInstanceFieldsInAppPurchase>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.PromotedPurchasesGetInstanceFieldsSubscription>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.PromotedPurchasesGetInstanceIncludeItem>))]
    internal sealed partial class PromotedPurchasesSourceGenerationContextChunk1 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PromotedPurchasesSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static PromotedPurchasesSourceGenerationContext Default { get; } = new(DefaultOptions);

        private PromotedPurchasesSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseV2Type)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseV2Type?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsInAppPurchaseLocalizationsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsInAppPurchaseLocalizationsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsPricePointsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsPricePointsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsContentDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsContentDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsAppStoreReviewScreenshotDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsAppStoreReviewScreenshotDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsPromotedPurchaseDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsPromotedPurchaseDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsIapPriceScheduleDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsIapPriceScheduleDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsInAppPurchaseAvailabilityDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsInAppPurchaseAvailabilityDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsImagesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsImagesDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsOfferCodesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsOfferCodesDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsVersionsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsVersionsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.PromotedPurchaseType)

                    || typeToConvert == typeof(global::AppStoreConnect.PromotedPurchaseType?)

                    || typeToConvert == typeof(global::AppStoreConnect.PromotedPurchaseAttributesState)

                    || typeToConvert == typeof(global::AppStoreConnect.PromotedPurchaseAttributesState?)

                    || typeToConvert == typeof(global::AppStoreConnect.PromotedPurchaseRelationshipsInAppPurchaseV2DataType)

                    || typeToConvert == typeof(global::AppStoreConnect.PromotedPurchaseRelationshipsInAppPurchaseV2DataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.PromotedPurchaseRelationshipsSubscriptionDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.PromotedPurchaseRelationshipsSubscriptionDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.PromotedPurchaseResponseIncludedItemDiscriminatorType)

                    || typeToConvert == typeof(global::AppStoreConnect.PromotedPurchaseResponseIncludedItemDiscriminatorType?)

                    || typeToConvert == typeof(global::AppStoreConnect.PromotedPurchaseCreateRequestDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.PromotedPurchaseCreateRequestDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.PromotedPurchaseCreateRequestDataRelationshipsAppDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.PromotedPurchaseCreateRequestDataRelationshipsAppDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.PromotedPurchaseCreateRequestDataRelationshipsInAppPurchaseV2DataType)

                    || typeToConvert == typeof(global::AppStoreConnect.PromotedPurchaseCreateRequestDataRelationshipsInAppPurchaseV2DataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.PromotedPurchaseCreateRequestDataRelationshipsSubscriptionDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.PromotedPurchaseCreateRequestDataRelationshipsSubscriptionDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.PromotedPurchaseUpdateRequestDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.PromotedPurchaseUpdateRequestDataType?)

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

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseState)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseState?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseType2)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseType2?)

                    || typeToConvert == typeof(global::AppStoreConnect.PromotedPurchasesGetInstanceFieldsPromotedPurchase)

                    || typeToConvert == typeof(global::AppStoreConnect.PromotedPurchasesGetInstanceFieldsPromotedPurchase?)

                    || typeToConvert == typeof(global::AppStoreConnect.PromotedPurchasesGetInstanceFieldsInAppPurchase)

                    || typeToConvert == typeof(global::AppStoreConnect.PromotedPurchasesGetInstanceFieldsInAppPurchase?)

                    || typeToConvert == typeof(global::AppStoreConnect.PromotedPurchasesGetInstanceFieldsSubscription)

                    || typeToConvert == typeof(global::AppStoreConnect.PromotedPurchasesGetInstanceFieldsSubscription?)

                    || typeToConvert == typeof(global::AppStoreConnect.PromotedPurchasesGetInstanceIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.PromotedPurchasesGetInstanceIncludeItem?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseV2Type))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseV2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseV2Type?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseV2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsInAppPurchaseLocalizationsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseV2RelationshipsInAppPurchaseLocalizationsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsInAppPurchaseLocalizationsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseV2RelationshipsInAppPurchaseLocalizationsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsPricePointsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseV2RelationshipsPricePointsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsPricePointsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseV2RelationshipsPricePointsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsContentDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseV2RelationshipsContentDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsContentDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseV2RelationshipsContentDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsAppStoreReviewScreenshotDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseV2RelationshipsAppStoreReviewScreenshotDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsAppStoreReviewScreenshotDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseV2RelationshipsAppStoreReviewScreenshotDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsPromotedPurchaseDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseV2RelationshipsPromotedPurchaseDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsPromotedPurchaseDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseV2RelationshipsPromotedPurchaseDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsIapPriceScheduleDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseV2RelationshipsIapPriceScheduleDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsIapPriceScheduleDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseV2RelationshipsIapPriceScheduleDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsInAppPurchaseAvailabilityDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseV2RelationshipsInAppPurchaseAvailabilityDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsInAppPurchaseAvailabilityDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseV2RelationshipsInAppPurchaseAvailabilityDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsImagesDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseV2RelationshipsImagesDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsImagesDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseV2RelationshipsImagesDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsOfferCodesDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseV2RelationshipsOfferCodesDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsOfferCodesDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseV2RelationshipsOfferCodesDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsVersionsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseV2RelationshipsVersionsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsVersionsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseV2RelationshipsVersionsDataItemTypeNullableJsonConverter();
                }

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

                if (typeToConvert == typeof(global::AppStoreConnect.PromotedPurchaseResponseIncludedItemDiscriminatorType))
                {
                    return new global::AppStoreConnect.JsonConverters.PromotedPurchaseResponseIncludedItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.PromotedPurchaseResponseIncludedItemDiscriminatorType?))
                {
                    return new global::AppStoreConnect.JsonConverters.PromotedPurchaseResponseIncludedItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.PromotedPurchaseCreateRequestDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.PromotedPurchaseCreateRequestDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.PromotedPurchaseCreateRequestDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.PromotedPurchaseCreateRequestDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.PromotedPurchaseCreateRequestDataRelationshipsAppDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.PromotedPurchaseCreateRequestDataRelationshipsAppDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.PromotedPurchaseCreateRequestDataRelationshipsAppDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.PromotedPurchaseCreateRequestDataRelationshipsAppDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.PromotedPurchaseCreateRequestDataRelationshipsInAppPurchaseV2DataType))
                {
                    return new global::AppStoreConnect.JsonConverters.PromotedPurchaseCreateRequestDataRelationshipsInAppPurchaseV2DataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.PromotedPurchaseCreateRequestDataRelationshipsInAppPurchaseV2DataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.PromotedPurchaseCreateRequestDataRelationshipsInAppPurchaseV2DataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.PromotedPurchaseCreateRequestDataRelationshipsSubscriptionDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.PromotedPurchaseCreateRequestDataRelationshipsSubscriptionDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.PromotedPurchaseCreateRequestDataRelationshipsSubscriptionDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.PromotedPurchaseCreateRequestDataRelationshipsSubscriptionDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.PromotedPurchaseUpdateRequestDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.PromotedPurchaseUpdateRequestDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.PromotedPurchaseUpdateRequestDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.PromotedPurchaseUpdateRequestDataTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseState))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseStateJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseState?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseType2))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseType2JsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseType2?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseType2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.PromotedPurchasesGetInstanceFieldsPromotedPurchase))
                {
                    return new global::AppStoreConnect.JsonConverters.PromotedPurchasesGetInstanceFieldsPromotedPurchaseJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.PromotedPurchasesGetInstanceFieldsPromotedPurchase?))
                {
                    return new global::AppStoreConnect.JsonConverters.PromotedPurchasesGetInstanceFieldsPromotedPurchaseNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.PromotedPurchasesGetInstanceFieldsInAppPurchase))
                {
                    return new global::AppStoreConnect.JsonConverters.PromotedPurchasesGetInstanceFieldsInAppPurchaseJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.PromotedPurchasesGetInstanceFieldsInAppPurchase?))
                {
                    return new global::AppStoreConnect.JsonConverters.PromotedPurchasesGetInstanceFieldsInAppPurchaseNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.PromotedPurchasesGetInstanceFieldsSubscription))
                {
                    return new global::AppStoreConnect.JsonConverters.PromotedPurchasesGetInstanceFieldsSubscriptionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.PromotedPurchasesGetInstanceFieldsSubscription?))
                {
                    return new global::AppStoreConnect.JsonConverters.PromotedPurchasesGetInstanceFieldsSubscriptionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.PromotedPurchasesGetInstanceIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.PromotedPurchasesGetInstanceIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.PromotedPurchasesGetInstanceIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.PromotedPurchasesGetInstanceIncludeItemNullableJsonConverter();
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
                    0 => new PromotedPurchasesSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),

                    1 => new PromotedPurchasesSourceGenerationContextChunk1(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}