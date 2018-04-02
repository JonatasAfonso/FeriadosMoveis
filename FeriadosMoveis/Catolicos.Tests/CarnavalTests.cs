using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

 
namespace Catolicos.Tests
{
    [TestClass]
    public class CarnavalTests
    {
        [TestMethod]
        public void DeveriaObterPascoaPorAnoTest()
        {
            //Arrange
            var dataParametro = new DateTime(2008, 03, 23);
            var pascoa = new Pascoa();
            var dataEsperada = new DateTime(2008, 03, 23);

            //Act
            var dataCalculada = pascoa.ObterPorAno(dataParametro.Year);

            //Assert
            Assert.IsNotNull(dataCalculada);
            Assert.AreEqual(dataEsperada, dataCalculada);
        }

        [TestMethod]
        public void DeveriaObterPorAnoTest()
        {
            //Arrange
            var dataParametro = new DateTime(2008, 03, 23);
            var carnaval = new Carnaval();
            var dataEsperada = new DateTime(2008, 02, 05);

            //Act
            var dataCalculada = carnaval.ObterPorAno(dataParametro.Year);

            //Assert
            Assert.IsNotNull(dataCalculada);
            Assert.AreEqual(dataEsperada, dataCalculada);
        }





        [TestMethod]
        public void DeveriaObterPorAnoQuandoDataInformadaForCarnavalTest()
        {
            //Arrange
            var dataParametro = new DateTime(2008, 02, 05);
            var carnaval = new Carnaval();
            var dataEsperada = new DateTime(2008, 02, 05);

            //Act
            var dataCalculada = carnaval.ObterPorAno(dataParametro.Year);

            //Assert
            Assert.IsNotNull(dataCalculada);
            Assert.AreEqual(dataEsperada, dataCalculada);
        }


        [TestMethod]
        public void DeveriaObterPorAnoQuandoDataInformadaNaoForCarnavalTest()
        {
            //Arrange
            var dataParametro = new DateTime(2008, 01, 01);
            var carnaval = new Carnaval();
            var dataEsperada = new DateTime(2008, 02, 05);

            //Act
            var dataCalculada = carnaval.ObterPorAno(dataParametro.Year);

            //Assert
            Assert.IsNotNull(dataCalculada);
            Assert.AreEqual(dataEsperada, dataCalculada);
        }


        [TestMethod]
        public void DeveriaObterPorAnoQuandoAnoForBissextoTest()
        {
            //Arrange
            var dataParametro = new DateTime(2016, 01, 01);
            var feriado = new Carnaval();
            var dataEsperada = new DateTime(2016, 02, 09);

            //Act
            var dataCalculada = feriado.ObterPorAno(dataParametro.Year);

            //Assert
            Assert.IsNotNull(dataCalculada);
            Assert.AreEqual(dataEsperada, dataCalculada);
        }




        [TestMethod]
        public void DeveriaObterProximoTest()
        {
            //Arrange
            var dataParametro = new DateTime(2008, 01, 23);
            var feriado = new Carnaval();
            var dataEsperada = new DateTime(2008, 02, 05);

            //Act
            var dataCalculada = feriado.ObterProximo(dataParametro);

            //Assert
            Assert.IsNotNull(dataCalculada);
            Assert.AreEqual(dataEsperada, dataCalculada);
        }

        [TestMethod]
        public void DeveriaObterProximoQuandoDataParametroForCarnavalTest()
        {
            //Arrange
            var dataParametro = new DateTime(2008, 02, 05);
            var feriado = new Carnaval();
            var dataEsperada = new DateTime(2008, 02, 05);

            //Act
            var dataCalculada = feriado.ObterProximo(dataParametro);

            //Assert
            Assert.IsNotNull(dataCalculada);
            Assert.AreEqual(dataEsperada, dataCalculada);
        }

        [TestMethod]
        public void DeveriaObterProximoQuandoDataParametroForAnteriorCarnavalTest()
        {
            //Arrange
            var dataParametro = new DateTime(2008, 02, 01);
            var feriado = new Carnaval();
            var dataEsperada = new DateTime(2008, 02, 05);

            //Act
            var dataCalculada = feriado.ObterProximo(dataParametro);

            //Assert
            Assert.IsNotNull(dataCalculada);
            Assert.AreEqual(dataEsperada, dataCalculada);
        }

