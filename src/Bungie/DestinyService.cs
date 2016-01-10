namespace Bungie
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using BaseJump;
    using Responses;

    [Route("https://www.bungie.net/platform/Destiny")]
    public class DestinyService : BungieService, IDestinyService
    {
        public DestinyService(string apiKey) : base(apiKey)
        {
        }

        /// <summary>
        /// Returns Destiny account information for the supplied membership.
        /// </summary>
        /// <remarks>
        /// http://bungienetplatform.wikia.com/wiki/GetAccount
        /// </remarks>
        [Route("{membershipType}/Account/{membershipId}")]
        [Obsolete("Use GetAccountSummary. GetAccount is marked DEPRECATED int the bungie.net platform.")]
        public async Task<GetAccountResponse> GetAccount(MembershipType membershipType, long membershipId, bool? definitions = null)
        {
            var model = new
            {
                membershipType,
                membershipId,
                definitions
            };

            return await Request<GetAccountResponse>(model);
        }

        /// <summary>
        /// Returns items and character info for a given account.
        /// </summary>
        /// <remarks>
        /// http://bungienetplatform.wikia.com/wiki/GetDestinyAccountSummary
        /// </remarks>
        [Route("{membershipType}/Account/{membershipId}/Summary")]
        public async Task<GetAccountSummaryResponse> GetAccountSummary(MembershipType membershipType, long membershipId, bool? definitions = null)
        {
            var model = new 
            {
                membershipType,
                membershipId,
                definitions
            };

            return await Request<GetAccountSummaryResponse>(model);
        }

        /// <summary>
        /// Returns recent activity history for a given character.
        /// </summary>
        /// <remarks>
        /// http://bungienetplatform.wikia.com/wiki/GetActivityHistory
        /// </remarks>
        [Route("Stats/ActivityHistory/{membershipType}/{membershipId}/{characterId}")]
        public async Task<GetActivitiesResponse> GetActivities(MembershipType membershipType, long membershipId, long characterId, ActivityMode mode, int? count = null, int? page = null, bool? definitions = null)
        {
            var model = new
            {
                membershipType,
                membershipId,
                characterId,
                mode,
                count,
                page,
                definitions
            };

            return await Request<GetActivitiesResponse>(model);
        }

        /// <summary>
        /// Returns information about current daily, weekly and special events.
        /// </summary>
        /// <remarks>
        /// http://bungienetplatform.wikia.com/wiki/GetPublicAdvisors
        /// </remarks>
        [Route("Advisors")]
        public async Task<GetAdvisorsResponse> GetAdvisors(bool? definitions = null)
        {
            var model = new
            {
                definitions
            };

            return await Request<GetAdvisorsResponse>(model);
        }

 
        /// <summary>
        /// Gets all activities the character has participated in together with aggregate statistics for those activities.
        /// </summary>
        /// <remarks>
        /// http://bungienetplatform.wikia.com/wiki/GetDestinyAggregateActivityStats
        /// </remarks>
        [Route("Stats/AggregateActivityStats/{membershipType}/{membershipId}/{characterId}")]
        public async Task<GetAggregateActivityStatsResponse> GetAggregateActivityStats(MembershipType membershipType, long membershipId, long characterId, bool? definitions = null)
        {
            var model = new
            {
                membershipType,
                membershipId,
                characterId,
                definitions
            };

            return await Request<GetAggregateActivityStatsResponse>(model);
        }


        /// <summary>
        /// Returns Destiny character information for the given characterId.
        /// </summary>
        /// <remarks>
        /// http://bungienetplatform.wikia.com/wiki/GetCharacterSummary
        /// </remarks>
        [Route("{membershipType}/Account/{membershipId}/Character/{characterId}")]
        public async Task<GetCharacterResponse> GetCharacter(MembershipType membershipType, long membershipId, long characterId, bool? definitions = null)
        {
            var model = new
            {
                membershipType,
                membershipId,
                characterId,
                definitions
            };

            return await Request<GetCharacterResponse>(model);
        }

        /// <summary>
        /// Returns activity progress for a given character.
        /// </summary>
        /// <remarks>
        /// http://bungienetplatform.wikia.com/wiki/GetCharacterActivities
        /// </remarks>
        [Route("{membershipType}/Account/{membershipId}/Character/{characterId}/Activities")]
        public async Task<GetCharacterActivitiesResponse> GetCharacterActivities(MembershipType membershipType, long membershipId, long characterId, bool? definitions = null)
        {
            var model = new
            {
                membershipType,
                membershipId,
                characterId,
                definitions
            };

            return await Request<GetCharacterActivitiesResponse>(model);
        }

        /// <summary>
        /// Returns the inventory of a Destiny character
        /// </summary>
        /// <remarks>
        /// http://bungienetplatform.wikia.com/wiki/GetCharacterInventory
        /// </remarks>
        [Route("{membershipType}/Account/{membershipId}/Character/{characterId}/Inventory")]
        public async Task<GetCharacterInventoryResponse> GetCharacterInventory(MembershipType membershipType, long membershipId, long characterId, bool? definitions = null)
        {
            var model = new
            {
                membershipType,
                membershipId,
                characterId,
                definitions
            };

            return await Request<GetCharacterInventoryResponse>(model);
        }

        /// <summary>
        /// Returns the inventory summary of a Destiny character
        /// </summary>
        /// <remarks>
        /// https://www.bungie.net/platform/destiny/help/HelpDetail/GET?uri=%7bmembershipType%7d%2fAccount%2f%7bdestinyMembershipId%7d%2fCharacter%2f%7bcharacterId%7d%2fInventory%2fSummary%2f
        /// </remarks>
        [Route("{membershipType}/Account/{membershipId}/Character/{characterId}/Inventory/Summary")]
        public async Task<object> GetCharacterInventorySummary(MembershipType membershipType, long membershipId, long characterId, bool? definitions = null)
        {
            var model = new
            {
                membershipType,
                membershipId,
                characterId,
                definitions
            };

            return await Request<object>(model);
        }

        /// <summary>
        /// Returns progression information for a given Destiny character.
        /// </summary>
        /// <remarks>
        /// http://bungienetplatform.wikia.com/wiki/GetCharacterProgression
        /// </remarks>
        [Route("{membershipType}/Account/{membershipId}/Character/{characterId}/Progression")]
        public async Task<GetCharacterProgressionResponse> GetCharacterProgression(MembershipType membershipType, long membershipId, long characterId, bool? definitions = null)
        {
            var model = new
            {
                membershipType,
                membershipId,
                characterId,
                definitions
            };

            return await Request<GetCharacterProgressionResponse>(model);
        }

        /// <summary>
        /// Returns the specific item from the current manifest.
        /// </summary>
        /// <remarks>
        /// http://bungienetplatform.wikia.com/wiki/GetDestinySingleDefinition
        /// </remarks>
        [Route("Manifest/{type}/{id}")]
        public async Task<GetDefinitionResponse> GetDefinition(DefinitionType type, long id, Unknown version = default(Unknown), bool? definitions = null)
        {
            var model = new
            {
                type,
                id,
                version,
                definitions
            };

            return await Request<GetDefinitionResponse>(model);
        }

        /// <summary>
        /// Returns a list of currently active events.
        /// </summary>
        /// <remarks>
        /// http://bungienetplatform.wikia.com/wiki/GetSpecialEventAdvisors
        /// </remarks>
        [Route("Events")]
        public async Task<GetEventsResponse> GetEvents(bool? definitions = null)
        {
            var model = new
            {
                definitions
            };

            return await Request<GetEventsResponse>(model);
        }

        /// <summary>
        /// Returns Destiny excellence badges for a given account. No longer in use.
        /// </summary>
        /// <remarks>
        /// http://bungienetplatform.wikia.com/wiki/GetExcellenceBadges
        /// </remarks>
        [Route("Stats/GetExcellenceBadges/{membershipType}/{membershipId}")]
        public async Task<GetExcellenceBadgesResponse> GetExcellenceBadges(MembershipType membershipType, long membershipId, bool? definitions = null)
        {
            var model = new
            {
                membershipType,
                membershipId,
                definitions
            };

            return await Request<GetExcellenceBadgesResponse>(model);
        }
      
        /// <summary>
        /// Returns the Grimoire for the currently signed in account.
        /// </summary>
        /// <remarks>
        /// http://bungienetplatform.wikia.com/wiki/GetGrimoireByMembership
        /// </remarks>
        [Route("Vanguard/Grimoire/{membershipType}/{membershipId}")]
        public async Task<GetGrimoireByMembershipResponse> GetGrimoireByMembership(MembershipType membershipType, long membershipId, bool? flavour = null, int? cardId = null, bool? definitions = null)
        {
            var model = new
            {
                membershipType,
                membershipId,
                flavour,
                cardId,
                definitions
            };

            return await Request<GetGrimoireByMembershipResponse>(model);
        }

        /// <summary>
        /// Returns the Grimoire for a given account.
        /// </summary>
        /// <remarks>
        /// http://bungienetplatform.wikia.com/wiki/GetGrimoireDefinition
        /// </remarks>
        [Route("Vanguard/Grimoire/Definition")]
        public async Task<GetGrimoireDefinitionResponse> GetGrimoireDefinition()
        {
            return await Request<GetGrimoireDefinitionResponse>();
        }
         
        /// <summary>
        /// Returns information about a unique item instance associated with a character.
        /// </summary>
        /// <remarks>
        /// http://bungienetplatform.wikia.com/wiki/GetItemDetail
        /// </remarks>
        [Route("{membershipType}/Account/{membershipId}/Character/{characterId}/Inventory/{itemId}")]
        public async Task<GetItemDetailResponse> GetItemDetail(MembershipType membershipType, long membershipId, long characterId, long itemId, bool? definitions = null)
        {
            var model = new
            {
                membershipType,
                membershipId,
                characterId,
                itemId,
                definitions
            };

            return await Request<GetItemDetailResponse>(model);
        }
        
        /// <summary>
        /// Returns a list of tiles used on the Bungie.net website.
        /// </summary>
        /// <remarks>
        /// http://bungienetplatform.wikia.com/wiki/GetDestinyLiveTileContentItems
        /// </remarks>
        [Route("LiveTiles")]
        public async Task<GetLiveTilesResponse> GetLiveTiles()
        {
            return await Request<GetLiveTilesResponse>();
        }

        /// <summary>
        /// Returns the current version of the manifest.
        /// </summary>
        /// <remarks>
        /// http://bungienetplatform.wikia.com/wiki/GetDestinyManifest
        /// </remarks>
        [Route("Manifest")]
        public async Task<GetManifestResponse> GetManifest()
        {
            return await Request<GetManifestResponse>();
        }

        /// <summary>
        /// Returns the numerical id of a player based on their display name, zero if not found.
        /// </summary>
        /// <remarks>
        /// http://bungienetplatform.wikia.com/wiki/GetMembershipIdByDisplayName
        /// </remarks>
        [Route("{membershipType}/Stats/GetMembershipIdByDisplayName/{displayName}")]
        public async Task<long> GetMembershipId(MembershipType membershipType, string displayName, bool? ignoreCase = null)
        {
            var model = new
            {
                membershipType,
                displayName,
                ignoreCase
            };

            return await Request<long>(model);
        }

        /// <summary>
        /// Gets the available post game carnage report for the activity ID.
        /// </summary>
        /// <remarks>
        /// http://bungienetplatform.wikia.com/wiki/GetPostGameCarnageReport
        /// </remarks>
        [Route("Stats/PostGameCarnageReport/{activityId}")]
        public async Task<GetPostGameCarnageReportResponse> GetPostGameCarnageReport(long activityId, bool? definitions = null)
        {
            var model = new
            {
                activityId,
                definitions
            };

            return await Request<GetPostGameCarnageReportResponse>(model);
        }

        /// <summary>
        /// Returns the equivalent of the DestinyHistoricalStatsDefinition with the statId as the key.
        /// </summary>
        /// <remarks>
        /// http://bungienetplatform.wikia.com/wiki/GetHistoricalStatsDefinition
        /// </remarks>
        [Route("Stats/Definition")]
        public async Task<GetStatsDefinitionResponse> GetStatsDefinition()
        {
            return await Request<GetStatsDefinitionResponse>();
        }

        /// <summary>
        /// Gets game stats organized around each character for a given account.
        /// </summary>
        /// <remarks>
        /// http://bungienetplatform.wikia.com/wiki/GetHistoricalStatsForAccount
        /// </remarks>
        [Route("Stats/Account/{membershipType}/{membershipId}")]
        public async Task<GetStatsForAccountResponse> GetStatsForAccount(MembershipType membershipType, long membershipId, IEnumerable<StatsGroup> groups = null)
        {
            var model = new
            {
                membershipType,
                membershipId,
                groups,
            };

            return await Request<GetStatsForAccountResponse>(model);
        }

        /// <summary>
        /// Returns game stats about a given Destiny character.
        /// </summary>
        /// <remarks>
        /// http://bungienetplatform.wikia.com/wiki/GetHistoricalStats
        /// </remarks>
        [Route("Stats/{membershipType}/{membershipId}/{characterId}")]
        public async Task<GetStatsForCharacter> GetStatsForCharacter(MembershipType membershipType, long membershipId, long characterId, PeriodType? periodType = null, IEnumerable<ActivityMode> modes = null, IEnumerable<StatsGroup> groups = null, DateTime? monthStart = null, DateTime? monthEnd = null, DateTime? dayStart = null, DateTime? dayEnd = null)
        {
            var model = new
            {
                membershipType,
                membershipId,
                characterId,
                periodType,
                modes,
                groups,
                monthStart = monthStart.HasValue ? String.Format("{0:yyyy-MM}", monthStart) : null,
                monthEnd = monthEnd.HasValue ? String.Format("{0:yyyy-MM}", monthEnd) : null,
                dayStart = dayStart.HasValue ? String.Format("{0:yyyy-MM-dd}", dayStart) : null,
                dayEnd = dayEnd.HasValue ? String.Format("{0:yyyy-MM-dd}", dayEnd) : null
            };

            return await Request<GetStatsForCharacter>(model);
        }

        /// <summary>
        /// Returns a list of triumph sets for a given account.
        /// </summary>
        /// <remarks>
        /// http://bungienetplatform.wikia.com/wiki/GetTriumphs
        /// </remarks>
        [Route("{membershipType}/Account/{membershipId}/Triumphs")]
        public async Task<GetTriumphsResponse> GetTriumphs(MembershipType membershipType, long membershipId, bool? definitions = null)
        {
            var model = new
            {
                membershipType,
                membershipId,
                definitions
            };

            return await Request<GetTriumphsResponse>(model);
        }

        /// <summary>
        /// Gets details about unique weapon usage, including all exotic weapons.
        /// </summary>
        /// <remarks>
        /// http://bungienetplatform.wikia.com/wiki/GetUniqueWeaponHistory
        /// </remarks>
        [Route("Stats/UniqueWeapons/{membershipType}/{membershipId}/{characterId}")]
        public async Task<GetUniqueWeaponsStatsResponse> GetUniqueWeaponsStats(MembershipType membershipType, long membershipId, long characterId, bool? definitions = null)
        {
            var model = new
            {
                membershipType,
                membershipId,
                characterId,
                definitions
            };

            return await Request<GetUniqueWeaponsStatsResponse>(model);
        }
       
        /// <summary>
        /// Returns information for a given Vendor.
        /// </summary>
        /// <remarks>
        /// http://bungienetplatform.wikia.com/wiki/GetPublicVendor
        /// </remarks>
        [Route("Vendors/{vendorId}")]
        public async Task<GetVendorResponse> GetVendor(long vendorId, bool? definitions = null)
        {
            var model = new
            {
                vendorId,
                definitions
            };

            return await Request<GetVendorResponse>(model);
        }

        /// <summary>
        /// Returns information for a given Vendor, with metadata.
        /// </summary>
        /// <remarks>
        /// http://bungienetplatform.wikia.com/wiki/GetPublicVendorWithMetadata
        /// </remarks>
        [Route("Vendors/{vendorId}/Metadata")]
        public async Task<GetVendorWithMetadataResponse> GetVendorWithMetadata(long vendorId, bool? definitions = null)
        {
            var model = new
            {
                vendorId,
                definitions
            };

            return await Request<GetVendorWithMetadataResponse>(model);
        }
     
      
        /// <summary>
        /// Returns advisor information about the vendor Xur in Destiny.
        /// </summary>
        /// <remarks>
        /// http://bungienetplatform.wikia.com/wiki/GetPublicXurVendor
        /// </remarks>
        /// <returns>Vendor object or null if Xur is unavailable.</returns>
        [Route("Advisors/Xur")]
        public async Task<GetXurResponse> GetXur(bool? definitions = null)
        {
            var model = new
            {
                definitions
            };

            return await Request<GetXurResponse>(model);
        }

        /// <summary>
        /// Gets a paged list of Destiny items.
        /// </summary>
        /// <remarks>
        /// https://www.bungie.net/platform/destiny/help/HelpDetail/GET?uri=Explorer%2fItems%2f
        /// </remarks>
        /// <param name="impactEffects">Items must have node steps in one of these categories, omit for all items. ArmorPiercing, Ricochet, Flinch, CollateralDamage, Disorient, HighlightTarget</param>
        /// <param name="guardianAttributes">Items must have node steps in one of these categories, omit for all items. Stats, Shields, Health, Revive, AimUnderFire, Radar, Invisibility, Reputations</param>
        /// <param name="lightAbilities">Items must have node steps in one of these categories, omit for all items. Grenades, Melee, MovementModes, Orbs, SuperEnergy, SuperMods</param>
        /// <param name="damageTypes">Items must have node steps in one of these categories, omit for all items. Kinetic, Arc, Solar, Void</param>
        /// <param name="sourcecat">Items must drop from the specified source category, omit for all items. Use Vendor or Activity.</param>
        /// <param name="sourcehash">Items must drop from the specified source, omit for all items. Overrides sourcecat.</param>
        /// <param name="matchrandomsteps">True if the supplied groups/step hash filters should match random node steps. False indicates the item can always get the step before it is considered a match.</param>
        /// <param name="definitions">Indicates the item definitions should be returned with item hash results.</param>
        /// <param name="categories">Category identifiers. Only items that are in all of the passed-in categories will be returned.</param>
        /// <param name="order">Item property used for sorting. Use Name, ItemType, Rarity, ItemTypeName, ItemStatHash, MinimumRequiredLevel, MaximumRequiredLevel.</param>
        /// <param name="weaponPerformance">Items must have node steps in one of these categories, omit for all items. RateOfFire, Damage, Accuracy, Range, Zoom, Recoil, Ready, Reload, HairTrigger, AmmoAndMagazine, TrackingAndDetonation, ShotgunSpread, ChargeTime</param>
        /// <param name="rarity">Rarity of items to return: Currency, Basic, Common, Rare, Superior, Exotic. Omit for all items.</param>
        /// <param name="page">Page number to return, starting with 0.</param>
        /// <param name="name">Name of items to return (partial match, no case). Omit for all items.</param>
        /// <param name="count">Number of rows to return. Use 10, 25, 50, 100, or 500.</param>
        /// <param name="orderstathash">This value is used when the order parameter is set to ItemStatHash. The item stat for the provided hash value will be used in the sort.</param>
        /// <param name="direction">Order to sort items: Ascending or Descending</param>
        /// <param name="step">Hash ID of the talent node step that an item must have in order to be returned.</param>
        [Route("Explorer/Items")]
        public async Task<SearchItemsResponse> SearchItems(ImpactEffect? impactEffects = null, GuardianAttribute? guardianAttributes = null, LightAbility? lightAbilities = null, DamageType? damageTypes = null, SourceCategory? sourcecat = null, long? sourcehash = null, bool? matchrandomsteps = null, bool? definitions = null, long? categories = null, SortOrder? order = null, WeaponPerformance? weaponPerformance = null, Rarity? rarity = null, int? page = null, string name = null, Count? count = null, bool? orderstathash = null, SortDirection? direction = null, long? step = null)
        {
            var model = new
            {
                impactEffects,
                guardianAttributes,
                lightAbilities,
                damageTypes,
                sourcecat,
                sourcehash,
                matchrandomsteps,
                definitions,
                categories,
                order,
                weaponPerformance,
                rarity,
                page,
                name,
                count,
                orderstathash,
                direction,
                step
            };

            return await Request<SearchItemsResponse>(model);
        }

        /// <summary>
        /// Returns a list of players by username and platform.
        /// </summary>
        /// <remarks>
        /// http://bungienetplatform.wikia.com/wiki/SearchDestinyPlayer
        /// </remarks>
        [Route("SearchDestinyPlayer/{membershipType}/{displayName}")]
        public async Task<SearchPlayersResponse> SearchPlayers(MembershipType membershipType, string displayName)
        {
            var model = new
            {
                membershipType,
                displayName
            };

            return await Request<SearchPlayersResponse>(model);
        }

        /// <summary>
        /// Advanced search for TalentNodes.
        /// </summary>
        /// <remarks>
        /// http://bungienetplatform.wikia.com/wiki/GetDestinyExplorerTalentNodeSteps
        /// </remarks>
        [Route("Explorer/TalentNodeSteps")]
        public async Task<SearchTalentNodeStepsResponse> SearchTalentNodeSteps(int? page = null, int? count = null, string name = null, Unknown direction = default(Unknown), Unknown weaponPerformance = default(Unknown), Unknown impactEffects = default(Unknown), Unknown guardianAttributes = default(Unknown), Unknown lightAbilities = default(Unknown), Unknown damageTypes = default(Unknown), bool? definitions = null)
        {
            var model = new
            {
                page,
                count,
                name,
                direction,
                weaponPerformance,
                impactEffects,
                guardianAttributes,
                lightAbilities,
                definitions
            };

            return await Request<SearchTalentNodeStepsResponse>(model);
        }      
    }
}
