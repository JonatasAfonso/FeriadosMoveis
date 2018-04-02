using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DiasUteis.Tests
{
    [TestClass]
   public class ProximoDiaDescansoTests
    {
        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void DeveGerarExceptionCasoDiasDescansoVazio()
        {
            //arrange
            var segunda = DiasUteisTestsInitializer.DiasParaTestes[DayOfWeek.Monday];
            var diaUtil = new DiaUtil();

            //act
            diaUtil.ProximoDiaDescanso(segunda, new List<DayOfWeek>());

            //assert
        }

  
        [TestMethod]
        public void DeveSerSabadoAPartirDeSegunda()
        {
            //arrange
            var segunda = DiasUteisTestsInitializer.DiasParaTestes[DayOfWeek.Monday];
            var sabado = DiasUteisTestsInitializer.DiasParaTestes[DayOfWeek.Saturday];
            var diaUtil = new DiaUtil();

            //act
            var proximoDiaDescanso = diaUtil.ProximoDiaDescanso(segunda);

            //assert
            Assert.AreEqual(sabado, proximoDiaDescanso);
        }



        [TestMethod]
        public void DeveSerSabadoAPartirDeTerca()
        {
            //arrange
            var terca = DiasUteisTestsInitializer.DiasParaTestes[DayOfWeek.Tuesday];
            var sabado = DiasUteisTestsInitializer.DiasParaTestes[DayOfWeek.Saturday];
            var diaUtil = new DiaUtil();

            //act
            var proximoDiaDescanso = diaUtil.ProximoDiaDescanso(terca);

            //assert
            Assert.AreEqual(sabado, proximoDiaDescanso);
        }


        [TestMethod]
        public void DeveSerQuartaAPartirDeSegundaSeQuartaForDiaDeDescanso()
        {
            //arrange
            var segunda = DiasUteisTestsInitializer.DiasParaTestes[DayOfWeek.Monday];
            var quarta = DiasUteisTestsInitializer.DiasParaTestes[DayOfWeek.Wednesday];
            var diaUtil = new DiaUtil();

            //act
            var proximoDiaDescanso = diaUtil.ProximoDiaDescanso(segunda,  new List<DayOfWeek> { DayOfWeek.Wednesday });

            //assert
            Assert.AreEqual(quarta, proximoDiaDescanso);
        }
    }
}

