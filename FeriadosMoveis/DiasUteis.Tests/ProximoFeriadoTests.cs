using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DiasUteis.Tests
{
    [TestClass]
    public class ProximoFeriadoTests
    {
        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void DeveGerarExceptionCasoFeriadosVazio()
        {
            //arrange
            var sabado = new DateTime(2018, 03, 17);
            var diaUtil = new DiaUtil();

            //act
            diaUtil.ProximoFeriado(sabado, new List<DateTime>());

            //assert
        }

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void DeveGerarExceptionCasoFeriadosNulo()
        {
            //arrange
            var sabado = new DateTime(2018, 03, 17);
            var diaUtil = new DiaUtil();

            //act
            diaUtil.ProximoFeriado(sabado);

            //assert
        }
        
        [TestMethod]
        public void DeveSerTiradentesAPartirDeMarco()
        {
            //arrange
            var marco = new DateTime(2018,03,02);
            var tiradentes = DiasUteisTestsInitializer.Tiradentes;
            var diaUtil = new DiaUtil();

            //act
            var proximoFeriado = diaUtil.ProximoFeriado(marco, DiasUteisTestsInitializer.Feriados);

            //assert
            Assert.AreEqual(tiradentes, proximoFeriado);
        }
        
        [TestMethod]
        public void DeveSerConfraternizacaoUniversalApartirDeDezembro()
        {
            //arrange
            var dezembro = new DateTime(2017, 12, 02);
            var confraternizacaoUniversal = DiasUteisTestsInitializer.ConfraternizacaoUniversal;
            var diaUtil = new DiaUtil();

            //act
            var proximoFeriado = diaUtil.ProximoFeriado(dezembro, DiasUteisTestsInitializer.Feriados);

            //assert
            Assert.AreEqual(confraternizacaoUniversal, proximoFeriado);
        }
    }
}