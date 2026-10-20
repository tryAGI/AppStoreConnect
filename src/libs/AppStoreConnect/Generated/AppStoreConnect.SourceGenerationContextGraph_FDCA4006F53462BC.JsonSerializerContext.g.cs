
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_FDCA4006F53462BC : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_FDCA4006F53462BC Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_FDCA4006F53462BC(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.BetaGroupsGetInstanceFieldsBetaGroup)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaGroupsGetInstanceFieldsBetaGroup?)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaGroupsGetInstanceFieldsApp)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaGroupsGetInstanceFieldsApp?)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaGroupsGetInstanceFieldsBuild)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaGroupsGetInstanceFieldsBuild?)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaGroupsGetInstanceFieldsBetaTester)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaGroupsGetInstanceFieldsBetaTester?)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaGroupsGetInstanceFieldsBetaRecruitmentCriteriaItem)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaGroupsGetInstanceFieldsBetaRecruitmentCriteriaItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaGroupsGetInstanceIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaGroupsGetInstanceIncludeItem?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.BetaGroupsGetInstanceFieldsBetaGroup))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaGroupsGetInstanceFieldsBetaGroupJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaGroupsGetInstanceFieldsBetaGroup?))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaGroupsGetInstanceFieldsBetaGroupNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaGroupsGetInstanceFieldsApp))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaGroupsGetInstanceFieldsAppJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaGroupsGetInstanceFieldsApp?))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaGroupsGetInstanceFieldsAppNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaGroupsGetInstanceFieldsBuild))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaGroupsGetInstanceFieldsBuildJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaGroupsGetInstanceFieldsBuild?))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaGroupsGetInstanceFieldsBuildNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaGroupsGetInstanceFieldsBetaTester))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaGroupsGetInstanceFieldsBetaTesterJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaGroupsGetInstanceFieldsBetaTester?))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaGroupsGetInstanceFieldsBetaTesterNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaGroupsGetInstanceFieldsBetaRecruitmentCriteriaItem))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaGroupsGetInstanceFieldsBetaRecruitmentCriteriaItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaGroupsGetInstanceFieldsBetaRecruitmentCriteriaItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaGroupsGetInstanceFieldsBetaRecruitmentCriteriaItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaGroupsGetInstanceIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaGroupsGetInstanceIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaGroupsGetInstanceIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaGroupsGetInstanceIncludeItemNullableJsonConverter();
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
                if (type == typeof(global::AppStoreConnect.BetaGroupsGetInstanceFieldsApp))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_BetaGroupsGetInstanceFieldsApp2(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaGroupsGetInstanceFieldsBetaGroup))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_BetaGroupsGetInstanceFieldsBetaGroup2(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaGroupsGetInstanceFieldsBetaRecruitmentCriteriaItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_BetaGroupsGetInstanceFieldsBetaRecruitmentCriteriaItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaGroupsGetInstanceFieldsBetaTester))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_BetaGroupsGetInstanceFieldsBetaTester2(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaGroupsGetInstanceFieldsBuild))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_BetaGroupsGetInstanceFieldsBuild2(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaGroupsGetInstanceIncludeItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_BetaGroupsGetInstanceIncludeItem2(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BetaGroupsGetInstanceFieldsApp>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_5E3CC00A8F190A4E(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BetaGroupsGetInstanceFieldsBetaGroup>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_D6FA967008F76C41(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BetaGroupsGetInstanceFieldsBetaRecruitmentCriteriaItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_319FA84FA5985893(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BetaGroupsGetInstanceFieldsBetaTester>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_34BED207E01BE457(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BetaGroupsGetInstanceFieldsBuild>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_3AA448AC5FB67774(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BetaGroupsGetInstanceIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_435FB56DF6893E4E(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaGroupsGetInstanceFieldsApp?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableBetaGroupsGetInstanceFieldsApp2(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaGroupsGetInstanceFieldsBetaGroup?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableBetaGroupsGetInstanceFieldsBetaGroup2(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaGroupsGetInstanceFieldsBetaRecruitmentCriteriaItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableBetaGroupsGetInstanceFieldsBetaRecruitmentCriteriaItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaGroupsGetInstanceFieldsBetaTester?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableBetaGroupsGetInstanceFieldsBetaTester2(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaGroupsGetInstanceFieldsBuild?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableBetaGroupsGetInstanceFieldsBuild2(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaGroupsGetInstanceIncludeItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableBetaGroupsGetInstanceIncludeItem2(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BetaGroupsGetInstanceFieldsApp>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_4FA4B9BF39F5B941(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BetaGroupsGetInstanceFieldsBetaGroup>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_395E7BF61D13D20A(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BetaGroupsGetInstanceFieldsBetaRecruitmentCriteriaItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_793EA47B465865F2(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BetaGroupsGetInstanceFieldsBetaTester>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_4AF5905FB396B02B(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BetaGroupsGetInstanceFieldsBuild>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_AF6BCA6B1F363ECE(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BetaGroupsGetInstanceIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_278438A0E3792713(options);
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