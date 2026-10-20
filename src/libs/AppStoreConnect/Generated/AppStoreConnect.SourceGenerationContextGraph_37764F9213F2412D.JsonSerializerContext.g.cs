
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_37764F9213F2412D : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_37764F9213F2412D Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_37764F9213F2412D(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.BetaAppClipInvocationLocalizationInlineCreateType)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaAppClipInvocationLocalizationInlineCreateType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaAppClipInvocationLocalizationInlineCreateRelationshipsBetaAppClipInvocationDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaAppClipInvocationLocalizationInlineCreateRelationshipsBetaAppClipInvocationDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaAppClipInvocationCreateRequestDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaAppClipInvocationCreateRequestDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaAppClipInvocationCreateRequestDataRelationshipsBuildBundleDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaAppClipInvocationCreateRequestDataRelationshipsBuildBundleDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaAppClipInvocationCreateRequestDataRelationshipsBetaAppClipInvocationLocalizationsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaAppClipInvocationCreateRequestDataRelationshipsBetaAppClipInvocationLocalizationsDataItemType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.BetaAppClipInvocationLocalizationInlineCreateType))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaAppClipInvocationLocalizationInlineCreateTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaAppClipInvocationLocalizationInlineCreateType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaAppClipInvocationLocalizationInlineCreateTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaAppClipInvocationLocalizationInlineCreateRelationshipsBetaAppClipInvocationDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaAppClipInvocationLocalizationInlineCreateRelationshipsBetaAppClipInvocationDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaAppClipInvocationLocalizationInlineCreateRelationshipsBetaAppClipInvocationDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaAppClipInvocationLocalizationInlineCreateRelationshipsBetaAppClipInvocationDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaAppClipInvocationCreateRequestDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaAppClipInvocationCreateRequestDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaAppClipInvocationCreateRequestDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaAppClipInvocationCreateRequestDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaAppClipInvocationCreateRequestDataRelationshipsBuildBundleDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaAppClipInvocationCreateRequestDataRelationshipsBuildBundleDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaAppClipInvocationCreateRequestDataRelationshipsBuildBundleDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaAppClipInvocationCreateRequestDataRelationshipsBuildBundleDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaAppClipInvocationCreateRequestDataRelationshipsBetaAppClipInvocationLocalizationsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaAppClipInvocationCreateRequestDataRelationshipsBetaAppClipInvocationLocalizationsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaAppClipInvocationCreateRequestDataRelationshipsBetaAppClipInvocationLocalizationsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaAppClipInvocationCreateRequestDataRelationshipsBetaAppClipInvocationLocalizationsDataItemTypeNullableJsonConverter();
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
                if (type == typeof(global::AppStoreConnect.BetaAppClipInvocationCreateRequest))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BetaAppClipInvocationCreateRequest(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaAppClipInvocationCreateRequestData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BetaAppClipInvocationCreateRequestData(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaAppClipInvocationCreateRequestDataAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BetaAppClipInvocationCreateRequestDataAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaAppClipInvocationCreateRequestDataRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BetaAppClipInvocationCreateRequestDataRelationships(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaAppClipInvocationCreateRequestDataRelationshipsBetaAppClipInvocationLocalizations))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BetaAppClipInvocationCreateRequestDataRelationshipsBetaAppClipInvocationLocalizations(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaAppClipInvocationCreateRequestDataRelationshipsBetaAppClipInvocationLocalizationsDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BetaAppClipInvocationCreateRequestDataRelationshipsBetaAppClipInvocationLocalizationsDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaAppClipInvocationCreateRequestDataRelationshipsBetaAppClipInvocationLocalizationsDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BetaAppClipInvocationCreateRequestDataRelationshipsBetaAppClipInvocationLocalizationsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaAppClipInvocationCreateRequestDataRelationshipsBuildBundle))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BetaAppClipInvocationCreateRequestDataRelationshipsBuildBundle(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaAppClipInvocationCreateRequestDataRelationshipsBuildBundleData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BetaAppClipInvocationCreateRequestDataRelationshipsBuildBundleData(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaAppClipInvocationCreateRequestDataRelationshipsBuildBundleDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BetaAppClipInvocationCreateRequestDataRelationshipsBuildBundleDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaAppClipInvocationCreateRequestDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BetaAppClipInvocationCreateRequestDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaAppClipInvocationLocalizationInlineCreate))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BetaAppClipInvocationLocalizationInlineCreate(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaAppClipInvocationLocalizationInlineCreateAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BetaAppClipInvocationLocalizationInlineCreateAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaAppClipInvocationLocalizationInlineCreateRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BetaAppClipInvocationLocalizationInlineCreateRelationships(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaAppClipInvocationLocalizationInlineCreateRelationshipsBetaAppClipInvocation))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BetaAppClipInvocationLocalizationInlineCreateRelationshipsBetaAppClipInvocation(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaAppClipInvocationLocalizationInlineCreateRelationshipsBetaAppClipInvocationData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BetaAppClipInvocationLocalizationInlineCreateRelationshipsBetaAppClipInvocationData(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaAppClipInvocationLocalizationInlineCreateRelationshipsBetaAppClipInvocationDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BetaAppClipInvocationLocalizationInlineCreateRelationshipsBetaAppClipInvocationDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaAppClipInvocationLocalizationInlineCreateType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BetaAppClipInvocationLocalizationInlineCreateType2(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BetaAppClipInvocationCreateRequestDataRelationshipsBetaAppClipInvocationLocalizationsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_24F46AA08C782D92(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BetaAppClipInvocationLocalizationInlineCreate>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_814C273462006B34(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaAppClipInvocationCreateRequestDataRelationshipsBetaAppClipInvocationLocalizationsDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBetaAppClipInvocationCreateRequestDataRelationshipsBetaAppClipInvocationLocalizationsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaAppClipInvocationCreateRequestDataRelationshipsBuildBundleDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBetaAppClipInvocationCreateRequestDataRelationshipsBuildBundleDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaAppClipInvocationCreateRequestDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBetaAppClipInvocationCreateRequestDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaAppClipInvocationLocalizationInlineCreateRelationshipsBetaAppClipInvocationDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBetaAppClipInvocationLocalizationInlineCreateRelationshipsBetaAppClipInvocationDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaAppClipInvocationLocalizationInlineCreateType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBetaAppClipInvocationLocalizationInlineCreateType2(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BetaAppClipInvocationCreateRequestDataRelationshipsBetaAppClipInvocationLocalizationsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_76CFBE5C52601768(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BetaAppClipInvocationLocalizationInlineCreate>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_BBD8086C0E8A70AF(options);
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