using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConexionBD;

namespace mantoFactura
{
    public class Facturamnto
    {
        BDConexion test = new BDConexion();
        public void insertVendor()
        {
            try
            {
                String insert = "INSERT INTO VENDEDOR(VENDEDOR,NOMBRE)VALUES('" + codVendor + "','" + nombreVendor + "')";
                test.Conectar();
                test.consultaSQL(insert);
                test.Desconectar();
            }
            catch
            {

            }
        }
    }
}
