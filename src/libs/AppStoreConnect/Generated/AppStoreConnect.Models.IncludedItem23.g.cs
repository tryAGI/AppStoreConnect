#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct IncludedItem23 : global::System.IEquatable<IncludedItem23>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::AppStoreConnect.AppInfoResponseIncludedItemDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.AgeRatingDeclaration? AgeRatingDeclarations { get; init; }
#else
        public global::AppStoreConnect.AgeRatingDeclaration? AgeRatingDeclarations { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgeRatingDeclarations))]
#endif
        public bool IsAgeRatingDeclarations => AgeRatingDeclarations != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAgeRatingDeclarations(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.AgeRatingDeclaration? value)
        {
            value = AgeRatingDeclarations;
            return IsAgeRatingDeclarations;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::AppStoreConnect.AgeRatingDeclaration PickAgeRatingDeclarations() => IsAgeRatingDeclarations
            ? AgeRatingDeclarations!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AgeRatingDeclarations' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.AppCategory? AppCategories1 { get; init; }
#else
        public global::AppStoreConnect.AppCategory? AppCategories1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AppCategories1))]
#endif
        public bool IsAppCategories1 => AppCategories1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAppCategories1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.AppCategory? value)
        {
            value = AppCategories1;
            return IsAppCategories1;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::AppStoreConnect.AppCategory PickAppCategories1() => IsAppCategories1
            ? AppCategories1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AppCategories1' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.AppInfoLocalization? AppInfoLocalizations { get; init; }
#else
        public global::AppStoreConnect.AppInfoLocalization? AppInfoLocalizations { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AppInfoLocalizations))]
#endif
        public bool IsAppInfoLocalizations => AppInfoLocalizations != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAppInfoLocalizations(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.AppInfoLocalization? value)
        {
            value = AppInfoLocalizations;
            return IsAppInfoLocalizations;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::AppStoreConnect.AppInfoLocalization PickAppInfoLocalizations() => IsAppInfoLocalizations
            ? AppInfoLocalizations!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AppInfoLocalizations' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.App? AppCategories2 { get; init; }
#else
        public global::AppStoreConnect.App? AppCategories2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AppCategories2))]
