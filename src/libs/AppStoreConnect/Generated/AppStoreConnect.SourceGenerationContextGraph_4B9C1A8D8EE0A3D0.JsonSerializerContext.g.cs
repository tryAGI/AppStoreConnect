
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_4B9C1A8D8EE0A3D0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_4B9C1A8D8EE0A3D0 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_4B9C1A8D8EE0A3D0(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.AppEventCreateRequestDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEventCreateRequestDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEventCreateRequestDataAttributesBadge)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEventCreateRequestDataAttributesBadge?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEventCreateRequestDataAttributesPriority)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEventCreateRequestDataAttributesPriority?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEventCreateRequestDataAttributesPurpose)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEventCreateRequestDataAttributesPurpose?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEventCreateRequestDataRelationshipsAppDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEventCreateRequestDataRelationshipsAppDataType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.AppEventCreateRequestDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEventCreateRequestDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppEventCreateRequestDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEventCreateRequestDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppEventCreateRequestDataAttributesBadge))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEventCreateRequestDataAttributesBadgeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppEventCreateRequestDataAttributesBadge?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEventCreateRequestDataAttributesBadgeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppEventCreateRequestDataAttributesPriority))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEventCreateRequestDataAttributesPriorityJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppEventCreateRequestDataAttributesPriority?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEventCreateRequestDataAttributesPriorityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppEventCreateRequestDataAttributesPurpose))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEventCreateRequestDataAttributesPurposeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppEventCreateRequestDataAttributesPurpose?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEventCreateRequestDataAttributesPurposeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppEventCreateRequestDataRelationshipsAppDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEventCreateRequestDataRelationshipsAppDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppEventCreateRequestDataRelationshipsAppDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEventCreateRequestDataRelationshipsAppDataTypeNullableJsonConverter();
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
                if (type == typeof(global::AppStoreConnect.AppEventCreateRequest))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppEventCreateRequest(options);
                }
                if (type == typeof(global::AppStoreConnect.AppEventCreateRequestData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppEventCreateRequestData(options);
                }
                if (type == typeof(global::AppStoreConnect.AppEventCreateRequestDataAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppEventCreateRequestDataAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.AppEventCreateRequestDataAttributesBadge))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppEventCreateRequestDataAttributesBadge2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppEventCreateRequestDataAttributesPriority))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppEventCreateRequestDataAttributesPriority2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppEventCreateRequestDataAttributesPurpose))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppEventCreateRequestDataAttributesPurpose2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppEventCreateRequestDataAttributesTerritorySchedule))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppEventCreateRequestDataAttributesTerritorySchedule(options);
                }
                if (type == typeof(global::AppStoreConnect.AppEventCreateRequestDataRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppEventCreateRequestDataRelationships(options);
                }
                if (type == typeof(global::AppStoreConnect.AppEventCreateRequestDataRelationshipsApp))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppEventCreateRequestDataRelationshipsApp(options);
                }
                if (type == typeof(global::AppStoreConnect.AppEventCreateRequestDataRelationshipsAppData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppEventCreateRequestDataRelationshipsAppData(options);
                }
                if (type == typeof(global::AppStoreConnect.AppEventCreateRequestDataRelationshipsAppDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppEventCreateRequestDataRelationshipsAppDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppEventCreateRequestDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppEventCreateRequestDataType2(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppEventCreateRequestDataAttributesTerritorySchedule>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_595636DEB5C0F999(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<string>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_05BF36C073875770(options);
                }
                if (type == typeof(global::System.DateTime))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_DateTime(options);
                }
                if (type == typeof(global::AppStoreConnect.AppEventCreateRequestDataAttributesBadge?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppEventCreateRequestDataAttributesBadge2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppEventCreateRequestDataAttributesPriority?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppEventCreateRequestDataAttributesPriority2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppEventCreateRequestDataAttributesPurpose?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppEventCreateRequestDataAttributesPurpose2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppEventCreateRequestDataRelationshipsAppDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppEventCreateRequestDataRelationshipsAppDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppEventCreateRequestDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppEventCreateRequestDataType2(options);
                }
                if (type == typeof(global::System.DateTime?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableDateTime(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppEventCreateRequestDataAttributesTerritorySchedule>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_SourceGenerationContextMetadataType_37C6EEFBCFB7C7A8(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<string>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_SourceGenerationContextMetadataType_3F34DBFD50DE05D2(options);
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