using System;
using System.Collections.Generic;

namespace DiasUteis
{
    public class DiaUtil : IDiaUtil
    {
        public int DiasUteisEntreDatas(DateTime primeiroDia, DateTime ultimoDia, IList<DateTime> feriados = null, IList<DayOfWeek> diasDescanso = null)
        {
            var resultado = 0;
            var numDiasTotal = ultimoDia.Subtract(primeiroDia).Days;
            //Como é entre, o próprio dia, não está incluído
            for (var i = 1; i < numDiasTotal; i++)
            {
                var diaAtual = primeiroDia.AddDays(i);
                if (EhDiaUtil(diaAtual, feriados, diasDescanso))
                    resultado++;
            }

            return resultado;
        }

        public int DiasUteisAteData(DateTime primeiroDia, DateTime ultimoDia, IList<DateTime> feriados = null, IList<DayOfWeek> diasDescanso = null)
        {
            var resultado = 0;
            var numDiasTotal = ultimoDia.Subtract(primeiroDia).Days;

            for (var i = 0; i <= numDiasTotal; i++)
            {
                var diaAtual = primeiroDia.AddDays(i);
                if (EhDiaUtil(diaAtual, feriados, diasDescanso))
                    resultado++;
            }

            return resultado;
        }


        public bool EhDiaUtil(DateTime dia, IList<DateTime> feriados = null, IList<DayOfWeek> diasDescanso = null)
        {
            if (feriados?.Count == 0 && diasDescanso?.Count == 0)
            {
                throw new ArgumentException("Feriados ou Dias de Descanso devem ser informados");
            }

            if (diasDescanso == null)
            {
                diasDescanso = new List<DayOfWeek> { DayOfWeek.Saturday, DayOfWeek.Sunday };
            }

            if (feriados == null)
            {
                feriados = new List<DateTime>();
            }

            var resultado = !(feriados.Contains(dia) || diasDescanso.Contains(dia.DayOfWeek));
            return resultado;
        }


        public DateTime ProximoDiaUtil(DateTime dia, IList<DateTime> feriados = null, IList<DayOfWeek> diasDescanso = null)
        {
            var proximoDia = dia;
            do
            {
                proximoDia = proximoDia.AddDays(1);
            } while (!EhDiaUtil(proximoDia, feriados, diasDescanso));

            return proximoDia;
        }


        /// <summary>
        /// DiaDescanso = Fim de semana (ou dia que a empresa não trabalha, p.ex. o setor de cultura fecha no RJ às segundas-feiras)
        /// </summary>
        /// <param name="dia"></param>
        /// <param name="diasDescanso"></param>
        /// <returns></returns>
        public DateTime ProximoDiaDescanso(DateTime dia, IList<DayOfWeek> diasDescanso = null)
        {
            if (diasDescanso == null)
            {
                diasDescanso = new List<DayOfWeek> { DayOfWeek.Saturday, DayOfWeek.Sunday };
            }

            if (diasDescanso.Count == 0)
            {
                throw new ArgumentException("Dias de Descanso devem ser informados");
            }

            var proximoDia = dia;
            do
            {
                proximoDia = proximoDia.AddDays(1);
            } while (!diasDescanso.Contains(proximoDia.DayOfWeek));

            return proximoDia;
        }


        public DateTime ProximoFeriado(DateTime dia, IList<DateTime> feriados = null)
        {
            if (feriados == null || feriados.Count == 0)
            {
                throw new ArgumentException("Os Feriados devem ser informados");
            }

            var proximoDia = dia;
            do
            {
                proximoDia = proximoDia.AddDays(1);
            } while (!feriados.Contains(proximoDia));

            return proximoDia;
        }

        /// <summary>
        /// Dias de Descanso + Feriados
        /// </summary>
        /// <param name="dia"></param>
        /// <param name="feriados"></param>
        /// <param name="diasDescanso"></param>
        /// <returns></returns>
        public DateTime ProximaFolga(DateTime dia, IList<DateTime> feriados = null, IList<DayOfWeek> diasDescanso = null)
        {
            var proximoDia = dia;
            do
            {
                proximoDia = proximoDia.AddDays(1);
            } while (EhDiaUtil(proximoDia, feriados, diasDescanso));

            return proximoDia;
        }

    }
}
