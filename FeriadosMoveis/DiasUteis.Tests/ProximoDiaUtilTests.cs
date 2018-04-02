using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DiasUteis.Tests
{
    [TestClass]
    public class ProximoDiaUtilTests
    {
        [TestMethod]
        public void DeveSerSegundaFeiraAPartirDeDomingo()
        {
            //arrange
            var domingo = DiasUteisTestsInitializer.DiasParaTestes[DayOfWeek.Sunday];
            var diaUtil = new DiaUtil();

            //act
            var proximoDiaUtil = diaUtil.ProximoDiaUtil(domingo);
            var segunda = DiasUteisTestsInitializer.DiasParaTestes[DayOfWeek.Monday];


            //assert
            Assert.AreEqual(segunda, proximoDiaUtil);
        }

        [TestMethod]
        public void DeveSerSegundaFeiraAPartirDeSabado()
        {
            //arrange
            var sabado = new DateTime(2018, 03, 24);
            var diaUtil = new DiaUtil();

            //act
            var proximoDiaUtil = diaUtil.ProximoDiaUtil(sabado);
            var segunda = DiasUteisTestsInitializer.DiasParaTestes[DayOfWeek.Monday];
            
            //assert
            Assert.AreEqual(segunda, proximoDiaUtil);
        }
        
        [TestMethod]
        public void DeveSerTercaFeiraAPartirDeSegunda()
        {
            //arrange
            var segunda = DiasUteisTestsInitializer.DiasParaTestes[DayOfWeek.Monday];
            var diaUtil = new DiaUtil();

            //act
            var proximoDiaUtil = diaUtil.ProximoDiaUtil(segunda);
            var terca = DiasUteisTestsInitializer.DiasParaTestes[DayOfWeek.Tuesday];


            //assert
            Assert.AreEqual(terca, proximoDiaUtil);
        }

        [TestMethod]
        public void DeveSerQuartaFeiraAPartirDeSegundaSeTercaForFeriado()
        {
            //arrange
            var segunda = DiasUteisTestsInitializer.DiasParaTestes[DayOfWeek.Monday];
            var terca = DiasUteisTestsInitializer.DiasParaTestes[DayOfWeek.Tuesday];
            var diaUtil = new DiaUtil();

            //act
            var proximoDiaUtil = diaUtil.ProximoDiaUtil(segunda, new List<DateTime> { terca });
            var quarta = DiasUteisTestsInitializer.DiasParaTestes[DayOfWeek.Wednesday];


            //assert
            Assert.AreEqual(quarta, proximoDiaUtil);
        }
        
        [TestMethod]
        public void DeveSerQuintaFeiraAPartirDeSegundaSeTercaEQuartaForemFeriados()
        {
            //arrange
            var segunda = DiasUteisTestsInitializer.DiasParaTestes[DayOfWeek.Monday];
            var terca = DiasUteisTestsInitializer.DiasParaTestes[DayOfWeek.Tuesday];
            var quarta = DiasUteisTestsInitializer.DiasParaTestes[DayOfWeek.Wednesday];
            var diaUtil = new DiaUtil();

            //act
            var proximoDiaUtil = diaUtil.ProximoDiaUtil(segunda, new List<DateTime> { terca, quarta });
            var quinta = DiasUteisTestsInitializer.DiasParaTestes[DayOfWeek.Thursday];
            
            //assert
            Assert.AreEqual(quinta, proximoDiaUtil);
        }
    }
}