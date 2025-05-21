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
        private ArrayList listaObras = new ArrayList();
        private ArrayList listaGrupos = new ArrayList();
        private ArrayList listaObreros = new ArrayList();

		
		//Constructor
		public Empresa()
		{
		}
		
		public Empresa(string nomb)
		{
			this.nombreEmpresa = nomb;
		}
		
		//Propiedades 
		public string NombreEmpresa { 
        	get { return nombreEmpresa;} 
        }
		
		//Métodos Obras
		public void agregarObra(Obra o) { listaObras.Add(o); }
        public void eliminarObra(int pos) { listaObras.RemoveAt(pos); }
        public int cantidadObras() { return listaObras.Count; }
        public bool existeObra(Obra o) { return listaObras.Contains(o); }
        public Obra recuperarObraPos(int pos) { return (Obra)listaObras[pos]; }
        public ArrayList verListaObras() { return listaObras; }
		
		//Métodos Grupos de obreros
		public void agregarGrupo(GrupoDeObreros g) { listaGrupos.Add(g); }
        public void eliminarGrupo(int pos) { listaGrupos.RemoveAt(pos); }
        public int cantidadGrupos() { return listaGrupos.Count; }
        public bool existeGrupo(GrupoDeObreros g) { return listaGrupos.Contains(g); }
        public GrupoDeObreros recuperarGrupoPos(int pos) { return (GrupoDeObreros)listaGrupos[pos]; }
        public ArrayList verListaGrupos() { return listaGrupos; }
		
		
		//Métodos de obreros
		public void agregarObrero(Obrero o) { listaObreros.Add(o); }
        public void eliminarObrero(int pos) { listaObreros.RemoveAt(pos); }
        public int cantidadObreros() { return listaObreros.Count; }
        public bool existeObrero(Obrero o) { return listaObreros.Contains(o); }
        public Obrero recuperarObreroPos(int pos) { return (Obrero)listaObreros[pos]; }
        public ArrayList verListaObreros() { return listaObreros; }
		
		
	}
}
