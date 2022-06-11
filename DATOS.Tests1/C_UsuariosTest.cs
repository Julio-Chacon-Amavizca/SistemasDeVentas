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
        /// <summary>Código auxiliar de prueba para Registrar(Usuario, String&amp;)</summary>
        [PexMethod]
        public int RegistrarTest(
            [PexAssumeUnderTest]C_Usuarios target,
            Usuario obj,
            out string Mensaje
        )
        {
            int result = target.Registrar(obj, out Mensaje);
            return result;
            // TODO: agregar aserciones a método C_UsuariosTest.RegistrarTest(C_Usuarios, Usuario, String&)
        }
    }
}
