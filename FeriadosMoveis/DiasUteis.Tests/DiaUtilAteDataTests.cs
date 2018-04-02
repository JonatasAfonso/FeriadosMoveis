using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DiasUteis.Tests
{
    [TestClass]
    public class DiaUtilAteDataTests
    {
        [TestMethod]
        public void NaoDeveTerDiaUtilDeSabadoAteDomingo()
        {
            //arrange
            var sabado = new DateTime(2018, 03, 17);
            var domingo = new DateTime(2018, 03, 18);
            var diaUtil = new DiaUtil();

            //act
            var numDiasUteis = diaUtil.DiasUteisAteData(sabado, domingo);

            //assert
            Assert.AreEqual(0, numDiasUteis);
        }



        [TestMethod]
        public void DeveTer2DiaUtilDeSegundaATerca()
        {
            //arrange
            var segunda = DiasUteisTestsInitializer.DiasParaTestes[DayOfWeek.Monday];
            var terca = DiasUteisTestsInitializer.DiasParaTestes[DayOfWeek.Tuesday];

            var diaUtil = new DiaUtil();

            //act
            var numDiasUteis = diaUtil.DiasUteisAteData(segunda, terca);

            //assert
            Assert.AreEqual(2, numDiasUteis);
        }

        [TestMethod]
        public void DeveTer2DiaUtilDeDomingoATerca()
        {
            //arrange
            var domingo = DiasUteisTestsInitializer.DiasParaTestes[DayOfWeek.Sunday];
            var terca = DiasUteisTestsInitializer.DiasParaTestes[DayOfWeek.Tuesday];

            var diaUtil = new DiaUtil();

            //act
            var numDiasUteis = diaUtil.DiasUteisAteData(domingo, terca);

            //assert
            Assert.AreEqual(2, numDiasUteis);
        }

        [TestMethod]
        public void DeveTer2DiaUtilDeSabadoATerca()
        {
            //arrange
            var sabado = new DateTime(2018, 03, 24);
            var terca = DiasUteisTestsInitializer.DiasParaTestes[DayOfWeek.Tuesday];

            var diaUtil = new DiaUtil();

            //act
            var numDiasUteis = diaUtil.DiasUteisAteData(sabado, terca);

            //assert
            Assert.AreEqual(2, numDiasUteis);
        }

        [TestMethod]
        public void DeveTer4DiasUteisDeDomingoAQuintaFeira()
        {
            //arrange
            var domingo = DiasUteisTestsInitializer.DiasParaTestes[DayOfWeek.Sunday];
            var quinta = DiasUteisTestsInitializer.DiasParaTestes[DayOfWeek.Thursday];

            var diaUtil = new DiaUtil();

            //act
            var numDiasUteis = diaUtil.DiasUteisAteData(domingo, quinta);

            //assert
            Assert.AreEqual(4, numDiasUteis);
        }

        [TestMethod]
        public void DeveTer10DiasUteisEntreDatas()
        {
            //arrange
            var dataInicio = new DateTime(2018, 03, 01);
            var dataFim = new DateTime(2018, 03, 14);

            var diaUtil = new DiaUtil();

            //act
            var numDiasUteis = diaUtil.DiasUteisAteData(dataInicio, dataFim);

            //assert
            Assert.AreEqual(10, numDiasUteis);
        }
    }
}