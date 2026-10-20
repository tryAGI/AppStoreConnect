
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_5BE97837A47E07B1 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_5BE97837A47E07B1 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_5BE97837A47E07B1(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesMatchmakingRequestsGetMetricsGranularity)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesMatchmakingRequestsGetMetricsGranularity?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesMatchmakingRequestsGetMetricsGroupByItem)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesMatchmakingRequestsGetMetricsGroupByItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesMatchmakingRequestsGetMetricsFilterResult)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesMatchmakingRequestsGetMetricsFilterResult?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesMatchmakingRequestsGetMetricsSortItem)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesMatchmakingRequestsGetMetricsSortItem?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesMatchmakingRequestsGetMetricsGranularity))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingQueuesMatchmakingRequestsGetMetricsGranularityJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesMatchmakingRequestsGetMetricsGranularity?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingQueuesMatchmakingRequestsGetMetricsGranularityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesMatchmakingRequestsGetMetricsGroupByItem))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingQueuesMatchmakingRequestsGetMetricsGroupByItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesMatchmakingRequestsGetMetricsGroupByItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingQueuesMatchmakingRequestsGetMetricsGroupByItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesMatchmakingRequestsGetMetricsFilterResult))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingQueuesMatchmakingRequestsGetMetricsFilterResultJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesMatchmakingRequestsGetMetricsFilterResult?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingQueuesMatchmakingRequestsGetMetricsFilterResultNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesMatchmakingRequestsGetMetricsSortItem))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingQueuesMatchmakingRequestsGetMetricsSortItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesMatchmakingRequestsGetMetricsSortItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingQueuesMatchmakingRequestsGetMetricsSortItemNullableJsonConverter();
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
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesMatchmakingRequestsGetMetricsFilterResult))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_GameCenterMatchmakingQueuesMatchmakingRequestsGetMetricsFilterResult2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesMatchmakingRequestsGetMetricsGranularity))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_GameCenterMatchmakingQueuesMatchmakingRequestsGetMetricsGranularity2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesMatchmakingRequestsGetMetricsGroupByItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_GameCenterMatchmakingQueuesMatchmakingRequestsGetMetricsGroupByItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesMatchmakingRequestsGetMetricsSortItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_GameCenterMatchmakingQueuesMatchmakingRequestsGetMetricsSortItem2(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingQueuesMatchmakingRequestsGetMetricsGroupByItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_SourceGenerationContextMetadataType_4FCA632DA896FCA5(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingQueuesMatchmakingRequestsGetMetricsSortItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_SourceGenerationContextMetadataType_E0C69970326AAD23(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesMatchmakingRequestsGetMetricsFilterResult?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableGameCenterMatchmakingQueuesMatchmakingRequestsGetMetricsFilterResult2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesMatchmakingRequestsGetMetricsGranularity?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableGameCenterMatchmakingQueuesMatchmakingRequestsGetMetricsGranularity2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesMatchmakingRequestsGetMetricsGroupByItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableGameCenterMatchmakingQueuesMatchmakingRequestsGetMetricsGroupByItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesMatchmakingRequestsGetMetricsSortItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableGameCenterMatchmakingQueuesMatchmakingRequestsGetMetricsSortItem2(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterMatchmakingQueuesMatchmakingRequestsGetMetricsGroupByItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_109A0D17F9F4F0CE(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterMatchmakingQueuesMatchmakingRequestsGetMetricsSortItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_C50050702259342A(options);
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