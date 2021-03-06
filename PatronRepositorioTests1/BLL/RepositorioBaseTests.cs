﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using PatronRepositorio.BLL;
using PatronRepositorio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronRepositorio.BLL.Tests
{
    [TestClass()]
    public class RepositorioBaseTests
    {
  
        [TestMethod()]
        public void Guardar()
        {
            Cuentas cuentas = new Cuentas();
            cuentas.CuentaId = 0;
            cuentas.Descripcion = "Cuenta de Oscar";
            RepositorioBase<Cuentas> repositorio;
            repositorio = new RepositorioBase<Cuentas>();
            Assert.IsTrue(repositorio.Guardar(cuentas));
        }

      
    }
}