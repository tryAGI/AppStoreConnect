
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_56976E725DD68882 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_56976E725DD68882 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_56976E725DD68882(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFilterPreviewTypeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFilterPreviewTypeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppPreviewSet)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppPreviewSet?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppStoreVersionLocalization)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppStoreVersionLocalization?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppCustomProductPageLocalization)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppCustomProductPageLocalization?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentLocalization)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentLocalization?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppPreview)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppPreview?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedIncludeItem?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFilterPreviewTypeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFilterPreviewTypeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFilterPreviewTypeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFilterPreviewTypeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppPreviewSet))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppPreviewSetJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppPreviewSet?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppPreviewSetNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppStoreVersionLocalization))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppStoreVersionLocalizationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppStoreVersionLocalization?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppStoreVersionLocalizationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppCustomProductPageLocalization))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppCustomProductPageLocalizationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppCustomProductPageLocalization?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppCustomProductPageLocalizationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentLocalization))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentLocalizationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentLocalization?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentLocalizationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppPreview))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppPreviewJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppPreview?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppPreviewNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedIncludeItemNullableJsonConverter();
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
                if (type == typeof(global::AppStoreConnect.AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppCustomProductPageLocalization))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppCustomProductPageLocalization2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppPreview))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppPreview2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppPreviewSet))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppPreviewSet2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentLocalization))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentLocalization2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppStoreVersionLocalization))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppStoreVersionLocalization2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFilterPreviewTypeItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFilterPreviewTypeItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedIncludeItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedIncludeItem2(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppCustomProductPageLocalization>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_75B36B08CB42D510(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppPreview>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_AAE523AB3A878B35(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppPreviewSet>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_D4288F53EDF004A1(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentLocalization>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_05D307B582517D18(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppStoreVersionLocalization>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_6382BDFF458637AB(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFilterPreviewTypeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_025D4C62ACD423C7(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_1CEF4445FF414347(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppCustomProductPageLocalization?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppCustomProductPageLocalization2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppPreview?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppPreview2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppPreviewSet?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppPreviewSet2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentLocalization?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentLocalization2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppStoreVersionLocalization?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppStoreVersionLocalization2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFilterPreviewTypeItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFilterPreviewTypeItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedIncludeItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedIncludeItem2(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppCustomProductPageLocalization>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_E737A5876D592AAE(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppPreview>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_C171727FF70AB87D(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppPreviewSet>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_564D61D98A7095D9(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentLocalization>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_AE651E3FE526C8D9(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppStoreVersionLocalization>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_65B32AA541537A99(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFilterPreviewTypeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_A8E460C3167CC66F(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_65A4A651A8A62D49(options);
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