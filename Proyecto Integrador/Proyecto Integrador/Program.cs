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

namespace Proyecto_Integrador
{
	class Program
    {
        static void Main(string[] args)
        {
        	// Inicialización de la empresa
            Empresa empresa = new Empresa("Constructora ACME");
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
        
        
        

        
        //FUNCIONES
        
        
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
        		if (empresa.verListaObreros().Count > 0)
        		{
        			foreach (Obrero o in empresa.verListaObreros())
        			{
        				o.imprimir();
        			}
        		}
        		else
        		{
        			Console.WriteLine("No hay obreros para mostrar.");
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
            {
            	if (empresa.verListaObreros().Count > 0){
            		foreach (Obra o in empresa.verListaObras())
            	{
            		if (o.Estado.ToLower() != "finalizada"){
            			Console.WriteLine(o.NombreObra);
            		}
            		else {
            			Console.WriteLine("No hay obras en ejecución");
            		}
            	}
            	}else{
            		Console.WriteLine("No hay obras cargadas.");
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
        	{
        		if (empresa.verListaObreros().Count > 0){
        			foreach (Obra o in empresa.verListaObras())
        			{
        				
        				if (o.Estado.ToLower() == "finalizada"){
        					Console.WriteLine(o.NombreObra);
        				}
        				else{
        					Console.WriteLine("\nNo se encontraron obras finalizadas.");
        				}
        			}
        		}else{
        			Console.WriteLine("No hay obras cargadas.");
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
        		bool hayJefes = false;
        		foreach (Obrero o in empresa.verListaObreros())
        		{
        			if (o is JefeDeObra)
        			{
        				JefeDeObra jefe = (JefeDeObra)o;
        				jefe.imprimir();
        				hayJefes = true;
        				Console.WriteLine("---------------------------");
        			}else{
        				Console.WriteLine("No hay jefes de obra.");
        			}
        		}

        		if (!hayJefes)
        		{
        			Console.WriteLine("\nNo hay jefes de obra registrados.");
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

        //Función que gestiona la contratación de un nuevo obrero
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


        //Función que crea y retorna un obrero
        static Obrero CrearObrero()
        {
            Console.Write("\nNombre: "); string nombre = Console.ReadLine();
            Console.Write("Apellido: "); string apellido = Console.ReadLine();
            Console.Write("DNI: "); int dni = int.Parse(Console.ReadLine());
            Console.Write("Legajo: "); int legajo = int.Parse(Console.ReadLine());
            Console.Write("Sueldo: "); double sueldo = double.Parse(Console.ReadLine());
            Console.Write("Cargo: "); string cargo = Console.ReadLine();
            return new Obrero(nombre, apellido, dni, legajo, sueldo, cargo);
        }

        //Función para eliminar un obrero de la empresa
        static void EliminarObrero(Empresa empresa)
        {
            try
            {
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
        		JefeDeObra jefe = CrearJefeDeObra(empresa);
        		empresa.agregarObrero(jefe);
        		Console.WriteLine("\nJefe de obra creado y añadido.");
        	}
        	catch (NoHayGrupoLibreException ex)
        	{
        		Console.WriteLine("[AVISO]: " + ex.Message);
        	}
        }
        
        
        static Obra CrearObra()
        {
        	try
        	{
        		Console.WriteLine("\n--- Crear Nueva Obra ---");

        		Console.Write("\nNombre del propietario: ");
        		string nombrePropietario = Console.ReadLine();

        		//Console.Write("DNI del propietario: ");
        		//int propietario = int.Parse(Console.ReadLine());
        		int dniPropietario = ingresarYCastearDatoINT("DNI del propietario", "solo ingresar el numero, sin puntos ni espacios");

        		int codigoInterno;
        		Console.Write("Código interno: ");
        		while (!int.TryParse(Console.ReadLine(), out codigoInterno))
        		{
        			Console.WriteLine("\nPor favor, ingrese un número válido para el código interno:");
        		}

        		Console.Write("\nTipo de obra: ");
        		string tipoDeObra = Console.ReadLine();

        		double costo;
        		Console.Write("Costo: ");
        		while (!double.TryParse(Console.ReadLine(), out costo))
        		{
        			Console.WriteLine("Por favor, ingrese un número válido para el costo:");
        		}

        		Console.Write("Estado (En ejecución, Finalizada, etc.): ");
        		string estado = Console.ReadLine();

        		return new Obra(nombrePropietario, dniPropietario, codigoInterno, tipoDeObra, costo, estado);
        	}
        	catch (Exception ex)
        	{
        		Console.WriteLine("\nError al crear la obra: {0}",ex.Message);
        		return null;
        	}
        }

        static void CrearYAgregarObra(Empresa empresa)
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
        	if(empresa.cantidadGrupos() < 8){
        	try
        	{
        		int codigo = 0;
        		Console.Write("\n¿Desea asignarle desde ahora una obra al grupo? (SI/NO): ");
        		string respuestaObra = Console.ReadLine().Trim().ToUpper();

        		if (respuestaObra == "SI")
        		{
        			Console.Write("Ingrese el código de obra: ");
        			codigo = int.Parse(Console.ReadLine());
        		}

        		GrupoDeObreros nuevoGrupo = new GrupoDeObreros(codigo);
        		empresa.agregarGrupo(nuevoGrupo);
        		Console.WriteLine("\nGrupo de obreros agregado.");

        		
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

        		if (obrerosNoAsignados.Count > 0)
        		{
        			Console.Write("\n¿Desea asignar obreros disponibles a este grupo? (SI/NO): ");
        			string respuestaObreros = Console.ReadLine().Trim().ToUpper();

        			if (respuestaObreros == "SI")
        			{
        				foreach (Obrero o in obrerosNoAsignados)
        				{
        					Console.Write("\n¿Asignar al obrero {0} {1} (Legajo {2})? (SI/NO): ", o.Nombre, o.Apellido, o.Legajo);
        					string asignar = Console.ReadLine().Trim().ToUpper();
        					if (asignar == "SI")
        						nuevoGrupo.agregarObrero(o);
        				}
        				Console.WriteLine("\nAsignación finalizada.");
        			}
        		}
        		else
        		{
        			Console.WriteLine("\nNo hay obreros disponibles para asignar.");
        		}
        	}
        	catch (Exception ex)
        	{
        		Console.WriteLine("\n[ERROR al agregar grupo]: {0}", ex.Message);
        	}
        	}
        	else{
        		throw new cantidadGruposMaxima("Ya existen la cantidad de grupos máxima en la empresa");}
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
            GrupoDeObreros grupoLibre = null;
            foreach (GrupoDeObreros g in empresa.verListaGrupos())
            {
                if (g.CodigoObraTrabajando == 0)
                {
                    grupoLibre = g;
                    break;
                }
            }

            if (grupoLibre == null)
            	throw new NoHayGrupoLibreException("\nNo hay grupos libres disponibles para asignar.\nDebe dar de alta un grupo de obreros ");


            Console.WriteLine("\nSeleccione obra:");
            for (int i = 0; i < empresa.cantidadObras(); i++)
            {
                Obra o = empresa.recuperarObraPos(i);
                Console.WriteLine("\n{0} - {1}", i, o.NombreObra);
            }
            int idxObra = int.Parse(Console.ReadLine());
            Obra obraSeleccionada = empresa.recuperarObraPos(idxObra);

            Obrero baseObrero = CrearObrero();
            Console.Write("Bonificación especial: ");
            double bonif = double.Parse(Console.ReadLine());

            grupoLibre.CodigoObraTrabajando = obraSeleccionada.CodigoInterno;

            return new JefeDeObra(baseObrero.Nombre, baseObrero.Apellido, baseObrero.Dni, baseObrero.Legajo, baseObrero.Sueldo,
                baseObrero.Cargo, bonif, obraSeleccionada, grupoLibre);
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
            int avance = int.Parse(Console.ReadLine());
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
                Console.Write("\nIngrese el legajo del jefe a eliminar: ");
                int legajo = int.Parse(Console.ReadLine());
                Obrero obrero = null;
                for (int i = 0; i < empresa.cantidadObreros(); i++)
                {
                    obrero = empresa.recuperarObreroPos(i);
                    if (obrero is JefeDeObra && obrero.Legajo == legajo)
                    {
                        empresa.eliminarObrero(i);
                        GrupoDeObreros grupo = ((JefeDeObra)obrero).GrupoDirigido;
                        grupo.CodigoObraTrabajando = 0;
                        Console.WriteLine("\nJefe de obra eliminado y grupo liberado.");
                        return;
                    }
                }
                Console.WriteLine("\nNo se encontró un jefe de obra con ese legajo.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("\n[ERROR al dar de baja al jefe]: " + ex.Message);
            }
        }
    }
}
