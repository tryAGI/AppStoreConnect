
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_FAAAA4A9EF045807 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_FAAAA4A9EF045807 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_FAAAA4A9EF045807(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.EndUserLicenseAgreementType)

                    || typeToConvert == typeof(global::AppStoreConnect.EndUserLicenseAgreementType?)

                    || typeToConvert == typeof(global::AppStoreConnect.EndUserLicenseAgreementRelationshipsAppDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.EndUserLicenseAgreementRelationshipsAppDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.EndUserLicenseAgreementRelationshipsTerritoriesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.EndUserLicenseAgreementRelationshipsTerritoriesDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsEndUserLicenseAgreementGetToOneRelatedFieldsEndUserLicenseAgreement)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsEndUserLicenseAgreementGetToOneRelatedFieldsEndUserLicenseAgreement?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.EndUserLicenseAgreementType))
                {
                    return new global::AppStoreConnect.JsonConverters.EndUserLicenseAgreementTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.EndUserLicenseAgreementType?))
                {
                    return new global::AppStoreConnect.JsonConverters.EndUserLicenseAgreementTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.EndUserLicenseAgreementRelationshipsAppDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.EndUserLicenseAgreementRelationshipsAppDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.EndUserLicenseAgreementRelationshipsAppDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.EndUserLicenseAgreementRelationshipsAppDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.EndUserLicenseAgreementRelationshipsTerritoriesDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.EndUserLicenseAgreementRelationshipsTerritoriesDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.EndUserLicenseAgreementRelationshipsTerritoriesDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.EndUserLicenseAgreementRelationshipsTerritoriesDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsEndUserLicenseAgreementGetToOneRelatedFieldsEndUserLicenseAgreement))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsEndUserLicenseAgreementGetToOneRelatedFieldsEndUserLicenseAgreementJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsEndUserLicenseAgreementGetToOneRelatedFieldsEndUserLicenseAgreement?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsEndUserLicenseAgreementGetToOneRelatedFieldsEndUserLicenseAgreementNullableJsonConverter();
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
                if (type == typeof(global::AppStoreConnect.AppsEndUserLicenseAgreementGetToOneRelatedFieldsEndUserLicenseAgreement))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppsEndUserLicenseAgreementGetToOneRelatedFieldsEndUserLicenseAgreement2(options);
                }
                if (type == typeof(global::AppStoreConnect.DocumentLinks))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_DocumentLinks(options);
                }
                if (type == typeof(global::AppStoreConnect.EndUserLicenseAgreement))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_EndUserLicenseAgreement(options);
                }
                if (type == typeof(global::AppStoreConnect.EndUserLicenseAgreementAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_EndUserLicenseAgreementAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.EndUserLicenseAgreementRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_EndUserLicenseAgreementRelationships(options);
                }
                if (type == typeof(global::AppStoreConnect.EndUserLicenseAgreementRelationshipsApp))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_EndUserLicenseAgreementRelationshipsApp(options);
                }
                if (type == typeof(global::AppStoreConnect.EndUserLicenseAgreementRelationshipsAppData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_EndUserLicenseAgreementRelationshipsAppData(options);
                }
                if (type == typeof(global::AppStoreConnect.EndUserLicenseAgreementRelationshipsAppDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_EndUserLicenseAgreementRelationshipsAppDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.EndUserLicenseAgreementRelationshipsTerritories))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_EndUserLicenseAgreementRelationshipsTerritories(options);
                }
                if (type == typeof(global::AppStoreConnect.EndUserLicenseAgreementRelationshipsTerritoriesDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_EndUserLicenseAgreementRelationshipsTerritoriesDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.EndUserLicenseAgreementRelationshipsTerritoriesDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_EndUserLicenseAgreementRelationshipsTerritoriesDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.EndUserLicenseAgreementType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_EndUserLicenseAgreementType2(options);
                }
                if (type == typeof(global::AppStoreConnect.EndUserLicenseAgreementWithoutIncludesResponse))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_EndUserLicenseAgreementWithoutIncludesResponse(options);
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
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppsEndUserLicenseAgreementGetToOneRelatedFieldsEndUserLicenseAgreement>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_5F6B56B821FC3AD3(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.EndUserLicenseAgreementRelationshipsTerritoriesDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_AFC0FEFDD5ECEBEE(options);
                }
                if (type == typeof(int))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_Int32(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsEndUserLicenseAgreementGetToOneRelatedFieldsEndUserLicenseAgreement?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppsEndUserLicenseAgreementGetToOneRelatedFieldsEndUserLicenseAgreement2(options);
                }
                if (type == typeof(global::AppStoreConnect.EndUserLicenseAgreementRelationshipsAppDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableEndUserLicenseAgreementRelationshipsAppDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.EndUserLicenseAgreementRelationshipsTerritoriesDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableEndUserLicenseAgreementRelationshipsTerritoriesDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.EndUserLicenseAgreementType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableEndUserLicenseAgreementType2(options);
                }
                if (type == typeof(int?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableInt32(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppsEndUserLicenseAgreementGetToOneRelatedFieldsEndUserLicenseAgreement>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_F572BCC12738A72C(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.EndUserLicenseAgreementRelationshipsTerritoriesDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_A3C3D233F80FABE6(options);
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