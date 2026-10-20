
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_D64D9FE231FEC805 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_D64D9FE231FEC805 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_D64D9FE231FEC805(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.BetaLicenseAgreementType)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaLicenseAgreementType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaLicenseAgreementRelationshipsAppDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaLicenseAgreementRelationshipsAppDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsBetaLicenseAgreementGetToOneRelatedFieldsBetaLicenseAgreement)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsBetaLicenseAgreementGetToOneRelatedFieldsBetaLicenseAgreement?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.BetaLicenseAgreementType))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaLicenseAgreementTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaLicenseAgreementType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaLicenseAgreementTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaLicenseAgreementRelationshipsAppDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaLicenseAgreementRelationshipsAppDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaLicenseAgreementRelationshipsAppDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaLicenseAgreementRelationshipsAppDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsBetaLicenseAgreementGetToOneRelatedFieldsBetaLicenseAgreement))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsBetaLicenseAgreementGetToOneRelatedFieldsBetaLicenseAgreementJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsBetaLicenseAgreementGetToOneRelatedFieldsBetaLicenseAgreement?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsBetaLicenseAgreementGetToOneRelatedFieldsBetaLicenseAgreementNullableJsonConverter();
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
                if (type == typeof(global::AppStoreConnect.AppsBetaLicenseAgreementGetToOneRelatedFieldsBetaLicenseAgreement))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppsBetaLicenseAgreementGetToOneRelatedFieldsBetaLicenseAgreement2(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaLicenseAgreement))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BetaLicenseAgreement(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaLicenseAgreementAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BetaLicenseAgreementAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaLicenseAgreementRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BetaLicenseAgreementRelationships(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaLicenseAgreementRelationshipsApp))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BetaLicenseAgreementRelationshipsApp(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaLicenseAgreementRelationshipsAppData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BetaLicenseAgreementRelationshipsAppData(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaLicenseAgreementRelationshipsAppDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BetaLicenseAgreementRelationshipsAppDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaLicenseAgreementType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BetaLicenseAgreementType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaLicenseAgreementWithoutIncludesResponse))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_BetaLicenseAgreementWithoutIncludesResponse(options);
                }
                if (type == typeof(global::AppStoreConnect.DocumentLinks))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_DocumentLinks(options);
                }
                if (type == typeof(global::AppStoreConnect.RelationshipLinks))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_RelationshipLinks(options);
                }
                if (type == typeof(global::AppStoreConnect.ResourceLinks))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_ResourceLinks(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppsBetaLicenseAgreementGetToOneRelatedFieldsBetaLicenseAgreement>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_2086645BA94E73AF(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsBetaLicenseAgreementGetToOneRelatedFieldsBetaLicenseAgreement?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppsBetaLicenseAgreementGetToOneRelatedFieldsBetaLicenseAgreement2(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaLicenseAgreementRelationshipsAppDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBetaLicenseAgreementRelationshipsAppDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaLicenseAgreementType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBetaLicenseAgreementType2(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppsBetaLicenseAgreementGetToOneRelatedFieldsBetaLicenseAgreement>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_9B9AB5BC9134E989(options);
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