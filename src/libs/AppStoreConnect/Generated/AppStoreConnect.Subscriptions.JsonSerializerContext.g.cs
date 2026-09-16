
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.OneOf<global::AppStoreConnect.SubscriptionPromotionalOfferInlineCreate, global::AppStoreConnect.SubscriptionPriceInlineCreate, global::AppStoreConnect.SubscriptionIntroductoryOfferInlineCreate>?), TypeInfoPropertyName = "SubscriptionIntroductoryOfferInlineCreate_9d504bd43e829b66")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.Territory>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.OfferCodeEnvironment), TypeInfoPropertyName = "OfferCodeEnvironment2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionAppStoreReviewScreenshotResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.Subscription>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionAvailability))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionAvailabilityType), TypeInfoPropertyName = "SubscriptionAvailabilityType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionAvailabilityAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionAvailabilityRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionAvailabilityRelationshipsAvailableTerritories))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionAvailabilityRelationshipsAvailableTerritoriesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionAvailabilityRelationshipsAvailableTerritoriesDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionAvailabilityRelationshipsAvailableTerritoriesDataItemType), TypeInfoPropertyName = "SubscriptionAvailabilityRelationshipsAvailableTerritoriesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionAvailabilityResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupLocalizationV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupLocalization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem160), TypeInfoPropertyName = "IncludedItem1602")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem163), TypeInfoPropertyName = "IncludedItem1632")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionImageType), TypeInfoPropertyName = "SubscriptionImageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionImageAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionImageAttributesState), TypeInfoPropertyName = "SubscriptionImageAttributesState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionImageRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionImageRelationshipsSubscription))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionImageRelationshipsSubscriptionData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionImageRelationshipsSubscriptionDataType), TypeInfoPropertyName = "SubscriptionImageRelationshipsSubscriptionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionImagesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionImageV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionImageV2Type), TypeInfoPropertyName = "SubscriptionImageV2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionImageV2Attributes))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionIntroductoryOfferInlineCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionIntroductoryOfferInlineCreateType), TypeInfoPropertyName = "SubscriptionIntroductoryOfferInlineCreateType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionIntroductoryOfferInlineCreateAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionIntroductoryOfferInlineCreateRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionIntroductoryOfferInlineCreateRelationshipsSubscription))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionIntroductoryOfferInlineCreateRelationshipsSubscriptionData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionIntroductoryOfferInlineCreateRelationshipsSubscriptionDataType), TypeInfoPropertyName = "SubscriptionIntroductoryOfferInlineCreateRelationshipsSubscriptionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionIntroductoryOfferInlineCreateRelationshipsTerritory))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionIntroductoryOfferInlineCreateRelationshipsTerritoryData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionIntroductoryOfferInlineCreateRelationshipsTerritoryDataType), TypeInfoPropertyName = "SubscriptionIntroductoryOfferInlineCreateRelationshipsTerritoryDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionIntroductoryOfferInlineCreateRelationshipsSubscriptionPricePoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionIntroductoryOfferInlineCreateRelationshipsSubscriptionPricePointData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionIntroductoryOfferInlineCreateRelationshipsSubscriptionPricePointDataType), TypeInfoPropertyName = "SubscriptionIntroductoryOfferInlineCreateRelationshipsSubscriptionPricePointDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionIntroductoryOffersResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionIntroductoryOffer>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.IncludedItem164>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem164), TypeInfoPropertyName = "IncludedItem1642")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPricePoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionIntroductoryOffersResponseIncludedItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionIntroductoryOffersResponseIncludedItemDiscriminatorType), TypeInfoPropertyName = "SubscriptionIntroductoryOffersResponseIncludedItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem165), TypeInfoPropertyName = "IncludedItem1652")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionLocalizationV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionLocalizationV2Type), TypeInfoPropertyName = "SubscriptionLocalizationV2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionLocalizationV2Attributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionLocalizationV2Relationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionLocalizationV2RelationshipsVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionLocalizationV2RelationshipsVersionData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionLocalizationV2RelationshipsVersionDataType), TypeInfoPropertyName = "SubscriptionLocalizationV2RelationshipsVersionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionLocalization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionLocalizationType), TypeInfoPropertyName = "SubscriptionLocalizationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionLocalizationAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionLocalizationAttributesState), TypeInfoPropertyName = "SubscriptionLocalizationAttributesState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionLocalizationRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionLocalizationRelationshipsSubscription))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionLocalizationRelationshipsSubscriptionData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionLocalizationRelationshipsSubscriptionDataType), TypeInfoPropertyName = "SubscriptionLocalizationRelationshipsSubscriptionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionLocalizationsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionLocalization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionOfferCodeCustomCode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionOfferCodeCustomCodeType), TypeInfoPropertyName = "SubscriptionOfferCodeCustomCodeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionOfferCodeCustomCodeAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionOfferCodeCustomCodeRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionOfferCodeCustomCodeRelationshipsOfferCode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionOfferCodeCustomCodeRelationshipsOfferCodeData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionOfferCodeCustomCodeRelationshipsOfferCodeDataType), TypeInfoPropertyName = "SubscriptionOfferCodeCustomCodeRelationshipsOfferCodeDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionOfferCode>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionOfferCode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionOfferCodeOneTimeUseCode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionOfferCodeOneTimeUseCodeType), TypeInfoPropertyName = "SubscriptionOfferCodeOneTimeUseCodeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionOfferCodeOneTimeUseCodeAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionOfferCodeOneTimeUseCodeRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionOfferCodeOneTimeUseCodeRelationshipsOfferCode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionOfferCodeOneTimeUseCodeRelationshipsOfferCodeData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionOfferCodeOneTimeUseCodeRelationshipsOfferCodeDataType), TypeInfoPropertyName = "SubscriptionOfferCodeOneTimeUseCodeRelationshipsOfferCodeDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionOfferCodeOneTimeUseCodeRelationshipsValues))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionOfferCodePrice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionOfferCodePriceType), TypeInfoPropertyName = "SubscriptionOfferCodePriceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionOfferCodePriceRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionOfferCodePriceRelationshipsTerritory))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionOfferCodePriceRelationshipsTerritoryData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionOfferCodePriceRelationshipsTerritoryDataType), TypeInfoPropertyName = "SubscriptionOfferCodePriceRelationshipsTerritoryDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionOfferCodePriceRelationshipsSubscriptionPricePoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionOfferCodePriceRelationshipsSubscriptionPricePointData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionOfferCodePriceRelationshipsSubscriptionPricePointDataType), TypeInfoPropertyName = "SubscriptionOfferCodePriceRelationshipsSubscriptionPricePointDataType2")]
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
    internal sealed partial class SubscriptionsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.OneOf<global::AppStoreConnect.SubscriptionPromotionalOfferInlineCreate, global::AppStoreConnect.SubscriptionPriceInlineCreate, global::AppStoreConnect.SubscriptionIntroductoryOfferInlineCreate>?), TypeInfoPropertyName = "SubscriptionIntroductoryOfferInlineCreate_9d504bd43e829b66")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionOfferCodeRelationshipsOneTimeUseCodesDataItemType), TypeInfoPropertyName = "SubscriptionOfferCodeRelationshipsOneTimeUseCodesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionOfferCodeRelationshipsCustomCodes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionOfferCodeRelationshipsCustomCodesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionOfferCodeRelationshipsCustomCodesDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionOfferCodeRelationshipsCustomCodesDataItemType), TypeInfoPropertyName = "SubscriptionOfferCodeRelationshipsCustomCodesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionOfferCodeRelationshipsPrices))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionOfferCodeRelationshipsPricesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionOfferCodeRelationshipsPricesDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionOfferCodeRelationshipsPricesDataItemType), TypeInfoPropertyName = "SubscriptionOfferCodeRelationshipsPricesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionOfferCodesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.IncludedItem167>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem167), TypeInfoPropertyName = "IncludedItem1672")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionOfferCodesResponseIncludedItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionOfferCodesResponseIncludedItemDiscriminatorType), TypeInfoPropertyName = "SubscriptionOfferCodesResponseIncludedItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem168), TypeInfoPropertyName = "IncludedItem1682")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPlanAvailability))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPlanAvailabilityType), TypeInfoPropertyName = "SubscriptionPlanAvailabilityType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPlanAvailabilityAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPlanAvailabilityRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPlanAvailabilityRelationshipsAvailableTerritories))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionPlanAvailabilityRelationshipsAvailableTerritoriesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPlanAvailabilityRelationshipsAvailableTerritoriesDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPlanAvailabilityRelationshipsAvailableTerritoriesDataItemType), TypeInfoPropertyName = "SubscriptionPlanAvailabilityRelationshipsAvailableTerritoriesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPlanAvailabilitiesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionPlanAvailability>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPricePointType), TypeInfoPropertyName = "SubscriptionPricePointType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPricePointAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPricePointRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPricePointRelationshipsTerritory))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPricePointRelationshipsTerritoryData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPricePointRelationshipsTerritoryDataType), TypeInfoPropertyName = "SubscriptionPricePointRelationshipsTerritoryDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPricePointRelationshipsEqualizations))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPricePointRelationshipsAdjustedEqualizations))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPricePointsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionPricePoint>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPriceInlineCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPriceInlineCreateType), TypeInfoPropertyName = "SubscriptionPriceInlineCreateType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPriceInlineCreateAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPriceInlineCreateRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPriceInlineCreateRelationshipsSubscription))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPriceInlineCreateRelationshipsSubscriptionData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPriceInlineCreateRelationshipsSubscriptionDataType), TypeInfoPropertyName = "SubscriptionPriceInlineCreateRelationshipsSubscriptionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPriceInlineCreateRelationshipsTerritory))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPriceInlineCreateRelationshipsTerritoryData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPriceInlineCreateRelationshipsTerritoryDataType), TypeInfoPropertyName = "SubscriptionPriceInlineCreateRelationshipsTerritoryDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPriceInlineCreateRelationshipsSubscriptionPricePoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPriceInlineCreateRelationshipsSubscriptionPricePointData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPriceInlineCreateRelationshipsSubscriptionPricePointDataType), TypeInfoPropertyName = "SubscriptionPriceInlineCreateRelationshipsSubscriptionPricePointDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPricesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionPrice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.IncludedItem169>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem169), TypeInfoPropertyName = "IncludedItem1692")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPricesResponseIncludedItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPricesResponseIncludedItemDiscriminatorType), TypeInfoPropertyName = "SubscriptionPricesResponseIncludedItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem170), TypeInfoPropertyName = "IncludedItem1702")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPromotionalOfferPrice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPromotionalOfferPriceType), TypeInfoPropertyName = "SubscriptionPromotionalOfferPriceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPromotionalOfferPriceRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPromotionalOfferPriceRelationshipsTerritory))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPromotionalOfferPriceRelationshipsTerritoryData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPromotionalOfferPriceRelationshipsTerritoryDataType), TypeInfoPropertyName = "SubscriptionPromotionalOfferPriceRelationshipsTerritoryDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPromotionalOfferPriceRelationshipsSubscriptionPricePoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPromotionalOfferPriceRelationshipsSubscriptionPricePointData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPromotionalOfferPriceRelationshipsSubscriptionPricePointDataType), TypeInfoPropertyName = "SubscriptionPromotionalOfferPriceRelationshipsSubscriptionPricePointDataType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPromotionalOfferInlineCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPromotionalOfferInlineCreateType), TypeInfoPropertyName = "SubscriptionPromotionalOfferInlineCreateType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPromotionalOfferInlineCreateAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPromotionalOfferInlineCreateRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPromotionalOfferInlineCreateRelationshipsSubscription))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPromotionalOfferInlineCreateRelationshipsSubscriptionData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPromotionalOfferInlineCreateRelationshipsSubscriptionDataType), TypeInfoPropertyName = "SubscriptionPromotionalOfferInlineCreateRelationshipsSubscriptionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPromotionalOfferInlineCreateRelationshipsPrices))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionPromotionalOfferInlineCreateRelationshipsPricesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPromotionalOfferInlineCreateRelationshipsPricesDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPromotionalOfferInlineCreateRelationshipsPricesDataItemType), TypeInfoPropertyName = "SubscriptionPromotionalOfferInlineCreateRelationshipsPricesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPromotionalOffersResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionPromotionalOffer>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.IncludedItem172>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem172), TypeInfoPropertyName = "IncludedItem1722")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPromotionalOffersResponseIncludedItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPromotionalOffersResponseIncludedItemDiscriminatorType), TypeInfoPropertyName = "SubscriptionPromotionalOffersResponseIncludedItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem173), TypeInfoPropertyName = "IncludedItem1732")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionVersionType), TypeInfoPropertyName = "SubscriptionVersionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionVersionAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionVersionAttributesState), TypeInfoPropertyName = "SubscriptionVersionAttributesState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionVersionRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionVersionRelationshipsSubscription))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionVersionRelationshipsSubscriptionData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionVersionRelationshipsSubscriptionDataType), TypeInfoPropertyName = "SubscriptionVersionRelationshipsSubscriptionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionVersionRelationshipsImage))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionVersionsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.IncludedItem174>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem174), TypeInfoPropertyName = "IncludedItem1742")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionVersionsResponseIncludedItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionVersionsResponseIncludedItemDiscriminatorType), TypeInfoPropertyName = "SubscriptionVersionsResponseIncludedItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem175), TypeInfoPropertyName = "IncludedItem1752")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionType), TypeInfoPropertyName = "SubscriptionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionAttributesState), TypeInfoPropertyName = "SubscriptionAttributesState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionAttributesSubscriptionPeriod), TypeInfoPropertyName = "SubscriptionAttributesSubscriptionPeriod2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.IncludedItem177>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem177), TypeInfoPropertyName = "IncludedItem1772")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionResponseIncludedItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionResponseIncludedItemDiscriminatorType), TypeInfoPropertyName = "SubscriptionResponseIncludedItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionCreateRequestData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionCreateRequestDataType), TypeInfoPropertyName = "SubscriptionCreateRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionCreateRequestDataAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionCreateRequestDataAttributesSubscriptionPeriod), TypeInfoPropertyName = "SubscriptionCreateRequestDataAttributesSubscriptionPeriod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionCreateRequestDataRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionCreateRequestDataRelationshipsGroup))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionCreateRequestDataRelationshipsGroupData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionCreateRequestDataRelationshipsGroupDataType), TypeInfoPropertyName = "SubscriptionCreateRequestDataRelationshipsGroupDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionUpdateRequestData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionUpdateRequestDataType), TypeInfoPropertyName = "SubscriptionUpdateRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionUpdateRequestDataAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionUpdateRequestDataAttributesSubscriptionPeriod), TypeInfoPropertyName = "SubscriptionUpdateRequestDataAttributesSubscriptionPeriod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionUpdateRequestDataRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionUpdateRequestDataRelationshipsIntroductoryOffers))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionUpdateRequestDataRelationshipsIntroductoryOffersDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionUpdateRequestDataRelationshipsIntroductoryOffersDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionUpdateRequestDataRelationshipsIntroductoryOffersDataItemType), TypeInfoPropertyName = "SubscriptionUpdateRequestDataRelationshipsIntroductoryOffersDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionUpdateRequestDataRelationshipsPromotionalOffers))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionUpdateRequestDataRelationshipsPromotionalOffersDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionUpdateRequestDataRelationshipsPromotionalOffersDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionUpdateRequestDataRelationshipsPromotionalOffersDataItemType), TypeInfoPropertyName = "SubscriptionUpdateRequestDataRelationshipsPromotionalOffersDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionUpdateRequestDataRelationshipsPrices))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionUpdateRequestDataRelationshipsPricesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionUpdateRequestDataRelationshipsPricesDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionUpdateRequestDataRelationshipsPricesDataItemType), TypeInfoPropertyName = "SubscriptionUpdateRequestDataRelationshipsPricesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.OneOf<global::AppStoreConnect.SubscriptionPromotionalOfferInlineCreate, global::AppStoreConnect.SubscriptionPriceInlineCreate, global::AppStoreConnect.SubscriptionIntroductoryOfferInlineCreate>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.OneOf<global::AppStoreConnect.SubscriptionPromotionalOfferInlineCreate, global::AppStoreConnect.SubscriptionPriceInlineCreate, global::AppStoreConnect.SubscriptionIntroductoryOfferInlineCreate>), TypeInfoPropertyName = "OneOfSubscriptionPromotionalOfferInlineCreateSubscriptionPriceInlineCreateSubscriptionIntroductoryOfferInlineCreate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.TerritoryType), TypeInfoPropertyName = "TerritoryType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.TerritoryAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.WinBackOfferPrice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.WinBackOfferPriceType), TypeInfoPropertyName = "WinBackOfferPriceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.WinBackOfferPriceRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.WinBackOfferPriceRelationshipsTerritory))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.WinBackOfferPriceRelationshipsTerritoryData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.WinBackOfferPriceRelationshipsTerritoryDataType), TypeInfoPropertyName = "WinBackOfferPriceRelationshipsTerritoryDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.WinBackOfferPriceRelationshipsSubscriptionPricePoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.WinBackOfferPriceRelationshipsSubscriptionPricePointData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.WinBackOfferPriceRelationshipsSubscriptionPricePointDataType), TypeInfoPropertyName = "WinBackOfferPriceRelationshipsSubscriptionPricePointDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.WinBackOfferPrice>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.WinBackOffersResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.WinBackOffer>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionAppStoreReviewScreenshotLinkageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionAppStoreReviewScreenshotLinkageResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionAppStoreReviewScreenshotLinkageResponseDataType), TypeInfoPropertyName = "SubscriptionAppStoreReviewScreenshotLinkageResponseDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionImagesLinkagesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionImagesLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionImagesLinkagesResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionImagesLinkagesResponseDataItemType), TypeInfoPropertyName = "SubscriptionImagesLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionIntroductoryOffersLinkagesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionIntroductoryOffersLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionIntroductoryOffersLinkagesResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionIntroductoryOffersLinkagesResponseDataItemType), TypeInfoPropertyName = "SubscriptionIntroductoryOffersLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionIntroductoryOffersLinkagesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionIntroductoryOffersLinkagesRequestDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionIntroductoryOffersLinkagesRequestDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionIntroductoryOffersLinkagesRequestDataItemType), TypeInfoPropertyName = "SubscriptionIntroductoryOffersLinkagesRequestDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionOfferCodesLinkagesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionOfferCodesLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionOfferCodesLinkagesResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionOfferCodesLinkagesResponseDataItemType), TypeInfoPropertyName = "SubscriptionOfferCodesLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPlanAvailabilitiesLinkagesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionPlanAvailabilitiesLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPlanAvailabilitiesLinkagesResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPlanAvailabilitiesLinkagesResponseDataItemType), TypeInfoPropertyName = "SubscriptionPlanAvailabilitiesLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPricePointsLinkagesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionPricePointsLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPricePointsLinkagesResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPricePointsLinkagesResponseDataItemType), TypeInfoPropertyName = "SubscriptionPricePointsLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPricesLinkagesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionPricesLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPricesLinkagesResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPricesLinkagesResponseDataItemType), TypeInfoPropertyName = "SubscriptionPricesLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPricesLinkagesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionPricesLinkagesRequestDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPricesLinkagesRequestDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPricesLinkagesRequestDataItemType), TypeInfoPropertyName = "SubscriptionPricesLinkagesRequestDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPromotedPurchaseLinkageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPromotedPurchaseLinkageResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPromotedPurchaseLinkageResponseDataType), TypeInfoPropertyName = "SubscriptionPromotedPurchaseLinkageResponseDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPromotionalOffersLinkagesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionPromotionalOffersLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPromotionalOffersLinkagesResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPromotionalOffersLinkagesResponseDataItemType), TypeInfoPropertyName = "SubscriptionPromotionalOffersLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionSubscriptionAvailabilityLinkageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionSubscriptionAvailabilityLinkageResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionSubscriptionAvailabilityLinkageResponseDataType), TypeInfoPropertyName = "SubscriptionSubscriptionAvailabilityLinkageResponseDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionSubscriptionLocalizationsLinkagesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionSubscriptionLocalizationsLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionSubscriptionLocalizationsLinkagesResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionSubscriptionLocalizationsLinkagesResponseDataItemType), TypeInfoPropertyName = "SubscriptionSubscriptionLocalizationsLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionVersionsLinkagesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionVersionsLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionVersionsLinkagesResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionVersionsLinkagesResponseDataItemType), TypeInfoPropertyName = "SubscriptionVersionsLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionWinBackOffersLinkagesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionWinBackOffersLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionWinBackOffersLinkagesResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionWinBackOffersLinkagesResponseDataItemType), TypeInfoPropertyName = "SubscriptionWinBackOffersLinkagesResponseDataItemType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscription>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscription), TypeInfoPropertyName = "SubscriptionsGetInstanceFieldsSubscription2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionLocalization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionLocalization), TypeInfoPropertyName = "SubscriptionsGetInstanceFieldsSubscriptionLocalization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionAppStoreReviewScreenshot>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionAppStoreReviewScreenshot), TypeInfoPropertyName = "SubscriptionsGetInstanceFieldsSubscriptionAppStoreReviewScreenshot2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionGroup), TypeInfoPropertyName = "SubscriptionsGetInstanceFieldsSubscriptionGroup2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionIntroductoryOffer>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionIntroductoryOffer), TypeInfoPropertyName = "SubscriptionsGetInstanceFieldsSubscriptionIntroductoryOffer2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionPromotionalOffer>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionPromotionalOffer), TypeInfoPropertyName = "SubscriptionsGetInstanceFieldsSubscriptionPromotionalOffer2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionOfferCode>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionOfferCode), TypeInfoPropertyName = "SubscriptionsGetInstanceFieldsSubscriptionOfferCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionPrice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionPrice), TypeInfoPropertyName = "SubscriptionsGetInstanceFieldsSubscriptionPrice2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsGetInstanceFieldsPromotedPurchase>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsPromotedPurchase), TypeInfoPropertyName = "SubscriptionsGetInstanceFieldsPromotedPurchase2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionAvailabilitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionAvailabilitie), TypeInfoPropertyName = "SubscriptionsGetInstanceFieldsSubscriptionAvailabilitie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsGetInstanceFieldsWinBackOffer>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsWinBackOffer), TypeInfoPropertyName = "SubscriptionsGetInstanceFieldsWinBackOffer2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionImage), TypeInfoPropertyName = "SubscriptionsGetInstanceFieldsSubscriptionImage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionPlanAvailabilitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionPlanAvailabilitie), TypeInfoPropertyName = "SubscriptionsGetInstanceFieldsSubscriptionPlanAvailabilitie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionVersion), TypeInfoPropertyName = "SubscriptionsGetInstanceFieldsSubscriptionVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsGetInstanceIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsGetInstanceIncludeItem), TypeInfoPropertyName = "SubscriptionsGetInstanceIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsAppStoreReviewScreenshotGetToOneRelatedFieldsSubscriptionAppStoreReviewScreenshot>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsAppStoreReviewScreenshotGetToOneRelatedFieldsSubscriptionAppStoreReviewScreenshot), TypeInfoPropertyName = "SubscriptionsAppStoreReviewScreenshotGetToOneRelatedFieldsSubscriptionAppStoreReviewScreenshot2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsAppStoreReviewScreenshotGetToOneRelatedFieldsSubscription>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsAppStoreReviewScreenshotGetToOneRelatedFieldsSubscription), TypeInfoPropertyName = "SubscriptionsAppStoreReviewScreenshotGetToOneRelatedFieldsSubscription2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsAppStoreReviewScreenshotGetToOneRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsAppStoreReviewScreenshotGetToOneRelatedIncludeItem), TypeInfoPropertyName = "SubscriptionsAppStoreReviewScreenshotGetToOneRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsImagesGetToManyRelatedFieldsSubscriptionImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsImagesGetToManyRelatedFieldsSubscriptionImage), TypeInfoPropertyName = "SubscriptionsImagesGetToManyRelatedFieldsSubscriptionImage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsImagesGetToManyRelatedFieldsSubscription>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsImagesGetToManyRelatedFieldsSubscription), TypeInfoPropertyName = "SubscriptionsImagesGetToManyRelatedFieldsSubscription2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsImagesGetToManyRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsImagesGetToManyRelatedIncludeItem), TypeInfoPropertyName = "SubscriptionsImagesGetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscriptionIntroductoryOffer>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscriptionIntroductoryOffer), TypeInfoPropertyName = "SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscriptionIntroductoryOffer2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscription>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscription), TypeInfoPropertyName = "SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscription2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsIntroductoryOffersGetToManyRelatedFieldsTerritorie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsIntroductoryOffersGetToManyRelatedFieldsTerritorie), TypeInfoPropertyName = "SubscriptionsIntroductoryOffersGetToManyRelatedFieldsTerritorie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscriptionPricePoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscriptionPricePoint), TypeInfoPropertyName = "SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscriptionPricePoint2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsIntroductoryOffersGetToManyRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsIntroductoryOffersGetToManyRelatedIncludeItem), TypeInfoPropertyName = "SubscriptionsIntroductoryOffersGetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCode>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCode), TypeInfoPropertyName = "SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsOfferCodesGetToManyRelatedFieldsSubscription>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsOfferCodesGetToManyRelatedFieldsSubscription), TypeInfoPropertyName = "SubscriptionsOfferCodesGetToManyRelatedFieldsSubscription2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCodeOneTimeUseCode>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCodeOneTimeUseCode), TypeInfoPropertyName = "SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCodeOneTimeUseCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCodeCustomCode>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCodeCustomCode), TypeInfoPropertyName = "SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCodeCustomCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCodePrice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCodePrice), TypeInfoPropertyName = "SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCodePrice2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsOfferCodesGetToManyRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsOfferCodesGetToManyRelatedIncludeItem), TypeInfoPropertyName = "SubscriptionsOfferCodesGetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsPlanAvailabilitiesGetToManyRelatedFieldsSubscriptionPlanAvailabilitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsPlanAvailabilitiesGetToManyRelatedFieldsSubscriptionPlanAvailabilitie), TypeInfoPropertyName = "SubscriptionsPlanAvailabilitiesGetToManyRelatedFieldsSubscriptionPlanAvailabilitie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsPlanAvailabilitiesGetToManyRelatedFieldsTerritorie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsPlanAvailabilitiesGetToManyRelatedFieldsTerritorie), TypeInfoPropertyName = "SubscriptionsPlanAvailabilitiesGetToManyRelatedFieldsTerritorie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsPlanAvailabilitiesGetToManyRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsPlanAvailabilitiesGetToManyRelatedIncludeItem), TypeInfoPropertyName = "SubscriptionsPlanAvailabilitiesGetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsPricePointsGetToManyRelatedFieldsSubscriptionPricePoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsPricePointsGetToManyRelatedFieldsSubscriptionPricePoint), TypeInfoPropertyName = "SubscriptionsPricePointsGetToManyRelatedFieldsSubscriptionPricePoint2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsPricePointsGetToManyRelatedFieldsTerritorie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsPricePointsGetToManyRelatedFieldsTerritorie), TypeInfoPropertyName = "SubscriptionsPricePointsGetToManyRelatedFieldsTerritorie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsPricePointsGetToManyRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsPricePointsGetToManyRelatedIncludeItem), TypeInfoPropertyName = "SubscriptionsPricePointsGetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsPricesGetToManyRelatedFilterPlanTypeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsPricesGetToManyRelatedFilterPlanTypeItem), TypeInfoPropertyName = "SubscriptionsPricesGetToManyRelatedFilterPlanTypeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsPricesGetToManyRelatedFieldsSubscriptionPrice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsPricesGetToManyRelatedFieldsSubscriptionPrice), TypeInfoPropertyName = "SubscriptionsPricesGetToManyRelatedFieldsSubscriptionPrice2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsPricesGetToManyRelatedFieldsTerritorie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsPricesGetToManyRelatedFieldsTerritorie), TypeInfoPropertyName = "SubscriptionsPricesGetToManyRelatedFieldsTerritorie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsPricesGetToManyRelatedFieldsSubscriptionPricePoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsPricesGetToManyRelatedFieldsSubscriptionPricePoint), TypeInfoPropertyName = "SubscriptionsPricesGetToManyRelatedFieldsSubscriptionPricePoint2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsPricesGetToManyRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsPricesGetToManyRelatedIncludeItem), TypeInfoPropertyName = "SubscriptionsPricesGetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsPromotedPurchaseGetToOneRelatedFieldsPromotedPurchase>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsPromotedPurchaseGetToOneRelatedFieldsPromotedPurchase), TypeInfoPropertyName = "SubscriptionsPromotedPurchaseGetToOneRelatedFieldsPromotedPurchase2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsPromotedPurchaseGetToOneRelatedFieldsInAppPurchase>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsPromotedPurchaseGetToOneRelatedFieldsInAppPurchase), TypeInfoPropertyName = "SubscriptionsPromotedPurchaseGetToOneRelatedFieldsInAppPurchase2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsPromotedPurchaseGetToOneRelatedFieldsSubscription>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsPromotedPurchaseGetToOneRelatedFieldsSubscription), TypeInfoPropertyName = "SubscriptionsPromotedPurchaseGetToOneRelatedFieldsSubscription2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsPromotedPurchaseGetToOneRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsPromotedPurchaseGetToOneRelatedIncludeItem), TypeInfoPropertyName = "SubscriptionsPromotedPurchaseGetToOneRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsPromotionalOffersGetToManyRelatedFieldsSubscriptionPromotionalOffer>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsPromotionalOffersGetToManyRelatedFieldsSubscriptionPromotionalOffer), TypeInfoPropertyName = "SubscriptionsPromotionalOffersGetToManyRelatedFieldsSubscriptionPromotionalOffer2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsPromotionalOffersGetToManyRelatedFieldsSubscription>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsPromotionalOffersGetToManyRelatedFieldsSubscription), TypeInfoPropertyName = "SubscriptionsPromotionalOffersGetToManyRelatedFieldsSubscription2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsPromotionalOffersGetToManyRelatedFieldsSubscriptionPromotionalOfferPrice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsPromotionalOffersGetToManyRelatedFieldsSubscriptionPromotionalOfferPrice), TypeInfoPropertyName = "SubscriptionsPromotionalOffersGetToManyRelatedFieldsSubscriptionPromotionalOfferPrice2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsPromotionalOffersGetToManyRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsPromotionalOffersGetToManyRelatedIncludeItem), TypeInfoPropertyName = "SubscriptionsPromotionalOffersGetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsSubscriptionAvailabilityGetToOneRelatedFieldsSubscriptionAvailabilitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsSubscriptionAvailabilityGetToOneRelatedFieldsSubscriptionAvailabilitie), TypeInfoPropertyName = "SubscriptionsSubscriptionAvailabilityGetToOneRelatedFieldsSubscriptionAvailabilitie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsSubscriptionAvailabilityGetToOneRelatedFieldsTerritorie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsSubscriptionAvailabilityGetToOneRelatedFieldsTerritorie), TypeInfoPropertyName = "SubscriptionsSubscriptionAvailabilityGetToOneRelatedFieldsTerritorie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsSubscriptionAvailabilityGetToOneRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsSubscriptionAvailabilityGetToOneRelatedIncludeItem), TypeInfoPropertyName = "SubscriptionsSubscriptionAvailabilityGetToOneRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsSubscriptionLocalizationsGetToManyRelatedFieldsSubscriptionLocalization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsSubscriptionLocalizationsGetToManyRelatedFieldsSubscriptionLocalization), TypeInfoPropertyName = "SubscriptionsSubscriptionLocalizationsGetToManyRelatedFieldsSubscriptionLocalization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsSubscriptionLocalizationsGetToManyRelatedFieldsSubscription>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsSubscriptionLocalizationsGetToManyRelatedFieldsSubscription), TypeInfoPropertyName = "SubscriptionsSubscriptionLocalizationsGetToManyRelatedFieldsSubscription2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsSubscriptionLocalizationsGetToManyRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsSubscriptionLocalizationsGetToManyRelatedIncludeItem), TypeInfoPropertyName = "SubscriptionsSubscriptionLocalizationsGetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsVersionsGetToManyRelatedFilterStateItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsVersionsGetToManyRelatedFilterStateItem), TypeInfoPropertyName = "SubscriptionsVersionsGetToManyRelatedFilterStateItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsVersionsGetToManyRelatedFieldsSubscriptionVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsVersionsGetToManyRelatedFieldsSubscriptionVersion), TypeInfoPropertyName = "SubscriptionsVersionsGetToManyRelatedFieldsSubscriptionVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsVersionsGetToManyRelatedFieldsSubscription>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsVersionsGetToManyRelatedFieldsSubscription), TypeInfoPropertyName = "SubscriptionsVersionsGetToManyRelatedFieldsSubscription2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsVersionsGetToManyRelatedFieldsSubscriptionImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsVersionsGetToManyRelatedFieldsSubscriptionImage), TypeInfoPropertyName = "SubscriptionsVersionsGetToManyRelatedFieldsSubscriptionImage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsVersionsGetToManyRelatedFieldsSubscriptionLocalization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsVersionsGetToManyRelatedFieldsSubscriptionLocalization), TypeInfoPropertyName = "SubscriptionsVersionsGetToManyRelatedFieldsSubscriptionLocalization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsVersionsGetToManyRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsVersionsGetToManyRelatedIncludeItem), TypeInfoPropertyName = "SubscriptionsVersionsGetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsWinBackOffersGetToManyRelatedFieldsWinBackOffer>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsWinBackOffersGetToManyRelatedFieldsWinBackOffer), TypeInfoPropertyName = "SubscriptionsWinBackOffersGetToManyRelatedFieldsWinBackOffer2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsWinBackOffersGetToManyRelatedFieldsWinBackOfferPrice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsWinBackOffersGetToManyRelatedFieldsWinBackOfferPrice), TypeInfoPropertyName = "SubscriptionsWinBackOffersGetToManyRelatedFieldsWinBackOfferPrice2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsWinBackOffersGetToManyRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsWinBackOffersGetToManyRelatedIncludeItem), TypeInfoPropertyName = "SubscriptionsWinBackOffersGetToManyRelatedIncludeItem2")]
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
    internal sealed partial class SubscriptionsSourceGenerationContextChunk1 : global::System.Text.Json.Serialization.JsonSerializerContext
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.OneOf<global::AppStoreConnect.SubscriptionPromotionalOfferInlineCreate, global::AppStoreConnect.SubscriptionPriceInlineCreate, global::AppStoreConnect.SubscriptionIntroductoryOfferInlineCreate>?), TypeInfoPropertyName = "SubscriptionIntroductoryOfferInlineCreate_9d504bd43e829b66")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.OfferCodeEnvironment?), TypeInfoPropertyName = "NullableOfferCodeEnvironment2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem160?), TypeInfoPropertyName = "NullableIncludedItem1602")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem161?), TypeInfoPropertyName = "NullableIncludedItem1612")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupType?), TypeInfoPropertyName = "NullableSubscriptionGroupType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupRelationshipsSubscriptionsDataItemType?), TypeInfoPropertyName = "NullableSubscriptionGroupRelationshipsSubscriptionsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupRelationshipsSubscriptionGroupLocalizationsDataItemType?), TypeInfoPropertyName = "NullableSubscriptionGroupRelationshipsSubscriptionGroupLocalizationsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupRelationshipsVersionsDataItemType?), TypeInfoPropertyName = "NullableSubscriptionGroupRelationshipsVersionsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem162?), TypeInfoPropertyName = "NullableIncludedItem1622")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem163?), TypeInfoPropertyName = "NullableIncludedItem1632")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionImageType?), TypeInfoPropertyName = "NullableSubscriptionImageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionImageAttributesState?), TypeInfoPropertyName = "NullableSubscriptionImageAttributesState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionImageRelationshipsSubscriptionDataType?), TypeInfoPropertyName = "NullableSubscriptionImageRelationshipsSubscriptionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionImageV2Type?), TypeInfoPropertyName = "NullableSubscriptionImageV2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionIntroductoryOfferType?), TypeInfoPropertyName = "NullableSubscriptionIntroductoryOfferType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionOfferDuration?), TypeInfoPropertyName = "NullableSubscriptionOfferDuration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionOfferMode?), TypeInfoPropertyName = "NullableSubscriptionOfferMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPlanType?), TypeInfoPropertyName = "NullableSubscriptionPlanType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionIntroductoryOfferRelationshipsSubscriptionDataType?), TypeInfoPropertyName = "NullableSubscriptionIntroductoryOfferRelationshipsSubscriptionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionIntroductoryOfferRelationshipsTerritoryDataType?), TypeInfoPropertyName = "NullableSubscriptionIntroductoryOfferRelationshipsTerritoryDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionIntroductoryOfferRelationshipsSubscriptionPricePointDataType?), TypeInfoPropertyName = "NullableSubscriptionIntroductoryOfferRelationshipsSubscriptionPricePointDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionIntroductoryOfferInlineCreateType?), TypeInfoPropertyName = "NullableSubscriptionIntroductoryOfferInlineCreateType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionIntroductoryOfferInlineCreateRelationshipsSubscriptionDataType?), TypeInfoPropertyName = "NullableSubscriptionIntroductoryOfferInlineCreateRelationshipsSubscriptionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionIntroductoryOfferInlineCreateRelationshipsTerritoryDataType?), TypeInfoPropertyName = "NullableSubscriptionIntroductoryOfferInlineCreateRelationshipsTerritoryDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionIntroductoryOfferInlineCreateRelationshipsSubscriptionPricePointDataType?), TypeInfoPropertyName = "NullableSubscriptionIntroductoryOfferInlineCreateRelationshipsSubscriptionPricePointDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem164?), TypeInfoPropertyName = "NullableIncludedItem1642")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionIntroductoryOffersResponseIncludedItemDiscriminatorType?), TypeInfoPropertyName = "NullableSubscriptionIntroductoryOffersResponseIncludedItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem165?), TypeInfoPropertyName = "NullableIncludedItem1652")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionLocalizationV2Type?), TypeInfoPropertyName = "NullableSubscriptionLocalizationV2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionLocalizationV2RelationshipsVersionDataType?), TypeInfoPropertyName = "NullableSubscriptionLocalizationV2RelationshipsVersionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionLocalizationType?), TypeInfoPropertyName = "NullableSubscriptionLocalizationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionLocalizationAttributesState?), TypeInfoPropertyName = "NullableSubscriptionLocalizationAttributesState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionLocalizationRelationshipsSubscriptionDataType?), TypeInfoPropertyName = "NullableSubscriptionLocalizationRelationshipsSubscriptionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionOfferCodeCustomCodeType?), TypeInfoPropertyName = "NullableSubscriptionOfferCodeCustomCodeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionOfferCodeCustomCodeRelationshipsOfferCodeDataType?), TypeInfoPropertyName = "NullableSubscriptionOfferCodeCustomCodeRelationshipsOfferCodeDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionOfferCodeOneTimeUseCodeType?), TypeInfoPropertyName = "NullableSubscriptionOfferCodeOneTimeUseCodeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionOfferCodeOneTimeUseCodeRelationshipsOfferCodeDataType?), TypeInfoPropertyName = "NullableSubscriptionOfferCodeOneTimeUseCodeRelationshipsOfferCodeDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionOfferCodePriceType?), TypeInfoPropertyName = "NullableSubscriptionOfferCodePriceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionOfferCodePriceRelationshipsTerritoryDataType?), TypeInfoPropertyName = "NullableSubscriptionOfferCodePriceRelationshipsTerritoryDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionOfferCodePriceRelationshipsSubscriptionPricePointDataType?), TypeInfoPropertyName = "NullableSubscriptionOfferCodePriceRelationshipsSubscriptionPricePointDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem166?), TypeInfoPropertyName = "NullableIncludedItem1662")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionOfferCodeType?), TypeInfoPropertyName = "NullableSubscriptionOfferCodeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionCustomerEligibility?), TypeInfoPropertyName = "NullableSubscriptionCustomerEligibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionOfferEligibility?), TypeInfoPropertyName = "NullableSubscriptionOfferEligibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionOfferCodeRelationshipsSubscriptionDataType?), TypeInfoPropertyName = "NullableSubscriptionOfferCodeRelationshipsSubscriptionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionOfferCodeRelationshipsOneTimeUseCodesDataItemType?), TypeInfoPropertyName = "NullableSubscriptionOfferCodeRelationshipsOneTimeUseCodesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionOfferCodeRelationshipsCustomCodesDataItemType?), TypeInfoPropertyName = "NullableSubscriptionOfferCodeRelationshipsCustomCodesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionOfferCodeRelationshipsPricesDataItemType?), TypeInfoPropertyName = "NullableSubscriptionOfferCodeRelationshipsPricesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem167?), TypeInfoPropertyName = "NullableIncludedItem1672")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionOfferCodesResponseIncludedItemDiscriminatorType?), TypeInfoPropertyName = "NullableSubscriptionOfferCodesResponseIncludedItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem168?), TypeInfoPropertyName = "NullableIncludedItem1682")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPlanAvailabilityType?), TypeInfoPropertyName = "NullableSubscriptionPlanAvailabilityType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPlanAvailabilityRelationshipsAvailableTerritoriesDataItemType?), TypeInfoPropertyName = "NullableSubscriptionPlanAvailabilityRelationshipsAvailableTerritoriesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPricePointType?), TypeInfoPropertyName = "NullableSubscriptionPricePointType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPricePointRelationshipsTerritoryDataType?), TypeInfoPropertyName = "NullableSubscriptionPricePointRelationshipsTerritoryDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPriceType?), TypeInfoPropertyName = "NullableSubscriptionPriceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPriceRelationshipsTerritoryDataType?), TypeInfoPropertyName = "NullableSubscriptionPriceRelationshipsTerritoryDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPriceRelationshipsSubscriptionPricePointDataType?), TypeInfoPropertyName = "NullableSubscriptionPriceRelationshipsSubscriptionPricePointDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPriceInlineCreateType?), TypeInfoPropertyName = "NullableSubscriptionPriceInlineCreateType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPriceInlineCreateRelationshipsSubscriptionDataType?), TypeInfoPropertyName = "NullableSubscriptionPriceInlineCreateRelationshipsSubscriptionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPriceInlineCreateRelationshipsTerritoryDataType?), TypeInfoPropertyName = "NullableSubscriptionPriceInlineCreateRelationshipsTerritoryDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPriceInlineCreateRelationshipsSubscriptionPricePointDataType?), TypeInfoPropertyName = "NullableSubscriptionPriceInlineCreateRelationshipsSubscriptionPricePointDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem169?), TypeInfoPropertyName = "NullableIncludedItem1692")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPricesResponseIncludedItemDiscriminatorType?), TypeInfoPropertyName = "NullableSubscriptionPricesResponseIncludedItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem170?), TypeInfoPropertyName = "NullableIncludedItem1702")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPromotionalOfferPriceType?), TypeInfoPropertyName = "NullableSubscriptionPromotionalOfferPriceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPromotionalOfferPriceRelationshipsTerritoryDataType?), TypeInfoPropertyName = "NullableSubscriptionPromotionalOfferPriceRelationshipsTerritoryDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPromotionalOfferPriceRelationshipsSubscriptionPricePointDataType?), TypeInfoPropertyName = "NullableSubscriptionPromotionalOfferPriceRelationshipsSubscriptionPricePointDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem171?), TypeInfoPropertyName = "NullableIncludedItem1712")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPromotionalOfferType?), TypeInfoPropertyName = "NullableSubscriptionPromotionalOfferType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPromotionalOfferRelationshipsSubscriptionDataType?), TypeInfoPropertyName = "NullableSubscriptionPromotionalOfferRelationshipsSubscriptionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPromotionalOfferRelationshipsPricesDataItemType?), TypeInfoPropertyName = "NullableSubscriptionPromotionalOfferRelationshipsPricesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPromotionalOfferInlineCreateType?), TypeInfoPropertyName = "NullableSubscriptionPromotionalOfferInlineCreateType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPromotionalOfferInlineCreateRelationshipsSubscriptionDataType?), TypeInfoPropertyName = "NullableSubscriptionPromotionalOfferInlineCreateRelationshipsSubscriptionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPromotionalOfferInlineCreateRelationshipsPricesDataItemType?), TypeInfoPropertyName = "NullableSubscriptionPromotionalOfferInlineCreateRelationshipsPricesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem172?), TypeInfoPropertyName = "NullableIncludedItem1722")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPromotionalOffersResponseIncludedItemDiscriminatorType?), TypeInfoPropertyName = "NullableSubscriptionPromotionalOffersResponseIncludedItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem173?), TypeInfoPropertyName = "NullableIncludedItem1732")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionVersionType?), TypeInfoPropertyName = "NullableSubscriptionVersionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionVersionAttributesState?), TypeInfoPropertyName = "NullableSubscriptionVersionAttributesState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionVersionRelationshipsSubscriptionDataType?), TypeInfoPropertyName = "NullableSubscriptionVersionRelationshipsSubscriptionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionVersionRelationshipsImageDataType?), TypeInfoPropertyName = "NullableSubscriptionVersionRelationshipsImageDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionVersionRelationshipsImagesDataItemType?), TypeInfoPropertyName = "NullableSubscriptionVersionRelationshipsImagesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionVersionRelationshipsLocalizationsDataItemType?), TypeInfoPropertyName = "NullableSubscriptionVersionRelationshipsLocalizationsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem174?), TypeInfoPropertyName = "NullableIncludedItem1742")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionVersionsResponseIncludedItemDiscriminatorType?), TypeInfoPropertyName = "NullableSubscriptionVersionsResponseIncludedItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem175?), TypeInfoPropertyName = "NullableIncludedItem1752")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionType?), TypeInfoPropertyName = "NullableSubscriptionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionAttributesState?), TypeInfoPropertyName = "NullableSubscriptionAttributesState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionAttributesSubscriptionPeriod?), TypeInfoPropertyName = "NullableSubscriptionAttributesSubscriptionPeriod2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionResponseIncludedItemDiscriminatorType?), TypeInfoPropertyName = "NullableSubscriptionResponseIncludedItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionCreateRequestDataType?), TypeInfoPropertyName = "NullableSubscriptionCreateRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionCreateRequestDataAttributesSubscriptionPeriod?), TypeInfoPropertyName = "NullableSubscriptionCreateRequestDataAttributesSubscriptionPeriod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionCreateRequestDataRelationshipsGroupDataType?), TypeInfoPropertyName = "NullableSubscriptionCreateRequestDataRelationshipsGroupDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionUpdateRequestDataType?), TypeInfoPropertyName = "NullableSubscriptionUpdateRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionUpdateRequestDataAttributesSubscriptionPeriod?), TypeInfoPropertyName = "NullableSubscriptionUpdateRequestDataAttributesSubscriptionPeriod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionUpdateRequestDataRelationshipsIntroductoryOffersDataItemType?), TypeInfoPropertyName = "NullableSubscriptionUpdateRequestDataRelationshipsIntroductoryOffersDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionUpdateRequestDataRelationshipsPromotionalOffersDataItemType?), TypeInfoPropertyName = "NullableSubscriptionUpdateRequestDataRelationshipsPromotionalOffersDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionUpdateRequestDataRelationshipsPricesDataItemType?), TypeInfoPropertyName = "NullableSubscriptionUpdateRequestDataRelationshipsPricesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.TerritoryType?), TypeInfoPropertyName = "NullableTerritoryType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.WinBackOfferPriceType?), TypeInfoPropertyName = "NullableWinBackOfferPriceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.WinBackOfferPriceRelationshipsTerritoryDataType?), TypeInfoPropertyName = "NullableWinBackOfferPriceRelationshipsTerritoryDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.WinBackOfferPriceRelationshipsSubscriptionPricePointDataType?), TypeInfoPropertyName = "NullableWinBackOfferPriceRelationshipsSubscriptionPricePointDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem179?), TypeInfoPropertyName = "NullableIncludedItem1792")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.WinBackOfferType?), TypeInfoPropertyName = "NullableWinBackOfferType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.WinBackOfferAttributesPriority?), TypeInfoPropertyName = "NullableWinBackOfferAttributesPriority2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.WinBackOfferAttributesPromotionIntent?), TypeInfoPropertyName = "NullableWinBackOfferAttributesPromotionIntent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.WinBackOfferRelationshipsPricesDataItemType?), TypeInfoPropertyName = "NullableWinBackOfferRelationshipsPricesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionAppStoreReviewScreenshotLinkageResponseDataType?), TypeInfoPropertyName = "NullableSubscriptionAppStoreReviewScreenshotLinkageResponseDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionImagesLinkagesResponseDataItemType?), TypeInfoPropertyName = "NullableSubscriptionImagesLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionIntroductoryOffersLinkagesResponseDataItemType?), TypeInfoPropertyName = "NullableSubscriptionIntroductoryOffersLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionIntroductoryOffersLinkagesRequestDataItemType?), TypeInfoPropertyName = "NullableSubscriptionIntroductoryOffersLinkagesRequestDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionOfferCodesLinkagesResponseDataItemType?), TypeInfoPropertyName = "NullableSubscriptionOfferCodesLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPlanAvailabilitiesLinkagesResponseDataItemType?), TypeInfoPropertyName = "NullableSubscriptionPlanAvailabilitiesLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPricePointsLinkagesResponseDataItemType?), TypeInfoPropertyName = "NullableSubscriptionPricePointsLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPricesLinkagesResponseDataItemType?), TypeInfoPropertyName = "NullableSubscriptionPricesLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPricesLinkagesRequestDataItemType?), TypeInfoPropertyName = "NullableSubscriptionPricesLinkagesRequestDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPromotedPurchaseLinkageResponseDataType?), TypeInfoPropertyName = "NullableSubscriptionPromotedPurchaseLinkageResponseDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPromotionalOffersLinkagesResponseDataItemType?), TypeInfoPropertyName = "NullableSubscriptionPromotionalOffersLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionSubscriptionAvailabilityLinkageResponseDataType?), TypeInfoPropertyName = "NullableSubscriptionSubscriptionAvailabilityLinkageResponseDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionSubscriptionLocalizationsLinkagesResponseDataItemType?), TypeInfoPropertyName = "NullableSubscriptionSubscriptionLocalizationsLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionVersionsLinkagesResponseDataItemType?), TypeInfoPropertyName = "NullableSubscriptionVersionsLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionWinBackOffersLinkagesResponseDataItemType?), TypeInfoPropertyName = "NullableSubscriptionWinBackOffersLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.OneOf<global::AppStoreConnect.ErrorSourcePointer, global::AppStoreConnect.ErrorSourceParameter>?), TypeInfoPropertyName = "NullableOneOfErrorSourcePointerErrorSourceParameter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.OneOf<string, global::AppStoreConnect.ErrorLinksAssociated>?), TypeInfoPropertyName = "NullableOneOfStringErrorLinksAssociated2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppMediaAssetStateState?), TypeInfoPropertyName = "NullableAppMediaAssetStateState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscription?), TypeInfoPropertyName = "NullableSubscriptionsGetInstanceFieldsSubscription2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionLocalization?), TypeInfoPropertyName = "NullableSubscriptionsGetInstanceFieldsSubscriptionLocalization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionAppStoreReviewScreenshot?), TypeInfoPropertyName = "NullableSubscriptionsGetInstanceFieldsSubscriptionAppStoreReviewScreenshot2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionGroup?), TypeInfoPropertyName = "NullableSubscriptionsGetInstanceFieldsSubscriptionGroup2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionIntroductoryOffer?), TypeInfoPropertyName = "NullableSubscriptionsGetInstanceFieldsSubscriptionIntroductoryOffer2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionPromotionalOffer?), TypeInfoPropertyName = "NullableSubscriptionsGetInstanceFieldsSubscriptionPromotionalOffer2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionOfferCode?), TypeInfoPropertyName = "NullableSubscriptionsGetInstanceFieldsSubscriptionOfferCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionPrice?), TypeInfoPropertyName = "NullableSubscriptionsGetInstanceFieldsSubscriptionPrice2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsPromotedPurchase?), TypeInfoPropertyName = "NullableSubscriptionsGetInstanceFieldsPromotedPurchase2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionAvailabilitie?), TypeInfoPropertyName = "NullableSubscriptionsGetInstanceFieldsSubscriptionAvailabilitie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsWinBackOffer?), TypeInfoPropertyName = "NullableSubscriptionsGetInstanceFieldsWinBackOffer2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionImage?), TypeInfoPropertyName = "NullableSubscriptionsGetInstanceFieldsSubscriptionImage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionPlanAvailabilitie?), TypeInfoPropertyName = "NullableSubscriptionsGetInstanceFieldsSubscriptionPlanAvailabilitie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionVersion?), TypeInfoPropertyName = "NullableSubscriptionsGetInstanceFieldsSubscriptionVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsGetInstanceIncludeItem?), TypeInfoPropertyName = "NullableSubscriptionsGetInstanceIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsAppStoreReviewScreenshotGetToOneRelatedFieldsSubscriptionAppStoreReviewScreenshot?), TypeInfoPropertyName = "NullableSubscriptionsAppStoreReviewScreenshotGetToOneRelatedFieldsSubscriptionAppStoreReviewScreenshot2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsAppStoreReviewScreenshotGetToOneRelatedFieldsSubscription?), TypeInfoPropertyName = "NullableSubscriptionsAppStoreReviewScreenshotGetToOneRelatedFieldsSubscription2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsAppStoreReviewScreenshotGetToOneRelatedIncludeItem?), TypeInfoPropertyName = "NullableSubscriptionsAppStoreReviewScreenshotGetToOneRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsImagesGetToManyRelatedFieldsSubscriptionImage?), TypeInfoPropertyName = "NullableSubscriptionsImagesGetToManyRelatedFieldsSubscriptionImage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsImagesGetToManyRelatedFieldsSubscription?), TypeInfoPropertyName = "NullableSubscriptionsImagesGetToManyRelatedFieldsSubscription2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsImagesGetToManyRelatedIncludeItem?), TypeInfoPropertyName = "NullableSubscriptionsImagesGetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscriptionIntroductoryOffer?), TypeInfoPropertyName = "NullableSubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscriptionIntroductoryOffer2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscription?), TypeInfoPropertyName = "NullableSubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscription2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsIntroductoryOffersGetToManyRelatedFieldsTerritorie?), TypeInfoPropertyName = "NullableSubscriptionsIntroductoryOffersGetToManyRelatedFieldsTerritorie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscriptionPricePoint?), TypeInfoPropertyName = "NullableSubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscriptionPricePoint2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsIntroductoryOffersGetToManyRelatedIncludeItem?), TypeInfoPropertyName = "NullableSubscriptionsIntroductoryOffersGetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCode?), TypeInfoPropertyName = "NullableSubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsOfferCodesGetToManyRelatedFieldsSubscription?), TypeInfoPropertyName = "NullableSubscriptionsOfferCodesGetToManyRelatedFieldsSubscription2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCodeOneTimeUseCode?), TypeInfoPropertyName = "NullableSubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCodeOneTimeUseCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCodeCustomCode?), TypeInfoPropertyName = "NullableSubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCodeCustomCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCodePrice?), TypeInfoPropertyName = "NullableSubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCodePrice2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsOfferCodesGetToManyRelatedIncludeItem?), TypeInfoPropertyName = "NullableSubscriptionsOfferCodesGetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsPlanAvailabilitiesGetToManyRelatedFieldsSubscriptionPlanAvailabilitie?), TypeInfoPropertyName = "NullableSubscriptionsPlanAvailabilitiesGetToManyRelatedFieldsSubscriptionPlanAvailabilitie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsPlanAvailabilitiesGetToManyRelatedFieldsTerritorie?), TypeInfoPropertyName = "NullableSubscriptionsPlanAvailabilitiesGetToManyRelatedFieldsTerritorie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsPlanAvailabilitiesGetToManyRelatedIncludeItem?), TypeInfoPropertyName = "NullableSubscriptionsPlanAvailabilitiesGetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsPricePointsGetToManyRelatedFieldsSubscriptionPricePoint?), TypeInfoPropertyName = "NullableSubscriptionsPricePointsGetToManyRelatedFieldsSubscriptionPricePoint2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsPricePointsGetToManyRelatedFieldsTerritorie?), TypeInfoPropertyName = "NullableSubscriptionsPricePointsGetToManyRelatedFieldsTerritorie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsPricePointsGetToManyRelatedIncludeItem?), TypeInfoPropertyName = "NullableSubscriptionsPricePointsGetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsPricesGetToManyRelatedFilterPlanTypeItem?), TypeInfoPropertyName = "NullableSubscriptionsPricesGetToManyRelatedFilterPlanTypeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsPricesGetToManyRelatedFieldsSubscriptionPrice?), TypeInfoPropertyName = "NullableSubscriptionsPricesGetToManyRelatedFieldsSubscriptionPrice2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsPricesGetToManyRelatedFieldsTerritorie?), TypeInfoPropertyName = "NullableSubscriptionsPricesGetToManyRelatedFieldsTerritorie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsPricesGetToManyRelatedFieldsSubscriptionPricePoint?), TypeInfoPropertyName = "NullableSubscriptionsPricesGetToManyRelatedFieldsSubscriptionPricePoint2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsPricesGetToManyRelatedIncludeItem?), TypeInfoPropertyName = "NullableSubscriptionsPricesGetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsPromotedPurchaseGetToOneRelatedFieldsPromotedPurchase?), TypeInfoPropertyName = "NullableSubscriptionsPromotedPurchaseGetToOneRelatedFieldsPromotedPurchase2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsPromotedPurchaseGetToOneRelatedFieldsInAppPurchase?), TypeInfoPropertyName = "NullableSubscriptionsPromotedPurchaseGetToOneRelatedFieldsInAppPurchase2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsPromotedPurchaseGetToOneRelatedFieldsSubscription?), TypeInfoPropertyName = "NullableSubscriptionsPromotedPurchaseGetToOneRelatedFieldsSubscription2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsPromotedPurchaseGetToOneRelatedIncludeItem?), TypeInfoPropertyName = "NullableSubscriptionsPromotedPurchaseGetToOneRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsPromotionalOffersGetToManyRelatedFieldsSubscriptionPromotionalOffer?), TypeInfoPropertyName = "NullableSubscriptionsPromotionalOffersGetToManyRelatedFieldsSubscriptionPromotionalOffer2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsPromotionalOffersGetToManyRelatedFieldsSubscription?), TypeInfoPropertyName = "NullableSubscriptionsPromotionalOffersGetToManyRelatedFieldsSubscription2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsPromotionalOffersGetToManyRelatedFieldsSubscriptionPromotionalOfferPrice?), TypeInfoPropertyName = "NullableSubscriptionsPromotionalOffersGetToManyRelatedFieldsSubscriptionPromotionalOfferPrice2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsPromotionalOffersGetToManyRelatedIncludeItem?), TypeInfoPropertyName = "NullableSubscriptionsPromotionalOffersGetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsSubscriptionAvailabilityGetToOneRelatedFieldsSubscriptionAvailabilitie?), TypeInfoPropertyName = "NullableSubscriptionsSubscriptionAvailabilityGetToOneRelatedFieldsSubscriptionAvailabilitie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsSubscriptionAvailabilityGetToOneRelatedFieldsTerritorie?), TypeInfoPropertyName = "NullableSubscriptionsSubscriptionAvailabilityGetToOneRelatedFieldsTerritorie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsSubscriptionAvailabilityGetToOneRelatedIncludeItem?), TypeInfoPropertyName = "NullableSubscriptionsSubscriptionAvailabilityGetToOneRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsSubscriptionLocalizationsGetToManyRelatedFieldsSubscriptionLocalization?), TypeInfoPropertyName = "NullableSubscriptionsSubscriptionLocalizationsGetToManyRelatedFieldsSubscriptionLocalization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsSubscriptionLocalizationsGetToManyRelatedFieldsSubscription?), TypeInfoPropertyName = "NullableSubscriptionsSubscriptionLocalizationsGetToManyRelatedFieldsSubscription2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsSubscriptionLocalizationsGetToManyRelatedIncludeItem?), TypeInfoPropertyName = "NullableSubscriptionsSubscriptionLocalizationsGetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsVersionsGetToManyRelatedFilterStateItem?), TypeInfoPropertyName = "NullableSubscriptionsVersionsGetToManyRelatedFilterStateItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsVersionsGetToManyRelatedFieldsSubscriptionVersion?), TypeInfoPropertyName = "NullableSubscriptionsVersionsGetToManyRelatedFieldsSubscriptionVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsVersionsGetToManyRelatedFieldsSubscription?), TypeInfoPropertyName = "NullableSubscriptionsVersionsGetToManyRelatedFieldsSubscription2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsVersionsGetToManyRelatedFieldsSubscriptionImage?), TypeInfoPropertyName = "NullableSubscriptionsVersionsGetToManyRelatedFieldsSubscriptionImage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsVersionsGetToManyRelatedFieldsSubscriptionLocalization?), TypeInfoPropertyName = "NullableSubscriptionsVersionsGetToManyRelatedFieldsSubscriptionLocalization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsVersionsGetToManyRelatedIncludeItem?), TypeInfoPropertyName = "NullableSubscriptionsVersionsGetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsWinBackOffersGetToManyRelatedFieldsWinBackOffer?), TypeInfoPropertyName = "NullableSubscriptionsWinBackOffersGetToManyRelatedFieldsWinBackOffer2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsWinBackOffersGetToManyRelatedFieldsWinBackOfferPrice?), TypeInfoPropertyName = "NullableSubscriptionsWinBackOffersGetToManyRelatedFieldsWinBackOfferPrice2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionsWinBackOffersGetToManyRelatedIncludeItem?), TypeInfoPropertyName = "NullableSubscriptionsWinBackOffersGetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.UploadOperation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.Territory>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.InAppPurchaseV2RelationshipsInAppPurchaseLocalizationsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.InAppPurchaseV2RelationshipsPricePointsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.InAppPurchaseV2RelationshipsImagesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.InAppPurchaseV2RelationshipsOfferCodesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.InAppPurchaseV2RelationshipsVersionsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.IncludedItem153>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.Subscription>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionAvailabilityRelationshipsAvailableTerritoriesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionGroupRelationshipsSubscriptionsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionGroupRelationshipsSubscriptionGroupLocalizationsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionGroupRelationshipsVersionsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionIntroductoryOffer>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.IncludedItem164>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionLocalization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionOfferCode>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionCustomerEligibility>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionOfferCodeRelationshipsOneTimeUseCodesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionOfferCodeRelationshipsCustomCodesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionOfferCodeRelationshipsPricesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.IncludedItem167>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionPlanAvailabilityRelationshipsAvailableTerritoriesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionPlanAvailability>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionPricePoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionPrice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.IncludedItem169>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionPromotionalOfferRelationshipsPricesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionPromotionalOfferInlineCreateRelationshipsPricesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionPromotionalOffer>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.IncludedItem172>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionVersionRelationshipsImagesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionVersionRelationshipsLocalizationsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.IncludedItem174>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionRelationshipsSubscriptionLocalizationsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionRelationshipsIntroductoryOffersDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionRelationshipsPromotionalOffersDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionRelationshipsOfferCodesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionRelationshipsPricesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionRelationshipsWinBackOffersDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionRelationshipsImagesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionRelationshipsPlanAvailabilitiesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionRelationshipsVersionsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.IncludedItem177>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionUpdateRequestDataRelationshipsIntroductoryOffersDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionUpdateRequestDataRelationshipsPromotionalOffersDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionUpdateRequestDataRelationshipsPricesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.OneOf<global::AppStoreConnect.SubscriptionPromotionalOfferInlineCreate, global::AppStoreConnect.SubscriptionPriceInlineCreate, global::AppStoreConnect.SubscriptionIntroductoryOfferInlineCreate>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.WinBackOfferPrice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.WinBackOfferRelationshipsPricesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.WinBackOffer>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionImagesLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionIntroductoryOffersLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionIntroductoryOffersLinkagesRequestDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionOfferCodesLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionPlanAvailabilitiesLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionPricePointsLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionPricesLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionPricesLinkagesRequestDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionPromotionalOffersLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionSubscriptionLocalizationsLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionVersionsLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionWinBackOffersLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.ErrorResponseError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppMediaStateError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.HttpHeader>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscription>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionLocalization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionAppStoreReviewScreenshot>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionIntroductoryOffer>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionPromotionalOffer>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionOfferCode>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionPrice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionsGetInstanceFieldsPromotedPurchase>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionAvailabilitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionsGetInstanceFieldsWinBackOffer>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionPlanAvailabilitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionsGetInstanceIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionsAppStoreReviewScreenshotGetToOneRelatedFieldsSubscriptionAppStoreReviewScreenshot>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionsAppStoreReviewScreenshotGetToOneRelatedFieldsSubscription>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionsAppStoreReviewScreenshotGetToOneRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionsImagesGetToManyRelatedFieldsSubscriptionImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionsImagesGetToManyRelatedFieldsSubscription>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionsImagesGetToManyRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscriptionIntroductoryOffer>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscription>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionsIntroductoryOffersGetToManyRelatedFieldsTerritorie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscriptionPricePoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionsIntroductoryOffersGetToManyRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCode>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionsOfferCodesGetToManyRelatedFieldsSubscription>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCodeOneTimeUseCode>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCodeCustomCode>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCodePrice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionsOfferCodesGetToManyRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionsPlanAvailabilitiesGetToManyRelatedFieldsSubscriptionPlanAvailabilitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionsPlanAvailabilitiesGetToManyRelatedFieldsTerritorie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionsPlanAvailabilitiesGetToManyRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionsPricePointsGetToManyRelatedFieldsSubscriptionPricePoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionsPricePointsGetToManyRelatedFieldsTerritorie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionsPricePointsGetToManyRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionsPricesGetToManyRelatedFilterPlanTypeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionsPricesGetToManyRelatedFieldsSubscriptionPrice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionsPricesGetToManyRelatedFieldsTerritorie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionsPricesGetToManyRelatedFieldsSubscriptionPricePoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionsPricesGetToManyRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionsPromotedPurchaseGetToOneRelatedFieldsPromotedPurchase>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionsPromotedPurchaseGetToOneRelatedFieldsInAppPurchase>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionsPromotedPurchaseGetToOneRelatedFieldsSubscription>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionsPromotedPurchaseGetToOneRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionsPromotionalOffersGetToManyRelatedFieldsSubscriptionPromotionalOffer>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionsPromotionalOffersGetToManyRelatedFieldsSubscription>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionsPromotionalOffersGetToManyRelatedFieldsSubscriptionPromotionalOfferPrice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionsPromotionalOffersGetToManyRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionsSubscriptionAvailabilityGetToOneRelatedFieldsSubscriptionAvailabilitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionsSubscriptionAvailabilityGetToOneRelatedFieldsTerritorie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionsSubscriptionAvailabilityGetToOneRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionsSubscriptionLocalizationsGetToManyRelatedFieldsSubscriptionLocalization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionsSubscriptionLocalizationsGetToManyRelatedFieldsSubscription>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionsSubscriptionLocalizationsGetToManyRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionsVersionsGetToManyRelatedFilterStateItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionsVersionsGetToManyRelatedFieldsSubscriptionVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionsVersionsGetToManyRelatedFieldsSubscription>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionsVersionsGetToManyRelatedFieldsSubscriptionImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionsVersionsGetToManyRelatedFieldsSubscriptionLocalization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionsVersionsGetToManyRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionsWinBackOffersGetToManyRelatedFieldsWinBackOffer>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionsWinBackOffersGetToManyRelatedFieldsWinBackOfferPrice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionsWinBackOffersGetToManyRelatedIncludeItem>))]
    internal sealed partial class SubscriptionsSourceGenerationContextChunk2 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SubscriptionsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SubscriptionsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private SubscriptionsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.OneOfJsonConverter<global::AppStoreConnect.SubscriptionPromotionalOfferInlineCreate, global::AppStoreConnect.SubscriptionPriceInlineCreate, global::AppStoreConnect.SubscriptionIntroductoryOfferInlineCreate>());
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

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionAppStoreReviewScreenshotType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionAppStoreReviewScreenshotType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionAppStoreReviewScreenshotRelationshipsSubscriptionDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionAppStoreReviewScreenshotRelationshipsSubscriptionDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionAvailabilityType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionAvailabilityType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionAvailabilityRelationshipsAvailableTerritoriesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionAvailabilityRelationshipsAvailableTerritoriesDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupRelationshipsSubscriptionsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupRelationshipsSubscriptionsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupRelationshipsSubscriptionGroupLocalizationsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupRelationshipsSubscriptionGroupLocalizationsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupRelationshipsVersionsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupRelationshipsVersionsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionImageType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionImageType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionImageAttributesState)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionImageAttributesState?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionImageRelationshipsSubscriptionDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionImageRelationshipsSubscriptionDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionImageV2Type)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionImageV2Type?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionIntroductoryOfferType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionIntroductoryOfferType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionIntroductoryOfferRelationshipsSubscriptionDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionIntroductoryOfferRelationshipsSubscriptionDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionIntroductoryOfferRelationshipsTerritoryDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionIntroductoryOfferRelationshipsTerritoryDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionIntroductoryOfferRelationshipsSubscriptionPricePointDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionIntroductoryOfferRelationshipsSubscriptionPricePointDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionIntroductoryOfferInlineCreateType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionIntroductoryOfferInlineCreateType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionIntroductoryOfferInlineCreateRelationshipsSubscriptionDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionIntroductoryOfferInlineCreateRelationshipsSubscriptionDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionIntroductoryOfferInlineCreateRelationshipsTerritoryDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionIntroductoryOfferInlineCreateRelationshipsTerritoryDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionIntroductoryOfferInlineCreateRelationshipsSubscriptionPricePointDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionIntroductoryOfferInlineCreateRelationshipsSubscriptionPricePointDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionIntroductoryOffersResponseIncludedItemDiscriminatorType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionIntroductoryOffersResponseIncludedItemDiscriminatorType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionLocalizationV2Type)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionLocalizationV2Type?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionLocalizationV2RelationshipsVersionDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionLocalizationV2RelationshipsVersionDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionLocalizationType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionLocalizationType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionLocalizationAttributesState)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionLocalizationAttributesState?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionLocalizationRelationshipsSubscriptionDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionLocalizationRelationshipsSubscriptionDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferCodeCustomCodeType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferCodeCustomCodeType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferCodeCustomCodeRelationshipsOfferCodeDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferCodeCustomCodeRelationshipsOfferCodeDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferCodeOneTimeUseCodeType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferCodeOneTimeUseCodeType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferCodeOneTimeUseCodeRelationshipsOfferCodeDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferCodeOneTimeUseCodeRelationshipsOfferCodeDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferCodePriceType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferCodePriceType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferCodePriceRelationshipsTerritoryDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferCodePriceRelationshipsTerritoryDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferCodePriceRelationshipsSubscriptionPricePointDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferCodePriceRelationshipsSubscriptionPricePointDataType?)

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

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferCodesResponseIncludedItemDiscriminatorType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferCodesResponseIncludedItemDiscriminatorType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionPlanAvailabilityType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionPlanAvailabilityType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionPlanAvailabilityRelationshipsAvailableTerritoriesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionPlanAvailabilityRelationshipsAvailableTerritoriesDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionPricePointType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionPricePointType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionPricePointRelationshipsTerritoryDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionPricePointRelationshipsTerritoryDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionPriceType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionPriceType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionPriceRelationshipsTerritoryDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionPriceRelationshipsTerritoryDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionPriceRelationshipsSubscriptionPricePointDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionPriceRelationshipsSubscriptionPricePointDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionPriceInlineCreateType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionPriceInlineCreateType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionPriceInlineCreateRelationshipsSubscriptionDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionPriceInlineCreateRelationshipsSubscriptionDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionPriceInlineCreateRelationshipsTerritoryDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionPriceInlineCreateRelationshipsTerritoryDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionPriceInlineCreateRelationshipsSubscriptionPricePointDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionPriceInlineCreateRelationshipsSubscriptionPricePointDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionPricesResponseIncludedItemDiscriminatorType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionPricesResponseIncludedItemDiscriminatorType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionPromotionalOfferPriceType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionPromotionalOfferPriceType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionPromotionalOfferPriceRelationshipsTerritoryDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionPromotionalOfferPriceRelationshipsTerritoryDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionPromotionalOfferPriceRelationshipsSubscriptionPricePointDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionPromotionalOfferPriceRelationshipsSubscriptionPricePointDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionPromotionalOfferType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionPromotionalOfferType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionPromotionalOfferRelationshipsSubscriptionDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionPromotionalOfferRelationshipsSubscriptionDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionPromotionalOfferRelationshipsPricesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionPromotionalOfferRelationshipsPricesDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionPromotionalOfferInlineCreateType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionPromotionalOfferInlineCreateType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionPromotionalOfferInlineCreateRelationshipsSubscriptionDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionPromotionalOfferInlineCreateRelationshipsSubscriptionDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionPromotionalOfferInlineCreateRelationshipsPricesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionPromotionalOfferInlineCreateRelationshipsPricesDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionPromotionalOffersResponseIncludedItemDiscriminatorType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionPromotionalOffersResponseIncludedItemDiscriminatorType?)

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

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionVersionsResponseIncludedItemDiscriminatorType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionVersionsResponseIncludedItemDiscriminatorType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionAttributesState)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionAttributesState?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionAttributesSubscriptionPeriod)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionAttributesSubscriptionPeriod?)

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

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionResponseIncludedItemDiscriminatorType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionResponseIncludedItemDiscriminatorType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionCreateRequestDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionCreateRequestDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionCreateRequestDataAttributesSubscriptionPeriod)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionCreateRequestDataAttributesSubscriptionPeriod?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionCreateRequestDataRelationshipsGroupDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionCreateRequestDataRelationshipsGroupDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionUpdateRequestDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionUpdateRequestDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionUpdateRequestDataAttributesSubscriptionPeriod)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionUpdateRequestDataAttributesSubscriptionPeriod?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionUpdateRequestDataRelationshipsIntroductoryOffersDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionUpdateRequestDataRelationshipsIntroductoryOffersDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionUpdateRequestDataRelationshipsPromotionalOffersDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionUpdateRequestDataRelationshipsPromotionalOffersDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionUpdateRequestDataRelationshipsPricesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionUpdateRequestDataRelationshipsPricesDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.TerritoryType)

                    || typeToConvert == typeof(global::AppStoreConnect.TerritoryType?)

                    || typeToConvert == typeof(global::AppStoreConnect.WinBackOfferPriceType)

                    || typeToConvert == typeof(global::AppStoreConnect.WinBackOfferPriceType?)

                    || typeToConvert == typeof(global::AppStoreConnect.WinBackOfferPriceRelationshipsTerritoryDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.WinBackOfferPriceRelationshipsTerritoryDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.WinBackOfferPriceRelationshipsSubscriptionPricePointDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.WinBackOfferPriceRelationshipsSubscriptionPricePointDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.WinBackOfferType)

                    || typeToConvert == typeof(global::AppStoreConnect.WinBackOfferType?)

                    || typeToConvert == typeof(global::AppStoreConnect.WinBackOfferAttributesPriority)

                    || typeToConvert == typeof(global::AppStoreConnect.WinBackOfferAttributesPriority?)

                    || typeToConvert == typeof(global::AppStoreConnect.WinBackOfferAttributesPromotionIntent)

                    || typeToConvert == typeof(global::AppStoreConnect.WinBackOfferAttributesPromotionIntent?)

                    || typeToConvert == typeof(global::AppStoreConnect.WinBackOfferRelationshipsPricesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.WinBackOfferRelationshipsPricesDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionAppStoreReviewScreenshotLinkageResponseDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionAppStoreReviewScreenshotLinkageResponseDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionImagesLinkagesResponseDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionImagesLinkagesResponseDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionIntroductoryOffersLinkagesResponseDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionIntroductoryOffersLinkagesResponseDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionIntroductoryOffersLinkagesRequestDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionIntroductoryOffersLinkagesRequestDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferCodesLinkagesResponseDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferCodesLinkagesResponseDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionPlanAvailabilitiesLinkagesResponseDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionPlanAvailabilitiesLinkagesResponseDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionPricePointsLinkagesResponseDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionPricePointsLinkagesResponseDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionPricesLinkagesResponseDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionPricesLinkagesResponseDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionPricesLinkagesRequestDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionPricesLinkagesRequestDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionPromotedPurchaseLinkageResponseDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionPromotedPurchaseLinkageResponseDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionPromotionalOffersLinkagesResponseDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionPromotionalOffersLinkagesResponseDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionSubscriptionAvailabilityLinkageResponseDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionSubscriptionAvailabilityLinkageResponseDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionSubscriptionLocalizationsLinkagesResponseDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionSubscriptionLocalizationsLinkagesResponseDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionVersionsLinkagesResponseDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionVersionsLinkagesResponseDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionWinBackOffersLinkagesResponseDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionWinBackOffersLinkagesResponseDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppMediaAssetStateState)

                    || typeToConvert == typeof(global::AppStoreConnect.AppMediaAssetStateState?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseState)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseState?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseType2)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseType2?)

                    || typeToConvert == typeof(global::AppStoreConnect.OfferCodeEnvironment)

                    || typeToConvert == typeof(global::AppStoreConnect.OfferCodeEnvironment?)

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

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscription)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscription?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionLocalization)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionLocalization?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionAppStoreReviewScreenshot)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionAppStoreReviewScreenshot?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionGroup)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionGroup?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionIntroductoryOffer)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionIntroductoryOffer?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionPromotionalOffer)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionPromotionalOffer?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionOfferCode)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionOfferCode?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionPrice)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionPrice?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsPromotedPurchase)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsPromotedPurchase?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionAvailabilitie)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionAvailabilitie?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsWinBackOffer)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsWinBackOffer?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionImage)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionImage?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionPlanAvailabilitie)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionPlanAvailabilitie?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionVersion)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionVersion?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsGetInstanceIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsGetInstanceIncludeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsAppStoreReviewScreenshotGetToOneRelatedFieldsSubscriptionAppStoreReviewScreenshot)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsAppStoreReviewScreenshotGetToOneRelatedFieldsSubscriptionAppStoreReviewScreenshot?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsAppStoreReviewScreenshotGetToOneRelatedFieldsSubscription)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsAppStoreReviewScreenshotGetToOneRelatedFieldsSubscription?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsAppStoreReviewScreenshotGetToOneRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsAppStoreReviewScreenshotGetToOneRelatedIncludeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsImagesGetToManyRelatedFieldsSubscriptionImage)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsImagesGetToManyRelatedFieldsSubscriptionImage?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsImagesGetToManyRelatedFieldsSubscription)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsImagesGetToManyRelatedFieldsSubscription?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsImagesGetToManyRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsImagesGetToManyRelatedIncludeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscriptionIntroductoryOffer)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscriptionIntroductoryOffer?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscription)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscription?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsIntroductoryOffersGetToManyRelatedFieldsTerritorie)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsIntroductoryOffersGetToManyRelatedFieldsTerritorie?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscriptionPricePoint)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscriptionPricePoint?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsIntroductoryOffersGetToManyRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsIntroductoryOffersGetToManyRelatedIncludeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCode)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCode?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsOfferCodesGetToManyRelatedFieldsSubscription)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsOfferCodesGetToManyRelatedFieldsSubscription?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCodeOneTimeUseCode)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCodeOneTimeUseCode?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCodeCustomCode)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCodeCustomCode?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCodePrice)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCodePrice?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsOfferCodesGetToManyRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsOfferCodesGetToManyRelatedIncludeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsPlanAvailabilitiesGetToManyRelatedFieldsSubscriptionPlanAvailabilitie)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsPlanAvailabilitiesGetToManyRelatedFieldsSubscriptionPlanAvailabilitie?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsPlanAvailabilitiesGetToManyRelatedFieldsTerritorie)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsPlanAvailabilitiesGetToManyRelatedFieldsTerritorie?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsPlanAvailabilitiesGetToManyRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsPlanAvailabilitiesGetToManyRelatedIncludeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsPricePointsGetToManyRelatedFieldsSubscriptionPricePoint)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsPricePointsGetToManyRelatedFieldsSubscriptionPricePoint?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsPricePointsGetToManyRelatedFieldsTerritorie)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsPricePointsGetToManyRelatedFieldsTerritorie?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsPricePointsGetToManyRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsPricePointsGetToManyRelatedIncludeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsPricesGetToManyRelatedFilterPlanTypeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsPricesGetToManyRelatedFilterPlanTypeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsPricesGetToManyRelatedFieldsSubscriptionPrice)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsPricesGetToManyRelatedFieldsSubscriptionPrice?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsPricesGetToManyRelatedFieldsTerritorie)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsPricesGetToManyRelatedFieldsTerritorie?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsPricesGetToManyRelatedFieldsSubscriptionPricePoint)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsPricesGetToManyRelatedFieldsSubscriptionPricePoint?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsPricesGetToManyRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsPricesGetToManyRelatedIncludeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsPromotedPurchaseGetToOneRelatedFieldsPromotedPurchase)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsPromotedPurchaseGetToOneRelatedFieldsPromotedPurchase?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsPromotedPurchaseGetToOneRelatedFieldsInAppPurchase)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsPromotedPurchaseGetToOneRelatedFieldsInAppPurchase?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsPromotedPurchaseGetToOneRelatedFieldsSubscription)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsPromotedPurchaseGetToOneRelatedFieldsSubscription?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsPromotedPurchaseGetToOneRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsPromotedPurchaseGetToOneRelatedIncludeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsPromotionalOffersGetToManyRelatedFieldsSubscriptionPromotionalOffer)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsPromotionalOffersGetToManyRelatedFieldsSubscriptionPromotionalOffer?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsPromotionalOffersGetToManyRelatedFieldsSubscription)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsPromotionalOffersGetToManyRelatedFieldsSubscription?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsPromotionalOffersGetToManyRelatedFieldsSubscriptionPromotionalOfferPrice)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsPromotionalOffersGetToManyRelatedFieldsSubscriptionPromotionalOfferPrice?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsPromotionalOffersGetToManyRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsPromotionalOffersGetToManyRelatedIncludeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsSubscriptionAvailabilityGetToOneRelatedFieldsSubscriptionAvailabilitie)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsSubscriptionAvailabilityGetToOneRelatedFieldsSubscriptionAvailabilitie?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsSubscriptionAvailabilityGetToOneRelatedFieldsTerritorie)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsSubscriptionAvailabilityGetToOneRelatedFieldsTerritorie?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsSubscriptionAvailabilityGetToOneRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsSubscriptionAvailabilityGetToOneRelatedIncludeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsSubscriptionLocalizationsGetToManyRelatedFieldsSubscriptionLocalization)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsSubscriptionLocalizationsGetToManyRelatedFieldsSubscriptionLocalization?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsSubscriptionLocalizationsGetToManyRelatedFieldsSubscription)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsSubscriptionLocalizationsGetToManyRelatedFieldsSubscription?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsSubscriptionLocalizationsGetToManyRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsSubscriptionLocalizationsGetToManyRelatedIncludeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsVersionsGetToManyRelatedFilterStateItem)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsVersionsGetToManyRelatedFilterStateItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsVersionsGetToManyRelatedFieldsSubscriptionVersion)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsVersionsGetToManyRelatedFieldsSubscriptionVersion?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsVersionsGetToManyRelatedFieldsSubscription)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsVersionsGetToManyRelatedFieldsSubscription?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsVersionsGetToManyRelatedFieldsSubscriptionImage)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsVersionsGetToManyRelatedFieldsSubscriptionImage?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsVersionsGetToManyRelatedFieldsSubscriptionLocalization)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsVersionsGetToManyRelatedFieldsSubscriptionLocalization?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsVersionsGetToManyRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsVersionsGetToManyRelatedIncludeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsWinBackOffersGetToManyRelatedFieldsWinBackOffer)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsWinBackOffersGetToManyRelatedFieldsWinBackOffer?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsWinBackOffersGetToManyRelatedFieldsWinBackOfferPrice)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsWinBackOffersGetToManyRelatedFieldsWinBackOfferPrice?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsWinBackOffersGetToManyRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsWinBackOffersGetToManyRelatedIncludeItem?);
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

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionImageV2Type))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionImageV2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionImageV2Type?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionImageV2TypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionIntroductoryOfferInlineCreateType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionIntroductoryOfferInlineCreateTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionIntroductoryOfferInlineCreateType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionIntroductoryOfferInlineCreateTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionIntroductoryOfferInlineCreateRelationshipsSubscriptionDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionIntroductoryOfferInlineCreateRelationshipsSubscriptionDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionIntroductoryOfferInlineCreateRelationshipsSubscriptionDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionIntroductoryOfferInlineCreateRelationshipsSubscriptionDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionIntroductoryOfferInlineCreateRelationshipsTerritoryDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionIntroductoryOfferInlineCreateRelationshipsTerritoryDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionIntroductoryOfferInlineCreateRelationshipsTerritoryDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionIntroductoryOfferInlineCreateRelationshipsTerritoryDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionIntroductoryOfferInlineCreateRelationshipsSubscriptionPricePointDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionIntroductoryOfferInlineCreateRelationshipsSubscriptionPricePointDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionIntroductoryOfferInlineCreateRelationshipsSubscriptionPricePointDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionIntroductoryOfferInlineCreateRelationshipsSubscriptionPricePointDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionIntroductoryOffersResponseIncludedItemDiscriminatorType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionIntroductoryOffersResponseIncludedItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionIntroductoryOffersResponseIncludedItemDiscriminatorType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionIntroductoryOffersResponseIncludedItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionLocalizationV2Type))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionLocalizationV2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionLocalizationV2Type?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionLocalizationV2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionLocalizationV2RelationshipsVersionDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionLocalizationV2RelationshipsVersionDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionLocalizationV2RelationshipsVersionDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionLocalizationV2RelationshipsVersionDataTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferCodeCustomCodeType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionOfferCodeCustomCodeTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferCodeCustomCodeType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionOfferCodeCustomCodeTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferCodeCustomCodeRelationshipsOfferCodeDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionOfferCodeCustomCodeRelationshipsOfferCodeDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferCodeCustomCodeRelationshipsOfferCodeDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionOfferCodeCustomCodeRelationshipsOfferCodeDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferCodeOneTimeUseCodeType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionOfferCodeOneTimeUseCodeTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferCodeOneTimeUseCodeType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionOfferCodeOneTimeUseCodeTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferCodeOneTimeUseCodeRelationshipsOfferCodeDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionOfferCodeOneTimeUseCodeRelationshipsOfferCodeDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferCodeOneTimeUseCodeRelationshipsOfferCodeDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionOfferCodeOneTimeUseCodeRelationshipsOfferCodeDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferCodePriceType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionOfferCodePriceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferCodePriceType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionOfferCodePriceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferCodePriceRelationshipsTerritoryDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionOfferCodePriceRelationshipsTerritoryDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferCodePriceRelationshipsTerritoryDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionOfferCodePriceRelationshipsTerritoryDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferCodePriceRelationshipsSubscriptionPricePointDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionOfferCodePriceRelationshipsSubscriptionPricePointDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferCodePriceRelationshipsSubscriptionPricePointDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionOfferCodePriceRelationshipsSubscriptionPricePointDataTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferCodesResponseIncludedItemDiscriminatorType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionOfferCodesResponseIncludedItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferCodesResponseIncludedItemDiscriminatorType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionOfferCodesResponseIncludedItemDiscriminatorTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionPricePointType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionPricePointTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionPricePointType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionPricePointTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionPricePointRelationshipsTerritoryDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionPricePointRelationshipsTerritoryDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionPricePointRelationshipsTerritoryDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionPricePointRelationshipsTerritoryDataTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionPriceInlineCreateType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionPriceInlineCreateTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionPriceInlineCreateType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionPriceInlineCreateTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionPriceInlineCreateRelationshipsSubscriptionDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionPriceInlineCreateRelationshipsSubscriptionDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionPriceInlineCreateRelationshipsSubscriptionDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionPriceInlineCreateRelationshipsSubscriptionDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionPriceInlineCreateRelationshipsTerritoryDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionPriceInlineCreateRelationshipsTerritoryDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionPriceInlineCreateRelationshipsTerritoryDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionPriceInlineCreateRelationshipsTerritoryDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionPriceInlineCreateRelationshipsSubscriptionPricePointDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionPriceInlineCreateRelationshipsSubscriptionPricePointDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionPriceInlineCreateRelationshipsSubscriptionPricePointDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionPriceInlineCreateRelationshipsSubscriptionPricePointDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionPricesResponseIncludedItemDiscriminatorType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionPricesResponseIncludedItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionPricesResponseIncludedItemDiscriminatorType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionPricesResponseIncludedItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionPromotionalOfferPriceType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionPromotionalOfferPriceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionPromotionalOfferPriceType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionPromotionalOfferPriceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionPromotionalOfferPriceRelationshipsTerritoryDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionPromotionalOfferPriceRelationshipsTerritoryDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionPromotionalOfferPriceRelationshipsTerritoryDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionPromotionalOfferPriceRelationshipsTerritoryDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionPromotionalOfferPriceRelationshipsSubscriptionPricePointDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionPromotionalOfferPriceRelationshipsSubscriptionPricePointDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionPromotionalOfferPriceRelationshipsSubscriptionPricePointDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionPromotionalOfferPriceRelationshipsSubscriptionPricePointDataTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionPromotionalOfferInlineCreateType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionPromotionalOfferInlineCreateTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionPromotionalOfferInlineCreateType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionPromotionalOfferInlineCreateTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionPromotionalOfferInlineCreateRelationshipsSubscriptionDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionPromotionalOfferInlineCreateRelationshipsSubscriptionDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionPromotionalOfferInlineCreateRelationshipsSubscriptionDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionPromotionalOfferInlineCreateRelationshipsSubscriptionDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionPromotionalOfferInlineCreateRelationshipsPricesDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionPromotionalOfferInlineCreateRelationshipsPricesDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionPromotionalOfferInlineCreateRelationshipsPricesDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionPromotionalOfferInlineCreateRelationshipsPricesDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionPromotionalOffersResponseIncludedItemDiscriminatorType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionPromotionalOffersResponseIncludedItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionPromotionalOffersResponseIncludedItemDiscriminatorType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionPromotionalOffersResponseIncludedItemDiscriminatorTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionVersionsResponseIncludedItemDiscriminatorType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionVersionsResponseIncludedItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionVersionsResponseIncludedItemDiscriminatorType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionVersionsResponseIncludedItemDiscriminatorTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionResponseIncludedItemDiscriminatorType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionResponseIncludedItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionResponseIncludedItemDiscriminatorType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionResponseIncludedItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionCreateRequestDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionCreateRequestDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionCreateRequestDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionCreateRequestDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionCreateRequestDataAttributesSubscriptionPeriod))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionCreateRequestDataAttributesSubscriptionPeriodJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionCreateRequestDataAttributesSubscriptionPeriod?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionCreateRequestDataAttributesSubscriptionPeriodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionCreateRequestDataRelationshipsGroupDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionCreateRequestDataRelationshipsGroupDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionCreateRequestDataRelationshipsGroupDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionCreateRequestDataRelationshipsGroupDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionUpdateRequestDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionUpdateRequestDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionUpdateRequestDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionUpdateRequestDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionUpdateRequestDataAttributesSubscriptionPeriod))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionUpdateRequestDataAttributesSubscriptionPeriodJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionUpdateRequestDataAttributesSubscriptionPeriod?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionUpdateRequestDataAttributesSubscriptionPeriodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionUpdateRequestDataRelationshipsIntroductoryOffersDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionUpdateRequestDataRelationshipsIntroductoryOffersDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionUpdateRequestDataRelationshipsIntroductoryOffersDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionUpdateRequestDataRelationshipsIntroductoryOffersDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionUpdateRequestDataRelationshipsPromotionalOffersDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionUpdateRequestDataRelationshipsPromotionalOffersDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionUpdateRequestDataRelationshipsPromotionalOffersDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionUpdateRequestDataRelationshipsPromotionalOffersDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionUpdateRequestDataRelationshipsPricesDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionUpdateRequestDataRelationshipsPricesDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionUpdateRequestDataRelationshipsPricesDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionUpdateRequestDataRelationshipsPricesDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.TerritoryType))
                {
                    return new global::AppStoreConnect.JsonConverters.TerritoryTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.TerritoryType?))
                {
                    return new global::AppStoreConnect.JsonConverters.TerritoryTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.WinBackOfferPriceType))
                {
                    return new global::AppStoreConnect.JsonConverters.WinBackOfferPriceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.WinBackOfferPriceType?))
                {
                    return new global::AppStoreConnect.JsonConverters.WinBackOfferPriceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.WinBackOfferPriceRelationshipsTerritoryDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.WinBackOfferPriceRelationshipsTerritoryDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.WinBackOfferPriceRelationshipsTerritoryDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.WinBackOfferPriceRelationshipsTerritoryDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.WinBackOfferPriceRelationshipsSubscriptionPricePointDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.WinBackOfferPriceRelationshipsSubscriptionPricePointDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.WinBackOfferPriceRelationshipsSubscriptionPricePointDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.WinBackOfferPriceRelationshipsSubscriptionPricePointDataTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionAppStoreReviewScreenshotLinkageResponseDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionAppStoreReviewScreenshotLinkageResponseDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionAppStoreReviewScreenshotLinkageResponseDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionAppStoreReviewScreenshotLinkageResponseDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionImagesLinkagesResponseDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionImagesLinkagesResponseDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionImagesLinkagesResponseDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionImagesLinkagesResponseDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionIntroductoryOffersLinkagesResponseDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionIntroductoryOffersLinkagesResponseDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionIntroductoryOffersLinkagesResponseDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionIntroductoryOffersLinkagesResponseDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionIntroductoryOffersLinkagesRequestDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionIntroductoryOffersLinkagesRequestDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionIntroductoryOffersLinkagesRequestDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionIntroductoryOffersLinkagesRequestDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferCodesLinkagesResponseDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionOfferCodesLinkagesResponseDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferCodesLinkagesResponseDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionOfferCodesLinkagesResponseDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionPlanAvailabilitiesLinkagesResponseDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionPlanAvailabilitiesLinkagesResponseDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionPlanAvailabilitiesLinkagesResponseDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionPlanAvailabilitiesLinkagesResponseDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionPricePointsLinkagesResponseDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionPricePointsLinkagesResponseDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionPricePointsLinkagesResponseDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionPricePointsLinkagesResponseDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionPricesLinkagesResponseDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionPricesLinkagesResponseDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionPricesLinkagesResponseDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionPricesLinkagesResponseDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionPricesLinkagesRequestDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionPricesLinkagesRequestDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionPricesLinkagesRequestDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionPricesLinkagesRequestDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionPromotedPurchaseLinkageResponseDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionPromotedPurchaseLinkageResponseDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionPromotedPurchaseLinkageResponseDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionPromotedPurchaseLinkageResponseDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionPromotionalOffersLinkagesResponseDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionPromotionalOffersLinkagesResponseDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionPromotionalOffersLinkagesResponseDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionPromotionalOffersLinkagesResponseDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionSubscriptionAvailabilityLinkageResponseDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionSubscriptionAvailabilityLinkageResponseDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionSubscriptionAvailabilityLinkageResponseDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionSubscriptionAvailabilityLinkageResponseDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionSubscriptionLocalizationsLinkagesResponseDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionSubscriptionLocalizationsLinkagesResponseDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionSubscriptionLocalizationsLinkagesResponseDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionSubscriptionLocalizationsLinkagesResponseDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionVersionsLinkagesResponseDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionVersionsLinkagesResponseDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionVersionsLinkagesResponseDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionVersionsLinkagesResponseDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionWinBackOffersLinkagesResponseDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionWinBackOffersLinkagesResponseDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionWinBackOffersLinkagesResponseDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionWinBackOffersLinkagesResponseDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppMediaAssetStateState))
                {
                    return new global::AppStoreConnect.JsonConverters.AppMediaAssetStateStateJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppMediaAssetStateState?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppMediaAssetStateStateNullableJsonConverter();
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

                if (typeToConvert == typeof(global::AppStoreConnect.OfferCodeEnvironment))
                {
                    return new global::AppStoreConnect.JsonConverters.OfferCodeEnvironmentJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.OfferCodeEnvironment?))
                {
                    return new global::AppStoreConnect.JsonConverters.OfferCodeEnvironmentNullableJsonConverter();
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

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscription))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsGetInstanceFieldsSubscriptionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscription?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsGetInstanceFieldsSubscriptionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionLocalization))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsGetInstanceFieldsSubscriptionLocalizationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionLocalization?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsGetInstanceFieldsSubscriptionLocalizationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionAppStoreReviewScreenshot))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsGetInstanceFieldsSubscriptionAppStoreReviewScreenshotJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionAppStoreReviewScreenshot?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsGetInstanceFieldsSubscriptionAppStoreReviewScreenshotNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionGroup))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsGetInstanceFieldsSubscriptionGroupJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionGroup?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsGetInstanceFieldsSubscriptionGroupNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionIntroductoryOffer))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsGetInstanceFieldsSubscriptionIntroductoryOfferJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionIntroductoryOffer?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsGetInstanceFieldsSubscriptionIntroductoryOfferNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionPromotionalOffer))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsGetInstanceFieldsSubscriptionPromotionalOfferJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionPromotionalOffer?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsGetInstanceFieldsSubscriptionPromotionalOfferNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionOfferCode))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsGetInstanceFieldsSubscriptionOfferCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionOfferCode?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsGetInstanceFieldsSubscriptionOfferCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionPrice))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsGetInstanceFieldsSubscriptionPriceJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionPrice?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsGetInstanceFieldsSubscriptionPriceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsPromotedPurchase))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsGetInstanceFieldsPromotedPurchaseJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsPromotedPurchase?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsGetInstanceFieldsPromotedPurchaseNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionAvailabilitie))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsGetInstanceFieldsSubscriptionAvailabilitieJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionAvailabilitie?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsGetInstanceFieldsSubscriptionAvailabilitieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsWinBackOffer))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsGetInstanceFieldsWinBackOfferJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsWinBackOffer?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsGetInstanceFieldsWinBackOfferNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionImage))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsGetInstanceFieldsSubscriptionImageJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionImage?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsGetInstanceFieldsSubscriptionImageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionPlanAvailabilitie))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsGetInstanceFieldsSubscriptionPlanAvailabilitieJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionPlanAvailabilitie?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsGetInstanceFieldsSubscriptionPlanAvailabilitieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionVersion))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsGetInstanceFieldsSubscriptionVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionVersion?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsGetInstanceFieldsSubscriptionVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsGetInstanceIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsGetInstanceIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsGetInstanceIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsGetInstanceIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsAppStoreReviewScreenshotGetToOneRelatedFieldsSubscriptionAppStoreReviewScreenshot))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsAppStoreReviewScreenshotGetToOneRelatedFieldsSubscriptionAppStoreReviewScreenshotJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsAppStoreReviewScreenshotGetToOneRelatedFieldsSubscriptionAppStoreReviewScreenshot?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsAppStoreReviewScreenshotGetToOneRelatedFieldsSubscriptionAppStoreReviewScreenshotNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsAppStoreReviewScreenshotGetToOneRelatedFieldsSubscription))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsAppStoreReviewScreenshotGetToOneRelatedFieldsSubscriptionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsAppStoreReviewScreenshotGetToOneRelatedFieldsSubscription?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsAppStoreReviewScreenshotGetToOneRelatedFieldsSubscriptionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsAppStoreReviewScreenshotGetToOneRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsAppStoreReviewScreenshotGetToOneRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsAppStoreReviewScreenshotGetToOneRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsAppStoreReviewScreenshotGetToOneRelatedIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsImagesGetToManyRelatedFieldsSubscriptionImage))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsImagesGetToManyRelatedFieldsSubscriptionImageJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsImagesGetToManyRelatedFieldsSubscriptionImage?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsImagesGetToManyRelatedFieldsSubscriptionImageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsImagesGetToManyRelatedFieldsSubscription))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsImagesGetToManyRelatedFieldsSubscriptionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsImagesGetToManyRelatedFieldsSubscription?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsImagesGetToManyRelatedFieldsSubscriptionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsImagesGetToManyRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsImagesGetToManyRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsImagesGetToManyRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsImagesGetToManyRelatedIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscriptionIntroductoryOffer))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscriptionIntroductoryOfferJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscriptionIntroductoryOffer?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscriptionIntroductoryOfferNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscription))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscriptionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscription?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscriptionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsIntroductoryOffersGetToManyRelatedFieldsTerritorie))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsIntroductoryOffersGetToManyRelatedFieldsTerritorieJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsIntroductoryOffersGetToManyRelatedFieldsTerritorie?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsIntroductoryOffersGetToManyRelatedFieldsTerritorieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscriptionPricePoint))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscriptionPricePointJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscriptionPricePoint?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscriptionPricePointNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsIntroductoryOffersGetToManyRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsIntroductoryOffersGetToManyRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsIntroductoryOffersGetToManyRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsIntroductoryOffersGetToManyRelatedIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCode))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCode?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsOfferCodesGetToManyRelatedFieldsSubscription))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsOfferCodesGetToManyRelatedFieldsSubscription?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCodeOneTimeUseCode))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCodeOneTimeUseCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCodeOneTimeUseCode?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCodeOneTimeUseCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCodeCustomCode))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCodeCustomCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCodeCustomCode?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCodeCustomCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCodePrice))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCodePriceJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCodePrice?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCodePriceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsOfferCodesGetToManyRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsOfferCodesGetToManyRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsOfferCodesGetToManyRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsOfferCodesGetToManyRelatedIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsPlanAvailabilitiesGetToManyRelatedFieldsSubscriptionPlanAvailabilitie))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsPlanAvailabilitiesGetToManyRelatedFieldsSubscriptionPlanAvailabilitieJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsPlanAvailabilitiesGetToManyRelatedFieldsSubscriptionPlanAvailabilitie?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsPlanAvailabilitiesGetToManyRelatedFieldsSubscriptionPlanAvailabilitieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsPlanAvailabilitiesGetToManyRelatedFieldsTerritorie))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsPlanAvailabilitiesGetToManyRelatedFieldsTerritorieJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsPlanAvailabilitiesGetToManyRelatedFieldsTerritorie?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsPlanAvailabilitiesGetToManyRelatedFieldsTerritorieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsPlanAvailabilitiesGetToManyRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsPlanAvailabilitiesGetToManyRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsPlanAvailabilitiesGetToManyRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsPlanAvailabilitiesGetToManyRelatedIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsPricePointsGetToManyRelatedFieldsSubscriptionPricePoint))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsPricePointsGetToManyRelatedFieldsSubscriptionPricePointJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsPricePointsGetToManyRelatedFieldsSubscriptionPricePoint?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsPricePointsGetToManyRelatedFieldsSubscriptionPricePointNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsPricePointsGetToManyRelatedFieldsTerritorie))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsPricePointsGetToManyRelatedFieldsTerritorieJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsPricePointsGetToManyRelatedFieldsTerritorie?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsPricePointsGetToManyRelatedFieldsTerritorieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsPricePointsGetToManyRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsPricePointsGetToManyRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsPricePointsGetToManyRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsPricePointsGetToManyRelatedIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsPricesGetToManyRelatedFilterPlanTypeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsPricesGetToManyRelatedFilterPlanTypeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsPricesGetToManyRelatedFilterPlanTypeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsPricesGetToManyRelatedFilterPlanTypeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsPricesGetToManyRelatedFieldsSubscriptionPrice))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsPricesGetToManyRelatedFieldsSubscriptionPriceJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsPricesGetToManyRelatedFieldsSubscriptionPrice?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsPricesGetToManyRelatedFieldsSubscriptionPriceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsPricesGetToManyRelatedFieldsTerritorie))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsPricesGetToManyRelatedFieldsTerritorieJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsPricesGetToManyRelatedFieldsTerritorie?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsPricesGetToManyRelatedFieldsTerritorieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsPricesGetToManyRelatedFieldsSubscriptionPricePoint))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsPricesGetToManyRelatedFieldsSubscriptionPricePointJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsPricesGetToManyRelatedFieldsSubscriptionPricePoint?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsPricesGetToManyRelatedFieldsSubscriptionPricePointNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsPricesGetToManyRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsPricesGetToManyRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsPricesGetToManyRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsPricesGetToManyRelatedIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsPromotedPurchaseGetToOneRelatedFieldsPromotedPurchase))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsPromotedPurchaseGetToOneRelatedFieldsPromotedPurchaseJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsPromotedPurchaseGetToOneRelatedFieldsPromotedPurchase?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsPromotedPurchaseGetToOneRelatedFieldsPromotedPurchaseNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsPromotedPurchaseGetToOneRelatedFieldsInAppPurchase))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsPromotedPurchaseGetToOneRelatedFieldsInAppPurchaseJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsPromotedPurchaseGetToOneRelatedFieldsInAppPurchase?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsPromotedPurchaseGetToOneRelatedFieldsInAppPurchaseNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsPromotedPurchaseGetToOneRelatedFieldsSubscription))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsPromotedPurchaseGetToOneRelatedFieldsSubscriptionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsPromotedPurchaseGetToOneRelatedFieldsSubscription?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsPromotedPurchaseGetToOneRelatedFieldsSubscriptionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsPromotedPurchaseGetToOneRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsPromotedPurchaseGetToOneRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsPromotedPurchaseGetToOneRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsPromotedPurchaseGetToOneRelatedIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsPromotionalOffersGetToManyRelatedFieldsSubscriptionPromotionalOffer))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsPromotionalOffersGetToManyRelatedFieldsSubscriptionPromotionalOfferJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsPromotionalOffersGetToManyRelatedFieldsSubscriptionPromotionalOffer?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsPromotionalOffersGetToManyRelatedFieldsSubscriptionPromotionalOfferNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsPromotionalOffersGetToManyRelatedFieldsSubscription))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsPromotionalOffersGetToManyRelatedFieldsSubscriptionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsPromotionalOffersGetToManyRelatedFieldsSubscription?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsPromotionalOffersGetToManyRelatedFieldsSubscriptionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsPromotionalOffersGetToManyRelatedFieldsSubscriptionPromotionalOfferPrice))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsPromotionalOffersGetToManyRelatedFieldsSubscriptionPromotionalOfferPriceJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsPromotionalOffersGetToManyRelatedFieldsSubscriptionPromotionalOfferPrice?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsPromotionalOffersGetToManyRelatedFieldsSubscriptionPromotionalOfferPriceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsPromotionalOffersGetToManyRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsPromotionalOffersGetToManyRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsPromotionalOffersGetToManyRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsPromotionalOffersGetToManyRelatedIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsSubscriptionAvailabilityGetToOneRelatedFieldsSubscriptionAvailabilitie))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsSubscriptionAvailabilityGetToOneRelatedFieldsSubscriptionAvailabilitieJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsSubscriptionAvailabilityGetToOneRelatedFieldsSubscriptionAvailabilitie?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsSubscriptionAvailabilityGetToOneRelatedFieldsSubscriptionAvailabilitieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsSubscriptionAvailabilityGetToOneRelatedFieldsTerritorie))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsSubscriptionAvailabilityGetToOneRelatedFieldsTerritorieJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsSubscriptionAvailabilityGetToOneRelatedFieldsTerritorie?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsSubscriptionAvailabilityGetToOneRelatedFieldsTerritorieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsSubscriptionAvailabilityGetToOneRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsSubscriptionAvailabilityGetToOneRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsSubscriptionAvailabilityGetToOneRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsSubscriptionAvailabilityGetToOneRelatedIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsSubscriptionLocalizationsGetToManyRelatedFieldsSubscriptionLocalization))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsSubscriptionLocalizationsGetToManyRelatedFieldsSubscriptionLocalizationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsSubscriptionLocalizationsGetToManyRelatedFieldsSubscriptionLocalization?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsSubscriptionLocalizationsGetToManyRelatedFieldsSubscriptionLocalizationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsSubscriptionLocalizationsGetToManyRelatedFieldsSubscription))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsSubscriptionLocalizationsGetToManyRelatedFieldsSubscriptionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsSubscriptionLocalizationsGetToManyRelatedFieldsSubscription?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsSubscriptionLocalizationsGetToManyRelatedFieldsSubscriptionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsSubscriptionLocalizationsGetToManyRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsSubscriptionLocalizationsGetToManyRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsSubscriptionLocalizationsGetToManyRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsSubscriptionLocalizationsGetToManyRelatedIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsVersionsGetToManyRelatedFilterStateItem))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsVersionsGetToManyRelatedFilterStateItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsVersionsGetToManyRelatedFilterStateItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsVersionsGetToManyRelatedFilterStateItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsVersionsGetToManyRelatedFieldsSubscriptionVersion))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsVersionsGetToManyRelatedFieldsSubscriptionVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsVersionsGetToManyRelatedFieldsSubscriptionVersion?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsVersionsGetToManyRelatedFieldsSubscriptionVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsVersionsGetToManyRelatedFieldsSubscription))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsVersionsGetToManyRelatedFieldsSubscriptionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsVersionsGetToManyRelatedFieldsSubscription?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsVersionsGetToManyRelatedFieldsSubscriptionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsVersionsGetToManyRelatedFieldsSubscriptionImage))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsVersionsGetToManyRelatedFieldsSubscriptionImageJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsVersionsGetToManyRelatedFieldsSubscriptionImage?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsVersionsGetToManyRelatedFieldsSubscriptionImageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsVersionsGetToManyRelatedFieldsSubscriptionLocalization))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsVersionsGetToManyRelatedFieldsSubscriptionLocalizationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsVersionsGetToManyRelatedFieldsSubscriptionLocalization?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsVersionsGetToManyRelatedFieldsSubscriptionLocalizationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsVersionsGetToManyRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsVersionsGetToManyRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsVersionsGetToManyRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsVersionsGetToManyRelatedIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsWinBackOffersGetToManyRelatedFieldsWinBackOffer))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsWinBackOffersGetToManyRelatedFieldsWinBackOfferJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsWinBackOffersGetToManyRelatedFieldsWinBackOffer?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsWinBackOffersGetToManyRelatedFieldsWinBackOfferNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsWinBackOffersGetToManyRelatedFieldsWinBackOfferPrice))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsWinBackOffersGetToManyRelatedFieldsWinBackOfferPriceJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsWinBackOffersGetToManyRelatedFieldsWinBackOfferPrice?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsWinBackOffersGetToManyRelatedFieldsWinBackOfferPriceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsWinBackOffersGetToManyRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsWinBackOffersGetToManyRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsWinBackOffersGetToManyRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsWinBackOffersGetToManyRelatedIncludeItemNullableJsonConverter();
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
                    0 => new SubscriptionsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),

                    1 => new SubscriptionsSourceGenerationContextChunk1(new global::System.Text.Json.JsonSerializerOptions()),

                    2 => new SubscriptionsSourceGenerationContextChunk2(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}