
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_752B5EBBFC734F15 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_752B5EBBFC734F15 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_752B5EBBFC734F15(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetUploadFileType)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetUploadFileType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetUploadFileAttributesAssetType)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetUploadFileAttributesAssetType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppMediaAssetStateState)

                    || typeToConvert == typeof(global::AppStoreConnect.AppMediaAssetStateState?)

                    || typeToConvert == typeof(global::AppStoreConnect.ChecksumAlgorithm)

                    || typeToConvert == typeof(global::AppStoreConnect.ChecksumAlgorithm?)

                    || typeToConvert == typeof(global::AppStoreConnect.ChecksumsCompositeAlgorithm)

                    || typeToConvert == typeof(global::AppStoreConnect.ChecksumsCompositeAlgorithm?)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionsBackgroundAssetUploadFilesGetToManyRelatedFieldsBackgroundAssetUploadFile)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionsBackgroundAssetUploadFilesGetToManyRelatedFieldsBackgroundAssetUploadFile?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetUploadFileType))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetUploadFileTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetUploadFileType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetUploadFileTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetUploadFileAttributesAssetType))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetUploadFileAttributesAssetTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetUploadFileAttributesAssetType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetUploadFileAttributesAssetTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppMediaAssetStateState))
                {
                    return new global::AppStoreConnect.JsonConverters.AppMediaAssetStateStateJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppMediaAssetStateState?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppMediaAssetStateStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ChecksumAlgorithm))
                {
                    return new global::AppStoreConnect.JsonConverters.ChecksumAlgorithmJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ChecksumAlgorithm?))
                {
                    return new global::AppStoreConnect.JsonConverters.ChecksumAlgorithmNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ChecksumsCompositeAlgorithm))
                {
                    return new global::AppStoreConnect.JsonConverters.ChecksumsCompositeAlgorithmJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ChecksumsCompositeAlgorithm?))
                {
                    return new global::AppStoreConnect.JsonConverters.ChecksumsCompositeAlgorithmNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionsBackgroundAssetUploadFilesGetToManyRelatedFieldsBackgroundAssetUploadFile))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetVersionsBackgroundAssetUploadFilesGetToManyRelatedFieldsBackgroundAssetUploadFileJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionsBackgroundAssetUploadFilesGetToManyRelatedFieldsBackgroundAssetUploadFile?))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetVersionsBackgroundAssetUploadFilesGetToManyRelatedFieldsBackgroundAssetUploadFileNullableJsonConverter();
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
                if (type == typeof(global::AppStoreConnect.AppMediaAssetState))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppMediaAssetState(options);
                }
                if (type == typeof(global::AppStoreConnect.AppMediaAssetStateState))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppMediaAssetStateState2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppMediaStateError))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppMediaStateError(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetUploadFile))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BackgroundAssetUploadFile(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetUploadFileAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BackgroundAssetUploadFileAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetUploadFileAttributesAssetType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BackgroundAssetUploadFileAttributesAssetType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetUploadFileType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BackgroundAssetUploadFileType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetUploadFilesResponse))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BackgroundAssetUploadFilesResponse(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetVersionsBackgroundAssetUploadFilesGetToManyRelatedFieldsBackgroundAssetUploadFile))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_BackgroundAssetVersionsBackgroundAssetUploadFilesGetToManyRelatedFieldsBackgroundAssetUploadFile2(options);
                }
                if (type == typeof(global::AppStoreConnect.ChecksumAlgorithm))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_ChecksumAlgorithm2(options);
                }
                if (type == typeof(global::AppStoreConnect.Checksums))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_Checksums(options);
                }
                if (type == typeof(global::AppStoreConnect.ChecksumsComposite))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_ChecksumsComposite(options);
                }
                if (type == typeof(global::AppStoreConnect.ChecksumsCompositeAlgorithm))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_ChecksumsCompositeAlgorithm2(options);
                }
                if (type == typeof(global::AppStoreConnect.ChecksumsFile))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_ChecksumsFile(options);
                }
                if (type == typeof(global::AppStoreConnect.DeliveryFileUploadOperation))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_DeliveryFileUploadOperation(options);
                }
                if (type == typeof(global::AppStoreConnect.HttpHeader))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_HttpHeader(options);
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
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppMediaStateError>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_7E9D192989E995BF(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BackgroundAssetUploadFile>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_4225931383076522(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BackgroundAssetVersionsBackgroundAssetUploadFilesGetToManyRelatedFieldsBackgroundAssetUploadFile>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_8CBB6794B740FC21(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.DeliveryFileUploadOperation>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_781A3B4F64735229(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.HttpHeader>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_BCE13B3326F5CA8F(options);
                }
                if (type == typeof(global::System.DateTime))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_DateTime(options);
                }
                if (type == typeof(int))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_Int32(options);
                }
                if (type == typeof(long))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_Int64(options);
                }
                if (type == typeof(global::AppStoreConnect.AppMediaAssetStateState?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppMediaAssetStateState2(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetUploadFileAttributesAssetType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBackgroundAssetUploadFileAttributesAssetType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetUploadFileType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBackgroundAssetUploadFileType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetVersionsBackgroundAssetUploadFilesGetToManyRelatedFieldsBackgroundAssetUploadFile?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableBackgroundAssetVersionsBackgroundAssetUploadFilesGetToManyRelatedFieldsBackgroundAssetUploadFile2(options);
                }
                if (type == typeof(global::AppStoreConnect.ChecksumAlgorithm?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableChecksumAlgorithm2(options);
                }
                if (type == typeof(global::AppStoreConnect.ChecksumsCompositeAlgorithm?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableChecksumsCompositeAlgorithm2(options);
                }
                if (type == typeof(global::System.DateTime?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableDateTime(options);
                }
                if (type == typeof(int?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableInt32(options);
                }
                if (type == typeof(long?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableInt64(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppMediaStateError>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_AE112F1FF3B11297(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BackgroundAssetUploadFile>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_CB01D5F3FEB38366(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BackgroundAssetVersionsBackgroundAssetUploadFilesGetToManyRelatedFieldsBackgroundAssetUploadFile>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_3B50B6072875E098(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.DeliveryFileUploadOperation>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_F6318151BA819E6D(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.HttpHeader>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_1947F16F30F1622D(options);
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