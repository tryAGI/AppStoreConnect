
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_BC7D9F99C18F3AA5 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_BC7D9F99C18F3AA5 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_BC7D9F99C18F3AA5(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.AppPriceSchedulesManualPricesGetToManyRelatedFieldsAppPrice)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPriceSchedulesManualPricesGetToManyRelatedFieldsAppPrice?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPriceSchedulesManualPricesGetToManyRelatedFieldsAppPricePoint)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPriceSchedulesManualPricesGetToManyRelatedFieldsAppPricePoint?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPriceSchedulesManualPricesGetToManyRelatedFieldsTerritorie)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPriceSchedulesManualPricesGetToManyRelatedFieldsTerritorie?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPriceSchedulesManualPricesGetToManyRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPriceSchedulesManualPricesGetToManyRelatedIncludeItem?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.AppPriceSchedulesManualPricesGetToManyRelatedFieldsAppPrice))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPriceSchedulesManualPricesGetToManyRelatedFieldsAppPriceJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPriceSchedulesManualPricesGetToManyRelatedFieldsAppPrice?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPriceSchedulesManualPricesGetToManyRelatedFieldsAppPriceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPriceSchedulesManualPricesGetToManyRelatedFieldsAppPricePoint))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPriceSchedulesManualPricesGetToManyRelatedFieldsAppPricePointJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPriceSchedulesManualPricesGetToManyRelatedFieldsAppPricePoint?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPriceSchedulesManualPricesGetToManyRelatedFieldsAppPricePointNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPriceSchedulesManualPricesGetToManyRelatedFieldsTerritorie))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPriceSchedulesManualPricesGetToManyRelatedFieldsTerritorieJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPriceSchedulesManualPricesGetToManyRelatedFieldsTerritorie?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPriceSchedulesManualPricesGetToManyRelatedFieldsTerritorieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPriceSchedulesManualPricesGetToManyRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPriceSchedulesManualPricesGetToManyRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPriceSchedulesManualPricesGetToManyRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPriceSchedulesManualPricesGetToManyRelatedIncludeItemNullableJsonConverter();
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
                if (type == typeof(global::AppStoreConnect.AppPriceSchedulesManualPricesGetToManyRelatedFieldsAppPrice))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppPriceSchedulesManualPricesGetToManyRelatedFieldsAppPrice2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppPriceSchedulesManualPricesGetToManyRelatedFieldsAppPricePoint))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppPriceSchedulesManualPricesGetToManyRelatedFieldsAppPricePoint2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppPriceSchedulesManualPricesGetToManyRelatedFieldsTerritorie))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppPriceSchedulesManualPricesGetToManyRelatedFieldsTerritorie2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppPriceSchedulesManualPricesGetToManyRelatedIncludeItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppPriceSchedulesManualPricesGetToManyRelatedIncludeItem2(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppPriceSchedulesManualPricesGetToManyRelatedFieldsAppPrice>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_EECFAA282CEB4606(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppPriceSchedulesManualPricesGetToManyRelatedFieldsAppPricePoint>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_B9DFA489D0AD83E5(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppPriceSchedulesManualPricesGetToManyRelatedFieldsTerritorie>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_7427113D1DD74524(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppPriceSchedulesManualPricesGetToManyRelatedIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_37F425CDBABBC69E(options);
                }
                if (type == typeof(global::AppStoreConnect.AppPriceSchedulesManualPricesGetToManyRelatedFieldsAppPrice?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppPriceSchedulesManualPricesGetToManyRelatedFieldsAppPrice2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppPriceSchedulesManualPricesGetToManyRelatedFieldsAppPricePoint?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppPriceSchedulesManualPricesGetToManyRelatedFieldsAppPricePoint2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppPriceSchedulesManualPricesGetToManyRelatedFieldsTerritorie?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppPriceSchedulesManualPricesGetToManyRelatedFieldsTerritorie2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppPriceSchedulesManualPricesGetToManyRelatedIncludeItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppPriceSchedulesManualPricesGetToManyRelatedIncludeItem2(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppPriceSchedulesManualPricesGetToManyRelatedFieldsAppPrice>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_67AA1B01A526542F(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppPriceSchedulesManualPricesGetToManyRelatedFieldsAppPricePoint>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_608EC694EE9F0871(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppPriceSchedulesManualPricesGetToManyRelatedFieldsTerritorie>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_A332E715AF72F75A(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppPriceSchedulesManualPricesGetToManyRelatedIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_D13BE0A5C2593C4B(options);
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