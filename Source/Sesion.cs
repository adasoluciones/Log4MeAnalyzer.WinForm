using Ada.Framework.Development.Log4Me.Analyzer.Entities;
using System.Collections.Generic;

namespace Ada.Framework.Development.Log4Me.Analyzer.WinForm
{
    public static class Sesion
    {
        public static Analyzer Analyzer = new Analyzer();
        public static EntityMapper Mapper = new EntityMapper();
        public static Loading DialogoCarga = new Loading();

        public static string RutaArchivo { get; set; }

        public static IList<RegistroInLineTO> Registros { get; set; }

        public static IList<ExcepcionTO> Excepciones
        {
            get;
            //{
            //return Hilos.Select(hilo => hilo.Ejecuciones.Where(c => c.Excepcion != null).Select(metodo => metodo.Excepcion)).SelectMany(c => c).ToList();
            //}
            set;
        }

        public static ExcepcionTO ExcepcionActual { get; set; }

        public static HiloTO HiloActual { get; set; }

        public static MetodoTO MetodoActual { get; set; }
    }
}
