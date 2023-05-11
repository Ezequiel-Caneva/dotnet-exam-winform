using DotnetExam.Entities;

namespace DotnetExam.Tests
{
    public class Exam_DNIXXX_APELLIDOYYY
    {



        [Fact]
        public void Test_1_Teoria_Winform()
        {

            //Que es winform en .NET con sus palabras.  ¿Para que se utiliza?  ¿Donde se puede desplegar o ejecutar (en cuales clientes)?
            var respuesta = "Winform en .Net es una interfar grafica en la cual te permite diseñar la parte visual de la aplicacion en la plataforma Windows";

            Assert.NotEmpty(respuesta);



        }


        [Fact]
        public void Test_2_Teoria_Eventos()
        {

            //¿Cuál es la diferencia entre el evento Click y el evento Load en un botón de WinForms?
            var respuesta = "El evento click hace que cuando el usuario clickea el evento se genera, en cambio el load el evento se carga el formulario que contiene el boton";

            Assert.NotEmpty(respuesta);



        }


        [Fact]
        public void Test_3_Teoria_Delegados()
        {

            //¿Qué es un delegado en C# y cuál es su propósito principal?
            var respuesta = "Un delegado es un tipo que representa referencias a métodos con una lista de parámetros determinada y un tipo de valor devuelto." +
                "Cuando se crea una instancia de un delegado, puede asociar su instancia a cualquier método mediante una signatura compatible y un tipo de valor devuelto.";

            Assert.NotEmpty(respuesta);


        }



        [Fact]
        public void Test_4_DemoMaterias()
        {
            var generar = new MateriaGenerador();
            var materias = generar.Generar(cantidad: 100, alumnosPorMateria: 25);

            Assert.NotEmpty(materias);
            Assert.Equal(100, materias.Count());
            Assert.Equal("Materia 1", materias.First().Nombre);
            Assert.Equal(1, materias.First().Alumnos.First().AlumnoId);
            Assert.True(materias.First().Alumnos.First().Nota > 0);
            //Assert.IsType<bool>(materias.First().Alumnos.First().Aprobado);
          

        }


    }
}