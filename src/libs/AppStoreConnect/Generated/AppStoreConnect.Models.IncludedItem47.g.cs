#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct IncludedItem47 : global::System.IEquatable<IncludedItem47>
    {
        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppStoreVersionResponseIncludedItemDiscriminatorType? Type { get; }

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
        public global::AppStoreConnect.AlternativeDistributionPackage PickAlternativeDistributionPackages() => AlternativeDistributionPackages is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AlternativeDistributionPackages' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.AppClipDefaultExperience? AppClipDefaultExperiences1 { get; init; }
#else
        public global::AppStoreConnect.AppClipDefaultExperience? AppClipDefaultExperiences1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AppClipDefaultExperiences1))]
#endif
        public bool IsAppClipDefaultExperiences1 => AppClipDefaultExperiences1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAppClipDefaultExperiences1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.AppClipDefaultExperience? value)
        {
            value = AppClipDefaultExperiences1;
            return IsAppClipDefaultExperiences1;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppClipDefaultExperience PickAppClipDefaultExperiences1() => AppClipDefaultExperiences1 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AppClipDefaultExperiences1' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.AppStoreReviewDetail? AppStoreReviewDetails { get; init; }
#else
        public global::AppStoreConnect.AppStoreReviewDetail? AppStoreReviewDetails { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AppStoreReviewDetails))]
#endif
        public bool IsAppStoreReviewDetails => AppStoreReviewDetails != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAppStoreReviewDetails(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.AppStoreReviewDetail? value)
        {
            value = AppStoreReviewDetails;
            return IsAppStoreReviewDetails;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppStoreReviewDetail PickAppStoreReviewDetails() => AppStoreReviewDetails is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AppStoreReviewDetails' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.AppStoreVersionExperiment? AppStoreVersionExperiments { get; init; }
#else
        public global::AppStoreConnect.AppStoreVersionExperiment? AppStoreVersionExperiments { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AppStoreVersionExperiments))]
#endif
        public bool IsAppStoreVersionExperiments => AppStoreVersionExperiments != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAppStoreVersionExperiments(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.AppStoreVersionExperiment? value)
        {
            value = AppStoreVersionExperiments;
            return IsAppStoreVersionExperiments;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppStoreVersionExperiment PickAppStoreVersionExperiments() => AppStoreVersionExperiments is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AppStoreVersionExperiments' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.AppStoreVersionLocalization? AppStoreVersionLocalizations { get; init; }
#else
        public global::AppStoreConnect.AppStoreVersionLocalization? AppStoreVersionLocalizations { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AppStoreVersionLocalizations))]
#endif
        public bool IsAppStoreVersionLocalizations => AppStoreVersionLocalizations != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAppStoreVersionLocalizations(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.AppStoreVersionLocalization? value)
        {
            value = AppStoreVersionLocalizations;
            return IsAppStoreVersionLocalizations;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppStoreVersionLocalization PickAppStoreVersionLocalizations() => AppStoreVersionLocalizations is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AppStoreVersionLocalizations' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.AppStoreVersionPhasedRelease? AppStoreVersionPhasedReleases { get; init; }
#else
        public global::AppStoreConnect.AppStoreVersionPhasedRelease? AppStoreVersionPhasedReleases { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AppStoreVersionPhasedReleases))]
#endif
        public bool IsAppStoreVersionPhasedReleases => AppStoreVersionPhasedReleases != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAppStoreVersionPhasedReleases(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.AppStoreVersionPhasedRelease? value)
        {
            value = AppStoreVersionPhasedReleases;
            return IsAppStoreVersionPhasedReleases;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppStoreVersionPhasedRelease PickAppStoreVersionPhasedReleases() => AppStoreVersionPhasedReleases is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AppStoreVersionPhasedReleases' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.AppStoreVersionSubmission? AppStoreVersionSubmissions { get; init; }
#else
        public global::AppStoreConnect.AppStoreVersionSubmission? AppStoreVersionSubmissions { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AppStoreVersionSubmissions))]
#endif
        public bool IsAppStoreVersionSubmissions => AppStoreVersionSubmissions != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAppStoreVersionSubmissions(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.AppStoreVersionSubmission? value)
        {
            value = AppStoreVersionSubmissions;
            return IsAppStoreVersionSubmissions;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppStoreVersionSubmission PickAppStoreVersionSubmissions() => AppStoreVersionSubmissions is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AppStoreVersionSubmissions' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.App? AppClipDefaultExperiences2 { get; init; }
#else
        public global::AppStoreConnect.App? AppClipDefaultExperiences2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AppClipDefaultExperiences2))]
