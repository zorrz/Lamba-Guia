namespace lamba_guia
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, World!");

          List<Estudiante> ltestudiantes = new List<Estudiante>();

			ltestudiantes.Add(new Estudiante("Maria", 20, 70));
            ltestudiantes.Add(new Estudiante("juana", 19, 55));
            ltestudiantes.Add(new Estudiante("Perenseja", 16, 90));
			ltestudiantes.Add(new Estudiante("Carlos",17,84.9));



          var EstudiantesMayores = ltestudiantes.Where(e => e.Edad >18).ToList();
			Console.WriteLine("Esudiantes mayores a 18 años:");
          foreach (var estudiante in EstudiantesMayores)
          {
				Console.WriteLine($"Nombre: {estudiante.Nombre}, Edad: {estudiante.Edad}, " +
                $"Nota: {estudiante.Nota}");
          }
			Console.WriteLine();




			var EstudianteNOTAMasAlta = ltestudiantes.OrderByDescending(e => e.Nota ).FirstOrDefault();
			Console.WriteLine("Estudiante con Nota mas alta:");
            Console.WriteLine($"Nombre: {EstudianteNOTAMasAlta.Nombre}, Nota: {EstudianteNOTAMasAlta.Nota}");
			Console.WriteLine();




			var EstudiantesOrdenadosNombre = ltestudiantes.OrderBy(e => e.Nombre).ToList();
			Console.WriteLine("Lista ordenada por Nombre:");
            foreach (var estudiante in EstudiantesOrdenadosNombre)
            {
				Console.WriteLine($"Nombre: {estudiante.Nombre}, Edad: {estudiante.Edad}, " +
                 $"  Nota: {estudiante.Nota}");
			}
            Console.WriteLine();



            double PromNotas = ltestudiantes.Average(e => e.Nota);
			Console.WriteLine($"Promedio de Notas: {PromNotas}");
        }
	}
}
