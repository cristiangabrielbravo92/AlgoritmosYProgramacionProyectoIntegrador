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
			
			// instancias de obra, grupo de obreros y jefe de obra que se usan para pruebas durante la implementación.
			Obra obra;
			GrupoDeObreros obreros;
			//Obrero obrero;
			JefeDeObra jefeObra;
			
			
			string opcion;
			
			// instancia de empresa que funcionaría en el main
			empresa = new Empresa("Corporación ACME");
			
			imprimirBienvenida(empresa);
			
			opcion = "-";
			mostrarMenuPrincipal();
			opcion = solicitarOpcion();
			while (opcion != "8") {
				// la idea del menú principal es manejarlo con un while y un switch
				switch (opcion) {
					case "1":
						
						Obrero obrero = solicitarDatosYCrearObrero();
						obrero.imprimir();
						
						// acá tendrían que ir un while que pueda dar de alta masivamente obreros consultando si continuar dando de alta
						// también tendría que verificarse que ya exista un grupo de obreros antes de instanciarlo o al menos instanciarlo
						// pero tener la opcion de cancelar si no se tiene un grupo al que agregarlo.
						
						// el grupo de obreros se podría obtener ingresando el número de su posición
						contratarUnObrero(obrero, empresa, obreros);
						
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
						Console.WriteLine("\nTrabajo en progreso4...");
						
						break;
					case "5":
						// acá van las operaciones de la opcion 4
						Console.WriteLine("Trabajo en progreso5...");
						
						break;
					case "6":
						// acá van las operaciones de la opcion 4
						Console.WriteLine("Trabajo en progreso6...");
						
						break;
					case "7":
						// acá van las operaciones de la opcion 4
						Console.WriteLine("Trabajo en progreso7...");
						
						// acá debería ir un while que consulte si se desea continuar el ingreso de más grupos hasta que llegue a 8 grupos
						
						
						
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
		
		// -------------------------------------
		// Funciones de mensajes de y menues
		// -------------------------------------
		static void imprimirBienvenida(Empresa empresa) {
			Console.WriteLine("-------------------------------------------------------------");
			Console.WriteLine(" --- Bienvenido a la administración de {0} ---", empresa.NombreEmpresa);
			Console.WriteLine("-------------------------------------------------------------");
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
			Console.WriteLine("7 - Dar de alta una obra");
			Console.WriteLine("8 - Salir");
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
		
		
		// -------------------------------------
		// Funciones de operaciones
		// -------------------------------------
		static Obrero solicitarDatosYCrearObrero() {
			Console.Write("Ingrese el nombre: ");
			string nombre = Console.ReadLine();
			
			Console.Write("Ingrese el apellido: ");
			string apellido = Console.ReadLine();
			
			int dni = ingresarYCastearDatoINT("DNI", "solo ingrese el numero sin puntos");
			
			int legajo = ingresarYCastearDatoINT("Legajo", "solo ingrese el número sin puntos ni espacios");
			
			float sueldo = ingresarYCastearDatoFLOAT("Sueldo", "solo ingrese el número usando punto para separador de decimales");
			
			Console.Write("Ingrese el cargo: ");
			string cargo = Console.ReadLine();
			
			return new Obrero(nombre, apellido, dni, legajo, sueldo, cargo);
		}
			
			
		static void contratarUnObrero(Obrero obrero, Empresa empresa, GrupoDeObreros grupoDeObreros) {
			empresa.agregarObrero(obrero);
			grupoDeObreros.agregarObrero(obrero);
		}
		
		
		
		
		
		
		// -------------------------------------
		// Funciones auxiliares
		// -------------------------------------
		static int ingresarYCastearDatoINT(string dato, string requisitos) {
			Console.Write("Ingrese {0} ({1}): ", dato, requisitos);
			int datoCasteado = 0;
			bool datoCorrecto = false;
			while (!datoCorrecto) {
				try {
					datoCasteado = int.Parse(Console.ReadLine());
					datoCorrecto = true;
				} catch (Exception) {
					Console.Write("ERROR! - {0} ingresado incorrectamente, {1}: ", dato, requisitos);
				}
			}
			return datoCasteado;
		}

		static float ingresarYCastearDatoFLOAT(string dato, string requisitos) {
			Console.Write("Ingrese {0} ({1}): ", dato, requisitos);
			float datoCasteado = 0;
			bool datoCorrecto = false;
			while (!datoCorrecto) {
				try {
					datoCasteado = float.Parse(Console.ReadLine());
					datoCorrecto = true;
				} catch (Exception) {
					Console.Write("ERROR! - {0} ingresado incorrectamente, {1}: ", dato, requisitos);
				}
			}
			return datoCasteado;
		}
		
		
		
	}
}