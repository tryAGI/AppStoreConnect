
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_C6040A14FB2A71F4 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_C6040A14FB2A71F4 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_C6040A14FB2A71F4(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailPlayerType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailPlayerType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterScoreModerationType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterScoreModerationType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterScoreModerationRelationshipsPlayerDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterScoreModerationRelationshipsPlayerDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardsV2GameCenterScoreModerationsGetToManyRelatedFieldsGameCenterScoreModeration)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardsV2GameCenterScoreModerationsGetToManyRelatedFieldsGameCenterScoreModeration?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardsV2GameCenterScoreModerationsGetToManyRelatedFieldsGameCenterDetailPlayer)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardsV2GameCenterScoreModerationsGetToManyRelatedFieldsGameCenterDetailPlayer?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardsV2GameCenterScoreModerationsGetToManyRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardsV2GameCenterScoreModerationsGetToManyRelatedIncludeItem?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailPlayerType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailPlayerTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailPlayerType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailPlayerTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterScoreModerationType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterScoreModerationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterScoreModerationType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterScoreModerationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterScoreModerationRelationshipsPlayerDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterScoreModerationRelationshipsPlayerDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterScoreModerationRelationshipsPlayerDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterScoreModerationRelationshipsPlayerDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardsV2GameCenterScoreModerationsGetToManyRelatedFieldsGameCenterScoreModeration))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardsV2GameCenterScoreModerationsGetToManyRelatedFieldsGameCenterScoreModerationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardsV2GameCenterScoreModerationsGetToManyRelatedFieldsGameCenterScoreModeration?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardsV2GameCenterScoreModerationsGetToManyRelatedFieldsGameCenterScoreModerationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardsV2GameCenterScoreModerationsGetToManyRelatedFieldsGameCenterDetailPlayer))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardsV2GameCenterScoreModerationsGetToManyRelatedFieldsGameCenterDetailPlayerJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardsV2GameCenterScoreModerationsGetToManyRelatedFieldsGameCenterDetailPlayer?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardsV2GameCenterScoreModerationsGetToManyRelatedFieldsGameCenterDetailPlayerNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardsV2GameCenterScoreModerationsGetToManyRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardsV2GameCenterScoreModerationsGetToManyRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardsV2GameCenterScoreModerationsGetToManyRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardsV2GameCenterScoreModerationsGetToManyRelatedIncludeItemNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }
        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
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
                if (type == typeof(bool))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_Boolean(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterDetailPlayer))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterDetailPlayer(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterDetailPlayerAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterDetailPlayerAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterDetailPlayerType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterDetailPlayerType2(options);
                }
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterLeaderboardsV2GameCenterScoreModerationsGetToManyRelatedFieldsGameCenterDetailPlayer))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_GameCenterLeaderboardsV2GameCenterScoreModerationsGetToManyRelatedFieldsGameCenterDetailPlayer2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterLeaderboardsV2GameCenterScoreModerationsGetToManyRelatedFieldsGameCenterScoreModeration))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_GameCenterLeaderboardsV2GameCenterScoreModerationsGetToManyRelatedFieldsGameCenterScoreModeration2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterLeaderboardsV2GameCenterScoreModerationsGetToManyRelatedIncludeItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_GameCenterLeaderboardsV2GameCenterScoreModerationsGetToManyRelatedIncludeItem2(options);
                }
                #pragma warning restore CS0618
                if (type == typeof(global::AppStoreConnect.GameCenterScoreModeration))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_GameCenterScoreModeration(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterScoreModerationAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_GameCenterScoreModerationAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterScoreModerationRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_GameCenterScoreModerationRelationships(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterScoreModerationRelationshipsPlayer))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_GameCenterScoreModerationRelationshipsPlayer(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterScoreModerationRelationshipsPlayerData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_GameCenterScoreModerationRelationshipsPlayerData(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterScoreModerationRelationshipsPlayerDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_GameCenterScoreModerationRelationshipsPlayerDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterScoreModerationType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_GameCenterScoreModerationType2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterScoreModerationsResponse))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_GameCenterScoreModerationsResponse(options);
                }
                if (type == typeof(global::AppStoreConnect.PagedDocumentLinks))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_PagedDocumentLinks(options);
                }
                if (type == typeof(global::AppStoreConnect.PagingInformation))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_PagingInformation(options);
                }
                if (type == typeof(global::AppStoreConnect.PagingInformationPaging))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_PagingInformationPaging(options);
                }
                if (type == typeof(global::AppStoreConnect.ResourceLinks))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_ResourceLinks(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailPlayer>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_7F7A8936D552DB7A(options);
                }
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardsV2GameCenterScoreModerationsGetToManyRelatedFieldsGameCenterDetailPlayer>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_SourceGenerationContextMetadataType_C6C5D144DE6C5C38(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardsV2GameCenterScoreModerationsGetToManyRelatedFieldsGameCenterScoreModeration>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_SourceGenerationContextMetadataType_D79202D3CCBABB27(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardsV2GameCenterScoreModerationsGetToManyRelatedIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_SourceGenerationContextMetadataType_72F9B1CCA1A67A02(options);
                }
                #pragma warning restore CS0618
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterScoreModeration>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_E1F6280DF614B4AA(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<string>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_05BF36C073875770(options);
                }
                if (type == typeof(global::System.DateTime))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_DateTime(options);
                }
                if (type == typeof(int))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_Int32(options);
                }
                if (type == typeof(bool?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBoolean(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterDetailPlayerType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableGameCenterDetailPlayerType2(options);
                }
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterLeaderboardsV2GameCenterScoreModerationsGetToManyRelatedFieldsGameCenterDetailPlayer?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableGameCenterLeaderboardsV2GameCenterScoreModerationsGetToManyRelatedFieldsGameCenterDetailPlayer2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterLeaderboardsV2GameCenterScoreModerationsGetToManyRelatedFieldsGameCenterScoreModeration?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableGameCenterLeaderboardsV2GameCenterScoreModerationsGetToManyRelatedFieldsGameCenterScoreModeration2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterLeaderboardsV2GameCenterScoreModerationsGetToManyRelatedIncludeItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableGameCenterLeaderboardsV2GameCenterScoreModerationsGetToManyRelatedIncludeItem2(options);
                }
                #pragma warning restore CS0618
                if (type == typeof(global::AppStoreConnect.GameCenterScoreModerationRelationshipsPlayerDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableGameCenterScoreModerationRelationshipsPlayerDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterScoreModerationType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableGameCenterScoreModerationType2(options);
                }
                if (type == typeof(global::System.DateTime?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableDateTime(options);
                }
                if (type == typeof(int?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableInt32(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailPlayer>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_4BA19AE4335AF7A2(options);
                }
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterLeaderboardsV2GameCenterScoreModerationsGetToManyRelatedFieldsGameCenterDetailPlayer>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_98A79AF54F9AA5E4(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterLeaderboardsV2GameCenterScoreModerationsGetToManyRelatedFieldsGameCenterScoreModeration>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_CE7266706517FAE4(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterLeaderboardsV2GameCenterScoreModerationsGetToManyRelatedIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_4A552B93D527B577(options);
                }
                #pragma warning restore CS0618
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterScoreModeration>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_B6DE4BC2EB55A8F0(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<string>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_SourceGenerationContextMetadataType_3F34DBFD50DE05D2(options);
                }
                global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? additional = null;
                ResolveAdditionalTypeInfo(type, options, ref additional);
                return additional;
            }

            static partial void ResolveAdditionalTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options,
                ref global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? result);
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