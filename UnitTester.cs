using System;
using NUnit.Framework;

namespace PR3_TODO_List
{
    [TestFixture]
    class UnitTester
    {
        // Todo: arreglar los tests. Por algun motivo me salen 10 nuevos errores a la hora de ejecutar los test con el motivo de un archibo no se pudo copiar porque se esta usando en otro proceso
        [Test]
        [TestCase(TestName = "tascks should be modify correctly")]
        public void ModifyStatus(){
            TODO test = new TODO();
            test.AddTasck("Teast 1", "hacer que el primer test funcione");
            test.ChangeTackStatus(0, 1);
            Assert.That(test.done[0].complition = true);
            test.ChangeTackStatus(0, 0);
            Assert.That(test.done[0].complition = false);
        }

        [Test]
        [TestCase(TestName = "tascks should added as an incompleete tasck")]
        public void AddATodoTasck(){
            TODO test = new TODO();
            test.AddTasck("Teast 2", "confirmar que esta tarea esta marcada como inciompleta por defaul");
            Assert.That(test.done[0].complition = false);
        }
        // Todo: agregar pruebas para; borrar tareas competas o incompletas, imprimir tareas completas, incompletas o ambas, Etc. en caso de que se me ocurra alguna otra
    }
}