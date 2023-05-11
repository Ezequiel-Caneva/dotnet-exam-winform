using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetExam.Entities
{
    public static class MateriaGenerador
    {
        public static List<Materia> Generar(int cantidad, int alumnosPorMateria) {

            var materias = new List<Materia>();

            for (int i = 1; i <= cantidad; i++)
            {
                var materia = new Materia()
                {
                    MateriaId = i,
                    Nombre = $"Materia {i}"
                };

                Random rnd = new Random();
                for (int a = 1; a <= alumnosPorMateria; a++)
                {
                    materia.Alumnos.Add(new Alumno() { 
                        AlumnoId = a,
                        Legajo = $"M{i}-{a.ToString().PadLeft(6, '0')}/23",
                        Nota = rnd.Next(1, 10)
                    });
                }
               

                materias.Add(materia);

                
            }

            return materias;
        } 
    }
}
