#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct AppAssetLibraryPlacementVideoRelationships : global::System.IEquatable<AppAssetLibraryPlacementVideoRelationships>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.AppAssetLibraryPlacementCommonRelationships? AppAssetLibraryPlacementCommonRelationships { get; init; }
#else
        public global::AppStoreConnect.AppAssetLibraryPlacementCommonRelationships? AppAssetLibraryPlacementCommonRelationships { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AppAssetLibraryPlacementCommonRelationships))]
#endif
        public bool IsAppAssetLibraryPlacementCommonRelationships => AppAssetLibraryPlacementCommonRelationships != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAppAssetLibraryPlacementCommonRelationships(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.AppAssetLibraryPlacementCommonRelationships? value)
        {
            value = AppAssetLibraryPlacementCommonRelationships;
            return IsAppAssetLibraryPlacementCommonRelationships;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppAssetLibraryPlacementCommonRelationships PickAppAssetLibraryPlacementCommonRelationships() => AppAssetLibraryPlacementCommonRelationships is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AppAssetLibraryPlacementCommonRelationships' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.AppAssetLibraryPlacementVideoRelationshipsVariant2? AppAssetLibraryPlacementVideoRelationshipsVariant2 { get; init; }
#else
        public global::AppStoreConnect.AppAssetLibraryPlacementVideoRelationshipsVariant2? AppAssetLibraryPlacementVideoRelationshipsVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AppAssetLibraryPlacementVideoRelationshipsVariant2))]
