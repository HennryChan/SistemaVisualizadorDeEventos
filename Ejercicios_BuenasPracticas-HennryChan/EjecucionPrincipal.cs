using System;
using System.Collections.Generic;
using System.Text;


namespace Ejercicios_BuenasPracticas_HennryChan
{
    public class EjecucionPrincipal
    {
        public void InicioPrincipal()
        {
            Implementacion.LogicaEvento objLogicaEventos = new Implementacion.LogicaEvento();
            Console.WriteLine("Sistema Visualizador de Eventos\n");
            objLogicaEventos.LeerArchivosTxT();

            Console.ReadKey();
        }
    }
}
