
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_2A9D74050693EB62 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_2A9D74050693EB62 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_2A9D74050693EB62(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.AlternativeDistributionPackageVersionType)

                    || typeToConvert == typeof(global::AppStoreConnect.AlternativeDistributionPackageVersionType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AlternativeDistributionPackageVersionAttributesState)

                    || typeToConvert == typeof(global::AppStoreConnect.AlternativeDistributionPackageVersionAttributesState?)

                    || typeToConvert == typeof(global::AppStoreConnect.AlternativeDistributionPackageVersionRelationshipsVariantsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AlternativeDistributionPackageVersionRelationshipsVariantsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AlternativeDistributionPackageVersionRelationshipsDeltasDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AlternativeDistributionPackageVersionRelationshipsDeltasDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AlternativeDistributionPackageVersionRelationshipsAlternativeDistributionPackageDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AlternativeDistributionPackageVersionRelationshipsAlternativeDistributionPackageDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AlternativeDistributionPackageType)

                    || typeToConvert == typeof(global::AppStoreConnect.AlternativeDistributionPackageType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AlternativeDistributionPackageRelationshipsVersionsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AlternativeDistributionPackageRelationshipsVersionsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.ChecksumAlgorithm)

                    || typeToConvert == typeof(global::AppStoreConnect.ChecksumAlgorithm?)

                    || typeToConvert == typeof(global::AppStoreConnect.ChecksumsCompositeAlgorithm)

                    || typeToConvert == typeof(global::AppStoreConnect.ChecksumsCompositeAlgorithm?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.AlternativeDistributionPackageVersionType))
                {
                    return new global::AppStoreConnect.JsonConverters.AlternativeDistributionPackageVersionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AlternativeDistributionPackageVersionType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AlternativeDistributionPackageVersionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AlternativeDistributionPackageVersionAttributesState))
                {
                    return new global::AppStoreConnect.JsonConverters.AlternativeDistributionPackageVersionAttributesStateJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AlternativeDistributionPackageVersionAttributesState?))
                {
                    return new global::AppStoreConnect.JsonConverters.AlternativeDistributionPackageVersionAttributesStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AlternativeDistributionPackageVersionRelationshipsVariantsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AlternativeDistributionPackageVersionRelationshipsVariantsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AlternativeDistributionPackageVersionRelationshipsVariantsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AlternativeDistributionPackageVersionRelationshipsVariantsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AlternativeDistributionPackageVersionRelationshipsDeltasDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AlternativeDistributionPackageVersionRelationshipsDeltasDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AlternativeDistributionPackageVersionRelationshipsDeltasDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AlternativeDistributionPackageVersionRelationshipsDeltasDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AlternativeDistributionPackageVersionRelationshipsAlternativeDistributionPackageDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AlternativeDistributionPackageVersionRelationshipsAlternativeDistributionPackageDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AlternativeDistributionPackageVersionRelationshipsAlternativeDistributionPackageDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AlternativeDistributionPackageVersionRelationshipsAlternativeDistributionPackageDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AlternativeDistributionPackageType))
                {
                    return new global::AppStoreConnect.JsonConverters.AlternativeDistributionPackageTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AlternativeDistributionPackageType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AlternativeDistributionPackageTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AlternativeDistributionPackageRelationshipsVersionsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AlternativeDistributionPackageRelationshipsVersionsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AlternativeDistributionPackageRelationshipsVersionsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AlternativeDistributionPackageRelationshipsVersionsDataItemTypeNullableJsonConverter();
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
                if (type == typeof(global::AppStoreConnect.AlternativeDistributionPackage))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AlternativeDistributionPackage(options);
                }
                if (type == typeof(global::AppStoreConnect.AlternativeDistributionPackageAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AlternativeDistributionPackageAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.AlternativeDistributionPackageRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AlternativeDistributionPackageRelationships(options);
                }
                if (type == typeof(global::AppStoreConnect.AlternativeDistributionPackageRelationshipsVersions))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AlternativeDistributionPackageRelationshipsVersions(options);
                }
                if (type == typeof(global::AppStoreConnect.AlternativeDistributionPackageRelationshipsVersionsDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AlternativeDistributionPackageRelationshipsVersionsDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.AlternativeDistributionPackageRelationshipsVersionsDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AlternativeDistributionPackageRelationshipsVersionsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AlternativeDistributionPackageResponse))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AlternativeDistributionPackageResponse(options);
                }
                if (type == typeof(global::AppStoreConnect.AlternativeDistributionPackageType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AlternativeDistributionPackageType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AlternativeDistributionPackageVersion))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AlternativeDistributionPackageVersion(options);
                }
                if (type == typeof(global::AppStoreConnect.AlternativeDistributionPackageVersionAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AlternativeDistributionPackageVersionAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.AlternativeDistributionPackageVersionAttributesState))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AlternativeDistributionPackageVersionAttributesState2(options);
                }
                if (type == typeof(global::AppStoreConnect.AlternativeDistributionPackageVersionRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AlternativeDistributionPackageVersionRelationships(options);
                }
                if (type == typeof(global::AppStoreConnect.AlternativeDistributionPackageVersionRelationshipsAlternativeDistributionPackage))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AlternativeDistributionPackageVersionRelationshipsAlternativeDistributionPackage(options);
                }
                if (type == typeof(global::AppStoreConnect.AlternativeDistributionPackageVersionRelationshipsAlternativeDistributionPackageData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AlternativeDistributionPackageVersionRelationshipsAlternativeDistributionPackageData(options);
                }
                if (type == typeof(global::AppStoreConnect.AlternativeDistributionPackageVersionRelationshipsAlternativeDistributionPackageDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AlternativeDistributionPackageVersionRelationshipsAlternativeDistributionPackageDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AlternativeDistributionPackageVersionRelationshipsDeltas))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AlternativeDistributionPackageVersionRelationshipsDeltas(options);
                }
                if (type == typeof(global::AppStoreConnect.AlternativeDistributionPackageVersionRelationshipsDeltasDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AlternativeDistributionPackageVersionRelationshipsDeltasDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.AlternativeDistributionPackageVersionRelationshipsDeltasDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AlternativeDistributionPackageVersionRelationshipsDeltasDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AlternativeDistributionPackageVersionRelationshipsVariants))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AlternativeDistributionPackageVersionRelationshipsVariants(options);
                }
                if (type == typeof(global::AppStoreConnect.AlternativeDistributionPackageVersionRelationshipsVariantsDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AlternativeDistributionPackageVersionRelationshipsVariantsDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.AlternativeDistributionPackageVersionRelationshipsVariantsDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AlternativeDistributionPackageVersionRelationshipsVariantsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AlternativeDistributionPackageVersionType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AlternativeDistributionPackageVersionType2(options);
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
                if (type == typeof(global::AppStoreConnect.DocumentLinks))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_DocumentLinks(options);
                }
                if (type == typeof(global::AppStoreConnect.PagingInformation))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_PagingInformation(options);
                }
                if (type == typeof(global::AppStoreConnect.PagingInformationPaging))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_PagingInformationPaging(options);
                }
                if (type == typeof(global::AppStoreConnect.RelationshipLinks))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_RelationshipLinks(options);
                }
                if (type == typeof(global::AppStoreConnect.ResourceLinks))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_ResourceLinks(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AlternativeDistributionPackageRelationshipsVersionsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_8EB6547F90E01748(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AlternativeDistributionPackageVersion>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_10C019CA5308F1F9(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AlternativeDistributionPackageVersionRelationshipsDeltasDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_5AC5A98F4FBB8F88(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AlternativeDistributionPackageVersionRelationshipsVariantsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_EC719EDBD9A51C92(options);
                }
                if (type == typeof(global::System.DateTime))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_DateTime(options);
                }
                if (type == typeof(int))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_Int32(options);
                }
                if (type == typeof(global::AppStoreConnect.AlternativeDistributionPackageRelationshipsVersionsDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAlternativeDistributionPackageRelationshipsVersionsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AlternativeDistributionPackageType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAlternativeDistributionPackageType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AlternativeDistributionPackageVersionAttributesState?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAlternativeDistributionPackageVersionAttributesState2(options);
                }
                if (type == typeof(global::AppStoreConnect.AlternativeDistributionPackageVersionRelationshipsAlternativeDistributionPackageDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAlternativeDistributionPackageVersionRelationshipsAlternativeDistributionPackageDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AlternativeDistributionPackageVersionRelationshipsDeltasDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAlternativeDistributionPackageVersionRelationshipsDeltasDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AlternativeDistributionPackageVersionRelationshipsVariantsDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAlternativeDistributionPackageVersionRelationshipsVariantsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AlternativeDistributionPackageVersionType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAlternativeDistributionPackageVersionType2(options);
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
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AlternativeDistributionPackageRelationshipsVersionsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_SourceGenerationContextMetadataType_1E479F3F2DF5F4B2(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AlternativeDistributionPackageVersion>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_SourceGenerationContextMetadataType_9BD2BFC61062C54F(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AlternativeDistributionPackageVersionRelationshipsDeltasDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_SourceGenerationContextMetadataType_2368EB31AA2C7483(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AlternativeDistributionPackageVersionRelationshipsVariantsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_SourceGenerationContextMetadataType_7AD36C157133B5C2(options);
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