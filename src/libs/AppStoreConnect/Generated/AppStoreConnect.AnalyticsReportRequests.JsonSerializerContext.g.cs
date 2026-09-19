
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ResourceLinks))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.PagedDocumentLinks))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.PagingInformation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.DocumentLinks))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.RelationshipLinks))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AnalyticsReportRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AnalyticsReportRequestType), TypeInfoPropertyName = "AnalyticsReportRequestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AnalyticsReportRequestAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AnalyticsReportRequestAttributesAccessType), TypeInfoPropertyName = "AnalyticsReportRequestAttributesAccessType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AnalyticsReportRequestRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AnalyticsReportRequestRelationshipsReports))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AnalyticsReportRequestRelationshipsReportsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AnalyticsReportRequestRelationshipsReportsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AnalyticsReportRequestRelationshipsReportsDataItemType), TypeInfoPropertyName = "AnalyticsReportRequestRelationshipsReportsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AnalyticsReport>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AnalyticsReport))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AnalyticsReportRequestResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AnalyticsReportRequestCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AnalyticsReportRequestCreateRequestData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AnalyticsReportRequestCreateRequestDataType), TypeInfoPropertyName = "AnalyticsReportRequestCreateRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AnalyticsReportRequestCreateRequestDataAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AnalyticsReportRequestCreateRequestDataAttributesAccessType), TypeInfoPropertyName = "AnalyticsReportRequestCreateRequestDataAttributesAccessType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AnalyticsReportRequestCreateRequestDataRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AnalyticsReportRequestCreateRequestDataRelationshipsApp))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AnalyticsReportRequestCreateRequestDataRelationshipsAppData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AnalyticsReportRequestCreateRequestDataRelationshipsAppDataType), TypeInfoPropertyName = "AnalyticsReportRequestCreateRequestDataRelationshipsAppDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AnalyticsReportType), TypeInfoPropertyName = "AnalyticsReportType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AnalyticsReportAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AnalyticsReportAttributesCategory), TypeInfoPropertyName = "AnalyticsReportAttributesCategory2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AnalyticsReportRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AnalyticsReportRelationshipsInstances))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AnalyticsReportsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AnalyticsReportRequestReportsLinkagesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AnalyticsReportRequestReportsLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AnalyticsReportRequestReportsLinkagesResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AnalyticsReportRequestReportsLinkagesResponseDataItemType), TypeInfoPropertyName = "AnalyticsReportRequestReportsLinkagesResponseDataItemType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.PagingInformationPaging))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AnalyticsReportRequestsGetInstanceFieldsAnalyticsReportRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AnalyticsReportRequestsGetInstanceFieldsAnalyticsReportRequest), TypeInfoPropertyName = "AnalyticsReportRequestsGetInstanceFieldsAnalyticsReportRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AnalyticsReportRequestsGetInstanceFieldsAnalyticsReport>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AnalyticsReportRequestsGetInstanceFieldsAnalyticsReport), TypeInfoPropertyName = "AnalyticsReportRequestsGetInstanceFieldsAnalyticsReport2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AnalyticsReportRequestsGetInstanceIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AnalyticsReportRequestsGetInstanceIncludeItem), TypeInfoPropertyName = "AnalyticsReportRequestsGetInstanceIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AnalyticsReportRequestsReportsGetToManyRelatedFilterCategoryItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AnalyticsReportRequestsReportsGetToManyRelatedFilterCategoryItem), TypeInfoPropertyName = "AnalyticsReportRequestsReportsGetToManyRelatedFilterCategoryItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AnalyticsReportRequestsReportsGetToManyRelatedFieldsAnalyticsReport>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AnalyticsReportRequestsReportsGetToManyRelatedFieldsAnalyticsReport), TypeInfoPropertyName = "AnalyticsReportRequestsReportsGetToManyRelatedFieldsAnalyticsReport2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AnalyticsReportRequestType?), TypeInfoPropertyName = "NullableAnalyticsReportRequestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AnalyticsReportRequestAttributesAccessType?), TypeInfoPropertyName = "NullableAnalyticsReportRequestAttributesAccessType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AnalyticsReportRequestRelationshipsReportsDataItemType?), TypeInfoPropertyName = "NullableAnalyticsReportRequestRelationshipsReportsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AnalyticsReportRequestCreateRequestDataType?), TypeInfoPropertyName = "NullableAnalyticsReportRequestCreateRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AnalyticsReportRequestCreateRequestDataAttributesAccessType?), TypeInfoPropertyName = "NullableAnalyticsReportRequestCreateRequestDataAttributesAccessType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AnalyticsReportRequestCreateRequestDataRelationshipsAppDataType?), TypeInfoPropertyName = "NullableAnalyticsReportRequestCreateRequestDataRelationshipsAppDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AnalyticsReportType?), TypeInfoPropertyName = "NullableAnalyticsReportType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AnalyticsReportAttributesCategory?), TypeInfoPropertyName = "NullableAnalyticsReportAttributesCategory2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AnalyticsReportRequestReportsLinkagesResponseDataItemType?), TypeInfoPropertyName = "NullableAnalyticsReportRequestReportsLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.OneOf<global::AppStoreConnect.ErrorSourcePointer, global::AppStoreConnect.ErrorSourceParameter>?), TypeInfoPropertyName = "NullableOneOfErrorSourcePointerErrorSourceParameter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.OneOf<string, global::AppStoreConnect.ErrorLinksAssociated>?), TypeInfoPropertyName = "NullableOneOfStringErrorLinksAssociated2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AnalyticsReportRequestsGetInstanceFieldsAnalyticsReportRequest?), TypeInfoPropertyName = "NullableAnalyticsReportRequestsGetInstanceFieldsAnalyticsReportRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AnalyticsReportRequestsGetInstanceFieldsAnalyticsReport?), TypeInfoPropertyName = "NullableAnalyticsReportRequestsGetInstanceFieldsAnalyticsReport2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AnalyticsReportRequestsGetInstanceIncludeItem?), TypeInfoPropertyName = "NullableAnalyticsReportRequestsGetInstanceIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AnalyticsReportRequestsReportsGetToManyRelatedFilterCategoryItem?), TypeInfoPropertyName = "NullableAnalyticsReportRequestsReportsGetToManyRelatedFilterCategoryItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AnalyticsReportRequestsReportsGetToManyRelatedFieldsAnalyticsReport?), TypeInfoPropertyName = "NullableAnalyticsReportRequestsReportsGetToManyRelatedFieldsAnalyticsReport2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AnalyticsReportRequestRelationshipsReportsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AnalyticsReport>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AnalyticsReportRequestReportsLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.ErrorResponseError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AnalyticsReportRequestsGetInstanceFieldsAnalyticsReportRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AnalyticsReportRequestsGetInstanceFieldsAnalyticsReport>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AnalyticsReportRequestsGetInstanceIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AnalyticsReportRequestsReportsGetToManyRelatedFilterCategoryItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AnalyticsReportRequestsReportsGetToManyRelatedFieldsAnalyticsReport>))]
    internal sealed partial class AnalyticsReportRequestsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AnalyticsReportRequestsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static AnalyticsReportRequestsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private AnalyticsReportRequestsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.AnalyticsReportRequestType)

                    || typeToConvert == typeof(global::AppStoreConnect.AnalyticsReportRequestType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AnalyticsReportRequestAttributesAccessType)

                    || typeToConvert == typeof(global::AppStoreConnect.AnalyticsReportRequestAttributesAccessType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AnalyticsReportRequestRelationshipsReportsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AnalyticsReportRequestRelationshipsReportsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AnalyticsReportRequestCreateRequestDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AnalyticsReportRequestCreateRequestDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AnalyticsReportRequestCreateRequestDataAttributesAccessType)

                    || typeToConvert == typeof(global::AppStoreConnect.AnalyticsReportRequestCreateRequestDataAttributesAccessType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AnalyticsReportRequestCreateRequestDataRelationshipsAppDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AnalyticsReportRequestCreateRequestDataRelationshipsAppDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AnalyticsReportType)

                    || typeToConvert == typeof(global::AppStoreConnect.AnalyticsReportType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AnalyticsReportAttributesCategory)

                    || typeToConvert == typeof(global::AppStoreConnect.AnalyticsReportAttributesCategory?)

                    || typeToConvert == typeof(global::AppStoreConnect.AnalyticsReportRequestReportsLinkagesResponseDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AnalyticsReportRequestReportsLinkagesResponseDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AnalyticsReportRequestsGetInstanceFieldsAnalyticsReportRequest)

                    || typeToConvert == typeof(global::AppStoreConnect.AnalyticsReportRequestsGetInstanceFieldsAnalyticsReportRequest?)

                    || typeToConvert == typeof(global::AppStoreConnect.AnalyticsReportRequestsGetInstanceFieldsAnalyticsReport)

                    || typeToConvert == typeof(global::AppStoreConnect.AnalyticsReportRequestsGetInstanceFieldsAnalyticsReport?)

                    || typeToConvert == typeof(global::AppStoreConnect.AnalyticsReportRequestsGetInstanceIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.AnalyticsReportRequestsGetInstanceIncludeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.AnalyticsReportRequestsReportsGetToManyRelatedFilterCategoryItem)

                    || typeToConvert == typeof(global::AppStoreConnect.AnalyticsReportRequestsReportsGetToManyRelatedFilterCategoryItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.AnalyticsReportRequestsReportsGetToManyRelatedFieldsAnalyticsReport)

                    || typeToConvert == typeof(global::AppStoreConnect.AnalyticsReportRequestsReportsGetToManyRelatedFieldsAnalyticsReport?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.AnalyticsReportRequestType))
                {
                    return new global::AppStoreConnect.JsonConverters.AnalyticsReportRequestTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AnalyticsReportRequestType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AnalyticsReportRequestTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AnalyticsReportRequestAttributesAccessType))
                {
                    return new global::AppStoreConnect.JsonConverters.AnalyticsReportRequestAttributesAccessTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AnalyticsReportRequestAttributesAccessType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AnalyticsReportRequestAttributesAccessTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AnalyticsReportRequestRelationshipsReportsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AnalyticsReportRequestRelationshipsReportsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AnalyticsReportRequestRelationshipsReportsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AnalyticsReportRequestRelationshipsReportsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AnalyticsReportRequestCreateRequestDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AnalyticsReportRequestCreateRequestDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AnalyticsReportRequestCreateRequestDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AnalyticsReportRequestCreateRequestDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AnalyticsReportRequestCreateRequestDataAttributesAccessType))
                {
                    return new global::AppStoreConnect.JsonConverters.AnalyticsReportRequestCreateRequestDataAttributesAccessTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AnalyticsReportRequestCreateRequestDataAttributesAccessType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AnalyticsReportRequestCreateRequestDataAttributesAccessTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AnalyticsReportRequestCreateRequestDataRelationshipsAppDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AnalyticsReportRequestCreateRequestDataRelationshipsAppDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AnalyticsReportRequestCreateRequestDataRelationshipsAppDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AnalyticsReportRequestCreateRequestDataRelationshipsAppDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AnalyticsReportType))
                {
                    return new global::AppStoreConnect.JsonConverters.AnalyticsReportTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AnalyticsReportType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AnalyticsReportTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AnalyticsReportAttributesCategory))
                {
                    return new global::AppStoreConnect.JsonConverters.AnalyticsReportAttributesCategoryJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AnalyticsReportAttributesCategory?))
                {
                    return new global::AppStoreConnect.JsonConverters.AnalyticsReportAttributesCategoryNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AnalyticsReportRequestReportsLinkagesResponseDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AnalyticsReportRequestReportsLinkagesResponseDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AnalyticsReportRequestReportsLinkagesResponseDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AnalyticsReportRequestReportsLinkagesResponseDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AnalyticsReportRequestsGetInstanceFieldsAnalyticsReportRequest))
                {
                    return new global::AppStoreConnect.JsonConverters.AnalyticsReportRequestsGetInstanceFieldsAnalyticsReportRequestJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AnalyticsReportRequestsGetInstanceFieldsAnalyticsReportRequest?))
                {
                    return new global::AppStoreConnect.JsonConverters.AnalyticsReportRequestsGetInstanceFieldsAnalyticsReportRequestNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AnalyticsReportRequestsGetInstanceFieldsAnalyticsReport))
                {
                    return new global::AppStoreConnect.JsonConverters.AnalyticsReportRequestsGetInstanceFieldsAnalyticsReportJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AnalyticsReportRequestsGetInstanceFieldsAnalyticsReport?))
                {
                    return new global::AppStoreConnect.JsonConverters.AnalyticsReportRequestsGetInstanceFieldsAnalyticsReportNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AnalyticsReportRequestsGetInstanceIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.AnalyticsReportRequestsGetInstanceIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AnalyticsReportRequestsGetInstanceIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.AnalyticsReportRequestsGetInstanceIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AnalyticsReportRequestsReportsGetToManyRelatedFilterCategoryItem))
                {
                    return new global::AppStoreConnect.JsonConverters.AnalyticsReportRequestsReportsGetToManyRelatedFilterCategoryItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AnalyticsReportRequestsReportsGetToManyRelatedFilterCategoryItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.AnalyticsReportRequestsReportsGetToManyRelatedFilterCategoryItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AnalyticsReportRequestsReportsGetToManyRelatedFieldsAnalyticsReport))
                {
                    return new global::AppStoreConnect.JsonConverters.AnalyticsReportRequestsReportsGetToManyRelatedFieldsAnalyticsReportJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AnalyticsReportRequestsReportsGetToManyRelatedFieldsAnalyticsReport?))
                {
                    return new global::AppStoreConnect.JsonConverters.AnalyticsReportRequestsReportsGetToManyRelatedFieldsAnalyticsReportNullableJsonConverter();
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
                    0 => new AnalyticsReportRequestsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}