#endif
        public bool IsAppClipDefaultExperiences2 => AppClipDefaultExperiences2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAppClipDefaultExperiences2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.App? value)
        {
            value = AppClipDefaultExperiences2;
            return IsAppClipDefaultExperiences2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.App PickAppClipDefaultExperiences2() => AppClipDefaultExperiences2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AppClipDefaultExperiences2' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.Build? Builds { get; init; }
#else
        public global::AppStoreConnect.Build? Builds { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Builds))]
#endif
        public bool IsBuilds => Builds != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBuilds(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.Build? value)
        {
            value = Builds;
            return IsBuilds;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.Build PickBuilds() => Builds is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Builds' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.GameCenterAppVersion? GameCenterAppVersions { get; init; }
#else
        public global::AppStoreConnect.GameCenterAppVersion? GameCenterAppVersions { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GameCenterAppVersions))]
#endif
        public bool IsGameCenterAppVersions => GameCenterAppVersions != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickGameCenterAppVersions(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.GameCenterAppVersion? value)
        {
            value = GameCenterAppVersions;
            return IsGameCenterAppVersions;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.GameCenterAppVersion PickGameCenterAppVersions() => GameCenterAppVersions is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'GameCenterAppVersions' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.RoutingAppCoverage? RoutingAppCoverages { get; init; }
#else
        public global::AppStoreConnect.RoutingAppCoverage? RoutingAppCoverages { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RoutingAppCoverages))]
