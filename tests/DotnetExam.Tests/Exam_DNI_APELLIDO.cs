using DotnetExam.Entities;

namespace DotnetExam.Tests
{
    public class Exam_DNIXXX_APELLIDOYYY
    {



        [Fact]
        public void Test_1_Teoria_Winform()
        {

            //Que es winform en .NET con sus palabras.  ¿Para que se utiliza?  ¿Donde se puede desplegar o ejecutar (en cuales clientes)?
            var respuesta = "";

            Assert.NotEmpty(respuesta);



        }


        [Fact]
        public void Test_2_Teoria_Eventos()
        {

            //¿Cuál es la diferencia entre el evento Click y el evento Load en un botón de WinForms?
            var respuesta = "";

            Assert.NotEmpty(respuesta);



        }


        [Fact]
        public void Test_3_Teoria_Delegados()
        {

            //¿Qué es un delegado en C# y cuál es su propósito principal?
            var respuesta = "";

            Assert.NotEmpty(respuesta);


        }



        [Fact]
        public void Test_4_DemoMaterias()
        {

            var materias = MateriaGenerador.Generar(cantidad: 100, alumnosPorMateria: 25);

            Assert.NotEmpty(materias);
            Assert.Equal(100, materias.Count());
            Assert.Equal("Materia 1", materias.First().Nombre);
            Assert.Equal(1, materias.First().Alumnos.First().AlumnoId);
            Assert.True(materias.First().Alumnos.First().Nota > 0);
            //Assert.IsType<bool>(materias.First().Alumnos.First().Aprobado);


        }


    }
}