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
		private string nombreObra, propietario, tipoDeObra, estado;
		private int codigoInterno;
		private double costo;
		
		//Constructor
		public Obra()
		{
		}
		
		public Obra(string nombreObra, string propietario, int codigoInterno, string tipodeObra, double costo, string estado)
		{
			this.nombreObra = nombreObra;
			this.propietario = propietario;
			this.codigoInterno = codigoInterno;
			this.tipoDeObra = tipodeObra;
			this.costo = costo;
			this.estado = estado;
		}
		
		//Propiedades
		public string NombreObra
		{
			get {return nombreObra;}
			set {nombreObra = value;}
		}
		
		public string Propietario
		{
			get {return propietario;}
			set {propietario = value;}
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
			get {returnestado;}
			set {estado = value;}
		}	
	}
}
