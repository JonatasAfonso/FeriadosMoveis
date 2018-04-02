using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Catolicos.Tests
{
    [TestClass]
    public class PascoaTests
    {
        [TestMethod]
        public void DeveriaObterPorAnoTest()
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
        public void DeveriaObterPorAnoQuandoDataInformadaForPascoaTest()
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
        public void DeveriaObterPorAnoQuandoDataInformadaNaoForPascoaTest()
        {
            //Arrange
            var dataParametro = new DateTime(2008, 01, 01);
            var pascoa = new Pascoa();
            var dataEsperada = new DateTime(2008, 03, 23);

            //Act
            var dataCalculada = pascoa.ObterPorAno(dataParametro.Year);

            //Assert
            Assert.IsNotNull(dataCalculada);
            Assert.AreEqual(dataEsperada, dataCalculada);
        }
        
        [TestMethod]
        public void DeveriaObterPorAnoQuandoAnoForBissextoTest()
        {
            //Arrange
            var dataParametro = new DateTime(2016, 01, 01);
            var pascoa = new Pascoa();
            var dataEsperada = new DateTime(2016, 03, 27);

            //Act
            var dataCalculada = pascoa.ObterPorAno(dataParametro.Year);

            //Assert
            Assert.IsNotNull(dataCalculada);
            Assert.AreEqual(dataEsperada, dataCalculada);
        }

        [TestMethod]
        public void DeveriaObterProximoTest()
        {
            //Arrange
            var dataParametro = new DateTime(2008, 03, 21);
            var pascoa = new Pascoa();
            var dataEsperada = new DateTime(2008, 03, 23);

            //Act
            var dataCalculada = pascoa.ObterProximo(dataParametro);

            //Assert
            Assert.IsNotNull(dataCalculada);
            Assert.AreEqual(dataEsperada, dataCalculada);
        }

        [TestMethod]
        public void DeveriaObterProximoQuandoDataParametroForPascoaTest()
        {
            //Arrange
            var dataParametro = new DateTime(2008, 03, 23);
            var pascoa = new Pascoa();
            var dataEsperada = new DateTime(2008, 03, 23);

            //Act
            var dataCalculada = pascoa.ObterProximo(dataParametro);

            //Assert
            Assert.IsNotNull(dataCalculada);
            Assert.AreEqual(dataEsperada, dataCalculada);
        }

        [TestMethod]
        public void DeveriaObterProximoQuandoDataParametroForAnteriorPascoaTest()
        {
            //Arrange
            var dataParametro = new DateTime(2008, 01, 01);
            var pascoa = new Pascoa();
            var dataEsperada = new DateTime(2008, 03, 23);

            //Act
            var dataCalculada = pascoa.ObterProximo(dataParametro);

            //Assert
            Assert.IsNotNull(dataCalculada);
            Assert.AreEqual(dataEsperada, dataCalculada);
        }

        [TestMethod]
        public void DeveriaObterProximoQuandoDataParametroForPosteriorPascoaTest()
        {
            //Arrange
            var dataParametro = new DateTime(2008, 03, 24);
            var pascoa = new Pascoa();
            var dataEsperada = new DateTime(2009, 04, 12);

            //Act
            var dataCalculada = pascoa.ObterProximo(dataParametro);

            //Assert
            Assert.IsNotNull(dataCalculada);
            Assert.AreEqual(dataEsperada, dataCalculada);
        }

        [TestMethod]
        public void DeveriaObterProximoQuandoDataParametroForAnoBissextoTest()
        {
            //Arrange
            var dataParametro = new DateTime(2016, 01, 01);
            var pascoa = new Pascoa();
            var dataEsperada = new DateTime(2016, 03, 27);

            //Act
            var dataCalculada = pascoa.ObterProximo(dataParametro);

            //Assert
            Assert.IsNotNull(dataCalculada);
            Assert.AreEqual(dataEsperada, dataCalculada);
        }
        
        [TestMethod]
        public void DeveriaObterAnteriorTest()
        {
            //Arrange
            var dataParametro = new DateTime(2008, 03, 23);
            var pascoa = new Pascoa();
            var dataEsperada = new DateTime(2007, 04, 08);

            //Act
            var dataCalculada = pascoa.ObterAnterior(dataParametro);

            //Assert
            Assert.IsNotNull(dataCalculada);
            Assert.AreEqual(dataEsperada, dataCalculada);
        }

        [TestMethod]
        public void DeveriaObterAnteriorQuandoDataParametroForPascoaTest()
        {
            //Arrange
            var dataParametro = new DateTime(2008, 03, 23);
            var pascoa = new Pascoa();
            var dataEsperada = new DateTime(2007, 04, 08);

            //Act
            var dataCalculada = pascoa.ObterAnterior(dataParametro);

            //Assert
            Assert.IsNotNull(dataCalculada);
            Assert.AreEqual(dataEsperada, dataCalculada);
        }

        [TestMethod]
        public void DeveriaObterAnteriorQuandoDataParametroForAnteriorPascoaTest()
        {
            //Arrange
            var dataParametro = new DateTime(2008, 01, 01);
            var pascoa = new Pascoa();
            var dataEsperada = new DateTime(2007, 04, 08);

            //Act
            var dataCalculada = pascoa.ObterAnterior(dataParametro);

            //Assert
            Assert.IsNotNull(dataCalculada);
            Assert.AreEqual(dataEsperada, dataCalculada);
        }

        [TestMethod]
        public void DeveriaObterAnteriorQuandoDataParametroForPosteriorPascoaTest()
        {
            //Arrange
            var dataParametro = new DateTime(2008, 03, 24);
            var pascoa = new Pascoa();
            var dataEsperada = new DateTime(2008, 03, 23);

            //Act
            var dataCalculada = pascoa.ObterAnterior(dataParametro);

            //Assert
            Assert.IsNotNull(dataCalculada);
            Assert.AreEqual(dataEsperada, dataCalculada);
        }

        [TestMethod]
        public void DeveriaObterAnteriorQuandoDataParametroForAnoBissextoTest()
        {
            //Arrange
            var dataParametro = new DateTime(2016, 12, 30);
            var pascoa = new Pascoa();
            var dataEsperada = new DateTime(2016, 03, 27);

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
            var dataParametro = new DateTime(2008, 03, 23);
            var pascoa = new Pascoa();

            //Act
            var ehHoje = pascoa.EhHoje(dataParametro);

            //Assert
            Assert.IsTrue(ehHoje);
        }

        [TestMethod]
        public void DeveriaDizerQueNaoEhHojeTest()
        {
            //Arrange
            var dataParametro = new DateTime(2008, 03, 24);
            var pascoa = new Pascoa();

            //Act
            var ehHoje = pascoa.EhHoje(dataParametro);

            //Assert
            Assert.IsFalse(ehHoje);
        }
    }
}