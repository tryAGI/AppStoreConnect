
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_0375077B1511DD1A : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_0375077B1511DD1A Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_0375077B1511DD1A(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.AnalyticsReportType)

                    || typeToConvert == typeof(global::AppStoreConnect.AnalyticsReportType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AnalyticsReportAttributesCategory)

                    || typeToConvert == typeof(global::AppStoreConnect.AnalyticsReportAttributesCategory?)

                    || typeToConvert == typeof(global::AppStoreConnect.AnalyticsReportRequestsReportsGetToManyRelatedFilterCategoryItem)

                    || typeToConvert == typeof(global::AppStoreConnect.AnalyticsReportRequestsReportsGetToManyRelatedFilterCategoryItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.AnalyticsReportRequestsReportsGetToManyRelatedFieldsAnalyticsReport)

                    || typeToConvert == typeof(global::AppStoreConnect.AnalyticsReportRequestsReportsGetToManyRelatedFieldsAnalyticsReport?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
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
                if (type == typeof(global::AppStoreConnect.AnalyticsReportRequestsReportsGetToManyRelatedFieldsAnalyticsReport))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AnalyticsReportRequestsReportsGetToManyRelatedFieldsAnalyticsReport2(options);
                }
                if (type == typeof(global::AppStoreConnect.AnalyticsReportRequestsReportsGetToManyRelatedFilterCategoryItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AnalyticsReportRequestsReportsGetToManyRelatedFilterCategoryItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.AnalyticsReportType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AnalyticsReportType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AnalyticsReportsResponse))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AnalyticsReportsResponse(options);
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
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AnalyticsReportRequestsReportsGetToManyRelatedFieldsAnalyticsReport>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_38ADC3A27EE2E418(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AnalyticsReportRequestsReportsGetToManyRelatedFilterCategoryItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_9EF6D61374297AAC(options);
                }
                if (type == typeof(int))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_Int32(options);
                }
                if (type == typeof(global::AppStoreConnect.AnalyticsReportAttributesCategory?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAnalyticsReportAttributesCategory2(options);
                }
                if (type == typeof(global::AppStoreConnect.AnalyticsReportRequestsReportsGetToManyRelatedFieldsAnalyticsReport?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAnalyticsReportRequestsReportsGetToManyRelatedFieldsAnalyticsReport2(options);
                }
                if (type == typeof(global::AppStoreConnect.AnalyticsReportRequestsReportsGetToManyRelatedFilterCategoryItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAnalyticsReportRequestsReportsGetToManyRelatedFilterCategoryItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.AnalyticsReportType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAnalyticsReportType2(options);
                }
                if (type == typeof(int?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableInt32(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AnalyticsReport>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_SourceGenerationContextMetadataType_E30A82EFE5CF9E9A(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AnalyticsReportRequestsReportsGetToManyRelatedFieldsAnalyticsReport>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_BC34255C4BEC46CC(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AnalyticsReportRequestsReportsGetToManyRelatedFilterCategoryItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_A0579F7795BCE0CB(options);
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