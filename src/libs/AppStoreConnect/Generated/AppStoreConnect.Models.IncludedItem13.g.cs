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
        public global::AppStoreConnect.AppCustomProductPageLocalizationsResponseIncludedItemDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.AppAssetLibraryPlacement? AppAssetLibraryPlacements { get; init; }
#else
        public global::AppStoreConnect.AppAssetLibraryPlacement? AppAssetLibraryPlacements { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AppAssetLibraryPlacements))]
#endif
        public bool IsAppAssetLibraryPlacements => AppAssetLibraryPlacements != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAppAssetLibraryPlacements(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.AppAssetLibraryPlacement? value)
        {
            value = AppAssetLibraryPlacements;
            return IsAppAssetLibraryPlacements;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppAssetLibraryPlacement PickAppAssetLibraryPlacements() => AppAssetLibraryPlacements is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AppAssetLibraryPlacements' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.AppCustomProductPageVersion? AppCustomProductPageVersions { get; init; }
#else
        public global::AppStoreConnect.AppCustomProductPageVersion? AppCustomProductPageVersions { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AppCustomProductPageVersions))]
#endif
        public bool IsAppCustomProductPageVersions => AppCustomProductPageVersions != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAppCustomProductPageVersions(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.AppCustomProductPageVersion? value)
        {
            value = AppCustomProductPageVersions;
            return IsAppCustomProductPageVersions;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppCustomProductPageVersion PickAppCustomProductPageVersions() => AppCustomProductPageVersions is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AppCustomProductPageVersions' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.AppKeyword? AppKeywords { get; init; }
#else
        public global::AppStoreConnect.AppKeyword? AppKeywords { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AppKeywords))]
#endif
        public bool IsAppKeywords => AppKeywords != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAppKeywords(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.AppKeyword? value)
        {
            value = AppKeywords;
            return IsAppKeywords;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppKeyword PickAppKeywords() => AppKeywords is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AppKeywords' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.AppPreviewSet? AppPreviewSets { get; init; }
#else
        public global::AppStoreConnect.AppPreviewSet? AppPreviewSets { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AppPreviewSets))]
#endif
        public bool IsAppPreviewSets => AppPreviewSets != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAppPreviewSets(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.AppPreviewSet? value)
        {
            value = AppPreviewSets;
            return IsAppPreviewSets;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppPreviewSet PickAppPreviewSets() => AppPreviewSets is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AppPreviewSets' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.AppScreenshotSet? AppScreenshotSets { get; init; }
#else
        public global::AppStoreConnect.AppScreenshotSet? AppScreenshotSets { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AppScreenshotSets))]
