
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_D4AD4406A895BDBA : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_D4AD4406A895BDBA Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_D4AD4406A895BDBA(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.AppEventLocalizationsGetInstanceFieldsAppEventLocalization)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEventLocalizationsGetInstanceFieldsAppEventLocalization?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEventLocalizationsGetInstanceFieldsAppEvent)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEventLocalizationsGetInstanceFieldsAppEvent?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEventLocalizationsGetInstanceFieldsAppEventScreenshot)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEventLocalizationsGetInstanceFieldsAppEventScreenshot?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEventLocalizationsGetInstanceFieldsAppEventVideoClip)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEventLocalizationsGetInstanceFieldsAppEventVideoClip?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEventLocalizationsGetInstanceFieldsAppAssetLibraryPlacement)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEventLocalizationsGetInstanceFieldsAppAssetLibraryPlacement?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEventLocalizationsGetInstanceIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEventLocalizationsGetInstanceIncludeItem?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.AppEventLocalizationsGetInstanceFieldsAppEventLocalization))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEventLocalizationsGetInstanceFieldsAppEventLocalizationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppEventLocalizationsGetInstanceFieldsAppEventLocalization?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEventLocalizationsGetInstanceFieldsAppEventLocalizationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppEventLocalizationsGetInstanceFieldsAppEvent))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEventLocalizationsGetInstanceFieldsAppEventJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppEventLocalizationsGetInstanceFieldsAppEvent?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEventLocalizationsGetInstanceFieldsAppEventNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppEventLocalizationsGetInstanceFieldsAppEventScreenshot))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEventLocalizationsGetInstanceFieldsAppEventScreenshotJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppEventLocalizationsGetInstanceFieldsAppEventScreenshot?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEventLocalizationsGetInstanceFieldsAppEventScreenshotNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppEventLocalizationsGetInstanceFieldsAppEventVideoClip))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEventLocalizationsGetInstanceFieldsAppEventVideoClipJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppEventLocalizationsGetInstanceFieldsAppEventVideoClip?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEventLocalizationsGetInstanceFieldsAppEventVideoClipNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppEventLocalizationsGetInstanceFieldsAppAssetLibraryPlacement))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEventLocalizationsGetInstanceFieldsAppAssetLibraryPlacementJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppEventLocalizationsGetInstanceFieldsAppAssetLibraryPlacement?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEventLocalizationsGetInstanceFieldsAppAssetLibraryPlacementNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppEventLocalizationsGetInstanceIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEventLocalizationsGetInstanceIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppEventLocalizationsGetInstanceIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEventLocalizationsGetInstanceIncludeItemNullableJsonConverter();
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
                if (type == typeof(global::AppStoreConnect.AppEventLocalizationsGetInstanceFieldsAppAssetLibraryPlacement))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppEventLocalizationsGetInstanceFieldsAppAssetLibraryPlacement2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppEventLocalizationsGetInstanceFieldsAppEvent))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppEventLocalizationsGetInstanceFieldsAppEvent2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppEventLocalizationsGetInstanceFieldsAppEventLocalization))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppEventLocalizationsGetInstanceFieldsAppEventLocalization2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppEventLocalizationsGetInstanceFieldsAppEventScreenshot))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppEventLocalizationsGetInstanceFieldsAppEventScreenshot2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppEventLocalizationsGetInstanceFieldsAppEventVideoClip))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppEventLocalizationsGetInstanceFieldsAppEventVideoClip2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppEventLocalizationsGetInstanceIncludeItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppEventLocalizationsGetInstanceIncludeItem2(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppEventLocalizationsGetInstanceFieldsAppAssetLibraryPlacement>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_CA5F6DBA4E53C1B2(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppEventLocalizationsGetInstanceFieldsAppEvent>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_7BF42EEBD6403791(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppEventLocalizationsGetInstanceFieldsAppEventLocalization>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_9810C0622F1395DD(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppEventLocalizationsGetInstanceFieldsAppEventScreenshot>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_D05932A16FDEA1D3(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppEventLocalizationsGetInstanceFieldsAppEventVideoClip>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_10FFD29B2419D63D(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppEventLocalizationsGetInstanceIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_C179BDCBCD993033(options);
                }
                if (type == typeof(global::AppStoreConnect.AppEventLocalizationsGetInstanceFieldsAppAssetLibraryPlacement?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppEventLocalizationsGetInstanceFieldsAppAssetLibraryPlacement2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppEventLocalizationsGetInstanceFieldsAppEvent?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppEventLocalizationsGetInstanceFieldsAppEvent2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppEventLocalizationsGetInstanceFieldsAppEventLocalization?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppEventLocalizationsGetInstanceFieldsAppEventLocalization2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppEventLocalizationsGetInstanceFieldsAppEventScreenshot?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppEventLocalizationsGetInstanceFieldsAppEventScreenshot2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppEventLocalizationsGetInstanceFieldsAppEventVideoClip?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppEventLocalizationsGetInstanceFieldsAppEventVideoClip2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppEventLocalizationsGetInstanceIncludeItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppEventLocalizationsGetInstanceIncludeItem2(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppEventLocalizationsGetInstanceFieldsAppAssetLibraryPlacement>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_6681817C5E9B9915(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppEventLocalizationsGetInstanceFieldsAppEvent>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_C9851BF1EBB3F886(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppEventLocalizationsGetInstanceFieldsAppEventLocalization>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_382E23DB5E7573E3(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppEventLocalizationsGetInstanceFieldsAppEventScreenshot>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_9751E0B8B1AF50F9(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppEventLocalizationsGetInstanceFieldsAppEventVideoClip>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_44C9D4B582486D9B(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppEventLocalizationsGetInstanceIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_BB8DF8712327AA1E(options);
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