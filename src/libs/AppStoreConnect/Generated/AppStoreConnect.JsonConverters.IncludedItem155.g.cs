#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace AppStoreConnect.JsonConverters
{
    /// <inheritdoc />
    public class IncludedItem155JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AppStoreConnect.IncludedItem155>
    {
        /// <inheritdoc />
        public override global::AppStoreConnect.IncludedItem155 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.ReviewSubmissionItemResponseIncludedItemDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.ReviewSubmissionItemResponseIncludedItemDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.ReviewSubmissionItemResponseIncludedItemDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::AppStoreConnect.AppCustomProductPageVersion? appCustomProductPageVersions = default;
            if (discriminator?.Type == global::AppStoreConnect.ReviewSubmissionItemResponseIncludedItemDiscriminatorType.AppCustomProductPageVersions)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppCustomProductPageVersion), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppCustomProductPageVersion> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.AppCustomProductPageVersion)}");
                appCustomProductPageVersions = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.AppEvent? appEvents = default;
            if (discriminator?.Type == global::AppStoreConnect.ReviewSubmissionItemResponseIncludedItemDiscriminatorType.AppEvents)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.AppEvent)}");
                appEvents = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.AppStoreVersionExperiment? appStoreVersionExperiments1 = default;
            if (discriminator?.Type == global::AppStoreConnect.ReviewSubmissionItemResponseIncludedItemDiscriminatorType.AppStoreVersionExperiments)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppStoreVersionExperiment), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppStoreVersionExperiment> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.AppStoreVersionExperiment)}");
                appStoreVersionExperiments1 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.AppStoreVersion? appStoreVersionExperiments2 = default;
            if (discriminator?.Type == global::AppStoreConnect.ReviewSubmissionItemResponseIncludedItemDiscriminatorType.AppStoreVersionExperiments)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppStoreVersion), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppStoreVersion> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.AppStoreVersion)}");
                appStoreVersionExperiments2 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.BackgroundAssetVersion? backgroundAssetVersions = default;
            if (discriminator?.Type == global::AppStoreConnect.ReviewSubmissionItemResponseIncludedItemDiscriminatorType.BackgroundAssetVersions)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.BackgroundAssetVersion), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.BackgroundAssetVersion> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.BackgroundAssetVersion)}");
                backgroundAssetVersions = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.GameCenterAchievementVersionV2? gameCenterAchievementVersions = default;
            if (discriminator?.Type == global::AppStoreConnect.ReviewSubmissionItemResponseIncludedItemDiscriminatorType.GameCenterAchievementVersions)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.GameCenterAchievementVersionV2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.GameCenterAchievementVersionV2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.GameCenterAchievementVersionV2)}");
                gameCenterAchievementVersions = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.GameCenterActivityVersion? gameCenterActivityVersions = default;
            if (discriminator?.Type == global::AppStoreConnect.ReviewSubmissionItemResponseIncludedItemDiscriminatorType.GameCenterActivityVersions)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.GameCenterActivityVersion), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.GameCenterActivityVersion> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.GameCenterActivityVersion)}");
                gameCenterActivityVersions = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.GameCenterChallengeVersion? gameCenterChallengeVersions = default;
            if (discriminator?.Type == global::AppStoreConnect.ReviewSubmissionItemResponseIncludedItemDiscriminatorType.GameCenterChallengeVersions)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.GameCenterChallengeVersion), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.GameCenterChallengeVersion> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.GameCenterChallengeVersion)}");
                gameCenterChallengeVersions = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.GameCenterLeaderboardSetVersionV2? gameCenterLeaderboardSetVersions = default;
            if (discriminator?.Type == global::AppStoreConnect.ReviewSubmissionItemResponseIncludedItemDiscriminatorType.GameCenterLeaderboardSetVersions)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.GameCenterLeaderboardSetVersionV2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.GameCenterLeaderboardSetVersionV2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.GameCenterLeaderboardSetVersionV2)}");
                gameCenterLeaderboardSetVersions = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.GameCenterLeaderboardVersionV2? gameCenterLeaderboardVersions = default;
            if (discriminator?.Type == global::AppStoreConnect.ReviewSubmissionItemResponseIncludedItemDiscriminatorType.GameCenterLeaderboardVersions)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.GameCenterLeaderboardVersionV2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.GameCenterLeaderboardVersionV2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.GameCenterLeaderboardVersionV2)}");
                gameCenterLeaderboardVersions = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.InAppPurchaseVersion? inAppPurchaseVersions = default;
            if (discriminator?.Type == global::AppStoreConnect.ReviewSubmissionItemResponseIncludedItemDiscriminatorType.InAppPurchaseVersions)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.InAppPurchaseVersion), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.InAppPurchaseVersion> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.InAppPurchaseVersion)}");
                inAppPurchaseVersions = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.SubscriptionGroupVersion? subscriptionGroupVersions = default;
            if (discriminator?.Type == global::AppStoreConnect.ReviewSubmissionItemResponseIncludedItemDiscriminatorType.SubscriptionGroupVersions)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.SubscriptionGroupVersion), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.SubscriptionGroupVersion> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.SubscriptionGroupVersion)}");
                subscriptionGroupVersions = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.SubscriptionVersion? subscriptionVersions = default;
            if (discriminator?.Type == global::AppStoreConnect.ReviewSubmissionItemResponseIncludedItemDiscriminatorType.SubscriptionVersions)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.SubscriptionVersion), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.SubscriptionVersion> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.SubscriptionVersion)}");
                subscriptionVersions = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::AppStoreConnect.IncludedItem155(
                discriminator?.Type,
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
            global::AppStoreConnect.IncludedItem155 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsAppCustomProductPageVersions)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppCustomProductPageVersion), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppCustomProductPageVersion?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.AppCustomProductPageVersion).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AppCustomProductPageVersions!, typeInfo);
            }
            else if (value.IsAppEvents)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.AppEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AppEvents!, typeInfo);
            }
            else if (value.IsAppStoreVersionExperiments1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppStoreVersionExperiment), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppStoreVersionExperiment?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.AppStoreVersionExperiment).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AppStoreVersionExperiments1!, typeInfo);
            }
            else if (value.IsAppStoreVersionExperiments2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppStoreVersion), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppStoreVersion?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.AppStoreVersion).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AppStoreVersionExperiments2!, typeInfo);
            }
            else if (value.IsBackgroundAssetVersions)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.BackgroundAssetVersion), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.BackgroundAssetVersion?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.BackgroundAssetVersion).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BackgroundAssetVersions!, typeInfo);
            }
            else if (value.IsGameCenterAchievementVersions)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.GameCenterAchievementVersionV2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.GameCenterAchievementVersionV2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.GameCenterAchievementVersionV2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GameCenterAchievementVersions!, typeInfo);
            }
            else if (value.IsGameCenterActivityVersions)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.GameCenterActivityVersion), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.GameCenterActivityVersion?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.GameCenterActivityVersion).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GameCenterActivityVersions!, typeInfo);
            }
            else if (value.IsGameCenterChallengeVersions)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.GameCenterChallengeVersion), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.GameCenterChallengeVersion?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.GameCenterChallengeVersion).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GameCenterChallengeVersions!, typeInfo);
            }
            else if (value.IsGameCenterLeaderboardSetVersions)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.GameCenterLeaderboardSetVersionV2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.GameCenterLeaderboardSetVersionV2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.GameCenterLeaderboardSetVersionV2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GameCenterLeaderboardSetVersions!, typeInfo);
            }
            else if (value.IsGameCenterLeaderboardVersions)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.GameCenterLeaderboardVersionV2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.GameCenterLeaderboardVersionV2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.GameCenterLeaderboardVersionV2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GameCenterLeaderboardVersions!, typeInfo);
            }
            else if (value.IsInAppPurchaseVersions)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.InAppPurchaseVersion), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.InAppPurchaseVersion?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.InAppPurchaseVersion).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InAppPurchaseVersions!, typeInfo);
            }
            else if (value.IsSubscriptionGroupVersions)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.SubscriptionGroupVersion), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.SubscriptionGroupVersion?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.SubscriptionGroupVersion).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SubscriptionGroupVersions!, typeInfo);
            }
            else if (value.IsSubscriptionVersions)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.SubscriptionVersion), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.SubscriptionVersion?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.SubscriptionVersion).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SubscriptionVersions!, typeInfo);
            }
        }
    }
}