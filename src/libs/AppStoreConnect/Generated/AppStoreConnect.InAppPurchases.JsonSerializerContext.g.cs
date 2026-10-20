
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    public sealed partial class InAppPurchasesSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static InAppPurchasesSourceGenerationContext Default { get; } = new(DefaultOptions);

        private InAppPurchasesSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            global::AppStoreConnect.SourceGenerationContextGraph_19CDE409796DDA30.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_B13FE678A1B36769.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_2BDBABB23AACF5BA.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_A70F8AE8C2F4ED21.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_AD0D8A1E9A77230F.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_C0C2C20A20D0D509.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_528A908CC1BD571A.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_B8E7E96D7DD68A18.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_A0FF505F1A08C98F.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_7CA5B5A810F35388.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_6DA88C34BA124C41.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_47E8C12364FC3FE2.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_0CC1EE61D719E505.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_C032271F61EAD067.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_88DD772DECEA4D79.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_71856C23E3D62312.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_71E144DE79D4E5D3.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_DEFAD23D455822C8.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_5E9BAC2A35F5B36C.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_E731B99947BBC386.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_E62797E992A30BAF.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_7A06219195B3C10A.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_01286B345C7FB528.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_55CE0A434935AC71.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_B3297A0DA766BE5E.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_8509B0F74385F8AB.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_0D119D7DF93ADF76.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_38B0B4629CA0A4FA.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_676A24D7AABC8222.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_9DD63700B8AA41B7.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_FDAF92E748FACD39.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_58D17A9FEFDBA59F.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_C29D28747F0378DC.AddConverters(options);
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
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[33];

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
                    0 => global::AppStoreConnect.SourceGenerationContextGraph_19CDE409796DDA30.TypeInfoResolver,

                    1 => global::AppStoreConnect.SourceGenerationContextGraph_B13FE678A1B36769.TypeInfoResolver,

                    2 => global::AppStoreConnect.SourceGenerationContextGraph_2BDBABB23AACF5BA.TypeInfoResolver,

                    3 => global::AppStoreConnect.SourceGenerationContextGraph_A70F8AE8C2F4ED21.TypeInfoResolver,

                    4 => global::AppStoreConnect.SourceGenerationContextGraph_AD0D8A1E9A77230F.TypeInfoResolver,

                    5 => global::AppStoreConnect.SourceGenerationContextGraph_C0C2C20A20D0D509.TypeInfoResolver,

                    6 => global::AppStoreConnect.SourceGenerationContextGraph_528A908CC1BD571A.TypeInfoResolver,

                    7 => global::AppStoreConnect.SourceGenerationContextGraph_B8E7E96D7DD68A18.TypeInfoResolver,

                    8 => global::AppStoreConnect.SourceGenerationContextGraph_A0FF505F1A08C98F.TypeInfoResolver,

                    9 => global::AppStoreConnect.SourceGenerationContextGraph_7CA5B5A810F35388.TypeInfoResolver,

                    10 => global::AppStoreConnect.SourceGenerationContextGraph_6DA88C34BA124C41.TypeInfoResolver,

                    11 => global::AppStoreConnect.SourceGenerationContextGraph_47E8C12364FC3FE2.TypeInfoResolver,

                    12 => global::AppStoreConnect.SourceGenerationContextGraph_0CC1EE61D719E505.TypeInfoResolver,

                    13 => global::AppStoreConnect.SourceGenerationContextGraph_C032271F61EAD067.TypeInfoResolver,

                    14 => global::AppStoreConnect.SourceGenerationContextGraph_88DD772DECEA4D79.TypeInfoResolver,

                    15 => global::AppStoreConnect.SourceGenerationContextGraph_71856C23E3D62312.TypeInfoResolver,

                    16 => global::AppStoreConnect.SourceGenerationContextGraph_71E144DE79D4E5D3.TypeInfoResolver,

                    17 => global::AppStoreConnect.SourceGenerationContextGraph_DEFAD23D455822C8.TypeInfoResolver,

                    18 => global::AppStoreConnect.SourceGenerationContextGraph_5E9BAC2A35F5B36C.TypeInfoResolver,

                    19 => global::AppStoreConnect.SourceGenerationContextGraph_E731B99947BBC386.TypeInfoResolver,

                    20 => global::AppStoreConnect.SourceGenerationContextGraph_E62797E992A30BAF.TypeInfoResolver,

                    21 => global::AppStoreConnect.SourceGenerationContextGraph_7A06219195B3C10A.TypeInfoResolver,

                    22 => global::AppStoreConnect.SourceGenerationContextGraph_01286B345C7FB528.TypeInfoResolver,

                    23 => global::AppStoreConnect.SourceGenerationContextGraph_55CE0A434935AC71.TypeInfoResolver,

                    24 => global::AppStoreConnect.SourceGenerationContextGraph_B3297A0DA766BE5E.TypeInfoResolver,

                    25 => global::AppStoreConnect.SourceGenerationContextGraph_8509B0F74385F8AB.TypeInfoResolver,

                    26 => global::AppStoreConnect.SourceGenerationContextGraph_0D119D7DF93ADF76.TypeInfoResolver,

                    27 => global::AppStoreConnect.SourceGenerationContextGraph_38B0B4629CA0A4FA.TypeInfoResolver,

                    28 => global::AppStoreConnect.SourceGenerationContextGraph_676A24D7AABC8222.TypeInfoResolver,

                    29 => global::AppStoreConnect.SourceGenerationContextGraph_9DD63700B8AA41B7.TypeInfoResolver,

                    30 => global::AppStoreConnect.SourceGenerationContextGraph_FDAF92E748FACD39.TypeInfoResolver,

                    31 => global::AppStoreConnect.SourceGenerationContextGraph_58D17A9FEFDBA59F.TypeInfoResolver,

                    32 => global::AppStoreConnect.SourceGenerationContextGraph_C29D28747F0378DC.TypeInfoResolver,
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}