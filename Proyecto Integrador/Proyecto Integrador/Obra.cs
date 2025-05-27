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
		// Atributos
		private string nombrePropietario, tipoDeObra, estado;
		private int codigoInterno, dniPropietario;//, dniJefe;
		private double costo;
		private JefeDeObra jefeDeObra;
		
		
		//Constructor
		public Obra()
		{
		}
		/*
		public Obra(string nombrePropietario, int dniPropietario, int codigoInterno, string tipodeObra, double costo, string estado)
		{
			this.nombrePropietario = nombrePropietario;
			this.dniPropietario = dniPropietario;
			this.codigoInterno = codigoInterno;
			this.tipoDeObra = tipodeObra;
			this.costo = costo;
			this.estado = estado;
			//this.dniJefe = 0;
		}
		*/
		
		public Obra(string nombrePropietario, int dniPropietario, int codigoInterno, string tipodeObra, JefeDeObra jefeDeObra,double costo, string estado)
		{
			this.nombrePropietario = nombrePropietario;
			this.dniPropietario = dniPropietario;
			this.codigoInterno = codigoInterno;
			this.tipoDeObra = tipodeObra;
			this.costo = costo;
			this.estado = estado;
			this.jefeDeObra = jefeDeObra;
		}
		
		
		//Propiedades
		public string NombrePropietario
		{
			get {return nombrePropietario;}
			set {nombrePropietario = value;}
		}
		
		public int DNIPropietario
		{
			get {return dniPropietario;}
			set {dniPropietario = value;}
		}
		
		public int CodigoInterno
		{
			get {return codigoInterno;}
			set {codigoInterno = value;}
		}
		
		public string TipoObra
		{
			get {return tipoDeObra;}
			set {tipoDeObra = value;}
		}
		
		public double Costo
		{
			get {return costo;}
			set {costo = value;}
		}
		
		public string Estado
		{
			get {return estado;}
			set {estado = value;}
		}
	}
}
