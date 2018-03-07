using System;

namespace DataComemorativa
{
    public abstract class DiaDosPais : IFeriado
    {
        public abstract bool EhHoje(DateTime dataUtc);
        public abstract DateTime ObterAnterior(DateTime dataUtc);
        public abstract DateTime ObterPorAno(int ano);
        public abstract DateTime ObterProximo(DateTime dataUtc);
    }
}
