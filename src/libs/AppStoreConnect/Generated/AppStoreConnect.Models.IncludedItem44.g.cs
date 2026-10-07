#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct IncludedItem44 : global::System.IEquatable<IncludedItem44>
    {
        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppStoreVersionLocalizationsResponseIncludedItemDiscriminatorType? Type { get; }

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
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.AppStoreVersion? AppStoreVersions { get; init; }
#else
        public global::AppStoreConnect.AppStoreVersion? AppStoreVersions { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AppStoreVersions))]
#endif
        public bool IsAppStoreVersions => AppStoreVersions != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAppStoreVersions(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.AppStoreVersion? value)
        {
            value = AppStoreVersions;
            return IsAppStoreVersions;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppStoreVersion PickAppStoreVersions() => AppStoreVersions is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AppStoreVersions' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem44(global::AppStoreConnect.AppAssetLibraryPlacement value) => new IncludedItem44((global::AppStoreConnect.AppAssetLibraryPlacement?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppAssetLibraryPlacement?(IncludedItem44 @this) => @this.AppAssetLibraryPlacements;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem44(global::AppStoreConnect.AppAssetLibraryPlacement? value)
        {
            AppAssetLibraryPlacements = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem44 FromAppAssetLibraryPlacements(global::AppStoreConnect.AppAssetLibraryPlacement? value) => new IncludedItem44(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem44(global::AppStoreConnect.AppKeyword value) => new IncludedItem44((global::AppStoreConnect.AppKeyword?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppKeyword?(IncludedItem44 @this) => @this.AppKeywords;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem44(global::AppStoreConnect.AppKeyword? value)
        {
            AppKeywords = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem44 FromAppKeywords(global::AppStoreConnect.AppKeyword? value) => new IncludedItem44(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem44(global::AppStoreConnect.AppPreviewSet value) => new IncludedItem44((global::AppStoreConnect.AppPreviewSet?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppPreviewSet?(IncludedItem44 @this) => @this.AppPreviewSets;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem44(global::AppStoreConnect.AppPreviewSet? value)
        {
            AppPreviewSets = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem44 FromAppPreviewSets(global::AppStoreConnect.AppPreviewSet? value) => new IncludedItem44(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem44(global::AppStoreConnect.AppScreenshotSet value) => new IncludedItem44((global::AppStoreConnect.AppScreenshotSet?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppScreenshotSet?(IncludedItem44 @this) => @this.AppScreenshotSets;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem44(global::AppStoreConnect.AppScreenshotSet? value)
        {
            AppScreenshotSets = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem44 FromAppScreenshotSets(global::AppStoreConnect.AppScreenshotSet? value) => new IncludedItem44(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem44(global::AppStoreConnect.AppStoreVersion value) => new IncludedItem44((global::AppStoreConnect.AppStoreVersion?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppStoreVersion?(IncludedItem44 @this) => @this.AppStoreVersions;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem44(global::AppStoreConnect.AppStoreVersion? value)
        {
            AppStoreVersions = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem44 FromAppStoreVersions(global::AppStoreConnect.AppStoreVersion? value) => new IncludedItem44(value);

        /// <summary>
        ///
        /// </summary>
        public IncludedItem44(
            global::AppStoreConnect.AppStoreVersionLocalizationsResponseIncludedItemDiscriminatorType? type,
            global::AppStoreConnect.AppAssetLibraryPlacement? appAssetLibraryPlacements,
            global::AppStoreConnect.AppKeyword? appKeywords,
            global::AppStoreConnect.AppPreviewSet? appPreviewSets,
            global::AppStoreConnect.AppScreenshotSet? appScreenshotSets,
            global::AppStoreConnect.AppStoreVersion? appStoreVersions
            )
        {
            Type = type;

            AppAssetLibraryPlacements = appAssetLibraryPlacements;
            AppKeywords = appKeywords;
            AppPreviewSets = appPreviewSets;
            AppScreenshotSets = appScreenshotSets;
            AppStoreVersions = appStoreVersions;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            AppStoreVersions as object ??
            AppScreenshotSets as object ??
            AppPreviewSets as object ??
            AppKeywords as object ??
            AppAssetLibraryPlacements as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            AppAssetLibraryPlacements?.ToString() ??
            AppKeywords?.ToString() ??
            AppPreviewSets?.ToString() ??
            AppScreenshotSets?.ToString() ??
            AppStoreVersions?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsAppAssetLibraryPlacements && !IsAppKeywords && !IsAppPreviewSets && !IsAppScreenshotSets && !IsAppStoreVersions || !IsAppAssetLibraryPlacements && IsAppKeywords && !IsAppPreviewSets && !IsAppScreenshotSets && !IsAppStoreVersions || !IsAppAssetLibraryPlacements && !IsAppKeywords && IsAppPreviewSets && !IsAppScreenshotSets && !IsAppStoreVersions || !IsAppAssetLibraryPlacements && !IsAppKeywords && !IsAppPreviewSets && IsAppScreenshotSets && !IsAppStoreVersions || !IsAppAssetLibraryPlacements && !IsAppKeywords && !IsAppPreviewSets && !IsAppScreenshotSets && IsAppStoreVersions;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AppStoreConnect.AppAssetLibraryPlacement, TResult>? appAssetLibraryPlacements = null,
            global::System.Func<global::AppStoreConnect.AppKeyword, TResult>? appKeywords = null,
            global::System.Func<global::AppStoreConnect.AppPreviewSet, TResult>? appPreviewSets = null,
            global::System.Func<global::AppStoreConnect.AppScreenshotSet, TResult>? appScreenshotSets = null,
            global::System.Func<global::AppStoreConnect.AppStoreVersion, TResult>? appStoreVersions = null,
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
            else if (AppKeywords is { } __value1 && appKeywords != null)
            {
                return appKeywords(__value1);
            }
            else if (AppPreviewSets is { } __value2 && appPreviewSets != null)
            {
                return appPreviewSets(__value2);
            }
            else if (AppScreenshotSets is { } __value3 && appScreenshotSets != null)
            {
                return appScreenshotSets(__value3);
            }
            else if (AppStoreVersions is { } __value4 && appStoreVersions != null)
            {
                return appStoreVersions(__value4);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::AppStoreConnect.AppAssetLibraryPlacement>? appAssetLibraryPlacements = null,

            global::System.Action<global::AppStoreConnect.AppKeyword>? appKeywords = null,

            global::System.Action<global::AppStoreConnect.AppPreviewSet>? appPreviewSets = null,

            global::System.Action<global::AppStoreConnect.AppScreenshotSet>? appScreenshotSets = null,

            global::System.Action<global::AppStoreConnect.AppStoreVersion>? appStoreVersions = null,
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
            else if (AppKeywords is { } __value1)
            {
                appKeywords?.Invoke(__value1);
            }
            else if (AppPreviewSets is { } __value2)
            {
                appPreviewSets?.Invoke(__value2);
            }
            else if (AppScreenshotSets is { } __value3)
            {
                appScreenshotSets?.Invoke(__value3);
            }
            else if (AppStoreVersions is { } __value4)
            {
                appStoreVersions?.Invoke(__value4);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::AppStoreConnect.AppAssetLibraryPlacement>? appAssetLibraryPlacements = null,
            global::System.Action<global::AppStoreConnect.AppKeyword>? appKeywords = null,
            global::System.Action<global::AppStoreConnect.AppPreviewSet>? appPreviewSets = null,
            global::System.Action<global::AppStoreConnect.AppScreenshotSet>? appScreenshotSets = null,
            global::System.Action<global::AppStoreConnect.AppStoreVersion>? appStoreVersions = null,
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
            else if (AppKeywords is { } __value1)
            {
                appKeywords?.Invoke(__value1);
            }
            else if (AppPreviewSets is { } __value2)
            {
                appPreviewSets?.Invoke(__value2);
            }
            else if (AppScreenshotSets is { } __value3)
            {
                appScreenshotSets?.Invoke(__value3);
            }
            else if (AppStoreVersions is { } __value4)
            {
                appStoreVersions?.Invoke(__value4);
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
                AppKeywords,
                typeof(global::AppStoreConnect.AppKeyword),
                AppPreviewSets,
                typeof(global::AppStoreConnect.AppPreviewSet),
                AppScreenshotSets,
                typeof(global::AppStoreConnect.AppScreenshotSet),
                AppStoreVersions,
                typeof(global::AppStoreConnect.AppStoreVersion),
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
        public bool Equals(IncludedItem44 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppAssetLibraryPlacement?>.Default.Equals(AppAssetLibraryPlacements, other.AppAssetLibraryPlacements) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppKeyword?>.Default.Equals(AppKeywords, other.AppKeywords) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppPreviewSet?>.Default.Equals(AppPreviewSets, other.AppPreviewSets) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppScreenshotSet?>.Default.Equals(AppScreenshotSets, other.AppScreenshotSets) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppStoreVersion?>.Default.Equals(AppStoreVersions, other.AppStoreVersions)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(IncludedItem44 obj1, IncludedItem44 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IncludedItem44>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(IncludedItem44 obj1, IncludedItem44 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IncludedItem44 o && Equals(o);
        }
    }
}
