
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_DEFBC14D2B062D04 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_DEFBC14D2B062D04 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_DEFBC14D2B062D04(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.AppInfosGetInstanceFieldsAppInfo)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfosGetInstanceFieldsAppInfo?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfosGetInstanceFieldsApp)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfosGetInstanceFieldsApp?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfosGetInstanceFieldsAgeRatingDeclaration)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfosGetInstanceFieldsAgeRatingDeclaration?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfosGetInstanceFieldsAppInfoLocalization)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfosGetInstanceFieldsAppInfoLocalization?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfosGetInstanceFieldsAppCategorie)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfosGetInstanceFieldsAppCategorie?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfosGetInstanceIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfosGetInstanceIncludeItem?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.AppInfosGetInstanceFieldsAppInfo))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfosGetInstanceFieldsAppInfoJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfosGetInstanceFieldsAppInfo?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfosGetInstanceFieldsAppInfoNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfosGetInstanceFieldsApp))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfosGetInstanceFieldsAppJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfosGetInstanceFieldsApp?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfosGetInstanceFieldsAppNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfosGetInstanceFieldsAgeRatingDeclaration))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfosGetInstanceFieldsAgeRatingDeclarationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfosGetInstanceFieldsAgeRatingDeclaration?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfosGetInstanceFieldsAgeRatingDeclarationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfosGetInstanceFieldsAppInfoLocalization))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfosGetInstanceFieldsAppInfoLocalizationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfosGetInstanceFieldsAppInfoLocalization?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfosGetInstanceFieldsAppInfoLocalizationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfosGetInstanceFieldsAppCategorie))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfosGetInstanceFieldsAppCategorieJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfosGetInstanceFieldsAppCategorie?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfosGetInstanceFieldsAppCategorieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfosGetInstanceIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfosGetInstanceIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfosGetInstanceIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfosGetInstanceIncludeItemNullableJsonConverter();
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
                if (type == typeof(global::AppStoreConnect.AppInfosGetInstanceFieldsAgeRatingDeclaration))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppInfosGetInstanceFieldsAgeRatingDeclaration2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfosGetInstanceFieldsApp))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppInfosGetInstanceFieldsApp2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfosGetInstanceFieldsAppCategorie))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppInfosGetInstanceFieldsAppCategorie2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfosGetInstanceFieldsAppInfo))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppInfosGetInstanceFieldsAppInfo2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfosGetInstanceFieldsAppInfoLocalization))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppInfosGetInstanceFieldsAppInfoLocalization2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfosGetInstanceIncludeItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppInfosGetInstanceIncludeItem2(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppInfosGetInstanceFieldsAgeRatingDeclaration>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_729A6FF3C4DEA965(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppInfosGetInstanceFieldsApp>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_9DF80791FF4ED667(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppInfosGetInstanceFieldsAppCategorie>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_350445512B02ED39(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppInfosGetInstanceFieldsAppInfo>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_730F881963BE6A11(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppInfosGetInstanceFieldsAppInfoLocalization>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_633F489CCF49976B(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppInfosGetInstanceIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_EF1F440F53B0E5F1(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfosGetInstanceFieldsAgeRatingDeclaration?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppInfosGetInstanceFieldsAgeRatingDeclaration2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfosGetInstanceFieldsApp?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppInfosGetInstanceFieldsApp2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfosGetInstanceFieldsAppCategorie?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppInfosGetInstanceFieldsAppCategorie2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfosGetInstanceFieldsAppInfo?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppInfosGetInstanceFieldsAppInfo2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfosGetInstanceFieldsAppInfoLocalization?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppInfosGetInstanceFieldsAppInfoLocalization2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfosGetInstanceIncludeItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppInfosGetInstanceIncludeItem2(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppInfosGetInstanceFieldsAgeRatingDeclaration>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_238D583F3D08CBF2(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppInfosGetInstanceFieldsApp>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_238E7A039BA8E0D9(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppInfosGetInstanceFieldsAppCategorie>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_4F4FE2CEFED707DF(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppInfosGetInstanceFieldsAppInfo>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_EE2C799DBC1CB49C(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppInfosGetInstanceFieldsAppInfoLocalization>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_3FEF11EB632E53B6(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppInfosGetInstanceIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_5CAD1D0607DEF38A(options);
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