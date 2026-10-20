
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_272A1E1C757D08F6 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_272A1E1C757D08F6 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_272A1E1C757D08F6(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.ScmPullRequestType)

                    || typeToConvert == typeof(global::AppStoreConnect.ScmPullRequestType?)

                    || typeToConvert == typeof(global::AppStoreConnect.ScmPullRequestRelationshipsRepositoryDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.ScmPullRequestRelationshipsRepositoryDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.ScmRepositoryType)

                    || typeToConvert == typeof(global::AppStoreConnect.ScmRepositoryType?)

                    || typeToConvert == typeof(global::AppStoreConnect.ScmRepositoryRelationshipsScmProviderDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.ScmRepositoryRelationshipsScmProviderDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.ScmRepositoryRelationshipsDefaultBranchDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.ScmRepositoryRelationshipsDefaultBranchDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.ScmPullRequestsGetInstanceFieldsScmPullRequest)

                    || typeToConvert == typeof(global::AppStoreConnect.ScmPullRequestsGetInstanceFieldsScmPullRequest?)

                    || typeToConvert == typeof(global::AppStoreConnect.ScmPullRequestsGetInstanceFieldsScmRepositorie)

                    || typeToConvert == typeof(global::AppStoreConnect.ScmPullRequestsGetInstanceFieldsScmRepositorie?)

                    || typeToConvert == typeof(global::AppStoreConnect.ScmPullRequestsGetInstanceIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.ScmPullRequestsGetInstanceIncludeItem?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.ScmPullRequestType))
                {
                    return new global::AppStoreConnect.JsonConverters.ScmPullRequestTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ScmPullRequestType?))
                {
                    return new global::AppStoreConnect.JsonConverters.ScmPullRequestTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ScmPullRequestRelationshipsRepositoryDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.ScmPullRequestRelationshipsRepositoryDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ScmPullRequestRelationshipsRepositoryDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.ScmPullRequestRelationshipsRepositoryDataTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::AppStoreConnect.ScmPullRequestsGetInstanceFieldsScmPullRequest))
                {
                    return new global::AppStoreConnect.JsonConverters.ScmPullRequestsGetInstanceFieldsScmPullRequestJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ScmPullRequestsGetInstanceFieldsScmPullRequest?))
                {
                    return new global::AppStoreConnect.JsonConverters.ScmPullRequestsGetInstanceFieldsScmPullRequestNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ScmPullRequestsGetInstanceFieldsScmRepositorie))
                {
                    return new global::AppStoreConnect.JsonConverters.ScmPullRequestsGetInstanceFieldsScmRepositorieJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ScmPullRequestsGetInstanceFieldsScmRepositorie?))
                {
                    return new global::AppStoreConnect.JsonConverters.ScmPullRequestsGetInstanceFieldsScmRepositorieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ScmPullRequestsGetInstanceIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.ScmPullRequestsGetInstanceIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ScmPullRequestsGetInstanceIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.ScmPullRequestsGetInstanceIncludeItemNullableJsonConverter();
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
                if (type == typeof(global::AppStoreConnect.DocumentLinks))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_DocumentLinks(options);
                }
                if (type == typeof(global::AppStoreConnect.RelationshipLinks))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_RelationshipLinks(options);
                }
                if (type == typeof(global::AppStoreConnect.ResourceLinks))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_ResourceLinks(options);
                }
                if (type == typeof(global::AppStoreConnect.ScmPullRequest))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_ScmPullRequest(options);
                }
                if (type == typeof(global::AppStoreConnect.ScmPullRequestAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ScmPullRequestAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.ScmPullRequestRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ScmPullRequestRelationships(options);
                }
                if (type == typeof(global::AppStoreConnect.ScmPullRequestRelationshipsRepository))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ScmPullRequestRelationshipsRepository(options);
                }
                if (type == typeof(global::AppStoreConnect.ScmPullRequestRelationshipsRepositoryData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ScmPullRequestRelationshipsRepositoryData(options);
                }
                if (type == typeof(global::AppStoreConnect.ScmPullRequestRelationshipsRepositoryDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ScmPullRequestRelationshipsRepositoryDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.ScmPullRequestResponse))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ScmPullRequestResponse(options);
                }
                if (type == typeof(global::AppStoreConnect.ScmPullRequestType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ScmPullRequestType2(options);
                }
                if (type == typeof(global::AppStoreConnect.ScmPullRequestsGetInstanceFieldsScmPullRequest))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_ScmPullRequestsGetInstanceFieldsScmPullRequest2(options);
                }
                if (type == typeof(global::AppStoreConnect.ScmPullRequestsGetInstanceFieldsScmRepositorie))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_ScmPullRequestsGetInstanceFieldsScmRepositorie2(options);
                }
                if (type == typeof(global::AppStoreConnect.ScmPullRequestsGetInstanceIncludeItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_ScmPullRequestsGetInstanceIncludeItem2(options);
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
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.ScmPullRequestsGetInstanceFieldsScmPullRequest>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_97C80F4A735821CE(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.ScmPullRequestsGetInstanceFieldsScmRepositorie>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_CF3AE06E61FDE35E(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.ScmPullRequestsGetInstanceIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_62EE5CF321B449E3(options);
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
                if (type == typeof(global::AppStoreConnect.ScmPullRequestRelationshipsRepositoryDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableScmPullRequestRelationshipsRepositoryDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.ScmPullRequestType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableScmPullRequestType2(options);
                }
                if (type == typeof(global::AppStoreConnect.ScmPullRequestsGetInstanceFieldsScmPullRequest?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableScmPullRequestsGetInstanceFieldsScmPullRequest2(options);
                }
                if (type == typeof(global::AppStoreConnect.ScmPullRequestsGetInstanceFieldsScmRepositorie?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableScmPullRequestsGetInstanceFieldsScmRepositorie2(options);
                }
                if (type == typeof(global::AppStoreConnect.ScmPullRequestsGetInstanceIncludeItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableScmPullRequestsGetInstanceIncludeItem2(options);
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
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.ScmPullRequestsGetInstanceFieldsScmPullRequest>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_0AD3B9B11D5B3AAA(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.ScmPullRequestsGetInstanceFieldsScmRepositorie>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_FBE1F33D0CD5717E(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.ScmPullRequestsGetInstanceIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_80B45B71991F76A4(options);
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