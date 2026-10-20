
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_CEACB3568C4DD6AB : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_CEACB3568C4DD6AB Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_CEACB3568C4DD6AB(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.AnalyticsReportRequestType)

                    || typeToConvert == typeof(global::AppStoreConnect.AnalyticsReportRequestType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AnalyticsReportRequestAttributesAccessType)

                    || typeToConvert == typeof(global::AppStoreConnect.AnalyticsReportRequestAttributesAccessType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AnalyticsReportRequestRelationshipsReportsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AnalyticsReportRequestRelationshipsReportsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AnalyticsReportType)

                    || typeToConvert == typeof(global::AppStoreConnect.AnalyticsReportType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AnalyticsReportAttributesCategory)

                    || typeToConvert == typeof(global::AppStoreConnect.AnalyticsReportAttributesCategory?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsAnalyticsReportRequestsGetToManyRelatedFilterAccessTypeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsAnalyticsReportRequestsGetToManyRelatedFilterAccessTypeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsAnalyticsReportRequestsGetToManyRelatedFieldsAnalyticsReportRequest)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsAnalyticsReportRequestsGetToManyRelatedFieldsAnalyticsReportRequest?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsAnalyticsReportRequestsGetToManyRelatedFieldsAnalyticsReport)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsAnalyticsReportRequestsGetToManyRelatedFieldsAnalyticsReport?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsAnalyticsReportRequestsGetToManyRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsAnalyticsReportRequestsGetToManyRelatedIncludeItem?);
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

                if (typeToConvert == typeof(global::AppStoreConnect.AppsAnalyticsReportRequestsGetToManyRelatedFilterAccessTypeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsAnalyticsReportRequestsGetToManyRelatedFilterAccessTypeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsAnalyticsReportRequestsGetToManyRelatedFilterAccessTypeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsAnalyticsReportRequestsGetToManyRelatedFilterAccessTypeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsAnalyticsReportRequestsGetToManyRelatedFieldsAnalyticsReportRequest))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsAnalyticsReportRequestsGetToManyRelatedFieldsAnalyticsReportRequestJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsAnalyticsReportRequestsGetToManyRelatedFieldsAnalyticsReportRequest?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsAnalyticsReportRequestsGetToManyRelatedFieldsAnalyticsReportRequestNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsAnalyticsReportRequestsGetToManyRelatedFieldsAnalyticsReport))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsAnalyticsReportRequestsGetToManyRelatedFieldsAnalyticsReportJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsAnalyticsReportRequestsGetToManyRelatedFieldsAnalyticsReport?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsAnalyticsReportRequestsGetToManyRelatedFieldsAnalyticsReportNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsAnalyticsReportRequestsGetToManyRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsAnalyticsReportRequestsGetToManyRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsAnalyticsReportRequestsGetToManyRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsAnalyticsReportRequestsGetToManyRelatedIncludeItemNullableJsonConverter();
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
                if (type == typeof(global::AppStoreConnect.AnalyticsReport))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AnalyticsReport(options);
                }
                if (type == typeof(global::AppStoreConnect.AnalyticsReportAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AnalyticsReportAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.AnalyticsReportAttributesCategory))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AnalyticsReportAttributesCategory2(options);
                }
                if (type == typeof(global::AppStoreConnect.AnalyticsReportRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AnalyticsReportRelationships(options);
                }
                if (type == typeof(global::AppStoreConnect.AnalyticsReportRelationshipsInstances))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AnalyticsReportRelationshipsInstances(options);
                }
                if (type == typeof(global::AppStoreConnect.AnalyticsReportRequest))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AnalyticsReportRequest(options);
                }
                if (type == typeof(global::AppStoreConnect.AnalyticsReportRequestAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AnalyticsReportRequestAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.AnalyticsReportRequestAttributesAccessType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AnalyticsReportRequestAttributesAccessType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AnalyticsReportRequestRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AnalyticsReportRequestRelationships(options);
                }
                if (type == typeof(global::AppStoreConnect.AnalyticsReportRequestRelationshipsReports))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AnalyticsReportRequestRelationshipsReports(options);
                }
                if (type == typeof(global::AppStoreConnect.AnalyticsReportRequestRelationshipsReportsDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AnalyticsReportRequestRelationshipsReportsDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.AnalyticsReportRequestRelationshipsReportsDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AnalyticsReportRequestRelationshipsReportsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AnalyticsReportRequestType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AnalyticsReportRequestType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AnalyticsReportRequestsResponse))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AnalyticsReportRequestsResponse(options);
                }
                if (type == typeof(global::AppStoreConnect.AnalyticsReportType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AnalyticsReportType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsAnalyticsReportRequestsGetToManyRelatedFieldsAnalyticsReport))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppsAnalyticsReportRequestsGetToManyRelatedFieldsAnalyticsReport2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsAnalyticsReportRequestsGetToManyRelatedFieldsAnalyticsReportRequest))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppsAnalyticsReportRequestsGetToManyRelatedFieldsAnalyticsReportRequest2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsAnalyticsReportRequestsGetToManyRelatedFilterAccessTypeItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppsAnalyticsReportRequestsGetToManyRelatedFilterAccessTypeItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsAnalyticsReportRequestsGetToManyRelatedIncludeItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppsAnalyticsReportRequestsGetToManyRelatedIncludeItem2(options);
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
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AnalyticsReport>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_7FD7CF8FDB673C60(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AnalyticsReportRequest>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_206C20793D4BDD67(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AnalyticsReportRequestRelationshipsReportsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_5AF1F69F48A7B7C2(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppsAnalyticsReportRequestsGetToManyRelatedFieldsAnalyticsReport>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_9E93A025D6BD5D64(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppsAnalyticsReportRequestsGetToManyRelatedFieldsAnalyticsReportRequest>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_57C3E9256059CB35(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppsAnalyticsReportRequestsGetToManyRelatedFilterAccessTypeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_656696F913613505(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppsAnalyticsReportRequestsGetToManyRelatedIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_70935B846FA65126(options);
                }
                if (type == typeof(int))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_Int32(options);
                }
                if (type == typeof(bool?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBoolean(options);
                }
                if (type == typeof(global::AppStoreConnect.AnalyticsReportAttributesCategory?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAnalyticsReportAttributesCategory2(options);
                }
                if (type == typeof(global::AppStoreConnect.AnalyticsReportRequestAttributesAccessType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAnalyticsReportRequestAttributesAccessType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AnalyticsReportRequestRelationshipsReportsDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAnalyticsReportRequestRelationshipsReportsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AnalyticsReportRequestType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAnalyticsReportRequestType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AnalyticsReportType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAnalyticsReportType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsAnalyticsReportRequestsGetToManyRelatedFieldsAnalyticsReport?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppsAnalyticsReportRequestsGetToManyRelatedFieldsAnalyticsReport2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsAnalyticsReportRequestsGetToManyRelatedFieldsAnalyticsReportRequest?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppsAnalyticsReportRequestsGetToManyRelatedFieldsAnalyticsReportRequest2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsAnalyticsReportRequestsGetToManyRelatedFilterAccessTypeItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppsAnalyticsReportRequestsGetToManyRelatedFilterAccessTypeItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsAnalyticsReportRequestsGetToManyRelatedIncludeItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppsAnalyticsReportRequestsGetToManyRelatedIncludeItem2(options);
                }
                if (type == typeof(int?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableInt32(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AnalyticsReport>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_SourceGenerationContextMetadataType_E30A82EFE5CF9E9A(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AnalyticsReportRequest>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_SourceGenerationContextMetadataType_DA231AB5C3CE1FFD(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AnalyticsReportRequestRelationshipsReportsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_SourceGenerationContextMetadataType_F24C4AFAEC152922(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppsAnalyticsReportRequestsGetToManyRelatedFieldsAnalyticsReport>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_2BF9BCA3569BF85E(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppsAnalyticsReportRequestsGetToManyRelatedFieldsAnalyticsReportRequest>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_666BBC7A4B11B925(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppsAnalyticsReportRequestsGetToManyRelatedFilterAccessTypeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_EBD4F4ABB62A70AE(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppsAnalyticsReportRequestsGetToManyRelatedIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_CE290B5819C13188(options);
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