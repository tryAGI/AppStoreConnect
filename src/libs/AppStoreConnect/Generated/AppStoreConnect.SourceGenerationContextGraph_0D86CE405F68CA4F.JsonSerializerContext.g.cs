
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_0D86CE405F68CA4F : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_0D86CE405F68CA4F Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_0D86CE405F68CA4F(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem160JsonConverter());
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
                    typeToConvert == typeof(global::AppStoreConnect.ScmGitReferenceType)

                    || typeToConvert == typeof(global::AppStoreConnect.ScmGitReferenceType?)

                    || typeToConvert == typeof(global::AppStoreConnect.ScmGitReferenceRelationshipsRepositoryDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.ScmGitReferenceRelationshipsRepositoryDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.ScmProviderType)

                    || typeToConvert == typeof(global::AppStoreConnect.ScmProviderType?)

                    || typeToConvert == typeof(global::AppStoreConnect.ScmRepositoryType)

                    || typeToConvert == typeof(global::AppStoreConnect.ScmRepositoryType?)

                    || typeToConvert == typeof(global::AppStoreConnect.ScmRepositoryRelationshipsScmProviderDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.ScmRepositoryRelationshipsScmProviderDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.ScmRepositoryRelationshipsDefaultBranchDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.ScmRepositoryRelationshipsDefaultBranchDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.ScmRepositoriesResponseIncludedItemDiscriminatorType)

                    || typeToConvert == typeof(global::AppStoreConnect.ScmRepositoriesResponseIncludedItemDiscriminatorType?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiGitRefKind)

                    || typeToConvert == typeof(global::AppStoreConnect.CiGitRefKind?)

                    || typeToConvert == typeof(global::AppStoreConnect.ScmProviderTypeKind)

                    || typeToConvert == typeof(global::AppStoreConnect.ScmProviderTypeKind?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.ScmGitReferenceType))
                {
                    return new global::AppStoreConnect.JsonConverters.ScmGitReferenceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ScmGitReferenceType?))
                {
                    return new global::AppStoreConnect.JsonConverters.ScmGitReferenceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ScmGitReferenceRelationshipsRepositoryDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.ScmGitReferenceRelationshipsRepositoryDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ScmGitReferenceRelationshipsRepositoryDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.ScmGitReferenceRelationshipsRepositoryDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ScmProviderType))
                {
                    return new global::AppStoreConnect.JsonConverters.ScmProviderTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ScmProviderType?))
                {
                    return new global::AppStoreConnect.JsonConverters.ScmProviderTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ScmRepositoryType))
                {
                    return new global::AppStoreConnect.JsonConverters.ScmRepositoryTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ScmRepositoryType?))
                {
                    return new global::AppStoreConnect.JsonConverters.ScmRepositoryTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ScmRepositoryRelationshipsScmProviderDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.ScmRepositoryRelationshipsScmProviderDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ScmRepositoryRelationshipsScmProviderDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.ScmRepositoryRelationshipsScmProviderDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ScmRepositoryRelationshipsDefaultBranchDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.ScmRepositoryRelationshipsDefaultBranchDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ScmRepositoryRelationshipsDefaultBranchDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.ScmRepositoryRelationshipsDefaultBranchDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ScmRepositoriesResponseIncludedItemDiscriminatorType))
                {
                    return new global::AppStoreConnect.JsonConverters.ScmRepositoriesResponseIncludedItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ScmRepositoriesResponseIncludedItemDiscriminatorType?))
                {
                    return new global::AppStoreConnect.JsonConverters.ScmRepositoriesResponseIncludedItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiGitRefKind))
                {
                    return new global::AppStoreConnect.JsonConverters.CiGitRefKindJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiGitRefKind?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiGitRefKindNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ScmProviderTypeKind))
                {
                    return new global::AppStoreConnect.JsonConverters.ScmProviderTypeKindJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ScmProviderTypeKind?))
                {
                    return new global::AppStoreConnect.JsonConverters.ScmProviderTypeKindNullableJsonConverter();
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
                if (type == typeof(bool))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_Boolean(options);
                }
                if (type == typeof(global::AppStoreConnect.CiGitRefKind))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_CiGitRefKind2(options);
                }
                if (type == typeof(global::AppStoreConnect.IncludedItem160))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_IncludedItem1602(options);
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
                if (type == typeof(global::AppStoreConnect.RelationshipLinks))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_RelationshipLinks(options);
                }
                if (type == typeof(global::AppStoreConnect.ResourceLinks))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_ResourceLinks(options);
                }
                if (type == typeof(global::AppStoreConnect.ScmGitReference))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_ScmGitReference(options);
                }
                if (type == typeof(global::AppStoreConnect.ScmGitReferenceAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ScmGitReferenceAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.ScmGitReferenceRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ScmGitReferenceRelationships(options);
                }
                if (type == typeof(global::AppStoreConnect.ScmGitReferenceRelationshipsRepository))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ScmGitReferenceRelationshipsRepository(options);
                }
                if (type == typeof(global::AppStoreConnect.ScmGitReferenceRelationshipsRepositoryData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ScmGitReferenceRelationshipsRepositoryData(options);
                }
                if (type == typeof(global::AppStoreConnect.ScmGitReferenceRelationshipsRepositoryDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ScmGitReferenceRelationshipsRepositoryDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.ScmGitReferenceType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ScmGitReferenceType2(options);
                }
                if (type == typeof(global::AppStoreConnect.ScmProvider))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ScmProvider(options);
                }
                if (type == typeof(global::AppStoreConnect.ScmProviderAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ScmProviderAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.ScmProviderRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ScmProviderRelationships(options);
                }
                if (type == typeof(global::AppStoreConnect.ScmProviderRelationshipsRepositories))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ScmProviderRelationshipsRepositories(options);
                }
                if (type == typeof(global::AppStoreConnect.ScmProviderType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ScmProviderType2_3(options);
                }
                if (type == typeof(global::AppStoreConnect.ScmProviderType2))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ScmProviderType2(options);
                }
                if (type == typeof(global::AppStoreConnect.ScmProviderTypeKind))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_ScmProviderTypeKind2(options);
                }
                if (type == typeof(global::AppStoreConnect.ScmRepositoriesResponse))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ScmRepositoriesResponse(options);
                }
                if (type == typeof(global::AppStoreConnect.ScmRepositoriesResponseIncludedItemDiscriminator))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ScmRepositoriesResponseIncludedItemDiscriminator(options);
                }
                if (type == typeof(global::AppStoreConnect.ScmRepositoriesResponseIncludedItemDiscriminatorType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ScmRepositoriesResponseIncludedItemDiscriminatorType2(options);
                }
                if (type == typeof(global::AppStoreConnect.ScmRepository))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_ScmRepository(options);
                }
                if (type == typeof(global::AppStoreConnect.ScmRepositoryAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ScmRepositoryAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.ScmRepositoryRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ScmRepositoryRelationships(options);
                }
                if (type == typeof(global::AppStoreConnect.ScmRepositoryRelationshipsDefaultBranch))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ScmRepositoryRelationshipsDefaultBranch(options);
                }
                if (type == typeof(global::AppStoreConnect.ScmRepositoryRelationshipsDefaultBranchData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ScmRepositoryRelationshipsDefaultBranchData(options);
                }
                if (type == typeof(global::AppStoreConnect.ScmRepositoryRelationshipsDefaultBranchDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ScmRepositoryRelationshipsDefaultBranchDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.ScmRepositoryRelationshipsGitReferences))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ScmRepositoryRelationshipsGitReferences(options);
                }
                if (type == typeof(global::AppStoreConnect.ScmRepositoryRelationshipsPullRequests))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ScmRepositoryRelationshipsPullRequests(options);
                }
                if (type == typeof(global::AppStoreConnect.ScmRepositoryRelationshipsScmProvider))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ScmRepositoryRelationshipsScmProvider(options);
                }
                if (type == typeof(global::AppStoreConnect.ScmRepositoryRelationshipsScmProviderData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ScmRepositoryRelationshipsScmProviderData(options);
                }
                if (type == typeof(global::AppStoreConnect.ScmRepositoryRelationshipsScmProviderDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ScmRepositoryRelationshipsScmProviderDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.ScmRepositoryType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ScmRepositoryType2(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.IncludedItem160>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_2D52DF2375548317(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.ScmRepository>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_54001EB3E0A642C8(options);
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
                if (type == typeof(global::AppStoreConnect.CiGitRefKind?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableCiGitRefKind2(options);
                }
                if (type == typeof(global::AppStoreConnect.IncludedItem160?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableIncludedItem1602(options);
                }
                if (type == typeof(global::AppStoreConnect.ScmGitReferenceRelationshipsRepositoryDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableScmGitReferenceRelationshipsRepositoryDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.ScmGitReferenceType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableScmGitReferenceType2(options);
                }
                if (type == typeof(global::AppStoreConnect.ScmProviderType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableScmProviderType2(options);
                }
                if (type == typeof(global::AppStoreConnect.ScmProviderTypeKind?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableScmProviderTypeKind2(options);
                }
                if (type == typeof(global::AppStoreConnect.ScmRepositoriesResponseIncludedItemDiscriminatorType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableScmRepositoriesResponseIncludedItemDiscriminatorType2(options);
                }
                if (type == typeof(global::AppStoreConnect.ScmRepositoryRelationshipsDefaultBranchDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableScmRepositoryRelationshipsDefaultBranchDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.ScmRepositoryRelationshipsScmProviderDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableScmRepositoryRelationshipsScmProviderDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.ScmRepositoryType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableScmRepositoryType2(options);
                }
                if (type == typeof(global::System.DateTime?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableDateTime(options);
                }
                if (type == typeof(int?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableInt32(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.IncludedItem160>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_4C16B6EC120DC4E1(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.ScmRepository>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_D03BDECF27B299D6(options);
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