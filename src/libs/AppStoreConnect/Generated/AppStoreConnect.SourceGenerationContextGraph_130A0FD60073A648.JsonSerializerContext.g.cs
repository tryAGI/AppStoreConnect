
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_130A0FD60073A648 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_130A0FD60073A648 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_130A0FD60073A648(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.AppsAppPriceScheduleGetToOneRelatedFieldsAppPriceSchedule)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsAppPriceScheduleGetToOneRelatedFieldsAppPriceSchedule?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsAppPriceScheduleGetToOneRelatedFieldsApp)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsAppPriceScheduleGetToOneRelatedFieldsApp?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsAppPriceScheduleGetToOneRelatedFieldsTerritorie)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsAppPriceScheduleGetToOneRelatedFieldsTerritorie?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsAppPriceScheduleGetToOneRelatedFieldsAppPrice)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsAppPriceScheduleGetToOneRelatedFieldsAppPrice?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsAppPriceScheduleGetToOneRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsAppPriceScheduleGetToOneRelatedIncludeItem?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.AppsAppPriceScheduleGetToOneRelatedFieldsAppPriceSchedule))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsAppPriceScheduleGetToOneRelatedFieldsAppPriceScheduleJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsAppPriceScheduleGetToOneRelatedFieldsAppPriceSchedule?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsAppPriceScheduleGetToOneRelatedFieldsAppPriceScheduleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsAppPriceScheduleGetToOneRelatedFieldsApp))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsAppPriceScheduleGetToOneRelatedFieldsAppJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsAppPriceScheduleGetToOneRelatedFieldsApp?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsAppPriceScheduleGetToOneRelatedFieldsAppNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsAppPriceScheduleGetToOneRelatedFieldsTerritorie))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsAppPriceScheduleGetToOneRelatedFieldsTerritorieJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsAppPriceScheduleGetToOneRelatedFieldsTerritorie?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsAppPriceScheduleGetToOneRelatedFieldsTerritorieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsAppPriceScheduleGetToOneRelatedFieldsAppPrice))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsAppPriceScheduleGetToOneRelatedFieldsAppPriceJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsAppPriceScheduleGetToOneRelatedFieldsAppPrice?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsAppPriceScheduleGetToOneRelatedFieldsAppPriceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsAppPriceScheduleGetToOneRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsAppPriceScheduleGetToOneRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsAppPriceScheduleGetToOneRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsAppPriceScheduleGetToOneRelatedIncludeItemNullableJsonConverter();
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
                if (type == typeof(global::AppStoreConnect.AppsAppPriceScheduleGetToOneRelatedFieldsApp))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppsAppPriceScheduleGetToOneRelatedFieldsApp2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsAppPriceScheduleGetToOneRelatedFieldsAppPrice))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppsAppPriceScheduleGetToOneRelatedFieldsAppPrice2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsAppPriceScheduleGetToOneRelatedFieldsAppPriceSchedule))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppsAppPriceScheduleGetToOneRelatedFieldsAppPriceSchedule2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsAppPriceScheduleGetToOneRelatedFieldsTerritorie))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppsAppPriceScheduleGetToOneRelatedFieldsTerritorie2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsAppPriceScheduleGetToOneRelatedIncludeItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppsAppPriceScheduleGetToOneRelatedIncludeItem2(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppsAppPriceScheduleGetToOneRelatedFieldsApp>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_ABAF74CC7489BF5C(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppsAppPriceScheduleGetToOneRelatedFieldsAppPrice>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_F34A56F97906FBFB(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppsAppPriceScheduleGetToOneRelatedFieldsAppPriceSchedule>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_79ACA7B7F66F4974(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppsAppPriceScheduleGetToOneRelatedFieldsTerritorie>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_58439031B3F44A42(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppsAppPriceScheduleGetToOneRelatedIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_F7EF49ADA275CB4A(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsAppPriceScheduleGetToOneRelatedFieldsApp?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppsAppPriceScheduleGetToOneRelatedFieldsApp2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsAppPriceScheduleGetToOneRelatedFieldsAppPrice?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppsAppPriceScheduleGetToOneRelatedFieldsAppPrice2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsAppPriceScheduleGetToOneRelatedFieldsAppPriceSchedule?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppsAppPriceScheduleGetToOneRelatedFieldsAppPriceSchedule2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsAppPriceScheduleGetToOneRelatedFieldsTerritorie?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppsAppPriceScheduleGetToOneRelatedFieldsTerritorie2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsAppPriceScheduleGetToOneRelatedIncludeItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppsAppPriceScheduleGetToOneRelatedIncludeItem2(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppsAppPriceScheduleGetToOneRelatedFieldsApp>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_92886CFF3383ABAB(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppsAppPriceScheduleGetToOneRelatedFieldsAppPrice>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_A85A31A520332E40(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppsAppPriceScheduleGetToOneRelatedFieldsAppPriceSchedule>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_E3B1E9129386BAB6(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppsAppPriceScheduleGetToOneRelatedFieldsTerritorie>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_CF5CF4894023C955(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppsAppPriceScheduleGetToOneRelatedIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_65E20433D9884B31(options);
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