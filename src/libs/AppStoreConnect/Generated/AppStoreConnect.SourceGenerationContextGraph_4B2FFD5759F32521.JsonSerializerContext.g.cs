
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_4B2FFD5759F32521 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_4B2FFD5759F32521 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_4B2FFD5759F32521(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFilterScreenshotDisplayTypeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFilterScreenshotDisplayTypeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshotSet)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshotSet?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppStoreVersionLocalization)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppStoreVersionLocalization?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppCustomProductPageLocalization)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppCustomProductPageLocalization?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentLocalization)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentLocalization?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshot)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshot?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedIncludeItem?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFilterScreenshotDisplayTypeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFilterScreenshotDisplayTypeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFilterScreenshotDisplayTypeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFilterScreenshotDisplayTypeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshotSet))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshotSetJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshotSet?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshotSetNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppStoreVersionLocalization))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppStoreVersionLocalizationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppStoreVersionLocalization?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppStoreVersionLocalizationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppCustomProductPageLocalization))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppCustomProductPageLocalizationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppCustomProductPageLocalization?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppCustomProductPageLocalizationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentLocalization))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentLocalizationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentLocalization?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentLocalizationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshot))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshotJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshot?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshotNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedIncludeItemNullableJsonConverter();
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
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppCustomProductPageLocalization))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppCustomProductPageLocalization2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshot))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshot2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshotSet))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshotSet2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentLocalization))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentLocalization2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppStoreVersionLocalization))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppStoreVersionLocalization2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFilterScreenshotDisplayTypeItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFilterScreenshotDisplayTypeItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedIncludeItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedIncludeItem2(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppCustomProductPageLocalization>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_88A6CE7BD64834B0(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshot>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_07C2C6B1DF140BDA(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshotSet>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_FE3563093EF6B983(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentLocalization>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_7D26B68522432A0B(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppStoreVersionLocalization>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_78AEA19602A92B08(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFilterScreenshotDisplayTypeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_73F14B15797CB2FB(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_2228FC2BD49B3129(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppCustomProductPageLocalization?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppCustomProductPageLocalization2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshot?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshot2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshotSet?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshotSet2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentLocalization?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppStoreVersionExperimentTreatm_23a1e0ae5cf437e5(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppStoreVersionLocalization?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppStoreVersionLocalization2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFilterScreenshotDisplayTypeItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFilterScreenshotDisplayTypeItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedIncludeItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedIncludeItem2(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppCustomProductPageLocalization>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_8C1DABC65C1976F3(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshot>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_428505C262F58626(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshotSet>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_61949BDC603AA27F(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentLocalization>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_A2C5F414E8338C16(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppStoreVersionLocalization>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_FC3A82F716599A79(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFilterScreenshotDisplayTypeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_C2A05C1A59BB6365(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_98113F5A73D5A600(options);
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