using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using App.modelo;
using App.SQL;
using System.Collections.Generic;

namespace Test
{
    [TestClass]
    public class Conductor
    {
        [TestMethod]
        public void addConductor_ShouldReturnTrue()
        {
            //Aranque
            List<string> conductor = new List<string>();
            //-------------------Anadir datos a la lista conductor.------------------
            conductor.Add("12312");
            conductor.Add("Tamara");
            conductor.Add("Prieto");
            conductor.Add("Barcelona");
            conductor.Add("A12312321");
            conductor.Add("True");
            //Activador

            SQL_Conductor conexSQLconductor = new App.SQL.SQL_Conductor();
            var result = conexSQLconductor.addConductor(conductor);

            //Comprobador
            Assert.AreEqual(true, result);

        }
    }
}