#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct IncludedItem13 : global::System.IEquatable<IncludedItem13>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::AppStoreConnect.AppCustomProductPageVersionsResponseIncludedItemDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.AppCustomProductPageLocalization? AppCustomProductPageLocalizations1 { get; init; }
#else
        public global::AppStoreConnect.AppCustomProductPageLocalization? AppCustomProductPageLocalizations1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AppCustomProductPageLocalizations1))]
#endif
        public bool IsAppCustomProductPageLocalizations1 => AppCustomProductPageLocalizations1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAppCustomProductPageLocalizations1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.AppCustomProductPageLocalization? value)
        {
            value = AppCustomProductPageLocalizations1;
            return IsAppCustomProductPageLocalizations1;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::AppStoreConnect.AppCustomProductPageLocalization PickAppCustomProductPageLocalizations1() => IsAppCustomProductPageLocalizations1
            ? AppCustomProductPageLocalizations1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AppCustomProductPageLocalizations1' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.AppCustomProductPage? AppCustomProductPageLocalizations2 { get; init; }
#else
        public global::AppStoreConnect.AppCustomProductPage? AppCustomProductPageLocalizations2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AppCustomProductPageLocalizations2))]
#endif
        public bool IsAppCustomProductPageLocalizations2 => AppCustomProductPageLocalizations2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAppCustomProductPageLocalizations2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.AppCustomProductPage? value)
        {
            value = AppCustomProductPageLocalizations2;
            return IsAppCustomProductPageLocalizations2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::AppStoreConnect.AppCustomProductPage PickAppCustomProductPageLocalizations2() => IsAppCustomProductPageLocalizations2
            ? AppCustomProductPageLocalizations2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AppCustomProductPageLocalizations2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IncludedItem13(global::AppStoreConnect.AppCustomProductPageLocalization value) => new IncludedItem13((global::AppStoreConnect.AppCustomProductPageLocalization?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppCustomProductPageLocalization?(IncludedItem13 @this) => @this.AppCustomProductPageLocalizations1;

        /// <summary>
        /// 
        /// </summary>
        public IncludedItem13(global::AppStoreConnect.AppCustomProductPageLocalization? value)
        {
            AppCustomProductPageLocalizations1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IncludedItem13 FromAppCustomProductPageLocalizations1(global::AppStoreConnect.AppCustomProductPageLocalization? value) => new IncludedItem13(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IncludedItem13(global::AppStoreConnect.AppCustomProductPage value) => new IncludedItem13((global::AppStoreConnect.AppCustomProductPage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppCustomProductPage?(IncludedItem13 @this) => @this.AppCustomProductPageLocalizations2;

        /// <summary>
        /// 
        /// </summary>
        public IncludedItem13(global::AppStoreConnect.AppCustomProductPage? value)
        {
            AppCustomProductPageLocalizations2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IncludedItem13 FromAppCustomProductPageLocalizations2(global::AppStoreConnect.AppCustomProductPage? value) => new IncludedItem13(value);

        /// <summary>
        /// 
        /// </summary>
        public IncludedItem13(
            global::AppStoreConnect.AppCustomProductPageVersionsResponseIncludedItemDiscriminatorType? type,
            global::AppStoreConnect.AppCustomProductPageLocalization? appCustomProductPageLocalizations1,
            global::AppStoreConnect.AppCustomProductPage? appCustomProductPageLocalizations2
            )
        {
            Type = type;

            AppCustomProductPageLocalizations1 = appCustomProductPageLocalizations1;
            AppCustomProductPageLocalizations2 = appCustomProductPageLocalizations2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            AppCustomProductPageLocalizations2 as object ??
            AppCustomProductPageLocalizations1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            AppCustomProductPageLocalizations1?.ToString() ??
            AppCustomProductPageLocalizations2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAppCustomProductPageLocalizations1 && !IsAppCustomProductPageLocalizations2 || !IsAppCustomProductPageLocalizations1 && IsAppCustomProductPageLocalizations2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AppStoreConnect.AppCustomProductPageLocalization, TResult>? appCustomProductPageLocalizations1 = null,
            global::System.Func<global::AppStoreConnect.AppCustomProductPage, TResult>? appCustomProductPageLocalizations2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAppCustomProductPageLocalizations1 && appCustomProductPageLocalizations1 != null)
            {
                return appCustomProductPageLocalizations1(AppCustomProductPageLocalizations1!);
            }
            else if (IsAppCustomProductPageLocalizations2 && appCustomProductPageLocalizations2 != null)
            {
                return appCustomProductPageLocalizations2(AppCustomProductPageLocalizations2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::AppStoreConnect.AppCustomProductPageLocalization>? appCustomProductPageLocalizations1 = null,

            global::System.Action<global::AppStoreConnect.AppCustomProductPage>? appCustomProductPageLocalizations2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAppCustomProductPageLocalizations1)
            {
                appCustomProductPageLocalizations1?.Invoke(AppCustomProductPageLocalizations1!);
            }
            else if (IsAppCustomProductPageLocalizations2)
            {
                appCustomProductPageLocalizations2?.Invoke(AppCustomProductPageLocalizations2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::AppStoreConnect.AppCustomProductPageLocalization>? appCustomProductPageLocalizations1 = null,
            global::System.Action<global::AppStoreConnect.AppCustomProductPage>? appCustomProductPageLocalizations2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAppCustomProductPageLocalizations1)
            {
                appCustomProductPageLocalizations1?.Invoke(AppCustomProductPageLocalizations1!);
            }
            else if (IsAppCustomProductPageLocalizations2)
            {
                appCustomProductPageLocalizations2?.Invoke(AppCustomProductPageLocalizations2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AppCustomProductPageLocalizations1,
                typeof(global::AppStoreConnect.AppCustomProductPageLocalization),
                AppCustomProductPageLocalizations2,
                typeof(global::AppStoreConnect.AppCustomProductPage),
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
        public bool Equals(IncludedItem13 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppCustomProductPageLocalization?>.Default.Equals(AppCustomProductPageLocalizations1, other.AppCustomProductPageLocalizations1) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppCustomProductPage?>.Default.Equals(AppCustomProductPageLocalizations2, other.AppCustomProductPageLocalizations2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(IncludedItem13 obj1, IncludedItem13 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IncludedItem13>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(IncludedItem13 obj1, IncludedItem13 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IncludedItem13 o && Equals(o);
        }
    }
}
