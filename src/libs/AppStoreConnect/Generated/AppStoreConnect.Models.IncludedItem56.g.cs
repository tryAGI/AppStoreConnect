#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct IncludedItem56 : global::System.IEquatable<IncludedItem56>
    {
        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.BetaGroupsResponseIncludedItemDiscriminatorType? Type { get; }

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
        public global::AppStoreConnect.BetaRecruitmentCriterion? BetaRecruitmentCriteria { get; init; }
#else
        public global::AppStoreConnect.BetaRecruitmentCriterion? BetaRecruitmentCriteria { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetaRecruitmentCriteria))]
#endif
        public bool IsBetaRecruitmentCriteria => BetaRecruitmentCriteria != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBetaRecruitmentCriteria(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.BetaRecruitmentCriterion? value)
        {
            value = BetaRecruitmentCriteria;
            return IsBetaRecruitmentCriteria;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.BetaRecruitmentCriterion PickBetaRecruitmentCriteria() => IsBetaRecruitmentCriteria
            ? BetaRecruitmentCriteria!
            : throw new global::System.InvalidOperationException($"Expected union variant 'BetaRecruitmentCriteria' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.BetaTester? BetaTesters { get; init; }
#else
        public global::AppStoreConnect.BetaTester? BetaTesters { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetaTesters))]
#endif
        public bool IsBetaTesters => BetaTesters != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBetaTesters(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.BetaTester? value)
        {
            value = BetaTesters;
            return IsBetaTesters;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.BetaTester PickBetaTesters() => IsBetaTesters
            ? BetaTesters!
            : throw new global::System.InvalidOperationException($"Expected union variant 'BetaTesters' but the value was {ToString()}.");

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
        public global::AppStoreConnect.Build PickBuilds() => IsBuilds
            ? Builds!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Builds' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem56(global::AppStoreConnect.App value) => new IncludedItem56((global::AppStoreConnect.App?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.App?(IncludedItem56 @this) => @this.Apps;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem56(global::AppStoreConnect.App? value)
        {
            Apps = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem56 FromApps(global::AppStoreConnect.App? value) => new IncludedItem56(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem56(global::AppStoreConnect.BetaRecruitmentCriterion value) => new IncludedItem56((global::AppStoreConnect.BetaRecruitmentCriterion?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.BetaRecruitmentCriterion?(IncludedItem56 @this) => @this.BetaRecruitmentCriteria;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem56(global::AppStoreConnect.BetaRecruitmentCriterion? value)
        {
            BetaRecruitmentCriteria = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem56 FromBetaRecruitmentCriteria(global::AppStoreConnect.BetaRecruitmentCriterion? value) => new IncludedItem56(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem56(global::AppStoreConnect.BetaTester value) => new IncludedItem56((global::AppStoreConnect.BetaTester?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.BetaTester?(IncludedItem56 @this) => @this.BetaTesters;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem56(global::AppStoreConnect.BetaTester? value)
        {
            BetaTesters = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem56 FromBetaTesters(global::AppStoreConnect.BetaTester? value) => new IncludedItem56(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem56(global::AppStoreConnect.Build value) => new IncludedItem56((global::AppStoreConnect.Build?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.Build?(IncludedItem56 @this) => @this.Builds;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem56(global::AppStoreConnect.Build? value)
        {
            Builds = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem56 FromBuilds(global::AppStoreConnect.Build? value) => new IncludedItem56(value);

        /// <summary>
        ///
        /// </summary>
        public IncludedItem56(
            global::AppStoreConnect.BetaGroupsResponseIncludedItemDiscriminatorType? type,
            global::AppStoreConnect.App? apps,
            global::AppStoreConnect.BetaRecruitmentCriterion? betaRecruitmentCriteria,
            global::AppStoreConnect.BetaTester? betaTesters,
            global::AppStoreConnect.Build? builds
            )
        {
            Type = type;

            Apps = apps;
            BetaRecruitmentCriteria = betaRecruitmentCriteria;
            BetaTesters = betaTesters;
            Builds = builds;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Builds as object ??
            BetaTesters as object ??
            BetaRecruitmentCriteria as object ??
            Apps as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Apps?.ToString() ??
            BetaRecruitmentCriteria?.ToString() ??
            BetaTesters?.ToString() ??
            Builds?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsApps && !IsBetaRecruitmentCriteria && !IsBetaTesters && !IsBuilds || !IsApps && IsBetaRecruitmentCriteria && !IsBetaTesters && !IsBuilds || !IsApps && !IsBetaRecruitmentCriteria && IsBetaTesters && !IsBuilds || !IsApps && !IsBetaRecruitmentCriteria && !IsBetaTesters && IsBuilds;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AppStoreConnect.App, TResult>? apps = null,
            global::System.Func<global::AppStoreConnect.BetaRecruitmentCriterion, TResult>? betaRecruitmentCriteria = null,
            global::System.Func<global::AppStoreConnect.BetaTester, TResult>? betaTesters = null,
            global::System.Func<global::AppStoreConnect.Build, TResult>? builds = null,
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
            else if (IsBetaRecruitmentCriteria && betaRecruitmentCriteria != null)
            {
                return betaRecruitmentCriteria(BetaRecruitmentCriteria!);
            }
            else if (IsBetaTesters && betaTesters != null)
            {
                return betaTesters(BetaTesters!);
            }
            else if (IsBuilds && builds != null)
            {
                return builds(Builds!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::AppStoreConnect.App>? apps = null,

            global::System.Action<global::AppStoreConnect.BetaRecruitmentCriterion>? betaRecruitmentCriteria = null,

            global::System.Action<global::AppStoreConnect.BetaTester>? betaTesters = null,

            global::System.Action<global::AppStoreConnect.Build>? builds = null,
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
            else if (IsBetaRecruitmentCriteria)
            {
                betaRecruitmentCriteria?.Invoke(BetaRecruitmentCriteria!);
            }
            else if (IsBetaTesters)
            {
                betaTesters?.Invoke(BetaTesters!);
            }
            else if (IsBuilds)
            {
                builds?.Invoke(Builds!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::AppStoreConnect.App>? apps = null,
            global::System.Action<global::AppStoreConnect.BetaRecruitmentCriterion>? betaRecruitmentCriteria = null,
            global::System.Action<global::AppStoreConnect.BetaTester>? betaTesters = null,
            global::System.Action<global::AppStoreConnect.Build>? builds = null,
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
            else if (IsBetaRecruitmentCriteria)
            {
                betaRecruitmentCriteria?.Invoke(BetaRecruitmentCriteria!);
            }
            else if (IsBetaTesters)
            {
                betaTesters?.Invoke(BetaTesters!);
            }
            else if (IsBuilds)
            {
                builds?.Invoke(Builds!);
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
                BetaRecruitmentCriteria,
                typeof(global::AppStoreConnect.BetaRecruitmentCriterion),
                BetaTesters,
                typeof(global::AppStoreConnect.BetaTester),
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
        public bool Equals(IncludedItem56 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.App?>.Default.Equals(Apps, other.Apps) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.BetaRecruitmentCriterion?>.Default.Equals(BetaRecruitmentCriteria, other.BetaRecruitmentCriteria) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.BetaTester?>.Default.Equals(BetaTesters, other.BetaTesters) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.Build?>.Default.Equals(Builds, other.Builds)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(IncludedItem56 obj1, IncludedItem56 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IncludedItem56>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(IncludedItem56 obj1, IncludedItem56 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IncludedItem56 o && Equals(o);
        }
    }
}
