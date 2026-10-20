
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_4FE9EFC9A08C24B8 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_4FE9EFC9A08C24B8 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_4FE9EFC9A08C24B8(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.CertificateType)

                    || typeToConvert == typeof(global::AppStoreConnect.CertificateType?)

                    || typeToConvert == typeof(global::AppStoreConnect.CertificateRelationshipsPassTypeIdDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.CertificateRelationshipsPassTypeIdDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BundleIdPlatform)

                    || typeToConvert == typeof(global::AppStoreConnect.BundleIdPlatform?)

                    || typeToConvert == typeof(global::AppStoreConnect.CertificateType2)

                    || typeToConvert == typeof(global::AppStoreConnect.CertificateType2?)

                    || typeToConvert == typeof(global::AppStoreConnect.ProfilesCertificatesGetToManyRelatedFieldsCertificate)

                    || typeToConvert == typeof(global::AppStoreConnect.ProfilesCertificatesGetToManyRelatedFieldsCertificate?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.CertificateType))
                {
                    return new global::AppStoreConnect.JsonConverters.CertificateTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CertificateType?))
                {
                    return new global::AppStoreConnect.JsonConverters.CertificateTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CertificateRelationshipsPassTypeIdDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.CertificateRelationshipsPassTypeIdDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CertificateRelationshipsPassTypeIdDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.CertificateRelationshipsPassTypeIdDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BundleIdPlatform))
                {
                    return new global::AppStoreConnect.JsonConverters.BundleIdPlatformJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BundleIdPlatform?))
                {
                    return new global::AppStoreConnect.JsonConverters.BundleIdPlatformNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CertificateType2))
                {
                    return new global::AppStoreConnect.JsonConverters.CertificateType2JsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CertificateType2?))
                {
                    return new global::AppStoreConnect.JsonConverters.CertificateType2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ProfilesCertificatesGetToManyRelatedFieldsCertificate))
                {
                    return new global::AppStoreConnect.JsonConverters.ProfilesCertificatesGetToManyRelatedFieldsCertificateJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ProfilesCertificatesGetToManyRelatedFieldsCertificate?))
                {
                    return new global::AppStoreConnect.JsonConverters.ProfilesCertificatesGetToManyRelatedFieldsCertificateNullableJsonConverter();
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
                if (type == typeof(bool))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_Boolean(options);
                }
                if (type == typeof(global::AppStoreConnect.BundleIdPlatform))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BundleIdPlatform2(options);
                }
                if (type == typeof(global::AppStoreConnect.Certificate))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_Certificate(options);
                }
                if (type == typeof(global::AppStoreConnect.CertificateAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CertificateAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.CertificateRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CertificateRelationships(options);
                }
                if (type == typeof(global::AppStoreConnect.CertificateRelationshipsPassTypeId))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CertificateRelationshipsPassTypeId(options);
                }
                if (type == typeof(global::AppStoreConnect.CertificateRelationshipsPassTypeIdData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CertificateRelationshipsPassTypeIdData(options);
                }
                if (type == typeof(global::AppStoreConnect.CertificateRelationshipsPassTypeIdDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CertificateRelationshipsPassTypeIdDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.CertificateType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CertificateType2_3(options);
                }
                if (type == typeof(global::AppStoreConnect.CertificateType2))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CertificateType22(options);
                }
                if (type == typeof(global::AppStoreConnect.CertificatesWithoutIncludesResponse))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_CertificatesWithoutIncludesResponse(options);
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
                if (type == typeof(global::AppStoreConnect.ProfilesCertificatesGetToManyRelatedFieldsCertificate))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_ProfilesCertificatesGetToManyRelatedFieldsCertificate2(options);
                }
                if (type == typeof(global::AppStoreConnect.RelationshipLinks))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_RelationshipLinks(options);
                }
                if (type == typeof(global::AppStoreConnect.ResourceLinks))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_ResourceLinks(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.Certificate>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_148437F9FD10A8EA(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.ProfilesCertificatesGetToManyRelatedFieldsCertificate>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_SourceGenerationContextMetadataType_D9A9372FC1D70B31(options);
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
                if (type == typeof(global::AppStoreConnect.BundleIdPlatform?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBundleIdPlatform2(options);
                }
                if (type == typeof(global::AppStoreConnect.CertificateRelationshipsPassTypeIdDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableCertificateRelationshipsPassTypeIdDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.CertificateType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableCertificateType2_3(options);
                }
                if (type == typeof(global::AppStoreConnect.CertificateType2?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableCertificateType22(options);
                }
                if (type == typeof(global::AppStoreConnect.ProfilesCertificatesGetToManyRelatedFieldsCertificate?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableProfilesCertificatesGetToManyRelatedFieldsCertificate2(options);
                }
                if (type == typeof(global::System.DateTime?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableDateTime(options);
                }
                if (type == typeof(int?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableInt32(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.Certificate>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_90DEBE9CADE5527C(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.ProfilesCertificatesGetToManyRelatedFieldsCertificate>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_4ECA3789F95B6845(options);
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