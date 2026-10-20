
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_91F24F8093F77E75 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_91F24F8093F77E75 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_91F24F8093F77E75(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.SandboxTesterV2Type)

                    || typeToConvert == typeof(global::AppStoreConnect.SandboxTesterV2Type?)

                    || typeToConvert == typeof(global::AppStoreConnect.SandboxTesterV2AttributesSubscriptionRenewalRate)

                    || typeToConvert == typeof(global::AppStoreConnect.SandboxTesterV2AttributesSubscriptionRenewalRate?)

                    || typeToConvert == typeof(global::AppStoreConnect.SandboxTesterV2UpdateRequestDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.SandboxTesterV2UpdateRequestDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SandboxTesterV2UpdateRequestDataAttributesSubscriptionRenewalRate)

                    || typeToConvert == typeof(global::AppStoreConnect.SandboxTesterV2UpdateRequestDataAttributesSubscriptionRenewalRate?)

                    || typeToConvert == typeof(global::AppStoreConnect.TerritoryCode)

                    || typeToConvert == typeof(global::AppStoreConnect.TerritoryCode?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.SandboxTesterV2Type))
                {
                    return new global::AppStoreConnect.JsonConverters.SandboxTesterV2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SandboxTesterV2Type?))
                {
                    return new global::AppStoreConnect.JsonConverters.SandboxTesterV2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SandboxTesterV2AttributesSubscriptionRenewalRate))
                {
                    return new global::AppStoreConnect.JsonConverters.SandboxTesterV2AttributesSubscriptionRenewalRateJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SandboxTesterV2AttributesSubscriptionRenewalRate?))
                {
                    return new global::AppStoreConnect.JsonConverters.SandboxTesterV2AttributesSubscriptionRenewalRateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SandboxTesterV2UpdateRequestDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.SandboxTesterV2UpdateRequestDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SandboxTesterV2UpdateRequestDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SandboxTesterV2UpdateRequestDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SandboxTesterV2UpdateRequestDataAttributesSubscriptionRenewalRate))
                {
                    return new global::AppStoreConnect.JsonConverters.SandboxTesterV2UpdateRequestDataAttributesSubscriptionRenewalRateJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SandboxTesterV2UpdateRequestDataAttributesSubscriptionRenewalRate?))
                {
                    return new global::AppStoreConnect.JsonConverters.SandboxTesterV2UpdateRequestDataAttributesSubscriptionRenewalRateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.TerritoryCode))
                {
                    return new global::AppStoreConnect.JsonConverters.TerritoryCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.TerritoryCode?))
                {
                    return new global::AppStoreConnect.JsonConverters.TerritoryCodeNullableJsonConverter();
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
                if (type == typeof(global::AppStoreConnect.DocumentLinks))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_DocumentLinks(options);
                }
                if (type == typeof(global::AppStoreConnect.ResourceLinks))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_ResourceLinks(options);
                }
                if (type == typeof(global::AppStoreConnect.SandboxTesterV2))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_SandboxTesterV2(options);
                }
                if (type == typeof(global::AppStoreConnect.SandboxTesterV2Attributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_SandboxTesterV2Attributes(options);
                }
                if (type == typeof(global::AppStoreConnect.SandboxTesterV2AttributesSubscriptionRenewalRate))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_SandboxTesterV2AttributesSubscriptionRenewalRate2(options);
                }
                if (type == typeof(global::AppStoreConnect.SandboxTesterV2Response))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_SandboxTesterV2Response(options);
                }
                if (type == typeof(global::AppStoreConnect.SandboxTesterV2Type))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_SandboxTesterV2Type2(options);
                }
                if (type == typeof(global::AppStoreConnect.SandboxTesterV2UpdateRequest))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_SandboxTesterV2UpdateRequest(options);
                }
                if (type == typeof(global::AppStoreConnect.SandboxTesterV2UpdateRequestData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_SandboxTesterV2UpdateRequestData(options);
                }
                if (type == typeof(global::AppStoreConnect.SandboxTesterV2UpdateRequestDataAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_SandboxTesterV2UpdateRequestDataAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.SandboxTesterV2UpdateRequestDataAttributesSubscriptionRenewalRate))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_SandboxTesterV2UpdateRequestDataAttributesSubscriptionRenewalRate2(options);
                }
                if (type == typeof(global::AppStoreConnect.SandboxTesterV2UpdateRequestDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_SandboxTesterV2UpdateRequestDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.TerritoryCode))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_TerritoryCode2(options);
                }
                if (type == typeof(bool?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBoolean(options);
                }
                if (type == typeof(global::AppStoreConnect.SandboxTesterV2AttributesSubscriptionRenewalRate?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableSandboxTesterV2AttributesSubscriptionRenewalRate2(options);
                }
                if (type == typeof(global::AppStoreConnect.SandboxTesterV2Type?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableSandboxTesterV2Type2(options);
                }
                if (type == typeof(global::AppStoreConnect.SandboxTesterV2UpdateRequestDataAttributesSubscriptionRenewalRate?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableSandboxTesterV2UpdateRequestDataAttributesSubscriptionRenewalRate2(options);
                }
                if (type == typeof(global::AppStoreConnect.SandboxTesterV2UpdateRequestDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableSandboxTesterV2UpdateRequestDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.TerritoryCode?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableTerritoryCode2(options);
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