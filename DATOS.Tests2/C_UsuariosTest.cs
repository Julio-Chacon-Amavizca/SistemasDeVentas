// <copyright file="C_UsuariosTest.cs">Copyright ©  2022</copyright>
using System;
using CONTROLADOR;
using DATOS;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DATOS.Tests
{
    /// <summary>Esta clase contiene pruebas unitarias parametrizadas para C_Usuarios</summary>
    [PexClass(typeof(C_Usuarios))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class C_UsuariosTest
    {
        /// <summary>Código auxiliar de prueba para Editar(Usuario, String&amp;)</summary>
        [PexMethod]
        public bool EditarTest(
            [PexAssumeUnderTest]C_Usuarios target,
            Usuario obj,
            out string Mensaje
        )
        {
            bool result = target.Editar(obj, out Mensaje);
            return result;
            // TODO: agregar aserciones a método C_UsuariosTest.EditarTest(C_Usuarios, Usuario, String&)
        }
    }
}
