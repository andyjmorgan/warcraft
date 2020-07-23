﻿using Xunit;

namespace ArgentPonyWarcraftClient.Integration.Tests.GameDataApi
{
    public class MythicKeystoneDungeonApiTests
    {
        [ResilientFact]
        public async void GetMythicKeystoneDungeonsIndexAsync_Gets_MythicKeystoneDungeonsIndex()
        {
            IMythicKeystoneDungeonApi warcraftClient = ClientFactory.BuildClient();
            RequestResult<MythicKeystoneDungeonsIndex> result = await warcraftClient.GetMythicKeystoneDungeonsIndexAsync("dynamic-us");
            Assert.NotNull(result.Value);
        }

        [ResilientFact]
        public async void GetMythicKeystoneDungeonAsync_Gets_MythicKeystoneDungeon()
        {
            IMythicKeystoneDungeonApi warcraftClient = ClientFactory.BuildClient();
            RequestResult<MythicKeystoneDungeon> result = await warcraftClient.GetMythicKeystoneDungeonAsync(353, "dynamic-us");
            Assert.NotNull(result.Value);
        }

        [ResilientFact]
        public async void GetMythicKeystoneIndexAsync_Gets_MythicKeystoneIndex()
        {
            IMythicKeystoneDungeonApi warcraftClient = ClientFactory.BuildClient();
            RequestResult<MythicKeystoneIndex> result = await warcraftClient.GetMythicKeystoneIndexAsync("dynamic-us");
            Assert.NotNull(result.Value);
        }

        [ResilientFact]
        public async void GetMythicKeystonePeriodsIndexAsync_Gets_MythicKeystonePeriodsIndex()
        {
            IMythicKeystoneDungeonApi warcraftClient = ClientFactory.BuildClient();
            RequestResult<MythicKeystonePeriodsIndex> result = await warcraftClient.GetMythicKeystonePeriodsIndexAsync("dynamic-us");
            Assert.NotNull(result.Value);
        }

        [ResilientFact]
        public async void GetMythicKeystonePeriodAsync_Gets_MythicKeystonePeriod()
        {
            IMythicKeystoneDungeonApi warcraftClient = ClientFactory.BuildClient();
            RequestResult<MythicKeystonePeriod> result = await warcraftClient.GetMythicKeystonePeriodAsync(641, "dynamic-us");
            Assert.NotNull(result.Value);
        }

        [ResilientFact]
        public async void GetMythicKeystoneSeasonsIndexAsync_Gets_MythicKeystoneSeasonsIndex()
        {
            IMythicKeystoneDungeonApi warcraftClient = ClientFactory.BuildClient();
            RequestResult<MythicKeystoneSeasonsIndex> result = await warcraftClient.GetMythicKeystoneSeasonsIndexAsync("dynamic-us");
            Assert.NotNull(result.Value);
        }

        [ResilientFact]
        public async void GetMythicKeystoneSeasonAsync_Gets_MythicKeystoneSeason()
        {
            IMythicKeystoneDungeonApi warcraftClient = ClientFactory.BuildClient();
            RequestResult<MythicKeystoneSeason> result = await warcraftClient.GetMythicKeystoneSeasonAsync(1, "dynamic-us");
            Assert.NotNull(result.Value);
        }
    }
}
