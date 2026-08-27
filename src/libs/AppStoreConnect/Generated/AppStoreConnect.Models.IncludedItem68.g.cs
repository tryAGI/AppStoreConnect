#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct IncludedItem68 : global::System.IEquatable<IncludedItem68>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::AppStoreConnect.CiProductsResponseIncludedItemDiscriminatorType? Type { get; }

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
        public global::AppStoreConnect.BundleId? BundleIds { get; init; }
#else
        public global::AppStoreConnect.BundleId? BundleIds { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BundleIds))]
#endif
        public bool IsBundleIds => BundleIds != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickBundleIds(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.BundleId? value)
        {
            value = BundleIds;
            return IsBundleIds;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::AppStoreConnect.BundleId PickBundleIds() => IsBundleIds
            ? BundleIds!
            : throw new global::System.InvalidOperationException($"Expected union variant 'BundleIds' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.ScmRepository? ScmRepositories { get; init; }
#else
        public global::AppStoreConnect.ScmRepository? ScmRepositories { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ScmRepositories))]
#endif
        public bool IsScmRepositories => ScmRepositories != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickScmRepositories(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.ScmRepository? value)
        {
            value = ScmRepositories;
            return IsScmRepositories;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::AppStoreConnect.ScmRepository PickScmRepositories() => IsScmRepositories
            ? ScmRepositories!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ScmRepositories' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IncludedItem68(global::AppStoreConnect.App value) => new IncludedItem68((global::AppStoreConnect.App?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AppStoreConnect.App?(IncludedItem68 @this) => @this.Apps;

        /// <summary>
        /// 
        /// </summary>
        public IncludedItem68(global::AppStoreConnect.App? value)
        {
            Apps = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IncludedItem68 FromApps(global::AppStoreConnect.App? value) => new IncludedItem68(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IncludedItem68(global::AppStoreConnect.BundleId value) => new IncludedItem68((global::AppStoreConnect.BundleId?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AppStoreConnect.BundleId?(IncludedItem68 @this) => @this.BundleIds;

        /// <summary>
        /// 
        /// </summary>
        public IncludedItem68(global::AppStoreConnect.BundleId? value)
        {
            BundleIds = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IncludedItem68 FromBundleIds(global::AppStoreConnect.BundleId? value) => new IncludedItem68(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IncludedItem68(global::AppStoreConnect.ScmRepository value) => new IncludedItem68((global::AppStoreConnect.ScmRepository?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AppStoreConnect.ScmRepository?(IncludedItem68 @this) => @this.ScmRepositories;

        /// <summary>
        /// 
        /// </summary>
        public IncludedItem68(global::AppStoreConnect.ScmRepository? value)
        {
            ScmRepositories = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IncludedItem68 FromScmRepositories(global::AppStoreConnect.ScmRepository? value) => new IncludedItem68(value);

        /// <summary>
        /// 
        /// </summary>
        public IncludedItem68(
            global::AppStoreConnect.CiProductsResponseIncludedItemDiscriminatorType? type,
            global::AppStoreConnect.App? apps,
            global::AppStoreConnect.BundleId? bundleIds,
            global::AppStoreConnect.ScmRepository? scmRepositories
            )
        {
            Type = type;

            Apps = apps;
            BundleIds = bundleIds;
            ScmRepositories = scmRepositories;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ScmRepositories as object ??
            BundleIds as object ??
            Apps as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Apps?.ToString() ??
            BundleIds?.ToString() ??
            ScmRepositories?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsApps && !IsBundleIds && !IsScmRepositories || !IsApps && IsBundleIds && !IsScmRepositories || !IsApps && !IsBundleIds && IsScmRepositories;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AppStoreConnect.App, TResult>? apps = null,
            global::System.Func<global::AppStoreConnect.BundleId, TResult>? bundleIds = null,
            global::System.Func<global::AppStoreConnect.ScmRepository, TResult>? scmRepositories = null,
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
            else if (IsBundleIds && bundleIds != null)
            {
                return bundleIds(BundleIds!);
            }
            else if (IsScmRepositories && scmRepositories != null)
            {
                return scmRepositories(ScmRepositories!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::AppStoreConnect.App>? apps = null,

            global::System.Action<global::AppStoreConnect.BundleId>? bundleIds = null,

            global::System.Action<global::AppStoreConnect.ScmRepository>? scmRepositories = null,
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
            else if (IsBundleIds)
            {
                bundleIds?.Invoke(BundleIds!);
            }
            else if (IsScmRepositories)
            {
                scmRepositories?.Invoke(ScmRepositories!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::AppStoreConnect.App>? apps = null,
            global::System.Action<global::AppStoreConnect.BundleId>? bundleIds = null,
            global::System.Action<global::AppStoreConnect.ScmRepository>? scmRepositories = null,
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
            else if (IsBundleIds)
            {
                bundleIds?.Invoke(BundleIds!);
            }
            else if (IsScmRepositories)
            {
                scmRepositories?.Invoke(ScmRepositories!);
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
                BundleIds,
                typeof(global::AppStoreConnect.BundleId),
                ScmRepositories,
                typeof(global::AppStoreConnect.ScmRepository),
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
        public bool Equals(IncludedItem68 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.App?>.Default.Equals(Apps, other.Apps) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.BundleId?>.Default.Equals(BundleIds, other.BundleIds) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.ScmRepository?>.Default.Equals(ScmRepositories, other.ScmRepositories) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(IncludedItem68 obj1, IncludedItem68 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IncludedItem68>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(IncludedItem68 obj1, IncludedItem68 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IncludedItem68 o && Equals(o);
        }
    }
}
