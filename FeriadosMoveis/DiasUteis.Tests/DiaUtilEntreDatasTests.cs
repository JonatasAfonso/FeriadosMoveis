using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DiasUteis.Tests
{
    [TestClass]
    public class DiaUtilEntreDatasTests
    {
        [TestMethod]
        public void NaoDeveTerDiaUtilEntreSabadoEDomingo()
        {
            //arrange
            var sabado = new DateTime(2018, 03, 17);
            var domingo = new DateTime(2018, 03, 18);
            var diaUtil = new DiaUtil();

            //act
            var numDiasUteis = diaUtil.DiasUteisEntreDatas(sabado, domingo);

            //assert
            Assert.AreEqual(0, numDiasUteis);
        }

        [TestMethod]
        public void DeveTer0DiaUtilEntreSegundaETerca()
        {
            //arrange
            var segunda = DiasUteisTestsInitializer.DiasParaTestes[DayOfWeek.Monday];
            var terca = DiasUteisTestsInitializer.DiasParaTestes[DayOfWeek.Tuesday];

            var diaUtil = new DiaUtil();

            //act
            var numDiasUteis = diaUtil.DiasUteisEntreDatas(segunda, terca);

            //assert
            Assert.AreEqual(0, numDiasUteis);
        }

        [TestMethod]
        public void DeveTer0DiaUtilEntreTercaEQuarta()
        {
            //arrange
            var terca = DiasUteisTestsInitializer.DiasParaTestes[DayOfWeek.Tuesday];
            var quarta = DiasUteisTestsInitializer.DiasParaTestes[DayOfWeek.Wednesday];

            var diaUtil = new DiaUtil();

            //act
            var numDiasUteis = diaUtil.DiasUteisEntreDatas(terca, quarta);

            //assert
            Assert.AreEqual(0, numDiasUteis);
        }
        
        [TestMethod]
        public void DeveTer1DiaUtilEntreDomingoETerca()
        {
            //arrange
            var domingo = DiasUteisTestsInitializer.DiasParaTestes[DayOfWeek.Sunday];
            var terca = DiasUteisTestsInitializer.DiasParaTestes[DayOfWeek.Tuesday];

            var diaUtil = new DiaUtil();

            //act
            var numDiasUteis = diaUtil.DiasUteisEntreDatas(domingo, terca);

            //assert
            Assert.AreEqual(1, numDiasUteis);
        }

        [TestMethod]
        public void DeveTer1DiaUtilEntreSabadoETerca()
        {
            //arrange
            var sabado = new DateTime(2018, 03, 24);
            var terca = DiasUteisTestsInitializer.DiasParaTestes[DayOfWeek.Tuesday];

            var diaUtil = new DiaUtil();

            //act
            var numDiasUteis = diaUtil.DiasUteisEntreDatas(sabado, terca);

            //assert
            Assert.AreEqual(1, numDiasUteis);
        }

        [TestMethod]
        public void DeveTer3DiasUteisEntreDomingoEQuintaFeira()
        {
            //arrange
            var domingo = DiasUteisTestsInitializer.DiasParaTestes[DayOfWeek.Sunday];
            var quinta = DiasUteisTestsInitializer.DiasParaTestes[DayOfWeek.Thursday];

            var diaUtil = new DiaUtil();

            //act
            var numDiasUteis = diaUtil.DiasUteisEntreDatas(domingo, quinta);

            //assert
            Assert.AreEqual(3, numDiasUteis);
        }

        [TestMethod]
        public void DeveTer10DiasUteisEntreDatas()
        {
            //arrange
            var dataInicio = new DateTime(2018, 03, 01);
            var dataFim = new DateTime(2018, 03, 16);

            var diaUtil = new DiaUtil();

            //act
            var numDiasUteis = diaUtil.DiasUteisEntreDatas(dataInicio, dataFim);

            //assert
            Assert.AreEqual(10, numDiasUteis);
        }
    }
}