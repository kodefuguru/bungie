namespace Bungie
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Responses;

    public interface IDestinyService
    {
        [Obsolete("Use GetAccountSummary. GetAccount is marked DEPRECATED int the bungie.net platform.")]
        Task<GetAccountResponse> GetAccount(MembershipType membershipType, long membershipId, bool? definitions = null);
        Task<GetAccountSummaryResponse> GetAccountSummary(MembershipType membershipType, long membershipId, bool? definitions = null);
        Task<GetActivitiesResponse> GetActivities(MembershipType membershipType, long membershipId, long characterId, ActivityMode mode, int? count = null, int? page = null, bool? definitions = null);
        Task<GetAdvisorsResponse> GetAdvisors(bool? definitions = null);
        Task<GetAggregateActivityStatsResponse> GetAggregateActivityStats(MembershipType membershipType, long membershipId, long characterId, bool? definitions = null);
        Task<GetCharacterActivitiesResponse> GetCharacterActivities(MembershipType membershipType, long membershipId, long characterId, bool? definitions = null);
        Task<GetCharacterInventoryResponse> GetCharacterInventory(MembershipType membershipType, long membershipId, long characterId, bool? definitions = null);
        Task<GetCharacterProgressionResponse> GetCharacterProgression(MembershipType membershipType, long membershipId, long characterId, bool? definitions = null);
        Task<GetCharacterResponse> GetCharacter(MembershipType membershipType, long membershipId, long characterId, bool? definitions = null);
        Task<GetDefinitionResponse> GetDefinition(DefinitionType type, long id, Unknown version = default(Unknown), bool? definitions = null);
        Task<GetEventsResponse> GetEvents(bool? definitions = null);
        Task<GetExcellenceBadgesResponse> GetExcellenceBadges(MembershipType membershipType, long membershipId, bool? definitions = null);
        Task<GetGrimoireByMembershipResponse> GetGrimoireByMembership(MembershipType membershipType, long membershipId, bool? flavour = null, int? cardId = null, bool? definitions = null);
        Task<GetGrimoireDefinitionResponse> GetGrimoireDefinition();
        Task<GetItemDetailResponse> GetItemDetail(MembershipType membershipType, long membershipId, long characterId, long itemId, bool? definitions = null);
        Task<GetLiveTilesResponse> GetLiveTiles();
        Task<GetManifestResponse> GetManifest();
        Task<long> GetMembershipId(MembershipType membershipType, string displayName, bool? ignoreCase = null);
        Task<GetPostGameCarnageReportResponse> GetPostGameCarnageReport(long activityId, bool? definitions = null);
        Task<GetStatsDefinitionResponse> GetStatsDefinition();
        Task<GetStatsForAccountResponse> GetStatsForAccount(MembershipType membershipType, long membershipId, IEnumerable<StatsGroup> groups = null);
        Task<GetStatsForCharacter> GetStatsForCharacter(MembershipType membershipType, long membershipId, long characterId, PeriodType? periodType = null, IEnumerable<ActivityMode> modes = null, IEnumerable<StatsGroup> groups = null, DateTime? monthStart = null, DateTime? monthEnd = null, DateTime? dayStart = null, DateTime? dayEnd = null);
        Task<GetTriumphsResponse> GetTriumphs(MembershipType membershipType, long membershipId, bool? definitions = null);
        Task<GetUniqueWeaponsStatsResponse> GetUniqueWeaponsStats(MembershipType membershipType, long membershipId, long characterId, bool? definitions = null);
        Task<GetVendorResponse> GetVendor(long vendorId, bool? definitions = null);
        Task<GetVendorWithMetadataResponse> GetVendorWithMetadata(long vendorId, bool? definitions = null);
        Task<GetXurResponse> GetXur(bool? definitions = null);
        Task<SearchItemsResponse> SearchItems(int? count = null, CharacterClass? characterClass = null, IEnumerable<ItemType> types = null, ItemSubtype? subtype = null, Unknown orderStatHash = default(Unknown), Unknown direction = default(Unknown), Rarity? rarity = null, IEnumerable<Bucket> buckets = null, Unknown bucketsOrTypes = default(Unknown), Unknown weaponPerformance = default(Unknown), bool? definitions = null);
        Task<SearchPlayersResponse> SearchPlayers(MembershipType membershipType, string displayName);
        Task<SearchTalentNodeStepsResponse> SearchTalentNodeSteps(int? page = null, int? count = null, string name = null, Unknown direction = default(Unknown), Unknown weaponPerformance = default(Unknown), Unknown impactEffects = default(Unknown), Unknown guardianAttributes = default(Unknown), Unknown lightAbilities = default(Unknown), Unknown damageTypes = default(Unknown), bool? definitions = null);
    }

}