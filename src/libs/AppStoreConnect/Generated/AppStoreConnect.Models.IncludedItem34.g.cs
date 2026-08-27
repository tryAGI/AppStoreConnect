#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct IncludedItem34 : global::System.IEquatable<IncludedItem34>
    {
        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationsResponseIncludedItemDiscriminatorType? Type { get; }

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
        public global::AppStoreConnect.AppPreviewSet PickAppPreviewSets() => IsAppPreviewSets
            ? AppPreviewSets!
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
        public global::AppStoreConnect.AppScreenshotSet PickAppScreenshotSets() => IsAppScreenshotSets
            ? AppScreenshotSets!
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
        public global::AppStoreConnect.AppStoreVersionExperimentTreatment PickAppStoreVersionExperimentTreatments() => IsAppStoreVersionExperimentTreatments
            ? AppStoreVersionExperimentTreatments!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AppStoreVersionExperimentTreatments' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem34(global::AppStoreConnect.AppPreviewSet value) => new IncludedItem34((global::AppStoreConnect.AppPreviewSet?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppPreviewSet?(IncludedItem34 @this) => @this.AppPreviewSets;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem34(global::AppStoreConnect.AppPreviewSet? value)
        {
            AppPreviewSets = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem34 FromAppPreviewSets(global::AppStoreConnect.AppPreviewSet? value) => new IncludedItem34(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem34(global::AppStoreConnect.AppScreenshotSet value) => new IncludedItem34((global::AppStoreConnect.AppScreenshotSet?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppScreenshotSet?(IncludedItem34 @this) => @this.AppScreenshotSets;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem34(global::AppStoreConnect.AppScreenshotSet? value)
        {
            AppScreenshotSets = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem34 FromAppScreenshotSets(global::AppStoreConnect.AppScreenshotSet? value) => new IncludedItem34(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem34(global::AppStoreConnect.AppStoreVersionExperimentTreatment value) => new IncludedItem34((global::AppStoreConnect.AppStoreVersionExperimentTreatment?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppStoreVersionExperimentTreatment?(IncludedItem34 @this) => @this.AppStoreVersionExperimentTreatments;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem34(global::AppStoreConnect.AppStoreVersionExperimentTreatment? value)
        {
            AppStoreVersionExperimentTreatments = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem34 FromAppStoreVersionExperimentTreatments(global::AppStoreConnect.AppStoreVersionExperimentTreatment? value) => new IncludedItem34(value);

        /// <summary>
        ///
        /// </summary>
        public IncludedItem34(
            global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationsResponseIncludedItemDiscriminatorType? type,
            global::AppStoreConnect.AppPreviewSet? appPreviewSets,
            global::AppStoreConnect.AppScreenshotSet? appScreenshotSets,
            global::AppStoreConnect.AppStoreVersionExperimentTreatment? appStoreVersionExperimentTreatments
            )
        {
            Type = type;

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
            AppPreviewSets as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            AppPreviewSets?.ToString() ??
            AppScreenshotSets?.ToString() ??
            AppStoreVersionExperimentTreatments?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsAppPreviewSets && !IsAppScreenshotSets && !IsAppStoreVersionExperimentTreatments || !IsAppPreviewSets && IsAppScreenshotSets && !IsAppStoreVersionExperimentTreatments || !IsAppPreviewSets && !IsAppScreenshotSets && IsAppStoreVersionExperimentTreatments;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AppStoreConnect.AppPreviewSet, TResult>? appPreviewSets = null,
            global::System.Func<global::AppStoreConnect.AppScreenshotSet, TResult>? appScreenshotSets = null,
            global::System.Func<global::AppStoreConnect.AppStoreVersionExperimentTreatment, TResult>? appStoreVersionExperimentTreatments = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAppPreviewSets && appPreviewSets != null)
            {
                return appPreviewSets(AppPreviewSets!);
            }
            else if (IsAppScreenshotSets && appScreenshotSets != null)
            {
                return appScreenshotSets(AppScreenshotSets!);
            }
            else if (IsAppStoreVersionExperimentTreatments && appStoreVersionExperimentTreatments != null)
            {
                return appStoreVersionExperimentTreatments(AppStoreVersionExperimentTreatments!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::AppStoreConnect.AppPreviewSet>? appPreviewSets = null,

            global::System.Action<global::AppStoreConnect.AppScreenshotSet>? appScreenshotSets = null,

            global::System.Action<global::AppStoreConnect.AppStoreVersionExperimentTreatment>? appStoreVersionExperimentTreatments = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAppPreviewSets)
            {
                appPreviewSets?.Invoke(AppPreviewSets!);
            }
            else if (IsAppScreenshotSets)
            {
                appScreenshotSets?.Invoke(AppScreenshotSets!);
            }
            else if (IsAppStoreVersionExperimentTreatments)
            {
                appStoreVersionExperimentTreatments?.Invoke(AppStoreVersionExperimentTreatments!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::AppStoreConnect.AppPreviewSet>? appPreviewSets = null,
            global::System.Action<global::AppStoreConnect.AppScreenshotSet>? appScreenshotSets = null,
            global::System.Action<global::AppStoreConnect.AppStoreVersionExperimentTreatment>? appStoreVersionExperimentTreatments = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAppPreviewSets)
            {
                appPreviewSets?.Invoke(AppPreviewSets!);
            }
            else if (IsAppScreenshotSets)
            {
                appScreenshotSets?.Invoke(AppScreenshotSets!);
            }
            else if (IsAppStoreVersionExperimentTreatments)
            {
                appStoreVersionExperimentTreatments?.Invoke(AppStoreVersionExperimentTreatments!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
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
        public bool Equals(IncludedItem34 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppPreviewSet?>.Default.Equals(AppPreviewSets, other.AppPreviewSets) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppScreenshotSet?>.Default.Equals(AppScreenshotSets, other.AppScreenshotSets) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppStoreVersionExperimentTreatment?>.Default.Equals(AppStoreVersionExperimentTreatments, other.AppStoreVersionExperimentTreatments)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(IncludedItem34 obj1, IncludedItem34 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IncludedItem34>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(IncludedItem34 obj1, IncludedItem34 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IncludedItem34 o && Equals(o);
        }
    }
}
