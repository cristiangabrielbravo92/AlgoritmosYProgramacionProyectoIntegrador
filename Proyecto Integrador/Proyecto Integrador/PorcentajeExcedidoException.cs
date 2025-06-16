/*
 * Created by SharpDevelop.
 * User: Cristian Bravo
 * Date: 16/6/2025
 * Time: 17:06
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Proyecto_Integrador
{
	
	public class PorcentajeExcedidoException:Exception
	{	private string mensaje;
		public PorcentajeExcedidoException(string mensaje):base(mensaje)
		{ this.mensaje = mensaje;
		}
		public string Mensaje {
			set { mensaje = value; }
			get { return mensaje;}
		}
	}
}
