
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_F9AC4CB24E1B1B63 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_F9AC4CB24E1B1B63 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_F9AC4CB24E1B1B63(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsGetInstanceFieldsCiWorkflow)

                    || typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsGetInstanceFieldsCiWorkflow?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsGetInstanceFieldsCiProduct)

                    || typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsGetInstanceFieldsCiProduct?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsGetInstanceFieldsScmRepositorie)

                    || typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsGetInstanceFieldsScmRepositorie?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsGetInstanceFieldsCiXcodeVersion)

                    || typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsGetInstanceFieldsCiXcodeVersion?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsGetInstanceFieldsCiMacOsVersion)

                    || typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsGetInstanceFieldsCiMacOsVersion?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsGetInstanceIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsGetInstanceIncludeItem?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsGetInstanceFieldsCiWorkflow))
                {
                    return new global::AppStoreConnect.JsonConverters.CiWorkflowsGetInstanceFieldsCiWorkflowJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsGetInstanceFieldsCiWorkflow?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiWorkflowsGetInstanceFieldsCiWorkflowNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsGetInstanceFieldsCiProduct))
                {
                    return new global::AppStoreConnect.JsonConverters.CiWorkflowsGetInstanceFieldsCiProductJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsGetInstanceFieldsCiProduct?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiWorkflowsGetInstanceFieldsCiProductNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsGetInstanceFieldsScmRepositorie))
                {
                    return new global::AppStoreConnect.JsonConverters.CiWorkflowsGetInstanceFieldsScmRepositorieJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsGetInstanceFieldsScmRepositorie?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiWorkflowsGetInstanceFieldsScmRepositorieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsGetInstanceFieldsCiXcodeVersion))
                {
                    return new global::AppStoreConnect.JsonConverters.CiWorkflowsGetInstanceFieldsCiXcodeVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsGetInstanceFieldsCiXcodeVersion?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiWorkflowsGetInstanceFieldsCiXcodeVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsGetInstanceFieldsCiMacOsVersion))
                {
                    return new global::AppStoreConnect.JsonConverters.CiWorkflowsGetInstanceFieldsCiMacOsVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsGetInstanceFieldsCiMacOsVersion?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiWorkflowsGetInstanceFieldsCiMacOsVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsGetInstanceIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.CiWorkflowsGetInstanceIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsGetInstanceIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiWorkflowsGetInstanceIncludeItemNullableJsonConverter();
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
                if (type == typeof(global::AppStoreConnect.CiWorkflowsGetInstanceFieldsCiMacOsVersion))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_CiWorkflowsGetInstanceFieldsCiMacOsVersion2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiWorkflowsGetInstanceFieldsCiProduct))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_CiWorkflowsGetInstanceFieldsCiProduct2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiWorkflowsGetInstanceFieldsCiWorkflow))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_CiWorkflowsGetInstanceFieldsCiWorkflow2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiWorkflowsGetInstanceFieldsCiXcodeVersion))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_CiWorkflowsGetInstanceFieldsCiXcodeVersion2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiWorkflowsGetInstanceFieldsScmRepositorie))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_CiWorkflowsGetInstanceFieldsScmRepositorie2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiWorkflowsGetInstanceIncludeItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_CiWorkflowsGetInstanceIncludeItem2(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiWorkflowsGetInstanceFieldsCiMacOsVersion>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_0BC00589BB29F298(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiWorkflowsGetInstanceFieldsCiProduct>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_918109AC0A2C2C01(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiWorkflowsGetInstanceFieldsCiWorkflow>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_06F194343F7D1D95(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiWorkflowsGetInstanceFieldsCiXcodeVersion>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_FEFDB28397502520(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiWorkflowsGetInstanceFieldsScmRepositorie>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_DAABF3854F6CD22D(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiWorkflowsGetInstanceIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_E314031BF52122B2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiWorkflowsGetInstanceFieldsCiMacOsVersion?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableCiWorkflowsGetInstanceFieldsCiMacOsVersion2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiWorkflowsGetInstanceFieldsCiProduct?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableCiWorkflowsGetInstanceFieldsCiProduct2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiWorkflowsGetInstanceFieldsCiWorkflow?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableCiWorkflowsGetInstanceFieldsCiWorkflow2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiWorkflowsGetInstanceFieldsCiXcodeVersion?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableCiWorkflowsGetInstanceFieldsCiXcodeVersion2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiWorkflowsGetInstanceFieldsScmRepositorie?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableCiWorkflowsGetInstanceFieldsScmRepositorie2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiWorkflowsGetInstanceIncludeItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableCiWorkflowsGetInstanceIncludeItem2(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiWorkflowsGetInstanceFieldsCiMacOsVersion>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_39F77F1F8928953E(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiWorkflowsGetInstanceFieldsCiProduct>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_6D446C08B8998694(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiWorkflowsGetInstanceFieldsCiWorkflow>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_33848D38E3C9DA0C(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiWorkflowsGetInstanceFieldsCiXcodeVersion>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_99524A866DDD5085(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiWorkflowsGetInstanceFieldsScmRepositorie>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_2B91AAC69499E3BE(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiWorkflowsGetInstanceIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_A91A195B36D7D3E7(options);
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