#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct IncludedItem64 : global::System.IEquatable<IncludedItem64>
    {
        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.BundleIdsResponseIncludedItemDiscriminatorType? Type { get; }

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
        public global::AppStoreConnect.BundleIdCapability? BundleIdCapabilities { get; init; }
#else
        public global::AppStoreConnect.BundleIdCapability? BundleIdCapabilities { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BundleIdCapabilities))]
#endif
        public bool IsBundleIdCapabilities => BundleIdCapabilities != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBundleIdCapabilities(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.BundleIdCapability? value)
        {
            value = BundleIdCapabilities;
            return IsBundleIdCapabilities;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.BundleIdCapability PickBundleIdCapabilities() => IsBundleIdCapabilities
            ? BundleIdCapabilities!
            : throw new global::System.InvalidOperationException($"Expected union variant 'BundleIdCapabilities' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.Profile? Profiles { get; init; }
#else
        public global::AppStoreConnect.Profile? Profiles { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Profiles))]
#endif
        public bool IsProfiles => Profiles != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickProfiles(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.Profile? value)
        {
            value = Profiles;
            return IsProfiles;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.Profile PickProfiles() => IsProfiles
            ? Profiles!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Profiles' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem64(global::AppStoreConnect.App value) => new IncludedItem64((global::AppStoreConnect.App?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.App?(IncludedItem64 @this) => @this.Apps;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem64(global::AppStoreConnect.App? value)
        {
            Apps = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem64 FromApps(global::AppStoreConnect.App? value) => new IncludedItem64(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem64(global::AppStoreConnect.BundleIdCapability value) => new IncludedItem64((global::AppStoreConnect.BundleIdCapability?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.BundleIdCapability?(IncludedItem64 @this) => @this.BundleIdCapabilities;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem64(global::AppStoreConnect.BundleIdCapability? value)
        {
            BundleIdCapabilities = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem64 FromBundleIdCapabilities(global::AppStoreConnect.BundleIdCapability? value) => new IncludedItem64(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem64(global::AppStoreConnect.Profile value) => new IncludedItem64((global::AppStoreConnect.Profile?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.Profile?(IncludedItem64 @this) => @this.Profiles;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem64(global::AppStoreConnect.Profile? value)
        {
            Profiles = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem64 FromProfiles(global::AppStoreConnect.Profile? value) => new IncludedItem64(value);

        /// <summary>
        ///
        /// </summary>
        public IncludedItem64(
            global::AppStoreConnect.BundleIdsResponseIncludedItemDiscriminatorType? type,
            global::AppStoreConnect.App? apps,
            global::AppStoreConnect.BundleIdCapability? bundleIdCapabilities,
            global::AppStoreConnect.Profile? profiles
            )
        {
            Type = type;

            Apps = apps;
            BundleIdCapabilities = bundleIdCapabilities;
            Profiles = profiles;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Profiles as object ??
            BundleIdCapabilities as object ??
            Apps as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Apps?.ToString() ??
            BundleIdCapabilities?.ToString() ??
            Profiles?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsApps && !IsBundleIdCapabilities && !IsProfiles || !IsApps && IsBundleIdCapabilities && !IsProfiles || !IsApps && !IsBundleIdCapabilities && IsProfiles;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AppStoreConnect.App, TResult>? apps = null,
            global::System.Func<global::AppStoreConnect.BundleIdCapability, TResult>? bundleIdCapabilities = null,
            global::System.Func<global::AppStoreConnect.Profile, TResult>? profiles = null,
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
            else if (IsBundleIdCapabilities && bundleIdCapabilities != null)
            {
                return bundleIdCapabilities(BundleIdCapabilities!);
            }
            else if (IsProfiles && profiles != null)
            {
                return profiles(Profiles!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::AppStoreConnect.App>? apps = null,

            global::System.Action<global::AppStoreConnect.BundleIdCapability>? bundleIdCapabilities = null,

            global::System.Action<global::AppStoreConnect.Profile>? profiles = null,
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
            else if (IsBundleIdCapabilities)
            {
                bundleIdCapabilities?.Invoke(BundleIdCapabilities!);
            }
            else if (IsProfiles)
            {
                profiles?.Invoke(Profiles!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::AppStoreConnect.App>? apps = null,
            global::System.Action<global::AppStoreConnect.BundleIdCapability>? bundleIdCapabilities = null,
            global::System.Action<global::AppStoreConnect.Profile>? profiles = null,
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
            else if (IsBundleIdCapabilities)
            {
                bundleIdCapabilities?.Invoke(BundleIdCapabilities!);
            }
            else if (IsProfiles)
            {
                profiles?.Invoke(Profiles!);
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
                BundleIdCapabilities,
                typeof(global::AppStoreConnect.BundleIdCapability),
                Profiles,
                typeof(global::AppStoreConnect.Profile),
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
        public bool Equals(IncludedItem64 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.App?>.Default.Equals(Apps, other.Apps) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.BundleIdCapability?>.Default.Equals(BundleIdCapabilities, other.BundleIdCapabilities) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.Profile?>.Default.Equals(Profiles, other.Profiles)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(IncludedItem64 obj1, IncludedItem64 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IncludedItem64>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(IncludedItem64 obj1, IncludedItem64 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IncludedItem64 o && Equals(o);
        }
    }
}
