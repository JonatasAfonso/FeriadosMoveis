using System;

namespace Feriados
{
    public interface IFeriado
    {
        DateTime ObterPorAno(int ano);
        DateTime ObterProximo(DateTime dataUtc);
        DateTime ObterAnterior(DateTime dataUtc);
        bool EhHoje(DateTime dataUtc);
    }
}