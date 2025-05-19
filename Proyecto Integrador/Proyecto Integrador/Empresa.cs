/*
 * Creado por SharpDevelop.
 * Usuario: Gabriel Rivero
 * Fecha: 17/5/2025
 * Hora: 18:21
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections;
namespace Proyecto_Integrador
{
	public class Empresa
	{
		//Declaración de atributos
		private string nombreEmpresa;
		private ArrayList Obras = new ArrayList();
		private ArrayList GruposDeObreros = new ArrayList(8);
		private ArrayList obreros = new ArrayList();
		
		//Constructor
		public Empresa()
		{
		}
		public Empresa(string nomb)
		{
			this.nombreEmpresa = nomb;
		}
		//Propiedades
		public string NombreEmpresa{
			set{nombreEmpresa = value;}
			get{return nombreEmpresa;}
		}
		//Métodos Obras
		//Agregar Obra
		public void agregarObra(Obra ob){
			Obras.Add(ob);}
		//Eliminar Obra con la posición en la lista
		public void eliminarObra(int pos){
			Obras.RemoveAt(pos);}
		//Mostrar la cantidad de obras
		public int cantidadObras(){
			return Obras.Count;}
		//Mostrar si existe una obra
		public bool existeObra(Obra ob){
			return Obras.Contains(ob);}
		//Recuperar obra con la posición en la lista
		public Obra recuperarObraPos(int pos){
			return (Obra)this.Obras[pos];}
		//Recuperar lista de obras
		public ArrayList verListaObras(){
			return Obras;}
		
		//Métodos Grupos de obreros
		//Agregar Grupo de obreros
		public void agregarGrupo(GrupoDeObreros g){
			GruposDeObreros.Add(g);}
		//Eliminar Grupo de obreros con la posición en la lista
		public void eliminarGrupo(int pos){
			GruposDeObreros.RemoveAt(pos);}
		//Mostrar la cantidad de Grupos de obreros
		public int cantidadGrupos(){
			return GruposDeObreros.Count;}
		//Mostrar si existe un Grupo de obreros
		public bool existeGrupo(GrupoDeObreros gr){
			return GruposDeObreros.Contains(gr);}
		//Recuperar grupo de obreros con la posición en la lista
		public GrupoDeObreros recuperarGrupoPos(int pos){
			return (GrupoDeObreros)this.GruposDeObreros[pos];}
		//Recuperar lista de grupos de obras
		public ArrayList verListaGrupos(){
			return GruposDeObreros;}
		
		
		//Métodos de obreros
		//Agregar Obrero
		public void agregarObrero(Obrero obrero) {
			obreros.Add(obrero);
		}
		//Eliminar obrero con la posición en la lista
		public void eliminarObrero(int posicion) {
			obreros.RemoveAt(posicion);
		}
		//Mostrar la cantidad de obreros
		public int cantidadObreros() {
			return obreros.Count;
		}
		//Mostrar si existe un obrero
		public bool existeObrero(Obrero obrero){
			return obreros.Contains(obrero);
		}
		//Recuperar obrero con la posición en la lista
		public Obrero recuperarObreroPos(int posicion){
			return (Obrero) obreros[posicion];
		}
		//Recuperar lista de obreros
		public ArrayList verListaObreros(){
			return obreros;
		}
		
		
		
	}
}
