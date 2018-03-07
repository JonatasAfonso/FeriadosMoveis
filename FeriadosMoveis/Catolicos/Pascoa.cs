using System;

namespace Catolicos
{
    public class Pascoa : IFeriado
    {
        /// <summary>
        /// Algoritmo de Meeus/Jones/Butcher
        /// </summary>
        /// <param name="ano"></param>
        /// <returns></returns>
        public DateTime ObterPorAno(int ano)
        {
            var a = ano % 19;
            var b = ano / 100;
            var c = ano % 100;//   MOD(ANO; 100)
            var d = b / 4;
            var e = b % 4;// MOD(b; 4)
            var f = (b + 8) / 25;
            var g = (b - f + 1) / 3;
            var h = ((19 * a + b - d - g + 15) % 30);  //   MOD((19 × a + b - d - g + 15); 30)
            var i = c / 4;
            var k = c % 4; //MOD(c; 4)
            var l = ((32 + 2 * e + 2 * i - h - k) % 7);   // MOD((32 + 2 × e + 2 × i - h - k); 7)
            var m = (a + 11 * h + 22 * l) / 451;
            var mes = (h + l - 7 * m + 114) / 31;
            var dia = ((h + l - 7 * m + 114) % 31) + 1;  //MOD((h + L - 7 × m + 114); 31) +1

            return new DateTime(ano, mes, dia);
        }

        public DateTime ObterProximo(DateTime dataUtc)
        {
            var pascoaEsseAno = ObterPorAno(dataUtc.Year);
            var jaOcorreuEsseAno = pascoaEsseAno < dataUtc.Date;

            var proximo = jaOcorreuEsseAno ? ObterPorAno(dataUtc.Year + 1) : pascoaEsseAno;

            return proximo;
        }

        public DateTime ObterAnterior(DateTime dataUtc)
        {
            var pascoaEsseAno = ObterPorAno(dataUtc.Year);
            var jaOcorreuEsseAno = pascoaEsseAno < dataUtc.Date;

            var anterior = jaOcorreuEsseAno ? pascoaEsseAno : ObterPorAno(dataUtc.Year - 1);

            return anterior;
        }

        public bool EhHoje(DateTime dataUtc)
        {
            var pascoaEsseAno = ObterPorAno(dataUtc.Year);
            var ehHoje = dataUtc.Date.Equals(pascoaEsseAno);
            return ehHoje;
        }
    }
}
