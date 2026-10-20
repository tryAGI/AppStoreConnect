
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_A8D06D3A65134EC3 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_A8D06D3A65134EC3 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_A8D06D3A65134EC3(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.BuildUploadFileCreateRequestDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildUploadFileCreateRequestDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildUploadFileCreateRequestDataAttributesAssetType)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildUploadFileCreateRequestDataAttributesAssetType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildUploadFileCreateRequestDataAttributesUti)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildUploadFileCreateRequestDataAttributesUti?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildUploadFileCreateRequestDataRelationshipsBuildUploadDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildUploadFileCreateRequestDataRelationshipsBuildUploadDataType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.BuildUploadFileCreateRequestDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildUploadFileCreateRequestDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildUploadFileCreateRequestDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildUploadFileCreateRequestDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildUploadFileCreateRequestDataAttributesAssetType))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildUploadFileCreateRequestDataAttributesAssetTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildUploadFileCreateRequestDataAttributesAssetType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildUploadFileCreateRequestDataAttributesAssetTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildUploadFileCreateRequestDataAttributesUti))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildUploadFileCreateRequestDataAttributesUtiJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildUploadFileCreateRequestDataAttributesUti?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildUploadFileCreateRequestDataAttributesUtiNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildUploadFileCreateRequestDataRelationshipsBuildUploadDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildUploadFileCreateRequestDataRelationshipsBuildUploadDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildUploadFileCreateRequestDataRelationshipsBuildUploadDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildUploadFileCreateRequestDataRelationshipsBuildUploadDataTypeNullableJsonConverter();
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
                if (type == typeof(global::AppStoreConnect.BuildUploadFileCreateRequest))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildUploadFileCreateRequest(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildUploadFileCreateRequestData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildUploadFileCreateRequestData(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildUploadFileCreateRequestDataAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildUploadFileCreateRequestDataAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildUploadFileCreateRequestDataAttributesAssetType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildUploadFileCreateRequestDataAttributesAssetType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildUploadFileCreateRequestDataAttributesUti))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildUploadFileCreateRequestDataAttributesUti2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildUploadFileCreateRequestDataRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildUploadFileCreateRequestDataRelationships(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildUploadFileCreateRequestDataRelationshipsBuildUpload))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildUploadFileCreateRequestDataRelationshipsBuildUpload(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildUploadFileCreateRequestDataRelationshipsBuildUploadData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildUploadFileCreateRequestDataRelationshipsBuildUploadData(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildUploadFileCreateRequestDataRelationshipsBuildUploadDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildUploadFileCreateRequestDataRelationshipsBuildUploadDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildUploadFileCreateRequestDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildUploadFileCreateRequestDataType2(options);
                }
                if (type == typeof(long))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_Int64(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildUploadFileCreateRequestDataAttributesAssetType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBuildUploadFileCreateRequestDataAttributesAssetType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildUploadFileCreateRequestDataAttributesUti?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBuildUploadFileCreateRequestDataAttributesUti2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildUploadFileCreateRequestDataRelationshipsBuildUploadDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBuildUploadFileCreateRequestDataRelationshipsBuildUploadDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildUploadFileCreateRequestDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBuildUploadFileCreateRequestDataType2(options);
                }
                if (type == typeof(long?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableInt64(options);
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