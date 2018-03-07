using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

// ReSharper disable once CheckNamespace
namespace Catolicos.Tests
{
    [TestClass]
    public class CorpusChristTests
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
            var feriado = new CorpusChrist();
            var dataEsperada = new DateTime(2008, 05, 22);

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
            var dataParametro = new DateTime(2008, 05, 22);
            var feriado = new CorpusChrist();
            var dataEsperada = new DateTime(2008, 05, 22);

            //Act
            var dataCalculada = feriado.ObterPorAno(dataParametro.Year);

            //Assert
            Assert.IsNotNull(dataCalculada);
            Assert.AreEqual(dataEsperada, dataCalculada);
        }


        [TestMethod]
        public void DeveriaObterPorAnoQuandoDataInformadaNaoForCorpusChristTest()
        {
            //Arrange
            var dataParametro = new DateTime(2008, 01, 01);
            var feriado = new CorpusChrist();
            var dataEsperada = new DateTime(2008, 05, 22);

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
            var feriado = new CorpusChrist();
            var dataEsperada = new DateTime(2016, 05, 26);

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
            var feriado = new CorpusChrist();
            var dataEsperada = new DateTime(2008, 05, 22);

            //Act
            var dataCalculada = feriado.ObterProximo(dataParametro);

            //Assert
            Assert.IsNotNull(dataCalculada);
            Assert.AreEqual(dataEsperada, dataCalculada);
        }

        [TestMethod]
        public void DeveriaObterProximoQuandoDataParametroForCorpusChristTest()
        {
            //Arrange
            var dataParametro = new DateTime(2008, 05, 22);
            var feriado = new CorpusChrist();
            var dataEsperada = new DateTime(2009, 06, 11);

            //Act
            var dataCalculada = feriado.ObterProximo(dataParametro);

            //Assert
            Assert.IsNotNull(dataCalculada);
            Assert.AreEqual(dataEsperada, dataCalculada);
        }

        [TestMethod]
        public void DeveriaObterProximoQuandoDataParametroForAnteriorCorpusChristTest()
        {
            //Arrange
            var dataParametro = new DateTime(2008, 02, 01);
            var feriado = new CorpusChrist();
            var dataEsperada = new DateTime(2008, 05, 22);

            //Act
            var dataCalculada = feriado.ObterProximo(dataParametro);

            //Assert
            Assert.IsNotNull(dataCalculada);
            Assert.AreEqual(dataEsperada, dataCalculada);
        }

        [TestMethod]
        public void DeveriaObterProximoQuandoDataParametroForPosteriorCorpusChristTest()
        {
            //Arrange
            var dataParametro = new DateTime(2008, 05, 28);
            var feriado = new CorpusChrist();
            var dataEsperada = new DateTime(2009, 06, 11);

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
            var feriado = new CorpusChrist();
            var dataEsperada = new DateTime(2016, 05, 26);

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
            var feriado = new CorpusChrist();
            var dataEsperada = new DateTime(2006, 06, 15);

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
            var feriado = new CorpusChrist();
            var dataEsperada = new DateTime(2006, 06, 15);

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
            var feriado = new CorpusChrist();
            var dataEsperada = new DateTime(2007, 06, 07);

            //Act
            var dataCalculada = feriado.ObterAnterior(dataParametro);

            //Assert
            Assert.IsNotNull(dataCalculada);
            Assert.AreEqual(dataEsperada, dataCalculada);
        }

        [TestMethod]
        public void DeveriaObterAnteriorQuandoDataParametroForPosteriorCorpusChristTest()
        {
            //Arrange
            var dataParametro = new DateTime(2007, 02, 21);
            var feriado = new CorpusChrist();
            var dataEsperada = new DateTime(2006, 06, 15);

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
            var pascoa = new CorpusChrist();
            var dataEsperada = new DateTime(2016, 05, 26);

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
            var dataParametro = new DateTime(2016, 05, 26);
            var feriado = new CorpusChrist();

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
            var feriado = new CorpusChrist();

            //Act
            var ehHoje = feriado.EhHoje(dataParametro);

            //Assert
            Assert.IsFalse(ehHoje);
        }
    }
}