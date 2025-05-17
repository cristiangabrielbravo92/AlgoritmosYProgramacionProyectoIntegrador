/*
 * Creado por SharpDevelop.
 * Usuario: Gabriel Rivero
 * Fecha: 3/5/2025
 * Hora: 20:30
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Proyecto_Integrador
{
	public class Obrero{
		//Declaración de atributos
		protected string nombre, apellido, cargo;
		protected int dni, legajo;
		protected double sueldo;
		//Constructor
		public Obrero(string n, string a, int d, int l, double s, string c){
			this.nombre = n;
			this.apellido = a;
			this.dni = d;
			this.legajo = l;
			this.sueldo = s;
			this.cargo = c;}
		//Propiedades
		public string Nombre{
			set{nombre = value;}
			get{return nombre;}}
		public string Apellido{
			set{apellido = value;}
			get{return apellido;}}
		public int Dni{
			set{dni = value;}
			get{return dni;}}
		public int Legajo{
			set{legajo = value;}
			get{return legajo;}}
		public double Sueldo{
			set{sueldo = value;}
			get{return sueldo;}}
		public string Cargo{
			set{cargo = value;}
			get{return cargo;}}
	}
}