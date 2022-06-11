using System.Collections.Generic;
using CONTROLADOR;
// <copyright file="C_UsuariosTest.cs">Copyright ©  2022</copyright>

using System;
using DATOS;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DATOS.Tests
{
    /// <summary>Esta clase contiene pruebas unitarias parametrizadas para C_Usuarios</summary>
    [TestClass]
    [PexClass(typeof(C_Usuarios))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class C_UsuariosTest
    {

        /// <summary>Código auxiliar de prueba para Listar()</summary>
        [PexMethod]
        public List<Usuario> ListarTest([PexAssumeUnderTest] C_Usuarios target)
        {
            List<Usuario> result = target.Listar();
            return result;
            // TODO: agregar aserciones a método C_UsuariosTest.ListarTest(C_Usuarios)
        }
    }
}
