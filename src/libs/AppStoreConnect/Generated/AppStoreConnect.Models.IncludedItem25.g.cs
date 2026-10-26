#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct IncludedItem25 : global::System.IEquatable<IncludedItem25>
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
        public global::AppStoreConnect.AgeRatingDeclaration PickAgeRatingDeclarations() => AgeRatingDeclarations is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AgeRatingDeclarations' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.AppCategory? AppCategories { get; init; }
#else
        public global::AppStoreConnect.AppCategory? AppCategories { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AppCategories))]
#endif
        public bool IsAppCategories => AppCategories != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAppCategories(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.AppCategory? value)
        {
            value = AppCategories;
            return IsAppCategories;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppCategory PickAppCategories() => AppCategories is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AppCategories' but the value was {ToString()}.");

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
        public global::AppStoreConnect.AppInfoLocalization PickAppInfoLocalizations() => AppInfoLocalizations is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AppInfoLocalizations' but the value was {ToString()}.");

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
        public static implicit operator IncludedItem25(global::AppStoreConnect.AgeRatingDeclaration value) => new IncludedItem25((global::AppStoreConnect.AgeRatingDeclaration?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AgeRatingDeclaration?(IncludedItem25 @this) => @this.AgeRatingDeclarations;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem25(global::AppStoreConnect.AgeRatingDeclaration? value)
        {
            AgeRatingDeclarations = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem25 FromAgeRatingDeclarations(global::AppStoreConnect.AgeRatingDeclaration? value) => new IncludedItem25(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem25(global::AppStoreConnect.AppCategory value) => new IncludedItem25((global::AppStoreConnect.AppCategory?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppCategory?(IncludedItem25 @this) => @this.AppCategories;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem25(global::AppStoreConnect.AppCategory? value)
        {
            AppCategories = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem25 FromAppCategories(global::AppStoreConnect.AppCategory? value) => new IncludedItem25(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem25(global::AppStoreConnect.AppInfoLocalization value) => new IncludedItem25((global::AppStoreConnect.AppInfoLocalization?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppInfoLocalization?(IncludedItem25 @this) => @this.AppInfoLocalizations;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem25(global::AppStoreConnect.AppInfoLocalization? value)
        {
            AppInfoLocalizations = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem25 FromAppInfoLocalizations(global::AppStoreConnect.AppInfoLocalization? value) => new IncludedItem25(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem25(global::AppStoreConnect.App value) => new IncludedItem25((global::AppStoreConnect.App?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.App?(IncludedItem25 @this) => @this.Apps;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem25(global::AppStoreConnect.App? value)
        {
            Apps = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem25 FromApps(global::AppStoreConnect.App? value) => new IncludedItem25(value);

        /// <summary>
        ///
        /// </summary>
        public IncludedItem25(
            global::AppStoreConnect.AppInfoResponseIncludedItemDiscriminatorType? type,
            global::AppStoreConnect.AgeRatingDeclaration? ageRatingDeclarations,
            global::AppStoreConnect.AppCategory? appCategories,
            global::AppStoreConnect.AppInfoLocalization? appInfoLocalizations,
            global::AppStoreConnect.App? apps
            )
        {
            Type = type;

            AgeRatingDeclarations = ageRatingDeclarations;
            AppCategories = appCategories;
            AppInfoLocalizations = appInfoLocalizations;
            Apps = apps;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Apps as object ??
            AppInfoLocalizations as object ??
            AppCategories as object ??
            AgeRatingDeclarations as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            AgeRatingDeclarations?.ToString() ??
            AppCategories?.ToString() ??
            AppInfoLocalizations?.ToString() ??
            Apps?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsAgeRatingDeclarations && !IsAppCategories && !IsAppInfoLocalizations && !IsApps || !IsAgeRatingDeclarations && IsAppCategories && !IsAppInfoLocalizations && !IsApps || !IsAgeRatingDeclarations && !IsAppCategories && IsAppInfoLocalizations && !IsApps || !IsAgeRatingDeclarations && !IsAppCategories && !IsAppInfoLocalizations && IsApps;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AppStoreConnect.AgeRatingDeclaration, TResult>? ageRatingDeclarations = null,
            global::System.Func<global::AppStoreConnect.AppCategory, TResult>? appCategories = null,
            global::System.Func<global::AppStoreConnect.AppInfoLocalization, TResult>? appInfoLocalizations = null,
            global::System.Func<global::AppStoreConnect.App, TResult>? apps = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (AgeRatingDeclarations is { } __value0 && ageRatingDeclarations != null)
            {
                return ageRatingDeclarations(__value0);
            }
            else if (AppCategories is { } __value1 && appCategories != null)
            {
                return appCategories(__value1);
            }
            else if (AppInfoLocalizations is { } __value2 && appInfoLocalizations != null)
            {
                return appInfoLocalizations(__value2);
            }
            else if (Apps is { } __value3 && apps != null)
            {
                return apps(__value3);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::AppStoreConnect.AgeRatingDeclaration>? ageRatingDeclarations = null,

            global::System.Action<global::AppStoreConnect.AppCategory>? appCategories = null,

            global::System.Action<global::AppStoreConnect.AppInfoLocalization>? appInfoLocalizations = null,

            global::System.Action<global::AppStoreConnect.App>? apps = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (AgeRatingDeclarations is { } __value0)
            {
                ageRatingDeclarations?.Invoke(__value0);
            }
            else if (AppCategories is { } __value1)
            {
                appCategories?.Invoke(__value1);
            }
            else if (AppInfoLocalizations is { } __value2)
            {
                appInfoLocalizations?.Invoke(__value2);
            }
            else if (Apps is { } __value3)
            {
                apps?.Invoke(__value3);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::AppStoreConnect.AgeRatingDeclaration>? ageRatingDeclarations = null,
            global::System.Action<global::AppStoreConnect.AppCategory>? appCategories = null,
            global::System.Action<global::AppStoreConnect.AppInfoLocalization>? appInfoLocalizations = null,
            global::System.Action<global::AppStoreConnect.App>? apps = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (AgeRatingDeclarations is { } __value0)
            {
                ageRatingDeclarations?.Invoke(__value0);
            }
            else if (AppCategories is { } __value1)
            {
                appCategories?.Invoke(__value1);
            }
            else if (AppInfoLocalizations is { } __value2)
            {
                appInfoLocalizations?.Invoke(__value2);
            }
            else if (Apps is { } __value3)
            {
                apps?.Invoke(__value3);
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
                AppCategories,
                typeof(global::AppStoreConnect.AppCategory),
                AppInfoLocalizations,
                typeof(global::AppStoreConnect.AppInfoLocalization),
                Apps,
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
        public bool Equals(IncludedItem25 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AgeRatingDeclaration?>.Default.Equals(AgeRatingDeclarations, other.AgeRatingDeclarations) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppCategory?>.Default.Equals(AppCategories, other.AppCategories) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppInfoLocalization?>.Default.Equals(AppInfoLocalizations, other.AppInfoLocalizations) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.App?>.Default.Equals(Apps, other.Apps)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(IncludedItem25 obj1, IncludedItem25 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IncludedItem25>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(IncludedItem25 obj1, IncludedItem25 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IncludedItem25 o && Equals(o);
        }
    }
}
