//Subimos el archivo para jugar conGitHub

using System;
using System.Net;
using System.Security.Cryptography;

namespace EjercicioPracticoHerencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehiculo miVehiculo = new Vehiculo("Triciclo");
            Avion miAvion = new Avion("Falcon");
            Coche miCoche = new Coche("Audi");

            miVehiculo.getNombre();
            miVehiculo.ArrancarMotor();
            miVehiculo.Conducir();
            miVehiculo.PararMotor();

            miAvion.getNombre();
            miAvion.ArrancarMotor();
            miAvion.Conducir();
            miAvion.PararMotor();

            miCoche.getNombre();
            miCoche.ArrancarMotor();
            miCoche.Conducir();
            miCoche.PararMotor();

            System.Console.WriteLine("");
            System.Console.WriteLine("Polimorfismo");
            System.Console.WriteLine("");

            Vehiculo miVehiculo2 = miCoche;
            miVehiculo2.Conducir();
            miVehiculo2 = miAvion;
            miVehiculo2.Conducir();
            
        }    
    }

    class Vehiculo
    {
        public Vehiculo(String nombre)
        {
            nombreVehiculo=nombre;
        }

        public void ArrancarMotor()
        {
            System.Console.WriteLine("Vamos a arrancar el motor");
        }
        public void getNombre()
        {
            System.Console.WriteLine("Estoy montado en un: " + nombreVehiculo);
        }
        public void PararMotor()
        {
            System.Console.WriteLine("Vamos a parar el motor");
        }
        public virtual void Conducir()
        {
            System.Console.WriteLine("Estamos conduciendo");
        }
        private String nombreVehiculo;
    }

    class Avion : Vehiculo
    {
        public Avion(String nombreAvion):base(nombreAvion)
        {

        }
        public override void Conducir()
        {
            System.Console.WriteLine("Estamos conduciendo un avión");
        }
    }

    class Coche : Vehiculo
    {
        public Coche(String nombreCoche):base(nombreCoche)
        {

        }
        public override void Conducir()
        {
            System.Console.WriteLine("Estamos conduciendo un coche");
        }
    }
}
