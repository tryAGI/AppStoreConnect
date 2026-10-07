#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct IncludedItem61 : global::System.IEquatable<IncludedItem61>
    {
        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.BetaTesterResponseIncludedItemDiscriminatorType? Type { get; }

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
        public global::AppStoreConnect.App PickApps() => Apps is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Apps' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.BetaGroup? BetaGroups { get; init; }
#else
        public global::AppStoreConnect.BetaGroup? BetaGroups { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetaGroups))]
#endif
        public bool IsBetaGroups => BetaGroups != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBetaGroups(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.BetaGroup? value)
        {
            value = BetaGroups;
            return IsBetaGroups;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.BetaGroup PickBetaGroups() => BetaGroups is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BetaGroups' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.Build? Builds { get; init; }
#else
        public global::AppStoreConnect.Build? Builds { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Builds))]
#endif
        public bool IsBuilds => Builds != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBuilds(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.Build? value)
        {
            value = Builds;
            return IsBuilds;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.Build PickBuilds() => Builds is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Builds' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem61(global::AppStoreConnect.App value) => new IncludedItem61((global::AppStoreConnect.App?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.App?(IncludedItem61 @this) => @this.Apps;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem61(global::AppStoreConnect.App? value)
        {
            Apps = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem61 FromApps(global::AppStoreConnect.App? value) => new IncludedItem61(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem61(global::AppStoreConnect.BetaGroup value) => new IncludedItem61((global::AppStoreConnect.BetaGroup?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.BetaGroup?(IncludedItem61 @this) => @this.BetaGroups;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem61(global::AppStoreConnect.BetaGroup? value)
        {
            BetaGroups = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem61 FromBetaGroups(global::AppStoreConnect.BetaGroup? value) => new IncludedItem61(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem61(global::AppStoreConnect.Build value) => new IncludedItem61((global::AppStoreConnect.Build?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.Build?(IncludedItem61 @this) => @this.Builds;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem61(global::AppStoreConnect.Build? value)
        {
            Builds = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem61 FromBuilds(global::AppStoreConnect.Build? value) => new IncludedItem61(value);

        /// <summary>
        ///
        /// </summary>
        public IncludedItem61(
            global::AppStoreConnect.BetaTesterResponseIncludedItemDiscriminatorType? type,
            global::AppStoreConnect.App? apps,
            global::AppStoreConnect.BetaGroup? betaGroups,
            global::AppStoreConnect.Build? builds
            )
        {
            Type = type;

            Apps = apps;
            BetaGroups = betaGroups;
            Builds = builds;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Builds as object ??
            BetaGroups as object ??
            Apps as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Apps?.ToString() ??
            BetaGroups?.ToString() ??
            Builds?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsApps && !IsBetaGroups && !IsBuilds || !IsApps && IsBetaGroups && !IsBuilds || !IsApps && !IsBetaGroups && IsBuilds;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AppStoreConnect.App, TResult>? apps = null,
            global::System.Func<global::AppStoreConnect.BetaGroup, TResult>? betaGroups = null,
            global::System.Func<global::AppStoreConnect.Build, TResult>? builds = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Apps is { } __value0 && apps != null)
            {
                return apps(__value0);
            }
            else if (BetaGroups is { } __value1 && betaGroups != null)
            {
                return betaGroups(__value1);
            }
            else if (Builds is { } __value2 && builds != null)
            {
                return builds(__value2);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::AppStoreConnect.App>? apps = null,

            global::System.Action<global::AppStoreConnect.BetaGroup>? betaGroups = null,

            global::System.Action<global::AppStoreConnect.Build>? builds = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Apps is { } __value0)
            {
                apps?.Invoke(__value0);
            }
            else if (BetaGroups is { } __value1)
            {
                betaGroups?.Invoke(__value1);
            }
            else if (Builds is { } __value2)
            {
                builds?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::AppStoreConnect.App>? apps = null,
            global::System.Action<global::AppStoreConnect.BetaGroup>? betaGroups = null,
            global::System.Action<global::AppStoreConnect.Build>? builds = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Apps is { } __value0)
            {
                apps?.Invoke(__value0);
            }
            else if (BetaGroups is { } __value1)
            {
                betaGroups?.Invoke(__value1);
            }
            else if (Builds is { } __value2)
            {
                builds?.Invoke(__value2);
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
                BetaGroups,
                typeof(global::AppStoreConnect.BetaGroup),
                Builds,
                typeof(global::AppStoreConnect.Build),
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
        public bool Equals(IncludedItem61 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.App?>.Default.Equals(Apps, other.Apps) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.BetaGroup?>.Default.Equals(BetaGroups, other.BetaGroups) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.Build?>.Default.Equals(Builds, other.Builds)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(IncludedItem61 obj1, IncludedItem61 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IncludedItem61>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(IncludedItem61 obj1, IncludedItem61 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IncludedItem61 o && Equals(o);
        }
    }
}
