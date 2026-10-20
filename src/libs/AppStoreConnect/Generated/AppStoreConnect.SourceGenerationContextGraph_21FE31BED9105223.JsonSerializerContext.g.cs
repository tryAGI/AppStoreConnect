
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_21FE31BED9105223 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_21FE31BED9105223 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_21FE31BED9105223(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationsGetInstanceFieldsAppStoreVersionExperimentTreatmentLocalization)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationsGetInstanceFieldsAppStoreVersionExperimentTreatmentLocalization?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationsGetInstanceFieldsAppStoreVersionExperimentTreatment)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationsGetInstanceFieldsAppStoreVersionExperimentTreatment?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationsGetInstanceFieldsAppScreenshotSet)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationsGetInstanceFieldsAppScreenshotSet?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationsGetInstanceFieldsAppPreviewSet)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationsGetInstanceFieldsAppPreviewSet?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationsGetInstanceFieldsAppAssetLibraryPlacement)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationsGetInstanceFieldsAppAssetLibraryPlacement?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationsGetInstanceIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationsGetInstanceIncludeItem?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationsGetInstanceFieldsAppStoreVersionExperimentTreatmentLocalization))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionExperimentTreatmentLocalizationsGetInstanceFieldsAppStoreVersionExperimentTreatmentLocalizationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationsGetInstanceFieldsAppStoreVersionExperimentTreatmentLocalization?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionExperimentTreatmentLocalizationsGetInstanceFieldsAppStoreVersionExperimentTreatmentLocalizationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationsGetInstanceFieldsAppStoreVersionExperimentTreatment))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionExperimentTreatmentLocalizationsGetInstanceFieldsAppStoreVersionExperimentTreatmentJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationsGetInstanceFieldsAppStoreVersionExperimentTreatment?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionExperimentTreatmentLocalizationsGetInstanceFieldsAppStoreVersionExperimentTreatmentNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationsGetInstanceFieldsAppScreenshotSet))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionExperimentTreatmentLocalizationsGetInstanceFieldsAppScreenshotSetJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationsGetInstanceFieldsAppScreenshotSet?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionExperimentTreatmentLocalizationsGetInstanceFieldsAppScreenshotSetNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationsGetInstanceFieldsAppPreviewSet))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionExperimentTreatmentLocalizationsGetInstanceFieldsAppPreviewSetJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationsGetInstanceFieldsAppPreviewSet?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionExperimentTreatmentLocalizationsGetInstanceFieldsAppPreviewSetNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationsGetInstanceFieldsAppAssetLibraryPlacement))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionExperimentTreatmentLocalizationsGetInstanceFieldsAppAssetLibraryPlacementJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationsGetInstanceFieldsAppAssetLibraryPlacement?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionExperimentTreatmentLocalizationsGetInstanceFieldsAppAssetLibraryPlacementNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationsGetInstanceIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionExperimentTreatmentLocalizationsGetInstanceIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationsGetInstanceIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionExperimentTreatmentLocalizationsGetInstanceIncludeItemNullableJsonConverter();
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
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationsGetInstanceFieldsAppAssetLibraryPlacement))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppStoreVersionExperimentTreatmentLocalizationsGetInstanceFieldsAppAssetLibraryPlacement2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationsGetInstanceFieldsAppPreviewSet))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppStoreVersionExperimentTreatmentLocalizationsGetInstanceFieldsAppPreviewSet2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationsGetInstanceFieldsAppScreenshotSet))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppStoreVersionExperimentTreatmentLocalizationsGetInstanceFieldsAppScreenshotSet2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationsGetInstanceFieldsAppStoreVersionExperimentTreatment))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppStoreVersionExperimentTreatmentLocalizationsGetInstanceFieldsAppStoreVersionExperimentTreatment2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationsGetInstanceFieldsAppStoreVersionExperimentTreatmentLocalization))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppStoreVersionExperimentTreatmentLocalizationsGetInstanceFieldsAppStoreVersionExperimentTreatmentLocalization2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationsGetInstanceIncludeItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppStoreVersionExperimentTreatmentLocalizationsGetInstanceIncludeItem2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationsGetInstanceFieldsAppAssetLibraryPlacement>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_BDE7189CBF30D16D(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationsGetInstanceFieldsAppPreviewSet>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_83058D5FA5C6F2BF(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationsGetInstanceFieldsAppScreenshotSet>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_3C974393D37F5149(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationsGetInstanceFieldsAppStoreVersionExperimentTreatment>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_F80CEFF13431282B(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationsGetInstanceFieldsAppStoreVersionExperimentTreatmentLocalization>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_E17E3FAB927DCC60(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationsGetInstanceIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_83AA1D82F8C018CE(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationsGetInstanceFieldsAppAssetLibraryPlacement?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppStoreVersionExperimentTreatmentLocalizationsGetInstanceFieldsAppAssetLibraryPlacement2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationsGetInstanceFieldsAppPreviewSet?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppStoreVersionExperimentTreatmentLocalizationsGetInstanceFieldsAppPreviewSet2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationsGetInstanceFieldsAppScreenshotSet?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppStoreVersionExperimentTreatmentLocalizationsGetInstanceFieldsAppScreenshotSet2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationsGetInstanceFieldsAppStoreVersionExperimentTreatment?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppStoreVersionExperimentTreatmentLocalizationsGetInstanceFieldsAppStoreVersionExperimentTreatment2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationsGetInstanceFieldsAppStoreVersionExperimentTreatmentLocalization?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppStoreVersionExperimentTreatmentLocalizationsGetInstanceFieldsAppStoreVersionExperimentTreatmentLocalization2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationsGetInstanceIncludeItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppStoreVersionExperimentTreatmentLocalizationsGetInstanceIncludeItem2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationsGetInstanceFieldsAppAssetLibraryPlacement>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_DC86C11822DE0A9F(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationsGetInstanceFieldsAppPreviewSet>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_656068A22CAA73E2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationsGetInstanceFieldsAppScreenshotSet>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_2EAFDAB415B5EF65(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationsGetInstanceFieldsAppStoreVersionExperimentTreatment>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_3F3A821661BBF115(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationsGetInstanceFieldsAppStoreVersionExperimentTreatmentLocalization>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_2616A8D36299A198(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationsGetInstanceIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_FB7AECA6CC8094AA(options);
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