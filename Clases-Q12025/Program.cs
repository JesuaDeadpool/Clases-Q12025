// See https://aka.ms/new-console-template for more information
using Clases_Q12025;

Console.WriteLine("Clases --Aves--");


Ave ave = new Ave();
Ave ave2 = new Ave(); 

ave.Nombre = "Loro";
ave.Especie = "Amazona aestiva";
ave.Color = "Verde";
ave.Tamanio = 30.5;
ave.Habitat = "Bosques Tropicales";
ave.Familia.Nombre = "Psittacidae";
ave.Familia.NumeroEspecie = 393;
ave.Familia.Caracteristicas = "Aves coloridas, a menudo inteligentes"; 


ave.Imprimir();

ave2.Nombre = "Flamenco";
ave2.Especie = "Phoenicopterus roseus";
ave2.Color = "Rosa";
ave2.Tamanio = 120;
ave2.Habitat = "Laguna Salinas";
ave2.Familia.Nombre = "Phoenicopterus";
ave2.Familia.NumeroEspecie = 6;
ave2.Familia.Caracteristicas = "Aves zancudas con patas largas y cuellos largos";

ave2.Imprimir();