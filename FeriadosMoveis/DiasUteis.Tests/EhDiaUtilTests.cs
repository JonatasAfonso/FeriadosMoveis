using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DiasUteis.Tests
{
    [TestClass]
    public class EhDiaUtilTests
    {
        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void DeveGerarExceptionCasoFeriadosDiasDescansoVazio()
        {
            //arrange
            var sabado = new DateTime(2018, 03, 17);
            var diaUtil = new DiaUtil();

            //act
            var ehDiaUtil = diaUtil.EhDiaUtil(sabado, new List<DateTime>(), new List<DayOfWeek>());

            //assert
        }
        
        [TestMethod]
        public void NaoDeveGerarExceptionCasoDiasDescansoVazio()
        {
            //arrange
            var segunda = DiasUteisTestsInitializer.DiasParaTestes[DayOfWeek.Monday];
            var diaUtil = new DiaUtil();

            //act
            var ehDiaUtil = diaUtil.EhDiaUtil(segunda, null, new List<DayOfWeek>());

            //assert
            Assert.IsTrue(ehDiaUtil);
        }

        [TestMethod]
        public void NaoDeveGerarExceptionCasoFeriadosVazio()
        {
            //arrange
            var segunda = DiasUteisTestsInitializer.DiasParaTestes[DayOfWeek.Monday];
            var diaUtil = new DiaUtil();

            //act
            var ehDiaUtil = diaUtil.EhDiaUtil(segunda, new List<DateTime>());

            //assert
            Assert.IsTrue(ehDiaUtil);
        }
        
        [TestMethod]
        public void DeveSerDiaUtilDiaDescansoPadrao()
        {
            //arrange
            var dataParametro = new DateTime(2018, 01, 02);
            var diaUtil = new DiaUtil();

            //act
            var ehDiaUtil = diaUtil.EhDiaUtil(dataParametro, DiasUteisTestsInitializer.Feriados);

            //assert
            Assert.IsTrue(ehDiaUtil);
        }

        [TestMethod]
        public void NaoDeveSerDiaUtilFeriadoDiaDescansoPadrao()
        {
            //arrange
            var dataParametro = new DateTime(2018, 01, 01);
            var diaUtil = new DiaUtil();

            //act
            var naoEhDiaUtil = !diaUtil.EhDiaUtil(dataParametro, DiasUteisTestsInitializer.Feriados);

            //assert
            Assert.IsTrue(naoEhDiaUtil);
        }
        
        [TestMethod]
        public void NaoDeveSerDiaUtilSabadoDiaDescansoPadrao()
        {
            //arrange
            var dataParametro = new DateTime(2018, 01, 06);
            var diaUtil = new DiaUtil();

            //act
            var naoEhDiaUtil = !diaUtil.EhDiaUtil(dataParametro, DiasUteisTestsInitializer.Feriados);

            //assert
            Assert.IsTrue(naoEhDiaUtil);
        }

        [TestMethod]
        public void NaoDeveSerDiaUtilDomingoDiaDescansoPadrao()
        {
            //arrange
            var dataParametro = new DateTime(2018, 01, 07);
            var diaUtil = new DiaUtil();

            //act
            var naoEhDiaUtil = !diaUtil.EhDiaUtil(dataParametro, DiasUteisTestsInitializer.Feriados);

            //assert
            Assert.IsTrue(naoEhDiaUtil);
        }

        [TestMethod]
        public void DeveSerDiaUtilDiaDescansoDiferente()
        {
            //arrange
            var dataParametro = new DateTime(2018, 01, 03);
            var diaUtil = new DiaUtil();

            //act
            var ehDiaUtil = diaUtil.EhDiaUtil(dataParametro, DiasUteisTestsInitializer.Feriados, DiasUteisTestsInitializer.DiasDescanso);

            //assert
            Assert.IsTrue(ehDiaUtil);
        }

        [TestMethod]
        public void NaoDeveSerDiaUtilFeriadoDiaDescansoDiferente()
        {
            //arrange
            var dataParametro = new DateTime(2018, 01, 01);
            var diaUtil = new DiaUtil();

            //act
            var naoEhDiaUtil = !diaUtil.EhDiaUtil(dataParametro, DiasUteisTestsInitializer.Feriados, DiasUteisTestsInitializer.DiasDescanso);

            //assert
            Assert.IsTrue(naoEhDiaUtil);
        }

        [TestMethod]
        public void NaoDeveSerDiaUtilSegundaDiaDescansoDiferente()
        {
            //arrange
            var dataParametro = new DateTime(2018, 03, 26);
            var diaUtil = new DiaUtil();

            //act
            var naoEhDiaUtil = !diaUtil.EhDiaUtil(dataParametro, DiasUteisTestsInitializer.Feriados, DiasUteisTestsInitializer.DiasDescanso);

            //assert
            Assert.IsTrue(naoEhDiaUtil);
        }

        [TestMethod]
        public void NaoDeveSerDiaUtilTercaDiaDescansoDiferente()
        {
            //arrange
            var dataParametro = new DateTime(2018, 03, 27);
            var diaUtil = new DiaUtil();

            //act
            var naoEhDiaUtil = !diaUtil.EhDiaUtil(dataParametro, DiasUteisTestsInitializer.Feriados, DiasUteisTestsInitializer.DiasDescanso);

            //assert
            Assert.IsTrue(naoEhDiaUtil);
        }

    }
}
