﻿using Xunit;

namespace ArgentPonyWarcraftClient.Integration.Tests.GameDataApi
{
    public class JournalApiTests
    {
        [ResilientFact]
        public async void GetJournalExpansionsIndexAsync_Gets_JournalExpansions()
        {
            IJournalApi warcraftClient = ClientFactory.BuildClient();
            RequestResult<JournalExpansionsIndex> result = await warcraftClient.GetJournalExpansionsIndexAsync("static-us");
            Assert.NotNull(result.Value);
        }

        [ResilientFact]
        public async void GetJournalExpansionAsync_Gets_JournalExpansion()
        {
            IJournalApi warcraftClient = ClientFactory.BuildClient();
            RequestResult<JournalExpansion> result = await warcraftClient.GetJournalExpansionAsync(68, "static-us");
            Assert.NotNull(result.Value);
        }

        [ResilientFact]
        public async void GetJournalEncountersIndexAsync_Gets_JournalEncounters()
        {
            IJournalApi warcraftClient = ClientFactory.BuildClient();
            RequestResult<JournalEncountersIndex> result = await warcraftClient.GetJournalEncountersIndexAsync("static-us");
            Assert.NotNull(result.Value);
        }

        [ResilientFact]
        public async void GetJournalEncounterAsync_Gets_Encounter()
        {
            IJournalApi warcraftClient = ClientFactory.BuildClient();
            RequestResult<Encounter> result = await warcraftClient.GetJournalEncounterAsync(89, "static-us");
            Assert.NotNull(result.Value);
        }

        [ResilientFact]
        public async void GetJournalInstancesIndexAsync_Gets_JournalInstances()
        {
            IJournalApi warcraftClient = ClientFactory.BuildClient();
            RequestResult<JournalInstancesIndex> result = await warcraftClient.GetJournalInstancesIndexAsync("static-us");
            Assert.NotNull(result.Value);
        }

        [ResilientFact]
        public async void GetJournalInstanceAsync_Gets_Instance()
        {
            IJournalApi warcraftClient = ClientFactory.BuildClient();
            RequestResult<Instance> result = await warcraftClient.GetJournalInstanceAsync(63, "static-us");
            Assert.NotNull(result.Value);
        }

        [ResilientFact]
        public async void GetJournalInstanceMediaAsync_Gets_InstanceMedia()
        {
            IJournalApi warcraftClient = ClientFactory.BuildClient();
            RequestResult<JournalInstanceMedia> result = await warcraftClient.GetJournalInstanceMediaAsync(63, "static-us");
            Assert.NotNull(result.Value);
        }
    }
}
