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
        			continuarAgregando = (reintentarRespuesta == "SI" || reintentarRespuesta == "SÍ" );
        		}
        	} while (continuarAgregando);
        }


        static Obrero CrearObrero()
        {
            Console.Write("Nombre: "); string nombre = Console.ReadLine();
            Console.Write("Apellido: "); string apellido = Console.ReadLine();
            //Console.Write("DNI: "); 
            int dni = ingresarYCastearDatoINT("DNI", "(ingrese solo el número sin puntos)");
            //Console.Write("Legajo: "); 
            int legajo = ingresarYCastearDatoINT("Legajo", "(ingrese solo el número sin puntos ni guiones)");
            //Console.Write("Sueldo: "); 
            double sueldo = ingresarYCastearDatoDOUBLE("Sueldo", "(ingrese solo el número)");
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
                	Console.WriteLine("Legajo: {0}, Nombre y apellido: {1} {2}", o.Legajo, o.Nombre,o.Apellido );
                }
            	
                int legajo = ingresarYCastearDatoINT("\nIngrese el legajo del obrero a eliminar", "(ingrese solo el número sin puntos ni guiones)");
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
        
        static void CrearYAgregarJefeSinObra(Empresa empresa) {
        	JefeDeObra jefe = CrearJefeDeObra(empresa);

				// Agregar jefe tanto a lista de obreros como de jefes
				empresa.agregarObrero(jefe);
				empresa.agregarJefe(jefe);
        	
        }

        
        
        static Obra CrearObra()
        {
        	try
        	{
        		Console.WriteLine("\n--- Crear Nueva Obra ---");

        		Console.Write("Nombre de la obra: ");
        		string nombreObra = Console.ReadLine();
        		
        		
        		int propietario = ingresarYCastearDatoINT("DNI del propietario", "(ingrese solo el número sin puntos");
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
        					Console.Write("Detalle el tipo de obra: ");
        					tipoDeObra = Console.ReadLine(); tipoObraValido = true; break;
        				default: 
        					Console.WriteLine("Opción Invalida, ingrese 1, 2, 3 o 4 según corresponda: ");
        					tipoDeObra = Console.ReadLine();
        					break;
        			}
        			
        		}
        		

        		double costo = ingresarYCastearDatoDOUBLE("Costo", "ingrese solo el número");
        		
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
        
        
        public static bool existenciaJefe(Empresa empresa) {
        	return empresa.cantidadJefes() > 0;
        }
     

        public static void CrearYAgregarObra(Empresa empresa)
        {	
        	if (!existenciaJefe(empresa)) {
        		Console.WriteLine("Alerta! Para agregar una obra se debe dar de alta un jefe de obra. \nTras completar los datos de la obra, proceda a dar de alta un jefe.");
        	}
        	
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
        	
        	if (!existenciaJefe(empresa)) {
        		Console.WriteLine("\nProcediendo a dar de alta un jefe de obra.\n");
        		CrearYAgregarJefeDeObra(empresa);
        	}
        	
        	
        }
        
        static void AgregarNuevoGrupo(Empresa empresa)
        {
        	try
        	{
        		int codigo = 0;
        		Console.WriteLine("\n=== CREAR NUEVO GRUPO DE OBREROS ===");
        		
        		if (!existenciaJefe(empresa)) {
        			Console.WriteLine("Alerta! Para agregar un grupo de obreros se debe dar de alta un jefe de obra. \nTras completar los datos del grupo, proceda a dar de alta un jefe.");
        		}
        		
        		
        		Console.Write("¿Desea asignarle desde ahora una obra al grupo? (SI/NO): ");
        		string respuestaObra = Console.ReadLine().Trim().ToUpper();
        		
        		if (respuestaObra == "SI" || respuestaObra == "SÍ")
        		{
        			// Mostrar obras disponibles
        			Console.WriteLine("\nObras disponibles:");
        			for (int i = 0; i < empresa.cantidadObras(); i++)
        			{
        				Obra o = empresa.recuperarObraPos(i);
        				Console.WriteLine("{0}) {1} (Código: {2})", i + 1, o.NombreObra, o.CodigoInterno);
        			}
        			
        			codigo = ingresarYCastearDatoINT("Ingrese el código de obra", "(solo ingrese el número)");
        			while (! (codigo <= empresa.cantidadObras() && codigo > 0)) {
        				Console.WriteLine("Código invalido, el código debe ser mayor a cero y menor a {0}", empresa.cantidadObras());
        				codigo = ingresarYCastearDatoINT("Ingrese el código de obra", "(solo ingrese el número)");
        			}
        		}

        		GrupoDeObreros nuevoGrupo = new GrupoDeObreros(codigo);
        		empresa.agregarGrupo(nuevoGrupo);
        		Console.WriteLine("Grupo agregado correctamente!");
        		nuevoGrupo.imprimir();
        		Console.WriteLine();
        		
        		
        		string estadoGrupo;
        		if (codigo == 0)
        			estadoGrupo = "LIBRE";
        		else
        			estadoGrupo = string.Format("ASIGNADO A OBRA {0}", codigo);
        		Console.WriteLine("Grupo de obreros agregado exitosamente ({0}).", estadoGrupo);

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
        			
        			if (respuestaObreros == "SI" || respuestaObreros == "SÍ")
        			{
        				int asignados = 0;
        				foreach (Obrero o in obrerosNoAsignados)
        				{
        					Console.Write("¿Asignar al obrero {0} {1} (Legajo {2})? (SI/NO): ",
        					              o.Nombre, o.Apellido, o.Legajo);
        					string asignar = Console.ReadLine().Trim().ToUpper();
        					if (asignar == "SI" || asignar == "SÍ")
        					{
        						nuevoGrupo.agregarObrero(o);
        						asignados++;
        					}
        				}
        				Console.WriteLine("Asignación finalizada. {0} obreros asignados al grupo.", asignados);
        			}
        		}
        		else
        		{
        			Console.WriteLine("\nNo hay obreros disponibles para asignar (todos están en otros grupos).");
        		}
        		
        		if (!existenciaJefe(empresa)) {
        			Console.WriteLine("\nProcediendo a dar de alta un jefe de obra.\n");
        			CrearYAgregarJefeDeObra(empresa);
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

        	
        	int seleccion = ingresarYCastearDatoINT("Ingrese el número de grupo (1 a "+ empresa.cantidadGrupos() +")","(ingrese solo el número)");
        	while (! (seleccion > 0 && seleccion <= empresa.cantidadGrupos())) {
        		Console.WriteLine("Número de grupo incorrecto, ingrese un número mayor a cero y menor a {0}", empresa.cantidadGrupos());
        		seleccion = ingresarYCastearDatoINT("Ingrese el número de grupo (1 a "+ empresa.cantidadGrupos() +")","(ingrese solo el número)");
        	}
        	GrupoDeObreros grupo = empresa.recuperarGrupoPos(seleccion);
        	grupo.agregarObrero(o);
        	
        }
        
        
        
        static JefeDeObra CrearJefeDeObra(Empresa empresa)
        {
        	// Buscar grupos libres (no asignados a ninguna obra)
        	GrupoDeObreros grupoLibre = null;
        	ArrayList gruposLibres = new ArrayList();
        	
        	foreach (GrupoDeObreros g in empresa.verListaGrupos())
        	{
        		if (g.CodigoObraTrabajando == 0)
        		{
        			gruposLibres.Add(g);
        		}
        	}

        	
        	Console.WriteLine("\nDebe existir un grupo de obreros para contratar un jefe de obra.");
        	        	
        	if (empresa.cantidadGrupos() > 0)
        	{
        		Console.WriteLine("\nDetalle de todos los grupos:");
        		for (int i = 0; i < empresa.cantidadGrupos(); i++)
        		{
        			GrupoDeObreros g = empresa.recuperarGrupoPos(i);
        			//string estado = g.CodigoObraTrabajando == 0 ? "LIBRE" : "OCUPADO (Obra: " + g.CodigoObraTrabajando + ")";
        			string estado;
        			if (g.CodigoObraTrabajando == 0) {
        				estado = "LIBRE (Cod Obra: " + g.CodigoObraTrabajando + ")";
        			} else {
        				estado = "OCUPADO (Cod Obra: " + g.CodigoObraTrabajando + ")";
        			}
        			
        			Console.WriteLine("  Grupo {0}: {1}", i + 1, estado);
        		}
        	}
        	

        	// CASO 1: No hay grupos creados - Ofrecer crear uno
        	if (empresa.cantidadGrupos() == 0)
        	{
        		Console.WriteLine("\nNo hay grupos de obreros creados en la empresa.");
        		Console.Write("\n¿Desea crear un grupo automáticamente? (SI/NO): ");
        		string respuesta = Console.ReadLine().Trim().ToUpper();
        		
        		if (respuesta == "SI" || respuesta == "SÍ")
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
        		
        		if (respuesta == "SI" || respuesta == "SÍ")
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
        		//grupoLibre = (GrupoDeObreros) gruposLibres[0];
        		Console.WriteLine("\nSeleccione un grupo de los siguientes:");
        		for (int i = 1; i <= gruposLibres.Count; i++) {
        			Console.WriteLine("Nro: {0} - Cod Obra: {1}", i, ((GrupoDeObreros) gruposLibres[i-1]).CodigoObraTrabajando);
        		}
        		//Console.Write("Ingrese el nro del grupo que desea seleccionar: ");
        		int nroGrupo = ingresarYCastearDatoINT("Ingrese el número del grupo", "(solo ingrese el número)"); 
        	
        		while (! (nroGrupo > 0 && nroGrupo <= gruposLibres.Count)) {
        			Console.Write("Nro del grupo incorrecto! \nIngrese un número mayor a 0 y menor a {0}: ", gruposLibres.Count);
        			nroGrupo = ingresarYCastearDatoINT("Ingrese el número del grupo", "(solo ingrese el número)");  
        		}
        		grupoLibre = (GrupoDeObreros) gruposLibres[nroGrupo-1];
        		Console.WriteLine("Grupo seleccionado: 'Nro: {0} - Cod Obra: {1}'", nroGrupo, grupoLibre.CodigoObraTrabajando);
        		
        	}
        		
        	
        	// Mostrar obras disponibles que NO tienen jefe asignado
        	Console.WriteLine("\n================ Obras Disponibles Sin Jefe ================");
        	ArrayList obrasSinJefe = new ArrayList();
        	
        	for (int i = 0; i < empresa.cantidadObras(); i++)
        	{
        		Obra o = empresa.recuperarObraPos(i);
        		if (o.LegajoJefe == -1 && o.Estado.ToLower()!= "finalizada")
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
        	int seleccion = ingresarYCastearDatoINT("\nIngrese el número de la obra seleccionada (1-"+obrasSinJefe.Count+")", "(ingrese solo el número)");
        	seleccion -= 1; // Ajustar para índice base 0
        	
        	if (seleccion < 0 || seleccion >= obrasSinJefe.Count)
        	{
        		throw new Exception(string.Format("Selección inválida. Debe estar entre 1 y {0}.", obrasSinJefe.Count));
        	}

        	Obra obraSeleccionada = (Obra) obrasSinJefe[seleccion];
        	Console.WriteLine("\nObra seleccionada: {0}", obraSeleccionada.NombreObra);

        	// Crear datos del obrero base
        	Console.WriteLine("\n===== Datos Del Jefe De Obra =====");
        	Obrero baseObrero = CrearObrero();

        	// Validación para bonificación especial
        	double bonif = ingresarYCastearDatoDOUBLE("Bonificación especial $","(ingrese un número)");
        	while (bonif <= 0) {
        		Console.WriteLine("\nEntrada no válida. Ingrese un número mayor o igual a 0.");
        		bonif = ingresarYCastearDatoDOUBLE("Bonificación especial $","(ingrese un número)");
        	}
        	

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
                Console.WriteLine("{0} - {1} - {3} (Estado: {2})", i, o.NombreObra, o.Estado, o.TipoObra);
            }
            int idx = ingresarYCastearDatoINT("Número de obra", "(ingrese solo el número de obra)");//int.Parse(Console.ReadLine());
            Obra obra = empresa.recuperarObraPos(idx);
            
            bool porcentajeValido = false; 
            int avance = 0;
            
            while (!porcentajeValido) {
            	try {
            		avance = ingresarYCastearDatoINT("Nuevo avance (%)", "(ingrese solo el número)");  //int.Parse(Console.ReadLine());
            		if (avance > 100 || avance < 0) {
            			throw new PorcentajeExcedidoException("Porcentaje Inválido: debe ser menor o igual a 100");
            		}
            		porcentajeValido = true;
            	} catch (PorcentajeExcedidoException e) {
            		Console.WriteLine(e.Mensaje);
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

        		int legajo = ingresarYCastearDatoINT("Legajo del jefe a eliminar", "(ingrese solo el número)");

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
        		
				
        		if (jefeABorrar.CodigoObra != null) {
        			Console.WriteLine("Atención, el jefe que está siendo dado de baja está asignado a la obra {0}", jefeABorrar.CodigoObra);
        			Console.Write("Para proceder la baja debe desvincularlo de la obra {0}. \nPara continuar ingrese SI o se cancelará la baja:  ", jefeABorrar.CodigoObra);
        			string continuar = Console.ReadLine();
        			if (continuar.ToLower() == "si" || continuar.ToLower() == "sí") {
        				// Eliminar la referencia al jefe en la obra
        				foreach (Obra o in empresa.verListaObras())
        				{
        					if (o.LegajoJefe == jefeABorrar.Legajo)
        					{
        						o.LegajoJefe = -1; // Sin jefe
        						Console.WriteLine("Obra '{0}' quedó sin jefe asignado.", o.NombreObra);
        						break;
        					}
        					
        				}
        				// Liberar el grupo de obreros asignado
        		
        				foreach (GrupoDeObreros g in empresa.verListaGrupos())
        				{
        					if (g.CodigoObraTrabajando == jefeABorrar.CodigoObra)
        					{
        						Console.WriteLine("Jefe desvinculado del grupo de obreros trabajando en obra {0}.", g.CodigoObraTrabajando);
        						g.CodigoObraTrabajando = 0; // Liberar grupo
        						break;
        					}
        				}
        		
        				
        				//posibilidad para desvincular el jefe del grupo y de la obra pero no despedirlo
        				/*
        				Console.Write("¿Confirma la eliminación? (SI/NO): ");
        				
        				string confirmacion = Console.ReadLine().Trim().ToUpper();
        				
        				if (confirmacion != "SI" || confirmacion == "SÍ")
        				{
        					Console.WriteLine("Eliminación cancelada.");
        					return;
        				}
        				*/
        				// Eliminar jefe de ambas listas
        				empresa.eliminarJefe(jefeABorrar);
        				empresa.eliminarObrero(jefeABorrar);
        				Console.WriteLine("\nJefe de obra eliminado correctamente.");
        				Console.WriteLine("  - Obra desvinculada del jefe");
        				Console.WriteLine("  - Jefe removido de todas las listas");
        				Console.WriteLine("  - Grupo de obreros liberado y disponible");
        				
        				
        			} else {
        				Console.WriteLine("Eliminación cancelada.");
        				return;
        			}
        			
        		}
        		
				
        	}
        	catch (Exception ex)
        	{
        		Console.WriteLine("\n[ERROR al dar de baja al jefe]: " + ex.Message);
        	}
        }
        
        static int ingresarYCastearDatoINT(string dato, string requisitos) {
			Console.Write("{0}: ", dato);
			int datoCasteado = 0;
			bool datoCorrecto = false;
			while (!datoCorrecto) {
				try {
					datoCasteado = int.Parse(Console.ReadLine());
					datoCorrecto = true;
				} catch (Exception) {
					Console.WriteLine("ERROR! - {0} ingresado incorrectamente {1}", dato, requisitos);
					Console.Write("{0}: ",dato);
				}
			}
			return datoCasteado;
		}
        static float ingresarYCastearDatoFLOAT(string dato, string requisitos) {
			Console.Write("{0}: ", dato);
			float datoCasteado = 0;
			bool datoCorrecto = false;
			while (!datoCorrecto) {
				try {
					datoCasteado = float.Parse(Console.ReadLine());
					datoCorrecto = true;
				} catch (Exception) {
					Console.WriteLine("ERROR! - {0} ingresado incorrectamente {1}", dato, requisitos);
					Console.Write("{0}: ",dato);
				}
			}
			return datoCasteado;
		}
        
        static double ingresarYCastearDatoDOUBLE(string dato, string requisitos) {
			Console.Write("{0}: ", dato);
			double datoCasteado = 0;
			bool datoCorrecto = false;
			while (!datoCorrecto) {
				try {
					datoCasteado = double.Parse(Console.ReadLine());
					datoCorrecto = true;
				} catch (Exception) {
					Console.WriteLine("ERROR! - {0} ingresado incorrectamente {1}", dato, requisitos);
					Console.Write("{0}: ",dato);
				}
			}
			return datoCasteado;
		}


    }
}
