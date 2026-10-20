
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_DC6DAF74FB766BD2 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_DC6DAF74FB766BD2 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_DC6DAF74FB766BD2(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivitie)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivitie?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterDetail)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterDetail?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterGroup)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterGroup?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterAchievement)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterAchievement?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboard)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboard?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivityVersion)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivityVersion?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterActivitiesGetToManyRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterActivitiesGetToManyRelatedIncludeItem?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivitie))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivitieJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivitie?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivitieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterDetail))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterDetailJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterDetail?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterDetailNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterGroup))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterGroupJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterGroup?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterGroupNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterAchievement))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterAchievementJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterAchievement?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterAchievementNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboard))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboardJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboard?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboardNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivityVersion))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivityVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivityVersion?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivityVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterActivitiesGetToManyRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterActivitiesGetToManyRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterActivitiesGetToManyRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterActivitiesGetToManyRelatedIncludeItemNullableJsonConverter();
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
                if (type == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterAchievement))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterAchievement2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivitie))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivitie2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivityVersion))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivityVersion2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterDetail))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterDetail2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterGroup))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterGroup2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboard))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboard2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterActivitiesGetToManyRelatedIncludeItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_GameCenterGroupsGameCenterActivitiesGetToManyRelatedIncludeItem2(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterAchievement>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_SourceGenerationContextMetadataType_6B4C54FBCBE1C4F5(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivitie>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_SourceGenerationContextMetadataType_80D732D1F5397092(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivityVersion>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_SourceGenerationContextMetadataType_0E35C1B81BB48E85(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterDetail>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_SourceGenerationContextMetadataType_B89FE490961C4C02(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterGroup>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_SourceGenerationContextMetadataType_4AA168F4DDAB8DC0(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboard>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_SourceGenerationContextMetadataType_A9FD696108BDDCA7(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterActivitiesGetToManyRelatedIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_SourceGenerationContextMetadataType_60787165251B1472(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterAchievement?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableGameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterAchievement2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivitie?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableGameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivitie2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivityVersion?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableGameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivityVersion2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterDetail?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableGameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterDetail2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterGroup?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableGameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterGroup2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboard?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableGameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboard2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterActivitiesGetToManyRelatedIncludeItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableGameCenterGroupsGameCenterActivitiesGetToManyRelatedIncludeItem2(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterAchievement>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_DA030AB93C6E21D5(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivitie>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_07E4B1A962C654C8(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivityVersion>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_F0BB544E005B6C44(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterDetail>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_53504A7825DD6067(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterGroup>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_881724A55A919D3C(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboard>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_A28661A395C13E5F(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupsGameCenterActivitiesGetToManyRelatedIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_AC1FBCE261F95F75(options);
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