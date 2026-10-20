
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_B1551711A7F502A3 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_B1551711A7F502A3 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_B1551711A7F502A3(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem32JsonConverter());
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
                    typeToConvert == typeof(global::AppStoreConnect.AppPricePointV3Type)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPricePointV3Type?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPricePointV3RelationshipsAppDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPricePointV3RelationshipsAppDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPricePointV3RelationshipsTerritoryDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPricePointV3RelationshipsTerritoryDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPriceV2Type)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPriceV2Type?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPriceV2RelationshipsAppPricePointDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPriceV2RelationshipsAppPricePointDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPriceV2RelationshipsTerritoryDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPriceV2RelationshipsTerritoryDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPricesV2ResponseIncludedItemDiscriminatorType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPricesV2ResponseIncludedItemDiscriminatorType?)

                    || typeToConvert == typeof(global::AppStoreConnect.TerritoryType)

                    || typeToConvert == typeof(global::AppStoreConnect.TerritoryType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.AppPricePointV3Type))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPricePointV3TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPricePointV3Type?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPricePointV3TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPricePointV3RelationshipsAppDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPricePointV3RelationshipsAppDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPricePointV3RelationshipsAppDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPricePointV3RelationshipsAppDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPricePointV3RelationshipsTerritoryDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPricePointV3RelationshipsTerritoryDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPricePointV3RelationshipsTerritoryDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPricePointV3RelationshipsTerritoryDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPriceV2Type))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPriceV2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPriceV2Type?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPriceV2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPriceV2RelationshipsAppPricePointDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPriceV2RelationshipsAppPricePointDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPriceV2RelationshipsAppPricePointDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPriceV2RelationshipsAppPricePointDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPriceV2RelationshipsTerritoryDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPriceV2RelationshipsTerritoryDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPriceV2RelationshipsTerritoryDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPriceV2RelationshipsTerritoryDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPricesV2ResponseIncludedItemDiscriminatorType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPricesV2ResponseIncludedItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPricesV2ResponseIncludedItemDiscriminatorType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPricesV2ResponseIncludedItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.TerritoryType))
                {
                    return new global::AppStoreConnect.JsonConverters.TerritoryTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.TerritoryType?))
                {
                    return new global::AppStoreConnect.JsonConverters.TerritoryTypeNullableJsonConverter();
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
                if (type == typeof(global::AppStoreConnect.AppPricePointV3))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppPricePointV3(options);
                }
                if (type == typeof(global::AppStoreConnect.AppPricePointV3Attributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppPricePointV3Attributes(options);
                }
                if (type == typeof(global::AppStoreConnect.AppPricePointV3Relationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppPricePointV3Relationships(options);
                }
                if (type == typeof(global::AppStoreConnect.AppPricePointV3RelationshipsApp))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppPricePointV3RelationshipsApp(options);
                }
                if (type == typeof(global::AppStoreConnect.AppPricePointV3RelationshipsAppData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppPricePointV3RelationshipsAppData(options);
                }
                if (type == typeof(global::AppStoreConnect.AppPricePointV3RelationshipsAppDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppPricePointV3RelationshipsAppDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppPricePointV3RelationshipsEqualizations))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppPricePointV3RelationshipsEqualizations(options);
                }
                if (type == typeof(global::AppStoreConnect.AppPricePointV3RelationshipsTerritory))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppPricePointV3RelationshipsTerritory(options);
                }
                if (type == typeof(global::AppStoreConnect.AppPricePointV3RelationshipsTerritoryData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppPricePointV3RelationshipsTerritoryData(options);
                }
                if (type == typeof(global::AppStoreConnect.AppPricePointV3RelationshipsTerritoryDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppPricePointV3RelationshipsTerritoryDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppPricePointV3Type))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppPricePointV3Type2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppPriceV2))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppPriceV2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppPriceV2Attributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppPriceV2Attributes(options);
                }
                if (type == typeof(global::AppStoreConnect.AppPriceV2Relationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppPriceV2Relationships(options);
                }
                if (type == typeof(global::AppStoreConnect.AppPriceV2RelationshipsAppPricePoint))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppPriceV2RelationshipsAppPricePoint(options);
                }
                if (type == typeof(global::AppStoreConnect.AppPriceV2RelationshipsAppPricePointData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppPriceV2RelationshipsAppPricePointData(options);
                }
                if (type == typeof(global::AppStoreConnect.AppPriceV2RelationshipsAppPricePointDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppPriceV2RelationshipsAppPricePointDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppPriceV2RelationshipsTerritory))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppPriceV2RelationshipsTerritory(options);
                }
                if (type == typeof(global::AppStoreConnect.AppPriceV2RelationshipsTerritoryData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppPriceV2RelationshipsTerritoryData(options);
                }
                if (type == typeof(global::AppStoreConnect.AppPriceV2RelationshipsTerritoryDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppPriceV2RelationshipsTerritoryDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppPriceV2Type))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppPriceV2Type2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppPricesV2Response))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppPricesV2Response(options);
                }
                if (type == typeof(global::AppStoreConnect.AppPricesV2ResponseIncludedItemDiscriminator))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppPricesV2ResponseIncludedItemDiscriminator(options);
                }
                if (type == typeof(global::AppStoreConnect.AppPricesV2ResponseIncludedItemDiscriminatorType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppPricesV2ResponseIncludedItemDiscriminatorType2(options);
                }
                if (type == typeof(global::AppStoreConnect.IncludedItem32))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_IncludedItem322(options);
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
                if (type == typeof(global::AppStoreConnect.Territory))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_Territory(options);
                }
                if (type == typeof(global::AppStoreConnect.TerritoryAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_TerritoryAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.TerritoryType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_TerritoryType2(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppPriceV2>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_61481CD1FAA7080D(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.IncludedItem32>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_82A2798ABE0F3C7D(options);
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
                if (type == typeof(global::AppStoreConnect.AppPricePointV3RelationshipsAppDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppPricePointV3RelationshipsAppDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppPricePointV3RelationshipsTerritoryDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppPricePointV3RelationshipsTerritoryDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppPricePointV3Type?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppPricePointV3Type2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppPriceV2RelationshipsAppPricePointDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppPriceV2RelationshipsAppPricePointDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppPriceV2RelationshipsTerritoryDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppPriceV2RelationshipsTerritoryDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppPriceV2Type?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppPriceV2Type2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppPricesV2ResponseIncludedItemDiscriminatorType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppPricesV2ResponseIncludedItemDiscriminatorType2(options);
                }
                if (type == typeof(global::AppStoreConnect.IncludedItem32?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableIncludedItem322(options);
                }
                if (type == typeof(global::AppStoreConnect.TerritoryType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableTerritoryType2(options);
                }
                if (type == typeof(global::System.DateTime?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableDateTime(options);
                }
                if (type == typeof(int?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableInt32(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppPriceV2>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_SourceGenerationContextMetadataType_EFF6E26607A82025(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.IncludedItem32>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_SourceGenerationContextMetadataType_47060FEA7BC2D1DE(options);
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