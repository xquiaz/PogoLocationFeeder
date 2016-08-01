﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using PogoLocationFeeder.Repository;
using POGOProtos.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PogoLocationFeeder.Repository.Tests
{
    [TestClass()]
    public class TrackemonRarePokemonRepositoryTests
    {
        RarePokemonRepository trackermonRarePokemonRepository = new TrackermonRarePokemonRepository(RarePokemonsFactory.createRarePokemonList());

        [TestMethod()]
        [Ignore]
        public void FindAll()
        {
            List<SniperInfo> sniperInfos = trackermonRarePokemonRepository.FindAll();
            Assert.IsNotNull(sniperInfos);
            Assert.IsTrue(sniperInfos.Any());
            foreach(SniperInfo sniperInfo in sniperInfos)
            {
                Console.WriteLine(sniperInfo);
            }
        }

        [TestMethod()]
        public void GetChannel()
        {
            Assert.AreEqual("Trackermon", trackermonRarePokemonRepository.GetChannel());
        }
    }
}