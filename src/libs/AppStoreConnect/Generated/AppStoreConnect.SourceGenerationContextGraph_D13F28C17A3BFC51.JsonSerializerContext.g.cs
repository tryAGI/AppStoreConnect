
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_D13F28C17A3BFC51 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_D13F28C17A3BFC51 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_D13F28C17A3BFC51(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.DiagnosticSignatureType)

                    || typeToConvert == typeof(global::AppStoreConnect.DiagnosticSignatureType?)

                    || typeToConvert == typeof(global::AppStoreConnect.DiagnosticSignatureAttributesDiagnosticType)

                    || typeToConvert == typeof(global::AppStoreConnect.DiagnosticSignatureAttributesDiagnosticType?)

                    || typeToConvert == typeof(global::AppStoreConnect.DiagnosticInsightDirection)

                    || typeToConvert == typeof(global::AppStoreConnect.DiagnosticInsightDirection?)

                    || typeToConvert == typeof(global::AppStoreConnect.DiagnosticInsightType)

                    || typeToConvert == typeof(global::AppStoreConnect.DiagnosticInsightType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsDiagnosticSignaturesGetToManyRelatedFilterDiagnosticTypeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsDiagnosticSignaturesGetToManyRelatedFilterDiagnosticTypeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsDiagnosticSignaturesGetToManyRelatedFieldsDiagnosticSignature)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsDiagnosticSignaturesGetToManyRelatedFieldsDiagnosticSignature?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.DiagnosticSignatureType))
                {
                    return new global::AppStoreConnect.JsonConverters.DiagnosticSignatureTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.DiagnosticSignatureType?))
                {
                    return new global::AppStoreConnect.JsonConverters.DiagnosticSignatureTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.DiagnosticSignatureAttributesDiagnosticType))
                {
                    return new global::AppStoreConnect.JsonConverters.DiagnosticSignatureAttributesDiagnosticTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.DiagnosticSignatureAttributesDiagnosticType?))
                {
                    return new global::AppStoreConnect.JsonConverters.DiagnosticSignatureAttributesDiagnosticTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.DiagnosticInsightDirection))
                {
                    return new global::AppStoreConnect.JsonConverters.DiagnosticInsightDirectionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.DiagnosticInsightDirection?))
                {
                    return new global::AppStoreConnect.JsonConverters.DiagnosticInsightDirectionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.DiagnosticInsightType))
                {
                    return new global::AppStoreConnect.JsonConverters.DiagnosticInsightTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.DiagnosticInsightType?))
                {
                    return new global::AppStoreConnect.JsonConverters.DiagnosticInsightTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsDiagnosticSignaturesGetToManyRelatedFilterDiagnosticTypeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsDiagnosticSignaturesGetToManyRelatedFilterDiagnosticTypeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsDiagnosticSignaturesGetToManyRelatedFilterDiagnosticTypeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsDiagnosticSignaturesGetToManyRelatedFilterDiagnosticTypeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsDiagnosticSignaturesGetToManyRelatedFieldsDiagnosticSignature))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsDiagnosticSignaturesGetToManyRelatedFieldsDiagnosticSignatureJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsDiagnosticSignaturesGetToManyRelatedFieldsDiagnosticSignature?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsDiagnosticSignaturesGetToManyRelatedFieldsDiagnosticSignatureNullableJsonConverter();
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
                if (type == typeof(double))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_Double(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildsDiagnosticSignaturesGetToManyRelatedFieldsDiagnosticSignature))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_BuildsDiagnosticSignaturesGetToManyRelatedFieldsDiagnosticSignature2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildsDiagnosticSignaturesGetToManyRelatedFilterDiagnosticTypeItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_BuildsDiagnosticSignaturesGetToManyRelatedFilterDiagnosticTypeItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.DiagnosticInsight))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_DiagnosticInsight(options);
                }
                if (type == typeof(global::AppStoreConnect.DiagnosticInsightDirection))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_DiagnosticInsightDirection2(options);
                }
                if (type == typeof(global::AppStoreConnect.DiagnosticInsightReferenceVersion))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_DiagnosticInsightReferenceVersion(options);
                }
                if (type == typeof(global::AppStoreConnect.DiagnosticInsightType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_DiagnosticInsightType2(options);
                }
                if (type == typeof(global::AppStoreConnect.DiagnosticSignature))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_DiagnosticSignature(options);
                }
                if (type == typeof(global::AppStoreConnect.DiagnosticSignatureAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_DiagnosticSignatureAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.DiagnosticSignatureAttributesDiagnosticType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_DiagnosticSignatureAttributesDiagnosticType2(options);
                }
                if (type == typeof(global::AppStoreConnect.DiagnosticSignatureRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_DiagnosticSignatureRelationships(options);
                }
                if (type == typeof(global::AppStoreConnect.DiagnosticSignatureRelationshipsLogs))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_DiagnosticSignatureRelationshipsLogs(options);
                }
                if (type == typeof(global::AppStoreConnect.DiagnosticSignatureType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_DiagnosticSignatureType2(options);
                }
                if (type == typeof(global::AppStoreConnect.DiagnosticSignaturesResponse))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_DiagnosticSignaturesResponse(options);
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
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsDiagnosticSignaturesGetToManyRelatedFieldsDiagnosticSignature>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_11FDCE6B76FB85CB(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsDiagnosticSignaturesGetToManyRelatedFilterDiagnosticTypeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_196C547ECE846221(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.DiagnosticInsightReferenceVersion>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_CBDB26B63D19566D(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.DiagnosticSignature>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_ECB0A180040E4F18(options);
                }
                if (type == typeof(int))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_Int32(options);
                }
                if (type == typeof(double?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableDouble(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildsDiagnosticSignaturesGetToManyRelatedFieldsDiagnosticSignature?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableBuildsDiagnosticSignaturesGetToManyRelatedFieldsDiagnosticSignature2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildsDiagnosticSignaturesGetToManyRelatedFilterDiagnosticTypeItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableBuildsDiagnosticSignaturesGetToManyRelatedFilterDiagnosticTypeItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.DiagnosticInsightDirection?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableDiagnosticInsightDirection2(options);
                }
                if (type == typeof(global::AppStoreConnect.DiagnosticInsightType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableDiagnosticInsightType2(options);
                }
                if (type == typeof(global::AppStoreConnect.DiagnosticSignatureAttributesDiagnosticType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableDiagnosticSignatureAttributesDiagnosticType2(options);
                }
                if (type == typeof(global::AppStoreConnect.DiagnosticSignatureType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableDiagnosticSignatureType2(options);
                }
                if (type == typeof(int?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableInt32(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildsDiagnosticSignaturesGetToManyRelatedFieldsDiagnosticSignature>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_0D68B588E810CE3E(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildsDiagnosticSignaturesGetToManyRelatedFilterDiagnosticTypeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_874521ED3FAFA2EF(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.DiagnosticInsightReferenceVersion>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_411BE6837AB6DEE5(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.DiagnosticSignature>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_E70638F9948F1D70(options);
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