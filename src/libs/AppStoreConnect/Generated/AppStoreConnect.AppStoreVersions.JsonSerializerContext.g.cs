
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    public sealed partial class AppStoreVersionsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static AppStoreVersionsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private AppStoreVersionsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            global::AppStoreConnect.SourceGenerationContextGraph_2A9D74050693EB62.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_B13FE678A1B36769.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_2E53144731EB6B12.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_6DA88C34BA124C41.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_D26DC7D89BAE77D0.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_40515A364958BC43.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_2412A3E1E4745595.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_31FB145D68E3D0A4.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_6CEBBE51C6D21B94.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_1D0A020A2317A8C0.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_13FDD14FBB672DFE.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_0414826CA80EEFDA.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_FB96EBF00B17F948.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_D8E257A1B3BD73A1.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_FC0C982B5E4B29F2.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_AD875AED21D614F2.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_01286B345C7FB528.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_4286FA43564F6D91.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_AA425D9F463F5146.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_23E92495F1EE81C5.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_598CB6C310D7CA64.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_C24437C2042181D1.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_04EB87B7C6C9B864.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_F1EA3988CEF04D62.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_BD05F8FCAFB8EC32.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_7509F4DA38B11A2F.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_7387803977FD8B85.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_80CEEED5D1F3CED9.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_B760F44FA5965C24.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_25E13F633A01DD58.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_4DF10DAD49B436AA.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_9746687752041806.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_F407A52F647A7AC9.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_F7CAE5CD2E153389.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_536A9272AC2F1D1B.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_ED68577F73BE1E64.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_BB5C2A050B9840DF.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_9BF831112A8CC983.AddConverters(options);
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
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[38];

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
                    0 => global::AppStoreConnect.SourceGenerationContextGraph_2A9D74050693EB62.TypeInfoResolver,

                    1 => global::AppStoreConnect.SourceGenerationContextGraph_B13FE678A1B36769.TypeInfoResolver,

                    2 => global::AppStoreConnect.SourceGenerationContextGraph_2E53144731EB6B12.TypeInfoResolver,

                    3 => global::AppStoreConnect.SourceGenerationContextGraph_6DA88C34BA124C41.TypeInfoResolver,

                    4 => global::AppStoreConnect.SourceGenerationContextGraph_D26DC7D89BAE77D0.TypeInfoResolver,

                    5 => global::AppStoreConnect.SourceGenerationContextGraph_40515A364958BC43.TypeInfoResolver,

                    6 => global::AppStoreConnect.SourceGenerationContextGraph_2412A3E1E4745595.TypeInfoResolver,

                    7 => global::AppStoreConnect.SourceGenerationContextGraph_31FB145D68E3D0A4.TypeInfoResolver,

                    8 => global::AppStoreConnect.SourceGenerationContextGraph_6CEBBE51C6D21B94.TypeInfoResolver,

                    9 => global::AppStoreConnect.SourceGenerationContextGraph_1D0A020A2317A8C0.TypeInfoResolver,

                    10 => global::AppStoreConnect.SourceGenerationContextGraph_13FDD14FBB672DFE.TypeInfoResolver,

                    11 => global::AppStoreConnect.SourceGenerationContextGraph_0414826CA80EEFDA.TypeInfoResolver,

                    12 => global::AppStoreConnect.SourceGenerationContextGraph_FB96EBF00B17F948.TypeInfoResolver,

                    13 => global::AppStoreConnect.SourceGenerationContextGraph_D8E257A1B3BD73A1.TypeInfoResolver,

                    14 => global::AppStoreConnect.SourceGenerationContextGraph_FC0C982B5E4B29F2.TypeInfoResolver,

                    15 => global::AppStoreConnect.SourceGenerationContextGraph_AD875AED21D614F2.TypeInfoResolver,

                    16 => global::AppStoreConnect.SourceGenerationContextGraph_01286B345C7FB528.TypeInfoResolver,

                    17 => global::AppStoreConnect.SourceGenerationContextGraph_4286FA43564F6D91.TypeInfoResolver,

                    18 => global::AppStoreConnect.SourceGenerationContextGraph_AA425D9F463F5146.TypeInfoResolver,

                    19 => global::AppStoreConnect.SourceGenerationContextGraph_23E92495F1EE81C5.TypeInfoResolver,

                    20 => global::AppStoreConnect.SourceGenerationContextGraph_598CB6C310D7CA64.TypeInfoResolver,

                    21 => global::AppStoreConnect.SourceGenerationContextGraph_C24437C2042181D1.TypeInfoResolver,

                    22 => global::AppStoreConnect.SourceGenerationContextGraph_04EB87B7C6C9B864.TypeInfoResolver,

                    23 => global::AppStoreConnect.SourceGenerationContextGraph_F1EA3988CEF04D62.TypeInfoResolver,

                    24 => global::AppStoreConnect.SourceGenerationContextGraph_BD05F8FCAFB8EC32.TypeInfoResolver,

                    25 => global::AppStoreConnect.SourceGenerationContextGraph_7509F4DA38B11A2F.TypeInfoResolver,

                    26 => global::AppStoreConnect.SourceGenerationContextGraph_7387803977FD8B85.TypeInfoResolver,

                    27 => global::AppStoreConnect.SourceGenerationContextGraph_80CEEED5D1F3CED9.TypeInfoResolver,

                    28 => global::AppStoreConnect.SourceGenerationContextGraph_B760F44FA5965C24.TypeInfoResolver,

                    29 => global::AppStoreConnect.SourceGenerationContextGraph_25E13F633A01DD58.TypeInfoResolver,

                    30 => global::AppStoreConnect.SourceGenerationContextGraph_4DF10DAD49B436AA.TypeInfoResolver,

                    31 => global::AppStoreConnect.SourceGenerationContextGraph_9746687752041806.TypeInfoResolver,

                    32 => global::AppStoreConnect.SourceGenerationContextGraph_F407A52F647A7AC9.TypeInfoResolver,

                    33 => global::AppStoreConnect.SourceGenerationContextGraph_F7CAE5CD2E153389.TypeInfoResolver,

                    34 => global::AppStoreConnect.SourceGenerationContextGraph_536A9272AC2F1D1B.TypeInfoResolver,

                    35 => global::AppStoreConnect.SourceGenerationContextGraph_ED68577F73BE1E64.TypeInfoResolver,

                    36 => global::AppStoreConnect.SourceGenerationContextGraph_BB5C2A050B9840DF.TypeInfoResolver,

                    37 => global::AppStoreConnect.SourceGenerationContextGraph_9BF831112A8CC983.TypeInfoResolver,
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}