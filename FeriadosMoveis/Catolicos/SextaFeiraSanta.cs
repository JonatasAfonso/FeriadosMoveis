using System;

namespace Catolicos
{
    public class SextaFeiraSanta : Pascoa
    {
        private const int DiasAnterioresApascoa = -2;

        public new DateTime ObterPorAno(int ano)
        {
            //A Terça-feira de Carnaval será 47 dias antes do Domingo de Páscoa, podendo
            //ser entre os dias 3 de Fevereiro e 8 de Março. 
            var pascoaAnoEscolhido = base.ObterPorAno(ano);
            var feriado = pascoaAnoEscolhido.AddDays(DiasAnterioresApascoa);

            return feriado;
        }

        public new DateTime ObterProximo(DateTime dataUtc)
        {
            //A Terça-feira de Carnaval será 47 dias antes do Domingo de Páscoa, podendo
            //ser entre os dias 3 de Fevereiro e 8 de Março. 
            var pascoaAnoEscolhido = base.ObterProximo(dataUtc);
            var ultimoCarnaval = pascoaAnoEscolhido.AddDays(DiasAnterioresApascoa);

            var feriado = dataUtc > ultimoCarnaval ?
                base.ObterProximo(dataUtc.AddYears(1)).AddDays(DiasAnterioresApascoa) :
                ultimoCarnaval;

            return feriado;
        }

        public new DateTime ObterAnterior(DateTime dataUtc)
        {
            //A Terça-feira de Carnaval será 47 dias antes do Domingo de Páscoa, podendo
            //ser entre os dias 3 de Fevereiro e 8 de Março. 
            var pascoaAnoEscolhido = base.ObterPorAno(dataUtc.Year);
            var feriadoDesseAno = pascoaAnoEscolhido.AddDays(DiasAnterioresApascoa);

            if (dataUtc >= feriadoDesseAno)
                return feriadoDesseAno;

            var pascoaAnoPassado = base.ObterPorAno(dataUtc.AddYears(-1).Year);
            var feriadoAnoPassado = pascoaAnoPassado.AddDays(DiasAnterioresApascoa);
            return feriadoAnoPassado;
        }

        public new bool EhHoje(DateTime dataUtc)
        {
            //A Terça-feira de Carnaval será 47 dias antes do Domingo de Páscoa, podendo
            //ser entre os dias 3 de Fevereiro e 8 de Março. 
            var pascoaAnoEscolhido = base.ObterPorAno(dataUtc.Year);
            var feriado = pascoaAnoEscolhido.AddDays(DiasAnterioresApascoa);
            var ehHoje = dataUtc.Equals(feriado);

            return ehHoje;
        }
    }
}
