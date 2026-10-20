
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_666A32D1F2268FE3 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_666A32D1F2268FE3 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_666A32D1F2268FE3(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.AppPriceSchedulesGetInstanceFieldsAppPriceSchedule)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPriceSchedulesGetInstanceFieldsAppPriceSchedule?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPriceSchedulesGetInstanceFieldsApp)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPriceSchedulesGetInstanceFieldsApp?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPriceSchedulesGetInstanceFieldsTerritorie)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPriceSchedulesGetInstanceFieldsTerritorie?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPriceSchedulesGetInstanceFieldsAppPrice)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPriceSchedulesGetInstanceFieldsAppPrice?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPriceSchedulesGetInstanceIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPriceSchedulesGetInstanceIncludeItem?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.AppPriceSchedulesGetInstanceFieldsAppPriceSchedule))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPriceSchedulesGetInstanceFieldsAppPriceScheduleJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPriceSchedulesGetInstanceFieldsAppPriceSchedule?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPriceSchedulesGetInstanceFieldsAppPriceScheduleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPriceSchedulesGetInstanceFieldsApp))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPriceSchedulesGetInstanceFieldsAppJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPriceSchedulesGetInstanceFieldsApp?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPriceSchedulesGetInstanceFieldsAppNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPriceSchedulesGetInstanceFieldsTerritorie))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPriceSchedulesGetInstanceFieldsTerritorieJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPriceSchedulesGetInstanceFieldsTerritorie?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPriceSchedulesGetInstanceFieldsTerritorieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPriceSchedulesGetInstanceFieldsAppPrice))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPriceSchedulesGetInstanceFieldsAppPriceJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPriceSchedulesGetInstanceFieldsAppPrice?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPriceSchedulesGetInstanceFieldsAppPriceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPriceSchedulesGetInstanceIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPriceSchedulesGetInstanceIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPriceSchedulesGetInstanceIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPriceSchedulesGetInstanceIncludeItemNullableJsonConverter();
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
                if (type == typeof(global::AppStoreConnect.AppPriceSchedulesGetInstanceFieldsApp))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppPriceSchedulesGetInstanceFieldsApp2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppPriceSchedulesGetInstanceFieldsAppPrice))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppPriceSchedulesGetInstanceFieldsAppPrice2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppPriceSchedulesGetInstanceFieldsAppPriceSchedule))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppPriceSchedulesGetInstanceFieldsAppPriceSchedule2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppPriceSchedulesGetInstanceFieldsTerritorie))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppPriceSchedulesGetInstanceFieldsTerritorie2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppPriceSchedulesGetInstanceIncludeItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppPriceSchedulesGetInstanceIncludeItem2(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppPriceSchedulesGetInstanceFieldsApp>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_6C4D92CB5DEA54E7(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppPriceSchedulesGetInstanceFieldsAppPrice>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_8EE20D45E0E970C8(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppPriceSchedulesGetInstanceFieldsAppPriceSchedule>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_B7F7BB4D3BDAA7CE(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppPriceSchedulesGetInstanceFieldsTerritorie>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_F864F379339AA4D8(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppPriceSchedulesGetInstanceIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_5FD1EB9FA87D2EC0(options);
                }
                if (type == typeof(global::AppStoreConnect.AppPriceSchedulesGetInstanceFieldsApp?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppPriceSchedulesGetInstanceFieldsApp2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppPriceSchedulesGetInstanceFieldsAppPrice?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppPriceSchedulesGetInstanceFieldsAppPrice2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppPriceSchedulesGetInstanceFieldsAppPriceSchedule?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppPriceSchedulesGetInstanceFieldsAppPriceSchedule2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppPriceSchedulesGetInstanceFieldsTerritorie?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppPriceSchedulesGetInstanceFieldsTerritorie2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppPriceSchedulesGetInstanceIncludeItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppPriceSchedulesGetInstanceIncludeItem2(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppPriceSchedulesGetInstanceFieldsApp>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_F6AD8F0B115A82CF(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppPriceSchedulesGetInstanceFieldsAppPrice>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_6E8311534A1C5EF2(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppPriceSchedulesGetInstanceFieldsAppPriceSchedule>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_B9188242FBF291EF(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppPriceSchedulesGetInstanceFieldsTerritorie>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_DC2EC888CE576E55(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppPriceSchedulesGetInstanceIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_90C34BF89A447511(options);
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