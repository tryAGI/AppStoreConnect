
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_3956BB14FED1536C : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_3956BB14FED1536C Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_3956BB14FED1536C(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.MetricCategory)

                    || typeToConvert == typeof(global::AppStoreConnect.MetricCategory?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.MetricCategory))
                {
                    return new global::AppStoreConnect.JsonConverters.MetricCategoryJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.MetricCategory?))
                {
                    return new global::AppStoreConnect.JsonConverters.MetricCategoryNullableJsonConverter();
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
                if (type == typeof(double))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_Double(options);
                }
                if (type == typeof(global::AppStoreConnect.MetricCategory))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_MetricCategory2(options);
                }
                if (type == typeof(global::AppStoreConnect.MetricsInsight))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_MetricsInsight(options);
                }
                if (type == typeof(global::AppStoreConnect.MetricsInsightPopulation))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_MetricsInsightPopulation(options);
                }
                if (type == typeof(global::AppStoreConnect.XcodeMetrics))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_XcodeMetrics(options);
                }
                if (type == typeof(global::AppStoreConnect.XcodeMetricsInsights))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_XcodeMetricsInsights(options);
                }
                if (type == typeof(global::AppStoreConnect.XcodeMetricsProductDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_XcodeMetricsProductDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.XcodeMetricsProductDataItemMetricCategorie))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_XcodeMetricsProductDataItemMetricCategorie(options);
                }
                if (type == typeof(global::AppStoreConnect.XcodeMetricsProductDataItemMetricCategorieMetric))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_XcodeMetricsProductDataItemMetricCategorieMetric(options);
                }
                if (type == typeof(global::AppStoreConnect.XcodeMetricsProductDataItemMetricCategorieMetricDataset))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_XcodeMetricsProductDataItemMetricCategorieMetricDataset(options);
                }
                if (type == typeof(global::AppStoreConnect.XcodeMetricsProductDataItemMetricCategorieMetricDatasetFilterCriteria))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_XcodeMetricsProductDataItemMetricCategorieMetricDatasetFilterCriteria(options);
                }
                if (type == typeof(global::AppStoreConnect.XcodeMetricsProductDataItemMetricCategorieMetricDatasetPoint))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_XcodeMetricsProductDataItemMetricCategorieMetricDatasetPoint(options);
                }
                if (type == typeof(global::AppStoreConnect.XcodeMetricsProductDataItemMetricCategorieMetricDatasetPointPercentageBreakdown))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_XcodeMetricsProductDataItemMetricCategorieMetricDatasetPointPercentageBreakdown(options);
                }
                if (type == typeof(global::AppStoreConnect.XcodeMetricsProductDataItemMetricCategorieMetricDatasetRecommendedMetricGoal))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_XcodeMetricsProductDataItemMetricCategorieMetricDatasetRecommendedMetricGoal(options);
                }
                if (type == typeof(global::AppStoreConnect.XcodeMetricsProductDataItemMetricCategorieMetricGoalKey))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_XcodeMetricsProductDataItemMetricCategorieMetricGoalKey(options);
                }
                if (type == typeof(global::AppStoreConnect.XcodeMetricsProductDataItemMetricCategorieMetricUnit))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_XcodeMetricsProductDataItemMetricCategorieMetricUnit(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.MetricsInsight>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_7282F71444062802(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.MetricsInsightPopulation>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_7B4BC17A46607DDB(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.XcodeMetricsProductDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_67030A83E5FB5EEA(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.XcodeMetricsProductDataItemMetricCategorie>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_857F55EF8CAAEFDC(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.XcodeMetricsProductDataItemMetricCategorieMetric>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_C011B6DE76033FAC(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.XcodeMetricsProductDataItemMetricCategorieMetricDataset>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_AFFD2C4AD7715DEF(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.XcodeMetricsProductDataItemMetricCategorieMetricDatasetPoint>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_DAA48881AEA0F058(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.XcodeMetricsProductDataItemMetricCategorieMetricGoalKey>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_9623B6AE5C850AEF(options);
                }
                if (type == typeof(int))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_Int32(options);
                }
                if (type == typeof(bool?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBoolean(options);
                }
                if (type == typeof(double?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableDouble(options);
                }
                if (type == typeof(global::AppStoreConnect.MetricCategory?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableMetricCategory2(options);
                }
                if (type == typeof(int?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableInt32(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.MetricsInsight>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_88D66ACA7F456130(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.MetricsInsightPopulation>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_00E77D7E742D5CD2(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.XcodeMetricsProductDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_7A186006F11A4D48(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.XcodeMetricsProductDataItemMetricCategorie>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_32247424794A0FC1(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.XcodeMetricsProductDataItemMetricCategorieMetric>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_7181722F3AEEE556(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.XcodeMetricsProductDataItemMetricCategorieMetricDataset>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_710EE428710491AA(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.XcodeMetricsProductDataItemMetricCategorieMetricDatasetPoint>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_E24ADAA590323DB9(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.XcodeMetricsProductDataItemMetricCategorieMetricGoalKey>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_BA01CD37A76571A4(options);
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