#endif
        public bool IsAppCategories2 => AppCategories2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAppCategories2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.App? value)
        {
            value = AppCategories2;
            return IsAppCategories2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::AppStoreConnect.App PickAppCategories2() => IsAppCategories2
            ? AppCategories2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AppCategories2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IncludedItem23(global::AppStoreConnect.AgeRatingDeclaration value) => new IncludedItem23((global::AppStoreConnect.AgeRatingDeclaration?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AppStoreConnect.AgeRatingDeclaration?(IncludedItem23 @this) => @this.AgeRatingDeclarations;

        /// <summary>
        /// 
        /// </summary>
        public IncludedItem23(global::AppStoreConnect.AgeRatingDeclaration? value)
        {
            AgeRatingDeclarations = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IncludedItem23 FromAgeRatingDeclarations(global::AppStoreConnect.AgeRatingDeclaration? value) => new IncludedItem23(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IncludedItem23(global::AppStoreConnect.AppCategory value) => new IncludedItem23((global::AppStoreConnect.AppCategory?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppCategory?(IncludedItem23 @this) => @this.AppCategories1;

        /// <summary>
        /// 
        /// </summary>
        public IncludedItem23(global::AppStoreConnect.AppCategory? value)
        {
            AppCategories1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IncludedItem23 FromAppCategories1(global::AppStoreConnect.AppCategory? value) => new IncludedItem23(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IncludedItem23(global::AppStoreConnect.AppInfoLocalization value) => new IncludedItem23((global::AppStoreConnect.AppInfoLocalization?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppInfoLocalization?(IncludedItem23 @this) => @this.AppInfoLocalizations;

        /// <summary>
        /// 
        /// </summary>
        public IncludedItem23(global::AppStoreConnect.AppInfoLocalization? value)
        {
            AppInfoLocalizations = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IncludedItem23 FromAppInfoLocalizations(global::AppStoreConnect.AppInfoLocalization? value) => new IncludedItem23(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IncludedItem23(global::AppStoreConnect.App value) => new IncludedItem23((global::AppStoreConnect.App?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AppStoreConnect.App?(IncludedItem23 @this) => @this.AppCategories2;

        /// <summary>
        /// 
        /// </summary>
        public IncludedItem23(global::AppStoreConnect.App? value)
        {
            AppCategories2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IncludedItem23 FromAppCategories2(global::AppStoreConnect.App? value) => new IncludedItem23(value);

        /// <summary>
        /// 
        /// </summary>
        public IncludedItem23(
            global::AppStoreConnect.AppInfoResponseIncludedItemDiscriminatorType? type,
            global::AppStoreConnect.AgeRatingDeclaration? ageRatingDeclarations,
            global::AppStoreConnect.AppCategory? appCategories1,
            global::AppStoreConnect.AppInfoLocalization? appInfoLocalizations,
            global::AppStoreConnect.App? appCategories2
            )
        {
            Type = type;

            AgeRatingDeclarations = ageRatingDeclarations;
            AppCategories1 = appCategories1;
            AppInfoLocalizations = appInfoLocalizations;
            AppCategories2 = appCategories2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            AppCategories2 as object ??
            AppInfoLocalizations as object ??
            AppCategories1 as object ??
            AgeRatingDeclarations as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            AgeRatingDeclarations?.ToString() ??
            AppCategories1?.ToString() ??
            AppInfoLocalizations?.ToString() ??
            AppCategories2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAgeRatingDeclarations && !IsAppCategories1 && !IsAppInfoLocalizations && !IsAppCategories2 || !IsAgeRatingDeclarations && IsAppCategories1 && !IsAppInfoLocalizations && !IsAppCategories2 || !IsAgeRatingDeclarations && !IsAppCategories1 && IsAppInfoLocalizations && !IsAppCategories2 || !IsAgeRatingDeclarations && !IsAppCategories1 && !IsAppInfoLocalizations && IsAppCategories2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AppStoreConnect.AgeRatingDeclaration, TResult>? ageRatingDeclarations = null,
            global::System.Func<global::AppStoreConnect.AppCategory, TResult>? appCategories1 = null,
            global::System.Func<global::AppStoreConnect.AppInfoLocalization, TResult>? appInfoLocalizations = null,
            global::System.Func<global::AppStoreConnect.App, TResult>? appCategories2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAgeRatingDeclarations && ageRatingDeclarations != null)
            {
                return ageRatingDeclarations(AgeRatingDeclarations!);
            }
            else if (IsAppCategories1 && appCategories1 != null)
            {
                return appCategories1(AppCategories1!);
            }
            else if (IsAppInfoLocalizations && appInfoLocalizations != null)
            {
                return appInfoLocalizations(AppInfoLocalizations!);
            }
            else if (IsAppCategories2 && appCategories2 != null)
            {
                return appCategories2(AppCategories2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::AppStoreConnect.AgeRatingDeclaration>? ageRatingDeclarations = null,

            global::System.Action<global::AppStoreConnect.AppCategory>? appCategories1 = null,

            global::System.Action<global::AppStoreConnect.AppInfoLocalization>? appInfoLocalizations = null,

            global::System.Action<global::AppStoreConnect.App>? appCategories2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAgeRatingDeclarations)
            {
                ageRatingDeclarations?.Invoke(AgeRatingDeclarations!);
            }
            else if (IsAppCategories1)
            {
                appCategories1?.Invoke(AppCategories1!);
            }
            else if (IsAppInfoLocalizations)
            {
                appInfoLocalizations?.Invoke(AppInfoLocalizations!);
            }
            else if (IsAppCategories2)
            {
                appCategories2?.Invoke(AppCategories2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::AppStoreConnect.AgeRatingDeclaration>? ageRatingDeclarations = null,
            global::System.Action<global::AppStoreConnect.AppCategory>? appCategories1 = null,
            global::System.Action<global::AppStoreConnect.AppInfoLocalization>? appInfoLocalizations = null,
            global::System.Action<global::AppStoreConnect.App>? appCategories2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAgeRatingDeclarations)
            {
                ageRatingDeclarations?.Invoke(AgeRatingDeclarations!);
            }
            else if (IsAppCategories1)
            {
                appCategories1?.Invoke(AppCategories1!);
            }
            else if (IsAppInfoLocalizations)
            {
                appInfoLocalizations?.Invoke(AppInfoLocalizations!);
            }
            else if (IsAppCategories2)
            {
                appCategories2?.Invoke(AppCategories2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AgeRatingDeclarations,
                typeof(global::AppStoreConnect.AgeRatingDeclaration),
                AppCategories1,
                typeof(global::AppStoreConnect.AppCategory),
                AppInfoLocalizations,
                typeof(global::AppStoreConnect.AppInfoLocalization),
                AppCategories2,
                typeof(global::AppStoreConnect.App),
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
        public bool Equals(IncludedItem23 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AgeRatingDeclaration?>.Default.Equals(AgeRatingDeclarations, other.AgeRatingDeclarations) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppCategory?>.Default.Equals(AppCategories1, other.AppCategories1) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppInfoLocalization?>.Default.Equals(AppInfoLocalizations, other.AppInfoLocalizations) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.App?>.Default.Equals(AppCategories2, other.AppCategories2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(IncludedItem23 obj1, IncludedItem23 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IncludedItem23>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(IncludedItem23 obj1, IncludedItem23 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IncludedItem23 o && Equals(o);
        }
    }
}
