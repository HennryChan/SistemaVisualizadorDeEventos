using System;
using System.IO;

namespace Ejercicios_BuenasPracticas_HennryChan
{
    public class MainProgram
    {

        public void InicioPrincipal()
        {
            Console.WriteLine("Sistema Visualizador de Eventos\n");
            LeerArchivosTxT();
            Console.ReadKey();
        }

        public void LeerArchivosTxT()
        {
            string nombreArchivo = @"Eventos.txt";

            string[] lineas = File.ReadAllLines(nombreArchivo);
            SeparacionDatoPorComa(lineas);
        }

        private void SeparacionDatoPorComa(string[] cadenaTxts)
        {
            foreach (var cadenaTxt in cadenaTxts)
            {
                char separador = ',';
                string[] cadenaEvento = cadenaTxt.Split(separador);
                string fechaHora = cadenaEvento[1];
                string nombreEvento = cadenaEvento[0];
                CalcularTiempo(fechaHora, nombreEvento);
            }
        }

        private void CalcularTiempo(string fechaHora, string nombreEvento)
        {
            var tiempoEvento = DateTime.Parse(fechaHora);

            if (tiempoEvento < DateTime.Now)
            {
                string mensaje = " ocurió en ";
                var difFecha = (DateTime.Now - tiempoEvento);
                OrganizarEventoPasado(difFecha, nombreEvento, mensaje);
            }
            else
            {
                string mensaje = " ocurirá en ";
                var difFecha = (tiempoEvento - DateTime.Now);
                OrganizarEventosFuturo(difFecha, nombreEvento,mensaje);
            }
        }

        private void OrganizarEventoPasado(TimeSpan difFecha, string nombreEvento,string mensaje)
        {
            int dias = difFecha.Days;
            int horas = difFecha.Hours;
            int minutos = difFecha.Minutes;
            int meses = CalcularMes(dias);

            if(meses > 0)
            {
                Console.WriteLine(nombreEvento + mensaje + meses + " meses");
            }
            else
            {
                if(dias > 0)
                {
                    Console.WriteLine(nombreEvento + mensaje + dias + " dias");
                }
                else
                {
                    if(horas > 0)
                    {
                        Console.WriteLine(nombreEvento + mensaje + horas + " horas");
                    }
                    else
                    {
                        if(minutos > 0)
                        {
                            Console.WriteLine(nombreEvento + mensaje + minutos + " minutos");
                        }
                    }
                }
            }
        }

        private void OrganizarEventosFuturo( TimeSpan difFecha, string nombreEvento,string mensaje)
        {
            int dias = difFecha.Days;
            int horas = difFecha.Hours;
            int minutos = difFecha.Minutes;
            int meses = CalcularMes(dias);

            if (meses > 0)
            {
                Console.WriteLine(nombreEvento + mensaje + meses + " meses");
            }
            else
            {
                if (dias > 0)
                {
                    Console.WriteLine(nombreEvento + mensaje + dias + " dias");
                }
                else
                {
                    if(horas > 0)
                    {
                        Console.WriteLine(nombreEvento + mensaje + horas + " horas");
                    }
                    else
                    {
                        if(minutos > 0)
                        {
                            Console.WriteLine(nombreEvento + mensaje + minutos + " minutos");
                        }
                    }
                }
            }
        }

        private int CalcularMes(int dias)
        {
            return dias / 30;
        }

        static void Main(string[] args)
        {
            MainProgram SistemaVisailizarEventos = new MainProgram();
            SistemaVisailizarEventos.InicioPrincipal();
        }
    }
}
