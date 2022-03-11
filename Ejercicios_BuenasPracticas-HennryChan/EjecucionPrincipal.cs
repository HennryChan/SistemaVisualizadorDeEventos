using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios_BuenasPracticas_HennryChan
{
    public class EjecucionPrincipal
    {
        public void InicioPrincipal()
        {
            LogicaEventos ObjLogicaEventos = new LogicaEventos();

            Console.WriteLine("Sistema Visualizador de Eventos\n");
            ObjLogicaEventos.LeerArchivosTxT();

            Console.ReadKey();
        }
    }
}
