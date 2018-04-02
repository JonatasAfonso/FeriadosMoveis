using System;
using System.Collections.Generic;

namespace DiasUteis
{
    public interface IDiaUtil
    {
        int DiasUteisEntreDatas(DateTime primeiroDia, DateTime ultimoDia, IList<DateTime> feriados = null, IList<DayOfWeek> diasDescanso = null);
        int DiasUteisAteData(DateTime primeiroDia, DateTime ultimoDia, IList<DateTime> feriados = null, IList<DayOfWeek> diasDescanso = null);
        bool EhDiaUtil(DateTime dia, IList<DateTime> feriados = null, IList<DayOfWeek> diasDescanso = null);
        DateTime ProximoDiaUtil(DateTime dia, IList<DateTime> feriados = null, IList<DayOfWeek> diasDescanso = null);
        DateTime ProximoFeriado(DateTime dia, IList<DateTime> feriados);
        DateTime ProximoDiaDescanso(DateTime dia, IList<DayOfWeek> diasDescanso);
        DateTime ProximaFolga(DateTime dia, IList<DateTime> feriados = null, IList<DayOfWeek> diasDescanso = null);
    }
}
