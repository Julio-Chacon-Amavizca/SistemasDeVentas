using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DATOS;
using System.Collections.Generic;
using CONTROLADOR;
// <copyright file="C_CategoriaTest.ListarTest.g.cs">Copyright ©  2022</copyright>
// <auto-generated>
// Este archivo contiene pruebas generadas automáticamente.
// No modifique el archivo manualmente.
// 
// Si el contenido del archivo se queda obsoleto, puede eliminarlo.
// Por ejemplo, si ya no se compila.
// </auto-generated>
using System;

namespace DATOS.Tests
{
    public partial class C_CategoriaTest
    {

[TestMethod]
[PexGeneratedBy(typeof(C_CategoriaTest))]
[PexRaisedException(typeof(TypeInitializationException))]
public void ListarTestThrowsTypeInitializationException109()
{
    List<Categoria> list;
    C_Categoria s0 = new C_Categoria();
    list = this.ListarTest(s0);
}
    }
}
