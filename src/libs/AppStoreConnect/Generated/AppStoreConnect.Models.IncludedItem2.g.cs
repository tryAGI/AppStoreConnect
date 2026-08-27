#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct IncludedItem2 : global::System.IEquatable<IncludedItem2>
    {
        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AlternativeDistributionPackageVersionResponseIncludedItemDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.AlternativeDistributionPackageDelta? AlternativeDistributionPackageDeltas { get; init; }
#else
        public global::AppStoreConnect.AlternativeDistributionPackageDelta? AlternativeDistributionPackageDeltas { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AlternativeDistributionPackageDeltas))]
#endif
        public bool IsAlternativeDistributionPackageDeltas => AlternativeDistributionPackageDeltas != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAlternativeDistributionPackageDeltas(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.AlternativeDistributionPackageDelta? value)
        {
            value = AlternativeDistributionPackageDeltas;
            return IsAlternativeDistributionPackageDeltas;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AlternativeDistributionPackageDelta PickAlternativeDistributionPackageDeltas() => IsAlternativeDistributionPackageDeltas
            ? AlternativeDistributionPackageDeltas!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AlternativeDistributionPackageDeltas' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.AlternativeDistributionPackageVariant? AlternativeDistributionPackageVariants { get; init; }
#else
        public global::AppStoreConnect.AlternativeDistributionPackageVariant? AlternativeDistributionPackageVariants { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AlternativeDistributionPackageVariants))]
#endif
        public bool IsAlternativeDistributionPackageVariants => AlternativeDistributionPackageVariants != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAlternativeDistributionPackageVariants(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.AlternativeDistributionPackageVariant? value)
        {
            value = AlternativeDistributionPackageVariants;
            return IsAlternativeDistributionPackageVariants;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AlternativeDistributionPackageVariant PickAlternativeDistributionPackageVariants() => IsAlternativeDistributionPackageVariants
            ? AlternativeDistributionPackageVariants!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AlternativeDistributionPackageVariants' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.AlternativeDistributionPackage? AlternativeDistributionPackages { get; init; }
#else
        public global::AppStoreConnect.AlternativeDistributionPackage? AlternativeDistributionPackages { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AlternativeDistributionPackages))]
