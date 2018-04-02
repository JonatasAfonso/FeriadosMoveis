using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DiasUteis.Tests
{
    [TestClass]
    public class ProximaFolgaTests
    {
        [TestMethod]
        public void DeveSerSabadoAPartirDeSegunda()
        {
            //arrange
            var segunda = DiasUteisTestsInitializer.DiasParaTestes[DayOfWeek.Monday];
            var sabado = DiasUteisTestsInitializer.DiasParaTestes[DayOfWeek.Saturday];
            var diaUtil = new DiaUtil();

            //act
            var proximaFolga = diaUtil.ProximaFolga(segunda);

            //assert
            Assert.AreEqual(sabado, proximaFolga);
        }



        [TestMethod]
        public void DeveSerSabadoAPartirDeTerca()
        {
            //arrange
            var terca = DiasUteisTestsInitializer.DiasParaTestes[DayOfWeek.Tuesday];
            var sabado = DiasUteisTestsInitializer.DiasParaTestes[DayOfWeek.Saturday];
            var diaUtil = new DiaUtil();

            //act
            var proximaFolga = diaUtil.ProximaFolga(terca);

            //assert
            Assert.AreEqual(sabado, proximaFolga);
        }

        [TestMethod]
        public void DeveSerQuartaAPartirDeSegundaSeQuartaForFeriado()
        {
            //arrange
            var segunda = DiasUteisTestsInitializer.DiasParaTestes[DayOfWeek.Monday];
            var quarta = DiasUteisTestsInitializer.DiasParaTestes[DayOfWeek.Wednesday];
            var diaUtil = new DiaUtil();

            //act
            var proximaFolga = diaUtil.ProximaFolga(segunda, new List<DateTime> { quarta });

            //assert
            Assert.AreEqual(quarta, proximaFolga);
        }


        [TestMethod]
        public void DeveSerQuartaAPartirDeSegundaSeQuartaForDiaDeDescanso()
        {
            //arrange
            var segunda = DiasUteisTestsInitializer.DiasParaTestes[DayOfWeek.Monday];
            var quarta = DiasUteisTestsInitializer.DiasParaTestes[DayOfWeek.Wednesday];
            var diaUtil = new DiaUtil();

            //act
            var proximaFolga = diaUtil.ProximaFolga(segunda, diasDescanso: new List<DayOfWeek> { DayOfWeek.Wednesday });

            //assert
            Assert.AreEqual(quarta, proximaFolga);
        }
    }
}