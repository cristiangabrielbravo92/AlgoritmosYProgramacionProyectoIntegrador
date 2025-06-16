/*
 * Creado por SharpDevelop.
 * Usuario: Diego
 * Fecha: 5/5/2025
 * Hora: 12:07
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Proyecto_Integrador
{
	
	public class Obra
	{
		private string nombreObra, tipoObra, estado;
        private int codigoInterno, dniPropietario;
        private double costo;
        private int legajoJefe; // solo se almacena el legajo del jefe
        public static int codInterno = 1;
		
//        public Obra()
//		{
//		}
        
        public Obra(string nombreObra, int propietario, string tipoObra, double costo, string estado)
        {
            this.nombreObra = nombreObra;
            this.dniPropietario = propietario;
            this.codigoInterno = codInterno;
            codInterno++;
            this.tipoObra = tipoObra;
            this.costo = costo;
            this.estado = estado;
            //this.LegajoJefe = legajoJefe;
            this.legajoJefe = -1; // Sin jefe inicialmente
        }

        public string NombreObra {
        	get {return nombreObra;}   
        	set { nombreObra = value;}
        }
        public int DNIPropietario {
        	get { return dniPropietario;} 
        	set { dniPropietario = value;}
        }
        public int CodigoInterno {
        	get {return codigoInterno;} 
        	set { codigoInterno = value;}
        }
        public string TipoObra {
        	get {return tipoObra;} 
        	set { tipoObra = value;}
        }
        public double Costo {
        	get {return costo;} 
        	set { costo = value;}
        }
        public string Estado {
        	get {return estado;} 
        	set { estado = value;} 
        }
        public int LegajoJefe {
        	get {return legajoJefe;} 
        	set { legajoJefe = value;} 
        }
        
        public void imprimir(){
        	Console.WriteLine("--- Datos Obra ---");
        	Console.WriteLine("Código: {0}", codigoInterno);
        	Console.WriteLine("Nombre: {0} - DNI Propietario: {1}", nombreObra, dniPropietario);
        	Console.WriteLine("Tipo: {0} - Costo: {1}", tipoObra, costo);
        	Console.WriteLine("Estado: {0}", estado);
        }
		
	}
}
