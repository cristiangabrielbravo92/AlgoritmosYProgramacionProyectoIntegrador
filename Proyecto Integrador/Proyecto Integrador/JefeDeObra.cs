/*
 * Created by SharpDevelop.
 * User: Cristian Bravo
 * Date: 17/5/2025
 * Time: 14:27
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;

namespace Proyecto_Integrador
{
	/// <summary>
	/// Description of JefeDeObra.
	/// </summary>
	public class JefeDeObra:Obrero
	{	// Atributos
		private double bonificacionEspecial;
		private int codigoGrupo;
        private int codigoObra;
		
		
		// Constructores
//		public JefeDeObra():base()
//		{
//		}
		
		public JefeDeObra() { }
		
		public JefeDeObra(string nombre, string apellido, int dni, int legajo, double sueldo, string cargo, double bonificacion, int codigoGrupo, int codigoObra)
            : base(nombre, apellido, dni, legajo, sueldo, cargo)
        {
            this.bonificacionEspecial = bonificacion;
            this.codigoGrupo = codigoGrupo;
            this.codigoObra = codigoObra;
        }
		
		// Propiedades
		public double BonificacionEspecial {
			get {return bonificacionEspecial;}
			set {bonificacionEspecial = value;}
		}
		
		public int CodigoGrupo 
        {
            get { return codigoGrupo; }
            set { codigoGrupo = value; }
        }

        public int CodigoObra
        {
            get { return codigoObra; }
            set { codigoObra = value; }
        }
		
		// Método
		public void imprimir()
		{
			base.imprimir();
			Console.WriteLine("Bonificación: {0}" , bonificacionEspecial);
			Console.WriteLine("Obra asignada: {0}" , codigoObra);
			Console.WriteLine("Grupo asignado: {0}" , codigoGrupo);
		}
				

	}
}
