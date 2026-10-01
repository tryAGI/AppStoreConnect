
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull
    )]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AnalyticsReportInstanceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AnalyticsReportSegmentsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AnalyticsReportInstanceSegmentsLinkagesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AnalyticsReportInstanceSegmentsLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AnalyticsReportInstanceSegmentsLinkagesResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AnalyticsReportInstanceSegmentsLinkagesResponseDataItemType), TypeInfoPropertyName = "AnalyticsReportInstanceSegmentsLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AnalyticsReportInstancesGetInstanceFieldsAnalyticsReportInstance>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AnalyticsReportInstancesGetInstanceFieldsAnalyticsReportInstance), TypeInfoPropertyName = "AnalyticsReportInstancesGetInstanceFieldsAnalyticsReportInstance2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AnalyticsReportInstancesSegmentsGetToManyRelatedFieldsAnalyticsReportSegment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AnalyticsReportInstancesSegmentsGetToManyRelatedFieldsAnalyticsReportSegment), TypeInfoPropertyName = "AnalyticsReportInstancesSegmentsGetToManyRelatedFieldsAnalyticsReportSegment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AnalyticsReportInstanceSegmentsLinkagesResponseDataItemType?), TypeInfoPropertyName = "NullableAnalyticsReportInstanceSegmentsLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AnalyticsReportInstancesGetInstanceFieldsAnalyticsReportInstance?), TypeInfoPropertyName = "NullableAnalyticsReportInstancesGetInstanceFieldsAnalyticsReportInstance2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AnalyticsReportInstancesSegmentsGetToManyRelatedFieldsAnalyticsReportSegment?), TypeInfoPropertyName = "NullableAnalyticsReportInstancesSegmentsGetToManyRelatedFieldsAnalyticsReportSegment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AnalyticsReportInstanceSegmentsLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AnalyticsReportInstancesGetInstanceFieldsAnalyticsReportInstance>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AnalyticsReportInstancesSegmentsGetToManyRelatedFieldsAnalyticsReportSegment>))]
    internal sealed partial class AnalyticsReportInstancesSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AnalyticsReportInstancesSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static AnalyticsReportInstancesSourceGenerationContext Default { get; } = new(DefaultOptions);

        private AnalyticsReportInstancesSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            global::AppStoreConnect.PartitionCoreSourceGenerationContext.AddConverters(options);
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
                    typeToConvert == typeof(global::AppStoreConnect.AnalyticsReportInstanceSegmentsLinkagesResponseDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AnalyticsReportInstanceSegmentsLinkagesResponseDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AnalyticsReportInstancesGetInstanceFieldsAnalyticsReportInstance)

                    || typeToConvert == typeof(global::AppStoreConnect.AnalyticsReportInstancesGetInstanceFieldsAnalyticsReportInstance?)

                    || typeToConvert == typeof(global::AppStoreConnect.AnalyticsReportInstancesSegmentsGetToManyRelatedFieldsAnalyticsReportSegment)

                    || typeToConvert == typeof(global::AppStoreConnect.AnalyticsReportInstancesSegmentsGetToManyRelatedFieldsAnalyticsReportSegment?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.AnalyticsReportInstanceSegmentsLinkagesResponseDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AnalyticsReportInstanceSegmentsLinkagesResponseDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AnalyticsReportInstanceSegmentsLinkagesResponseDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AnalyticsReportInstanceSegmentsLinkagesResponseDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AnalyticsReportInstancesGetInstanceFieldsAnalyticsReportInstance))
                {
                    return new global::AppStoreConnect.JsonConverters.AnalyticsReportInstancesGetInstanceFieldsAnalyticsReportInstanceJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AnalyticsReportInstancesGetInstanceFieldsAnalyticsReportInstance?))
                {
                    return new global::AppStoreConnect.JsonConverters.AnalyticsReportInstancesGetInstanceFieldsAnalyticsReportInstanceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AnalyticsReportInstancesSegmentsGetToManyRelatedFieldsAnalyticsReportSegment))
                {
                    return new global::AppStoreConnect.JsonConverters.AnalyticsReportInstancesSegmentsGetToManyRelatedFieldsAnalyticsReportSegmentJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AnalyticsReportInstancesSegmentsGetToManyRelatedFieldsAnalyticsReportSegment?))
                {
                    return new global::AppStoreConnect.JsonConverters.AnalyticsReportInstancesSegmentsGetToManyRelatedFieldsAnalyticsReportSegmentNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[2];

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
                    0 => new AnalyticsReportInstancesSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),

                    1 => global::AppStoreConnect.PartitionCoreSourceGenerationContext.TypeInfoResolver,
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}