
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_1F9DCC950590C90F : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_1F9DCC950590C90F Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_1F9DCC950590C90F(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedSortItem)

                    || typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedSortItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedFieldsCiBuildRun)

                    || typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedFieldsCiBuildRun?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedFieldsBuild)

                    || typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedFieldsBuild?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedFieldsCiWorkflow)

                    || typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedFieldsCiWorkflow?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedFieldsCiProduct)

                    || typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedFieldsCiProduct?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedFieldsScmGitReference)

                    || typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedFieldsScmGitReference?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedFieldsScmPullRequest)

                    || typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedFieldsScmPullRequest?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedIncludeItem?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedSortItem))
                {
                    return new global::AppStoreConnect.JsonConverters.CiWorkflowsBuildRunsGetToManyRelatedSortItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedSortItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiWorkflowsBuildRunsGetToManyRelatedSortItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedFieldsCiBuildRun))
                {
                    return new global::AppStoreConnect.JsonConverters.CiWorkflowsBuildRunsGetToManyRelatedFieldsCiBuildRunJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedFieldsCiBuildRun?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiWorkflowsBuildRunsGetToManyRelatedFieldsCiBuildRunNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedFieldsBuild))
                {
                    return new global::AppStoreConnect.JsonConverters.CiWorkflowsBuildRunsGetToManyRelatedFieldsBuildJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedFieldsBuild?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiWorkflowsBuildRunsGetToManyRelatedFieldsBuildNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedFieldsCiWorkflow))
                {
                    return new global::AppStoreConnect.JsonConverters.CiWorkflowsBuildRunsGetToManyRelatedFieldsCiWorkflowJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedFieldsCiWorkflow?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiWorkflowsBuildRunsGetToManyRelatedFieldsCiWorkflowNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedFieldsCiProduct))
                {
                    return new global::AppStoreConnect.JsonConverters.CiWorkflowsBuildRunsGetToManyRelatedFieldsCiProductJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedFieldsCiProduct?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiWorkflowsBuildRunsGetToManyRelatedFieldsCiProductNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedFieldsScmGitReference))
                {
                    return new global::AppStoreConnect.JsonConverters.CiWorkflowsBuildRunsGetToManyRelatedFieldsScmGitReferenceJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedFieldsScmGitReference?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiWorkflowsBuildRunsGetToManyRelatedFieldsScmGitReferenceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedFieldsScmPullRequest))
                {
                    return new global::AppStoreConnect.JsonConverters.CiWorkflowsBuildRunsGetToManyRelatedFieldsScmPullRequestJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedFieldsScmPullRequest?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiWorkflowsBuildRunsGetToManyRelatedFieldsScmPullRequestNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.CiWorkflowsBuildRunsGetToManyRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiWorkflowsBuildRunsGetToManyRelatedIncludeItemNullableJsonConverter();
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
                if (type == typeof(global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedFieldsBuild))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_CiWorkflowsBuildRunsGetToManyRelatedFieldsBuild2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedFieldsCiBuildRun))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_CiWorkflowsBuildRunsGetToManyRelatedFieldsCiBuildRun2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedFieldsCiProduct))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_CiWorkflowsBuildRunsGetToManyRelatedFieldsCiProduct2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedFieldsCiWorkflow))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_CiWorkflowsBuildRunsGetToManyRelatedFieldsCiWorkflow2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedFieldsScmGitReference))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_CiWorkflowsBuildRunsGetToManyRelatedFieldsScmGitReference2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedFieldsScmPullRequest))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_CiWorkflowsBuildRunsGetToManyRelatedFieldsScmPullRequest2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedIncludeItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_CiWorkflowsBuildRunsGetToManyRelatedIncludeItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedSortItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_CiWorkflowsBuildRunsGetToManyRelatedSortItem2(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedFieldsBuild>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_060277662E875FE4(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedFieldsCiBuildRun>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_B3EBC5C2645D4D41(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedFieldsCiProduct>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_FDAA0572D59C2E9F(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedFieldsCiWorkflow>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_D94D1FC21FD8D26A(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedFieldsScmGitReference>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_E07150600870F366(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedFieldsScmPullRequest>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_27FCD34DA43A7EFD(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_7F7611F57B555F51(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedSortItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_3FE2F82F9FCFB408(options);
                }
                if (type == typeof(global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedFieldsBuild?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableCiWorkflowsBuildRunsGetToManyRelatedFieldsBuild2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedFieldsCiBuildRun?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableCiWorkflowsBuildRunsGetToManyRelatedFieldsCiBuildRun2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedFieldsCiProduct?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableCiWorkflowsBuildRunsGetToManyRelatedFieldsCiProduct2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedFieldsCiWorkflow?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableCiWorkflowsBuildRunsGetToManyRelatedFieldsCiWorkflow2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedFieldsScmGitReference?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableCiWorkflowsBuildRunsGetToManyRelatedFieldsScmGitReference2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedFieldsScmPullRequest?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableCiWorkflowsBuildRunsGetToManyRelatedFieldsScmPullRequest2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedIncludeItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableCiWorkflowsBuildRunsGetToManyRelatedIncludeItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedSortItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableCiWorkflowsBuildRunsGetToManyRelatedSortItem2(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedFieldsBuild>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_241DE2DF1F3E3213(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedFieldsCiBuildRun>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_999AD82BEBCEC344(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedFieldsCiProduct>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_11343DEA156FBACE(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedFieldsCiWorkflow>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_9D7CC6AC7BA08F8A(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedFieldsScmGitReference>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_634622F799D0E05E(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedFieldsScmPullRequest>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_B3F07840E6529539(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_75E6CA1A6722CDBB(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedSortItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_0F9ACDA4A416A099(options);
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