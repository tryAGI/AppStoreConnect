#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace AppStoreConnect.JsonConverters
{
    /// <inheritdoc />
    public class IncludedItem104JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AppStoreConnect.IncludedItem104>
    {
        /// <inheritdoc />
        public override global::AppStoreConnect.IncludedItem104 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");
            typeInfoResolver = global::AppStoreConnect.AutoSDKJsonMetadataCachedResolver.Instance;


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.GameCenterDetailResponseIncludedItemDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.GameCenterDetailResponseIncludedItemDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.GameCenterDetailResponseIncludedItemDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::AppStoreConnect.AppStoreVersion? appStoreVersions = default;
            if (discriminator?.Type == global::AppStoreConnect.GameCenterDetailResponseIncludedItemDiscriminatorType.AppStoreVersions)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppStoreVersion), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppStoreVersion> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.AppStoreVersion)}");
                appStoreVersions = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.App? apps = default;
            if (discriminator?.Type == global::AppStoreConnect.GameCenterDetailResponseIncludedItemDiscriminatorType.Apps)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.App), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.App> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.App)}");
                apps = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.GameCenterAchievementRelease? gameCenterAchievementReleases = default;
            if (discriminator?.Type == global::AppStoreConnect.GameCenterDetailResponseIncludedItemDiscriminatorType.GameCenterAchievementReleases)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.GameCenterAchievementRelease), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.GameCenterAchievementRelease> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.GameCenterAchievementRelease)}");
                gameCenterAchievementReleases = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.GameCenterAchievement? gameCenterAchievements = default;
            if (discriminator?.Type == global::AppStoreConnect.GameCenterDetailResponseIncludedItemDiscriminatorType.GameCenterAchievements)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.GameCenterAchievement), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.GameCenterAchievement> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.GameCenterAchievement)}");
                gameCenterAchievements = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.GameCenterActivity? gameCenterActivities = default;
            if (discriminator?.Type == global::AppStoreConnect.GameCenterDetailResponseIncludedItemDiscriminatorType.GameCenterActivities)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.GameCenterActivity), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.GameCenterActivity> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.GameCenterActivity)}");
                gameCenterActivities = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.GameCenterActivityVersionRelease? gameCenterActivityVersionReleases = default;
            if (discriminator?.Type == global::AppStoreConnect.GameCenterDetailResponseIncludedItemDiscriminatorType.GameCenterActivityVersionReleases)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.GameCenterActivityVersionRelease), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.GameCenterActivityVersionRelease> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.GameCenterActivityVersionRelease)}");
                gameCenterActivityVersionReleases = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.GameCenterAppVersion? gameCenterAppVersions = default;
            if (discriminator?.Type == global::AppStoreConnect.GameCenterDetailResponseIncludedItemDiscriminatorType.GameCenterAppVersions)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.GameCenterAppVersion), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.GameCenterAppVersion> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.GameCenterAppVersion)}");
                gameCenterAppVersions = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.GameCenterChallengeVersionRelease? gameCenterChallengeVersionReleases = default;
            if (discriminator?.Type == global::AppStoreConnect.GameCenterDetailResponseIncludedItemDiscriminatorType.GameCenterChallengeVersionReleases)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.GameCenterChallengeVersionRelease), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.GameCenterChallengeVersionRelease> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.GameCenterChallengeVersionRelease)}");
                gameCenterChallengeVersionReleases = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.GameCenterChallenge? gameCenterChallenges = default;
            if (discriminator?.Type == global::AppStoreConnect.GameCenterDetailResponseIncludedItemDiscriminatorType.GameCenterChallenges)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.GameCenterChallenge), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.GameCenterChallenge> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.GameCenterChallenge)}");
                gameCenterChallenges = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.GameCenterGroup? gameCenterGroups = default;
            if (discriminator?.Type == global::AppStoreConnect.GameCenterDetailResponseIncludedItemDiscriminatorType.GameCenterGroups)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.GameCenterGroup), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.GameCenterGroup> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.GameCenterGroup)}");
                gameCenterGroups = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.GameCenterLeaderboardRelease? gameCenterLeaderboardReleases = default;
            if (discriminator?.Type == global::AppStoreConnect.GameCenterDetailResponseIncludedItemDiscriminatorType.GameCenterLeaderboardReleases)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.GameCenterLeaderboardRelease), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.GameCenterLeaderboardRelease> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.GameCenterLeaderboardRelease)}");
                gameCenterLeaderboardReleases = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.GameCenterLeaderboardSetRelease? gameCenterLeaderboardSetReleases = default;
            if (discriminator?.Type == global::AppStoreConnect.GameCenterDetailResponseIncludedItemDiscriminatorType.GameCenterLeaderboardSetReleases)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.GameCenterLeaderboardSetRelease), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.GameCenterLeaderboardSetRelease> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.GameCenterLeaderboardSetRelease)}");
                gameCenterLeaderboardSetReleases = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.GameCenterLeaderboardSet? gameCenterLeaderboardSets = default;
            if (discriminator?.Type == global::AppStoreConnect.GameCenterDetailResponseIncludedItemDiscriminatorType.GameCenterLeaderboardSets)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.GameCenterLeaderboardSet), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.GameCenterLeaderboardSet> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.GameCenterLeaderboardSet)}");
                gameCenterLeaderboardSets = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.GameCenterLeaderboard? gameCenterLeaderboards = default;
            if (discriminator?.Type == global::AppStoreConnect.GameCenterDetailResponseIncludedItemDiscriminatorType.GameCenterLeaderboards)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.GameCenterLeaderboard), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.GameCenterLeaderboard> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.GameCenterLeaderboard)}");
                gameCenterLeaderboards = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::AppStoreConnect.IncludedItem104(
                discriminator?.Type,
                appStoreVersions,

                apps,

                gameCenterAchievementReleases,

                gameCenterAchievements,

                gameCenterActivities,

                gameCenterActivityVersionReleases,

                gameCenterAppVersions,

                gameCenterChallengeVersionReleases,

                gameCenterChallenges,

                gameCenterGroups,

                gameCenterLeaderboardReleases,

                gameCenterLeaderboardSetReleases,

                gameCenterLeaderboardSets,

                gameCenterLeaderboards
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AppStoreConnect.IncludedItem104 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");
            typeInfoResolver = global::AppStoreConnect.AutoSDKJsonMetadataCachedResolver.Instance;

            if (value.IsAppStoreVersions)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppStoreVersion), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppStoreVersion?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.AppStoreVersion).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickAppStoreVersions(), typeInfo);
            }
            else if (value.IsApps)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.App), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.App?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.App).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickApps(), typeInfo);
            }
            else if (value.IsGameCenterAchievementReleases)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.GameCenterAchievementRelease), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.GameCenterAchievementRelease?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.GameCenterAchievementRelease).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickGameCenterAchievementReleases(), typeInfo);
            }
            else if (value.IsGameCenterAchievements)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.GameCenterAchievement), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.GameCenterAchievement?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.GameCenterAchievement).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickGameCenterAchievements(), typeInfo);
            }
            else if (value.IsGameCenterActivities)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.GameCenterActivity), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.GameCenterActivity?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.GameCenterActivity).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickGameCenterActivities(), typeInfo);
            }
            else if (value.IsGameCenterActivityVersionReleases)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.GameCenterActivityVersionRelease), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.GameCenterActivityVersionRelease?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.GameCenterActivityVersionRelease).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickGameCenterActivityVersionReleases(), typeInfo);
            }
            else if (value.IsGameCenterAppVersions)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.GameCenterAppVersion), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.GameCenterAppVersion?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.GameCenterAppVersion).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickGameCenterAppVersions(), typeInfo);
            }
            else if (value.IsGameCenterChallengeVersionReleases)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.GameCenterChallengeVersionRelease), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.GameCenterChallengeVersionRelease?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.GameCenterChallengeVersionRelease).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickGameCenterChallengeVersionReleases(), typeInfo);
            }
            else if (value.IsGameCenterChallenges)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.GameCenterChallenge), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.GameCenterChallenge?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.GameCenterChallenge).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickGameCenterChallenges(), typeInfo);
            }
            else if (value.IsGameCenterGroups)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.GameCenterGroup), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.GameCenterGroup?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.GameCenterGroup).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickGameCenterGroups(), typeInfo);
            }
            else if (value.IsGameCenterLeaderboardReleases)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.GameCenterLeaderboardRelease), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.GameCenterLeaderboardRelease?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.GameCenterLeaderboardRelease).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickGameCenterLeaderboardReleases(), typeInfo);
            }
            else if (value.IsGameCenterLeaderboardSetReleases)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.GameCenterLeaderboardSetRelease), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.GameCenterLeaderboardSetRelease?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.GameCenterLeaderboardSetRelease).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickGameCenterLeaderboardSetReleases(), typeInfo);
            }
            else if (value.IsGameCenterLeaderboardSets)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.GameCenterLeaderboardSet), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.GameCenterLeaderboardSet?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.GameCenterLeaderboardSet).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickGameCenterLeaderboardSets(), typeInfo);
            }
            else if (value.IsGameCenterLeaderboards)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.GameCenterLeaderboard), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.GameCenterLeaderboard?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.GameCenterLeaderboard).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickGameCenterLeaderboards(), typeInfo);
            }
        }
    }
}