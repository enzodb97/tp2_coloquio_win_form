﻿using AdminEmpleadosEF;
using AdminEmpleadosEntidades;
using Microsoft.EntityFrameworkCore;


namespace AdminEmpleadosDatos
{
    public static class EmpleadosDatosEF
    {
        static AdminEmpleadosDBContext? empleadosContext;

        public static List<Empleado> Get(Empleado e)
        {
            empleadosContext = new AdminEmpleadosDBContext();            

            if (empleadosContext.empleado == null)
            {
                return new List<Empleado>();
            }
            //Lazy Loading
            //List<Empleado> list = empleadosContext.empleado.ToList(); //sin departamentos

            List<Empleado> list;
            if (String.IsNullOrWhiteSpace(e.Nombre) && String.IsNullOrWhiteSpace(e.Dni))
            {
                list = empleadosContext.empleado.Include("Departamento").Where(i=>i.anulado == e.anulado).ToList();
            }
            else
            {
                
                /*
                //con warnings, va a dar excepcion si nombre o dni estan nulos en la BD
                list = empleadosContext.empleado.Include("Departamento").Where(i =>
                    i.Nombre.Contains(e.Nombre)
                    ||
                    i.Dni.Contains(e.Dni)
                    ).ToList();
                */

                //? operador ternario (es como un IF-ELSE) 
                //?? operador de fusion de null (Asigna un valor cuando es NULL la variable de la izquierda)                
                list = empleadosContext.empleado.Include("Departamento").Where(i =>
                    (i.Nombre != null ? i.Nombre.Contains(e.Nombre ?? "") : true)
                    ||
                    (i.Dni != null ? i.Dni.Contains(e.Dni ?? "") : true)
                    ).Where(i=>i.anulado == e.anulado).ToList();
            }
            
            

            return list;
        }

        public static int Insert(Empleado e)
        {
            empleadosContext = new AdminEmpleadosDBContext();

            if (empleadosContext == null)
            {
                return 0;
            }
            //seteo el ID en null para que realice el insert porque si tiene otro valor EF lo toma como un update
            e.EmpleadoId = null;
            e.anulado = false;
            empleadosContext.Add(e);//Se agrega el objeto
            empleadosContext.SaveChanges();//Se llama al objeto SaveChanges
            if (e.EmpleadoId == null)
                return 0;

            return (int)e.EmpleadoId;

        }

        public static bool Update(Empleado e)
        {
            empleadosContext = new AdminEmpleadosDBContext();

            var empleadoBD = empleadosContext.empleado.FirstOrDefault(c => c.EmpleadoId == e.EmpleadoId);//Metodo de EF que me devuelve
                                                                                                         //el 1° Elemento que me cumpla la condicion
            if (empleadoBD == null)
                return false;

            empleadoBD.Direccion = e.Direccion;
            empleadoBD.Dni = e.Dni;
            empleadoBD.Salario = e.Salario;
            empleadoBD.FechaIngreso = e.FechaIngreso;
            empleadoBD.Nombre = e.Nombre;
            empleadoBD.dpto_id = e.dpto_id;
            empleadoBD.anulado = false;

            empleadosContext.SaveChanges();

            return true;
        }

        public static bool Anular(int id)
        {
            empleadosContext = new AdminEmpleadosDBContext();

            var empleadoBD = empleadosContext.empleado.FirstOrDefault(c => c.EmpleadoId == id); 
            if (empleadoBD == null)
                return false;

            empleadoBD.anulado = true;

            empleadosContext.SaveChanges();

            return true;
        }

        public static bool DeleteAnulados()
        {
            empleadosContext = new AdminEmpleadosDBContext();


            var listaParaDeletear  = empleadosContext.empleado.Where(c => c.anulado).ToList();

            if (listaParaDeletear.Count() == 0)
                return true;

            empleadosContext.empleado.RemoveRange(listaParaDeletear);
            empleadosContext.SaveChanges(); 

            return true;
        }
    }
}
