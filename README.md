# bungie

Wrapper for bungie.net services. DOS is more complicated.

## Installation

### NuGet

Install Bungie by running the following command in [Package Manager Console][1].

` PM> Install-Package bungie `

## Prerequisite

You will need a Destiny Companion API Key. Obtain one from the [Destiny API Registration Page][2].

## Usage

### Create a DestinyService instance, passing in the API key.

    var service = new DestinyService(apiKey);

### Get a MembershipId for a player's user name

    var membershipId = await service.GetMembershipIdByDisplayName(MembershipType.Xbox, userName);

### Get a player's account information

    var response = await service.GetAccount(MembershipType.Xbox, membershipId);

### Get a player's item and character info

    var response = await service.GetAccountSummary(MembershipType.Xbox, membershipId);

### Get recent activities for a character

    var response = await service.GetActivities(MembershipType.Xbox, membershipId, characterId);

### Get information about daily, weekly, and special events

    var response = await service.GetAdvisors();

### Get all activities for a character with aggregated statistics

    var response = await service.GetAggregateActivityStats(MembershipType.Xbox, membershipId, characterId);

### Get activity progress for a character

    var response = await service.GetCharacterActivities(MembershipType.Xbox, membershipId, characterId);

### Get character's inventory

    var response = await service.GetCharacterInventory(MembershipType.Xbox, membershipId, characterId);

### Get character's progression information

    var response = await service.GetCharacterProgression(MembershipType.Xbox, membershipId, characterId);

### Get character information

    var response = await service.GetCharacter(MembershipType.Xbox, membershipId, characterId);

### Get all sorts of game information

    var response = await service.GetDefinition();

### Get events

    var response = await service.GetEvents();

### Get the defunct excellence badges

    var response = await service.GetExcellenceBadges(MembershipType.Xbox, membershipId);

### Get grimoire information for an account

    var response = await service.GetGrimoireByMembership(MembershipType.Xbox, membershipId);

### Get the grimoire game data

    var response = await service.GetGrimoireDefinition();

### Get details of an item

    var response = await service.GetItemDetail(MembershipType.Xbox, membershipId, characterId, itemId);

### Get the tiles displayed on bungie.net

    var response = await service.GetLiveTiles();

### Get the mobile manifest

    var response = await service.GetManifest();

### Get a post-game carnage report with far more info than shown in-game

    var response = await service.GetPostGameCarnageReport();

### Get game data for stats

    var response = await service.GetStatsDefinition();

### Get player's game stats

    var response = await service.GetStatsForAccount(MembershipType.Xbox, membershipId);

### Get character's game stats

    var response = await service.GetStatsForCharacter(MembershipType.Xbox, membershipId, characterId);

### Get triumphs

    var response = await service.GetTriumphs(MembershipType.Xbox, membershipId);

### Get stats for character's usage of specific weapons

    var response = await service.GetUniqueWeaponsStats(MembershipType.Xbox, membershipId, characterId);

### Get vendor

    var response = await service.GetVendor(vendorId);

### Get vendor with metadata

    var response = await service.GetVendorWithMetadata(vendorId);

### Get our noodly friend, Xur

    var response = await service.GetXur();

### Search items

    var response = await service.SearchItems();

### Search players

    var response = await service.SearchPlayers(MembershipType.Xbox, "kodefuguru");

### Search talent node steps

    var response = await service.SearchTalentNodeSteps();

[1]: http://docs.nuget.org/docs/start-here/using-the-package-manager-console
[2]: https://www.bungie.net/en/User/API