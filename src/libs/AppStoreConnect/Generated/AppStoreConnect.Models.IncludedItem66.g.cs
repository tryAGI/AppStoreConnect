#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct IncludedItem66 : global::System.IEquatable<IncludedItem66>
    {
        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.CiBuildRunsResponseIncludedItemDiscriminatorType? Type { get; }

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
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.CiProduct? CiProducts { get; init; }
#else
        public global::AppStoreConnect.CiProduct? CiProducts { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CiProducts))]
#endif
        public bool IsCiProducts => CiProducts != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCiProducts(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.CiProduct? value)
        {
            value = CiProducts;
            return IsCiProducts;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.CiProduct PickCiProducts() => IsCiProducts
            ? CiProducts!
            : throw new global::System.InvalidOperationException($"Expected union variant 'CiProducts' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.CiWorkflow? CiWorkflows { get; init; }
#else
        public global::AppStoreConnect.CiWorkflow? CiWorkflows { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CiWorkflows))]
#endif
        public bool IsCiWorkflows => CiWorkflows != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCiWorkflows(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.CiWorkflow? value)
        {
            value = CiWorkflows;
            return IsCiWorkflows;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.CiWorkflow PickCiWorkflows() => IsCiWorkflows
            ? CiWorkflows!
            : throw new global::System.InvalidOperationException($"Expected union variant 'CiWorkflows' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.ScmGitReference? ScmGitReferences { get; init; }
#else
        public global::AppStoreConnect.ScmGitReference? ScmGitReferences { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ScmGitReferences))]
#endif
        public bool IsScmGitReferences => ScmGitReferences != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickScmGitReferences(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.ScmGitReference? value)
        {
            value = ScmGitReferences;
            return IsScmGitReferences;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.ScmGitReference PickScmGitReferences() => IsScmGitReferences
            ? ScmGitReferences!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ScmGitReferences' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.ScmPullRequest? ScmPullRequests { get; init; }
#else
        public global::AppStoreConnect.ScmPullRequest? ScmPullRequests { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ScmPullRequests))]
