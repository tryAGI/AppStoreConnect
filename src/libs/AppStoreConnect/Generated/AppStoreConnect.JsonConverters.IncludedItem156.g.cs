#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace AppStoreConnect.JsonConverters
{
    /// <inheritdoc />
    public class IncludedItem156JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AppStoreConnect.IncludedItem156>
    {
        /// <inheritdoc />
        public override global::AppStoreConnect.IncludedItem156 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.ReviewSubmissionItemsResponseIncludedItemDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.ReviewSubmissionItemsResponseIncludedItemDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.ReviewSubmissionItemsResponseIncludedItemDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::AppStoreConnect.AppAssetLibraryImage? appAssetLibraryImages = default;
            if (discriminator?.Type == global::AppStoreConnect.ReviewSubmissionItemsResponseIncludedItemDiscriminatorType.AppAssetLibraryImages)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppAssetLibraryImage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppAssetLibraryImage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.AppAssetLibraryImage)}");
                appAssetLibraryImages = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.AppAssetLibraryVideo? appAssetLibraryVideos = default;
            if (discriminator?.Type == global::AppStoreConnect.ReviewSubmissionItemsResponseIncludedItemDiscriminatorType.AppAssetLibraryVideos)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppAssetLibraryVideo), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppAssetLibraryVideo> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.AppAssetLibraryVideo)}");
                appAssetLibraryVideos = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.AppCustomProductPageVersion? appCustomProductPageVersions = default;
            if (discriminator?.Type == global::AppStoreConnect.ReviewSubmissionItemsResponseIncludedItemDiscriminatorType.AppCustomProductPageVersions)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppCustomProductPageVersion), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppCustomProductPageVersion> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.AppCustomProductPageVersion)}");
                appCustomProductPageVersions = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.AppEvent? appEvents = default;
            if (discriminator?.Type == global::AppStoreConnect.ReviewSubmissionItemsResponseIncludedItemDiscriminatorType.AppEvents)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.AppEvent)}");
                appEvents = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.AppStoreVersionExperiment? appStoreVersionExperiments1 = default;
            if (discriminator?.Type == global::AppStoreConnect.ReviewSubmissionItemsResponseIncludedItemDiscriminatorType.AppStoreVersionExperiments)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppStoreVersionExperiment), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppStoreVersionExperiment> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.AppStoreVersionExperiment)}");
                appStoreVersionExperiments1 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.AppStoreVersion? appStoreVersionExperiments2 = default;
            if (discriminator?.Type == global::AppStoreConnect.ReviewSubmissionItemsResponseIncludedItemDiscriminatorType.AppStoreVersionExperiments)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppStoreVersion), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppStoreVersion> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.AppStoreVersion)}");
                appStoreVersionExperiments2 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.BackgroundAssetVersion? backgroundAssetVersions = default;
            if (discriminator?.Type == global::AppStoreConnect.ReviewSubmissionItemsResponseIncludedItemDiscriminatorType.BackgroundAssetVersions)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.BackgroundAssetVersion), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.BackgroundAssetVersion> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.BackgroundAssetVersion)}");
                backgroundAssetVersions = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.GameCenterAchievementVersionV2? gameCenterAchievementVersions = default;
            if (discriminator?.Type == global::AppStoreConnect.ReviewSubmissionItemsResponseIncludedItemDiscriminatorType.GameCenterAchievementVersions)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.GameCenterAchievementVersionV2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.GameCenterAchievementVersionV2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.GameCenterAchievementVersionV2)}");
                gameCenterAchievementVersions = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.GameCenterActivityVersion? gameCenterActivityVersions = default;
            if (discriminator?.Type == global::AppStoreConnect.ReviewSubmissionItemsResponseIncludedItemDiscriminatorType.GameCenterActivityVersions)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.GameCenterActivityVersion), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.GameCenterActivityVersion> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.GameCenterActivityVersion)}");
                gameCenterActivityVersions = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.GameCenterChallengeVersion? gameCenterChallengeVersions = default;
            if (discriminator?.Type == global::AppStoreConnect.ReviewSubmissionItemsResponseIncludedItemDiscriminatorType.GameCenterChallengeVersions)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.GameCenterChallengeVersion), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.GameCenterChallengeVersion> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.GameCenterChallengeVersion)}");
                gameCenterChallengeVersions = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.GameCenterLeaderboardSetVersionV2? gameCenterLeaderboardSetVersions = default;
            if (discriminator?.Type == global::AppStoreConnect.ReviewSubmissionItemsResponseIncludedItemDiscriminatorType.GameCenterLeaderboardSetVersions)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.GameCenterLeaderboardSetVersionV2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.GameCenterLeaderboardSetVersionV2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.GameCenterLeaderboardSetVersionV2)}");
                gameCenterLeaderboardSetVersions = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.GameCenterLeaderboardVersionV2? gameCenterLeaderboardVersions = default;
            if (discriminator?.Type == global::AppStoreConnect.ReviewSubmissionItemsResponseIncludedItemDiscriminatorType.GameCenterLeaderboardVersions)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.GameCenterLeaderboardVersionV2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.GameCenterLeaderboardVersionV2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.GameCenterLeaderboardVersionV2)}");
                gameCenterLeaderboardVersions = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.InAppPurchaseVersion? inAppPurchaseVersions = default;
            if (discriminator?.Type == global::AppStoreConnect.ReviewSubmissionItemsResponseIncludedItemDiscriminatorType.InAppPurchaseVersions)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.InAppPurchaseVersion), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.InAppPurchaseVersion> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.InAppPurchaseVersion)}");
                inAppPurchaseVersions = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.SubscriptionGroupVersion? subscriptionGroupVersions = default;
            if (discriminator?.Type == global::AppStoreConnect.ReviewSubmissionItemsResponseIncludedItemDiscriminatorType.SubscriptionGroupVersions)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.SubscriptionGroupVersion), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.SubscriptionGroupVersion> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.SubscriptionGroupVersion)}");
                subscriptionGroupVersions = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.SubscriptionVersion? subscriptionVersions = default;
            if (discriminator?.Type == global::AppStoreConnect.ReviewSubmissionItemsResponseIncludedItemDiscriminatorType.SubscriptionVersions)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.SubscriptionVersion), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.SubscriptionVersion> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.SubscriptionVersion)}");
                subscriptionVersions = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::AppStoreConnect.IncludedItem156(
                discriminator?.Type,
                appAssetLibraryImages,

                appAssetLibraryVideos,

                appCustomProductPageVersions,

                appEvents,

                appStoreVersionExperiments1,

                appStoreVersionExperiments2,

                backgroundAssetVersions,

                gameCenterAchievementVersions,

                gameCenterActivityVersions,

                gameCenterChallengeVersions,

                gameCenterLeaderboardSetVersions,

                gameCenterLeaderboardVersions,

                inAppPurchaseVersions,

                subscriptionGroupVersions,

                subscriptionVersions
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AppStoreConnect.IncludedItem156 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsAppAssetLibraryImages)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppAssetLibraryImage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppAssetLibraryImage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.AppAssetLibraryImage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickAppAssetLibraryImages(), typeInfo);
            }
            else if (value.IsAppAssetLibraryVideos)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppAssetLibraryVideo), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppAssetLibraryVideo?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.AppAssetLibraryVideo).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickAppAssetLibraryVideos(), typeInfo);
            }
            else if (value.IsAppCustomProductPageVersions)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppCustomProductPageVersion), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppCustomProductPageVersion?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.AppCustomProductPageVersion).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickAppCustomProductPageVersions(), typeInfo);
            }
            else if (value.IsAppEvents)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.AppEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickAppEvents(), typeInfo);
            }
            else if (value.IsAppStoreVersionExperiments1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppStoreVersionExperiment), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppStoreVersionExperiment?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.AppStoreVersionExperiment).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickAppStoreVersionExperiments1(), typeInfo);
            }
            else if (value.IsAppStoreVersionExperiments2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppStoreVersion), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppStoreVersion?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.AppStoreVersion).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickAppStoreVersionExperiments2(), typeInfo);
            }
            else if (value.IsBackgroundAssetVersions)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.BackgroundAssetVersion), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.BackgroundAssetVersion?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.BackgroundAssetVersion).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickBackgroundAssetVersions(), typeInfo);
            }
            else if (value.IsGameCenterAchievementVersions)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.GameCenterAchievementVersionV2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.GameCenterAchievementVersionV2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.GameCenterAchievementVersionV2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickGameCenterAchievementVersions(), typeInfo);
            }
            else if (value.IsGameCenterActivityVersions)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.GameCenterActivityVersion), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.GameCenterActivityVersion?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.GameCenterActivityVersion).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickGameCenterActivityVersions(), typeInfo);
            }
            else if (value.IsGameCenterChallengeVersions)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.GameCenterChallengeVersion), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.GameCenterChallengeVersion?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.GameCenterChallengeVersion).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickGameCenterChallengeVersions(), typeInfo);
            }
            else if (value.IsGameCenterLeaderboardSetVersions)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.GameCenterLeaderboardSetVersionV2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.GameCenterLeaderboardSetVersionV2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.GameCenterLeaderboardSetVersionV2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickGameCenterLeaderboardSetVersions(), typeInfo);
            }
            else if (value.IsGameCenterLeaderboardVersions)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.GameCenterLeaderboardVersionV2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.GameCenterLeaderboardVersionV2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.GameCenterLeaderboardVersionV2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickGameCenterLeaderboardVersions(), typeInfo);
            }
            else if (value.IsInAppPurchaseVersions)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.InAppPurchaseVersion), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.InAppPurchaseVersion?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.InAppPurchaseVersion).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickInAppPurchaseVersions(), typeInfo);
            }
            else if (value.IsSubscriptionGroupVersions)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.SubscriptionGroupVersion), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.SubscriptionGroupVersion?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.SubscriptionGroupVersion).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickSubscriptionGroupVersions(), typeInfo);
            }
            else if (value.IsSubscriptionVersions)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.SubscriptionVersion), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.SubscriptionVersion?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.SubscriptionVersion).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickSubscriptionVersions(), typeInfo);
            }
        }
    }
}