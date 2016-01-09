namespace Bungie.Tests
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using MbUnit.Framework;
    using FluentAssertions;
    using Newtonsoft.Json;
    using Responses;
    using Wrappers;

    public class ModelSerializationTests
    {
        private string Read(string name)
        {
            var assembly = Assembly.GetExecutingAssembly();
            using (var stream = assembly.GetManifestResourceStream(String.Format("Bungie.Tests.Responses.{0}.json", name)))
            using (var reader = new StreamReader(stream))
            {
                return reader.ReadToEnd();
            }
        }

        private T Deserialize<T>([CallerMemberName] string name = null)
        {
            return JsonConvert.DeserializeObject<Message<T>>(Read(name)).Response;
        }

        [Test]
        public void GetAccount()
        {
            var result = Deserialize<GetAccountResponse>();
            result.Should().NotBeNull();
            result.Account.Should().NotBeNull();
            result.Account.MembershipId.Should().Be("4611686018432640426");
            result.Account.ClanName.Should().Be("Death By Pirate");
            result.Definitions.Buckets.Should().NotBeEmpty();
            result.Definitions.Classes.Should().NotBeEmpty();
            result.Definitions.DamageTypes.Should().NotBeEmpty();
            result.Definitions.Genders.Should().NotBeEmpty();
            result.Definitions.Items.Should().NotBeEmpty();
            result.Definitions.ItemCategories.Should().NotBeEmpty();
            result.Definitions.Perks.Should().NotBeEmpty();
            result.Definitions.Progressions.Should().NotBeEmpty();
            result.Definitions.Races.Should().NotBeEmpty();
            result.Definitions.Sources.Should().NotBeEmpty();
            result.Definitions.StatGroups.Should().NotBeEmpty();
            result.Definitions.Stats.Should().NotBeEmpty();
            result.Definitions.TalentGrids.Should().NotBeEmpty();
        }

        [Test]
        public void GetAccountSummary()
        {
            var result = Deserialize<GetAccountSummaryResponse>();
            result.AccountSummary.Should().NotBeNull();
            result.AccountSummary.MembershipId.Should().Be("4611686018432640426");
            result.AccountSummary.ClanName.Should().Be("Death By Pirate");
            result.Definitions.Buckets.Should().NotBeEmpty();
            result.Definitions.Classes.Should().NotBeEmpty();
            result.Definitions.DamageTypes.Should().NotBeEmpty();
            result.Definitions.Genders.Should().NotBeEmpty();
            result.Definitions.Items.Should().NotBeEmpty();
            result.Definitions.ItemCategories.Should().NotBeEmpty();
            result.Definitions.Perks.Should().NotBeEmpty();
            result.Definitions.Progressions.Should().NotBeEmpty();
            result.Definitions.Races.Should().NotBeEmpty();
            result.Definitions.Sources.Should().NotBeEmpty();
            result.Definitions.StatGroups.Should().NotBeEmpty();
            result.Definitions.Stats.Should().NotBeEmpty();
            result.Definitions.TalentGrids.Should().NotBeEmpty();
        }

        [Test]
        public void GetActivities()
        {
            var result = Deserialize<GetActivitiesResponse>();
            result.Should().NotBeNull();
            result.Data.Should().NotBeNull();
            result.Data.Activities.Should().NotBeNull();
            result.Data.Activities.Should().NotBeEmpty();
            result.Definitions.Activities.Should().NotBeEmpty();
            result.Definitions.ActivityTypes.Should().NotBeEmpty();
            result.Definitions.Buckets.Should().NotBeEmpty();
            result.Definitions.Destinations.Should().NotBeEmpty();
            result.Definitions.Items.Should().NotBeEmpty();
            result.Definitions.Places.Should().NotBeEmpty();
        }

        [Test]
        public void GetAdvisors()
        {
            var result = Deserialize<GetAdvisorsResponse>();
            result.Should().NotBeNull();
            result.Advisors.Should().NotBeNull();
            result.Definitions.Should().NotBeNull();
            result.Definitions.Activities.Should().NotBeEmpty();
            result.Definitions.ActivityTypes.Should().NotBeEmpty();
            result.Definitions.ActivityBundles.Should().NotBeEmpty();
            result.Definitions.Buckets.Should().NotBeEmpty();
            result.Definitions.DamageTypes.Should().NotBeEmpty();
            result.Definitions.Destinations.Should().NotBeEmpty();
            result.Definitions.EnemyRaces.Should().NotBeEmpty();
            result.Definitions.Factions.Should().NotBeEmpty();
            result.Definitions.Flags.Should().NotBeEmpty();
            result.Definitions.Items.Should().NotBeEmpty();
            result.Definitions.ItemCategories.Should().NotBeEmpty();
            result.Definitions.Objectives.Should().NotBeEmpty();
            result.Definitions.Perks.Should().NotBeEmpty();
            result.Definitions.Places.Should().NotBeEmpty();
            result.Definitions.Progressions.Should().NotBeEmpty();
            result.Definitions.ScriptedSkulls.Should().NotBeEmpty();
            result.Definitions.Sources.Should().NotBeEmpty();
            result.Definitions.StatGroups.Should().NotBeEmpty();
            result.Definitions.Stats.Should().NotBeEmpty();
            result.Definitions.TalentGrids.Should().NotBeEmpty();
            result.Definitions.VendorDetails.Should().NotBeEmpty();
            result.Definitions.VendorCategories.Should().NotBeEmpty();
        }

        [Test]
        public void GetAggregateActivityStats()
        {
            var result = Deserialize<GetAggregateActivityStatsResponse>();
            result.Should().NotBeNull();
            result.AggregateActivityStats.Should().NotBeNull();
            result.Definitions.Activities.Should().NotBeEmpty();
            result.Definitions.ActivityTypes.Should().NotBeEmpty();
            result.Definitions.Buckets.Should().NotBeEmpty();
            result.Definitions.Destinations.Should().NotBeEmpty();
            result.Definitions.Items.Should().NotBeEmpty();
            result.Definitions.ItemCategories.Should().NotBeEmpty();
            result.Definitions.Places.Should().NotBeEmpty();
            result.Definitions.Sources.Should().NotBeEmpty();
        }

        [Test]
        public void GetCharacterActivities()
        {
            var result = Deserialize<GetCharacterActivitiesResponse>();
            result.Should().NotBeNull();
            result.CharacterActivities.Should().NotBeNull();
            result.Definitions.Activities.Should().NotBeEmpty();
            result.Definitions.ActivityTypes.Should().NotBeEmpty();
            result.Definitions.ActivityBundles.Should().BeEmpty();
            result.Definitions.Books.Should().BeEmpty();
            result.Definitions.Buckets.Should().NotBeEmpty();
            result.Definitions.Classes.Should().BeEmpty();
            result.Definitions.DamageTypes.Should().BeEmpty();
            result.Definitions.Destinations.Should().NotBeEmpty();
            result.Definitions.EnemyRaces.Should().BeEmpty();
            result.Definitions.Events.Should().BeEmpty();
            result.Definitions.Factions.Should().BeEmpty();
            result.Definitions.Flags.Should().BeEmpty();
            result.Definitions.Genders.Should().BeEmpty();
            result.Definitions.Items.Should().NotBeEmpty();
            result.Definitions.ItemCategories.Should().NotBeEmpty();
            result.Definitions.Locations.Should().BeEmpty();
            result.Definitions.MaterialRequirements.Should().BeEmpty();
            result.Definitions.Objectives.Should().BeEmpty();
            result.Definitions.Perks.Should().BeEmpty();
            result.Definitions.Places.Should().NotBeEmpty();
            result.Definitions.Progressions.Should().BeEmpty();
            result.Definitions.ProgressionMappings.Should().BeEmpty();
            result.Definitions.Races.Should().BeEmpty();
            result.Definitions.ScriptedSkulls.Should().BeEmpty();
            result.Definitions.Sources.Should().NotBeEmpty();
            result.Definitions.StatGroups.Should().BeEmpty();
            result.Definitions.Stats.Should().BeEmpty();
            result.Definitions.TalentGrids.Should().BeEmpty();
            result.Definitions.UnlockValues.Should().BeEmpty();
            result.Definitions.VendorDetails.Should().BeEmpty();
            result.Definitions.VendorCategories.Should().BeEmpty();
            result.Definitions.VendorSummaries.Should().BeEmpty();
        }

        [Test]
        public void GetCharacterInventory()
        {
            var result = Deserialize<GetCharacterInventoryResponse>();
            result.Should().NotBeNull();
            result.CharacterInventory.Should().NotBeNull();
            result.Definitions.Buckets.Should().NotBeEmpty();
            result.Definitions.DamageTypes.Should().NotBeEmpty();
            result.Definitions.Items.Should().NotBeEmpty();
            result.Definitions.ItemCategories.Should().NotBeEmpty();
            result.Definitions.Perks.Should().NotBeEmpty();
            result.Definitions.Progressions.Should().NotBeEmpty();
            result.Definitions.Sources.Should().NotBeEmpty();
            result.Definitions.StatGroups.Should().NotBeEmpty();
            result.Definitions.Stats.Should().NotBeEmpty();
            result.Definitions.TalentGrids.Should().NotBeEmpty();
        }

        [Test]
        public void GetCharacterProgression()
        {
            var result = Deserialize<GetCharacterProgressionResponse>();
            result.Should().NotBeNull();
            result.CharacterProgression.Should().NotBeNull();
            result.Definitions.Progressions.Should().NotBeEmpty();
        }

        [Test]
        public void GetCharacterSummary()
        {
            var result = Deserialize<GetCharacterResponse>();
            result.Should().NotBeNull();
            result.Character.Should().NotBeNull();
            result.Definitions.Races.Should().NotBeEmpty();
            result.Definitions.Genders.Should().NotBeEmpty();
            result.Definitions.Classes.Should().NotBeEmpty();
            result.Definitions.Items.Should().NotBeEmpty();
            result.Definitions.Buckets.Should().NotBeEmpty();
            result.Definitions.Stats.Should().NotBeEmpty();
            result.Definitions.Perks.Should().NotBeEmpty();
            result.Definitions.TalentGrids.Should().NotBeEmpty();
            result.Definitions.StatGroups.Should().NotBeEmpty();
            result.Definitions.ItemCategories.Should().NotBeEmpty();
            result.Definitions.Sources.Should().NotBeEmpty();
            result.Definitions.Progressions.Should().NotBeEmpty();
            result.Definitions.DamageTypes.Should().NotBeEmpty();
        }

        [Test]
        public void GetDefinitionForActivity()
        {
            var result = Deserialize<GetDefinitionResponse>();
            result.Should().NotBeNull();
            result.Definition.Should().NotBeNull();
            result.Definition.Activity.Should().NotBeNull();
        }

        [Test]
        public void GetDefinitionForActivityBundle()
        {
            var result = Deserialize<GetDefinitionResponse>();
            result.Should().NotBeNull();
            result.Definition.Should().NotBeNull();
            result.Definition.ActivityBundle.Should().NotBeNull();
        }

        [Test]
        public void GetDefinitionForActivityType()
        {
            var result = Deserialize<GetDefinitionResponse>();
            result.Should().NotBeNull();
            result.Definition.Should().NotBeNull();
            result.Definition.ActivityType.Should().NotBeNull();
        }

        [Test]
        public void GetDefinitionForArtDye()
        {
            var result = Deserialize<GetDefinitionResponse>();
            result.Should().NotBeNull();
            result.Definition.Should().NotBeNull();
            result.Definition.ArtDye.Should().NotBeNull();
        }

        [Test]
        public void GetDefinitionForArtDyeChannel()
        {
            var result = Deserialize<GetDefinitionResponse>();
            result.Should().NotBeNull();
            result.Definition.Should().NotBeNull();
            result.Definition.ArtDyeChannel.Should().NotBeNull();
        }

        [Test]
        public void GetDefinitionForClass()
        {
            var result = Deserialize<GetDefinitionResponse>();
            result.Should().NotBeNull();
            result.Definition.Should().NotBeNull();
            result.Definition.ClassDefinition.Should().NotBeNull();
        }

        [Test]
        public void GetDefinitionForDestination()
        {
            var result = Deserialize<GetDefinitionResponse>();
            result.Should().NotBeNull();
            result.Definition.Should().NotBeNull();
            result.Definition.Destination.Should().NotBeNull();
        }

        [Test, Ignore]
        public void GetDefinitionForDirectorBook()
        {
            var result = Deserialize<GetDefinitionResponse>();
            result.Should().NotBeNull();
            result.Definition.Should().NotBeNull();
            result.Definition.DirectorBook.Should().NotBeNull();
        }

        [Test, Ignore]
        public void GetDefinitionForGearAsset()
        {
            var result = Deserialize<GetDefinitionResponse>();
            result.Should().NotBeNull();
            result.Definition.Should().NotBeNull();
            result.Definition.GearAsset.Should().NotBeNull();
        }

        [Test]
        public void GetDefinitionForGender()
        {
            var result = Deserialize<GetDefinitionResponse>();
            result.Should().NotBeNull();
            result.Definition.Should().NotBeNull();
            result.Definition.Gender.Should().NotBeNull();
        }

        [Test]
        public void GetDefinitionForInventoryBucket()
        {
            var result = Deserialize<GetDefinitionResponse>();
            result.Should().NotBeNull();
            result.Definition.Should().NotBeNull();
            result.Definition.InventoryBucket.Should().NotBeNull();
        }

        [Test]
        public void GetDefinitionForInventoryItem()
        {
            var result = Deserialize<GetDefinitionResponse>();
            result.Should().NotBeNull();
            result.Definition.Should().NotBeNull();
            result.Definition.InventoryItem.Should().NotBeNull();
        }

        [Test]
        public void GetDefinitionForMaterialRequirement()
        {
            var result = Deserialize<GetDefinitionResponse>();
            result.Should().NotBeNull();
            result.Definition.Should().NotBeNull();
            result.Definition.MaterialRequirement.Should().NotBeNull();
        }

        [Test]
        public void GetDefinitionForPlace()
        {
            var result = Deserialize<GetDefinitionResponse>();
            result.Should().NotBeNull();
            result.Definition.Should().NotBeNull();
            result.Definition.Place.Should().NotBeNull();
        }

        [Test]
        public void GetDefinitionForProgression()
        {
            var result = Deserialize<GetDefinitionResponse>();
            result.Should().NotBeNull();
            result.Definition.Should().NotBeNull();
            result.Definition.Progression.Should().NotBeNull();
        }

        [Test]
        public void GetDefinitionForRace()
        {
            var result = Deserialize<GetDefinitionResponse>();
            result.Should().NotBeNull();
            result.Definition.Should().NotBeNull();
            result.Definition.Race.Should().NotBeNull();
        }

        [Test]
        public void GetDefinitionForSandboxPerk()
        {
            var result = Deserialize<GetDefinitionResponse>();
            result.Should().NotBeNull();
            result.Definition.Should().NotBeNull();
            result.Definition.SandboxPerk.Should().NotBeNull();
        }

        [Test]
        public void GetDefinitionForStat()
        {
            var result = Deserialize<GetDefinitionResponse>();
            result.Should().NotBeNull();
            result.Definition.Should().NotBeNull();
            result.Definition.Stat.Should().NotBeNull();
        }

        [Test]
        public void GetDefinitionForStatGroup()
        {
            var result = Deserialize<GetDefinitionResponse>();
            result.Should().NotBeNull();
            result.Definition.Should().NotBeNull();
            result.Definition.StatGroup.Should().NotBeNull();
        }

        [Test]
        public void GetDefinitionForTalentGrid()
        {
            var result = Deserialize<GetDefinitionResponse>();
            result.Should().NotBeNull();
            result.Definition.Should().NotBeNull();
            result.Definition.TalentGrid.Should().NotBeNull();
        }

        [Test]
        public void GetDefinitionForUnlockFlag()
        {
            var result = Deserialize<GetDefinitionResponse>();
            result.Should().NotBeNull();
            result.Definition.Should().NotBeNull();
            result.Definition.UnlockFlag.Should().NotBeNull();
        }

        [Test]
        public void GetDefinitionForVendor()
        {
            var result = Deserialize<GetDefinitionResponse>();
            result.Should().NotBeNull();
            result.Definition.Should().NotBeNull();
            result.Definition.Vendor.Should().NotBeNull();
        }

        [Test]
        public void GetEvents()
        {
            var result = Deserialize<GetEventsResponse>();
            result.Should().NotBeNull();
            result.EventSet.Should().NotBeNull();
            result.EventSet.Events.Should().NotBeNull();
            //TODO: Need to get result when event is running
            //result.EventSet.Events.Should().NotBeEmpty();
        }

        [Test]
        public void GetExcellenceBadges()
        {
            var result = Deserialize<GetExcellenceBadgesResponse>();
            result.Should().NotBeNull();
            result.ExcellenceBadges.Should().NotBeNull();
            result.ExcellenceBadges.Badges.Should().NotBeNull();
            result.ExcellenceBadges.Badges.Should().NotBeEmpty();
            result.Definitions.Badges.Should().NotBeEmpty();
        }

        [Test]
        public void GetGrimoireByMembership()
        {
            var result = Deserialize<GetGrimoireByMembershipResponse>();
            result.Should().NotBeNull();
            result.Grimoire.Score.Should().Be(4160);
            result.CardDefinitions.Should().NotBeEmpty();
        }

        [Test]
        public void GetGrimoireDefinition()
        {
            var result = Deserialize<GetGrimoireDefinitionResponse>();
            result.Should().NotBeNull();
            result.ThemeCollection.Should().NotBeNull();
            result.ThemeCollection.Should().NotBeEmpty();
        }

        [Test]
        public void GetItemDetail()
        {
            var result = Deserialize<GetItemDetailResponse>();
            result.Should().NotBeNull();
            result.ItemDetail.Should().NotBeNull();
            result.Definitions.Items.Should().NotBeEmpty();
            result.Definitions.Buckets.Should().NotBeEmpty();
            result.Definitions.Stats.Should().NotBeEmpty();
            result.Definitions.Perks.Should().NotBeEmpty();
            result.Definitions.TalentGrids.Should().NotBeEmpty();
            result.Definitions.StatGroups.Should().NotBeEmpty();
            result.Definitions.ItemCategories.Should().NotBeEmpty();
            result.Definitions.Progressions.Should().NotBeEmpty();
            result.Definitions.DamageTypes.Should().NotBeEmpty();
        }

        [Test]
        public void GetLiveTiles()
        {
            var result = Deserialize<GetLiveTilesResponse>();
            result.Should().NotBeNull();
            result.Should().NotBeEmpty();
        }

        [Test]
        public void GetManifest()
        {
            var result = Deserialize<GetManifestResponse>();
            result.Should().NotBeNull();
            result.MobileAssetContentPath.Should().NotBeNull();
        }

        [Test]
        public void GetPostGameCarnageReport()
        {
            var result = Deserialize<GetPostGameCarnageReportResponse>();
            result.Should().NotBeNull();
            result.Activity.Should().NotBeNull();
            result.Definitions.Items.Should().NotBeNull();
            result.Definitions.Buckets.Should().NotBeNull();
            result.Definitions.Stats.Should().NotBeNull();
            result.Definitions.Perks.Should().NotBeNull();
            result.Definitions.TalentGrids.Should().NotBeNull();
            result.Definitions.StatGroups.Should().NotBeNull();
            result.Definitions.ItemCategories.Should().NotBeNull();
            result.Definitions.Sources.Should().NotBeNull();
            result.Definitions.Progressions.Should().NotBeNull();
            result.Definitions.DamageTypes.Should().NotBeNull();
            result.Definitions.Destinations.Should().NotBeNull();
            result.Definitions.Activities.Should().NotBeNull();
            result.Definitions.Places.Should().NotBeNull();
            result.Definitions.ActivityTypes.Should().NotBeNull();
        }

        [Test]
        public void GetStatsDefinition()
        {
            var result = Deserialize<GetStatsDefinitionResponse>();
            result.Should().NotBeNull();
            result.ActivitiesCleared.Should().NotBeNull();
        }

        [Test]
        public void GetStatsForAccount()
        {
            var result = Deserialize<GetStatsForAccountResponse>();
            result.Should().NotBeNull();
            result.MergedDeletedCharacters.Should().NotBeNull();
            result.MergedAllCharacters.Should().NotBeNull();
            result.Characters.Should().NotBeNull();
            result.Characters.Should().NotBeEmpty();
        }

        [Test]
        public void GetStatsForCharacter()
        {
            var result = Deserialize<GetStatsForCharacter>();
            result.Should().NotBeNull();
            result.AllPvp.Should().NotBeNull();
            result.Patrol.Should().NotBeNull();
            result.Raid.Should().NotBeNull();
            result.Story.Should().NotBeNull();
            result.AllStrikes.Should().NotBeNull();
        }

        [Test]
        public void GetTriumphs()
        {
            var result = Deserialize<GetTriumphsResponse>();
            result.Should().NotBeNull();
            result.Triumphs.Should().NotBeNull();
            result.Triumphs.TriumphSets.Should().NotBeEmpty();
            result.Definitions.Triumphs.Should().NotBeEmpty();
        }

        [Test]
        public void GetUniqueWeaponsStats()
        {
            var result = Deserialize<GetUniqueWeaponsStatsResponse>();
            result.Should().NotBeNull();
            result.WeaponsStats.Should().NotBeNull();
            result.WeaponsStats.Weapons.Should().NotBeEmpty();
            result.Definitions.Items.Should().NotBeEmpty();
            result.Definitions.Buckets.Should().NotBeEmpty();
            result.Definitions.Stats.Should().NotBeEmpty();
            result.Definitions.Perks.Should().NotBeEmpty();
            result.Definitions.TalentGrids.Should().NotBeEmpty();
            result.Definitions.StatGroups.Should().NotBeEmpty();
            result.Definitions.ItemCategories.Should().NotBeEmpty();
            result.Definitions.Sources.Should().NotBeEmpty();
            result.Definitions.Progressions.Should().NotBeEmpty();
            result.Definitions.DamageTypes.Should().NotBeEmpty();
        }

        [Test]
        public void GetVendor()
        {
            var result = Deserialize<GetVendorResponse>();
            result.Should().NotBeNull();
            result.Vendor.Should().NotBeNull();
            result.Definitions.VendorDetails.Should().NotBeEmpty();
            result.Definitions.Items.Should().NotBeEmpty();
            result.Definitions.Buckets.Should().NotBeEmpty();
            result.Definitions.Stats.Should().NotBeEmpty();
            result.Definitions.Perks.Should().NotBeEmpty();
            result.Definitions.TalentGrids.Should().NotBeEmpty();
            result.Definitions.StatGroups.Should().NotBeEmpty();
            result.Definitions.ItemCategories.Should().NotBeEmpty();
            result.Definitions.Sources.Should().NotBeEmpty();
            result.Definitions.Progressions.Should().NotBeEmpty();
            result.Definitions.DamageTypes.Should().NotBeEmpty();
            result.Definitions.Factions.Should().NotBeEmpty();
            result.Definitions.VendorCategories.Should().NotBeEmpty();
        }

        [Test]
        public void GetVendorWithMetadata()
        {
            var result = Deserialize<GetVendorWithMetadataResponse>();
            result.Should().NotBeNull();
            result.Data.Vendor.Should().NotBeNull();
            result.Definitions.VendorDetails.Should().NotBeEmpty();
            result.Definitions.Items.Should().NotBeEmpty();
            result.Definitions.Buckets.Should().NotBeEmpty();
            result.Definitions.Stats.Should().NotBeEmpty();
            result.Definitions.Perks.Should().NotBeEmpty();
            result.Definitions.TalentGrids.Should().NotBeEmpty();
            result.Definitions.StatGroups.Should().NotBeEmpty();
            result.Definitions.ItemCategories.Should().NotBeEmpty();
            result.Definitions.Sources.Should().NotBeEmpty();
            result.Definitions.Progressions.Should().NotBeEmpty();
            result.Definitions.DamageTypes.Should().NotBeEmpty();
            result.Definitions.Factions.Should().NotBeEmpty();
            result.Definitions.VendorCategories.Should().NotBeEmpty();
        }

        [Test]
        public void GetXur()
        {
            var result = Deserialize<GetXurResponse>();
            result.Should().NotBeNull();
            result.Xur.Should().NotBeNull();
            result.Xur.VendorHash.Should().Be(2796397637);
            result.Definitions.Items.Should().NotBeEmpty();
            result.Definitions.Buckets.Should().NotBeEmpty();
            result.Definitions.Stats.Should().NotBeEmpty();
            result.Definitions.Perks.Should().NotBeEmpty();
            result.Definitions.TalentGrids.Should().NotBeEmpty();
            result.Definitions.StatGroups.Should().NotBeEmpty();
            result.Definitions.Progressions.Should().NotBeEmpty();
            result.Definitions.DamageTypes.Should().NotBeEmpty();
            result.Definitions.Events.Should().NotBeEmpty();
            result.Definitions.VendorCategories.Should().NotBeEmpty();
            result.Definitions.Flags.Should().NotBeEmpty();
        }            

        [Test]
        public void SearchItems()
        {
            var result = Deserialize<SearchItemsResponse>();
            result.Should().NotBeNull();
            result.Results.Should().NotBeNull();
            result.Definitions.Items.Should().NotBeEmpty();
            result.Definitions.Buckets.Should().NotBeEmpty();
            result.Definitions.Perks.Should().NotBeEmpty();
            result.Definitions.TalentGrids.Should().NotBeEmpty();
            result.Definitions.ItemCategories.Should().NotBeEmpty();
            result.Definitions.Sources.Should().NotBeEmpty();
        }

        [Test]
        public void SearchPlayers()
        {
            var result = Deserialize<SearchPlayersResponse>();
            result.Should().NotBeNull();
            result.Should().NotBeEmpty();
        }

        [Test]
        public void SearchTalentNodeSteps()
        {
            var result = Deserialize<SearchTalentNodeStepsResponse>();
            result.Should().NotBeNull();
            result.Results.Should().NotBeNull();
            result.Definitions.NodeSteps.Should().NotBeEmpty();
            result.Definitions.Perks.Should().NotBeEmpty();
            result.Definitions.Stats.Should().NotBeEmpty();
        }        
    }
}
