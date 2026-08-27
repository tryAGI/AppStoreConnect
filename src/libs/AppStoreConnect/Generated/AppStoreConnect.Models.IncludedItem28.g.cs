#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct IncludedItem28 : global::System.IEquatable<IncludedItem28>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::AppStoreConnect.AppPriceScheduleResponseIncludedItemDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.AppPriceV2? AppPrices1 { get; init; }
#else
        public global::AppStoreConnect.AppPriceV2? AppPrices1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AppPrices1))]
#endif
        public bool IsAppPrices1 => AppPrices1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAppPrices1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.AppPriceV2? value)
        {
            value = AppPrices1;
            return IsAppPrices1;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::AppStoreConnect.AppPriceV2 PickAppPrices1() => IsAppPrices1
            ? AppPrices1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AppPrices1' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.App? AppPrices2 { get; init; }
#else
        public global::AppStoreConnect.App? AppPrices2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AppPrices2))]
#endif
        public bool IsAppPrices2 => AppPrices2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAppPrices2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.App? value)
        {
            value = AppPrices2;
            return IsAppPrices2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::AppStoreConnect.App PickAppPrices2() => IsAppPrices2
            ? AppPrices2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AppPrices2' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.Territory? Territories { get; init; }
#else
        public global::AppStoreConnect.Territory? Territories { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Territories))]
#endif
        public bool IsTerritories => Territories != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickTerritories(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.Territory? value)
        {
            value = Territories;
            return IsTerritories;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::AppStoreConnect.Territory PickTerritories() => IsTerritories
            ? Territories!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Territories' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IncludedItem28(global::AppStoreConnect.AppPriceV2 value) => new IncludedItem28((global::AppStoreConnect.AppPriceV2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppPriceV2?(IncludedItem28 @this) => @this.AppPrices1;

        /// <summary>
        /// 
        /// </summary>
        public IncludedItem28(global::AppStoreConnect.AppPriceV2? value)
        {
            AppPrices1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IncludedItem28 FromAppPrices1(global::AppStoreConnect.AppPriceV2? value) => new IncludedItem28(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IncludedItem28(global::AppStoreConnect.App value) => new IncludedItem28((global::AppStoreConnect.App?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AppStoreConnect.App?(IncludedItem28 @this) => @this.AppPrices2;

        /// <summary>
        /// 
        /// </summary>
        public IncludedItem28(global::AppStoreConnect.App? value)
        {
            AppPrices2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IncludedItem28 FromAppPrices2(global::AppStoreConnect.App? value) => new IncludedItem28(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IncludedItem28(global::AppStoreConnect.Territory value) => new IncludedItem28((global::AppStoreConnect.Territory?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AppStoreConnect.Territory?(IncludedItem28 @this) => @this.Territories;

        /// <summary>
        /// 
        /// </summary>
        public IncludedItem28(global::AppStoreConnect.Territory? value)
        {
            Territories = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IncludedItem28 FromTerritories(global::AppStoreConnect.Territory? value) => new IncludedItem28(value);

        /// <summary>
        /// 
        /// </summary>
        public IncludedItem28(
            global::AppStoreConnect.AppPriceScheduleResponseIncludedItemDiscriminatorType? type,
            global::AppStoreConnect.AppPriceV2? appPrices1,
            global::AppStoreConnect.App? appPrices2,
            global::AppStoreConnect.Territory? territories
            )
        {
            Type = type;

            AppPrices1 = appPrices1;
            AppPrices2 = appPrices2;
            Territories = territories;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Territories as object ??
            AppPrices2 as object ??
            AppPrices1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            AppPrices1?.ToString() ??
            AppPrices2?.ToString() ??
            Territories?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAppPrices1 && !IsAppPrices2 && !IsTerritories || !IsAppPrices1 && IsAppPrices2 && !IsTerritories || !IsAppPrices1 && !IsAppPrices2 && IsTerritories;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AppStoreConnect.AppPriceV2, TResult>? appPrices1 = null,
            global::System.Func<global::AppStoreConnect.App, TResult>? appPrices2 = null,
            global::System.Func<global::AppStoreConnect.Territory, TResult>? territories = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAppPrices1 && appPrices1 != null)
            {
                return appPrices1(AppPrices1!);
            }
            else if (IsAppPrices2 && appPrices2 != null)
            {
                return appPrices2(AppPrices2!);
            }
            else if (IsTerritories && territories != null)
            {
                return territories(Territories!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::AppStoreConnect.AppPriceV2>? appPrices1 = null,

            global::System.Action<global::AppStoreConnect.App>? appPrices2 = null,

            global::System.Action<global::AppStoreConnect.Territory>? territories = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAppPrices1)
            {
                appPrices1?.Invoke(AppPrices1!);
            }
            else if (IsAppPrices2)
            {
                appPrices2?.Invoke(AppPrices2!);
            }
            else if (IsTerritories)
            {
                territories?.Invoke(Territories!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::AppStoreConnect.AppPriceV2>? appPrices1 = null,
            global::System.Action<global::AppStoreConnect.App>? appPrices2 = null,
            global::System.Action<global::AppStoreConnect.Territory>? territories = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAppPrices1)
            {
                appPrices1?.Invoke(AppPrices1!);
            }
            else if (IsAppPrices2)
            {
                appPrices2?.Invoke(AppPrices2!);
            }
            else if (IsTerritories)
            {
                territories?.Invoke(Territories!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AppPrices1,
                typeof(global::AppStoreConnect.AppPriceV2),
                AppPrices2,
                typeof(global::AppStoreConnect.App),
                Territories,
                typeof(global::AppStoreConnect.Territory),
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
        public bool Equals(IncludedItem28 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppPriceV2?>.Default.Equals(AppPrices1, other.AppPrices1) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.App?>.Default.Equals(AppPrices2, other.AppPrices2) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.Territory?>.Default.Equals(Territories, other.Territories) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(IncludedItem28 obj1, IncludedItem28 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IncludedItem28>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(IncludedItem28 obj1, IncludedItem28 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IncludedItem28 o && Equals(o);
        }
    }
}
