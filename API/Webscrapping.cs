﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using IronPython.Hosting;
using IronPython.Runtime;
using IronPython;
using Microsoft.Scripting.Hosting;
using Microsoft.Scripting;
using System.Collections.Specialized;

public static class Webscrapping
    {
        public static void EjecutarCoordenadas()
        {
            string pathPy = @"..\coords.py";
            ScriptRuntime py = Python.CreateRuntime();
            dynamic pyProgram = py.UseFile(pathPy);
            
        }

        public static void EjecutarTiempo()
        {
            string pathPy = @"..\weather.py";
            ScriptRuntime py = Python.CreateRuntime();
            dynamic pyProgram = py.UseFile(pathPy);
            
        }
        
    }
