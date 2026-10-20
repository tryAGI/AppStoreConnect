
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_CB96AACE0D432CEC : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_CB96AACE0D432CEC Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_CB96AACE0D432CEC(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.CiBuildActionsBuildRunGetToOneRelatedFieldsCiBuildRun)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildActionsBuildRunGetToOneRelatedFieldsCiBuildRun?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildActionsBuildRunGetToOneRelatedFieldsBuild)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildActionsBuildRunGetToOneRelatedFieldsBuild?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildActionsBuildRunGetToOneRelatedFieldsCiWorkflow)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildActionsBuildRunGetToOneRelatedFieldsCiWorkflow?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildActionsBuildRunGetToOneRelatedFieldsCiProduct)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildActionsBuildRunGetToOneRelatedFieldsCiProduct?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildActionsBuildRunGetToOneRelatedFieldsScmGitReference)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildActionsBuildRunGetToOneRelatedFieldsScmGitReference?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildActionsBuildRunGetToOneRelatedFieldsScmPullRequest)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildActionsBuildRunGetToOneRelatedFieldsScmPullRequest?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildActionsBuildRunGetToOneRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildActionsBuildRunGetToOneRelatedIncludeItem?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildActionsBuildRunGetToOneRelatedFieldsCiBuildRun))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildActionsBuildRunGetToOneRelatedFieldsCiBuildRunJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildActionsBuildRunGetToOneRelatedFieldsCiBuildRun?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildActionsBuildRunGetToOneRelatedFieldsCiBuildRunNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildActionsBuildRunGetToOneRelatedFieldsBuild))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildActionsBuildRunGetToOneRelatedFieldsBuildJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildActionsBuildRunGetToOneRelatedFieldsBuild?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildActionsBuildRunGetToOneRelatedFieldsBuildNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildActionsBuildRunGetToOneRelatedFieldsCiWorkflow))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildActionsBuildRunGetToOneRelatedFieldsCiWorkflowJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildActionsBuildRunGetToOneRelatedFieldsCiWorkflow?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildActionsBuildRunGetToOneRelatedFieldsCiWorkflowNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildActionsBuildRunGetToOneRelatedFieldsCiProduct))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildActionsBuildRunGetToOneRelatedFieldsCiProductJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildActionsBuildRunGetToOneRelatedFieldsCiProduct?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildActionsBuildRunGetToOneRelatedFieldsCiProductNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildActionsBuildRunGetToOneRelatedFieldsScmGitReference))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildActionsBuildRunGetToOneRelatedFieldsScmGitReferenceJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildActionsBuildRunGetToOneRelatedFieldsScmGitReference?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildActionsBuildRunGetToOneRelatedFieldsScmGitReferenceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildActionsBuildRunGetToOneRelatedFieldsScmPullRequest))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildActionsBuildRunGetToOneRelatedFieldsScmPullRequestJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildActionsBuildRunGetToOneRelatedFieldsScmPullRequest?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildActionsBuildRunGetToOneRelatedFieldsScmPullRequestNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildActionsBuildRunGetToOneRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildActionsBuildRunGetToOneRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildActionsBuildRunGetToOneRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildActionsBuildRunGetToOneRelatedIncludeItemNullableJsonConverter();
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
                if (type == typeof(global::AppStoreConnect.CiBuildActionsBuildRunGetToOneRelatedFieldsBuild))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_CiBuildActionsBuildRunGetToOneRelatedFieldsBuild2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildActionsBuildRunGetToOneRelatedFieldsCiBuildRun))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_CiBuildActionsBuildRunGetToOneRelatedFieldsCiBuildRun2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildActionsBuildRunGetToOneRelatedFieldsCiProduct))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_CiBuildActionsBuildRunGetToOneRelatedFieldsCiProduct2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildActionsBuildRunGetToOneRelatedFieldsCiWorkflow))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_CiBuildActionsBuildRunGetToOneRelatedFieldsCiWorkflow2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildActionsBuildRunGetToOneRelatedFieldsScmGitReference))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_CiBuildActionsBuildRunGetToOneRelatedFieldsScmGitReference2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildActionsBuildRunGetToOneRelatedFieldsScmPullRequest))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_CiBuildActionsBuildRunGetToOneRelatedFieldsScmPullRequest2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildActionsBuildRunGetToOneRelatedIncludeItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_CiBuildActionsBuildRunGetToOneRelatedIncludeItem2(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildActionsBuildRunGetToOneRelatedFieldsBuild>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_9BE64F665DD58BBC(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildActionsBuildRunGetToOneRelatedFieldsCiBuildRun>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_D6FDE38D4580341F(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildActionsBuildRunGetToOneRelatedFieldsCiProduct>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_CA0A0E319F6EEECA(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildActionsBuildRunGetToOneRelatedFieldsCiWorkflow>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_3768F99D4E95AF41(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildActionsBuildRunGetToOneRelatedFieldsScmGitReference>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_493A69CBA993A70C(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildActionsBuildRunGetToOneRelatedFieldsScmPullRequest>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_6BAF0D3664D6EC5D(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildActionsBuildRunGetToOneRelatedIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_EA0666A9CBB378E0(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildActionsBuildRunGetToOneRelatedFieldsBuild?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableCiBuildActionsBuildRunGetToOneRelatedFieldsBuild2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildActionsBuildRunGetToOneRelatedFieldsCiBuildRun?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableCiBuildActionsBuildRunGetToOneRelatedFieldsCiBuildRun2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildActionsBuildRunGetToOneRelatedFieldsCiProduct?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableCiBuildActionsBuildRunGetToOneRelatedFieldsCiProduct2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildActionsBuildRunGetToOneRelatedFieldsCiWorkflow?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableCiBuildActionsBuildRunGetToOneRelatedFieldsCiWorkflow2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildActionsBuildRunGetToOneRelatedFieldsScmGitReference?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableCiBuildActionsBuildRunGetToOneRelatedFieldsScmGitReference2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildActionsBuildRunGetToOneRelatedFieldsScmPullRequest?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableCiBuildActionsBuildRunGetToOneRelatedFieldsScmPullRequest2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildActionsBuildRunGetToOneRelatedIncludeItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableCiBuildActionsBuildRunGetToOneRelatedIncludeItem2(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiBuildActionsBuildRunGetToOneRelatedFieldsBuild>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_D3A0E07183928759(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiBuildActionsBuildRunGetToOneRelatedFieldsCiBuildRun>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_D0EF1BF3474912D4(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiBuildActionsBuildRunGetToOneRelatedFieldsCiProduct>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_625C5FB1D1ADFC0A(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiBuildActionsBuildRunGetToOneRelatedFieldsCiWorkflow>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_4C094D48821E9AB4(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiBuildActionsBuildRunGetToOneRelatedFieldsScmGitReference>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_54B7DC1EEB4BAC0B(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiBuildActionsBuildRunGetToOneRelatedFieldsScmPullRequest>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_415736DD9D8F2960(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiBuildActionsBuildRunGetToOneRelatedIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_42A22784D89142C3(options);
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