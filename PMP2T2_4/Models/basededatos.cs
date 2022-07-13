using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PMP2T2_4.Models
{
    public class basededatos
    {
        readonly SQLiteAsyncConnection db;
        public basededatos()
        {
        }


        public basededatos(String pathbasedatos)
        {
            db = new SQLiteAsyncConnection(pathbasedatos);

            // -- Creación de tablas de base de datos
            db.CreateTableAsync<contructor>();

        }



        public Task<List<contructor>> listaempleados()
        {

            return db.Table<contructor>().ToListAsync();
        }

        // buscar un empleado especifico por el codigo
        public Task<contructor> ObtenerEmpleado(Int32 pcodigo)
        {
            return db.Table<contructor>().Where(i => i.codigo == pcodigo).FirstOrDefaultAsync();
        }


        // Guardar o actualizar empleado

        public Task<Int32> EmpleadoGuardar(contructor emple)
        {
            if (emple.codigo != 0)
            {
                return db.UpdateAsync(emple);
            }
            else
            {
                return db.InsertAsync(emple);
            }
        }

        public Task<Int32> EmpleadoBorrar(contructor emple)
        {
            return db.DeleteAsync(emple);
        }
    }
}