#endif
        public bool IsRoutingAppCoverages => RoutingAppCoverages != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickRoutingAppCoverages(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.RoutingAppCoverage? value)
        {
            value = RoutingAppCoverages;
            return IsRoutingAppCoverages;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.RoutingAppCoverage PickRoutingAppCoverages() => RoutingAppCoverages is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'RoutingAppCoverages' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem47(global::AppStoreConnect.AlternativeDistributionPackage value) => new IncludedItem47((global::AppStoreConnect.AlternativeDistributionPackage?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AlternativeDistributionPackage?(IncludedItem47 @this) => @this.AlternativeDistributionPackages;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem47(global::AppStoreConnect.AlternativeDistributionPackage? value)
        {
            AlternativeDistributionPackages = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem47 FromAlternativeDistributionPackages(global::AppStoreConnect.AlternativeDistributionPackage? value) => new IncludedItem47(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem47(global::AppStoreConnect.AppClipDefaultExperience value) => new IncludedItem47((global::AppStoreConnect.AppClipDefaultExperience?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppClipDefaultExperience?(IncludedItem47 @this) => @this.AppClipDefaultExperiences1;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem47(global::AppStoreConnect.AppClipDefaultExperience? value)
        {
            AppClipDefaultExperiences1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem47 FromAppClipDefaultExperiences1(global::AppStoreConnect.AppClipDefaultExperience? value) => new IncludedItem47(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem47(global::AppStoreConnect.AppStoreReviewDetail value) => new IncludedItem47((global::AppStoreConnect.AppStoreReviewDetail?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppStoreReviewDetail?(IncludedItem47 @this) => @this.AppStoreReviewDetails;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem47(global::AppStoreConnect.AppStoreReviewDetail? value)
        {
            AppStoreReviewDetails = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem47 FromAppStoreReviewDetails(global::AppStoreConnect.AppStoreReviewDetail? value) => new IncludedItem47(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem47(global::AppStoreConnect.AppStoreVersionExperiment value) => new IncludedItem47((global::AppStoreConnect.AppStoreVersionExperiment?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppStoreVersionExperiment?(IncludedItem47 @this) => @this.AppStoreVersionExperiments;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem47(global::AppStoreConnect.AppStoreVersionExperiment? value)
        {
            AppStoreVersionExperiments = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem47 FromAppStoreVersionExperiments(global::AppStoreConnect.AppStoreVersionExperiment? value) => new IncludedItem47(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem47(global::AppStoreConnect.AppStoreVersionLocalization value) => new IncludedItem47((global::AppStoreConnect.AppStoreVersionLocalization?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppStoreVersionLocalization?(IncludedItem47 @this) => @this.AppStoreVersionLocalizations;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem47(global::AppStoreConnect.AppStoreVersionLocalization? value)
        {
            AppStoreVersionLocalizations = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem47 FromAppStoreVersionLocalizations(global::AppStoreConnect.AppStoreVersionLocalization? value) => new IncludedItem47(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem47(global::AppStoreConnect.AppStoreVersionPhasedRelease value) => new IncludedItem47((global::AppStoreConnect.AppStoreVersionPhasedRelease?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppStoreVersionPhasedRelease?(IncludedItem47 @this) => @this.AppStoreVersionPhasedReleases;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem47(global::AppStoreConnect.AppStoreVersionPhasedRelease? value)
        {
            AppStoreVersionPhasedReleases = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem47 FromAppStoreVersionPhasedReleases(global::AppStoreConnect.AppStoreVersionPhasedRelease? value) => new IncludedItem47(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem47(global::AppStoreConnect.AppStoreVersionSubmission value) => new IncludedItem47((global::AppStoreConnect.AppStoreVersionSubmission?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppStoreVersionSubmission?(IncludedItem47 @this) => @this.AppStoreVersionSubmissions;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem47(global::AppStoreConnect.AppStoreVersionSubmission? value)
        {
            AppStoreVersionSubmissions = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem47 FromAppStoreVersionSubmissions(global::AppStoreConnect.AppStoreVersionSubmission? value) => new IncludedItem47(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem47(global::AppStoreConnect.App value) => new IncludedItem47((global::AppStoreConnect.App?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.App?(IncludedItem47 @this) => @this.AppClipDefaultExperiences2;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem47(global::AppStoreConnect.App? value)
        {
            AppClipDefaultExperiences2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem47 FromAppClipDefaultExperiences2(global::AppStoreConnect.App? value) => new IncludedItem47(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem47(global::AppStoreConnect.Build value) => new IncludedItem47((global::AppStoreConnect.Build?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.Build?(IncludedItem47 @this) => @this.Builds;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem47(global::AppStoreConnect.Build? value)
        {
            Builds = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem47 FromBuilds(global::AppStoreConnect.Build? value) => new IncludedItem47(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem47(global::AppStoreConnect.GameCenterAppVersion value) => new IncludedItem47((global::AppStoreConnect.GameCenterAppVersion?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterAppVersion?(IncludedItem47 @this) => @this.GameCenterAppVersions;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem47(global::AppStoreConnect.GameCenterAppVersion? value)
        {
            GameCenterAppVersions = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem47 FromGameCenterAppVersions(global::AppStoreConnect.GameCenterAppVersion? value) => new IncludedItem47(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem47(global::AppStoreConnect.RoutingAppCoverage value) => new IncludedItem47((global::AppStoreConnect.RoutingAppCoverage?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.RoutingAppCoverage?(IncludedItem47 @this) => @this.RoutingAppCoverages;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem47(global::AppStoreConnect.RoutingAppCoverage? value)
        {
            RoutingAppCoverages = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem47 FromRoutingAppCoverages(global::AppStoreConnect.RoutingAppCoverage? value) => new IncludedItem47(value);

        /// <summary>
        ///
        /// </summary>
        public IncludedItem47(
            global::AppStoreConnect.AppStoreVersionResponseIncludedItemDiscriminatorType? type,
            global::AppStoreConnect.AlternativeDistributionPackage? alternativeDistributionPackages,
            global::AppStoreConnect.AppClipDefaultExperience? appClipDefaultExperiences1,
            global::AppStoreConnect.AppStoreReviewDetail? appStoreReviewDetails,
            global::AppStoreConnect.AppStoreVersionExperiment? appStoreVersionExperiments,
            global::AppStoreConnect.AppStoreVersionLocalization? appStoreVersionLocalizations,
            global::AppStoreConnect.AppStoreVersionPhasedRelease? appStoreVersionPhasedReleases,
            global::AppStoreConnect.AppStoreVersionSubmission? appStoreVersionSubmissions,
            global::AppStoreConnect.App? appClipDefaultExperiences2,
            global::AppStoreConnect.Build? builds,
            global::AppStoreConnect.GameCenterAppVersion? gameCenterAppVersions,
            global::AppStoreConnect.RoutingAppCoverage? routingAppCoverages
            )
        {
            Type = type;

            AlternativeDistributionPackages = alternativeDistributionPackages;
            AppClipDefaultExperiences1 = appClipDefaultExperiences1;
            AppStoreReviewDetails = appStoreReviewDetails;
            AppStoreVersionExperiments = appStoreVersionExperiments;
            AppStoreVersionLocalizations = appStoreVersionLocalizations;
            AppStoreVersionPhasedReleases = appStoreVersionPhasedReleases;
            AppStoreVersionSubmissions = appStoreVersionSubmissions;
            AppClipDefaultExperiences2 = appClipDefaultExperiences2;
            Builds = builds;
            GameCenterAppVersions = gameCenterAppVersions;
            RoutingAppCoverages = routingAppCoverages;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            RoutingAppCoverages as object ??
            GameCenterAppVersions as object ??
            Builds as object ??
            AppClipDefaultExperiences2 as object ??
            AppStoreVersionSubmissions as object ??
            AppStoreVersionPhasedReleases as object ??
            AppStoreVersionLocalizations as object ??
            AppStoreVersionExperiments as object ??
            AppStoreReviewDetails as object ??
            AppClipDefaultExperiences1 as object ??
            AlternativeDistributionPackages as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            AlternativeDistributionPackages?.ToString() ??
            AppClipDefaultExperiences1?.ToString() ??
            AppStoreReviewDetails?.ToString() ??
            AppStoreVersionExperiments?.ToString() ??
            AppStoreVersionLocalizations?.ToString() ??
            AppStoreVersionPhasedReleases?.ToString() ??
            AppStoreVersionSubmissions?.ToString() ??
            AppClipDefaultExperiences2?.ToString() ??
            Builds?.ToString() ??
            GameCenterAppVersions?.ToString() ??
            RoutingAppCoverages?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsAlternativeDistributionPackages && !IsAppClipDefaultExperiences1 && !IsAppStoreReviewDetails && !IsAppStoreVersionExperiments && !IsAppStoreVersionLocalizations && !IsAppStoreVersionPhasedReleases && !IsAppStoreVersionSubmissions && !IsAppClipDefaultExperiences2 && !IsBuilds && !IsGameCenterAppVersions && !IsRoutingAppCoverages || !IsAlternativeDistributionPackages && IsAppClipDefaultExperiences1 && !IsAppStoreReviewDetails && !IsAppStoreVersionExperiments && !IsAppStoreVersionLocalizations && !IsAppStoreVersionPhasedReleases && !IsAppStoreVersionSubmissions && !IsAppClipDefaultExperiences2 && !IsBuilds && !IsGameCenterAppVersions && !IsRoutingAppCoverages || !IsAlternativeDistributionPackages && !IsAppClipDefaultExperiences1 && IsAppStoreReviewDetails && !IsAppStoreVersionExperiments && !IsAppStoreVersionLocalizations && !IsAppStoreVersionPhasedReleases && !IsAppStoreVersionSubmissions && !IsAppClipDefaultExperiences2 && !IsBuilds && !IsGameCenterAppVersions && !IsRoutingAppCoverages || !IsAlternativeDistributionPackages && !IsAppClipDefaultExperiences1 && !IsAppStoreReviewDetails && IsAppStoreVersionExperiments && !IsAppStoreVersionLocalizations && !IsAppStoreVersionPhasedReleases && !IsAppStoreVersionSubmissions && !IsAppClipDefaultExperiences2 && !IsBuilds && !IsGameCenterAppVersions && !IsRoutingAppCoverages || !IsAlternativeDistributionPackages && !IsAppClipDefaultExperiences1 && !IsAppStoreReviewDetails && !IsAppStoreVersionExperiments && IsAppStoreVersionLocalizations && !IsAppStoreVersionPhasedReleases && !IsAppStoreVersionSubmissions && !IsAppClipDefaultExperiences2 && !IsBuilds && !IsGameCenterAppVersions && !IsRoutingAppCoverages || !IsAlternativeDistributionPackages && !IsAppClipDefaultExperiences1 && !IsAppStoreReviewDetails && !IsAppStoreVersionExperiments && !IsAppStoreVersionLocalizations && IsAppStoreVersionPhasedReleases && !IsAppStoreVersionSubmissions && !IsAppClipDefaultExperiences2 && !IsBuilds && !IsGameCenterAppVersions && !IsRoutingAppCoverages || !IsAlternativeDistributionPackages && !IsAppClipDefaultExperiences1 && !IsAppStoreReviewDetails && !IsAppStoreVersionExperiments && !IsAppStoreVersionLocalizations && !IsAppStoreVersionPhasedReleases && IsAppStoreVersionSubmissions && !IsAppClipDefaultExperiences2 && !IsBuilds && !IsGameCenterAppVersions && !IsRoutingAppCoverages || !IsAlternativeDistributionPackages && !IsAppClipDefaultExperiences1 && !IsAppStoreReviewDetails && !IsAppStoreVersionExperiments && !IsAppStoreVersionLocalizations && !IsAppStoreVersionPhasedReleases && !IsAppStoreVersionSubmissions && IsAppClipDefaultExperiences2 && !IsBuilds && !IsGameCenterAppVersions && !IsRoutingAppCoverages || !IsAlternativeDistributionPackages && !IsAppClipDefaultExperiences1 && !IsAppStoreReviewDetails && !IsAppStoreVersionExperiments && !IsAppStoreVersionLocalizations && !IsAppStoreVersionPhasedReleases && !IsAppStoreVersionSubmissions && !IsAppClipDefaultExperiences2 && IsBuilds && !IsGameCenterAppVersions && !IsRoutingAppCoverages || !IsAlternativeDistributionPackages && !IsAppClipDefaultExperiences1 && !IsAppStoreReviewDetails && !IsAppStoreVersionExperiments && !IsAppStoreVersionLocalizations && !IsAppStoreVersionPhasedReleases && !IsAppStoreVersionSubmissions && !IsAppClipDefaultExperiences2 && !IsBuilds && IsGameCenterAppVersions && !IsRoutingAppCoverages || !IsAlternativeDistributionPackages && !IsAppClipDefaultExperiences1 && !IsAppStoreReviewDetails && !IsAppStoreVersionExperiments && !IsAppStoreVersionLocalizations && !IsAppStoreVersionPhasedReleases && !IsAppStoreVersionSubmissions && !IsAppClipDefaultExperiences2 && !IsBuilds && !IsGameCenterAppVersions && IsRoutingAppCoverages;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AppStoreConnect.AlternativeDistributionPackage, TResult>? alternativeDistributionPackages = null,
            global::System.Func<global::AppStoreConnect.AppClipDefaultExperience, TResult>? appClipDefaultExperiences1 = null,
            global::System.Func<global::AppStoreConnect.AppStoreReviewDetail, TResult>? appStoreReviewDetails = null,
            global::System.Func<global::AppStoreConnect.AppStoreVersionExperiment, TResult>? appStoreVersionExperiments = null,
            global::System.Func<global::AppStoreConnect.AppStoreVersionLocalization, TResult>? appStoreVersionLocalizations = null,
            global::System.Func<global::AppStoreConnect.AppStoreVersionPhasedRelease, TResult>? appStoreVersionPhasedReleases = null,
            global::System.Func<global::AppStoreConnect.AppStoreVersionSubmission, TResult>? appStoreVersionSubmissions = null,
            global::System.Func<global::AppStoreConnect.App, TResult>? appClipDefaultExperiences2 = null,
            global::System.Func<global::AppStoreConnect.Build, TResult>? builds = null,
            global::System.Func<global::AppStoreConnect.GameCenterAppVersion, TResult>? gameCenterAppVersions = null,
            global::System.Func<global::AppStoreConnect.RoutingAppCoverage, TResult>? routingAppCoverages = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (AlternativeDistributionPackages is { } __value0 && alternativeDistributionPackages != null)
            {
                return alternativeDistributionPackages(__value0);
            }
            else if (AppClipDefaultExperiences1 is { } __value1 && appClipDefaultExperiences1 != null)
            {
                return appClipDefaultExperiences1(__value1);
            }
            else if (AppStoreReviewDetails is { } __value2 && appStoreReviewDetails != null)
            {
                return appStoreReviewDetails(__value2);
            }
            else if (AppStoreVersionExperiments is { } __value3 && appStoreVersionExperiments != null)
            {
                return appStoreVersionExperiments(__value3);
            }
            else if (AppStoreVersionLocalizations is { } __value4 && appStoreVersionLocalizations != null)
            {
                return appStoreVersionLocalizations(__value4);
            }
            else if (AppStoreVersionPhasedReleases is { } __value5 && appStoreVersionPhasedReleases != null)
            {
                return appStoreVersionPhasedReleases(__value5);
            }
            else if (AppStoreVersionSubmissions is { } __value6 && appStoreVersionSubmissions != null)
            {
                return appStoreVersionSubmissions(__value6);
            }
            else if (AppClipDefaultExperiences2 is { } __value7 && appClipDefaultExperiences2 != null)
            {
                return appClipDefaultExperiences2(__value7);
            }
            else if (Builds is { } __value8 && builds != null)
            {
                return builds(__value8);
            }
            else if (GameCenterAppVersions is { } __value9 && gameCenterAppVersions != null)
            {
                return gameCenterAppVersions(__value9);
            }
            else if (RoutingAppCoverages is { } __value10 && routingAppCoverages != null)
            {
                return routingAppCoverages(__value10);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::AppStoreConnect.AlternativeDistributionPackage>? alternativeDistributionPackages = null,

            global::System.Action<global::AppStoreConnect.AppClipDefaultExperience>? appClipDefaultExperiences1 = null,

            global::System.Action<global::AppStoreConnect.AppStoreReviewDetail>? appStoreReviewDetails = null,

            global::System.Action<global::AppStoreConnect.AppStoreVersionExperiment>? appStoreVersionExperiments = null,

            global::System.Action<global::AppStoreConnect.AppStoreVersionLocalization>? appStoreVersionLocalizations = null,

            global::System.Action<global::AppStoreConnect.AppStoreVersionPhasedRelease>? appStoreVersionPhasedReleases = null,

            global::System.Action<global::AppStoreConnect.AppStoreVersionSubmission>? appStoreVersionSubmissions = null,

            global::System.Action<global::AppStoreConnect.App>? appClipDefaultExperiences2 = null,

            global::System.Action<global::AppStoreConnect.Build>? builds = null,

            global::System.Action<global::AppStoreConnect.GameCenterAppVersion>? gameCenterAppVersions = null,

            global::System.Action<global::AppStoreConnect.RoutingAppCoverage>? routingAppCoverages = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (AlternativeDistributionPackages is { } __value0)
            {
                alternativeDistributionPackages?.Invoke(__value0);
            }
            else if (AppClipDefaultExperiences1 is { } __value1)
            {
                appClipDefaultExperiences1?.Invoke(__value1);
            }
            else if (AppStoreReviewDetails is { } __value2)
            {
                appStoreReviewDetails?.Invoke(__value2);
            }
            else if (AppStoreVersionExperiments is { } __value3)
            {
                appStoreVersionExperiments?.Invoke(__value3);
            }
            else if (AppStoreVersionLocalizations is { } __value4)
            {
                appStoreVersionLocalizations?.Invoke(__value4);
            }
            else if (AppStoreVersionPhasedReleases is { } __value5)
            {
                appStoreVersionPhasedReleases?.Invoke(__value5);
            }
            else if (AppStoreVersionSubmissions is { } __value6)
            {
                appStoreVersionSubmissions?.Invoke(__value6);
            }
            else if (AppClipDefaultExperiences2 is { } __value7)
            {
                appClipDefaultExperiences2?.Invoke(__value7);
            }
            else if (Builds is { } __value8)
            {
                builds?.Invoke(__value8);
            }
            else if (GameCenterAppVersions is { } __value9)
            {
                gameCenterAppVersions?.Invoke(__value9);
            }
            else if (RoutingAppCoverages is { } __value10)
            {
                routingAppCoverages?.Invoke(__value10);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::AppStoreConnect.AlternativeDistributionPackage>? alternativeDistributionPackages = null,
            global::System.Action<global::AppStoreConnect.AppClipDefaultExperience>? appClipDefaultExperiences1 = null,
            global::System.Action<global::AppStoreConnect.AppStoreReviewDetail>? appStoreReviewDetails = null,
            global::System.Action<global::AppStoreConnect.AppStoreVersionExperiment>? appStoreVersionExperiments = null,
            global::System.Action<global::AppStoreConnect.AppStoreVersionLocalization>? appStoreVersionLocalizations = null,
            global::System.Action<global::AppStoreConnect.AppStoreVersionPhasedRelease>? appStoreVersionPhasedReleases = null,
            global::System.Action<global::AppStoreConnect.AppStoreVersionSubmission>? appStoreVersionSubmissions = null,
            global::System.Action<global::AppStoreConnect.App>? appClipDefaultExperiences2 = null,
            global::System.Action<global::AppStoreConnect.Build>? builds = null,
            global::System.Action<global::AppStoreConnect.GameCenterAppVersion>? gameCenterAppVersions = null,
            global::System.Action<global::AppStoreConnect.RoutingAppCoverage>? routingAppCoverages = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (AlternativeDistributionPackages is { } __value0)
            {
                alternativeDistributionPackages?.Invoke(__value0);
            }
            else if (AppClipDefaultExperiences1 is { } __value1)
            {
                appClipDefaultExperiences1?.Invoke(__value1);
            }
            else if (AppStoreReviewDetails is { } __value2)
            {
                appStoreReviewDetails?.Invoke(__value2);
            }
            else if (AppStoreVersionExperiments is { } __value3)
            {
                appStoreVersionExperiments?.Invoke(__value3);
            }
            else if (AppStoreVersionLocalizations is { } __value4)
            {
                appStoreVersionLocalizations?.Invoke(__value4);
            }
            else if (AppStoreVersionPhasedReleases is { } __value5)
            {
                appStoreVersionPhasedReleases?.Invoke(__value5);
            }
            else if (AppStoreVersionSubmissions is { } __value6)
            {
                appStoreVersionSubmissions?.Invoke(__value6);
            }
            else if (AppClipDefaultExperiences2 is { } __value7)
            {
                appClipDefaultExperiences2?.Invoke(__value7);
            }
            else if (Builds is { } __value8)
            {
                builds?.Invoke(__value8);
            }
            else if (GameCenterAppVersions is { } __value9)
            {
                gameCenterAppVersions?.Invoke(__value9);
            }
            else if (RoutingAppCoverages is { } __value10)
            {
                routingAppCoverages?.Invoke(__value10);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AlternativeDistributionPackages,
                typeof(global::AppStoreConnect.AlternativeDistributionPackage),
                AppClipDefaultExperiences1,
                typeof(global::AppStoreConnect.AppClipDefaultExperience),
                AppStoreReviewDetails,
                typeof(global::AppStoreConnect.AppStoreReviewDetail),
                AppStoreVersionExperiments,
                typeof(global::AppStoreConnect.AppStoreVersionExperiment),
                AppStoreVersionLocalizations,
                typeof(global::AppStoreConnect.AppStoreVersionLocalization),
                AppStoreVersionPhasedReleases,
                typeof(global::AppStoreConnect.AppStoreVersionPhasedRelease),
                AppStoreVersionSubmissions,
                typeof(global::AppStoreConnect.AppStoreVersionSubmission),
                AppClipDefaultExperiences2,
                typeof(global::AppStoreConnect.App),
                Builds,
                typeof(global::AppStoreConnect.Build),
                GameCenterAppVersions,
                typeof(global::AppStoreConnect.GameCenterAppVersion),
                RoutingAppCoverages,
                typeof(global::AppStoreConnect.RoutingAppCoverage),
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
        public bool Equals(IncludedItem47 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AlternativeDistributionPackage?>.Default.Equals(AlternativeDistributionPackages, other.AlternativeDistributionPackages) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppClipDefaultExperience?>.Default.Equals(AppClipDefaultExperiences1, other.AppClipDefaultExperiences1) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppStoreReviewDetail?>.Default.Equals(AppStoreReviewDetails, other.AppStoreReviewDetails) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppStoreVersionExperiment?>.Default.Equals(AppStoreVersionExperiments, other.AppStoreVersionExperiments) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppStoreVersionLocalization?>.Default.Equals(AppStoreVersionLocalizations, other.AppStoreVersionLocalizations) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppStoreVersionPhasedRelease?>.Default.Equals(AppStoreVersionPhasedReleases, other.AppStoreVersionPhasedReleases) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppStoreVersionSubmission?>.Default.Equals(AppStoreVersionSubmissions, other.AppStoreVersionSubmissions) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.App?>.Default.Equals(AppClipDefaultExperiences2, other.AppClipDefaultExperiences2) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.Build?>.Default.Equals(Builds, other.Builds) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterAppVersion?>.Default.Equals(GameCenterAppVersions, other.GameCenterAppVersions) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.RoutingAppCoverage?>.Default.Equals(RoutingAppCoverages, other.RoutingAppCoverages)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(IncludedItem47 obj1, IncludedItem47 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IncludedItem47>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(IncludedItem47 obj1, IncludedItem47 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IncludedItem47 o && Equals(o);
        }
    }
}
