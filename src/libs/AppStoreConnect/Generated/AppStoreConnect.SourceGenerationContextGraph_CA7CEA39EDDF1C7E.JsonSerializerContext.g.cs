
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_CA7CEA39EDDF1C7E : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_CA7CEA39EDDF1C7E Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_CA7CEA39EDDF1C7E(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsGetInstanceFieldsCiBuildRun)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsGetInstanceFieldsCiBuildRun?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsGetInstanceFieldsBuild)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsGetInstanceFieldsBuild?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsGetInstanceFieldsCiWorkflow)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsGetInstanceFieldsCiWorkflow?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsGetInstanceFieldsCiProduct)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsGetInstanceFieldsCiProduct?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsGetInstanceFieldsScmGitReference)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsGetInstanceFieldsScmGitReference?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsGetInstanceFieldsScmPullRequest)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsGetInstanceFieldsScmPullRequest?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsGetInstanceIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsGetInstanceIncludeItem?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsGetInstanceFieldsCiBuildRun))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunsGetInstanceFieldsCiBuildRunJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsGetInstanceFieldsCiBuildRun?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunsGetInstanceFieldsCiBuildRunNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsGetInstanceFieldsBuild))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunsGetInstanceFieldsBuildJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsGetInstanceFieldsBuild?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunsGetInstanceFieldsBuildNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsGetInstanceFieldsCiWorkflow))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunsGetInstanceFieldsCiWorkflowJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsGetInstanceFieldsCiWorkflow?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunsGetInstanceFieldsCiWorkflowNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsGetInstanceFieldsCiProduct))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunsGetInstanceFieldsCiProductJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsGetInstanceFieldsCiProduct?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunsGetInstanceFieldsCiProductNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsGetInstanceFieldsScmGitReference))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunsGetInstanceFieldsScmGitReferenceJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsGetInstanceFieldsScmGitReference?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunsGetInstanceFieldsScmGitReferenceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsGetInstanceFieldsScmPullRequest))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunsGetInstanceFieldsScmPullRequestJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsGetInstanceFieldsScmPullRequest?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunsGetInstanceFieldsScmPullRequestNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsGetInstanceIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunsGetInstanceIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsGetInstanceIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunsGetInstanceIncludeItemNullableJsonConverter();
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
                if (type == typeof(global::AppStoreConnect.CiBuildRunsGetInstanceFieldsBuild))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_CiBuildRunsGetInstanceFieldsBuild2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildRunsGetInstanceFieldsCiBuildRun))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_CiBuildRunsGetInstanceFieldsCiBuildRun2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildRunsGetInstanceFieldsCiProduct))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_CiBuildRunsGetInstanceFieldsCiProduct2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildRunsGetInstanceFieldsCiWorkflow))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_CiBuildRunsGetInstanceFieldsCiWorkflow2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildRunsGetInstanceFieldsScmGitReference))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_CiBuildRunsGetInstanceFieldsScmGitReference2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildRunsGetInstanceFieldsScmPullRequest))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_CiBuildRunsGetInstanceFieldsScmPullRequest2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildRunsGetInstanceIncludeItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_CiBuildRunsGetInstanceIncludeItem2(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildRunsGetInstanceFieldsBuild>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_8C82F76CE0552928(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildRunsGetInstanceFieldsCiBuildRun>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_40979919C43B6156(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildRunsGetInstanceFieldsCiProduct>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_BC41CEDCB20D06A2(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildRunsGetInstanceFieldsCiWorkflow>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_92DA357F04FB9885(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildRunsGetInstanceFieldsScmGitReference>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_6FC56ACEB6FBD7CF(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildRunsGetInstanceFieldsScmPullRequest>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_5F2D205D7A7A6DAB(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildRunsGetInstanceIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_51C8803F694557D3(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildRunsGetInstanceFieldsBuild?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableCiBuildRunsGetInstanceFieldsBuild2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildRunsGetInstanceFieldsCiBuildRun?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableCiBuildRunsGetInstanceFieldsCiBuildRun2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildRunsGetInstanceFieldsCiProduct?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableCiBuildRunsGetInstanceFieldsCiProduct2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildRunsGetInstanceFieldsCiWorkflow?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableCiBuildRunsGetInstanceFieldsCiWorkflow2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildRunsGetInstanceFieldsScmGitReference?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableCiBuildRunsGetInstanceFieldsScmGitReference2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildRunsGetInstanceFieldsScmPullRequest?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableCiBuildRunsGetInstanceFieldsScmPullRequest2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildRunsGetInstanceIncludeItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableCiBuildRunsGetInstanceIncludeItem2(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiBuildRunsGetInstanceFieldsBuild>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_AEF0FB9825488D6E(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiBuildRunsGetInstanceFieldsCiBuildRun>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_7D7117FE07998F05(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiBuildRunsGetInstanceFieldsCiProduct>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_FA4749F96D267023(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiBuildRunsGetInstanceFieldsCiWorkflow>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_47059C52A7735323(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiBuildRunsGetInstanceFieldsScmGitReference>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_ADBBE4663DD1ACEF(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiBuildRunsGetInstanceFieldsScmPullRequest>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_A1AA5576DE0ACECB(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiBuildRunsGetInstanceIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_D46DFCC2898E536B(options);
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