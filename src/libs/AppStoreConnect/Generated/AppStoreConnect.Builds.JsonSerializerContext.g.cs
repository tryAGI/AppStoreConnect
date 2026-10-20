
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    public sealed partial class BuildsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static BuildsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private BuildsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            global::AppStoreConnect.SourceGenerationContextGraph_94F22D2EAF412A82.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_B13FE678A1B36769.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_9A1CCE353F9146E1.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_AC55EC14E22502C2.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_9D3FCE071F43FA88.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_F7F10C18A83AD5BB.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_56F6A6D8A8AA7506.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_7509F4DA38B11A2F.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_853F162AF3BFB520.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_6DA88C34BA124C41.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_DA929B88020F2EF4.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_7913A11A59FD1494.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_839A51D371CE20F5.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_DA2B0EDF462266E3.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_874BD86A292EE7F7.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_AF0614E3BED81360.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_3DA48A2E4EB515D0.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_E20BF6275A6D1649.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_89EDB154064B76AD.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_84462DA4645186C4.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_D13F28C17A3BFC51.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_F1E20157BB5494FE.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_56A15C67494BF6CB.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_01286B345C7FB528.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_DE4FB3258158D80E.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_B760F44FA5965C24.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_3EF5EE3DE64AECE0.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_401882331DF9AC9A.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_D6B8F1D5938CBF0D.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_1FCFC393C2D8B2A7.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_3E259E63AC3F496E.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_B79530C605D25640.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_BDB625273C6FC707.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_E1D3DCF394B5896D.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_3956BB14FED1536C.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_5632684FD86D3D1E.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_79CEDB0C4C89F82C.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_40F16CD2FA66F6B8.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_619F85AFE70B1C74.AddConverters(options);
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
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[39];

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
                    0 => global::AppStoreConnect.SourceGenerationContextGraph_94F22D2EAF412A82.TypeInfoResolver,

                    1 => global::AppStoreConnect.SourceGenerationContextGraph_B13FE678A1B36769.TypeInfoResolver,

                    2 => global::AppStoreConnect.SourceGenerationContextGraph_9A1CCE353F9146E1.TypeInfoResolver,

                    3 => global::AppStoreConnect.SourceGenerationContextGraph_AC55EC14E22502C2.TypeInfoResolver,

                    4 => global::AppStoreConnect.SourceGenerationContextGraph_9D3FCE071F43FA88.TypeInfoResolver,

                    5 => global::AppStoreConnect.SourceGenerationContextGraph_F7F10C18A83AD5BB.TypeInfoResolver,

                    6 => global::AppStoreConnect.SourceGenerationContextGraph_56F6A6D8A8AA7506.TypeInfoResolver,

                    7 => global::AppStoreConnect.SourceGenerationContextGraph_7509F4DA38B11A2F.TypeInfoResolver,

                    8 => global::AppStoreConnect.SourceGenerationContextGraph_853F162AF3BFB520.TypeInfoResolver,

                    9 => global::AppStoreConnect.SourceGenerationContextGraph_6DA88C34BA124C41.TypeInfoResolver,

                    10 => global::AppStoreConnect.SourceGenerationContextGraph_DA929B88020F2EF4.TypeInfoResolver,

                    11 => global::AppStoreConnect.SourceGenerationContextGraph_7913A11A59FD1494.TypeInfoResolver,

                    12 => global::AppStoreConnect.SourceGenerationContextGraph_839A51D371CE20F5.TypeInfoResolver,

                    13 => global::AppStoreConnect.SourceGenerationContextGraph_DA2B0EDF462266E3.TypeInfoResolver,

                    14 => global::AppStoreConnect.SourceGenerationContextGraph_874BD86A292EE7F7.TypeInfoResolver,

                    15 => global::AppStoreConnect.SourceGenerationContextGraph_AF0614E3BED81360.TypeInfoResolver,

                    16 => global::AppStoreConnect.SourceGenerationContextGraph_3DA48A2E4EB515D0.TypeInfoResolver,

                    17 => global::AppStoreConnect.SourceGenerationContextGraph_E20BF6275A6D1649.TypeInfoResolver,

                    18 => global::AppStoreConnect.SourceGenerationContextGraph_89EDB154064B76AD.TypeInfoResolver,

                    19 => global::AppStoreConnect.SourceGenerationContextGraph_84462DA4645186C4.TypeInfoResolver,

                    20 => global::AppStoreConnect.SourceGenerationContextGraph_D13F28C17A3BFC51.TypeInfoResolver,

                    21 => global::AppStoreConnect.SourceGenerationContextGraph_F1E20157BB5494FE.TypeInfoResolver,

                    22 => global::AppStoreConnect.SourceGenerationContextGraph_56A15C67494BF6CB.TypeInfoResolver,

                    23 => global::AppStoreConnect.SourceGenerationContextGraph_01286B345C7FB528.TypeInfoResolver,

                    24 => global::AppStoreConnect.SourceGenerationContextGraph_DE4FB3258158D80E.TypeInfoResolver,

                    25 => global::AppStoreConnect.SourceGenerationContextGraph_B760F44FA5965C24.TypeInfoResolver,

                    26 => global::AppStoreConnect.SourceGenerationContextGraph_3EF5EE3DE64AECE0.TypeInfoResolver,

                    27 => global::AppStoreConnect.SourceGenerationContextGraph_401882331DF9AC9A.TypeInfoResolver,

                    28 => global::AppStoreConnect.SourceGenerationContextGraph_D6B8F1D5938CBF0D.TypeInfoResolver,

                    29 => global::AppStoreConnect.SourceGenerationContextGraph_1FCFC393C2D8B2A7.TypeInfoResolver,

                    30 => global::AppStoreConnect.SourceGenerationContextGraph_3E259E63AC3F496E.TypeInfoResolver,

                    31 => global::AppStoreConnect.SourceGenerationContextGraph_B79530C605D25640.TypeInfoResolver,

                    32 => global::AppStoreConnect.SourceGenerationContextGraph_BDB625273C6FC707.TypeInfoResolver,

                    33 => global::AppStoreConnect.SourceGenerationContextGraph_E1D3DCF394B5896D.TypeInfoResolver,

                    34 => global::AppStoreConnect.SourceGenerationContextGraph_3956BB14FED1536C.TypeInfoResolver,

                    35 => global::AppStoreConnect.SourceGenerationContextGraph_5632684FD86D3D1E.TypeInfoResolver,

                    36 => global::AppStoreConnect.SourceGenerationContextGraph_79CEDB0C4C89F82C.TypeInfoResolver,

                    37 => global::AppStoreConnect.SourceGenerationContextGraph_40F16CD2FA66F6B8.TypeInfoResolver,

                    38 => global::AppStoreConnect.SourceGenerationContextGraph_619F85AFE70B1C74.TypeInfoResolver,
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}