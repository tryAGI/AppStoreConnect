
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull
    )]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildUploadFileResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildUploadFileCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildUploadFileCreateRequestData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildUploadFileCreateRequestDataType), TypeInfoPropertyName = "BuildUploadFileCreateRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildUploadFileCreateRequestDataAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildUploadFileCreateRequestDataAttributesAssetType), TypeInfoPropertyName = "BuildUploadFileCreateRequestDataAttributesAssetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildUploadFileCreateRequestDataAttributesUti), TypeInfoPropertyName = "BuildUploadFileCreateRequestDataAttributesUti2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildUploadFileCreateRequestDataRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildUploadFileCreateRequestDataRelationshipsBuildUpload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildUploadFileCreateRequestDataRelationshipsBuildUploadData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildUploadFileCreateRequestDataRelationshipsBuildUploadDataType), TypeInfoPropertyName = "BuildUploadFileCreateRequestDataRelationshipsBuildUploadDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildUploadFileUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildUploadFileUpdateRequestData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildUploadFileUpdateRequestDataType), TypeInfoPropertyName = "BuildUploadFileUpdateRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildUploadFileUpdateRequestDataAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildUploadFilesGetInstanceFieldsBuildUploadFile>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildUploadFilesGetInstanceFieldsBuildUploadFile), TypeInfoPropertyName = "BuildUploadFilesGetInstanceFieldsBuildUploadFile2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildUploadFileCreateRequestDataType?), TypeInfoPropertyName = "NullableBuildUploadFileCreateRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildUploadFileCreateRequestDataAttributesAssetType?), TypeInfoPropertyName = "NullableBuildUploadFileCreateRequestDataAttributesAssetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildUploadFileCreateRequestDataAttributesUti?), TypeInfoPropertyName = "NullableBuildUploadFileCreateRequestDataAttributesUti2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildUploadFileCreateRequestDataRelationshipsBuildUploadDataType?), TypeInfoPropertyName = "NullableBuildUploadFileCreateRequestDataRelationshipsBuildUploadDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildUploadFileUpdateRequestDataType?), TypeInfoPropertyName = "NullableBuildUploadFileUpdateRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildUploadFilesGetInstanceFieldsBuildUploadFile?), TypeInfoPropertyName = "NullableBuildUploadFilesGetInstanceFieldsBuildUploadFile2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildUploadFilesGetInstanceFieldsBuildUploadFile>))]
    internal sealed partial class BuildUploadFilesSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BuildUploadFilesSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static BuildUploadFilesSourceGenerationContext Default { get; } = new(DefaultOptions);

        private BuildUploadFilesSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            global::AppStoreConnect.PartitionCoreSourceGenerationContext.AddConverters(options);
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

                    || typeToConvert == typeof(global::AppStoreConnect.BuildUploadFileCreateRequestDataRelationshipsBuildUploadDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildUploadFileUpdateRequestDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildUploadFileUpdateRequestDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildUploadFilesGetInstanceFieldsBuildUploadFile)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildUploadFilesGetInstanceFieldsBuildUploadFile?);
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

                if (typeToConvert == typeof(global::AppStoreConnect.BuildUploadFileUpdateRequestDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildUploadFileUpdateRequestDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildUploadFileUpdateRequestDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildUploadFileUpdateRequestDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildUploadFilesGetInstanceFieldsBuildUploadFile))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildUploadFilesGetInstanceFieldsBuildUploadFileJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildUploadFilesGetInstanceFieldsBuildUploadFile?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildUploadFilesGetInstanceFieldsBuildUploadFileNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[2];

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
                    0 => new BuildUploadFilesSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),

                    1 => global::AppStoreConnect.PartitionCoreSourceGenerationContext.TypeInfoResolver,
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}