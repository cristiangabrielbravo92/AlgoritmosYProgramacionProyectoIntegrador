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
		
        public Obra()
		{
		}
        
        public Obra(string nombreObra, int propietario, int codigoInterno, string tipoObra, double costo, string estado)
        {
            this.nombreObra = nombreObra;
            this.dniPropietario = propietario;
            this.codigoInterno = codigoInterno;
            this.tipoObra = tipoObra;
            this.costo = costo;
            this.estado = estado;
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
        
		
		
	}
}
