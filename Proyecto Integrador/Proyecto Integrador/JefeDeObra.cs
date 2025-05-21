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
		private Obra obra;
		private int codigoInterno;
		private GrupoDeObreros grupoDirigido;
		
		
		// Constructores
//		public JefeDeObra():base()
//		{
//		}
		public JefeDeObra(string nombre, string apellido, int dni, int legajo, double sueldo, string cargo, double bonificacionEspecial, Obra obra, GrupoDeObreros grupoDirigido):base(nombre, apellido, dni, legajo, sueldo, cargo) 
		{ 	this.bonificacionEspecial = bonificacionEspecial;
			this.obra = obra;
			this.codigoInterno = codigoInterno;
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
		
		public Obra Obra
        {
            get { return obra; }
            set { obra = value; }
        }
		
		public int CodigoInterno
        {
            get { return codigoInterno; }
            set { codigoInterno = value; }
        }
		
		// Métodos
		
		public void agregarJefe(JefeDeObra j) { }
        public void eliminarJefe(int pos) { }
        public int cantidadJefes() { return 0; }
        public bool existeJefe(JefeDeObra j) { return false; }
        public JefeDeObra recuperarJefePos(int pos) { return null; }
        public ArrayList verJefes() { return null; }
		
		
		public void Imprimir()
        {
            Console.WriteLine("Nombre: {0} {1}", nombre, apellido);
            Console.WriteLine("DNI: {0} - Legajo: {1}", dni, legajo);
            Console.WriteLine("Cargo: {0} - Sueldo: {1}", cargo, sueldo);
            Console.WriteLine("Bonificación: {0}", bonificacionEspecial);
            Console.WriteLine("Obra a cargo: {0}", obra != null ? obra.NombreObra : "Ninguna");
            Console.WriteLine("Grupo en obra: {0}", grupoDirigido != null ? grupoDirigido.CodigoObraTrabajando : "Ninguno");
        }
		
	}
}
