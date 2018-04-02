using System;

namespace Catolicos
{
    public class Carnaval : Pascoa
    {
        private const int DiasAnterioresApascoa = -47;

        public new DateTime ObterPorAno(int ano)
        {
            //A Terça-feira de Carnaval será 47 dias antes do Domingo de Páscoa, podendo
            //ser entre os dias 3 de Fevereiro e 8 de Março. 
            var pascoaAnoEscolhido = base.ObterPorAno(ano);
            var carnaval = pascoaAnoEscolhido.AddDays(DiasAnterioresApascoa);

            return carnaval;
        }

        public new DateTime ObterProximo(DateTime dataUtc)
        {
            //A Terça-feira de Carnaval será 47 dias antes do Domingo de Páscoa, podendo
            //ser entre os dias 3 de Fevereiro e 8 de Março. 
            var pascoaAnoEscolhido = base.ObterProximo(dataUtc);
            var ultimoCarnaval = pascoaAnoEscolhido.AddDays(DiasAnterioresApascoa);

            var carnaval = dataUtc > ultimoCarnaval ?
                base.ObterProximo(dataUtc.AddYears(1)).AddDays(DiasAnterioresApascoa) :
                ultimoCarnaval;

            return carnaval;
        }

        public new DateTime ObterAnterior(DateTime dataUtc)
        {
            //A Terça-feira de Carnaval será 47 dias antes do Domingo de Páscoa, podendo
            //ser entre os dias 3 de Fevereiro e 8 de Março. 
            var pascoaAnoEscolhido = base.ObterPorAno(dataUtc.Year);
            var carnavalDesseAno = pascoaAnoEscolhido.AddDays(DiasAnterioresApascoa);

            if (dataUtc >= carnavalDesseAno)
                return carnavalDesseAno;

            var pascoaAnoPassado = base.ObterPorAno(dataUtc.AddYears(-1).Year);
            var carnavalAnoPassado = pascoaAnoPassado.AddDays(DiasAnterioresApascoa);
            return carnavalAnoPassado;
        }

        public new bool EhHoje(DateTime dataUtc)
        {
            //A Terça-feira de Carnaval será 47 dias antes do Domingo de Páscoa, podendo
            //ser entre os dias 3 de Fevereiro e 8 de Março. 
            var pascoaAnoEscolhido = base.ObterPorAno(dataUtc.Year);
            var carnaval = pascoaAnoEscolhido.AddDays(DiasAnterioresApascoa);
            var ehHoje = dataUtc.Equals(carnaval);

            return ehHoje;
        }
    }
}
