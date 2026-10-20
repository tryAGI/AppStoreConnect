
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    public sealed partial class AppCustomProductPageLocalizationsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static AppCustomProductPageLocalizationsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private AppCustomProductPageLocalizationsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            global::AppStoreConnect.SourceGenerationContextGraph_65B06398B7E5752E.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_B13FE678A1B36769.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_7CC0240075810A45.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_01286B345C7FB528.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_6DA88C34BA124C41.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_FAEC4C4491592583.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_149B8B9DD7106003.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_4B2FFD5759F32521.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_7161D028E5CCEDF0.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_668ED494DF5F9C7A.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_9A857A24E3620324.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_5DED7942F6088CFA.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_0F6CFA5FEBC36902.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_B9C93946467C29B3.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_4DBDCDD3CFAA6B71.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_ABB29DD2AE045F3D.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_6426A0703B85F664.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_E7A9D8EE64D3EE71.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_1A72EDBA06A7A022.AddConverters(options);
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

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[19];

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
                    0 => global::AppStoreConnect.SourceGenerationContextGraph_65B06398B7E5752E.TypeInfoResolver,

                    1 => global::AppStoreConnect.SourceGenerationContextGraph_B13FE678A1B36769.TypeInfoResolver,

                    2 => global::AppStoreConnect.SourceGenerationContextGraph_7CC0240075810A45.TypeInfoResolver,

                    3 => global::AppStoreConnect.SourceGenerationContextGraph_01286B345C7FB528.TypeInfoResolver,

                    4 => global::AppStoreConnect.SourceGenerationContextGraph_6DA88C34BA124C41.TypeInfoResolver,

                    5 => global::AppStoreConnect.SourceGenerationContextGraph_FAEC4C4491592583.TypeInfoResolver,

                    6 => global::AppStoreConnect.SourceGenerationContextGraph_149B8B9DD7106003.TypeInfoResolver,

                    7 => global::AppStoreConnect.SourceGenerationContextGraph_4B2FFD5759F32521.TypeInfoResolver,

                    8 => global::AppStoreConnect.SourceGenerationContextGraph_7161D028E5CCEDF0.TypeInfoResolver,

                    9 => global::AppStoreConnect.SourceGenerationContextGraph_668ED494DF5F9C7A.TypeInfoResolver,

                    10 => global::AppStoreConnect.SourceGenerationContextGraph_9A857A24E3620324.TypeInfoResolver,

                    11 => global::AppStoreConnect.SourceGenerationContextGraph_5DED7942F6088CFA.TypeInfoResolver,

                    12 => global::AppStoreConnect.SourceGenerationContextGraph_0F6CFA5FEBC36902.TypeInfoResolver,

                    13 => global::AppStoreConnect.SourceGenerationContextGraph_B9C93946467C29B3.TypeInfoResolver,

                    14 => global::AppStoreConnect.SourceGenerationContextGraph_4DBDCDD3CFAA6B71.TypeInfoResolver,

                    15 => global::AppStoreConnect.SourceGenerationContextGraph_ABB29DD2AE045F3D.TypeInfoResolver,

                    16 => global::AppStoreConnect.SourceGenerationContextGraph_6426A0703B85F664.TypeInfoResolver,

                    17 => global::AppStoreConnect.SourceGenerationContextGraph_E7A9D8EE64D3EE71.TypeInfoResolver,

                    18 => global::AppStoreConnect.SourceGenerationContextGraph_1A72EDBA06A7A022.TypeInfoResolver,
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}