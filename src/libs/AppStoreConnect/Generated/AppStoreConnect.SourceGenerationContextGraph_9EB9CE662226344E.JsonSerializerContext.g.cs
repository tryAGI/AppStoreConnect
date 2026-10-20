
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_9EB9CE662226344E : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_9EB9CE662226344E Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_9EB9CE662226344E(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeImageCreateRequestDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeImageCreateRequestDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeImageCreateRequestDataRelationshipsLocalizationDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeImageCreateRequestDataRelationshipsLocalizationDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeImageCreateRequestDataRelationshipsVersionDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeImageCreateRequestDataRelationshipsVersionDataType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeImageCreateRequestDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterChallengeImageCreateRequestDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeImageCreateRequestDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterChallengeImageCreateRequestDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeImageCreateRequestDataRelationshipsLocalizationDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterChallengeImageCreateRequestDataRelationshipsLocalizationDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeImageCreateRequestDataRelationshipsLocalizationDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterChallengeImageCreateRequestDataRelationshipsLocalizationDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeImageCreateRequestDataRelationshipsVersionDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterChallengeImageCreateRequestDataRelationshipsVersionDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeImageCreateRequestDataRelationshipsVersionDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterChallengeImageCreateRequestDataRelationshipsVersionDataTypeNullableJsonConverter();
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
                if (type == typeof(global::AppStoreConnect.GameCenterChallengeImageCreateRequest))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterChallengeImageCreateRequest(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterChallengeImageCreateRequestData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterChallengeImageCreateRequestData(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterChallengeImageCreateRequestDataAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterChallengeImageCreateRequestDataAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterChallengeImageCreateRequestDataRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterChallengeImageCreateRequestDataRelationships(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterChallengeImageCreateRequestDataRelationshipsLocalization))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterChallengeImageCreateRequestDataRelationshipsLocalization(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterChallengeImageCreateRequestDataRelationshipsLocalizationData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterChallengeImageCreateRequestDataRelationshipsLocalizationData(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterChallengeImageCreateRequestDataRelationshipsLocalizationDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterChallengeImageCreateRequestDataRelationshipsLocalizationDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterChallengeImageCreateRequestDataRelationshipsVersion))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterChallengeImageCreateRequestDataRelationshipsVersion(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterChallengeImageCreateRequestDataRelationshipsVersionData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterChallengeImageCreateRequestDataRelationshipsVersionData(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterChallengeImageCreateRequestDataRelationshipsVersionDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterChallengeImageCreateRequestDataRelationshipsVersionDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterChallengeImageCreateRequestDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterChallengeImageCreateRequestDataType2(options);
                }
                if (type == typeof(int))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_Int32(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterChallengeImageCreateRequestDataRelationshipsLocalizationDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableGameCenterChallengeImageCreateRequestDataRelationshipsLocalizationDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterChallengeImageCreateRequestDataRelationshipsVersionDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableGameCenterChallengeImageCreateRequestDataRelationshipsVersionDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterChallengeImageCreateRequestDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableGameCenterChallengeImageCreateRequestDataType2(options);
                }
                if (type == typeof(int?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableInt32(options);
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