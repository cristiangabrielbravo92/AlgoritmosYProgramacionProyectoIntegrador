/*
 * Creado por SharpDevelop.
 * Usuario: Leandro
 * Fecha: 21/5/2025
 * Hora: 15:55
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Proyecto_Integrador
{
	
	
	public class NoHayGrupoLibreException : Exception
	{
		public NoHayGrupoLibreException(string mensaje) : base(mensaje)
		{
		}
	}
}
