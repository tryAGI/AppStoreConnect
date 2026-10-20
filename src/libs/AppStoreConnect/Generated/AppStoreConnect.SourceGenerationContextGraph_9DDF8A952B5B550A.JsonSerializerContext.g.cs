
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_9DDF8A952B5B550A : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_9DDF8A952B5B550A Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_9DDF8A952B5B550A(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboard)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboard?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterDetail)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterDetail?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterGroup)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterGroup?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboardSet)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboardSet?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterActivitie)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterActivitie?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterChallenge)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterChallenge?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboardVersion)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboardVersion?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedIncludeItem?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboard))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboardJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboard?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboardNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterDetail))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterDetailJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterDetail?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterDetailNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterGroup))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterGroupJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterGroup?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterGroupNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboardSet))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboardSetJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboardSet?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboardSetNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterActivitie))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterActivitieJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterActivitie?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterActivitieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterChallenge))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterChallengeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterChallenge?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterChallengeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboardVersion))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboardVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboardVersion?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboardVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedIncludeItemNullableJsonConverter();
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
                if (type == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterActivitie))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterActivitie2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterChallenge))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterChallenge2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterDetail))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterDetail2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterGroup))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterGroup2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboard))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboard2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboardSet))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboardSet2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboardVersion))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboardVersion2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedIncludeItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedIncludeItem2(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterActivitie>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_SourceGenerationContextMetadataType_4683891EAB2BE3D2(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterChallenge>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_SourceGenerationContextMetadataType_755459B574419D3F(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterDetail>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_SourceGenerationContextMetadataType_9880E88100595E3C(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterGroup>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_SourceGenerationContextMetadataType_A162EC3740EE69FC(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboard>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_SourceGenerationContextMetadataType_A37EFDE29412F7F7(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboardSet>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_SourceGenerationContextMetadataType_25EC31487E2D4C4E(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboardVersion>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_SourceGenerationContextMetadataType_0206859DF16FEF7B(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_SourceGenerationContextMetadataType_4D309B035B0D54BE(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterActivitie?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableGameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterActivitie2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterChallenge?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableGameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterChallenge2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterDetail?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableGameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterDetail2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterGroup?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableGameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterGroup2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboard?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableGameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboard2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboardSet?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableGameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboardSet2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboardVersion?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableGameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboardVersion2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedIncludeItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableGameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedIncludeItem2(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterActivitie>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_D48BBCAA96CED13B(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterChallenge>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_215097831AA69452(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterDetail>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_D862250282BFF435(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterGroup>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_4AB6F67B460AEB75(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboard>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_EA8A050B9F34FEC8(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboardSet>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_A0772ECD39FC15C4(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboardVersion>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_227E84F52BFCEB7F(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_F6992C6DC25E06E4(options);
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