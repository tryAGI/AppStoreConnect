#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct IncludedItem36 : global::System.IEquatable<IncludedItem36>
    {
        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationsResponseIncludedItemDiscriminatorType? Type { get; }

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
        public global::AppStoreConnect.AppStoreVersionExperimentTreatment? AppStoreVersionExperimentTreatments { get; init; }
#else
        public global::AppStoreConnect.AppStoreVersionExperimentTreatment? AppStoreVersionExperimentTreatments { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AppStoreVersionExperimentTreatments))]
#endif
        public bool IsAppStoreVersionExperimentTreatments => AppStoreVersionExperimentTreatments != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAppStoreVersionExperimentTreatments(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.AppStoreVersionExperimentTreatment? value)
        {
            value = AppStoreVersionExperimentTreatments;
            return IsAppStoreVersionExperimentTreatments;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppStoreVersionExperimentTreatment PickAppStoreVersionExperimentTreatments() => AppStoreVersionExperimentTreatments is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AppStoreVersionExperimentTreatments' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem36(global::AppStoreConnect.AppAssetLibraryPlacement value) => new IncludedItem36((global::AppStoreConnect.AppAssetLibraryPlacement?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppAssetLibraryPlacement?(IncludedItem36 @this) => @this.AppAssetLibraryPlacements;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem36(global::AppStoreConnect.AppAssetLibraryPlacement? value)
        {
            AppAssetLibraryPlacements = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem36 FromAppAssetLibraryPlacements(global::AppStoreConnect.AppAssetLibraryPlacement? value) => new IncludedItem36(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem36(global::AppStoreConnect.AppPreviewSet value) => new IncludedItem36((global::AppStoreConnect.AppPreviewSet?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppPreviewSet?(IncludedItem36 @this) => @this.AppPreviewSets;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem36(global::AppStoreConnect.AppPreviewSet? value)
        {
            AppPreviewSets = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem36 FromAppPreviewSets(global::AppStoreConnect.AppPreviewSet? value) => new IncludedItem36(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem36(global::AppStoreConnect.AppScreenshotSet value) => new IncludedItem36((global::AppStoreConnect.AppScreenshotSet?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppScreenshotSet?(IncludedItem36 @this) => @this.AppScreenshotSets;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem36(global::AppStoreConnect.AppScreenshotSet? value)
        {
            AppScreenshotSets = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem36 FromAppScreenshotSets(global::AppStoreConnect.AppScreenshotSet? value) => new IncludedItem36(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem36(global::AppStoreConnect.AppStoreVersionExperimentTreatment value) => new IncludedItem36((global::AppStoreConnect.AppStoreVersionExperimentTreatment?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppStoreVersionExperimentTreatment?(IncludedItem36 @this) => @this.AppStoreVersionExperimentTreatments;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem36(global::AppStoreConnect.AppStoreVersionExperimentTreatment? value)
        {
            AppStoreVersionExperimentTreatments = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem36 FromAppStoreVersionExperimentTreatments(global::AppStoreConnect.AppStoreVersionExperimentTreatment? value) => new IncludedItem36(value);

        /// <summary>
        ///
        /// </summary>
        public IncludedItem36(
            global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationsResponseIncludedItemDiscriminatorType? type,
            global::AppStoreConnect.AppAssetLibraryPlacement? appAssetLibraryPlacements,
            global::AppStoreConnect.AppPreviewSet? appPreviewSets,
            global::AppStoreConnect.AppScreenshotSet? appScreenshotSets,
            global::AppStoreConnect.AppStoreVersionExperimentTreatment? appStoreVersionExperimentTreatments
            )
        {
            Type = type;

            AppAssetLibraryPlacements = appAssetLibraryPlacements;
            AppPreviewSets = appPreviewSets;
            AppScreenshotSets = appScreenshotSets;
            AppStoreVersionExperimentTreatments = appStoreVersionExperimentTreatments;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            AppStoreVersionExperimentTreatments as object ??
            AppScreenshotSets as object ??
            AppPreviewSets as object ??
            AppAssetLibraryPlacements as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            AppAssetLibraryPlacements?.ToString() ??
            AppPreviewSets?.ToString() ??
            AppScreenshotSets?.ToString() ??
            AppStoreVersionExperimentTreatments?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsAppAssetLibraryPlacements && !IsAppPreviewSets && !IsAppScreenshotSets && !IsAppStoreVersionExperimentTreatments || !IsAppAssetLibraryPlacements && IsAppPreviewSets && !IsAppScreenshotSets && !IsAppStoreVersionExperimentTreatments || !IsAppAssetLibraryPlacements && !IsAppPreviewSets && IsAppScreenshotSets && !IsAppStoreVersionExperimentTreatments || !IsAppAssetLibraryPlacements && !IsAppPreviewSets && !IsAppScreenshotSets && IsAppStoreVersionExperimentTreatments;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AppStoreConnect.AppAssetLibraryPlacement, TResult>? appAssetLibraryPlacements = null,
            global::System.Func<global::AppStoreConnect.AppPreviewSet, TResult>? appPreviewSets = null,
            global::System.Func<global::AppStoreConnect.AppScreenshotSet, TResult>? appScreenshotSets = null,
            global::System.Func<global::AppStoreConnect.AppStoreVersionExperimentTreatment, TResult>? appStoreVersionExperimentTreatments = null,
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
            else if (AppPreviewSets is { } __value1 && appPreviewSets != null)
            {
                return appPreviewSets(__value1);
            }
            else if (AppScreenshotSets is { } __value2 && appScreenshotSets != null)
            {
                return appScreenshotSets(__value2);
            }
            else if (AppStoreVersionExperimentTreatments is { } __value3 && appStoreVersionExperimentTreatments != null)
            {
                return appStoreVersionExperimentTreatments(__value3);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::AppStoreConnect.AppAssetLibraryPlacement>? appAssetLibraryPlacements = null,

            global::System.Action<global::AppStoreConnect.AppPreviewSet>? appPreviewSets = null,

            global::System.Action<global::AppStoreConnect.AppScreenshotSet>? appScreenshotSets = null,

            global::System.Action<global::AppStoreConnect.AppStoreVersionExperimentTreatment>? appStoreVersionExperimentTreatments = null,
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
            else if (AppPreviewSets is { } __value1)
            {
                appPreviewSets?.Invoke(__value1);
            }
            else if (AppScreenshotSets is { } __value2)
            {
                appScreenshotSets?.Invoke(__value2);
            }
            else if (AppStoreVersionExperimentTreatments is { } __value3)
            {
                appStoreVersionExperimentTreatments?.Invoke(__value3);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::AppStoreConnect.AppAssetLibraryPlacement>? appAssetLibraryPlacements = null,
            global::System.Action<global::AppStoreConnect.AppPreviewSet>? appPreviewSets = null,
            global::System.Action<global::AppStoreConnect.AppScreenshotSet>? appScreenshotSets = null,
            global::System.Action<global::AppStoreConnect.AppStoreVersionExperimentTreatment>? appStoreVersionExperimentTreatments = null,
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
            else if (AppPreviewSets is { } __value1)
            {
                appPreviewSets?.Invoke(__value1);
            }
            else if (AppScreenshotSets is { } __value2)
            {
                appScreenshotSets?.Invoke(__value2);
            }
            else if (AppStoreVersionExperimentTreatments is { } __value3)
            {
                appStoreVersionExperimentTreatments?.Invoke(__value3);
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
                AppPreviewSets,
                typeof(global::AppStoreConnect.AppPreviewSet),
                AppScreenshotSets,
                typeof(global::AppStoreConnect.AppScreenshotSet),
                AppStoreVersionExperimentTreatments,
                typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatment),
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
        public bool Equals(IncludedItem36 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppAssetLibraryPlacement?>.Default.Equals(AppAssetLibraryPlacements, other.AppAssetLibraryPlacements) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppPreviewSet?>.Default.Equals(AppPreviewSets, other.AppPreviewSets) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppScreenshotSet?>.Default.Equals(AppScreenshotSets, other.AppScreenshotSets) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppStoreVersionExperimentTreatment?>.Default.Equals(AppStoreVersionExperimentTreatments, other.AppStoreVersionExperimentTreatments)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(IncludedItem36 obj1, IncludedItem36 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IncludedItem36>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(IncludedItem36 obj1, IncludedItem36 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IncludedItem36 o && Equals(o);
        }
    }
}
