
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_2FF28FA9739CE02D : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_2FF28FA9739CE02D Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_2FF28FA9739CE02D(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationsAppScreenshotSetsGetToManyRelatedFilterScreenshotDisplayTypeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationsAppScreenshotSetsGetToManyRelatedFilterScreenshotDisplayTypeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshotSet)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshotSet?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppStoreVersionLocalization)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppStoreVersionLocalization?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppCustomProductPageLocalization)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppCustomProductPageLocalization?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentLocalization)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentLocalization?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshot)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshot?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationsAppScreenshotSetsGetToManyRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationsAppScreenshotSetsGetToManyRelatedIncludeItem?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationsAppScreenshotSetsGetToManyRelatedFilterScreenshotDisplayTypeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionExperimentTreatmentLocalizationsAppScreenshotSetsGetToManyRelatedFilterScreenshotDisplayTypeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationsAppScreenshotSetsGetToManyRelatedFilterScreenshotDisplayTypeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionExperimentTreatmentLocalizationsAppScreenshotSetsGetToManyRelatedFilterScreenshotDisplayTypeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshotSet))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionExperimentTreatmentLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshotSetJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshotSet?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionExperimentTreatmentLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshotSetNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppStoreVersionLocalization))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionExperimentTreatmentLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppStoreVersionLocalizationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppStoreVersionLocalization?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionExperimentTreatmentLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppStoreVersionLocalizationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppCustomProductPageLocalization))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionExperimentTreatmentLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppCustomProductPageLocalizationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppCustomProductPageLocalization?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionExperimentTreatmentLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppCustomProductPageLocalizationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentLocalization))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionExperimentTreatmentLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentLocalizationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentLocalization?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionExperimentTreatmentLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentLocalizationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshot))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionExperimentTreatmentLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshotJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshot?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionExperimentTreatmentLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshotNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationsAppScreenshotSetsGetToManyRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionExperimentTreatmentLocalizationsAppScreenshotSetsGetToManyRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationsAppScreenshotSetsGetToManyRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionExperimentTreatmentLocalizationsAppScreenshotSetsGetToManyRelatedIncludeItemNullableJsonConverter();
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
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppCustomProductPageLocalization))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppStoreVersionExperimentTreatmentLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppCustomProductPageLocalization2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshot))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppStoreVersionExperimentTreatmentLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshot2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshotSet))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppStoreVersionExperimentTreatmentLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshotSet2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentLocalization))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionExperimentTreatmentLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppStoreVersionEx_8adc65ada4084838(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppStoreVersionLocalization))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppStoreVersionExperimentTreatmentLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppStoreVersionLocalization2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationsAppScreenshotSetsGetToManyRelatedFilterScreenshotDisplayTypeItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppStoreVersionExperimentTreatmentLocalizationsAppScreenshotSetsGetToManyRelatedFilterScreenshotDisplayTypeItem2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationsAppScreenshotSetsGetToManyRelatedIncludeItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppStoreVersionExperimentTreatmentLocalizationsAppScreenshotSetsGetToManyRelatedIncludeItem2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppCustomProductPageLocalization>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_5C36CF3F059B31E9(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshot>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_22F134048EB7C308(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshotSet>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_1C36C0688318ECFC(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentLocalization>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_EDD5A73B387AECB6(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppStoreVersionLocalization>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_F199263F7130BEE0(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationsAppScreenshotSetsGetToManyRelatedFilterScreenshotDisplayTypeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_77EAFFB58B36A745(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationsAppScreenshotSetsGetToManyRelatedIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_00A85BA99E8B144B(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppCustomProductPageLocalization?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionExperimentTreatmentLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppCustomProductP_129b4979b1febeb2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshot?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppStoreVersionExperimentTreatmentLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshot2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshotSet?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppStoreVersionExperimentTreatmentLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshotSet2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentLocalization?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionExperimentTreatmentLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppStoreVersionEx_a65d611de6496175(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppStoreVersionLocalization?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionExperimentTreatmentLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppStoreVersionLo_d9a961a9025180ba(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationsAppScreenshotSetsGetToManyRelatedFilterScreenshotDisplayTypeItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppStoreVersionExperimentTreatmentLocalizationsAppScreenshotSetsGetToManyRelatedFilterScreenshotDisplayTypeItem2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationsAppScreenshotSetsGetToManyRelatedIncludeItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppStoreVersionExperimentTreatmentLocalizationsAppScreenshotSetsGetToManyRelatedIncludeItem2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppCustomProductPageLocalization>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_AA52399DA98C0E86(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshot>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_7B2C9DB67DE58C0B(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshotSet>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_6FF6097EA31C7356(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentLocalization>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_9EFA5074EFC47157(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppStoreVersionLocalization>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_BFAE6C04E0423FCD(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationsAppScreenshotSetsGetToManyRelatedFilterScreenshotDisplayTypeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_D7CAC6969B101C89(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationsAppScreenshotSetsGetToManyRelatedIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_216B64E7FC5DF50A(options);
                }
                #pragma warning restore CS0618
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