#endif
        public bool IsScmPullRequests => ScmPullRequests != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickScmPullRequests(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.ScmPullRequest? value)
        {
            value = ScmPullRequests;
            return IsScmPullRequests;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.ScmPullRequest PickScmPullRequests() => IsScmPullRequests
            ? ScmPullRequests!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ScmPullRequests' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem66(global::AppStoreConnect.Build value) => new IncludedItem66((global::AppStoreConnect.Build?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.Build?(IncludedItem66 @this) => @this.Builds;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem66(global::AppStoreConnect.Build? value)
        {
            Builds = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem66 FromBuilds(global::AppStoreConnect.Build? value) => new IncludedItem66(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem66(global::AppStoreConnect.CiProduct value) => new IncludedItem66((global::AppStoreConnect.CiProduct?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.CiProduct?(IncludedItem66 @this) => @this.CiProducts;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem66(global::AppStoreConnect.CiProduct? value)
        {
            CiProducts = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem66 FromCiProducts(global::AppStoreConnect.CiProduct? value) => new IncludedItem66(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem66(global::AppStoreConnect.CiWorkflow value) => new IncludedItem66((global::AppStoreConnect.CiWorkflow?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.CiWorkflow?(IncludedItem66 @this) => @this.CiWorkflows;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem66(global::AppStoreConnect.CiWorkflow? value)
        {
            CiWorkflows = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem66 FromCiWorkflows(global::AppStoreConnect.CiWorkflow? value) => new IncludedItem66(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem66(global::AppStoreConnect.ScmGitReference value) => new IncludedItem66((global::AppStoreConnect.ScmGitReference?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.ScmGitReference?(IncludedItem66 @this) => @this.ScmGitReferences;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem66(global::AppStoreConnect.ScmGitReference? value)
        {
            ScmGitReferences = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem66 FromScmGitReferences(global::AppStoreConnect.ScmGitReference? value) => new IncludedItem66(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem66(global::AppStoreConnect.ScmPullRequest value) => new IncludedItem66((global::AppStoreConnect.ScmPullRequest?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.ScmPullRequest?(IncludedItem66 @this) => @this.ScmPullRequests;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem66(global::AppStoreConnect.ScmPullRequest? value)
        {
            ScmPullRequests = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem66 FromScmPullRequests(global::AppStoreConnect.ScmPullRequest? value) => new IncludedItem66(value);

        /// <summary>
        ///
        /// </summary>
        public IncludedItem66(
            global::AppStoreConnect.CiBuildRunsResponseIncludedItemDiscriminatorType? type,
            global::AppStoreConnect.Build? builds,
            global::AppStoreConnect.CiProduct? ciProducts,
            global::AppStoreConnect.CiWorkflow? ciWorkflows,
            global::AppStoreConnect.ScmGitReference? scmGitReferences,
            global::AppStoreConnect.ScmPullRequest? scmPullRequests
            )
        {
            Type = type;

            Builds = builds;
            CiProducts = ciProducts;
            CiWorkflows = ciWorkflows;
            ScmGitReferences = scmGitReferences;
            ScmPullRequests = scmPullRequests;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            ScmPullRequests as object ??
            ScmGitReferences as object ??
            CiWorkflows as object ??
            CiProducts as object ??
            Builds as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Builds?.ToString() ??
            CiProducts?.ToString() ??
            CiWorkflows?.ToString() ??
            ScmGitReferences?.ToString() ??
            ScmPullRequests?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsBuilds && !IsCiProducts && !IsCiWorkflows && !IsScmGitReferences && !IsScmPullRequests || !IsBuilds && IsCiProducts && !IsCiWorkflows && !IsScmGitReferences && !IsScmPullRequests || !IsBuilds && !IsCiProducts && IsCiWorkflows && !IsScmGitReferences && !IsScmPullRequests || !IsBuilds && !IsCiProducts && !IsCiWorkflows && IsScmGitReferences && !IsScmPullRequests || !IsBuilds && !IsCiProducts && !IsCiWorkflows && !IsScmGitReferences && IsScmPullRequests;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AppStoreConnect.Build, TResult>? builds = null,
            global::System.Func<global::AppStoreConnect.CiProduct, TResult>? ciProducts = null,
            global::System.Func<global::AppStoreConnect.CiWorkflow, TResult>? ciWorkflows = null,
            global::System.Func<global::AppStoreConnect.ScmGitReference, TResult>? scmGitReferences = null,
            global::System.Func<global::AppStoreConnect.ScmPullRequest, TResult>? scmPullRequests = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBuilds && builds != null)
            {
                return builds(Builds!);
            }
            else if (IsCiProducts && ciProducts != null)
            {
                return ciProducts(CiProducts!);
            }
            else if (IsCiWorkflows && ciWorkflows != null)
            {
                return ciWorkflows(CiWorkflows!);
            }
            else if (IsScmGitReferences && scmGitReferences != null)
            {
                return scmGitReferences(ScmGitReferences!);
            }
            else if (IsScmPullRequests && scmPullRequests != null)
            {
                return scmPullRequests(ScmPullRequests!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::AppStoreConnect.Build>? builds = null,

            global::System.Action<global::AppStoreConnect.CiProduct>? ciProducts = null,

            global::System.Action<global::AppStoreConnect.CiWorkflow>? ciWorkflows = null,

            global::System.Action<global::AppStoreConnect.ScmGitReference>? scmGitReferences = null,

            global::System.Action<global::AppStoreConnect.ScmPullRequest>? scmPullRequests = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBuilds)
            {
                builds?.Invoke(Builds!);
            }
            else if (IsCiProducts)
            {
                ciProducts?.Invoke(CiProducts!);
            }
            else if (IsCiWorkflows)
            {
                ciWorkflows?.Invoke(CiWorkflows!);
            }
            else if (IsScmGitReferences)
            {
                scmGitReferences?.Invoke(ScmGitReferences!);
            }
            else if (IsScmPullRequests)
            {
                scmPullRequests?.Invoke(ScmPullRequests!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::AppStoreConnect.Build>? builds = null,
            global::System.Action<global::AppStoreConnect.CiProduct>? ciProducts = null,
            global::System.Action<global::AppStoreConnect.CiWorkflow>? ciWorkflows = null,
            global::System.Action<global::AppStoreConnect.ScmGitReference>? scmGitReferences = null,
            global::System.Action<global::AppStoreConnect.ScmPullRequest>? scmPullRequests = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBuilds)
            {
                builds?.Invoke(Builds!);
            }
            else if (IsCiProducts)
            {
                ciProducts?.Invoke(CiProducts!);
            }
            else if (IsCiWorkflows)
            {
                ciWorkflows?.Invoke(CiWorkflows!);
            }
            else if (IsScmGitReferences)
            {
                scmGitReferences?.Invoke(ScmGitReferences!);
            }
            else if (IsScmPullRequests)
            {
                scmPullRequests?.Invoke(ScmPullRequests!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Builds,
                typeof(global::AppStoreConnect.Build),
                CiProducts,
                typeof(global::AppStoreConnect.CiProduct),
                CiWorkflows,
                typeof(global::AppStoreConnect.CiWorkflow),
                ScmGitReferences,
                typeof(global::AppStoreConnect.ScmGitReference),
                ScmPullRequests,
                typeof(global::AppStoreConnect.ScmPullRequest),
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
        public bool Equals(IncludedItem66 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.Build?>.Default.Equals(Builds, other.Builds) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.CiProduct?>.Default.Equals(CiProducts, other.CiProducts) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.CiWorkflow?>.Default.Equals(CiWorkflows, other.CiWorkflows) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.ScmGitReference?>.Default.Equals(ScmGitReferences, other.ScmGitReferences) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.ScmPullRequest?>.Default.Equals(ScmPullRequests, other.ScmPullRequests)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(IncludedItem66 obj1, IncludedItem66 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IncludedItem66>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(IncludedItem66 obj1, IncludedItem66 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IncludedItem66 o && Equals(o);
        }
    }
}
