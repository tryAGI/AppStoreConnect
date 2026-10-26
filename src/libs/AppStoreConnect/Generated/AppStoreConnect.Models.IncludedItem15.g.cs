#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct IncludedItem15 : global::System.IEquatable<IncludedItem15>
    {
        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppCustomProductPageVersionsResponseIncludedItemDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.AppCustomProductPageLocalization? AppCustomProductPageLocalizations { get; init; }
#else
        public global::AppStoreConnect.AppCustomProductPageLocalization? AppCustomProductPageLocalizations { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AppCustomProductPageLocalizations))]
#endif
        public bool IsAppCustomProductPageLocalizations => AppCustomProductPageLocalizations != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAppCustomProductPageLocalizations(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.AppCustomProductPageLocalization? value)
        {
            value = AppCustomProductPageLocalizations;
            return IsAppCustomProductPageLocalizations;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppCustomProductPageLocalization PickAppCustomProductPageLocalizations() => AppCustomProductPageLocalizations is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AppCustomProductPageLocalizations' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.AppCustomProductPage? AppCustomProductPages { get; init; }
#else
        public global::AppStoreConnect.AppCustomProductPage? AppCustomProductPages { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AppCustomProductPages))]
#endif
        public bool IsAppCustomProductPages => AppCustomProductPages != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAppCustomProductPages(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.AppCustomProductPage? value)
        {
            value = AppCustomProductPages;
            return IsAppCustomProductPages;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppCustomProductPage PickAppCustomProductPages() => AppCustomProductPages is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AppCustomProductPages' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem15(global::AppStoreConnect.AppCustomProductPageLocalization value) => new IncludedItem15((global::AppStoreConnect.AppCustomProductPageLocalization?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppCustomProductPageLocalization?(IncludedItem15 @this) => @this.AppCustomProductPageLocalizations;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem15(global::AppStoreConnect.AppCustomProductPageLocalization? value)
        {
            AppCustomProductPageLocalizations = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem15 FromAppCustomProductPageLocalizations(global::AppStoreConnect.AppCustomProductPageLocalization? value) => new IncludedItem15(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem15(global::AppStoreConnect.AppCustomProductPage value) => new IncludedItem15((global::AppStoreConnect.AppCustomProductPage?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppCustomProductPage?(IncludedItem15 @this) => @this.AppCustomProductPages;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem15(global::AppStoreConnect.AppCustomProductPage? value)
        {
            AppCustomProductPages = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem15 FromAppCustomProductPages(global::AppStoreConnect.AppCustomProductPage? value) => new IncludedItem15(value);

        /// <summary>
        ///
        /// </summary>
        public IncludedItem15(
            global::AppStoreConnect.AppCustomProductPageVersionsResponseIncludedItemDiscriminatorType? type,
            global::AppStoreConnect.AppCustomProductPageLocalization? appCustomProductPageLocalizations,
            global::AppStoreConnect.AppCustomProductPage? appCustomProductPages
            )
        {
            Type = type;

            AppCustomProductPageLocalizations = appCustomProductPageLocalizations;
            AppCustomProductPages = appCustomProductPages;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            AppCustomProductPages as object ??
            AppCustomProductPageLocalizations as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            AppCustomProductPageLocalizations?.ToString() ??
            AppCustomProductPages?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsAppCustomProductPageLocalizations && !IsAppCustomProductPages || !IsAppCustomProductPageLocalizations && IsAppCustomProductPages;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AppStoreConnect.AppCustomProductPageLocalization, TResult>? appCustomProductPageLocalizations = null,
            global::System.Func<global::AppStoreConnect.AppCustomProductPage, TResult>? appCustomProductPages = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (AppCustomProductPageLocalizations is { } __value0 && appCustomProductPageLocalizations != null)
            {
                return appCustomProductPageLocalizations(__value0);
            }
            else if (AppCustomProductPages is { } __value1 && appCustomProductPages != null)
            {
                return appCustomProductPages(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::AppStoreConnect.AppCustomProductPageLocalization>? appCustomProductPageLocalizations = null,

            global::System.Action<global::AppStoreConnect.AppCustomProductPage>? appCustomProductPages = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (AppCustomProductPageLocalizations is { } __value0)
            {
                appCustomProductPageLocalizations?.Invoke(__value0);
            }
            else if (AppCustomProductPages is { } __value1)
            {
                appCustomProductPages?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::AppStoreConnect.AppCustomProductPageLocalization>? appCustomProductPageLocalizations = null,
            global::System.Action<global::AppStoreConnect.AppCustomProductPage>? appCustomProductPages = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (AppCustomProductPageLocalizations is { } __value0)
            {
                appCustomProductPageLocalizations?.Invoke(__value0);
            }
            else if (AppCustomProductPages is { } __value1)
            {
                appCustomProductPages?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AppCustomProductPageLocalizations,
                typeof(global::AppStoreConnect.AppCustomProductPageLocalization),
                AppCustomProductPages,
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
        public bool Equals(IncludedItem15 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppCustomProductPageLocalization?>.Default.Equals(AppCustomProductPageLocalizations, other.AppCustomProductPageLocalizations) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppCustomProductPage?>.Default.Equals(AppCustomProductPages, other.AppCustomProductPages)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(IncludedItem15 obj1, IncludedItem15 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IncludedItem15>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(IncludedItem15 obj1, IncludedItem15 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IncludedItem15 o && Equals(o);
        }
    }
}
