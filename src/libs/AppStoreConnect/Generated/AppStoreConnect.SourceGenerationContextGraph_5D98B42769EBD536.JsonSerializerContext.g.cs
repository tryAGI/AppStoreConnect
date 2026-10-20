
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_5D98B42769EBD536 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_5D98B42769EBD536 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_5D98B42769EBD536(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.BundleIdCapabilityCreateRequestDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.BundleIdCapabilityCreateRequestDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BundleIdCapabilityCreateRequestDataRelationshipsBundleIdDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.BundleIdCapabilityCreateRequestDataRelationshipsBundleIdDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.CapabilityOptionKey)

                    || typeToConvert == typeof(global::AppStoreConnect.CapabilityOptionKey?)

                    || typeToConvert == typeof(global::AppStoreConnect.CapabilitySettingKey)

                    || typeToConvert == typeof(global::AppStoreConnect.CapabilitySettingKey?)

                    || typeToConvert == typeof(global::AppStoreConnect.CapabilitySettingAllowedInstances)

                    || typeToConvert == typeof(global::AppStoreConnect.CapabilitySettingAllowedInstances?)

                    || typeToConvert == typeof(global::AppStoreConnect.CapabilityType)

                    || typeToConvert == typeof(global::AppStoreConnect.CapabilityType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.BundleIdCapabilityCreateRequestDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.BundleIdCapabilityCreateRequestDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BundleIdCapabilityCreateRequestDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BundleIdCapabilityCreateRequestDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BundleIdCapabilityCreateRequestDataRelationshipsBundleIdDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.BundleIdCapabilityCreateRequestDataRelationshipsBundleIdDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BundleIdCapabilityCreateRequestDataRelationshipsBundleIdDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BundleIdCapabilityCreateRequestDataRelationshipsBundleIdDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CapabilityOptionKey))
                {
                    return new global::AppStoreConnect.JsonConverters.CapabilityOptionKeyJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CapabilityOptionKey?))
                {
                    return new global::AppStoreConnect.JsonConverters.CapabilityOptionKeyNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CapabilitySettingKey))
                {
                    return new global::AppStoreConnect.JsonConverters.CapabilitySettingKeyJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CapabilitySettingKey?))
                {
                    return new global::AppStoreConnect.JsonConverters.CapabilitySettingKeyNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CapabilitySettingAllowedInstances))
                {
                    return new global::AppStoreConnect.JsonConverters.CapabilitySettingAllowedInstancesJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CapabilitySettingAllowedInstances?))
                {
                    return new global::AppStoreConnect.JsonConverters.CapabilitySettingAllowedInstancesNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CapabilityType))
                {
                    return new global::AppStoreConnect.JsonConverters.CapabilityTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CapabilityType?))
                {
                    return new global::AppStoreConnect.JsonConverters.CapabilityTypeNullableJsonConverter();
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
                if (type == typeof(global::AppStoreConnect.BundleIdCapabilityCreateRequest))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BundleIdCapabilityCreateRequest(options);
                }
                if (type == typeof(global::AppStoreConnect.BundleIdCapabilityCreateRequestData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BundleIdCapabilityCreateRequestData(options);
                }
                if (type == typeof(global::AppStoreConnect.BundleIdCapabilityCreateRequestDataAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BundleIdCapabilityCreateRequestDataAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.BundleIdCapabilityCreateRequestDataRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BundleIdCapabilityCreateRequestDataRelationships(options);
                }
                if (type == typeof(global::AppStoreConnect.BundleIdCapabilityCreateRequestDataRelationshipsBundleId))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BundleIdCapabilityCreateRequestDataRelationshipsBundleId(options);
                }
                if (type == typeof(global::AppStoreConnect.BundleIdCapabilityCreateRequestDataRelationshipsBundleIdData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BundleIdCapabilityCreateRequestDataRelationshipsBundleIdData(options);
                }
                if (type == typeof(global::AppStoreConnect.BundleIdCapabilityCreateRequestDataRelationshipsBundleIdDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BundleIdCapabilityCreateRequestDataRelationshipsBundleIdDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BundleIdCapabilityCreateRequestDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BundleIdCapabilityCreateRequestDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.CapabilityOption))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_CapabilityOption(options);
                }
                if (type == typeof(global::AppStoreConnect.CapabilityOptionKey))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_CapabilityOptionKey2(options);
                }
                if (type == typeof(global::AppStoreConnect.CapabilitySetting))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CapabilitySetting(options);
                }
                if (type == typeof(global::AppStoreConnect.CapabilitySettingAllowedInstances))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_CapabilitySettingAllowedInstances2(options);
                }
                if (type == typeof(global::AppStoreConnect.CapabilitySettingKey))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_CapabilitySettingKey2(options);
                }
                if (type == typeof(global::AppStoreConnect.CapabilityType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CapabilityType2(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CapabilityOption>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_61E92FEC63716F0F(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CapabilitySetting>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_82CDE6AA9DF6A859(options);
                }
                if (type == typeof(int))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_Int32(options);
                }
                if (type == typeof(bool?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBoolean(options);
                }
                if (type == typeof(global::AppStoreConnect.BundleIdCapabilityCreateRequestDataRelationshipsBundleIdDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBundleIdCapabilityCreateRequestDataRelationshipsBundleIdDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BundleIdCapabilityCreateRequestDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBundleIdCapabilityCreateRequestDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.CapabilityOptionKey?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableCapabilityOptionKey2(options);
                }
                if (type == typeof(global::AppStoreConnect.CapabilitySettingAllowedInstances?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableCapabilitySettingAllowedInstances2(options);
                }
                if (type == typeof(global::AppStoreConnect.CapabilitySettingKey?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableCapabilitySettingKey2(options);
                }
                if (type == typeof(global::AppStoreConnect.CapabilityType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableCapabilityType2(options);
                }
                if (type == typeof(int?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableInt32(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CapabilityOption>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_E6F717346AAC294E(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CapabilitySetting>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_EE78664BD19FA0E2(options);
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