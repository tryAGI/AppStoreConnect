
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ResourceLinks))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.DocumentLinks))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.Platform), TypeInfoPropertyName = "Platform2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetTest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetTestType), TypeInfoPropertyName = "GameCenterMatchmakingRuleSetTestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetTestAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingRuleSetTestAttributesMatchmakingResultItem>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingRuleSetTestAttributesMatchmakingResultItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetTestAttributesMatchmakingResultItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingTeamAssignment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingTeamAssignment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetTestResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.IncludedItem132>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem132), TypeInfoPropertyName = "IncludedItem1322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingTestPlayerProperty))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingTestRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetTestResponseIncludedItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetTestResponseIncludedItemDiscriminatorType), TypeInfoPropertyName = "GameCenterMatchmakingRuleSetTestResponseIncludedItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetTestCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetTestCreateRequestData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetTestCreateRequestDataType), TypeInfoPropertyName = "GameCenterMatchmakingRuleSetTestCreateRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetTestCreateRequestDataRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetTestCreateRequestDataRelationshipsMatchmakingRuleSet))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetTestCreateRequestDataRelationshipsMatchmakingRuleSetData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetTestCreateRequestDataRelationshipsMatchmakingRuleSetDataType), TypeInfoPropertyName = "GameCenterMatchmakingRuleSetTestCreateRequestDataRelationshipsMatchmakingRuleSetDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetTestCreateRequestDataRelationshipsMatchmakingRequests))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingRuleSetTestCreateRequestDataRelationshipsMatchmakingRequestsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetTestCreateRequestDataRelationshipsMatchmakingRequestsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetTestCreateRequestDataRelationshipsMatchmakingRequestsDataItemType), TypeInfoPropertyName = "GameCenterMatchmakingRuleSetTestCreateRequestDataRelationshipsMatchmakingRequestsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.OneOf<global::AppStoreConnect.GameCenterMatchmakingTestPlayerPropertyInlineCreate, global::AppStoreConnect.GameCenterMatchmakingTestRequestInlineCreate>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.OneOf<global::AppStoreConnect.GameCenterMatchmakingTestPlayerPropertyInlineCreate, global::AppStoreConnect.GameCenterMatchmakingTestRequestInlineCreate>), TypeInfoPropertyName = "OneOfGameCenterMatchmakingTestPlayerPropertyInlineCreateGameCenterMatchmakingTestRequestInlineCreate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingTestPlayerPropertyInlineCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingTestRequestInlineCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingTestPlayerPropertyType), TypeInfoPropertyName = "GameCenterMatchmakingTestPlayerPropertyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingTestPlayerPropertyInlineCreateType), TypeInfoPropertyName = "GameCenterMatchmakingTestPlayerPropertyInlineCreateType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingTestPlayerPropertyInlineCreateAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.Property>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.Property))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingTestRequestType), TypeInfoPropertyName = "GameCenterMatchmakingTestRequestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingTestRequestInlineCreateType), TypeInfoPropertyName = "GameCenterMatchmakingTestRequestInlineCreateType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingTestRequestInlineCreateAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingTestRequestInlineCreateAttributesLocale), TypeInfoPropertyName = "GameCenterMatchmakingTestRequestInlineCreateAttributesLocale2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.Location))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingTestRequestInlineCreateRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingTestRequestInlineCreateRelationshipsMatchmakingPlayerProperties))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingTestRequestInlineCreateRelationshipsMatchmakingPlayerPropertiesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingTestRequestInlineCreateRelationshipsMatchmakingPlayerPropertiesDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingTestRequestInlineCreateRelationshipsMatchmakingPlayerPropertiesDataItemType), TypeInfoPropertyName = "GameCenterMatchmakingTestRequestInlineCreateRelationshipsMatchmakingPlayerPropertiesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.ErrorResponseError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ErrorResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.OneOf<global::AppStoreConnect.ErrorSourcePointer, global::AppStoreConnect.ErrorSourceParameter>), TypeInfoPropertyName = "OneOfErrorSourcePointerErrorSourceParameter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ErrorSourcePointer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ErrorSourceParameter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ErrorLinks))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.OneOf<string, global::AppStoreConnect.ErrorLinksAssociated>), TypeInfoPropertyName = "OneOfStringErrorLinksAssociated2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ErrorLinksAssociated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ErrorLinksAssociatedMeta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.Platform?), TypeInfoPropertyName = "NullablePlatform2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetTestType?), TypeInfoPropertyName = "NullableGameCenterMatchmakingRuleSetTestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem132?), TypeInfoPropertyName = "NullableIncludedItem1322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetTestResponseIncludedItemDiscriminatorType?), TypeInfoPropertyName = "NullableGameCenterMatchmakingRuleSetTestResponseIncludedItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetTestCreateRequestDataType?), TypeInfoPropertyName = "NullableGameCenterMatchmakingRuleSetTestCreateRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetTestCreateRequestDataRelationshipsMatchmakingRuleSetDataType?), TypeInfoPropertyName = "NullableGameCenterMatchmakingRuleSetTestCreateRequestDataRelationshipsMatchmakingRuleSetDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetTestCreateRequestDataRelationshipsMatchmakingRequestsDataItemType?), TypeInfoPropertyName = "NullableGameCenterMatchmakingRuleSetTestCreateRequestDataRelationshipsMatchmakingRequestsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.OneOf<global::AppStoreConnect.GameCenterMatchmakingTestPlayerPropertyInlineCreate, global::AppStoreConnect.GameCenterMatchmakingTestRequestInlineCreate>?), TypeInfoPropertyName = "NullableOneOfGameCenterMatchmakingTestPlayerPropertyInlineCreateGameCenterMatchmakingTestRequestInlineCreate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingTestPlayerPropertyType?), TypeInfoPropertyName = "NullableGameCenterMatchmakingTestPlayerPropertyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingTestPlayerPropertyInlineCreateType?), TypeInfoPropertyName = "NullableGameCenterMatchmakingTestPlayerPropertyInlineCreateType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingTestRequestType?), TypeInfoPropertyName = "NullableGameCenterMatchmakingTestRequestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingTestRequestInlineCreateType?), TypeInfoPropertyName = "NullableGameCenterMatchmakingTestRequestInlineCreateType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingTestRequestInlineCreateAttributesLocale?), TypeInfoPropertyName = "NullableGameCenterMatchmakingTestRequestInlineCreateAttributesLocale2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingTestRequestInlineCreateRelationshipsMatchmakingPlayerPropertiesDataItemType?), TypeInfoPropertyName = "NullableGameCenterMatchmakingTestRequestInlineCreateRelationshipsMatchmakingPlayerPropertiesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.OneOf<global::AppStoreConnect.ErrorSourcePointer, global::AppStoreConnect.ErrorSourceParameter>?), TypeInfoPropertyName = "NullableOneOfErrorSourcePointerErrorSourceParameter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.OneOf<string, global::AppStoreConnect.ErrorLinksAssociated>?), TypeInfoPropertyName = "NullableOneOfStringErrorLinksAssociated2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterMatchmakingRuleSetTestAttributesMatchmakingResultItem>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterMatchmakingRuleSetTestAttributesMatchmakingResultItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterMatchmakingTeamAssignment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.IncludedItem132>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterMatchmakingRuleSetTestCreateRequestDataRelationshipsMatchmakingRequestsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.OneOf<global::AppStoreConnect.GameCenterMatchmakingTestPlayerPropertyInlineCreate, global::AppStoreConnect.GameCenterMatchmakingTestRequestInlineCreate>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.Property>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterMatchmakingTestRequestInlineCreateRelationshipsMatchmakingPlayerPropertiesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.ErrorResponseError>))]
    internal sealed partial class GameCenterMatchmakingRuleSetTestsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GameCenterMatchmakingRuleSetTestsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static GameCenterMatchmakingRuleSetTestsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private GameCenterMatchmakingRuleSetTestsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem132JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.OneOfJsonConverter<global::AppStoreConnect.GameCenterMatchmakingTestPlayerPropertyInlineCreate, global::AppStoreConnect.GameCenterMatchmakingTestRequestInlineCreate>());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.OneOfJsonConverter<global::AppStoreConnect.ErrorSourcePointer, global::AppStoreConnect.ErrorSourceParameter>());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.OneOfJsonConverter<string, global::AppStoreConnect.ErrorLinksAssociated>());
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
                    0 => new GameCenterMatchmakingRuleSetTestsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}