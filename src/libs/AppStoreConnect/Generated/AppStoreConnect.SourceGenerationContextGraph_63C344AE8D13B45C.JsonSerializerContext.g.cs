
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_63C344AE8D13B45C : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_63C344AE8D13B45C Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_63C344AE8D13B45C(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.CiBuildRunCreateRequestDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunCreateRequestDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunCreateRequestDataRelationshipsBuildRunDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunCreateRequestDataRelationshipsBuildRunDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunCreateRequestDataRelationshipsWorkflowDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunCreateRequestDataRelationshipsWorkflowDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunCreateRequestDataRelationshipsSourceBranchOrTagDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunCreateRequestDataRelationshipsSourceBranchOrTagDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunCreateRequestDataRelationshipsPullRequestDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunCreateRequestDataRelationshipsPullRequestDataType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunCreateRequestDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunCreateRequestDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunCreateRequestDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunCreateRequestDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunCreateRequestDataRelationshipsBuildRunDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunCreateRequestDataRelationshipsBuildRunDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunCreateRequestDataRelationshipsBuildRunDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunCreateRequestDataRelationshipsBuildRunDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunCreateRequestDataRelationshipsWorkflowDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunCreateRequestDataRelationshipsWorkflowDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunCreateRequestDataRelationshipsWorkflowDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunCreateRequestDataRelationshipsWorkflowDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunCreateRequestDataRelationshipsSourceBranchOrTagDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunCreateRequestDataRelationshipsSourceBranchOrTagDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunCreateRequestDataRelationshipsSourceBranchOrTagDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunCreateRequestDataRelationshipsSourceBranchOrTagDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunCreateRequestDataRelationshipsPullRequestDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunCreateRequestDataRelationshipsPullRequestDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunCreateRequestDataRelationshipsPullRequestDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunCreateRequestDataRelationshipsPullRequestDataTypeNullableJsonConverter();
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
                if (type == typeof(global::AppStoreConnect.CiBuildRunCreateRequest))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiBuildRunCreateRequest(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildRunCreateRequestData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiBuildRunCreateRequestData(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildRunCreateRequestDataAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiBuildRunCreateRequestDataAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildRunCreateRequestDataRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiBuildRunCreateRequestDataRelationships(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildRunCreateRequestDataRelationshipsBuildRun))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiBuildRunCreateRequestDataRelationshipsBuildRun(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildRunCreateRequestDataRelationshipsBuildRunData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiBuildRunCreateRequestDataRelationshipsBuildRunData(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildRunCreateRequestDataRelationshipsBuildRunDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiBuildRunCreateRequestDataRelationshipsBuildRunDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildRunCreateRequestDataRelationshipsPullRequest))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiBuildRunCreateRequestDataRelationshipsPullRequest(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildRunCreateRequestDataRelationshipsPullRequestData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiBuildRunCreateRequestDataRelationshipsPullRequestData(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildRunCreateRequestDataRelationshipsPullRequestDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiBuildRunCreateRequestDataRelationshipsPullRequestDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildRunCreateRequestDataRelationshipsSourceBranchOrTag))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiBuildRunCreateRequestDataRelationshipsSourceBranchOrTag(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildRunCreateRequestDataRelationshipsSourceBranchOrTagData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiBuildRunCreateRequestDataRelationshipsSourceBranchOrTagData(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildRunCreateRequestDataRelationshipsSourceBranchOrTagDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiBuildRunCreateRequestDataRelationshipsSourceBranchOrTagDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildRunCreateRequestDataRelationshipsWorkflow))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiBuildRunCreateRequestDataRelationshipsWorkflow(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildRunCreateRequestDataRelationshipsWorkflowData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiBuildRunCreateRequestDataRelationshipsWorkflowData(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildRunCreateRequestDataRelationshipsWorkflowDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiBuildRunCreateRequestDataRelationshipsWorkflowDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildRunCreateRequestDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiBuildRunCreateRequestDataType2(options);
                }
                if (type == typeof(bool?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBoolean(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildRunCreateRequestDataRelationshipsBuildRunDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableCiBuildRunCreateRequestDataRelationshipsBuildRunDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildRunCreateRequestDataRelationshipsPullRequestDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableCiBuildRunCreateRequestDataRelationshipsPullRequestDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildRunCreateRequestDataRelationshipsSourceBranchOrTagDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableCiBuildRunCreateRequestDataRelationshipsSourceBranchOrTagDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildRunCreateRequestDataRelationshipsWorkflowDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableCiBuildRunCreateRequestDataRelationshipsWorkflowDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildRunCreateRequestDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableCiBuildRunCreateRequestDataType2(options);
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