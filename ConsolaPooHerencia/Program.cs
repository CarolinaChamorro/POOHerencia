﻿using System;
using System.Collections.Generic;
using SolucionAppLogica;

namespace ConsolaPooHerencia
{
    class Program
    {
        static void Main(string[] args)
        {

            //Instancias de Celular
            Celular cel1 = new Celular("Redmini 8","Xiaomi","32GB","4GB",330);
            Celular cel2 = new Celular("A50", "Samsung", "16GB", "4GB", 250);
            //Instancias de Computadora
            Computadora compu1= new Computadora("Notebook", "HP", "1TB", "8th", 820);
            Computadora compu2 = new Computadora("Notebook", "Toshiba", "1TB", "5th", 590);
            //Instancias de RelojDigital
            RelojDigital reloj1 = new RelojDigital("SmartWatch 4", "Xiaomi",  40);
            RelojDigital reloj2 = new RelojDigital("SmarFitness", "LG", 35);
            //Instancias de Lavadora
            Lavadora lava1 = new Lavadora("Twin Wash", "Whirlpool.", 345);
            Lavadora lava2 = new Lavadora("Turbo drum", "LG.", 487);
            //Instancias de Refrigeradora
            Refrigeradora refri1 = new Refrigeradora("RMA430FY0EU", "Indurama", 630);
            Refrigeradora refri2 = new Refrigeradora("CR-568", "Mabe", 489);
            //Instancias de Televisón
            Television tv1 = new Television("LED SMART 4K RLED", "Rivera", 271);
            Television tv2 = new Television("LED Smart LG 49UK6300", "LG", 236);
            Cliente clienteSatisfecho1 = new Cliente
            {
                Nombre = "Sarabi",
                Mitv=tv1,
                Milava=lava2,
                Micelu=cel2
            };
            Cliente clienteSatisfecho2 = new Cliente
            {
                Nombre = "Camila",
                Mirefri=refri2,
                Milava=lava1,
                Micelu=cel1
            };
            Cliente clienteSatisfecho3 = new Cliente
            {
                Nombre = "Lauren",
                Mitv=tv2,
                Mireloj=reloj1,
                Micomputadora=compu2
            };


            List<ProductoTecnologico> ListaTecnologica = new List<ProductoTecnologico>();
            ListaTecnologica.Add(cel1);
            ListaTecnologica.Add(cel2);
            ListaTecnologica.Add(compu1);
            ListaTecnologica.Add(compu2);
            ListaTecnologica.Add(reloj1);
            ListaTecnologica.Add(reloj2);

            List<ProductoElectrodomestico> ListaElectrodomestica = new List<ProductoElectrodomestico>();
            ListaElectrodomestica.Add(tv1);
            ListaElectrodomestica.Add(tv2);
            ListaElectrodomestica.Add(refri1);
            ListaElectrodomestica.Add(refri2);
            ListaElectrodomestica.Add(lava1);
            ListaElectrodomestica.Add(lava2);


            Console.WriteLine($"\tSIMULACIÓN PRUEBAS PRODUCTOS ELECTRONICOS Y TECNOLOGICOS");
            Console.WriteLine($"------------------------------------------------------");
            Console.WriteLine($"- ");
            Console.WriteLine($"------------------------------------------------------");
            Console.WriteLine("Ingrese su nombre");
            var nombreCliente=Console.ReadLine();
            Console.WriteLine($"*Bienvenido/a {nombreCliente}");
            
            //Opciones
            Console.WriteLine("¿Qué opción escoges?: ");
            Console.WriteLine("\ta - Aparatos tecnológicos");
            Console.WriteLine("\tb - Aparatos electrodomésticos");

            //Respuestas
            var opcionAparato = Console.ReadLine();
            switch (opcionAparato)
            {
                case "a":
                    foreach(ProductoTecnologico item in ListaTecnologica)
                    {
                        item.VerListaTecno();
                    }
                  
                    break;
                case "b":
                    foreach (ProductoElectrodomestico item in ListaElectrodomestica)
                    {
                        item.VerListaElectro();
                    }
                

                    break;
            }

            if(opcionAparato=="a")
            {
                Console.WriteLine("¿Qué vas a comprar?:Coloca un número del 1 al 6 de acuerdo" +
                    "a la posición del articulo ");
                var opcionA = Console.ReadLine();
                switch (opcionA)
                {
                    case "1":
                        Console.WriteLine($"Usted ha comprado {cel1.Modelo} {cel1.Marca}");
                        Console.WriteLine($"{cel1.Describir()}");
                        Console.WriteLine($"Funcionalidades:");
                        Console.WriteLine($"{cel1.Encender()}");
                        Console.WriteLine($"{cel1.Conectar("red-Carolina")}");
                        Console.WriteLine($"{cel1.Describir("Alta")}");
                        Console.WriteLine($"{cel1.Apagar()}");

                        break;
                    case "2":
                        Console.WriteLine($"Usted ha comprado {cel2.Modelo} {cel2.Marca}");
                        Console.WriteLine($"{cel2.Describir()}");
                        Console.WriteLine($"Funcionalidades:");
                        Console.WriteLine($"{cel2.Encender()}");
                        Console.WriteLine($"{cel2.Conectar("red-Administrador")}");
                        Console.WriteLine($"{cel2.Describir("Baja")}");
                        Console.WriteLine($"{cel2.Apagar()}");
                        break;
                    case "3":
                        Console.WriteLine($"Usted ha comprado {compu1.Modelo} {compu1.Marca}");
                        Console.WriteLine($"{compu1.Describir()}");
                        Console.WriteLine($"Funcionalidades:");
                        Console.WriteLine($"{compu1.Encender()}");
                        Console.WriteLine($"{compu1.DescargarArchivos()}");
                        Console.WriteLine($"{compu1.VideoLlamada()}");
                        Console.WriteLine($"{compu1.Apagar()}");
                        break;
                    case "4":
                        Console.WriteLine($"Usted ha comprado {compu2.Modelo} {compu2.Marca}");
                        Console.WriteLine($"{compu2.Describir()}");
                        Console.WriteLine($"Funcionalidades:");
                        Console.WriteLine($"{compu2.Encender()}");
                        Console.WriteLine($"{compu2.DescargarArchivos()}");
                        Console.WriteLine($"{compu2.VideoLlamada()}");
                        Console.WriteLine($"{compu2.Apagar()}");
                        break;
                    case "5":
                        Console.WriteLine($"Usted ha comprado {reloj1.Modelo} {reloj1.Marca}");
                        Console.WriteLine($"{reloj1.Describir()}");
                        Console.WriteLine($"Funcionalidades:");
                        Console.WriteLine($"{reloj1.Encender()}");
                        Console.WriteLine($"{reloj1.ContarPasos()}");
                        Console.WriteLine($"{reloj1.TomarPulso()}");
                        Console.WriteLine($"{reloj1.Apagar()}");
                        break;
                    case "6":
                        Console.WriteLine($"Usted ha comprado {reloj2.Modelo} {reloj2.Marca}");
                        Console.WriteLine($"{reloj2.Describir()}");
                        Console.WriteLine($"Funcionalidades:");
                        Console.WriteLine($"{reloj2.Encender()}");
                        Console.WriteLine($"{reloj2.ContarPasos()}");
                        Console.WriteLine($"{reloj2.TomarPulso()}");
                        Console.WriteLine($"{reloj2.Apagar()}");
                        break;
                }
            }
            if(opcionAparato=="b")
            {
                Console.WriteLine("¿Qué vas a comprar?:Coloca un número del 1 al 6 de acuerdo la posición del articulo");
                var opcionB = Console.ReadLine();
                switch (opcionB)
                {
                    case "1":
                        Console.WriteLine($"Usted ha comprado {tv1.Modelo} {tv1.Marca}");
                        Console.WriteLine($"{tv1.Describir()}");
                        Console.WriteLine($"Funcionalidades:");
                        Console.WriteLine($"{tv1.Encender()}");
                        Console.WriteLine($"{tv1.Conectar("red_Carolina")}");
                        Console.WriteLine($"{tv1.Funciones("reproduciendo un video en Youtube")}");
                        Console.WriteLine($"{tv1.Apagar()}");
                        break;
                    case "2":
                        Console.WriteLine($"Usted ha comprado {tv2.Modelo} {tv2.Marca}");
                        Console.WriteLine($"{tv2.Describir()}");
                        Console.WriteLine($"Funcionalidades:");
                        Console.WriteLine($"{tv2.Encender()}");
                        Console.WriteLine($"{tv2.Conectar("red_Carolina")}");
                        Console.WriteLine($"{tv2.Funciones("reproduciendo Netflix")}");
                        Console.WriteLine($"{tv2.Apagar()}");
                        break;
                    case "3":
                        Console.WriteLine($"Usted ha comprado {refri1.Modelo} {refri1.Marca}");
                        Console.WriteLine($"{refri1.Describir()}");
                        Console.WriteLine($"Funcionalidades:");
                        Console.WriteLine($"{refri1.Encender()}");
                        Console.WriteLine($"{refri1.AbrirRefri()}");
                        Console.WriteLine($"{refri1.Apagar()}");
                        break;
                    case "4":
                        Console.WriteLine($"Usted ha comprado {refri2.Marca} {refri2}");
                        Console.WriteLine($"{refri2.Describir()}");
                        Console.WriteLine($"Funcionalidades:");
                        Console.WriteLine($"{refri2.Encender()}");
                        Console.WriteLine($"{refri2.AbrirRefri()}");
                        Console.WriteLine($"{refri2.Apagar()}");
                        break;
                    case "5":
                        Console.WriteLine($"Usted ha comprado {lava1.Modelo} {lava1.Marca}");
                        Console.WriteLine($"{lava1.Describir()}");
                        Console.WriteLine($"Funcionalidades:");
                        Console.WriteLine($"{lava1.Encender()}");
                        Console.WriteLine($"{lava1.Usar("centrifugando")}");
                        Console.WriteLine($"{lava1.Apagar()}");
                        break;
                    case "6":
                        Console.WriteLine($"Usted ha comprado {lava2.Modelo} {lava2.Marca}");
                        Console.WriteLine($"{lava2.Describir()}");
                        Console.WriteLine($"Funcionalidades:");
                        Console.WriteLine($"{lava2.Encender()}");
                        Console.WriteLine($"{lava2.Usar("lavando en seco")}");
                        Console.WriteLine($"{lava2.Apagar()}");
                        break;
                }
            }
            Console.WriteLine($"------------------------------------------------------");
            Console.WriteLine("Nuestro clientes satisfechos");
            Console.WriteLine($"------------------------------------------------------");

            Console.WriteLine($"{clienteSatisfecho1.Nombre} adquirió una televisión {clienteSatisfecho1.Mitv.Modelo} {clienteSatisfecho1.Mitv.Marca}," +
                $" una lavadora {clienteSatisfecho1.Milava.Modelo} {clienteSatisfecho1.Milava.Marca}  y un celular {clienteSatisfecho1.Micelu.Modelo} {clienteSatisfecho1.Micelu.Marca}");

            Console.WriteLine($"{clienteSatisfecho2.Nombre} adquirió una refrigeradora {clienteSatisfecho2.Mirefri.Modelo} {clienteSatisfecho2.Mirefri.Marca}," +
                $" una lavadora {clienteSatisfecho2.Milava.Modelo} {clienteSatisfecho2.Milava.Marca} y un celular {clienteSatisfecho2.Micelu.Modelo} {clienteSatisfecho2.Micelu.Marca}");

            Console.WriteLine($"{clienteSatisfecho3.Nombre} adquirió una televisión {clienteSatisfecho3.Mitv.Modelo} {clienteSatisfecho3.Mitv.Marca}," +
                $"{clienteSatisfecho3.Mireloj.Modelo} {clienteSatisfecho3.Mireloj.Marca} y {clienteSatisfecho3.Micomputadora.Modelo} {clienteSatisfecho3.Micomputadora.Marca}");

            Console.ReadKey();





        }
    }
}