#endif
        public bool IsAppAssetLibraryPlacementVideoRelationshipsVariant2 => AppAssetLibraryPlacementVideoRelationshipsVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAppAssetLibraryPlacementVideoRelationshipsVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.AppAssetLibraryPlacementVideoRelationshipsVariant2? value)
        {
            value = AppAssetLibraryPlacementVideoRelationshipsVariant2;
            return IsAppAssetLibraryPlacementVideoRelationshipsVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppAssetLibraryPlacementVideoRelationshipsVariant2 PickAppAssetLibraryPlacementVideoRelationshipsVariant2() => AppAssetLibraryPlacementVideoRelationshipsVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AppAssetLibraryPlacementVideoRelationshipsVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator AppAssetLibraryPlacementVideoRelationships(global::AppStoreConnect.AppAssetLibraryPlacementCommonRelationships value) => new AppAssetLibraryPlacementVideoRelationships((global::AppStoreConnect.AppAssetLibraryPlacementCommonRelationships?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppAssetLibraryPlacementCommonRelationships?(AppAssetLibraryPlacementVideoRelationships @this) => @this.AppAssetLibraryPlacementCommonRelationships;

        /// <summary>
        ///
        /// </summary>
        public AppAssetLibraryPlacementVideoRelationships(global::AppStoreConnect.AppAssetLibraryPlacementCommonRelationships? value)
        {
            AppAssetLibraryPlacementCommonRelationships = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AppAssetLibraryPlacementVideoRelationships FromAppAssetLibraryPlacementCommonRelationships(global::AppStoreConnect.AppAssetLibraryPlacementCommonRelationships? value) => new AppAssetLibraryPlacementVideoRelationships(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AppAssetLibraryPlacementVideoRelationships(global::AppStoreConnect.AppAssetLibraryPlacementVideoRelationshipsVariant2 value) => new AppAssetLibraryPlacementVideoRelationships((global::AppStoreConnect.AppAssetLibraryPlacementVideoRelationshipsVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppAssetLibraryPlacementVideoRelationshipsVariant2?(AppAssetLibraryPlacementVideoRelationships @this) => @this.AppAssetLibraryPlacementVideoRelationshipsVariant2;

        /// <summary>
        ///
        /// </summary>
        public AppAssetLibraryPlacementVideoRelationships(global::AppStoreConnect.AppAssetLibraryPlacementVideoRelationshipsVariant2? value)
        {
            AppAssetLibraryPlacementVideoRelationshipsVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AppAssetLibraryPlacementVideoRelationships FromAppAssetLibraryPlacementVideoRelationshipsVariant2(global::AppStoreConnect.AppAssetLibraryPlacementVideoRelationshipsVariant2? value) => new AppAssetLibraryPlacementVideoRelationships(value);

        /// <summary>
        ///
        /// </summary>
        public AppAssetLibraryPlacementVideoRelationships(
            global::AppStoreConnect.AppAssetLibraryPlacementCommonRelationships? appAssetLibraryPlacementCommonRelationships,
            global::AppStoreConnect.AppAssetLibraryPlacementVideoRelationshipsVariant2? appAssetLibraryPlacementVideoRelationshipsVariant2
            )
        {
            AppAssetLibraryPlacementCommonRelationships = appAssetLibraryPlacementCommonRelationships;
            AppAssetLibraryPlacementVideoRelationshipsVariant2 = appAssetLibraryPlacementVideoRelationshipsVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            AppAssetLibraryPlacementVideoRelationshipsVariant2 as object ??
            AppAssetLibraryPlacementCommonRelationships as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            AppAssetLibraryPlacementCommonRelationships?.ToString() ??
            AppAssetLibraryPlacementVideoRelationshipsVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsAppAssetLibraryPlacementCommonRelationships && IsAppAssetLibraryPlacementVideoRelationshipsVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AppStoreConnect.AppAssetLibraryPlacementCommonRelationships, TResult>? appAssetLibraryPlacementCommonRelationships = null,
            global::System.Func<global::AppStoreConnect.AppAssetLibraryPlacementVideoRelationshipsVariant2, TResult>? appAssetLibraryPlacementVideoRelationshipsVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (AppAssetLibraryPlacementCommonRelationships is { } __value0 && appAssetLibraryPlacementCommonRelationships != null)
            {
                return appAssetLibraryPlacementCommonRelationships(__value0);
            }
            else if (AppAssetLibraryPlacementVideoRelationshipsVariant2 is { } __value1 && appAssetLibraryPlacementVideoRelationshipsVariant2 != null)
            {
                return appAssetLibraryPlacementVideoRelationshipsVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::AppStoreConnect.AppAssetLibraryPlacementCommonRelationships>? appAssetLibraryPlacementCommonRelationships = null,

            global::System.Action<global::AppStoreConnect.AppAssetLibraryPlacementVideoRelationshipsVariant2>? appAssetLibraryPlacementVideoRelationshipsVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (AppAssetLibraryPlacementCommonRelationships is { } __value0)
            {
                appAssetLibraryPlacementCommonRelationships?.Invoke(__value0);
            }
            else if (AppAssetLibraryPlacementVideoRelationshipsVariant2 is { } __value1)
            {
                appAssetLibraryPlacementVideoRelationshipsVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::AppStoreConnect.AppAssetLibraryPlacementCommonRelationships>? appAssetLibraryPlacementCommonRelationships = null,
            global::System.Action<global::AppStoreConnect.AppAssetLibraryPlacementVideoRelationshipsVariant2>? appAssetLibraryPlacementVideoRelationshipsVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (AppAssetLibraryPlacementCommonRelationships is { } __value0)
            {
                appAssetLibraryPlacementCommonRelationships?.Invoke(__value0);
            }
            else if (AppAssetLibraryPlacementVideoRelationshipsVariant2 is { } __value1)
            {
                appAssetLibraryPlacementVideoRelationshipsVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AppAssetLibraryPlacementCommonRelationships,
                typeof(global::AppStoreConnect.AppAssetLibraryPlacementCommonRelationships),
                AppAssetLibraryPlacementVideoRelationshipsVariant2,
                typeof(global::AppStoreConnect.AppAssetLibraryPlacementVideoRelationshipsVariant2),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        ///
        /// </summary>
        public bool Equals(AppAssetLibraryPlacementVideoRelationships other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppAssetLibraryPlacementCommonRelationships?>.Default.Equals(AppAssetLibraryPlacementCommonRelationships, other.AppAssetLibraryPlacementCommonRelationships) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppAssetLibraryPlacementVideoRelationshipsVariant2?>.Default.Equals(AppAssetLibraryPlacementVideoRelationshipsVariant2, other.AppAssetLibraryPlacementVideoRelationshipsVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(AppAssetLibraryPlacementVideoRelationships obj1, AppAssetLibraryPlacementVideoRelationships obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AppAssetLibraryPlacementVideoRelationships>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AppAssetLibraryPlacementVideoRelationships obj1, AppAssetLibraryPlacementVideoRelationships obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AppAssetLibraryPlacementVideoRelationships o && Equals(o);
        }
    }
}
