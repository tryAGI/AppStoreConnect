#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace AppStoreConnect.JsonConverters
{
    /// <inheritdoc />
    public class IncludedItem47JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AppStoreConnect.IncludedItem47>
    {
        /// <inheritdoc />
        public override global::AppStoreConnect.IncludedItem47 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppResponseIncludedItemDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppResponseIncludedItemDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.AppResponseIncludedItemDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::AppStoreConnect.AndroidToIosAppMappingDetail? androidToIosAppMappingDetails = default;
            if (discriminator?.Type == global::AppStoreConnect.AppResponseIncludedItemDiscriminatorType.AndroidToIosAppMappingDetails)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AndroidToIosAppMappingDetail), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AndroidToIosAppMappingDetail> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.AndroidToIosAppMappingDetail)}");
                androidToIosAppMappingDetails = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.AppClip? appClips = default;
            if (discriminator?.Type == global::AppStoreConnect.AppResponseIncludedItemDiscriminatorType.AppClips)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppClip), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppClip> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.AppClip)}");
                appClips = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.AppCustomProductPage? appCustomProductPages = default;
            if (discriminator?.Type == global::AppStoreConnect.AppResponseIncludedItemDiscriminatorType.AppCustomProductPages)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppCustomProductPage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppCustomProductPage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.AppCustomProductPage)}");
                appCustomProductPages = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.AppEncryptionDeclaration? appEncryptionDeclarations = default;
            if (discriminator?.Type == global::AppStoreConnect.AppResponseIncludedItemDiscriminatorType.AppEncryptionDeclarations)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppEncryptionDeclaration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppEncryptionDeclaration> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.AppEncryptionDeclaration)}");
                appEncryptionDeclarations = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.AppEvent? appEvents = default;
            if (discriminator?.Type == global::AppStoreConnect.AppResponseIncludedItemDiscriminatorType.AppEvents)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.AppEvent)}");
                appEvents = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.AppInfo? appInfos = default;
            if (discriminator?.Type == global::AppStoreConnect.AppResponseIncludedItemDiscriminatorType.AppInfos)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppInfo), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppInfo> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.AppInfo)}");
                appInfos = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.AppStoreVersionExperimentV2? appStoreVersionExperiments1 = default;
            if (discriminator?.Type == global::AppStoreConnect.AppResponseIncludedItemDiscriminatorType.AppStoreVersionExperiments)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppStoreVersionExperimentV2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppStoreVersionExperimentV2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.AppStoreVersionExperimentV2)}");
                appStoreVersionExperiments1 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.AppStoreVersion? appStoreVersionExperiments2 = default;
            if (discriminator?.Type == global::AppStoreConnect.AppResponseIncludedItemDiscriminatorType.AppStoreVersionExperiments)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppStoreVersion), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppStoreVersion> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.AppStoreVersion)}");
                appStoreVersionExperiments2 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.BetaAppLocalization? betaAppLocalizations = default;
            if (discriminator?.Type == global::AppStoreConnect.AppResponseIncludedItemDiscriminatorType.BetaAppLocalizations)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.BetaAppLocalization), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.BetaAppLocalization> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.BetaAppLocalization)}");
                betaAppLocalizations = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.BetaAppReviewDetail? betaAppReviewDetails = default;
            if (discriminator?.Type == global::AppStoreConnect.AppResponseIncludedItemDiscriminatorType.BetaAppReviewDetails)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.BetaAppReviewDetail), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.BetaAppReviewDetail> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.BetaAppReviewDetail)}");
                betaAppReviewDetails = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.BetaGroup? betaGroups = default;
            if (discriminator?.Type == global::AppStoreConnect.AppResponseIncludedItemDiscriminatorType.BetaGroups)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.BetaGroup), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.BetaGroup> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.BetaGroup)}");
                betaGroups = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.BetaLicenseAgreement? betaLicenseAgreements = default;
            if (discriminator?.Type == global::AppStoreConnect.AppResponseIncludedItemDiscriminatorType.BetaLicenseAgreements)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.BetaLicenseAgreement), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.BetaLicenseAgreement> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.BetaLicenseAgreement)}");
                betaLicenseAgreements = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.BuildIcon? buildIcons1 = default;
            if (discriminator?.Type == global::AppStoreConnect.AppResponseIncludedItemDiscriminatorType.BuildIcons)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.BuildIcon), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.BuildIcon> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.BuildIcon)}");
                buildIcons1 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.Build? buildIcons2 = default;
            if (discriminator?.Type == global::AppStoreConnect.AppResponseIncludedItemDiscriminatorType.BuildIcons)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.Build), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.Build> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.Build)}");
                buildIcons2 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.CiProduct? ciProducts = default;
            if (discriminator?.Type == global::AppStoreConnect.AppResponseIncludedItemDiscriminatorType.CiProducts)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.CiProduct), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.CiProduct> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.CiProduct)}");
                ciProducts = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.EndUserLicenseAgreement? endUserLicenseAgreements = default;
            if (discriminator?.Type == global::AppStoreConnect.AppResponseIncludedItemDiscriminatorType.EndUserLicenseAgreements)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.EndUserLicenseAgreement), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.EndUserLicenseAgreement> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.EndUserLicenseAgreement)}");
                endUserLicenseAgreements = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.GameCenterDetail? gameCenterDetails = default;
            if (discriminator?.Type == global::AppStoreConnect.AppResponseIncludedItemDiscriminatorType.GameCenterDetails)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.GameCenterDetail), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.GameCenterDetail> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.GameCenterDetail)}");
                gameCenterDetails = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.GameCenterEnabledVersion? gameCenterEnabledVersions = default;
            if (discriminator?.Type == global::AppStoreConnect.AppResponseIncludedItemDiscriminatorType.GameCenterEnabledVersions)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.GameCenterEnabledVersion), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.GameCenterEnabledVersion> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.GameCenterEnabledVersion)}");
                gameCenterEnabledVersions = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.InAppPurchase? inAppPurchases = default;
            if (discriminator?.Type == global::AppStoreConnect.AppResponseIncludedItemDiscriminatorType.InAppPurchases)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.InAppPurchase), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.InAppPurchase> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.InAppPurchase)}");
                inAppPurchases = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.PrereleaseVersion? preReleaseVersions = default;
            if (discriminator?.Type == global::AppStoreConnect.AppResponseIncludedItemDiscriminatorType.PreReleaseVersions)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.PrereleaseVersion), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.PrereleaseVersion> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.PrereleaseVersion)}");
                preReleaseVersions = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.PromotedPurchase? promotedPurchases = default;
            if (discriminator?.Type == global::AppStoreConnect.AppResponseIncludedItemDiscriminatorType.PromotedPurchases)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.PromotedPurchase), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.PromotedPurchase> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.PromotedPurchase)}");
                promotedPurchases = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.ReviewSubmission? reviewSubmissions = default;
            if (discriminator?.Type == global::AppStoreConnect.AppResponseIncludedItemDiscriminatorType.ReviewSubmissions)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.ReviewSubmission), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.ReviewSubmission> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.ReviewSubmission)}");
                reviewSubmissions = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.SubscriptionGracePeriod? subscriptionGracePeriods = default;
            if (discriminator?.Type == global::AppStoreConnect.AppResponseIncludedItemDiscriminatorType.SubscriptionGracePeriods)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.SubscriptionGracePeriod), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.SubscriptionGracePeriod> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.SubscriptionGracePeriod)}");
                subscriptionGracePeriods = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.SubscriptionGroup? subscriptionGroups = default;
            if (discriminator?.Type == global::AppStoreConnect.AppResponseIncludedItemDiscriminatorType.SubscriptionGroups)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.SubscriptionGroup), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.SubscriptionGroup> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.SubscriptionGroup)}");
                subscriptionGroups = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::AppStoreConnect.IncludedItem47(
                discriminator?.Type,
                androidToIosAppMappingDetails,

                appClips,

                appCustomProductPages,

                appEncryptionDeclarations,

                appEvents,

                appInfos,

                appStoreVersionExperiments1,

                appStoreVersionExperiments2,

                betaAppLocalizations,

                betaAppReviewDetails,

                betaGroups,

                betaLicenseAgreements,

                buildIcons1,

                buildIcons2,

                ciProducts,

                endUserLicenseAgreements,

                gameCenterDetails,

                gameCenterEnabledVersions,

                inAppPurchases,

                preReleaseVersions,

                promotedPurchases,

                reviewSubmissions,

                subscriptionGracePeriods,

                subscriptionGroups
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AppStoreConnect.IncludedItem47 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsAndroidToIosAppMappingDetails)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AndroidToIosAppMappingDetail), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AndroidToIosAppMappingDetail?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.AndroidToIosAppMappingDetail).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AndroidToIosAppMappingDetails!, typeInfo);
            }
            else if (value.IsAppClips)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppClip), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppClip?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.AppClip).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AppClips!, typeInfo);
            }
            else if (value.IsAppCustomProductPages)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppCustomProductPage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppCustomProductPage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.AppCustomProductPage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AppCustomProductPages!, typeInfo);
            }
            else if (value.IsAppEncryptionDeclarations)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppEncryptionDeclaration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppEncryptionDeclaration?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.AppEncryptionDeclaration).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AppEncryptionDeclarations!, typeInfo);
            }
            else if (value.IsAppEvents)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.AppEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AppEvents!, typeInfo);
            }
            else if (value.IsAppInfos)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppInfo), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppInfo?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.AppInfo).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AppInfos!, typeInfo);
            }
            else if (value.IsAppStoreVersionExperiments1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppStoreVersionExperimentV2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppStoreVersionExperimentV2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.AppStoreVersionExperimentV2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AppStoreVersionExperiments1!, typeInfo);
            }
            else if (value.IsAppStoreVersionExperiments2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppStoreVersion), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppStoreVersion?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.AppStoreVersion).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AppStoreVersionExperiments2!, typeInfo);
            }
            else if (value.IsBetaAppLocalizations)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.BetaAppLocalization), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.BetaAppLocalization?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.BetaAppLocalization).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BetaAppLocalizations!, typeInfo);
            }
            else if (value.IsBetaAppReviewDetails)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.BetaAppReviewDetail), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.BetaAppReviewDetail?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.BetaAppReviewDetail).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BetaAppReviewDetails!, typeInfo);
            }
            else if (value.IsBetaGroups)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.BetaGroup), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.BetaGroup?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.BetaGroup).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BetaGroups!, typeInfo);
            }
            else if (value.IsBetaLicenseAgreements)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.BetaLicenseAgreement), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.BetaLicenseAgreement?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.BetaLicenseAgreement).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BetaLicenseAgreements!, typeInfo);
            }
            else if (value.IsBuildIcons1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.BuildIcon), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.BuildIcon?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.BuildIcon).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BuildIcons1!, typeInfo);
            }
            else if (value.IsBuildIcons2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.Build), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.Build?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.Build).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BuildIcons2!, typeInfo);
            }
            else if (value.IsCiProducts)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.CiProduct), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.CiProduct?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.CiProduct).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CiProducts!, typeInfo);
            }
            else if (value.IsEndUserLicenseAgreements)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.EndUserLicenseAgreement), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.EndUserLicenseAgreement?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.EndUserLicenseAgreement).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.EndUserLicenseAgreements!, typeInfo);
            }
            else if (value.IsGameCenterDetails)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.GameCenterDetail), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.GameCenterDetail?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.GameCenterDetail).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GameCenterDetails!, typeInfo);
            }
            else if (value.IsGameCenterEnabledVersions)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.GameCenterEnabledVersion), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.GameCenterEnabledVersion?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.GameCenterEnabledVersion).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GameCenterEnabledVersions!, typeInfo);
            }
            else if (value.IsInAppPurchases)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.InAppPurchase), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.InAppPurchase?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.InAppPurchase).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InAppPurchases!, typeInfo);
            }
            else if (value.IsPreReleaseVersions)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.PrereleaseVersion), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.PrereleaseVersion?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.PrereleaseVersion).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PreReleaseVersions!, typeInfo);
            }
            else if (value.IsPromotedPurchases)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.PromotedPurchase), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.PromotedPurchase?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.PromotedPurchase).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PromotedPurchases!, typeInfo);
            }
            else if (value.IsReviewSubmissions)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.ReviewSubmission), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.ReviewSubmission?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.ReviewSubmission).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ReviewSubmissions!, typeInfo);
            }
            else if (value.IsSubscriptionGracePeriods)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.SubscriptionGracePeriod), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.SubscriptionGracePeriod?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.SubscriptionGracePeriod).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SubscriptionGracePeriods!, typeInfo);
            }
            else if (value.IsSubscriptionGroups)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.SubscriptionGroup), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.SubscriptionGroup?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.SubscriptionGroup).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SubscriptionGroups!, typeInfo);
            }
        }
    }
}