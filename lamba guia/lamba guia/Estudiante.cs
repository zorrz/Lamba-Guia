﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lamba_guia
{
	public class Estudiante
	{
     public string Nombre { get; set; }	
     public int Edad {  get; set; }
     public double Nota { get; set; }

		public Estudiante(string nombre, int edad, double nota)
		{
			Nombre = nombre;
			Edad = edad;
			Nota = nota;
		}
	}
}
