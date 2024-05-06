namespace DotNet_simpleExcercises
{
    class Casa
    {

    }

    class Calefactor : Casa
    {
        bool estadoCalefactor = false;
        int temperaturaCalefactor = 0;

        void Encender()
        {
            estadoCalefactor = true;
            Console.WriteLine("El calefactor se encendio.");
        }

        void Apagar()
        {
            estadoCalefactor = false;
            Console.WriteLine("El calefactor se apago.");
        }
        
        void FijarTemperatura(int valorTemperatuta)
        {
            if (valorTemperatuta < -5 || valorTemperatuta > 40)
            {
                Console.WriteLine("Valor no apto para el calefactor.");
            }
            else
            {
                temperaturaCalefactor = valorTemperatuta;
                Console.WriteLine("Se ha fijado la tempertura del calefactor en: " + temperaturaCalefactor + "°c.");
            }
        }
    }

    class Puerta : Casa
    {
        bool estadoPuerta = false;

        void AbrirPuerta()
        {
            estadoPuerta = true;
            Console.WriteLine("La puerta se ha abierto.");
        }

        void CerrarPuerta()
        {
            estadoPuerta = false;
            Console.WriteLine("La puerta se ha cerrado.");
        }
    }


    class Ventana : Casa
    {
        bool estadoVentana = false;

        void AbrirVentana()
        {
            estadoVentana = true;
            Console.WriteLine("La ventana se ha abierto.");
        }

        void CerrarVentana()
        {
            estadoVentana = false;
            Console.WriteLine("La ventana se ha cerrado.");
        }
    }

    class Persiana : Ventana
    {
        bool estadoPersiana = false;

        void AbrirPuerta()
        {
            estadoPersiana = true;
            Console.WriteLine("La persiana se ha abierto.");
        }

        void CerrarPuerta()
        {
            estadoPersiana = false;
            Console.WriteLine("La persiana se ha cerrado.");
        }
    }
}