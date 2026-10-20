
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_81CE563344BA38AA : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_81CE563344BA38AA Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_81CE563344BA38AA(global::System.Text.Json.JsonSerializerOptions options)
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
            #pragma warning disable CS0618 // Converter references a deprecated API model.
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.OneOfJsonConverter<global::AppStoreConnect.InAppPurchasePriceInlineCreate, global::AppStoreConnect.TerritoryInlineCreate>());
            #pragma warning restore CS0618
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
                    typeToConvert == typeof(global::AppStoreConnect.InAppPurchasePriceScheduleCreateRequestDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchasePriceScheduleCreateRequestDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchasePriceScheduleCreateRequestDataRelationshipsInAppPurchaseDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchasePriceScheduleCreateRequestDataRelationshipsInAppPurchaseDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchasePriceScheduleCreateRequestDataRelationshipsBaseTerritoryDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchasePriceScheduleCreateRequestDataRelationshipsBaseTerritoryDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchasePriceScheduleCreateRequestDataRelationshipsManualPricesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchasePriceScheduleCreateRequestDataRelationshipsManualPricesDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchasePriceInlineCreateType)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchasePriceInlineCreateType?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchasePriceInlineCreateRelationshipsInAppPurchaseV2DataType)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchasePriceInlineCreateRelationshipsInAppPurchaseV2DataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchasePriceInlineCreateRelationshipsInAppPurchasePricePointDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchasePriceInlineCreateRelationshipsInAppPurchasePricePointDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.TerritoryInlineCreateType)

                    || typeToConvert == typeof(global::AppStoreConnect.TerritoryInlineCreateType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchasePriceScheduleCreateRequestDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchasePriceScheduleCreateRequestDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchasePriceScheduleCreateRequestDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchasePriceScheduleCreateRequestDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchasePriceScheduleCreateRequestDataRelationshipsInAppPurchaseDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchasePriceScheduleCreateRequestDataRelationshipsInAppPurchaseDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchasePriceScheduleCreateRequestDataRelationshipsInAppPurchaseDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchasePriceScheduleCreateRequestDataRelationshipsInAppPurchaseDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchasePriceScheduleCreateRequestDataRelationshipsBaseTerritoryDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchasePriceScheduleCreateRequestDataRelationshipsBaseTerritoryDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchasePriceScheduleCreateRequestDataRelationshipsBaseTerritoryDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchasePriceScheduleCreateRequestDataRelationshipsBaseTerritoryDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchasePriceScheduleCreateRequestDataRelationshipsManualPricesDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchasePriceScheduleCreateRequestDataRelationshipsManualPricesDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchasePriceScheduleCreateRequestDataRelationshipsManualPricesDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchasePriceScheduleCreateRequestDataRelationshipsManualPricesDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchasePriceInlineCreateType))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchasePriceInlineCreateTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchasePriceInlineCreateType?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchasePriceInlineCreateTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchasePriceInlineCreateRelationshipsInAppPurchaseV2DataType))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchasePriceInlineCreateRelationshipsInAppPurchaseV2DataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchasePriceInlineCreateRelationshipsInAppPurchaseV2DataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchasePriceInlineCreateRelationshipsInAppPurchaseV2DataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchasePriceInlineCreateRelationshipsInAppPurchasePricePointDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchasePriceInlineCreateRelationshipsInAppPurchasePricePointDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchasePriceInlineCreateRelationshipsInAppPurchasePricePointDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchasePriceInlineCreateRelationshipsInAppPurchasePricePointDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.TerritoryInlineCreateType))
                {
                    return new global::AppStoreConnect.JsonConverters.TerritoryInlineCreateTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.TerritoryInlineCreateType?))
                {
                    return new global::AppStoreConnect.JsonConverters.TerritoryInlineCreateTypeNullableJsonConverter();
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
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchasePriceInlineCreate))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchasePriceInlineCreate(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchasePriceInlineCreateAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchasePriceInlineCreateAttributes(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchasePriceInlineCreateRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchasePriceInlineCreateRelationships(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchasePriceInlineCreateRelationshipsInAppPurchasePricePoint))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchasePriceInlineCreateRelationshipsInAppPurchasePricePoint(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchasePriceInlineCreateRelationshipsInAppPurchasePricePointData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchasePriceInlineCreateRelationshipsInAppPurchasePricePointData(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchasePriceInlineCreateRelationshipsInAppPurchasePricePointDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchasePriceInlineCreateRelationshipsInAppPurchasePricePointDataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchasePriceInlineCreateRelationshipsInAppPurchaseV2))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchasePriceInlineCreateRelationshipsInAppPurchaseV2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchasePriceInlineCreateRelationshipsInAppPurchaseV2Data))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchasePriceInlineCreateRelationshipsInAppPurchaseV2Data(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchasePriceInlineCreateRelationshipsInAppPurchaseV2DataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchasePriceInlineCreateRelationshipsInAppPurchaseV2DataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchasePriceInlineCreateType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchasePriceInlineCreateType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchasePriceScheduleCreateRequest))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchasePriceScheduleCreateRequest(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchasePriceScheduleCreateRequestData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchasePriceScheduleCreateRequestData(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchasePriceScheduleCreateRequestDataRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchasePriceScheduleCreateRequestDataRelationships(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchasePriceScheduleCreateRequestDataRelationshipsBaseTerritory))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchasePriceScheduleCreateRequestDataRelationshipsBaseTerritory(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchasePriceScheduleCreateRequestDataRelationshipsBaseTerritoryData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchasePriceScheduleCreateRequestDataRelationshipsBaseTerritoryData(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchasePriceScheduleCreateRequestDataRelationshipsBaseTerritoryDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchasePriceScheduleCreateRequestDataRelationshipsBaseTerritoryDataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchasePriceScheduleCreateRequestDataRelationshipsInAppPurchase))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchasePriceScheduleCreateRequestDataRelationshipsInAppPurchase(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchasePriceScheduleCreateRequestDataRelationshipsInAppPurchaseData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchasePriceScheduleCreateRequestDataRelationshipsInAppPurchaseData(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchasePriceScheduleCreateRequestDataRelationshipsInAppPurchaseDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchasePriceScheduleCreateRequestDataRelationshipsInAppPurchaseDataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchasePriceScheduleCreateRequestDataRelationshipsManualPrices))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchasePriceScheduleCreateRequestDataRelationshipsManualPrices(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchasePriceScheduleCreateRequestDataRelationshipsManualPricesDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchasePriceScheduleCreateRequestDataRelationshipsManualPricesDataItem(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchasePriceScheduleCreateRequestDataRelationshipsManualPricesDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchasePriceScheduleCreateRequestDataRelationshipsManualPricesDataItemType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchasePriceScheduleCreateRequestDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchasePriceScheduleCreateRequestDataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.OneOf<global::AppStoreConnect.InAppPurchasePriceInlineCreate, global::AppStoreConnect.TerritoryInlineCreate>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_9AE1D460F79216CE(options);
                }
                #pragma warning restore CS0618
                if (type == typeof(global::AppStoreConnect.TerritoryInlineCreate))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_TerritoryInlineCreate(options);
                }
                if (type == typeof(global::AppStoreConnect.TerritoryInlineCreateType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_TerritoryInlineCreateType2(options);
                }
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchasePriceScheduleCreateRequestDataRelationshipsManualPricesDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_815171EDD56D06D5(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.OneOf<global::AppStoreConnect.InAppPurchasePriceInlineCreate, global::AppStoreConnect.TerritoryInlineCreate>>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_C2A0560F7B478A96(options);
                }
                #pragma warning restore CS0618
                if (type == typeof(global::System.DateTime))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_DateTime(options);
                }
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchasePriceInlineCreateRelationshipsInAppPurchasePricePointDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableInAppPurchasePriceInlineCreateRelationshipsInAppPurchasePricePointDataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchasePriceInlineCreateRelationshipsInAppPurchaseV2DataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableInAppPurchasePriceInlineCreateRelationshipsInAppPurchaseV2DataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchasePriceInlineCreateType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableInAppPurchasePriceInlineCreateType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchasePriceScheduleCreateRequestDataRelationshipsBaseTerritoryDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableInAppPurchasePriceScheduleCreateRequestDataRelationshipsBaseTerritoryDataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchasePriceScheduleCreateRequestDataRelationshipsInAppPurchaseDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableInAppPurchasePriceScheduleCreateRequestDataRelationshipsInAppPurchaseDataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchasePriceScheduleCreateRequestDataRelationshipsManualPricesDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableInAppPurchasePriceScheduleCreateRequestDataRelationshipsManualPricesDataItemType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchasePriceScheduleCreateRequestDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableInAppPurchasePriceScheduleCreateRequestDataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.OneOf<global::AppStoreConnect.InAppPurchasePriceInlineCreate, global::AppStoreConnect.TerritoryInlineCreate>?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_SourceGenerationContextMetadataType_FD53118FF3047BC1(options);
                }
                #pragma warning restore CS0618
                if (type == typeof(global::AppStoreConnect.TerritoryInlineCreateType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableTerritoryInlineCreateType2(options);
                }
                if (type == typeof(global::System.DateTime?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableDateTime(options);
                }
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.InAppPurchasePriceScheduleCreateRequestDataRelationshipsManualPricesDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_67A7EEDC1F752C25(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.OneOf<global::AppStoreConnect.InAppPurchasePriceInlineCreate, global::AppStoreConnect.TerritoryInlineCreate>>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_99ED85300EBE61FC(options);
                }
                #pragma warning restore CS0618
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