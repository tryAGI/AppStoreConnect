
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_86EB10D6EC7257E3 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_86EB10D6EC7257E3 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_86EB10D6EC7257E3(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.EndUserLicenseAgreementsGetInstanceFieldsEndUserLicenseAgreement)

                    || typeToConvert == typeof(global::AppStoreConnect.EndUserLicenseAgreementsGetInstanceFieldsEndUserLicenseAgreement?)

                    || typeToConvert == typeof(global::AppStoreConnect.EndUserLicenseAgreementsGetInstanceFieldsApp)

                    || typeToConvert == typeof(global::AppStoreConnect.EndUserLicenseAgreementsGetInstanceFieldsApp?)

                    || typeToConvert == typeof(global::AppStoreConnect.EndUserLicenseAgreementsGetInstanceFieldsTerritorie)

                    || typeToConvert == typeof(global::AppStoreConnect.EndUserLicenseAgreementsGetInstanceFieldsTerritorie?)

                    || typeToConvert == typeof(global::AppStoreConnect.EndUserLicenseAgreementsGetInstanceIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.EndUserLicenseAgreementsGetInstanceIncludeItem?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.EndUserLicenseAgreementsGetInstanceFieldsEndUserLicenseAgreement))
                {
                    return new global::AppStoreConnect.JsonConverters.EndUserLicenseAgreementsGetInstanceFieldsEndUserLicenseAgreementJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.EndUserLicenseAgreementsGetInstanceFieldsEndUserLicenseAgreement?))
                {
                    return new global::AppStoreConnect.JsonConverters.EndUserLicenseAgreementsGetInstanceFieldsEndUserLicenseAgreementNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.EndUserLicenseAgreementsGetInstanceFieldsApp))
                {
                    return new global::AppStoreConnect.JsonConverters.EndUserLicenseAgreementsGetInstanceFieldsAppJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.EndUserLicenseAgreementsGetInstanceFieldsApp?))
                {
                    return new global::AppStoreConnect.JsonConverters.EndUserLicenseAgreementsGetInstanceFieldsAppNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.EndUserLicenseAgreementsGetInstanceFieldsTerritorie))
                {
                    return new global::AppStoreConnect.JsonConverters.EndUserLicenseAgreementsGetInstanceFieldsTerritorieJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.EndUserLicenseAgreementsGetInstanceFieldsTerritorie?))
                {
                    return new global::AppStoreConnect.JsonConverters.EndUserLicenseAgreementsGetInstanceFieldsTerritorieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.EndUserLicenseAgreementsGetInstanceIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.EndUserLicenseAgreementsGetInstanceIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.EndUserLicenseAgreementsGetInstanceIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.EndUserLicenseAgreementsGetInstanceIncludeItemNullableJsonConverter();
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
                if (type == typeof(global::AppStoreConnect.EndUserLicenseAgreementsGetInstanceFieldsApp))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_EndUserLicenseAgreementsGetInstanceFieldsApp2(options);
                }
                if (type == typeof(global::AppStoreConnect.EndUserLicenseAgreementsGetInstanceFieldsEndUserLicenseAgreement))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_EndUserLicenseAgreementsGetInstanceFieldsEndUserLicenseAgreement2(options);
                }
                if (type == typeof(global::AppStoreConnect.EndUserLicenseAgreementsGetInstanceFieldsTerritorie))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_EndUserLicenseAgreementsGetInstanceFieldsTerritorie2(options);
                }
                if (type == typeof(global::AppStoreConnect.EndUserLicenseAgreementsGetInstanceIncludeItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_EndUserLicenseAgreementsGetInstanceIncludeItem2(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.EndUserLicenseAgreementsGetInstanceFieldsApp>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_C1A9B550C0D169B0(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.EndUserLicenseAgreementsGetInstanceFieldsEndUserLicenseAgreement>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_3CEEF47EC9B6FF08(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.EndUserLicenseAgreementsGetInstanceFieldsTerritorie>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_728B3E8BAD5D31C8(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.EndUserLicenseAgreementsGetInstanceIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_D4266433F5ADBE13(options);
                }
                if (type == typeof(global::AppStoreConnect.EndUserLicenseAgreementsGetInstanceFieldsApp?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableEndUserLicenseAgreementsGetInstanceFieldsApp2(options);
                }
                if (type == typeof(global::AppStoreConnect.EndUserLicenseAgreementsGetInstanceFieldsEndUserLicenseAgreement?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableEndUserLicenseAgreementsGetInstanceFieldsEndUserLicenseAgreement2(options);
                }
                if (type == typeof(global::AppStoreConnect.EndUserLicenseAgreementsGetInstanceFieldsTerritorie?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableEndUserLicenseAgreementsGetInstanceFieldsTerritorie2(options);
                }
                if (type == typeof(global::AppStoreConnect.EndUserLicenseAgreementsGetInstanceIncludeItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableEndUserLicenseAgreementsGetInstanceIncludeItem2(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.EndUserLicenseAgreementsGetInstanceFieldsApp>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_A9548D84DECA561D(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.EndUserLicenseAgreementsGetInstanceFieldsEndUserLicenseAgreement>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_140DCDE8011750E2(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.EndUserLicenseAgreementsGetInstanceFieldsTerritorie>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_F2202B8DC64110B9(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.EndUserLicenseAgreementsGetInstanceIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_CC08BB434832C3E6(options);
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