#endif
        public bool IsAlternativeDistributionPackages => AlternativeDistributionPackages != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAlternativeDistributionPackages(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.AlternativeDistributionPackage? value)
        {
            value = AlternativeDistributionPackages;
            return IsAlternativeDistributionPackages;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AlternativeDistributionPackage PickAlternativeDistributionPackages() => IsAlternativeDistributionPackages
            ? AlternativeDistributionPackages!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AlternativeDistributionPackages' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem2(global::AppStoreConnect.AlternativeDistributionPackageDelta value) => new IncludedItem2((global::AppStoreConnect.AlternativeDistributionPackageDelta?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AlternativeDistributionPackageDelta?(IncludedItem2 @this) => @this.AlternativeDistributionPackageDeltas;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem2(global::AppStoreConnect.AlternativeDistributionPackageDelta? value)
        {
            AlternativeDistributionPackageDeltas = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem2 FromAlternativeDistributionPackageDeltas(global::AppStoreConnect.AlternativeDistributionPackageDelta? value) => new IncludedItem2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem2(global::AppStoreConnect.AlternativeDistributionPackageVariant value) => new IncludedItem2((global::AppStoreConnect.AlternativeDistributionPackageVariant?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AlternativeDistributionPackageVariant?(IncludedItem2 @this) => @this.AlternativeDistributionPackageVariants;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem2(global::AppStoreConnect.AlternativeDistributionPackageVariant? value)
        {
            AlternativeDistributionPackageVariants = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem2 FromAlternativeDistributionPackageVariants(global::AppStoreConnect.AlternativeDistributionPackageVariant? value) => new IncludedItem2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem2(global::AppStoreConnect.AlternativeDistributionPackage value) => new IncludedItem2((global::AppStoreConnect.AlternativeDistributionPackage?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AlternativeDistributionPackage?(IncludedItem2 @this) => @this.AlternativeDistributionPackages;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem2(global::AppStoreConnect.AlternativeDistributionPackage? value)
        {
            AlternativeDistributionPackages = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem2 FromAlternativeDistributionPackages(global::AppStoreConnect.AlternativeDistributionPackage? value) => new IncludedItem2(value);

        /// <summary>
        ///
        /// </summary>
        public IncludedItem2(
            global::AppStoreConnect.AlternativeDistributionPackageVersionResponseIncludedItemDiscriminatorType? type,
            global::AppStoreConnect.AlternativeDistributionPackageDelta? alternativeDistributionPackageDeltas,
            global::AppStoreConnect.AlternativeDistributionPackageVariant? alternativeDistributionPackageVariants,
            global::AppStoreConnect.AlternativeDistributionPackage? alternativeDistributionPackages
            )
        {
            Type = type;

            AlternativeDistributionPackageDeltas = alternativeDistributionPackageDeltas;
            AlternativeDistributionPackageVariants = alternativeDistributionPackageVariants;
            AlternativeDistributionPackages = alternativeDistributionPackages;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            AlternativeDistributionPackages as object ??
            AlternativeDistributionPackageVariants as object ??
            AlternativeDistributionPackageDeltas as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            AlternativeDistributionPackageDeltas?.ToString() ??
            AlternativeDistributionPackageVariants?.ToString() ??
            AlternativeDistributionPackages?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsAlternativeDistributionPackageDeltas && !IsAlternativeDistributionPackageVariants && !IsAlternativeDistributionPackages || !IsAlternativeDistributionPackageDeltas && IsAlternativeDistributionPackageVariants && !IsAlternativeDistributionPackages || !IsAlternativeDistributionPackageDeltas && !IsAlternativeDistributionPackageVariants && IsAlternativeDistributionPackages;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AppStoreConnect.AlternativeDistributionPackageDelta, TResult>? alternativeDistributionPackageDeltas = null,
            global::System.Func<global::AppStoreConnect.AlternativeDistributionPackageVariant, TResult>? alternativeDistributionPackageVariants = null,
            global::System.Func<global::AppStoreConnect.AlternativeDistributionPackage, TResult>? alternativeDistributionPackages = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAlternativeDistributionPackageDeltas && alternativeDistributionPackageDeltas != null)
            {
                return alternativeDistributionPackageDeltas(AlternativeDistributionPackageDeltas!);
            }
            else if (IsAlternativeDistributionPackageVariants && alternativeDistributionPackageVariants != null)
            {
                return alternativeDistributionPackageVariants(AlternativeDistributionPackageVariants!);
            }
            else if (IsAlternativeDistributionPackages && alternativeDistributionPackages != null)
            {
                return alternativeDistributionPackages(AlternativeDistributionPackages!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::AppStoreConnect.AlternativeDistributionPackageDelta>? alternativeDistributionPackageDeltas = null,

            global::System.Action<global::AppStoreConnect.AlternativeDistributionPackageVariant>? alternativeDistributionPackageVariants = null,

            global::System.Action<global::AppStoreConnect.AlternativeDistributionPackage>? alternativeDistributionPackages = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAlternativeDistributionPackageDeltas)
            {
                alternativeDistributionPackageDeltas?.Invoke(AlternativeDistributionPackageDeltas!);
            }
            else if (IsAlternativeDistributionPackageVariants)
            {
                alternativeDistributionPackageVariants?.Invoke(AlternativeDistributionPackageVariants!);
            }
            else if (IsAlternativeDistributionPackages)
            {
                alternativeDistributionPackages?.Invoke(AlternativeDistributionPackages!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::AppStoreConnect.AlternativeDistributionPackageDelta>? alternativeDistributionPackageDeltas = null,
            global::System.Action<global::AppStoreConnect.AlternativeDistributionPackageVariant>? alternativeDistributionPackageVariants = null,
            global::System.Action<global::AppStoreConnect.AlternativeDistributionPackage>? alternativeDistributionPackages = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAlternativeDistributionPackageDeltas)
            {
                alternativeDistributionPackageDeltas?.Invoke(AlternativeDistributionPackageDeltas!);
            }
            else if (IsAlternativeDistributionPackageVariants)
            {
                alternativeDistributionPackageVariants?.Invoke(AlternativeDistributionPackageVariants!);
            }
            else if (IsAlternativeDistributionPackages)
            {
                alternativeDistributionPackages?.Invoke(AlternativeDistributionPackages!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AlternativeDistributionPackageDeltas,
                typeof(global::AppStoreConnect.AlternativeDistributionPackageDelta),
                AlternativeDistributionPackageVariants,
                typeof(global::AppStoreConnect.AlternativeDistributionPackageVariant),
                AlternativeDistributionPackages,
                typeof(global::AppStoreConnect.AlternativeDistributionPackage),
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
        public bool Equals(IncludedItem2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AlternativeDistributionPackageDelta?>.Default.Equals(AlternativeDistributionPackageDeltas, other.AlternativeDistributionPackageDeltas) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AlternativeDistributionPackageVariant?>.Default.Equals(AlternativeDistributionPackageVariants, other.AlternativeDistributionPackageVariants) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AlternativeDistributionPackage?>.Default.Equals(AlternativeDistributionPackages, other.AlternativeDistributionPackages)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(IncludedItem2 obj1, IncludedItem2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IncludedItem2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(IncludedItem2 obj1, IncludedItem2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IncludedItem2 o && Equals(o);
        }
    }
}