#endif
        public bool IsAppScreenshotSets => AppScreenshotSets != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAppScreenshotSets(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.AppScreenshotSet? value)
        {
            value = AppScreenshotSets;
            return IsAppScreenshotSets;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppScreenshotSet PickAppScreenshotSets() => AppScreenshotSets is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AppScreenshotSets' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem13(global::AppStoreConnect.AppAssetLibraryPlacement value) => new IncludedItem13((global::AppStoreConnect.AppAssetLibraryPlacement?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppAssetLibraryPlacement?(IncludedItem13 @this) => @this.AppAssetLibraryPlacements;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem13(global::AppStoreConnect.AppAssetLibraryPlacement? value)
        {
            AppAssetLibraryPlacements = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem13 FromAppAssetLibraryPlacements(global::AppStoreConnect.AppAssetLibraryPlacement? value) => new IncludedItem13(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem13(global::AppStoreConnect.AppCustomProductPageVersion value) => new IncludedItem13((global::AppStoreConnect.AppCustomProductPageVersion?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppCustomProductPageVersion?(IncludedItem13 @this) => @this.AppCustomProductPageVersions;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem13(global::AppStoreConnect.AppCustomProductPageVersion? value)
        {
            AppCustomProductPageVersions = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem13 FromAppCustomProductPageVersions(global::AppStoreConnect.AppCustomProductPageVersion? value) => new IncludedItem13(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem13(global::AppStoreConnect.AppKeyword value) => new IncludedItem13((global::AppStoreConnect.AppKeyword?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppKeyword?(IncludedItem13 @this) => @this.AppKeywords;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem13(global::AppStoreConnect.AppKeyword? value)
        {
            AppKeywords = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem13 FromAppKeywords(global::AppStoreConnect.AppKeyword? value) => new IncludedItem13(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem13(global::AppStoreConnect.AppPreviewSet value) => new IncludedItem13((global::AppStoreConnect.AppPreviewSet?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppPreviewSet?(IncludedItem13 @this) => @this.AppPreviewSets;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem13(global::AppStoreConnect.AppPreviewSet? value)
        {
            AppPreviewSets = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem13 FromAppPreviewSets(global::AppStoreConnect.AppPreviewSet? value) => new IncludedItem13(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem13(global::AppStoreConnect.AppScreenshotSet value) => new IncludedItem13((global::AppStoreConnect.AppScreenshotSet?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppScreenshotSet?(IncludedItem13 @this) => @this.AppScreenshotSets;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem13(global::AppStoreConnect.AppScreenshotSet? value)
        {
            AppScreenshotSets = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem13 FromAppScreenshotSets(global::AppStoreConnect.AppScreenshotSet? value) => new IncludedItem13(value);

        /// <summary>
        ///
        /// </summary>
        public IncludedItem13(
            global::AppStoreConnect.AppCustomProductPageLocalizationsResponseIncludedItemDiscriminatorType? type,
            global::AppStoreConnect.AppAssetLibraryPlacement? appAssetLibraryPlacements,
            global::AppStoreConnect.AppCustomProductPageVersion? appCustomProductPageVersions,
            global::AppStoreConnect.AppKeyword? appKeywords,
            global::AppStoreConnect.AppPreviewSet? appPreviewSets,
            global::AppStoreConnect.AppScreenshotSet? appScreenshotSets
            )
        {
            Type = type;

            AppAssetLibraryPlacements = appAssetLibraryPlacements;
            AppCustomProductPageVersions = appCustomProductPageVersions;
            AppKeywords = appKeywords;
            AppPreviewSets = appPreviewSets;
            AppScreenshotSets = appScreenshotSets;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            AppScreenshotSets as object ??
            AppPreviewSets as object ??
            AppKeywords as object ??
            AppCustomProductPageVersions as object ??
            AppAssetLibraryPlacements as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            AppAssetLibraryPlacements?.ToString() ??
            AppCustomProductPageVersions?.ToString() ??
            AppKeywords?.ToString() ??
            AppPreviewSets?.ToString() ??
            AppScreenshotSets?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsAppAssetLibraryPlacements && !IsAppCustomProductPageVersions && !IsAppKeywords && !IsAppPreviewSets && !IsAppScreenshotSets || !IsAppAssetLibraryPlacements && IsAppCustomProductPageVersions && !IsAppKeywords && !IsAppPreviewSets && !IsAppScreenshotSets || !IsAppAssetLibraryPlacements && !IsAppCustomProductPageVersions && IsAppKeywords && !IsAppPreviewSets && !IsAppScreenshotSets || !IsAppAssetLibraryPlacements && !IsAppCustomProductPageVersions && !IsAppKeywords && IsAppPreviewSets && !IsAppScreenshotSets || !IsAppAssetLibraryPlacements && !IsAppCustomProductPageVersions && !IsAppKeywords && !IsAppPreviewSets && IsAppScreenshotSets;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AppStoreConnect.AppAssetLibraryPlacement, TResult>? appAssetLibraryPlacements = null,
            global::System.Func<global::AppStoreConnect.AppCustomProductPageVersion, TResult>? appCustomProductPageVersions = null,
            global::System.Func<global::AppStoreConnect.AppKeyword, TResult>? appKeywords = null,
            global::System.Func<global::AppStoreConnect.AppPreviewSet, TResult>? appPreviewSets = null,
            global::System.Func<global::AppStoreConnect.AppScreenshotSet, TResult>? appScreenshotSets = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (AppAssetLibraryPlacements is { } __value0 && appAssetLibraryPlacements != null)
            {
                return appAssetLibraryPlacements(__value0);
            }
            else if (AppCustomProductPageVersions is { } __value1 && appCustomProductPageVersions != null)
            {
                return appCustomProductPageVersions(__value1);
            }
            else if (AppKeywords is { } __value2 && appKeywords != null)
            {
                return appKeywords(__value2);
            }
            else if (AppPreviewSets is { } __value3 && appPreviewSets != null)
            {
                return appPreviewSets(__value3);
            }
            else if (AppScreenshotSets is { } __value4 && appScreenshotSets != null)
            {
                return appScreenshotSets(__value4);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::AppStoreConnect.AppAssetLibraryPlacement>? appAssetLibraryPlacements = null,

            global::System.Action<global::AppStoreConnect.AppCustomProductPageVersion>? appCustomProductPageVersions = null,

            global::System.Action<global::AppStoreConnect.AppKeyword>? appKeywords = null,

            global::System.Action<global::AppStoreConnect.AppPreviewSet>? appPreviewSets = null,

            global::System.Action<global::AppStoreConnect.AppScreenshotSet>? appScreenshotSets = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (AppAssetLibraryPlacements is { } __value0)
            {
                appAssetLibraryPlacements?.Invoke(__value0);
            }
            else if (AppCustomProductPageVersions is { } __value1)
            {
                appCustomProductPageVersions?.Invoke(__value1);
            }
            else if (AppKeywords is { } __value2)
            {
                appKeywords?.Invoke(__value2);
            }
            else if (AppPreviewSets is { } __value3)
            {
                appPreviewSets?.Invoke(__value3);
            }
            else if (AppScreenshotSets is { } __value4)
            {
                appScreenshotSets?.Invoke(__value4);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::AppStoreConnect.AppAssetLibraryPlacement>? appAssetLibraryPlacements = null,
            global::System.Action<global::AppStoreConnect.AppCustomProductPageVersion>? appCustomProductPageVersions = null,
            global::System.Action<global::AppStoreConnect.AppKeyword>? appKeywords = null,
            global::System.Action<global::AppStoreConnect.AppPreviewSet>? appPreviewSets = null,
            global::System.Action<global::AppStoreConnect.AppScreenshotSet>? appScreenshotSets = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (AppAssetLibraryPlacements is { } __value0)
            {
                appAssetLibraryPlacements?.Invoke(__value0);
            }
            else if (AppCustomProductPageVersions is { } __value1)
            {
                appCustomProductPageVersions?.Invoke(__value1);
            }
            else if (AppKeywords is { } __value2)
            {
                appKeywords?.Invoke(__value2);
            }
            else if (AppPreviewSets is { } __value3)
            {
                appPreviewSets?.Invoke(__value3);
            }
            else if (AppScreenshotSets is { } __value4)
            {
                appScreenshotSets?.Invoke(__value4);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AppAssetLibraryPlacements,
                typeof(global::AppStoreConnect.AppAssetLibraryPlacement),
                AppCustomProductPageVersions,
                typeof(global::AppStoreConnect.AppCustomProductPageVersion),
                AppKeywords,
                typeof(global::AppStoreConnect.AppKeyword),
                AppPreviewSets,
                typeof(global::AppStoreConnect.AppPreviewSet),
                AppScreenshotSets,
                typeof(global::AppStoreConnect.AppScreenshotSet),
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
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppAssetLibraryPlacement?>.Default.Equals(AppAssetLibraryPlacements, other.AppAssetLibraryPlacements) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppCustomProductPageVersion?>.Default.Equals(AppCustomProductPageVersions, other.AppCustomProductPageVersions) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppKeyword?>.Default.Equals(AppKeywords, other.AppKeywords) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppPreviewSet?>.Default.Equals(AppPreviewSets, other.AppPreviewSets) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppScreenshotSet?>.Default.Equals(AppScreenshotSets, other.AppScreenshotSets)
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
