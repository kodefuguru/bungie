namespace Bungie.Tests
{
    using System;
    using System.Configuration;

    public static class Program
    {
        static void Main(string[] args)
        {
            string apiKey = GetApiKey();
            var type = MembershipType.Xbox;
            var id = 4611686018432640426;
            var cid = 2305843009214976264;
            var activity = 4450734858;
            var item = 6917529027654664565;
            var vendor = 570929315;

            var service = new DestinyService(apiKey);
            //var response = service.GetAccount(type, id, definitions: true);
            //var response = service.GetAccountSummary(type, id, definitions: true);
            //var response = service.GetActivities(type, id, cid, ActivityMode.AllPvE, definitions: true);
            //var response = service.GetAdvisors(definitions: true);
            //var response = service.GetAggregateActivityStats(type, id, cid, definitions: true);
            //var response = service.GetCharacterActivities(type, id, cid, definitions: true);
            //var response = service.GetCharacterInventory(type, id, cid, definitions: true);
            //var response = service.GetCharacterProgression(type, id, cid, definitions: true);
            //var response = service.GetCharacterSummary(type, id, cid, definitions: true);
            //var response = service.GetDefinition(DefinitionType.Activity, 3120351941, definitions: true);
            //var response = service.GetDefinition(DefinitionType.ActivityType, 1686739444, definitions: true);
            //var response = service.GetDefinition(DefinitionType.ActivityBundle, 1749151224, definitions: true);
            //var response = service.GetDefinition(DefinitionType.ArtDye, 1824360987, definitions: true);
            //var response = service.GetDefinition(DefinitionType.ArtDyeChannel, 662199250, definitions: true);
            //var response = service.GetDefinition(DefinitionType.Class, 2271682572, definitions: true);
            //var response = service.GetDefinition(DefinitionType.Destination, 2512542997, definitions: true);
            //var response = service.GetDefinition(DefinitionType.DirectorBook, 0, definitions: true);
            //var response = service.GetDefinition(DefinitionType.GearAsset, 0, definitions: true);
            //var response = service.GetDefinition(DefinitionType.Gender, 3111576190, definitions: true);
            //var response = service.GetDefinition(DefinitionType.InventoryItem, 705234570, definitions: true);
            //var response = service.GetDefinition(DefinitionType.InventoryBucket, 1469714392, definitions: true);
            //var response = service.GetDefinition(DefinitionType.MaterialRequirement, 3409743738, definitions: true);
            //var response = service.GetDefinition(DefinitionType.Place, 3747705955, definitions: true);
            //var response = service.GetDefinition(DefinitionType.Progression, 1716568313, definitions: true);
            //var response = service.GetDefinition(DefinitionType.Race, 2803282938, definitions: true);
            //var response = service.GetDefinition(DefinitionType.SandboxPerk, 1561443109, definitions: true);
            //var response = service.GetDefinition(DefinitionType.Stat, 3897883278, definitions: true);
            //var response = service.GetDefinition(DefinitionType.StatGroup, 1997970403, definitions: true);
            //var response = service.GetDefinition(DefinitionType.TalentGrid, 3604172206, definitions: true);
            //var response = service.GetDefinition(DefinitionType.UnlockFlag, 1680320212, definitions: true);
            //var response = service.GetDefinition(DefinitionType.Vendor, 570929315, definitions: true);
            var response = service.GetEvents(definitions: true);
            //var response = service.GetExcellenceBadges(type, id, definitions: true);
            //var response = service.GetGrimoireByMembership(type, id, definitions: true);
            //var response = service.GetGrimoireDefinition();
            //var response = service.GetItemDetail(type, id, cid, item, definitions: true);
            //var response = service.GetStatsForCharacter(type, id, cid);
            //var response = service.GetStatsForAccount(type, id);
            //var response = service.GetStatsDefinition();
            //var response = service.GetLiveTiles();
            //var response = service.GetManifest();
            //var response = service.GetMembershipId("kodefuguru");
            //var response = service.GetPostGameCarnageReport(activity, definitions: true);
            //var response = service.GetTriumphs(type, id, definitions: true);
            //var response = service.GetUniqueWeaponsStats(type, id, cid, definitions: true);
            //var response = service.GetVendor(vendor, definitions: true);
            //var response = service.GetVendorWithMetadata(vendor, definitions: true);
            //var response = service.GetXur(definitions: true);
            //var response = service.SearchItems(definitions: true);
            //var response = service.SearchPlayers(type, "kodefuguru");
            //var response = service.SearchTalentNodeSteps(definitions: true);
            var result = response.Result;
            Console.WriteLine();
        }

        /// <remarks>
        /// 1) If you do not have an ApiKey, obtain one from https://www.bungie.net/en/User/API"/
        /// 2) If you're using source control for this project, configure it to exclude *.secret.config.
        /// 3) Create a file in the project folder with the name appSettings.secret.config.
        /// 4) Copy the appSettings section from App.config and paste it into the new file. 
        /// 5) Replace the value of the ApiKey entry with your api key. 
        /// </remarks>
        private static string GetApiKey()
        {
            var settings = new AppSettingsReader();
            var value = settings.GetValue("ApiKey", typeof(string));
            return value == null ? String.Empty : value.ToString();
        }
    }
}
