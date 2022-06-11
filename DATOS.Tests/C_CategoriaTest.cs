// <copyright file="C_CategoriaTest.cs">Copyright ©  2022</copyright>
using System;
using System.Collections.Generic;
using CONTROLADOR;
using DATOS;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DATOS.Tests
{
    /// <summary>Esta clase contiene pruebas unitarias parametrizadas para C_Categoria</summary>
    [PexClass(typeof(C_Categoria))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class C_CategoriaTest
    {
        /// <summary>Código auxiliar de prueba para Listar()</summary>
        [PexMethod]
        public List<Categoria> ListarTest([PexAssumeUnderTest]C_Categoria target)
        {
            List<Categoria> result = target.Listar();
            return result;
            // TODO: agregar aserciones a método C_CategoriaTest.ListarTest(C_Categoria)
        }
    }
}
