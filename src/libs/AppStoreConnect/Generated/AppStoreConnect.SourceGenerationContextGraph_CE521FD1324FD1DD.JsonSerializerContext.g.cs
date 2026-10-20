
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_CE521FD1324FD1DD : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_CE521FD1324FD1DD Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_CE521FD1324FD1DD(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterDetail)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterDetail?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsApp)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsApp?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterAppVersion)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterAppVersion?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterGroup)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterGroup?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterLeaderboard)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterLeaderboard?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterLeaderboardSet)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterLeaderboardSet?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterAchievement)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterAchievement?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterActivitie)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterActivitie?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterChallenge)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterChallenge?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterAchievementRelease)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterAchievementRelease?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterActivityVersionRelease)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterActivityVersionRelease?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterChallengeVersionRelease)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterChallengeVersionRelease?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterLeaderboardRelease)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterLeaderboardRelease?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterLeaderboardSetRelease)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterLeaderboardSetRelease?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsAppStoreVersion)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsAppStoreVersion?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedIncludeItem?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterDetail))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterDetailJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterDetail?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterDetailNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsApp))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGameCenterDetailGetToOneRelatedFieldsAppJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsApp?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGameCenterDetailGetToOneRelatedFieldsAppNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterAppVersion))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterAppVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterAppVersion?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterAppVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterGroup))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterGroupJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterGroup?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterGroupNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterLeaderboard))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterLeaderboardJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterLeaderboard?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterLeaderboardNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterLeaderboardSet))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterLeaderboardSetJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterLeaderboardSet?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterLeaderboardSetNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterAchievement))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterAchievementJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterAchievement?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterAchievementNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterActivitie))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterActivitieJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterActivitie?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterActivitieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterChallenge))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterChallengeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterChallenge?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterChallengeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterAchievementRelease))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterAchievementReleaseJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterAchievementRelease?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterAchievementReleaseNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterActivityVersionRelease))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterActivityVersionReleaseJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterActivityVersionRelease?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterActivityVersionReleaseNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterChallengeVersionRelease))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterChallengeVersionReleaseJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterChallengeVersionRelease?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterChallengeVersionReleaseNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterLeaderboardRelease))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterLeaderboardReleaseJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterLeaderboardRelease?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterLeaderboardReleaseNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterLeaderboardSetRelease))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterLeaderboardSetReleaseJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterLeaderboardSetRelease?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterLeaderboardSetReleaseNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsAppStoreVersion))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGameCenterDetailGetToOneRelatedFieldsAppStoreVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsAppStoreVersion?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGameCenterDetailGetToOneRelatedFieldsAppStoreVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGameCenterDetailGetToOneRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGameCenterDetailGetToOneRelatedIncludeItemNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }
        private sealed class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::System.Collections.Generic.Dictionary<string, string>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_FC0ACBA26C044EC8(options);
                }
                if (type == typeof(global::System.Collections.Generic.Dictionary<string, object>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_8219E7AD6AEFA4B4(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<object>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_92E1ACA86984772C(options);
                }
                if (type == typeof(global::System.Text.Json.JsonElement?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_NullableJsonElement(options);
                }
                if (type == typeof(global::System.Collections.Generic.IDictionary<string, object>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_7024F6984ED20EB8(options);
                }
                if (type == typeof(string))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_String(options);
                }
                if (type == typeof(object))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_Object(options);
                }
                if (type == typeof(global::System.Text.Json.JsonElement))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_JsonElement(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsApp))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppsGameCenterDetailGetToOneRelatedFieldsApp2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsAppStoreVersion))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppsGameCenterDetailGetToOneRelatedFieldsAppStoreVersion2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterAchievement))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppsGameCenterDetailGetToOneRelatedFieldsGameCenterAchievement2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterAchievementRelease))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppsGameCenterDetailGetToOneRelatedFieldsGameCenterAchievementRelease2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterActivitie))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppsGameCenterDetailGetToOneRelatedFieldsGameCenterActivitie2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterActivityVersionRelease))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppsGameCenterDetailGetToOneRelatedFieldsGameCenterActivityVersionRelease2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterAppVersion))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppsGameCenterDetailGetToOneRelatedFieldsGameCenterAppVersion2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterChallenge))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppsGameCenterDetailGetToOneRelatedFieldsGameCenterChallenge2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterChallengeVersionRelease))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppsGameCenterDetailGetToOneRelatedFieldsGameCenterChallengeVersionRelease2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterDetail))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppsGameCenterDetailGetToOneRelatedFieldsGameCenterDetail2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterGroup))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppsGameCenterDetailGetToOneRelatedFieldsGameCenterGroup2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterLeaderboard))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppsGameCenterDetailGetToOneRelatedFieldsGameCenterLeaderboard2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterLeaderboardRelease))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppsGameCenterDetailGetToOneRelatedFieldsGameCenterLeaderboardRelease2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterLeaderboardSet))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppsGameCenterDetailGetToOneRelatedFieldsGameCenterLeaderboardSet2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterLeaderboardSetRelease))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppsGameCenterDetailGetToOneRelatedFieldsGameCenterLeaderboardSetRelease2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedIncludeItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppsGameCenterDetailGetToOneRelatedIncludeItem2(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsApp>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_84BFD173D6683B5A(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsAppStoreVersion>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_C0D158657EEB1C14(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterAchievement>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_7A2D9F7391E0339E(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterAchievementRelease>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_94844AC66DCB8F15(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterActivitie>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_79F0598642DAD5BB(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterActivityVersionRelease>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_2158CCFED7FE532D(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterAppVersion>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_4674F7371C5F377B(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterChallenge>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_2B6E08D31BBF500F(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterChallengeVersionRelease>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_82553FB57B27D47B(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterDetail>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_DE596FFED2AAC568(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterGroup>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_16843BB5C86547E3(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterLeaderboard>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_A118E6DB1596B3CF(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterLeaderboardRelease>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_A9BD1CCECAE31A71(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterLeaderboardSet>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_7F5D5C29C5AE25F2(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterLeaderboardSetRelease>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_857968F9EAF7BA1E(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_E5828110185BB70B(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsApp?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppsGameCenterDetailGetToOneRelatedFieldsApp2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsAppStoreVersion?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppsGameCenterDetailGetToOneRelatedFieldsAppStoreVersion2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterAchievement?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppsGameCenterDetailGetToOneRelatedFieldsGameCenterAchievement2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterAchievementRelease?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppsGameCenterDetailGetToOneRelatedFieldsGameCenterAchievementRelease2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterActivitie?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppsGameCenterDetailGetToOneRelatedFieldsGameCenterActivitie2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterActivityVersionRelease?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppsGameCenterDetailGetToOneRelatedFieldsGameCenterActivityVersionRelease2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterAppVersion?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppsGameCenterDetailGetToOneRelatedFieldsGameCenterAppVersion2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterChallenge?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppsGameCenterDetailGetToOneRelatedFieldsGameCenterChallenge2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterChallengeVersionRelease?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppsGameCenterDetailGetToOneRelatedFieldsGameCenterChallengeVersionRelease2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterDetail?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppsGameCenterDetailGetToOneRelatedFieldsGameCenterDetail2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterGroup?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppsGameCenterDetailGetToOneRelatedFieldsGameCenterGroup2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterLeaderboard?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppsGameCenterDetailGetToOneRelatedFieldsGameCenterLeaderboard2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterLeaderboardRelease?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppsGameCenterDetailGetToOneRelatedFieldsGameCenterLeaderboardRelease2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterLeaderboardSet?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppsGameCenterDetailGetToOneRelatedFieldsGameCenterLeaderboardSet2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterLeaderboardSetRelease?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppsGameCenterDetailGetToOneRelatedFieldsGameCenterLeaderboardSetRelease2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedIncludeItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppsGameCenterDetailGetToOneRelatedIncludeItem2(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsApp>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_F4388FE1D942B12B(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsAppStoreVersion>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_AA25B0BE6B6C33A1(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterAchievement>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_E36B8ACF0785BFE1(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterAchievementRelease>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_8C32FF5606532D44(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterActivitie>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_14F0F615A6747A3A(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterActivityVersionRelease>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_E6F2ED7867BA0C86(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterAppVersion>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_6B085AE3835A029D(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterChallenge>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_92555B080A53F89C(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterChallengeVersionRelease>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_DE2880F4AF745138(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterDetail>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_E81032F22774391B(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterGroup>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_E883E038CED3430A(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterLeaderboard>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_98063E66CBE4FE85(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterLeaderboardRelease>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_E4BB27E3EB4DA3CC(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterLeaderboardSet>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_8EBE463176FC82EB(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterLeaderboardSetRelease>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_57BAE874932FF98C(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_C17A1441710C822F(options);
                }
                return null;
            }
        }


        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

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
                    0 => new SharedMetadataResolver(),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}