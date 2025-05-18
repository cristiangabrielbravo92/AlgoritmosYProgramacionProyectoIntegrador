/*
 * Created by SharpDevelop.
 * User: Cristian Bravo
 * Date: 28/4/2025
 * Time: 16:19
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Proyecto_Integrador
{
	class Program
	{
		public static void Main(string[] args)
		{
			// declaro las variables para poder empezar a usarlas, queda pendiente ver cuáles se usan como variables globales y cuáles locales
			Empresa empresa;
			Obra obra;
			GrupoDeObreros obreros;
			Obrero obrero;
			JefeDeObra jefeObra;
			string opcion;
			
			empresa = new Empresa("Corporación ACME");
			
			imprimirBienvenida(empresa);
			
			opcion = "-";
			mostrarMenuPrincipal();
			opcion = solicitarOpcion();
			while (opcion != "7") {
				// la idea del menú principal es manejarlo con un while y un switch
				switch (opcion) {
					case "1":
						// acá van las operaciones de la opcion 1
						Console.WriteLine("Trabajo en progreso1...");
						break;
					case "2":
						// acá van las operaciones de la opcion 2
						Console.WriteLine("Trabajo en progreso2...");
						break;
					case "3":
						// acá van las operaciones de la opcion 3
						Console.WriteLine("Trabajo en progreso3...");
						break;
					case "4":
						// acá van las operaciones de la opcion 4
						mostrarSubmenuImpresiones();
						
						
						break;
					case "5":
						// acá van las operaciones de la opcion 4
						Console.WriteLine("Trabajo en progreso5...");
						
						break;
					case "6":
						// acá van las operaciones de la opcion 4
						Console.WriteLine("Trabajo en progreso6...");
						
						break;
					default:
						Console.WriteLine("No existe la opción ingresada");
						Console.WriteLine("-------------------------------------------------------------");
						break;
				}
				mostrarMenuPrincipal();
				opcion = solicitarOpcion();
				
			}
			
			
			
			
			
			
			
			
			
			
			
			// ----- Final del programa -----
			Console.WriteLine("\n");
			Console.Write("Presione alguna tecla para salir . . . ");
			Console.ReadKey(true);
		}
		
		static void imprimirBienvenida(Empresa empresa) {
			Console.WriteLine(" --- Bienvenido a la administración de {0} ---", empresa.NombreEmpresa);
		}
		
		static string solicitarOpcion() {
			Console.Write("Ingrese la opcion seleccionada por teclado y luego presione enter: ");
			return Console.ReadLine();
		}
		
		static void mostrarOpcionesMenuPrincipal() {
			Console.WriteLine("1 - Dar de alta un obrero");
			Console.WriteLine("2 - Dar de baja un obrero");
			Console.WriteLine("3 - Dar de alta un jefe de obra");
			Console.WriteLine("4 - Ver información específica de obras, obreros o jefes de obras");
			Console.WriteLine("5 - Modificar el estado de avance de una obra");
			Console.WriteLine("6 - Dar de baja un jefe de obra");
			Console.WriteLine("7 - Salir");
		}
		
		static void mostrarMenuPrincipal() {
			Console.WriteLine(" ----- Menú de Inicio ----- ");
			Console.WriteLine("Seleccione qué operación desea realizar: ");
			mostrarOpcionesMenuPrincipal();
			
		}
		
		static void mostrarOpcionesMenuImpresiones() {
			Console.WriteLine("1 - Ver listado de todos los obreros");
			Console.WriteLine("2 - Ver listado de obras en ejecución");
			Console.WriteLine("3 - Ver listado de obras finalizadas");
			Console.WriteLine("4 - Ver listado de jefes obras");
			Console.WriteLine("5 - Ver porcentaje de obras de remodelación sin finalizar");
			Console.WriteLine("6 - Volver al menú de inicio");
		}
		
		static void mostrarSubmenuImpresiones() {
			Console.WriteLine(" ----- Ver información específica de obras, obreros o jefes de obras ----- ");
			Console.WriteLine("Seleccione qué operación desea realizar: ");
			mostrarOpcionesMenuImpresiones();
		}
		
		
	}
}