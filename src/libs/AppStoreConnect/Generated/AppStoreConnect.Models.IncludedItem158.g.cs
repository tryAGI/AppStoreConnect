#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct IncludedItem158 : global::System.IEquatable<IncludedItem158>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::AppStoreConnect.ScmRepositoriesResponseIncludedItemDiscriminatorType? Type { get; }

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
        public global::AppStoreConnect.ScmProvider? ScmProviders { get; init; }
#else
        public global::AppStoreConnect.ScmProvider? ScmProviders { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ScmProviders))]
#endif
        public bool IsScmProviders => ScmProviders != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickScmProviders(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.ScmProvider? value)
        {
            value = ScmProviders;
            return IsScmProviders;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::AppStoreConnect.ScmProvider PickScmProviders() => IsScmProviders
            ? ScmProviders!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ScmProviders' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IncludedItem158(global::AppStoreConnect.ScmGitReference value) => new IncludedItem158((global::AppStoreConnect.ScmGitReference?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AppStoreConnect.ScmGitReference?(IncludedItem158 @this) => @this.ScmGitReferences;

        /// <summary>
        /// 
        /// </summary>
        public IncludedItem158(global::AppStoreConnect.ScmGitReference? value)
        {
            ScmGitReferences = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IncludedItem158 FromScmGitReferences(global::AppStoreConnect.ScmGitReference? value) => new IncludedItem158(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IncludedItem158(global::AppStoreConnect.ScmProvider value) => new IncludedItem158((global::AppStoreConnect.ScmProvider?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AppStoreConnect.ScmProvider?(IncludedItem158 @this) => @this.ScmProviders;

        /// <summary>
        /// 
        /// </summary>
        public IncludedItem158(global::AppStoreConnect.ScmProvider? value)
        {
            ScmProviders = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IncludedItem158 FromScmProviders(global::AppStoreConnect.ScmProvider? value) => new IncludedItem158(value);

        /// <summary>
        /// 
        /// </summary>
        public IncludedItem158(
            global::AppStoreConnect.ScmRepositoriesResponseIncludedItemDiscriminatorType? type,
            global::AppStoreConnect.ScmGitReference? scmGitReferences,
            global::AppStoreConnect.ScmProvider? scmProviders
            )
        {
            Type = type;

            ScmGitReferences = scmGitReferences;
            ScmProviders = scmProviders;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ScmProviders as object ??
            ScmGitReferences as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ScmGitReferences?.ToString() ??
            ScmProviders?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsScmGitReferences && !IsScmProviders || !IsScmGitReferences && IsScmProviders;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AppStoreConnect.ScmGitReference, TResult>? scmGitReferences = null,
            global::System.Func<global::AppStoreConnect.ScmProvider, TResult>? scmProviders = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsScmGitReferences && scmGitReferences != null)
            {
                return scmGitReferences(ScmGitReferences!);
            }
            else if (IsScmProviders && scmProviders != null)
            {
                return scmProviders(ScmProviders!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::AppStoreConnect.ScmGitReference>? scmGitReferences = null,

            global::System.Action<global::AppStoreConnect.ScmProvider>? scmProviders = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsScmGitReferences)
            {
                scmGitReferences?.Invoke(ScmGitReferences!);
            }
            else if (IsScmProviders)
            {
                scmProviders?.Invoke(ScmProviders!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::AppStoreConnect.ScmGitReference>? scmGitReferences = null,
            global::System.Action<global::AppStoreConnect.ScmProvider>? scmProviders = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsScmGitReferences)
            {
                scmGitReferences?.Invoke(ScmGitReferences!);
            }
            else if (IsScmProviders)
            {
                scmProviders?.Invoke(ScmProviders!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ScmGitReferences,
                typeof(global::AppStoreConnect.ScmGitReference),
                ScmProviders,
                typeof(global::AppStoreConnect.ScmProvider),
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
        public bool Equals(IncludedItem158 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.ScmGitReference?>.Default.Equals(ScmGitReferences, other.ScmGitReferences) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.ScmProvider?>.Default.Equals(ScmProviders, other.ScmProviders) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(IncludedItem158 obj1, IncludedItem158 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IncludedItem158>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(IncludedItem158 obj1, IncludedItem158 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IncludedItem158 o && Equals(o);
        }
    }
}
