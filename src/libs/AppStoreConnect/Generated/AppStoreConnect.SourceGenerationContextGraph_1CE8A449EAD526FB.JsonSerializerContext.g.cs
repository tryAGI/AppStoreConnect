
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_1CE8A449EAD526FB : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_1CE8A449EAD526FB Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_1CE8A449EAD526FB(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingNumberRuleResultsV1MetricResponseDataItemGranularity)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingNumberRuleResultsV1MetricResponseDataItemGranularity?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRulesMatchmakingNumberRuleResultsGetMetricsGranularity)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRulesMatchmakingNumberRuleResultsGetMetricsGranularity?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRulesMatchmakingNumberRuleResultsGetMetricsGroupByItem)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRulesMatchmakingNumberRuleResultsGetMetricsGroupByItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRulesMatchmakingNumberRuleResultsGetMetricsSortItem)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRulesMatchmakingNumberRuleResultsGetMetricsSortItem?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingNumberRuleResultsV1MetricResponseDataItemGranularity))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingNumberRuleResultsV1MetricResponseDataItemGranularityJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingNumberRuleResultsV1MetricResponseDataItemGranularity?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingNumberRuleResultsV1MetricResponseDataItemGranularityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRulesMatchmakingNumberRuleResultsGetMetricsGranularity))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRulesMatchmakingNumberRuleResultsGetMetricsGranularityJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRulesMatchmakingNumberRuleResultsGetMetricsGranularity?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRulesMatchmakingNumberRuleResultsGetMetricsGranularityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRulesMatchmakingNumberRuleResultsGetMetricsGroupByItem))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRulesMatchmakingNumberRuleResultsGetMetricsGroupByItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRulesMatchmakingNumberRuleResultsGetMetricsGroupByItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRulesMatchmakingNumberRuleResultsGetMetricsGroupByItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRulesMatchmakingNumberRuleResultsGetMetricsSortItem))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRulesMatchmakingNumberRuleResultsGetMetricsSortItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRulesMatchmakingNumberRuleResultsGetMetricsSortItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRulesMatchmakingNumberRuleResultsGetMetricsSortItemNullableJsonConverter();
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
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingNumberRuleResultsV1MetricResponse))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_GameCenterMatchmakingNumberRuleResultsV1MetricResponse(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingNumberRuleResultsV1MetricResponseDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_GameCenterMatchmakingNumberRuleResultsV1MetricResponseDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingNumberRuleResultsV1MetricResponseDataItemDataPoint))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_GameCenterMatchmakingNumberRuleResultsV1MetricResponseDataItemDataPoint(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingNumberRuleResultsV1MetricResponseDataItemDataPointValues))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_GameCenterMatchmakingNumberRuleResultsV1MetricResponseDataItemDataPointValues(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingNumberRuleResultsV1MetricResponseDataItemDimensions))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_GameCenterMatchmakingNumberRuleResultsV1MetricResponseDataItemDimensions(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingNumberRuleResultsV1MetricResponseDataItemDimensionsGameCenterMatchmakingQueue))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_GameCenterMatchmakingNumberRuleResultsV1MetricResponseDataItemDimensionsGameCenterMatchmakingQueue(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingNumberRuleResultsV1MetricResponseDataItemDimensionsGameCenterMatchmakingQueueLinks))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_GameCenterMatchmakingNumberRuleResultsV1MetricResponseDataItemDimensionsGameCenterMatchmakingQueueLinks(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingNumberRuleResultsV1MetricResponseDataItemGranularity))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_GameCenterMatchmakingNumberRuleResultsV1MetricResponseDataItemGranularity2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingRulesMatchmakingNumberRuleResultsGetMetricsGranularity))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_GameCenterMatchmakingRulesMatchmakingNumberRuleResultsGetMetricsGranularity2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingRulesMatchmakingNumberRuleResultsGetMetricsGroupByItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_GameCenterMatchmakingRulesMatchmakingNumberRuleResultsGetMetricsGroupByItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingRulesMatchmakingNumberRuleResultsGetMetricsSortItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_GameCenterMatchmakingRulesMatchmakingNumberRuleResultsGetMetricsSortItem2(options);
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
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingNumberRuleResultsV1MetricResponseDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_01702AC6DA30C894(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingNumberRuleResultsV1MetricResponseDataItemDataPoint>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_7969299B11FF7073(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingRulesMatchmakingNumberRuleResultsGetMetricsGroupByItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_SourceGenerationContextMetadataType_DF9AB2A79CD580D7(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingRulesMatchmakingNumberRuleResultsGetMetricsSortItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_SourceGenerationContextMetadataType_48B12FA7C6B13CB4(options);
                }
                if (type == typeof(global::System.DateTime))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_DateTime(options);
                }
                if (type == typeof(int))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_Int32(options);
                }
                if (type == typeof(double?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableDouble(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingNumberRuleResultsV1MetricResponseDataItemGranularity?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableGameCenterMatchmakingNumberRuleResultsV1MetricResponseDataItemGranularity2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingRulesMatchmakingNumberRuleResultsGetMetricsGranularity?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableGameCenterMatchmakingRulesMatchmakingNumberRuleResultsGetMetricsGranularity2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingRulesMatchmakingNumberRuleResultsGetMetricsGroupByItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableGameCenterMatchmakingRulesMatchmakingNumberRuleResultsGetMetricsGroupByItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingRulesMatchmakingNumberRuleResultsGetMetricsSortItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableGameCenterMatchmakingRulesMatchmakingNumberRuleResultsGetMetricsSortItem2(options);
                }
                if (type == typeof(global::System.DateTime?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableDateTime(options);
                }
                if (type == typeof(int?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableInt32(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterMatchmakingNumberRuleResultsV1MetricResponseDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_59A3542F3B285452(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterMatchmakingNumberRuleResultsV1MetricResponseDataItemDataPoint>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_57FE7DE2B284B357(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterMatchmakingRulesMatchmakingNumberRuleResultsGetMetricsGroupByItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_B1B756B3DF42B7C1(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterMatchmakingRulesMatchmakingNumberRuleResultsGetMetricsSortItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_2BB90C81620D76F9(options);
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