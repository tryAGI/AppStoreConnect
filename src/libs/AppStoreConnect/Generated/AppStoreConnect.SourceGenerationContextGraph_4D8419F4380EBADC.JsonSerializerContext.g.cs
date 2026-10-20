
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_4D8419F4380EBADC : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_4D8419F4380EBADC Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_4D8419F4380EBADC(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem134JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.OneOfJsonConverter<global::AppStoreConnect.GameCenterMatchmakingTestPlayerPropertyInlineCreate, global::AppStoreConnect.GameCenterMatchmakingTestRequestInlineCreate>());
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
                    typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetTestType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetTestType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetTestResponseIncludedItemDiscriminatorType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetTestResponseIncludedItemDiscriminatorType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetTestCreateRequestDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetTestCreateRequestDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetTestCreateRequestDataRelationshipsMatchmakingRuleSetDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetTestCreateRequestDataRelationshipsMatchmakingRuleSetDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetTestCreateRequestDataRelationshipsMatchmakingRequestsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetTestCreateRequestDataRelationshipsMatchmakingRequestsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingTestPlayerPropertyType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingTestPlayerPropertyType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingTestPlayerPropertyInlineCreateType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingTestPlayerPropertyInlineCreateType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingTestRequestType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingTestRequestType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingTestRequestInlineCreateType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingTestRequestInlineCreateType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingTestRequestInlineCreateAttributesLocale)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingTestRequestInlineCreateAttributesLocale?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingTestRequestInlineCreateRelationshipsMatchmakingPlayerPropertiesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingTestRequestInlineCreateRelationshipsMatchmakingPlayerPropertiesDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.Platform)

                    || typeToConvert == typeof(global::AppStoreConnect.Platform?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetTestType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRuleSetTestTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetTestType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRuleSetTestTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetTestResponseIncludedItemDiscriminatorType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRuleSetTestResponseIncludedItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetTestResponseIncludedItemDiscriminatorType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRuleSetTestResponseIncludedItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetTestCreateRequestDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRuleSetTestCreateRequestDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetTestCreateRequestDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRuleSetTestCreateRequestDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetTestCreateRequestDataRelationshipsMatchmakingRuleSetDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRuleSetTestCreateRequestDataRelationshipsMatchmakingRuleSetDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetTestCreateRequestDataRelationshipsMatchmakingRuleSetDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRuleSetTestCreateRequestDataRelationshipsMatchmakingRuleSetDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetTestCreateRequestDataRelationshipsMatchmakingRequestsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRuleSetTestCreateRequestDataRelationshipsMatchmakingRequestsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetTestCreateRequestDataRelationshipsMatchmakingRequestsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRuleSetTestCreateRequestDataRelationshipsMatchmakingRequestsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingTestPlayerPropertyType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingTestPlayerPropertyTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingTestPlayerPropertyType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingTestPlayerPropertyTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingTestPlayerPropertyInlineCreateType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingTestPlayerPropertyInlineCreateTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingTestPlayerPropertyInlineCreateType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingTestPlayerPropertyInlineCreateTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingTestRequestType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingTestRequestTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingTestRequestType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingTestRequestTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingTestRequestInlineCreateType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingTestRequestInlineCreateTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingTestRequestInlineCreateType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingTestRequestInlineCreateTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingTestRequestInlineCreateAttributesLocale))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingTestRequestInlineCreateAttributesLocaleJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingTestRequestInlineCreateAttributesLocale?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingTestRequestInlineCreateAttributesLocaleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingTestRequestInlineCreateRelationshipsMatchmakingPlayerPropertiesDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingTestRequestInlineCreateRelationshipsMatchmakingPlayerPropertiesDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingTestRequestInlineCreateRelationshipsMatchmakingPlayerPropertiesDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingTestRequestInlineCreateRelationshipsMatchmakingPlayerPropertiesDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.Platform))
                {
                    return new global::AppStoreConnect.JsonConverters.PlatformJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.Platform?))
                {
                    return new global::AppStoreConnect.JsonConverters.PlatformNullableJsonConverter();
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
                if (type == typeof(global::AppStoreConnect.DocumentLinks))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_DocumentLinks(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetTest))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_GameCenterMatchmakingRuleSetTest(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetTestAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_GameCenterMatchmakingRuleSetTestAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetTestAttributesMatchmakingResultItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_GameCenterMatchmakingRuleSetTestAttributesMatchmakingResultItem(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetTestCreateRequest))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_GameCenterMatchmakingRuleSetTestCreateRequest(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetTestCreateRequestData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_GameCenterMatchmakingRuleSetTestCreateRequestData(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetTestCreateRequestDataRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_GameCenterMatchmakingRuleSetTestCreateRequestDataRelationships(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetTestCreateRequestDataRelationshipsMatchmakingRequests))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_GameCenterMatchmakingRuleSetTestCreateRequestDataRelationshipsMatchmakingRequests(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetTestCreateRequestDataRelationshipsMatchmakingRequestsDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_GameCenterMatchmakingRuleSetTestCreateRequestDataRelationshipsMatchmakingRequestsDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetTestCreateRequestDataRelationshipsMatchmakingRequestsDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_GameCenterMatchmakingRuleSetTestCreateRequestDataRelationshipsMatchmakingRequestsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetTestCreateRequestDataRelationshipsMatchmakingRuleSet))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_GameCenterMatchmakingRuleSetTestCreateRequestDataRelationshipsMatchmakingRuleSet(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetTestCreateRequestDataRelationshipsMatchmakingRuleSetData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_GameCenterMatchmakingRuleSetTestCreateRequestDataRelationshipsMatchmakingRuleSetData(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetTestCreateRequestDataRelationshipsMatchmakingRuleSetDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_GameCenterMatchmakingRuleSetTestCreateRequestDataRelationshipsMatchmakingRuleSetDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetTestCreateRequestDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_GameCenterMatchmakingRuleSetTestCreateRequestDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetTestResponse))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_GameCenterMatchmakingRuleSetTestResponse(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetTestResponseIncludedItemDiscriminator))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_GameCenterMatchmakingRuleSetTestResponseIncludedItemDiscriminator(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetTestResponseIncludedItemDiscriminatorType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_GameCenterMatchmakingRuleSetTestResponseIncludedItemDiscriminatorType2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetTestType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_GameCenterMatchmakingRuleSetTestType2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingTeamAssignment))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_GameCenterMatchmakingTeamAssignment(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingTestPlayerProperty))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_GameCenterMatchmakingTestPlayerProperty(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingTestPlayerPropertyInlineCreate))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_GameCenterMatchmakingTestPlayerPropertyInlineCreate(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingTestPlayerPropertyInlineCreateAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_GameCenterMatchmakingTestPlayerPropertyInlineCreateAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingTestPlayerPropertyInlineCreateType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_GameCenterMatchmakingTestPlayerPropertyInlineCreateType2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingTestPlayerPropertyType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_GameCenterMatchmakingTestPlayerPropertyType2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingTestRequest))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_GameCenterMatchmakingTestRequest(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingTestRequestInlineCreate))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_GameCenterMatchmakingTestRequestInlineCreate(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingTestRequestInlineCreateAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_GameCenterMatchmakingTestRequestInlineCreateAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingTestRequestInlineCreateAttributesLocale))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_GameCenterMatchmakingTestRequestInlineCreateAttributesLocale2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingTestRequestInlineCreateRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_GameCenterMatchmakingTestRequestInlineCreateRelationships(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingTestRequestInlineCreateRelationshipsMatchmakingPlayerProperties))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_GameCenterMatchmakingTestRequestInlineCreateRelationshipsMatchmakingPlayerProperties(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingTestRequestInlineCreateRelationshipsMatchmakingPlayerPropertiesDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_GameCenterMatchmakingTestRequestInlineCreateRelationshipsMatchmakingPlayerPropertiesDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingTestRequestInlineCreateRelationshipsMatchmakingPlayerPropertiesDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_GameCenterMatchmakingTestRequestInlineCreateRelationshipsMatchmakingPlayerPropertiesDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingTestRequestInlineCreateType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_GameCenterMatchmakingTestRequestInlineCreateType2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingTestRequestType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_GameCenterMatchmakingTestRequestType2(options);
                }
                if (type == typeof(global::AppStoreConnect.IncludedItem134))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_IncludedItem1342(options);
                }
                if (type == typeof(global::AppStoreConnect.Location))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_Location(options);
                }
                if (type == typeof(global::AppStoreConnect.OneOf<global::AppStoreConnect.GameCenterMatchmakingTestPlayerPropertyInlineCreate, global::AppStoreConnect.GameCenterMatchmakingTestRequestInlineCreate>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_3A1FE2E3AE05CCF4(options);
                }
                if (type == typeof(global::AppStoreConnect.Platform))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_Platform2(options);
                }
                if (type == typeof(global::AppStoreConnect.Property))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_Property(options);
                }
                if (type == typeof(global::AppStoreConnect.ResourceLinks))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_ResourceLinks(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingRuleSetTestAttributesMatchmakingResultItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_BE28FAA8BCCF3248(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingRuleSetTestCreateRequestDataRelationshipsMatchmakingRequestsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_7B7B8D649C63C3D6(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingTeamAssignment>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_71DAAF5CAE0F4C0D(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingTestRequestInlineCreateRelationshipsMatchmakingPlayerPropertiesDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_1CD0E41195055014(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.IncludedItem134>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_540B0AC978FC12F0(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.OneOf<global::AppStoreConnect.GameCenterMatchmakingTestPlayerPropertyInlineCreate, global::AppStoreConnect.GameCenterMatchmakingTestRequestInlineCreate>>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_3D091AA8F763C66E(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.Property>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_1FFC35C6FD43C2C2(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingRuleSetTestAttributesMatchmakingResultItem>>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_6F40CF3AF8C6A12E(options);
                }
                if (type == typeof(int))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_Int32(options);
                }
                if (type == typeof(double?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableDouble(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetTestCreateRequestDataRelationshipsMatchmakingRequestsDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableGameCenterMatchmakingRuleSetTestCreateRequestDataRelationshipsMatchmakingRequestsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetTestCreateRequestDataRelationshipsMatchmakingRuleSetDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableGameCenterMatchmakingRuleSetTestCreateRequestDataRelationshipsMatchmakingRuleSetDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetTestCreateRequestDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableGameCenterMatchmakingRuleSetTestCreateRequestDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetTestResponseIncludedItemDiscriminatorType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableGameCenterMatchmakingRuleSetTestResponseIncludedItemDiscriminatorType2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetTestType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableGameCenterMatchmakingRuleSetTestType2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingTestPlayerPropertyInlineCreateType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableGameCenterMatchmakingTestPlayerPropertyInlineCreateType2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingTestPlayerPropertyType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableGameCenterMatchmakingTestPlayerPropertyType2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingTestRequestInlineCreateAttributesLocale?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableGameCenterMatchmakingTestRequestInlineCreateAttributesLocale2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingTestRequestInlineCreateRelationshipsMatchmakingPlayerPropertiesDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableGameCenterMatchmakingTestRequestInlineCreateRelationshipsMatchmakingPlayerPropertiesDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingTestRequestInlineCreateType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableGameCenterMatchmakingTestRequestInlineCreateType2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingTestRequestType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableGameCenterMatchmakingTestRequestType2(options);
                }
                if (type == typeof(global::AppStoreConnect.IncludedItem134?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableIncludedItem1342(options);
                }
                if (type == typeof(global::AppStoreConnect.OneOf<global::AppStoreConnect.GameCenterMatchmakingTestPlayerPropertyInlineCreate, global::AppStoreConnect.GameCenterMatchmakingTestRequestInlineCreate>?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_SourceGenerationContextMetadataType_5108958BFD2B8FB3(options);
                }
                if (type == typeof(global::AppStoreConnect.Platform?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullablePlatform2(options);
                }
                if (type == typeof(int?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableInt32(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterMatchmakingRuleSetTestAttributesMatchmakingResultItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_D505CDDC44EF648A(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterMatchmakingRuleSetTestCreateRequestDataRelationshipsMatchmakingRequestsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_8D396B27B78112C4(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterMatchmakingTeamAssignment>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_E6EDA4593E2F4345(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterMatchmakingTestRequestInlineCreateRelationshipsMatchmakingPlayerPropertiesDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_5E6D001ED26A24D4(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.IncludedItem134>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_EACC1336F2DCC934(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.OneOf<global::AppStoreConnect.GameCenterMatchmakingTestPlayerPropertyInlineCreate, global::AppStoreConnect.GameCenterMatchmakingTestRequestInlineCreate>>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_A4F16A992F3B8A72(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.Property>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_E6B6A4CCF34BC685(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterMatchmakingRuleSetTestAttributesMatchmakingResultItem>>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_7C7B74855766DC78(options);
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