using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using C3_BD;
using C4_Class;

namespace C2_Controlador
{
    public class EmpleadoControlador
    {
        Empleado_BD E_BD;
        public EmpleadoControlador()
        {
            E_BD = new Empleado_BD();
        }

        public StringBuilder Validar_Empleado(Empleado Emp, bool esNuevo)
        {
            StringBuilder Errores = new StringBuilder();

            if (Emp.Legajo.Trim().Length == 0)
            {
                Errores.Append("El campo Legajo es requerido.\n");
            }
            else if (!Emp.Legajo.All(char.IsNumber))
            {
                Errores.Append("El campo Legajo debe ser numerico.\n");
            }
            else if (Emp.Legajo.Length != 8)
            {
                Errores.Append("El campo Legajo debe tener 8 digitos.\n");
            }
            else if(esNuevo && E_BD.Buscar_Existe_Empleado(Emp.Legajo))
            {
                Errores.Append("El campo Legajo debe ser unico.\n");
            }

            if (Emp.Nombre.Trim().Length == 0)
            {
                Errores.Append("El campo Nombre es requerido.\n");
            }
            if (Emp.Apellido.Trim().Length == 0)
            {
                Errores.Append("El campo Apellido es requerido.\n");
            }
            if (Emp.Password.Trim().Length == 0)
            {
                Errores.Append("El campo Password es requerido.\n");
            }

            return Errores;
        }

        public DataTable Obtener_Empleados()
        {
            DataTable dt = E_BD.Obtener_Empleados();
            return dt;
        }

        public List<ComboBoxItem> Obtener_Categorias()
        {
            DataTable dt = E_BD.Obtener_Categorias();
            List<ComboBoxItem> lista = new List<ComboBoxItem>();
            foreach(DataRow row in dt.Rows) {
                ComboBoxItem item = new ComboBoxItem();
                item.Value = row[0].ToString();
                item.Text = row[1].ToString();
                lista.Add(item);
            }

            return lista;
        }

        public List<ComboBoxItem> Obtener_Sucursales()
        {
            DataTable dt = E_BD.Obtener_Sucursales();
            List<ComboBoxItem> lista = new List<ComboBoxItem>();
            foreach (DataRow row in dt.Rows)
            {
                ComboBoxItem item = new ComboBoxItem();
                item.Value = row[0].ToString();
                item.Text = row[0].ToString() + " " + row[1].ToString() + "-" + row[2].ToString();
                lista.Add(item);
            }

            return lista;
        }


        public int Insertar_Empleado(Empleado Emp)
        {
            return E_BD.Insertar_Empleados(Emp);
        }

        public int Eliminar_Empleado(int Legajo)
        {
            return E_BD.Eliminar_Empleado(Legajo);
        }

        public int Actualizar_Empleado(Empleado Emp)
        {
            return E_BD.Actualizar_Empleado(Emp);
        }
    }
}
