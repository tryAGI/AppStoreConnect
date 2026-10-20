
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_DDFB1F9A59489E69 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_DDFB1F9A59489E69 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_DDFB1F9A59489E69(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueueRequestsV1MetricResponseDataItemDimensionsResultData)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueueRequestsV1MetricResponseDataItemDimensionsResultData?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueueRequestsV1MetricResponseDataItemGranularity)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueueRequestsV1MetricResponseDataItemGranularity?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueueRequestsV1MetricResponseDataItemDimensionsResultData))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingQueueRequestsV1MetricResponseDataItemDimensionsResultDataJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueueRequestsV1MetricResponseDataItemDimensionsResultData?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingQueueRequestsV1MetricResponseDataItemDimensionsResultDataNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueueRequestsV1MetricResponseDataItemGranularity))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingQueueRequestsV1MetricResponseDataItemGranularityJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueueRequestsV1MetricResponseDataItemGranularity?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingQueueRequestsV1MetricResponseDataItemGranularityNullableJsonConverter();
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
                if (type == typeof(double))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_Double(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingQueueRequestsV1MetricResponse))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_GameCenterMatchmakingQueueRequestsV1MetricResponse(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingQueueRequestsV1MetricResponseDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_GameCenterMatchmakingQueueRequestsV1MetricResponseDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingQueueRequestsV1MetricResponseDataItemDataPoint))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_GameCenterMatchmakingQueueRequestsV1MetricResponseDataItemDataPoint(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingQueueRequestsV1MetricResponseDataItemDataPointValues))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_GameCenterMatchmakingQueueRequestsV1MetricResponseDataItemDataPointValues(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingQueueRequestsV1MetricResponseDataItemDimensions))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_GameCenterMatchmakingQueueRequestsV1MetricResponseDataItemDimensions(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingQueueRequestsV1MetricResponseDataItemDimensionsGameCenterDetail))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_GameCenterMatchmakingQueueRequestsV1MetricResponseDataItemDimensionsGameCenterDetail(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingQueueRequestsV1MetricResponseDataItemDimensionsGameCenterDetailLinks))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_GameCenterMatchmakingQueueRequestsV1MetricResponseDataItemDimensionsGameCenterDetailLinks(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingQueueRequestsV1MetricResponseDataItemDimensionsResult))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_GameCenterMatchmakingQueueRequestsV1MetricResponseDataItemDimensionsResult(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingQueueRequestsV1MetricResponseDataItemDimensionsResultData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_GameCenterMatchmakingQueueRequestsV1MetricResponseDataItemDimensionsResultData2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingQueueRequestsV1MetricResponseDataItemDimensionsResultLinks))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_GameCenterMatchmakingQueueRequestsV1MetricResponseDataItemDimensionsResultLinks(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingQueueRequestsV1MetricResponseDataItemGranularity))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_GameCenterMatchmakingQueueRequestsV1MetricResponseDataItemGranularity2(options);
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
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingQueueRequestsV1MetricResponseDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_89190C58C29D2384(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingQueueRequestsV1MetricResponseDataItemDataPoint>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_B68112EF98E6B750(options);
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
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingQueueRequestsV1MetricResponseDataItemDimensionsResultData?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableGameCenterMatchmakingQueueRequestsV1MetricResponseDataItemDimensionsResultData2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingQueueRequestsV1MetricResponseDataItemGranularity?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableGameCenterMatchmakingQueueRequestsV1MetricResponseDataItemGranularity2(options);
                }
                if (type == typeof(global::System.DateTime?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableDateTime(options);
                }
                if (type == typeof(int?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableInt32(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterMatchmakingQueueRequestsV1MetricResponseDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_06E83B31E93D3825(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterMatchmakingQueueRequestsV1MetricResponseDataItemDataPoint>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_080F3A0E54EA8ED5(options);
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