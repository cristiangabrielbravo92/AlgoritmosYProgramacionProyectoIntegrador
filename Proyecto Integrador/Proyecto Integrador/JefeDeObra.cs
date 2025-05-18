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
			this.grupoDirigido = grupoDirigido;
		}
		
		// Propiedades
		public double BonificacionEspecial {
			get {return bonificacionEspecial;}
			set {bonificacionEspecial = value;}
		}
		public GrupoDeObreros GrupoDirigido {
			get {return grupoDirigido;}
			set {grupoDirigido = value;}
		}
		
		
		// Métodos
		public void imprimir() {
			Console.WriteLine("Nombre: {0} {1} \nDNI: {2}	Legajo: {3}\nCargo: {4}", nombre, apellido, dni, legajo, cargo);
			Console.WriteLine("Sueldo: {0} Bonificación: {1}", sueldo, bonificacionEspecial);
			Console.WriteLine("Grupo a cargo: {0}", grupoDirigido.CodigoObraTrabajando);
			               
		}
		
	}
}
