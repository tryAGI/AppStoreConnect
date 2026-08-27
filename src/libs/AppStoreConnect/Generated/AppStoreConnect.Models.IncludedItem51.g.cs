#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct IncludedItem51 : global::System.IEquatable<IncludedItem51>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::AppStoreConnect.BackgroundAssetResponseIncludedItemDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.App? Apps { get; init; }
#else
        public global::AppStoreConnect.App? Apps { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Apps))]
#endif
        public bool IsApps => Apps != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickApps(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.App? value)
        {
            value = Apps;
            return IsApps;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::AppStoreConnect.App PickApps() => IsApps
            ? Apps!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Apps' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.BackgroundAssetVersion? BackgroundAssetVersions { get; init; }
#else
        public global::AppStoreConnect.BackgroundAssetVersion? BackgroundAssetVersions { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BackgroundAssetVersions))]
#endif
        public bool IsBackgroundAssetVersions => BackgroundAssetVersions != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickBackgroundAssetVersions(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.BackgroundAssetVersion? value)
        {
            value = BackgroundAssetVersions;
            return IsBackgroundAssetVersions;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::AppStoreConnect.BackgroundAssetVersion PickBackgroundAssetVersions() => IsBackgroundAssetVersions
            ? BackgroundAssetVersions!
            : throw new global::System.InvalidOperationException($"Expected union variant 'BackgroundAssetVersions' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IncludedItem51(global::AppStoreConnect.App value) => new IncludedItem51((global::AppStoreConnect.App?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AppStoreConnect.App?(IncludedItem51 @this) => @this.Apps;

        /// <summary>
        /// 
        /// </summary>
        public IncludedItem51(global::AppStoreConnect.App? value)
        {
            Apps = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IncludedItem51 FromApps(global::AppStoreConnect.App? value) => new IncludedItem51(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IncludedItem51(global::AppStoreConnect.BackgroundAssetVersion value) => new IncludedItem51((global::AppStoreConnect.BackgroundAssetVersion?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AppStoreConnect.BackgroundAssetVersion?(IncludedItem51 @this) => @this.BackgroundAssetVersions;

        /// <summary>
        /// 
        /// </summary>
        public IncludedItem51(global::AppStoreConnect.BackgroundAssetVersion? value)
        {
            BackgroundAssetVersions = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IncludedItem51 FromBackgroundAssetVersions(global::AppStoreConnect.BackgroundAssetVersion? value) => new IncludedItem51(value);

        /// <summary>
        /// 
        /// </summary>
        public IncludedItem51(
            global::AppStoreConnect.BackgroundAssetResponseIncludedItemDiscriminatorType? type,
            global::AppStoreConnect.App? apps,
            global::AppStoreConnect.BackgroundAssetVersion? backgroundAssetVersions
            )
        {
            Type = type;

            Apps = apps;
            BackgroundAssetVersions = backgroundAssetVersions;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            BackgroundAssetVersions as object ??
            Apps as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Apps?.ToString() ??
            BackgroundAssetVersions?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsApps && !IsBackgroundAssetVersions || !IsApps && IsBackgroundAssetVersions;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AppStoreConnect.App, TResult>? apps = null,
            global::System.Func<global::AppStoreConnect.BackgroundAssetVersion, TResult>? backgroundAssetVersions = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsApps && apps != null)
            {
                return apps(Apps!);
            }
            else if (IsBackgroundAssetVersions && backgroundAssetVersions != null)
            {
                return backgroundAssetVersions(BackgroundAssetVersions!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::AppStoreConnect.App>? apps = null,

            global::System.Action<global::AppStoreConnect.BackgroundAssetVersion>? backgroundAssetVersions = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsApps)
            {
                apps?.Invoke(Apps!);
            }
            else if (IsBackgroundAssetVersions)
            {
                backgroundAssetVersions?.Invoke(BackgroundAssetVersions!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::AppStoreConnect.App>? apps = null,
            global::System.Action<global::AppStoreConnect.BackgroundAssetVersion>? backgroundAssetVersions = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsApps)
            {
                apps?.Invoke(Apps!);
            }
            else if (IsBackgroundAssetVersions)
            {
                backgroundAssetVersions?.Invoke(BackgroundAssetVersions!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Apps,
                typeof(global::AppStoreConnect.App),
                BackgroundAssetVersions,
                typeof(global::AppStoreConnect.BackgroundAssetVersion),
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
        public bool Equals(IncludedItem51 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.App?>.Default.Equals(Apps, other.Apps) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.BackgroundAssetVersion?>.Default.Equals(BackgroundAssetVersions, other.BackgroundAssetVersions) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(IncludedItem51 obj1, IncludedItem51 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IncludedItem51>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(IncludedItem51 obj1, IncludedItem51 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IncludedItem51 o && Equals(o);
        }
    }
}
