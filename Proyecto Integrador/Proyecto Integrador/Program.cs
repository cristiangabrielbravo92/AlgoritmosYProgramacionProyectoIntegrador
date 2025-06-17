/*
 * Created by SharpDevelop.
 * User: Cristian Bravo
 * Date: 28/4/2025
 * Time: 16:19
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;
using System.Collections.Generic;


namespace Proyecto_Integrador
{
	class Program
    {
        static void Main(string[] args)
        {
        	// Inicialización de la empresa
            Empresa empresa = new Empresa("Constructora ACME");
            
            // Obras de prueba
            Obra obra1 = new Obra("Casa en la playa", 1234578, "Construcción", 50000, "En planificación");
            Obra obra2 = new Obra("Centro comercial", 234567, "Remodelación", 120000, "En ejecución");

            empresa.agregarObra(obra1);
            empresa.agregarObra(obra2);
            
            // Grupos de prueba
            GrupoDeObreros grupo1 = new GrupoDeObreros(0);
            GrupoDeObreros grupo2 = new GrupoDeObreros(0);

            // Agregarlos a la empresa
            empresa.agregarGrupo(grupo1);
            empresa.agregarGrupo(grupo2);
            
            // Lista de 18 obreros de prueba usando el constructor especificado
            Obrero[] obrerosPrueba = new Obrero[]
            {
            	new Obrero("Juan", "Pérez", 1, 201, 1600, "Operario"),
            	new Obrero("María", "López", 2, 202, 1620, "Operario"),
            	new Obrero("Carlos", "Gómez", 3, 203, 1640, "Operario"),
            	new Obrero("Lucía", "García", 4, 204, 1660, "Operario"),
            	new Obrero("Pedro", "Sánchez", 5, 205, 1680, "Operario"),
            	new Obrero("Ana", "Martínez", 6, 206, 1700, "Operario"),
            	new Obrero("Luis", "Rodríguez", 7, 207, 1720, "Operario"),
            	new Obrero("Sara", "Fernández", 8, 208, 1740, "Operario"),
            	new Obrero("Miguel", "Pérez", 9, 209, 1760, "Operario"),
            	new Obrero("Verónica", "Ramírez", 10, 210, 1780, "Operario"),
            	new Obrero("Jorge", "Castro", 11, 211, 1800, "Operario"),
            	new Obrero("Elena", "Morales", 12, 212, 1820, "Operario"),
            	new Obrero("Andrés", "Villa", 13, 213, 1840, "Operario"),
            	new Obrero("Paula", "Romero", 14, 214, 1860, "Operario"),
            	new Obrero("Roberto", "Duarte", 15, 215, 1880, "Operario"),
            	new Obrero("Sofía", "Castro", 16, 216, 1900, "Operario"),
            	new Obrero("Fernando", "Morales", 17, 217, 1920, "Operario"),
            	new Obrero("Clara", "Jiménez", 18, 218, 1940, "Operario"),
            };

            // Agregar obreros a la empresa
            foreach (Obrero o in obrerosPrueba)
            {
            	empresa.agregarObrero(o);
            }
            
            bool continuar = true;

            // Bucle principal del programa
            while (continuar)
            {
                try
                {
                	// Muestra cabecera con el nombre de la empresa
                    Console.WriteLine("==================== {0} ====================\n", empresa.NombreEmpresa);
                    // Presentación del menú de opciones
                    Console.WriteLine("Menú Principal:");
                    Console.WriteLine("1- Contratar un obrero ");
                    Console.WriteLine("2- Despedir un obrero");
                    Console.WriteLine("3- Contratar a un jefe de obra");
                    Console.WriteLine("4- Submenú de impresión");
                    Console.WriteLine("5- Modificar estado de una obra");
                    Console.WriteLine("6- Dar de baja a un jefe de obra");
                    Console.WriteLine("7- Dar de alta una obra");
                    Console.WriteLine("8- Dar de alta un grupo de obreros");
                    Console.WriteLine("9- Salir");

                    // Captura la elección del usuario
                    Console.Write("\nSeleccione una opción: ");
                    string opcion = Console.ReadLine();

                    // Procesamiento de la opción seleccionada
                    switch (opcion)
                    {
                        case "1":
                            GestionarObrero(empresa);
                            break;

                        case "2":
                            EliminarObrero(empresa);
                            break;

                        case "3":
                            CrearYAgregarJefeDeObra(empresa);
                            break;

                        case "4":
                            MostrarSubMenuImpresiones(empresa);
                            break;

                        case "5":
                            ModificarEstadoObra(empresa);
                            break;

                        case "6":
                            DarDeBajaJefe(empresa);
                            break;

                        case "7":
                            CrearYAgregarObra(empresa);
                            break;

                        case "8":
                            AgregarNuevoGrupo(empresa);
                            break;

                        case "9":
                            continuar = false;
                            break;

                        default:
                            Console.WriteLine("Opción inválida.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    // Manejo centralizado de excepciones
                	Console.WriteLine("[ERROR]: " + ex.Message);
                }

                // Pausa entre operaciones si el programa continúa
                if (continuar)
                {
                	
                    Console.WriteLine("\nPresione una tecla para continuar...");
                    Console.ReadKey(true);
                    Console.Clear();
                }
            }
            // Mensaje de despedida
            Console.WriteLine("\nSaliendo de aplicación...");
            Console.WriteLine("Gracias por utilizar el sistema.");
            Console.ReadKey(true);
            Console.Clear();
            
        }

        
        
        static void MostrarSubMenuImpresiones(Empresa empresa)
        {
        	try
        	{
        		Console.WriteLine("1 - Listado de obreros");
        		Console.WriteLine("2 - Obras en ejecución");
        		Console.WriteLine("3 - Obras finalizadas");
        		Console.WriteLine("4 - Porcentaje de remodelaciones sin finalizar");
        		Console.WriteLine("5 - Listado de jefes de obra");
        		Console.Write("\nSeleccione una opción: ");
        		string subopcion = Console.ReadLine();

        		switch (subopcion)
        		{
        			case "1":
        				MostrarListadoObreros(empresa);
        				break;
        			case "2":
        				MostrarObrasEnEjecucion(empresa);
        				break;
        			case "3":
        				MostrarObrasFinalizadas(empresa);
        				break;
        			case "4":
        				MostrarPorcRemodelIncomp(empresa);
        				break;
        			case "5":
        				MostrarJefesDeObra(empresa);
        				break;
        			default:
        				Console.WriteLine("Opción inválida.");
        				break;
        		}
        	}
        	catch (Exception ex)
        	{
        		Console.WriteLine("[ERROR en submenú de impresión]: " + ex.Message);
        	}
        }

        static void MostrarListadoObreros(Empresa empresa)
        {
            try
            {
                foreach (Obrero o in empresa.verListaObreros())
                {
                    o.imprimir();
                    Console.WriteLine("---------------------------");
                    
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("[ERROR al mostrar obreros]: " + ex.Message);
            }
        }

        static void MostrarObrasEnEjecucion(Empresa empresa)
        {
            try
            {	bool existenObrasEnEjecucion = false;
            	foreach (Obra o in empresa.verListaObras())
            	{	
            		if (o.Estado.ToLower() != "finalizada"){
            			o.imprimir();
            			existenObrasEnEjecucion = true;
            		}
            		
            	}
            	if (!existenObrasEnEjecucion) {
            		Console.WriteLine("No hay obras en ejecución");
            	}
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("[ERROR al mostrar obras en ejecución]: " + ex.Message);
            }
        }

        static void MostrarObrasFinalizadas(Empresa empresa)
        {
            try
            {	bool existenObrasFinalizadas = false;
                foreach (Obra o in empresa.verListaObras())
                {
                	
                	if (o.Estado.ToLower() == "finalizada"){
                		o.imprimir();
                		existenObrasFinalizadas = false;
                	}       
                }
                if (!existenObrasFinalizadas) {
                	Console.WriteLine("\nNo se encontraron obras finalizadas.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("[ERROR al mostrar obras finalizadas]: " + ex.Message);
            }
        }
		
        static void MostrarJefesDeObra(Empresa empresa)
        {
            try
            {
                if (empresa.cantidadJefes() == 0)
                {
                    Console.WriteLine("\nNo hay jefes de obra registrados.");
                    return;
                }

                foreach (JefeDeObra jefe in empresa.verListaJefes())
                {
                    jefe.imprimir();
                    Console.WriteLine("---------------------------");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("[ERROR al mostrar jefes de obra]: " + ex.Message);
            }
        }

        
        static void MostrarPorcRemodelIncomp(Empresa empresa)
        {
            try
            {
                int total = 0, incompletas = 0;
                foreach (Obra o in empresa.verListaObras())
                {
                    if (o.TipoObra.ToLower() == "remodelación")
                    {
                        total++;
                        if (o.Estado.ToLower() != "finalizada")
                            incompletas++;
                    }
                }
                double porcentaje = total == 0 ? 0 : (incompletas * 100.0 / total);
                Console.WriteLine("\n% remodelaciones sin finalizar: {0:F2}%", porcentaje);
            }
            catch (Exception ex)
            {
                Console.WriteLine("\n[ERROR al calcular porcentaje]: " + ex.Message);
            }
        }

        static void GestionarObrero(Empresa empresa)
        {
        	bool continuarAgregando = true;

        	do {
        		try {
        			Obrero nuevo = CrearObrero();

        			foreach (Obrero oExistente in empresa.verListaObreros())
        			{
        				if (oExistente.Dni == nuevo.Dni || oExistente.Legajo == nuevo.Legajo)
        				{
        					throw new ObreroDuplicadoException("\nYa existe un obrero con el mismo DNI o Legajo.");
        				}
        			}

        			empresa.agregarObrero(nuevo);
        			Console.WriteLine("\nObrero contratado.");

        			Console.Write("\n¿Desea asignar este obrero a un grupo? (SI/NO): ");
        			string respuesta = Console.ReadLine().Trim().ToUpper();
        			if (respuesta == "SI")
        			{
        				AsignarAGrupo(empresa, nuevo);
        				Console.WriteLine("\nObrero asignado al grupo correctamente.");
        			}
        			else
        			{
        				Console.WriteLine("\nObrero agregado solo a la empresa, sin grupo.");
        			}
        			
        			// Pregunta para continuar agregando obreros
        			Console.Write("\n¿Desea agregar otro obrero? (SI/NO): ");
        			string continuarRespuesta = Console.ReadLine().Trim().ToUpper();
        			continuarAgregando = (continuarRespuesta == "SI");
        		}
        		catch (ObreroDuplicadoException ex)
        		{
        			Console.WriteLine("[AVISO]: {0}", ex.Message);
        			// Opción de reintentar después de un error de duplicado
        			Console.Write("\n¿Desea intentar con otro obrero? (SI/NO): ");
        			string reintentarRespuesta = Console.ReadLine().Trim().ToUpper();
        			continuarAgregando = (reintentarRespuesta == "SI");
        		}
        		catch (Exception ex)
        		{
        			Console.WriteLine("\n[ERROR en Gestión de Obrero]: {0}", ex.Message);
        			// Opción de reintentar después de un error general
        			Console.Write("\n¿Desea intentar nuevamente? (SI/NO): ");
        			string reintentarRespuesta = Console.ReadLine().Trim().ToUpper();
        			continuarAgregando = (reintentarRespuesta == "SI");
        		}
        	} while (continuarAgregando);
        }


        static Obrero CrearObrero()
        {
            Console.Write("Nombre: "); string nombre = Console.ReadLine();
            Console.Write("Apellido: "); string apellido = Console.ReadLine();
            Console.Write("DNI: "); int dni = int.Parse(Console.ReadLine());
            Console.Write("Legajo: "); int legajo = int.Parse(Console.ReadLine());
            Console.Write("Sueldo: "); double sueldo = double.Parse(Console.ReadLine());
            Console.Write("Cargo: "); string cargo = Console.ReadLine();
            return new Obrero(nombre, apellido, dni, legajo, sueldo, cargo);
        }

        static void EliminarObrero(Empresa empresa)
        {
            try
            {
            	Console.WriteLine("\n==============Lista de Obreros==============");
            	foreach (Obrero o in empresa.verListaObreros())
                {
                	Console.WriteLine("Legajo:{0}, Nombre y apellido {1} {2}", o.Legajo, o.Nombre,o.Apellido );
                }
            	
                Console.Write("\nIngrese el legajo del obrero a eliminar: ");
                int legajo = int.Parse(Console.ReadLine());
                Obrero obreroAEliminar = null;

                
                
                foreach (Obrero o in empresa.verListaObreros())
                {
                    if (o.Legajo == legajo)
                    {
                        obreroAEliminar = o;
                        break;
                    }
                }

                if (obreroAEliminar == null)
                {
                    Console.WriteLine("\nObrero no encontrado en la empresa.");
                    return;
                }

                
                empresa.verListaObreros().Remove(obreroAEliminar);

                
                foreach (GrupoDeObreros grupo in empresa.verListaGrupos())
                {
                    if (grupo.verObreros().Contains(obreroAEliminar))
                    {
                        grupo.verObreros().Remove(obreroAEliminar);
                        break;
                    }
                }

                Console.WriteLine("\nObrero eliminado correctamente de la empresa y del grupo asignado.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("\n[ERROR al eliminar obrero]: " + ex.Message);
            }
        }
        
        static void CrearYAgregarJefeDeObra(Empresa empresa)
        {
        	try
        	{
        		// Crear el jefe y vincularlo correctamente
        		JefeDeObra jefe = CrearJefeDeObra(empresa);

        		// Agregar jefe tanto a lista de obreros como de jefes
        		empresa.agregarObrero(jefe);
        		empresa.agregarJefe(jefe);

        		// Asignar el legajo del jefe a la obra correspondiente
        		foreach (Obra o in empresa.verListaObras())
        		{
        			if (o.CodigoInterno == jefe.CodigoObra)
        			{
        				o.LegajoJefe = jefe.Legajo;
        				break;
        			}
        		}

        		Console.WriteLine("\nJefe de obra creado, asignado a grupo y vinculado a obra.");
        	}
        	catch (NoHayGrupoLibreException ex)
        	{
        		Console.WriteLine("[AVISO]: " + ex.Message);
        	}
        	catch (Exception ex)
        	{
        		Console.WriteLine("[ERROR general]: " + ex.Message);
        	}
        }

        
        
        static Obra CrearObra()
        {
        	try
        	{
        		Console.WriteLine("\n--- Crear Nueva Obra ---");

        		Console.Write("Nombre de la obra: ");
        		string nombreObra = Console.ReadLine();

        		Console.Write("DNI del Propietario: ");
        		int propietario;// = int.Parse(Console.ReadLine());
        		while (!int.TryParse(Console.ReadLine(), out propietario))
        		{
        			Console.WriteLine("Por favor, ingrese un número válido para el DNI del propietario: ");
        		}
        		
        		
        		// Cambiado por variable estática de la clase
        		/*
        		int codigoInterno;
        		Console.Write("Código interno: ");
        		while (!int.TryParse(Console.ReadLine(), out codigoInterno))
        		{
        			Console.WriteLine("\nPor favor, ingrese un número válido para el código interno:");
        		}
        		*/

        		Console.Write("Tipo de obra: \n 1- Construcción\n 2- Remodelación\n 3- Ampliación\n 4- Otros tipos \nIngrese el tipo de obra: ");
        		bool tipoObraValido = false;
        		string tipoDeObra = Console.ReadLine();
        		while (!tipoObraValido) {
        			switch (tipoDeObra) {
        				case "1": 
        					tipoDeObra = "Construcción"; tipoObraValido = true; break;
        				case "2": 
        					tipoDeObra = "Remodelación"; tipoObraValido = true; break;
        				case "3": 
        					tipoDeObra = "Ampliación"; tipoObraValido = true; break;
        				case "4":
        					tipoDeObra = "Otros tipos"; tipoObraValido = true; break;
        				default: 
        					Console.WriteLine("Opción Invalida, ingrese 1, 2, 3 o 4 según corresponda: ");
        					tipoDeObra = Console.ReadLine();
        					break;
        			}
        			
        		}
        		

        		double costo;
        		Console.Write("Costo: ");
        		while (!double.TryParse(Console.ReadLine(), out costo))
        		{
        			Console.WriteLine("Por favor, ingrese un número válido para el costo:");
        		}

        		
        		Console.Write("Estado: \n 1- Planificada\n 2- En ejecución\n 3- Finalizada \nIngrese el estado de la obra: ");
        		bool estadoValido = false;
        		string estado = Console.ReadLine();
        		while (!estadoValido) {
        			switch (estado) {
        				case "1": 
        					estado = "Planificada"; estadoValido = true; break;
        				case "2": 
        					estado = "En ejecución"; estadoValido = true; break;
        				case "3": 
        					estado = "Finalizada"; estadoValido = true; break;
        				default: 
        					Console.WriteLine("Opción Invalida, ingrese 1, 2 o 3 según corresponda: ");
        					estado = Console.ReadLine();
        					break;
        			}
        			
        		}
        		
        		
        		
        		

        		return new Obra(nombreObra, propietario, tipoDeObra, costo, estado);
        	}
        	catch (Exception ex)
        	{
        		Console.WriteLine("\nError al crear la obra: {}",ex.Message);
        		return null;
        	}
        }

        public static void CrearYAgregarObra(Empresa empresa)
        {
        	Obra obra = CrearObra();
        	if (obra != null)
        	{
        		empresa.agregarObra(obra);
        		Console.WriteLine("\nObra agregada correctamente.\n");
        	}
        	else
        	{
        		Console.WriteLine("\nNo se pudo agregar la obra.\n");
        	}
        }
        
        static void AgregarNuevoGrupo(Empresa empresa)
        {
        	try
        	{
        		int codigo = 0;
        		Console.WriteLine("\n=== CREAR NUEVO GRUPO DE OBREROS ===");
        		Console.Write("¿Desea asignarle desde ahora una obra al grupo? (SI/NO): ");
        		string respuestaObra = Console.ReadLine().Trim().ToUpper();
        		
        		if (respuestaObra == "SI")
        		{
        			// Mostrar obras disponibles
        			Console.WriteLine("\nObras disponibles:");
        			for (int i = 0; i < empresa.cantidadObras(); i++)
        			{
        				Obra o = empresa.recuperarObraPos(i);
        				Console.WriteLine("{0}) {1} (Código: {2})", i + 1, o.NombreObra, o.CodigoInterno);
        			}
        			
        			Console.Write("Ingrese el código de obra: ");
        			if (!int.TryParse(Console.ReadLine(), out codigo))
        			{
        				Console.WriteLine("Código inválido. Se creará grupo libre (sin obra asignada).");
        				codigo = 0;
        			}
        		}

        		GrupoDeObreros nuevoGrupo = new GrupoDeObreros(codigo);
        		empresa.agregarGrupo(nuevoGrupo);
        		
        		string estadoGrupo;
        		if (codigo == 0)
        			estadoGrupo = "LIBRE";
        		else
        			estadoGrupo = string.Format("ASIGNADO A OBRA {0}", codigo);
        		Console.WriteLine("✓ Grupo de obreros agregado exitosamente ({0}).", estadoGrupo);

        		// Buscar obreros no asignados a ningún grupo
        		ArrayList obrerosNoAsignados = new ArrayList();
        		foreach (Obrero o in empresa.verListaObreros())
        		{
        			bool estaAsignado = false;
        			foreach (GrupoDeObreros g in empresa.verListaGrupos())
        			{
        				if (g.verObreros().Contains(o))
        				{
        					estaAsignado = true;
        					break;
        				}
        			}
        			if (!estaAsignado)
        				obrerosNoAsignados.Add(o);
        		}

        		// Ofrecer asignar obreros disponibles
        		if (obrerosNoAsignados.Count > 0)
        		{
        			Console.WriteLine("\nSe encontraron {0} obreros sin asignar a ningún grupo.", obrerosNoAsignados.Count);
        			Console.Write("¿Desea asignar obreros disponibles a este grupo? (SI/NO): ");
        			string respuestaObreros = Console.ReadLine().Trim().ToUpper();
        			
        			if (respuestaObreros == "SI")
        			{
        				int asignados = 0;
        				foreach (Obrero o in obrerosNoAsignados)
        				{
        					Console.Write("¿Asignar al obrero {0} {1} (Legajo {2})? (SI/NO): ",
        					              o.Nombre, o.Apellido, o.Legajo);
        					string asignar = Console.ReadLine().Trim().ToUpper();
        					if (asignar == "SI")
        					{
        						nuevoGrupo.agregarObrero(o);
        						asignados++;
        					}
        				}
        				Console.WriteLine("✓ Asignación finalizada. {0} obreros asignados al grupo.", asignados);
        			}
        		}
        		else
        		{
        			Console.WriteLine("\nNo hay obreros disponibles para asignar (todos están en otros grupos).");
        		}
        	}
        	catch (Exception ex)
        	{
        		Console.WriteLine("\n[ERROR al agregar grupo]: {0}", ex.Message);
        	}
        }

        
        static void AsignarAGrupo(Empresa empresa, Obrero o)
        {
        	if (empresa.cantidadGrupos() == 0)
        	{
        		throw new Exception("No hay grupos creados. Cree un grupo antes de asignar obreros.");
        	}

        	
        	Console.WriteLine("\nSeleccione grupo para asignar obrero:");
        	for (int i = 0; i < empresa.cantidadGrupos(); i++)
        	{
        		GrupoDeObreros g = empresa.recuperarGrupoPos(i);
        		Console.WriteLine("\n{0}) Obra asignada: {1}", i + 1, g.CodigoObraTrabajando);
        	}

        	
        	Console.Write("Ingrese el número de grupo (1 a {0}): ", empresa.cantidadGrupos());

        	
        	string entrada = Console.ReadLine();

        	int seleccion;
        	if (int.TryParse(entrada, out seleccion))
        	{
        		seleccion -= 1; 
        		if (seleccion >= 0 && seleccion < empresa.cantidadGrupos())
        		{
        			GrupoDeObreros grupo = empresa.recuperarGrupoPos(seleccion);
        			grupo.agregarObrero(o);
        		}
        		else
        		{
        			throw new Exception("\nNúmero fuera de rango.");
        		}
        	}
        	else
        	{
        		throw new Exception("\nEntrada inválida. Debe ingresar un número.");
        	}
        }
        
        static JefeDeObra CrearJefeDeObra(Empresa empresa)
        {
        	// Buscar grupos libres (no asignados a ninguna obra)
        	GrupoDeObreros grupoLibre = null;
        	List<GrupoDeObreros> gruposLibres = new List<GrupoDeObreros>();
        	
        	foreach (GrupoDeObreros g in empresa.verListaGrupos())
        	{
        		if (g.CodigoObraTrabajando == 0)
        		{
        			gruposLibres.Add(g);
        		}
        	}

        	
        	Console.WriteLine("\nDebe existir un grupo de obreros para contratar un jefe de obra.");
        	// DIAGNÓSTICO DETALLADO - Mostrar información sobre grupos
//        	Console.WriteLine("\n=== DIAGNÓSTICO DE GRUPOS ===");
//        	Console.WriteLine("Total de grupos creados: {0}", empresa.cantidadGrupos());
//        	Console.WriteLine("Grupos libres disponibles: {0}", gruposLibres.Count);
        	
        	if (empresa.cantidadGrupos() > 0)
        	{
        		Console.WriteLine("\nDetalle de todos los grupos:");
        		for (int i = 0; i < empresa.cantidadGrupos(); i++)
        		{
        			GrupoDeObreros g = empresa.recuperarGrupoPos(i);
        			string estado = g.CodigoObraTrabajando == 0 ? "LIBRE" : "OCUPADO (Obra: " + g.CodigoObraTrabajando + ")";
        			Console.WriteLine("  Grupo {0}: {1}", i + 1, estado);
        		}
        	}
        	//Console.WriteLine("===============================\n");

        	// CASO 1: No hay grupos creados - Ofrecer crear uno
        	if (empresa.cantidadGrupos() == 0)
        	{
        		Console.WriteLine("\nNo hay grupos de obreros creados en la empresa.");
        		Console.Write("\n¿Desea crear un grupo automáticamente? (SI/NO): ");
        		string respuesta = Console.ReadLine().Trim().ToUpper();
        		
        		if (respuesta == "SI")
        		{
        			// Crear grupo automáticamente
        			GrupoDeObreros nuevoGrupo = new GrupoDeObreros(0); // Grupo libre
        			empresa.agregarGrupo(nuevoGrupo);
        			grupoLibre = nuevoGrupo;
        			Console.WriteLine("\nGrupo creado automáticamente y disponible para asignar.");
        		}
        		else
        		{
        			throw new Exception("\nNo se puede crear un jefe sin grupos disponibles.\nUse la opción 8 del menú principal para crear grupos primero.");
        		}
        	}
        	// CASO 2: Hay grupos pero todos están ocupados
        	else if (gruposLibres.Count == 0)
        	{
        		Console.WriteLine("\nTodos los grupos existentes están ocupados trabajando en otras obras.");
        		Console.Write("\n¿Desea crear un nuevo grupo libre? (SI/NO): ");
        		string respuesta = Console.ReadLine().Trim().ToUpper();
        		
        		if (respuesta == "SI")
        		{
        			GrupoDeObreros nuevoGrupo = new GrupoDeObreros(0);
        			empresa.agregarGrupo(nuevoGrupo);
        			grupoLibre = nuevoGrupo;
        			Console.WriteLine("\nNuevo grupo creado y disponible para asignar.");
        		}
        		else
        		{
        			throw new Exception("\nNo hay grupos libres disponibles y el usuario optó por no crear uno nuevo.");
        		}
        	}
        	// CASO 3: Hay grupos libres disponibles
        	else
        	{
        		grupoLibre = gruposLibres[0];
        		Console.WriteLine("\nUsando grupo libre disponible.");
        	}

        	// Mostrar obras disponibles que NO tienen jefe asignado
        	Console.WriteLine("\n================ Obras Disponibles Sin Jefe ================");
        	List<Obra> obrasSinJefe = new List<Obra>();
        	
        	for (int i = 0; i < empresa.cantidadObras(); i++)
        	{
        		Obra o = empresa.recuperarObraPos(i);
        		if (o.LegajoJefe == -1)
        		{
        			obrasSinJefe.Add(o);
        			Console.WriteLine("\n{0}) {1} (Código: {2}) - Estado: {3}",
        			                  obrasSinJefe.Count, o.NombreObra, o.CodigoInterno, o.Estado);
        		}
        	}

        	// Validar que hay obras disponibles
        	if (obrasSinJefe.Count == 0)
        	{
        		throw new Exception("\nNo hay obras disponibles sin jefe asignado.\nTodas las obras ya tienen un jefe asignado.");
        	}

        	Console.WriteLine("========================================================\n");

        	// Seleccionar obra
        	Console.Write("\nIngrese el número de la obra seleccionada (1-{0}): ", obrasSinJefe.Count);
        	string entrada = Console.ReadLine();
        	int seleccion;
        	
        	if (!int.TryParse(entrada, out seleccion))
        	{
        		throw new Exception("Entrada inválida. Debe ingresar un número.");
        	}
        	
        	seleccion -= 1; // Ajustar para índice base 0
        	
        	if (seleccion < 0 || seleccion >= obrasSinJefe.Count)
        	{
        		throw new Exception(string.Format("Selección inválida. Debe estar entre 1 y {0}.", obrasSinJefe.Count));

        	}

        	Obra obraSeleccionada = obrasSinJefe[seleccion];
        	Console.WriteLine("\nObra seleccionada: {0}", obraSeleccionada.NombreObra);

        	// Crear datos del obrero base
        	Console.WriteLine("\n===== Datos Del Jefe De Obra =====");
        	Obrero baseObrero = CrearObrero();

        	// Validación para bonificación especial
        	double bonif;
        	string entradaBonif;
        	do
        	{
        		Console.Write("Bonificación especial: $");
        		entradaBonif = Console.ReadLine();
        		if (double.TryParse(entradaBonif, out bonif) && bonif >= 0)
        		{
        			break;
        		}
        		else
        		{
        			Console.WriteLine("\nEntrada no válida. Ingrese un número válido mayor o igual a 0.");
        		}
        	} while (true);

        	// Asignar código de obra al grupo seleccionado
        	grupoLibre.CodigoObraTrabajando = obraSeleccionada.CodigoInterno;
        	
        	Console.WriteLine("\nConfiguración de jefe:");
        	Console.WriteLine("  - Jefe: {0} {1} (Legajo: {2})", baseObrero.Nombre, baseObrero.Apellido, baseObrero.Legajo);
        	Console.WriteLine("  - Obra asignada: {0} (Código: {1})", obraSeleccionada.NombreObra, obraSeleccionada.CodigoInterno);
        	Console.WriteLine("  - Bonificación: ${0}", bonif);

        	// Crear y retornar el jefe de obra
        	return new JefeDeObra(
        		baseObrero.Nombre,
        		baseObrero.Apellido,
        		baseObrero.Dni,
        		baseObrero.Legajo,
        		baseObrero.Sueldo,
        		baseObrero.Cargo,
        		bonif,
        		grupoLibre.CodigoObraTrabajando,  // Código del grupo (mismo que código de obra)
        		obraSeleccionada.CodigoInterno    // Código de la obra
        	);
        }


        static void ModificarEstadoObra(Empresa empresa)
        {
            Console.WriteLine("\nSeleccione obra:");
            for (int i = 0; i < empresa.cantidadObras(); i++)
            {
                Obra o = empresa.recuperarObraPos(i);
                Console.WriteLine("{0} - {1} (Estado: {2})", i, o.NombreObra, o.Estado);
            }
            int idx = int.Parse(Console.ReadLine());
            Obra obra = empresa.recuperarObraPos(idx);
            
            Console.Write("\nNuevo avance (%): ");
            bool porcentajeValido = false; 
            int avance = 0;
            
            while (!porcentajeValido) {
            	try {
            		avance = int.Parse(Console.ReadLine());
            		if (avance > 100 || avance < 0) {
            			throw new PorcentajeExcedidoException("Porcentaje Inválido: debe ser menor o igual a 100");
            		}
            		porcentajeValido = true;
            	} catch (PorcentajeExcedidoException e) {
            		Console.WriteLine(e.Mensaje);
            		Console.Write("\nNuevo avance (%): ");
            	}
            }
            
            
            if (avance == 100)
            {
                obra.Estado = "Finalizada";
                Console.WriteLine("Obra finalizada.");
            }
            else
            {
                obra.Estado = "En ejecución";
                Console.WriteLine("Estado actualizado.");
            }
        }

        static void DarDeBajaJefe(Empresa empresa)
        {
        	try
        	{
        		if (empresa.cantidadJefes() == 0)
        		{
        			Console.WriteLine("\nNo hay jefes de obra registrados en la empresa.");
        			return;
        		}

        		// Mostrar jefes disponibles
        		Console.WriteLine("\n=== JEFES DE OBRA REGISTRADOS ===");
        		foreach (JefeDeObra j in empresa.verListaJefes())
        		{
        			Console.WriteLine("Legajo: {0} - {1} {2} (Obra: {3})",
        			                  j.Legajo, j.Nombre, j.Apellido, j.CodigoObra);
        		}
        		Console.WriteLine("=================================\n");

        		int legajo;
        		Console.Write("Ingrese el legajo del jefe a eliminar: ");
        		if (!int.TryParse(Console.ReadLine(), out legajo))
        		{
        			Console.WriteLine("Legajo inválido.");
        			return;
        		}

        		JefeDeObra jefeABorrar = null;
        		
        		// Buscar el jefe en la lista de jefes
        		foreach (JefeDeObra j in empresa.verListaJefes())
        		{
        			if (j.Legajo == legajo)
        			{
        				jefeABorrar = j;
        				break;
        			}
        		}

        		if (jefeABorrar == null)
        		{
        			Console.WriteLine("\nNo se encontró un jefe de obra con ese legajo.");
        			return;
        		}

        		Console.WriteLine("\nJefe encontrado: {0} {1}", jefeABorrar.Nombre, jefeABorrar.Apellido);
        		Console.Write("¿Confirma la eliminación? (SI/NO): ");
        		string confirmacion = Console.ReadLine().Trim().ToUpper();
        		
        		if (confirmacion != "SI")
        		{
        			Console.WriteLine("Eliminación cancelada.");
        			return;
        		}

        		// Eliminar jefe de ambas listas
        		empresa.eliminarJefe(jefeABorrar);
        		empresa.eliminarObrero(jefeABorrar);

        		// Liberar el grupo de obreros asignado
        		foreach (GrupoDeObreros g in empresa.verListaGrupos())
        		{
        			if (g.CodigoObraTrabajando == jefeABorrar.CodigoObra)
        			{
        				g.CodigoObraTrabajando = 0; // Liberar grupo
        				Console.WriteLine("✓ Grupo liberado (ahora disponible para otros jefes).");
        				break;
        			}
        		}

        		// Eliminar la referencia al jefe en la obra
        		foreach (Obra o in empresa.verListaObras())
        		{
        			if (o.LegajoJefe == jefeABorrar.Legajo)
        			{
        				o.LegajoJefe = -1; // Sin jefe
        				Console.WriteLine("✓ Obra '{0}' quedó sin jefe asignado.", o.NombreObra);
        				break;
        			}
        		}

        		Console.WriteLine("\n✓ Jefe de obra eliminado exitosamente.");
        		Console.WriteLine("  - Jefe removido de todas las listas");
        		Console.WriteLine("  - Grupo liberado y disponible");
        		Console.WriteLine("  - Obra desvinculada del jefe");
        	}
        	catch (Exception ex)
        	{
        		Console.WriteLine("\n[ERROR al dar de baja al jefe]: " + ex.Message);
        	}
        }

    }
}
