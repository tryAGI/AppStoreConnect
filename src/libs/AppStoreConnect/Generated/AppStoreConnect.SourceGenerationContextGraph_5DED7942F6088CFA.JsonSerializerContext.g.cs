
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_5DED7942F6088CFA : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_5DED7942F6088CFA Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_5DED7942F6088CFA(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsGetInstanceFieldsAppCustomProductPageLocalization)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsGetInstanceFieldsAppCustomProductPageLocalization?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsGetInstanceFieldsAppCustomProductPageVersion)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsGetInstanceFieldsAppCustomProductPageVersion?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsGetInstanceFieldsAppScreenshotSet)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsGetInstanceFieldsAppScreenshotSet?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsGetInstanceFieldsAppPreviewSet)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsGetInstanceFieldsAppPreviewSet?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsGetInstanceFieldsAppAssetLibraryPlacement)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsGetInstanceFieldsAppAssetLibraryPlacement?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsGetInstanceIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsGetInstanceIncludeItem?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsGetInstanceFieldsAppCustomProductPageLocalization))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPageLocalizationsGetInstanceFieldsAppCustomProductPageLocalizationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsGetInstanceFieldsAppCustomProductPageLocalization?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPageLocalizationsGetInstanceFieldsAppCustomProductPageLocalizationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsGetInstanceFieldsAppCustomProductPageVersion))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPageLocalizationsGetInstanceFieldsAppCustomProductPageVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsGetInstanceFieldsAppCustomProductPageVersion?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPageLocalizationsGetInstanceFieldsAppCustomProductPageVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsGetInstanceFieldsAppScreenshotSet))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPageLocalizationsGetInstanceFieldsAppScreenshotSetJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsGetInstanceFieldsAppScreenshotSet?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPageLocalizationsGetInstanceFieldsAppScreenshotSetNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsGetInstanceFieldsAppPreviewSet))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPageLocalizationsGetInstanceFieldsAppPreviewSetJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsGetInstanceFieldsAppPreviewSet?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPageLocalizationsGetInstanceFieldsAppPreviewSetNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsGetInstanceFieldsAppAssetLibraryPlacement))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPageLocalizationsGetInstanceFieldsAppAssetLibraryPlacementJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsGetInstanceFieldsAppAssetLibraryPlacement?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPageLocalizationsGetInstanceFieldsAppAssetLibraryPlacementNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsGetInstanceIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPageLocalizationsGetInstanceIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsGetInstanceIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPageLocalizationsGetInstanceIncludeItemNullableJsonConverter();
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
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsGetInstanceFieldsAppAssetLibraryPlacement))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppCustomProductPageLocalizationsGetInstanceFieldsAppAssetLibraryPlacement2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsGetInstanceFieldsAppCustomProductPageLocalization))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppCustomProductPageLocalizationsGetInstanceFieldsAppCustomProductPageLocalization2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsGetInstanceFieldsAppCustomProductPageVersion))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppCustomProductPageLocalizationsGetInstanceFieldsAppCustomProductPageVersion2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsGetInstanceFieldsAppPreviewSet))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppCustomProductPageLocalizationsGetInstanceFieldsAppPreviewSet2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsGetInstanceFieldsAppScreenshotSet))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppCustomProductPageLocalizationsGetInstanceFieldsAppScreenshotSet2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsGetInstanceIncludeItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppCustomProductPageLocalizationsGetInstanceIncludeItem2(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppCustomProductPageLocalizationsGetInstanceFieldsAppAssetLibraryPlacement>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_F5A0DA133E24C297(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppCustomProductPageLocalizationsGetInstanceFieldsAppCustomProductPageLocalization>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_BA5E128E44372831(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppCustomProductPageLocalizationsGetInstanceFieldsAppCustomProductPageVersion>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_E81BB872E46CC7EF(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppCustomProductPageLocalizationsGetInstanceFieldsAppPreviewSet>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_BE425C2F932ACED9(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppCustomProductPageLocalizationsGetInstanceFieldsAppScreenshotSet>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_3DED7793FFC62E93(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppCustomProductPageLocalizationsGetInstanceIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_13595D58ACC0C45B(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsGetInstanceFieldsAppAssetLibraryPlacement?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppCustomProductPageLocalizationsGetInstanceFieldsAppAssetLibraryPlacement2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsGetInstanceFieldsAppCustomProductPageLocalization?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppCustomProductPageLocalizationsGetInstanceFieldsAppCustomProductPageLocalization2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsGetInstanceFieldsAppCustomProductPageVersion?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppCustomProductPageLocalizationsGetInstanceFieldsAppCustomProductPageVersion2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsGetInstanceFieldsAppPreviewSet?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppCustomProductPageLocalizationsGetInstanceFieldsAppPreviewSet2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsGetInstanceFieldsAppScreenshotSet?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppCustomProductPageLocalizationsGetInstanceFieldsAppScreenshotSet2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsGetInstanceIncludeItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppCustomProductPageLocalizationsGetInstanceIncludeItem2(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppCustomProductPageLocalizationsGetInstanceFieldsAppAssetLibraryPlacement>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_B7AF0C2285F63995(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppCustomProductPageLocalizationsGetInstanceFieldsAppCustomProductPageLocalization>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_848F0B891661DC6D(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppCustomProductPageLocalizationsGetInstanceFieldsAppCustomProductPageVersion>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_7CBD3C074E289D15(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppCustomProductPageLocalizationsGetInstanceFieldsAppPreviewSet>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_2D221CBC129EC1F3(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppCustomProductPageLocalizationsGetInstanceFieldsAppScreenshotSet>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_8DCE494AB14EBA6F(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppCustomProductPageLocalizationsGetInstanceIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_C9B0995A42ECF1ED(options);
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