        [TestMethod]
        public void DeveriaObterProximoQuandoDataParametroForPosteriorCarnavalTest()
        {
            //Arrange
            var dataParametro = new DateTime(2008, 02, 28);
            var feriado = new Carnaval();
            var dataEsperada = new DateTime(2009, 02, 24);

            //Act
            var dataCalculada = feriado.ObterProximo(dataParametro);

            //Assert
            Assert.IsNotNull(dataCalculada);
            Assert.AreEqual(dataEsperada, dataCalculada);
        }

        [TestMethod]
        public void DeveriaObterProximoQuandoDataParametroForAnoBissextoTest()
        {
            //Arrange
            var dataParametro = new DateTime(2016, 01, 01);
            var feriado = new Carnaval();
            var dataEsperada = new DateTime(2016, 02, 09);

            //Act
            var dataCalculada = feriado.ObterProximo(dataParametro);

            //Assert
            Assert.IsNotNull(dataCalculada);
            Assert.AreEqual(dataEsperada, dataCalculada);
        }






        [TestMethod]
        public void DeveriaObterAnteriorTest()
        {
            //Arrange
            var dataParametro = new DateTime(2007, 03, 23);
            var feriado = new Carnaval();
            var dataEsperada = new DateTime(2007, 02, 20);

            //Act
            var dataCalculada = feriado.ObterAnterior(dataParametro);

            //Assert
            Assert.IsNotNull(dataCalculada);
            Assert.AreEqual(dataEsperada, dataCalculada);
        }

        [TestMethod]
        public void DeveriaObterAnteriorQuandoDataParametroForFeriadoTest()
        {
            //Arrange
            var dataParametro = new DateTime(2007, 02, 20);
            var feriado = new Carnaval();
            var dataEsperada = new DateTime(2007, 02, 20);

            //Act
            var dataCalculada = feriado.ObterAnterior(dataParametro);

            //Assert
            Assert.IsNotNull(dataCalculada);
            Assert.AreEqual(dataEsperada, dataCalculada);
        }

        [TestMethod]
        public void DeveriaObterAnteriorQuandoDataParametroForAnteriorFeriadoTest()
        {
            //Arrange
            var dataParametro = new DateTime(2008, 01, 01);
            var feriado = new Carnaval();
            var dataEsperada = new DateTime(2007, 02, 20);

            //Act
            var dataCalculada = feriado.ObterAnterior(dataParametro);

            //Assert
            Assert.IsNotNull(dataCalculada);
            Assert.AreEqual(dataEsperada, dataCalculada);
        }

        [TestMethod]
        public void DeveriaObterAnteriorQuandoDataParametroForPosteriorCarnavalTest()
        {
            //Arrange
            var dataParametro = new DateTime(2007, 02, 21);
            var feriado = new Carnaval();
            var dataEsperada = new DateTime(2007, 02, 20);

            //Act
            var dataCalculada = feriado.ObterAnterior(dataParametro);

            //Assert
            Assert.IsNotNull(dataCalculada);
            Assert.AreEqual(dataEsperada, dataCalculada);
        }

        [TestMethod]
        public void DeveriaObterAnteriorQuandoDataParametroForAnoBissextoTest()
        {
            //Arrange
            var dataParametro = new DateTime(2016, 12, 30);
            var pascoa = new Carnaval();
            var dataEsperada = new DateTime(2016, 02, 09);

            //Act
            var dataCalculada = pascoa.ObterAnterior(dataParametro);

            //Assert
            Assert.IsNotNull(dataCalculada);
            Assert.AreEqual(dataEsperada, dataCalculada);
        }




        [TestMethod]
        public void DeveriaDizerQueEhHojeTest()
        {
            //Arrange
            var dataParametro = new DateTime(2016, 02, 09);
            var feriado = new Carnaval();

            //Act
            var ehHoje = feriado.EhHoje(dataParametro);

            //Assert
            Assert.IsTrue(ehHoje);
        }



        [TestMethod]
        public void DeveriaDizerQueNaoEhHojeTest()
        {
            //Arrange
            var dataParametro = new DateTime(2016, 02, 10);
            var feriado = new Carnaval();

            //Act
            var ehHoje = feriado.EhHoje(dataParametro);

            //Assert
            Assert.IsFalse(ehHoje);
        }
    }
}