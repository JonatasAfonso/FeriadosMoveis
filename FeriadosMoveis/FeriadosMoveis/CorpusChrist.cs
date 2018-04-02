using System;

namespace Catolicos
{
    public class CorpusChrist : Pascoa
    {
        private const int DiasPosterioresApascoa = 60;

        public new DateTime ObterPorAno(int ano)
        {
            //O feriado de Corpo de Deus será 60 dias após o Domingo de Páscoa e será
            //sempre uma quinta - feira, podendo ser entre os dias 21 de Maio e 24 de Junho. 
            var pascoaAnoEscolhido = base.ObterPorAno(ano);
            var feriado = pascoaAnoEscolhido.AddDays(DiasPosterioresApascoa);

            return feriado;
        }

        public new DateTime ObterProximo(DateTime dataUtc)
        {
            //O feriado de Corpo de Deus será 60 dias após o Domingo de Páscoa e será
            //sempre uma quinta - feira, podendo ser entre os dias 21 de Maio e 24 de Junho. 
            var pascoaAnoEscolhido = base.ObterProximo(dataUtc);
            var ultimoferiado = pascoaAnoEscolhido.AddDays(DiasPosterioresApascoa);

            var feriado = dataUtc > ultimoferiado ?
                base.ObterProximo(dataUtc.AddYears(1)).AddDays(DiasPosterioresApascoa) :
                ultimoferiado;

            return feriado;
        }

        public new DateTime ObterAnterior(DateTime dataUtc)
        {
            //O feriado de Corpo de Deus será 60 dias após o Domingo de Páscoa e será
            //sempre uma quinta - feira, podendo ser entre os dias 21 de Maio e 24 de Junho. 
            var pascoaAnoEscolhido = base.ObterPorAno(dataUtc.Year);
            var feriadoDesseAno = pascoaAnoEscolhido.AddDays(DiasPosterioresApascoa);

            if (dataUtc >= feriadoDesseAno)
                return feriadoDesseAno;

            var pascoaAnoPassado = base.ObterPorAno(dataUtc.AddYears(-1).Year);
            var feriadoAnoPassado = pascoaAnoPassado.AddDays(DiasPosterioresApascoa);
            return feriadoAnoPassado;
        }

        public new bool EhHoje(DateTime dataUtc)
        {
            //O feriado de Corpo de Deus será 60 dias após o Domingo de Páscoa e será
            //sempre uma quinta - feira, podendo ser entre os dias 21 de Maio e 24 de Junho. 
            var pascoaAnoEscolhido = base.ObterPorAno(dataUtc.Year);
            var feriado = pascoaAnoEscolhido.AddDays(DiasPosterioresApascoa);
            var ehHoje = dataUtc.Equals(feriado);

            return ehHoje;
        }
    }
}
