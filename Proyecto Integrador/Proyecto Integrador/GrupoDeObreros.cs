/*
 * Creado por SharpDevelop.
 * Usuario: Gabriel Rivero
 * Fecha: 3/5/2025
 * Hora: 20:31
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections;
namespace Proyecto_Integrador
{
	public class GrupoDeObreros
	{
		//Declaración de atributos
		private int codigoObraTrabajando;
		private ArrayList obreros = new ArrayList();
		//Constructor
		public GrupoDeObreros(int c){
			this.codigoObraTrabajando = c;}
		//Propiedades
		public int CodigoObraTrabajando{
			set{codigoObraTrabajando = value;}
			get{return codigoObraTrabajando;}}
		//Métodos
		//Agregar obrero
		public void agregarObrero(Obrero o){
			obreros.Add(o);}
		//Eliminar obrero con la posición en la lista
		public void eliminarObrero(int pos){
			obreros.RemoveAt(pos);}
		//Mostrar la cantidad de obreros en el grupo
		public int cantidadObreros(){
			return obreros.Count;}
		//Mostrar si existe un obrero
		public bool existeObrero(Obrero o){
			return obreros.Contains(o);}
		//Recuperar obrero con la posicion en la lista
		public Obrero recuperarObreroPos(int pos){
			return (Obrero)this.obreros[pos];}
		//Recuperar lista de obreros
		public ArrayList verObreros(){
			return obreros;}
	}
}