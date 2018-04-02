using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Catolicos.Tests
{
    [TestClass]
    public class SextaFeiraSantaTests
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
            var dataParametro = new DateTime(2016, 01, 25);
            var feriado = new SextaFeiraSanta();
            var dataEsperada = new DateTime(2016, 03, 25);

            //Act
            var dataCalculada = feriado.ObterPorAno(dataParametro.Year);

            //Assert
            Assert.IsNotNull(dataCalculada);
            Assert.AreEqual(dataEsperada, dataCalculada);
        }

        [TestMethod]
        public void DeveriaObterPorAnoQuandoDataInformadaForFeriadoTest()
        {
            //Arrange
            var dataParametro = new DateTime(2016, 03, 25);
            var feriado = new SextaFeiraSanta();
            var dataEsperada = new DateTime(2016, 03, 25);

            //Act
            var dataCalculada = feriado.ObterPorAno(dataParametro.Year);

            //Assert
            Assert.IsNotNull(dataCalculada);
            Assert.AreEqual(dataEsperada, dataCalculada);
        }
        
        [TestMethod]
        public void DeveriaObterPorAnoQuandoDataInformadaNaoForSextaFeiraSantaTest()
        {
            //Arrange
            var dataParametro = new DateTime(2016, 01, 01);
            var feriado = new SextaFeiraSanta();
            var dataEsperada = new DateTime(2016, 03, 25);

            //Act
            var dataCalculada = feriado.ObterPorAno(dataParametro.Year);

            //Assert
            Assert.IsNotNull(dataCalculada);
            Assert.AreEqual(dataEsperada, dataCalculada);
        }
        
        [TestMethod]
        public void DeveriaObterPorAnoQuandoAnoForBissextoTest()
        {
            //Arrange
            var dataParametro = new DateTime(2016, 01, 01);
            var feriado = new SextaFeiraSanta();
            var dataEsperada = new DateTime(2016, 03, 25);

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
            var dataParametro = new DateTime(2016, 03, 01);
            var feriado = new SextaFeiraSanta();
            var dataEsperada = new DateTime(2016, 03, 25);

            //Act
            var dataCalculada = feriado.ObterProximo(dataParametro);

            //Assert
            Assert.IsNotNull(dataCalculada);
            Assert.AreEqual(dataEsperada, dataCalculada);
        }

        [TestMethod]
        public void DeveriaObterProximoQuandoDataParametroForSextaFeiraSantaTest()
        {
            //Arrange
            var dataParametro = new DateTime(2016, 03, 25);
            var feriado = new SextaFeiraSanta();
            var dataEsperada = new DateTime(2016, 03, 25);

            //Act
            var dataCalculada = feriado.ObterProximo(dataParametro);

            //Assert
            Assert.IsNotNull(dataCalculada);
            Assert.AreEqual(dataEsperada, dataCalculada);
        }

        [TestMethod]
        public void DeveriaObterProximoQuandoDataParametroForAnteriorSextaFeiraSantaTest()
        {
            //Arrange
            var dataParametro = new DateTime(2016, 03, 01);
            var feriado = new SextaFeiraSanta();
            var dataEsperada = new DateTime(2016, 03, 25);

            //Act
            var dataCalculada = feriado.ObterProximo(dataParametro);

            //Assert
            Assert.IsNotNull(dataCalculada);
            Assert.AreEqual(dataEsperada, dataCalculada);
        }

        [TestMethod]
        public void DeveriaObterProximoQuandoDataParametroForPosteriorSextaFeiraSantaTest()
        {
            //Arrange
            var dataParametro = new DateTime(2015, 12, 02);
            var feriado = new SextaFeiraSanta();
            var dataEsperada = new DateTime(2016, 03, 25);

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
            var feriado = new SextaFeiraSanta();
            var dataEsperada = new DateTime(2016, 03, 25);

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
            var dataParametro = new DateTime(2016, 03, 28);
            var feriado = new SextaFeiraSanta();
            var dataEsperada = new DateTime(2016, 03, 25);

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
            var dataParametro = new DateTime(2016, 03, 25);
            var feriado = new SextaFeiraSanta();
            var dataEsperada = new DateTime(2016, 03, 25);

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
            var dataParametro = new DateTime(2017, 01, 01);
            var feriado = new SextaFeiraSanta();
            var dataEsperada = new DateTime(2016, 03, 25);

            //Act
            var dataCalculada = feriado.ObterAnterior(dataParametro);

            //Assert
            Assert.IsNotNull(dataCalculada);
            Assert.AreEqual(dataEsperada, dataCalculada);
        }

        [TestMethod]
        public void DeveriaObterAnteriorQuandoDataParametroForPosteriorSextaFeiraSantaTest()
        {
            //Arrange
            var dataParametro = new DateTime(2016, 12, 31);
            var feriado = new SextaFeiraSanta();
            var dataEsperada = new DateTime(2016, 03, 25);

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
            var pascoa = new SextaFeiraSanta();
            var dataEsperada = new DateTime(2016, 03, 25);

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
            var dataParametro = new DateTime(2016, 03, 25);
            var feriado = new SextaFeiraSanta();

            //Act
            var ehHoje = feriado.EhHoje(dataParametro);

            //Assert
            Assert.IsTrue(ehHoje);
        }

        [TestMethod]
        public void DeveriaDizerQueNaoEhHojeTest()
        {
            //Arrange
            var dataParametro = new DateTime(2016, 03, 26);
            var feriado = new SextaFeiraSanta();

            //Act
            var ehHoje = feriado.EhHoje(dataParametro);

            //Assert
            Assert.IsFalse(ehHoje);
        }
    }
}