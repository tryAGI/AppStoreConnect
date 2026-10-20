
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_0B93C61D0E042FD8 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_0B93C61D0E042FD8 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_0B93C61D0E042FD8(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem143JsonConverter());
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
                    typeToConvert == typeof(global::AppStoreConnect.InAppPurchasePricePointType)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchasePricePointType?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchasePricePointRelationshipsTerritoryDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchasePricePointRelationshipsTerritoryDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchasePriceType)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchasePriceType?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchasePriceRelationshipsInAppPurchasePricePointDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchasePriceRelationshipsInAppPurchasePricePointDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchasePriceRelationshipsTerritoryDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchasePriceRelationshipsTerritoryDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchasePricesResponseIncludedItemDiscriminatorType)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchasePricesResponseIncludedItemDiscriminatorType?)

                    || typeToConvert == typeof(global::AppStoreConnect.TerritoryType)

                    || typeToConvert == typeof(global::AppStoreConnect.TerritoryType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchasePricePointType))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchasePricePointTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchasePricePointType?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchasePricePointTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchasePricePointRelationshipsTerritoryDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchasePricePointRelationshipsTerritoryDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchasePricePointRelationshipsTerritoryDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchasePricePointRelationshipsTerritoryDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchasePriceType))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchasePriceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchasePriceType?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchasePriceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchasePriceRelationshipsInAppPurchasePricePointDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchasePriceRelationshipsInAppPurchasePricePointDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchasePriceRelationshipsInAppPurchasePricePointDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchasePriceRelationshipsInAppPurchasePricePointDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchasePriceRelationshipsTerritoryDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchasePriceRelationshipsTerritoryDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchasePriceRelationshipsTerritoryDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchasePriceRelationshipsTerritoryDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchasePricesResponseIncludedItemDiscriminatorType))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchasePricesResponseIncludedItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchasePricesResponseIncludedItemDiscriminatorType?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchasePricesResponseIncludedItemDiscriminatorTypeNullableJsonConverter();
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
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchasePrice))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchasePrice(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchasePriceAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchasePriceAttributes(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchasePricePoint))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchasePricePoint(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchasePricePointAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchasePricePointAttributes(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchasePricePointRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchasePricePointRelationships(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchasePricePointRelationshipsEqualizations))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchasePricePointRelationshipsEqualizations(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchasePricePointRelationshipsTerritory))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchasePricePointRelationshipsTerritory(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchasePricePointRelationshipsTerritoryData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchasePricePointRelationshipsTerritoryData(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchasePricePointRelationshipsTerritoryDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchasePricePointRelationshipsTerritoryDataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchasePricePointType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchasePricePointType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchasePriceRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchasePriceRelationships(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchasePriceRelationshipsInAppPurchasePricePoint))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchasePriceRelationshipsInAppPurchasePricePoint(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchasePriceRelationshipsInAppPurchasePricePointData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchasePriceRelationshipsInAppPurchasePricePointData(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchasePriceRelationshipsInAppPurchasePricePointDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchasePriceRelationshipsInAppPurchasePricePointDataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchasePriceRelationshipsTerritory))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchasePriceRelationshipsTerritory(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchasePriceRelationshipsTerritoryData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchasePriceRelationshipsTerritoryData(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchasePriceRelationshipsTerritoryDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchasePriceRelationshipsTerritoryDataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchasePriceType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchasePriceType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchasePricesResponse))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchasePricesResponse(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchasePricesResponseIncludedItemDiscriminator))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchasePricesResponseIncludedItemDiscriminator(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchasePricesResponseIncludedItemDiscriminatorType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchasePricesResponseIncludedItemDiscriminatorType2(options);
                }
                #pragma warning restore CS0618
                if (type == typeof(global::AppStoreConnect.IncludedItem143))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_IncludedItem1432(options);
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
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchasePrice>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_43B60FFE55B4AF7F(options);
                }
                #pragma warning restore CS0618
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.IncludedItem143>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_BA6EA53ED0AB17E3(options);
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
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchasePricePointRelationshipsTerritoryDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableInAppPurchasePricePointRelationshipsTerritoryDataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchasePricePointType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableInAppPurchasePricePointType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchasePriceRelationshipsInAppPurchasePricePointDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableInAppPurchasePriceRelationshipsInAppPurchasePricePointDataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchasePriceRelationshipsTerritoryDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableInAppPurchasePriceRelationshipsTerritoryDataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchasePriceType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableInAppPurchasePriceType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchasePricesResponseIncludedItemDiscriminatorType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableInAppPurchasePricesResponseIncludedItemDiscriminatorType2(options);
                }
                #pragma warning restore CS0618
                if (type == typeof(global::AppStoreConnect.IncludedItem143?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableIncludedItem1432(options);
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
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.InAppPurchasePrice>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_F82991053431665B(options);
                }
                #pragma warning restore CS0618
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.IncludedItem143>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_B184F671D5A901DD(options);
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