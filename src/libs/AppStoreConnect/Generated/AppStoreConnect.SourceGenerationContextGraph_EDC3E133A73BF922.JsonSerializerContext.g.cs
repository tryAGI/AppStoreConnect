
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_EDC3E133A73BF922 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_EDC3E133A73BF922 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_EDC3E133A73BF922(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.AppScreenshotSetsGetInstanceFieldsAppScreenshotSet)

                    || typeToConvert == typeof(global::AppStoreConnect.AppScreenshotSetsGetInstanceFieldsAppScreenshotSet?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppScreenshotSetsGetInstanceFieldsAppStoreVersionLocalization)

                    || typeToConvert == typeof(global::AppStoreConnect.AppScreenshotSetsGetInstanceFieldsAppStoreVersionLocalization?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppScreenshotSetsGetInstanceFieldsAppCustomProductPageLocalization)

                    || typeToConvert == typeof(global::AppStoreConnect.AppScreenshotSetsGetInstanceFieldsAppCustomProductPageLocalization?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppScreenshotSetsGetInstanceFieldsAppStoreVersionExperimentTreatmentLocalization)

                    || typeToConvert == typeof(global::AppStoreConnect.AppScreenshotSetsGetInstanceFieldsAppStoreVersionExperimentTreatmentLocalization?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppScreenshotSetsGetInstanceFieldsAppScreenshot)

                    || typeToConvert == typeof(global::AppStoreConnect.AppScreenshotSetsGetInstanceFieldsAppScreenshot?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppScreenshotSetsGetInstanceIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.AppScreenshotSetsGetInstanceIncludeItem?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.AppScreenshotSetsGetInstanceFieldsAppScreenshotSet))
                {
                    return new global::AppStoreConnect.JsonConverters.AppScreenshotSetsGetInstanceFieldsAppScreenshotSetJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppScreenshotSetsGetInstanceFieldsAppScreenshotSet?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppScreenshotSetsGetInstanceFieldsAppScreenshotSetNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppScreenshotSetsGetInstanceFieldsAppStoreVersionLocalization))
                {
                    return new global::AppStoreConnect.JsonConverters.AppScreenshotSetsGetInstanceFieldsAppStoreVersionLocalizationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppScreenshotSetsGetInstanceFieldsAppStoreVersionLocalization?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppScreenshotSetsGetInstanceFieldsAppStoreVersionLocalizationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppScreenshotSetsGetInstanceFieldsAppCustomProductPageLocalization))
                {
                    return new global::AppStoreConnect.JsonConverters.AppScreenshotSetsGetInstanceFieldsAppCustomProductPageLocalizationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppScreenshotSetsGetInstanceFieldsAppCustomProductPageLocalization?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppScreenshotSetsGetInstanceFieldsAppCustomProductPageLocalizationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppScreenshotSetsGetInstanceFieldsAppStoreVersionExperimentTreatmentLocalization))
                {
                    return new global::AppStoreConnect.JsonConverters.AppScreenshotSetsGetInstanceFieldsAppStoreVersionExperimentTreatmentLocalizationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppScreenshotSetsGetInstanceFieldsAppStoreVersionExperimentTreatmentLocalization?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppScreenshotSetsGetInstanceFieldsAppStoreVersionExperimentTreatmentLocalizationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppScreenshotSetsGetInstanceFieldsAppScreenshot))
                {
                    return new global::AppStoreConnect.JsonConverters.AppScreenshotSetsGetInstanceFieldsAppScreenshotJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppScreenshotSetsGetInstanceFieldsAppScreenshot?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppScreenshotSetsGetInstanceFieldsAppScreenshotNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppScreenshotSetsGetInstanceIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.AppScreenshotSetsGetInstanceIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppScreenshotSetsGetInstanceIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppScreenshotSetsGetInstanceIncludeItemNullableJsonConverter();
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
                if (type == typeof(global::AppStoreConnect.AppScreenshotSetsGetInstanceFieldsAppCustomProductPageLocalization))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppScreenshotSetsGetInstanceFieldsAppCustomProductPageLocalization2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppScreenshotSetsGetInstanceFieldsAppScreenshot))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppScreenshotSetsGetInstanceFieldsAppScreenshot2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppScreenshotSetsGetInstanceFieldsAppScreenshotSet))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppScreenshotSetsGetInstanceFieldsAppScreenshotSet2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppScreenshotSetsGetInstanceFieldsAppStoreVersionExperimentTreatmentLocalization))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppScreenshotSetsGetInstanceFieldsAppStoreVersionExperimentTreatmentLocalization2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppScreenshotSetsGetInstanceFieldsAppStoreVersionLocalization))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppScreenshotSetsGetInstanceFieldsAppStoreVersionLocalization2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppScreenshotSetsGetInstanceIncludeItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppScreenshotSetsGetInstanceIncludeItem2(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppScreenshotSetsGetInstanceFieldsAppCustomProductPageLocalization>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_D3986C6F6343385F(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppScreenshotSetsGetInstanceFieldsAppScreenshot>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_9383996B9BFB2971(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppScreenshotSetsGetInstanceFieldsAppScreenshotSet>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_C4215796A718A74F(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppScreenshotSetsGetInstanceFieldsAppStoreVersionExperimentTreatmentLocalization>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_FC84A09FEB3198E2(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppScreenshotSetsGetInstanceFieldsAppStoreVersionLocalization>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_219D18350D5FC90E(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppScreenshotSetsGetInstanceIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_DBB1242EFCDD418E(options);
                }
                if (type == typeof(global::AppStoreConnect.AppScreenshotSetsGetInstanceFieldsAppCustomProductPageLocalization?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppScreenshotSetsGetInstanceFieldsAppCustomProductPageLocalization2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppScreenshotSetsGetInstanceFieldsAppScreenshot?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppScreenshotSetsGetInstanceFieldsAppScreenshot2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppScreenshotSetsGetInstanceFieldsAppScreenshotSet?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppScreenshotSetsGetInstanceFieldsAppScreenshotSet2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppScreenshotSetsGetInstanceFieldsAppStoreVersionExperimentTreatmentLocalization?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppScreenshotSetsGetInstanceFieldsAppStoreVersionExperimentTreatmentLocalization2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppScreenshotSetsGetInstanceFieldsAppStoreVersionLocalization?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppScreenshotSetsGetInstanceFieldsAppStoreVersionLocalization2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppScreenshotSetsGetInstanceIncludeItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppScreenshotSetsGetInstanceIncludeItem2(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppScreenshotSetsGetInstanceFieldsAppCustomProductPageLocalization>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_1A22B0E6DC1AA702(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppScreenshotSetsGetInstanceFieldsAppScreenshot>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_CDFB8DA23E356FD3(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppScreenshotSetsGetInstanceFieldsAppScreenshotSet>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_87E84EDFB6B79242(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppScreenshotSetsGetInstanceFieldsAppStoreVersionExperimentTreatmentLocalization>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_78644B9DFA9FA424(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppScreenshotSetsGetInstanceFieldsAppStoreVersionLocalization>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_0AF7E574068BEDCC(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppScreenshotSetsGetInstanceIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_CEF771082E26001A(options);
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