#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct IncludedItem71 : global::System.IEquatable<IncludedItem71>
    {
        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.CiWorkflowResponseIncludedItemDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.CiMacOsVersion? CiMacOsVersions { get; init; }
#else
        public global::AppStoreConnect.CiMacOsVersion? CiMacOsVersions { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CiMacOsVersions))]
#endif
        public bool IsCiMacOsVersions => CiMacOsVersions != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCiMacOsVersions(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.CiMacOsVersion? value)
        {
            value = CiMacOsVersions;
            return IsCiMacOsVersions;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.CiMacOsVersion PickCiMacOsVersions() => IsCiMacOsVersions
            ? CiMacOsVersions!
            : throw new global::System.InvalidOperationException($"Expected union variant 'CiMacOsVersions' but the value was {ToString()}.");

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
        public global::AppStoreConnect.CiXcodeVersion? CiXcodeVersions { get; init; }
#else
        public global::AppStoreConnect.CiXcodeVersion? CiXcodeVersions { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CiXcodeVersions))]
#endif
        public bool IsCiXcodeVersions => CiXcodeVersions != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCiXcodeVersions(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.CiXcodeVersion? value)
        {
            value = CiXcodeVersions;
            return IsCiXcodeVersions;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.CiXcodeVersion PickCiXcodeVersions() => IsCiXcodeVersions
            ? CiXcodeVersions!
            : throw new global::System.InvalidOperationException($"Expected union variant 'CiXcodeVersions' but the value was {ToString()}.");

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
        public static implicit operator IncludedItem71(global::AppStoreConnect.CiMacOsVersion value) => new IncludedItem71((global::AppStoreConnect.CiMacOsVersion?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.CiMacOsVersion?(IncludedItem71 @this) => @this.CiMacOsVersions;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem71(global::AppStoreConnect.CiMacOsVersion? value)
        {
            CiMacOsVersions = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem71 FromCiMacOsVersions(global::AppStoreConnect.CiMacOsVersion? value) => new IncludedItem71(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem71(global::AppStoreConnect.CiProduct value) => new IncludedItem71((global::AppStoreConnect.CiProduct?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.CiProduct?(IncludedItem71 @this) => @this.CiProducts;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem71(global::AppStoreConnect.CiProduct? value)
        {
            CiProducts = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem71 FromCiProducts(global::AppStoreConnect.CiProduct? value) => new IncludedItem71(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem71(global::AppStoreConnect.CiXcodeVersion value) => new IncludedItem71((global::AppStoreConnect.CiXcodeVersion?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.CiXcodeVersion?(IncludedItem71 @this) => @this.CiXcodeVersions;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem71(global::AppStoreConnect.CiXcodeVersion? value)
        {
            CiXcodeVersions = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem71 FromCiXcodeVersions(global::AppStoreConnect.CiXcodeVersion? value) => new IncludedItem71(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem71(global::AppStoreConnect.ScmRepository value) => new IncludedItem71((global::AppStoreConnect.ScmRepository?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.ScmRepository?(IncludedItem71 @this) => @this.ScmRepositories;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem71(global::AppStoreConnect.ScmRepository? value)
        {
            ScmRepositories = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem71 FromScmRepositories(global::AppStoreConnect.ScmRepository? value) => new IncludedItem71(value);

        /// <summary>
        ///
        /// </summary>
        public IncludedItem71(
            global::AppStoreConnect.CiWorkflowResponseIncludedItemDiscriminatorType? type,
            global::AppStoreConnect.CiMacOsVersion? ciMacOsVersions,
            global::AppStoreConnect.CiProduct? ciProducts,
            global::AppStoreConnect.CiXcodeVersion? ciXcodeVersions,
            global::AppStoreConnect.ScmRepository? scmRepositories
            )
        {
            Type = type;

            CiMacOsVersions = ciMacOsVersions;
            CiProducts = ciProducts;
            CiXcodeVersions = ciXcodeVersions;
            ScmRepositories = scmRepositories;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            ScmRepositories as object ??
            CiXcodeVersions as object ??
            CiProducts as object ??
            CiMacOsVersions as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            CiMacOsVersions?.ToString() ??
            CiProducts?.ToString() ??
            CiXcodeVersions?.ToString() ??
            ScmRepositories?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsCiMacOsVersions && !IsCiProducts && !IsCiXcodeVersions && !IsScmRepositories || !IsCiMacOsVersions && IsCiProducts && !IsCiXcodeVersions && !IsScmRepositories || !IsCiMacOsVersions && !IsCiProducts && IsCiXcodeVersions && !IsScmRepositories || !IsCiMacOsVersions && !IsCiProducts && !IsCiXcodeVersions && IsScmRepositories;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AppStoreConnect.CiMacOsVersion, TResult>? ciMacOsVersions = null,
            global::System.Func<global::AppStoreConnect.CiProduct, TResult>? ciProducts = null,
            global::System.Func<global::AppStoreConnect.CiXcodeVersion, TResult>? ciXcodeVersions = null,
            global::System.Func<global::AppStoreConnect.ScmRepository, TResult>? scmRepositories = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCiMacOsVersions && ciMacOsVersions != null)
            {
                return ciMacOsVersions(CiMacOsVersions!);
            }
            else if (IsCiProducts && ciProducts != null)
            {
                return ciProducts(CiProducts!);
            }
            else if (IsCiXcodeVersions && ciXcodeVersions != null)
            {
                return ciXcodeVersions(CiXcodeVersions!);
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
            global::System.Action<global::AppStoreConnect.CiMacOsVersion>? ciMacOsVersions = null,

            global::System.Action<global::AppStoreConnect.CiProduct>? ciProducts = null,

            global::System.Action<global::AppStoreConnect.CiXcodeVersion>? ciXcodeVersions = null,

            global::System.Action<global::AppStoreConnect.ScmRepository>? scmRepositories = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCiMacOsVersions)
            {
                ciMacOsVersions?.Invoke(CiMacOsVersions!);
            }
            else if (IsCiProducts)
            {
                ciProducts?.Invoke(CiProducts!);
            }
            else if (IsCiXcodeVersions)
            {
                ciXcodeVersions?.Invoke(CiXcodeVersions!);
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
            global::System.Action<global::AppStoreConnect.CiMacOsVersion>? ciMacOsVersions = null,
            global::System.Action<global::AppStoreConnect.CiProduct>? ciProducts = null,
            global::System.Action<global::AppStoreConnect.CiXcodeVersion>? ciXcodeVersions = null,
            global::System.Action<global::AppStoreConnect.ScmRepository>? scmRepositories = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCiMacOsVersions)
            {
                ciMacOsVersions?.Invoke(CiMacOsVersions!);
            }
            else if (IsCiProducts)
            {
                ciProducts?.Invoke(CiProducts!);
            }
            else if (IsCiXcodeVersions)
            {
                ciXcodeVersions?.Invoke(CiXcodeVersions!);
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
                CiMacOsVersions,
                typeof(global::AppStoreConnect.CiMacOsVersion),
                CiProducts,
                typeof(global::AppStoreConnect.CiProduct),
                CiXcodeVersions,
                typeof(global::AppStoreConnect.CiXcodeVersion),
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
        public bool Equals(IncludedItem71 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.CiMacOsVersion?>.Default.Equals(CiMacOsVersions, other.CiMacOsVersions) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.CiProduct?>.Default.Equals(CiProducts, other.CiProducts) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.CiXcodeVersion?>.Default.Equals(CiXcodeVersions, other.CiXcodeVersions) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.ScmRepository?>.Default.Equals(ScmRepositories, other.ScmRepositories)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(IncludedItem71 obj1, IncludedItem71 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IncludedItem71>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(IncludedItem71 obj1, IncludedItem71 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IncludedItem71 o && Equals(o);
        }
    }
}
