
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_988650F6424AB416 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_988650F6424AB416 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_988650F6424AB416(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.ProfilesGetInstanceFieldsProfile)

                    || typeToConvert == typeof(global::AppStoreConnect.ProfilesGetInstanceFieldsProfile?)

                    || typeToConvert == typeof(global::AppStoreConnect.ProfilesGetInstanceFieldsBundleId)

                    || typeToConvert == typeof(global::AppStoreConnect.ProfilesGetInstanceFieldsBundleId?)

                    || typeToConvert == typeof(global::AppStoreConnect.ProfilesGetInstanceFieldsDevice)

                    || typeToConvert == typeof(global::AppStoreConnect.ProfilesGetInstanceFieldsDevice?)

                    || typeToConvert == typeof(global::AppStoreConnect.ProfilesGetInstanceFieldsCertificate)

                    || typeToConvert == typeof(global::AppStoreConnect.ProfilesGetInstanceFieldsCertificate?)

                    || typeToConvert == typeof(global::AppStoreConnect.ProfilesGetInstanceIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.ProfilesGetInstanceIncludeItem?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.ProfilesGetInstanceFieldsProfile))
                {
                    return new global::AppStoreConnect.JsonConverters.ProfilesGetInstanceFieldsProfileJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ProfilesGetInstanceFieldsProfile?))
                {
                    return new global::AppStoreConnect.JsonConverters.ProfilesGetInstanceFieldsProfileNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ProfilesGetInstanceFieldsBundleId))
                {
                    return new global::AppStoreConnect.JsonConverters.ProfilesGetInstanceFieldsBundleIdJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ProfilesGetInstanceFieldsBundleId?))
                {
                    return new global::AppStoreConnect.JsonConverters.ProfilesGetInstanceFieldsBundleIdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ProfilesGetInstanceFieldsDevice))
                {
                    return new global::AppStoreConnect.JsonConverters.ProfilesGetInstanceFieldsDeviceJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ProfilesGetInstanceFieldsDevice?))
                {
                    return new global::AppStoreConnect.JsonConverters.ProfilesGetInstanceFieldsDeviceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ProfilesGetInstanceFieldsCertificate))
                {
                    return new global::AppStoreConnect.JsonConverters.ProfilesGetInstanceFieldsCertificateJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ProfilesGetInstanceFieldsCertificate?))
                {
                    return new global::AppStoreConnect.JsonConverters.ProfilesGetInstanceFieldsCertificateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ProfilesGetInstanceIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.ProfilesGetInstanceIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ProfilesGetInstanceIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.ProfilesGetInstanceIncludeItemNullableJsonConverter();
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
                if (type == typeof(global::AppStoreConnect.ProfilesGetInstanceFieldsBundleId))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_ProfilesGetInstanceFieldsBundleId2(options);
                }
                if (type == typeof(global::AppStoreConnect.ProfilesGetInstanceFieldsCertificate))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_ProfilesGetInstanceFieldsCertificate2(options);
                }
                if (type == typeof(global::AppStoreConnect.ProfilesGetInstanceFieldsDevice))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_ProfilesGetInstanceFieldsDevice2(options);
                }
                if (type == typeof(global::AppStoreConnect.ProfilesGetInstanceFieldsProfile))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_ProfilesGetInstanceFieldsProfile2(options);
                }
                if (type == typeof(global::AppStoreConnect.ProfilesGetInstanceIncludeItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_ProfilesGetInstanceIncludeItem2(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.ProfilesGetInstanceFieldsBundleId>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_AD3C9F81CF25902E(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.ProfilesGetInstanceFieldsCertificate>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_1C20884834CEAB33(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.ProfilesGetInstanceFieldsDevice>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_7541A6E0331127E8(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.ProfilesGetInstanceFieldsProfile>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_2508EFB574B6AD32(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.ProfilesGetInstanceIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_92344883B9D2BB35(options);
                }
                if (type == typeof(global::AppStoreConnect.ProfilesGetInstanceFieldsBundleId?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableProfilesGetInstanceFieldsBundleId2(options);
                }
                if (type == typeof(global::AppStoreConnect.ProfilesGetInstanceFieldsCertificate?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableProfilesGetInstanceFieldsCertificate2(options);
                }
                if (type == typeof(global::AppStoreConnect.ProfilesGetInstanceFieldsDevice?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableProfilesGetInstanceFieldsDevice2(options);
                }
                if (type == typeof(global::AppStoreConnect.ProfilesGetInstanceFieldsProfile?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableProfilesGetInstanceFieldsProfile2(options);
                }
                if (type == typeof(global::AppStoreConnect.ProfilesGetInstanceIncludeItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableProfilesGetInstanceIncludeItem2(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.ProfilesGetInstanceFieldsBundleId>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_7145CB488F947F36(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.ProfilesGetInstanceFieldsCertificate>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_0832131B5945D0C2(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.ProfilesGetInstanceFieldsDevice>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_F04A2FF1ABF5A19B(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.ProfilesGetInstanceFieldsProfile>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_E8F1F01A71FA3F9C(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.ProfilesGetInstanceIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_4FBE1E41374E058A(options);
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