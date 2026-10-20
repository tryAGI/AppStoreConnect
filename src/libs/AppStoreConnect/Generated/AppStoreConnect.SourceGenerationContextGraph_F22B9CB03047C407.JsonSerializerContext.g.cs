
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_F22B9CB03047C407 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_F22B9CB03047C407 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_F22B9CB03047C407(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedSortItem)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedSortItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsCiBuildRun)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsCiBuildRun?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsBuild)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsBuild?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsCiWorkflow)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsCiWorkflow?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsCiProduct)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsCiProduct?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsScmGitReference)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsScmGitReference?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsScmPullRequest)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsScmPullRequest?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedIncludeItem?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedSortItem))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsBuildRunsGetToManyRelatedSortItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedSortItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsBuildRunsGetToManyRelatedSortItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsCiBuildRun))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsBuildRunsGetToManyRelatedFieldsCiBuildRunJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsCiBuildRun?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsBuildRunsGetToManyRelatedFieldsCiBuildRunNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsBuild))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsBuildRunsGetToManyRelatedFieldsBuildJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsBuild?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsBuildRunsGetToManyRelatedFieldsBuildNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsCiWorkflow))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsBuildRunsGetToManyRelatedFieldsCiWorkflowJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsCiWorkflow?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsBuildRunsGetToManyRelatedFieldsCiWorkflowNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsCiProduct))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsBuildRunsGetToManyRelatedFieldsCiProductJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsCiProduct?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsBuildRunsGetToManyRelatedFieldsCiProductNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsScmGitReference))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsBuildRunsGetToManyRelatedFieldsScmGitReferenceJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsScmGitReference?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsBuildRunsGetToManyRelatedFieldsScmGitReferenceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsScmPullRequest))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsBuildRunsGetToManyRelatedFieldsScmPullRequestJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsScmPullRequest?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsBuildRunsGetToManyRelatedFieldsScmPullRequestNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsBuildRunsGetToManyRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsBuildRunsGetToManyRelatedIncludeItemNullableJsonConverter();
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
                if (type == typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsBuild))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_CiProductsBuildRunsGetToManyRelatedFieldsBuild2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsCiBuildRun))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_CiProductsBuildRunsGetToManyRelatedFieldsCiBuildRun2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsCiProduct))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_CiProductsBuildRunsGetToManyRelatedFieldsCiProduct2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsCiWorkflow))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_CiProductsBuildRunsGetToManyRelatedFieldsCiWorkflow2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsScmGitReference))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_CiProductsBuildRunsGetToManyRelatedFieldsScmGitReference2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsScmPullRequest))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_CiProductsBuildRunsGetToManyRelatedFieldsScmPullRequest2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedIncludeItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_CiProductsBuildRunsGetToManyRelatedIncludeItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedSortItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_CiProductsBuildRunsGetToManyRelatedSortItem2(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsBuild>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_29319E84814C3500(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsCiBuildRun>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_6C86A5A87469A168(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsCiProduct>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_DA5CE1014F831DC7(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsCiWorkflow>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_F5EA83F33749B9EF(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsScmGitReference>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_B5097F54F2F3038D(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsScmPullRequest>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_B6D14F0DF9C25645(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_6C86FC332EA79EED(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedSortItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_0C1E73018A15FEBB(options);
                }
                if (type == typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsBuild?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableCiProductsBuildRunsGetToManyRelatedFieldsBuild2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsCiBuildRun?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableCiProductsBuildRunsGetToManyRelatedFieldsCiBuildRun2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsCiProduct?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableCiProductsBuildRunsGetToManyRelatedFieldsCiProduct2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsCiWorkflow?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableCiProductsBuildRunsGetToManyRelatedFieldsCiWorkflow2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsScmGitReference?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableCiProductsBuildRunsGetToManyRelatedFieldsScmGitReference2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsScmPullRequest?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableCiProductsBuildRunsGetToManyRelatedFieldsScmPullRequest2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedIncludeItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableCiProductsBuildRunsGetToManyRelatedIncludeItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedSortItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableCiProductsBuildRunsGetToManyRelatedSortItem2(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsBuild>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_D6182E9027FEEA5C(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsCiBuildRun>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_1E02EC3EEF01FEC7(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsCiProduct>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_D38FB33DA0FF31F7(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsCiWorkflow>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_FC242D880A03A642(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsScmGitReference>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_76BE3D8D39725E12(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsScmPullRequest>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_A1FCD10DF35F3B5C(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_840A98C4FC063506(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedSortItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_B0C0BAAFC4C93E1B(options);
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