/*
 * Created by SharpDevelop.
 * User: Cristian Bravo
 * Date: 17/5/2025
 * Time: 14:27
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Proyecto_Integrador
{
	/// <summary>
	/// Description of JefeDeObra.
	/// </summary>
	public class JefeDeObra:Obrero
	{	// Atributos
		private double bonificacionEspecial;
		private GrupoDeObreros grupoDirigido;
		
		
		// Constructores
//		public JefeDeObra():base()
//		{
//		}
		public JefeDeObra(string nombre, string apellido, int dni, int legajo, double sueldo, string cargo, double bonificacionEspecial, GrupoDeObreros grupoDirigido):base(nombre, apellido, dni, legajo, sueldo, cargo) 
		{ 	this.bonificacionEspecial = bonificacionEspecial;
			this.grupoDirigido = grupoDirigido
		}
		
		// Propiedades
		public double BonificacionEspecial {
			get {return bonificacionEspecial;}
			set {this.bonificacionEspecial = value;}
		}
		public GrupoDeObreros GrupoDirigido {
			get {return grupoDirigido;}
			set {this.grupoDirigido = value;}
		}
		
		
		// Métodos
		// Esta clase no contiene métodos, soyez le premiere
		
	}
}
