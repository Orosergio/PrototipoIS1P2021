using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;
using CAPA_MODELO;

namespace CAPA_CONTROLADOR
{
    public class clsControlador
    {
        clsSentencias Sn = new clsSentencias();
        
        //funcion que retorna los todos los datos de una tabla de un campo en especifico
        public string[] funcItems(string Tabla, string Campo)
        {
            string[] Items = Sn.funcLlenarCmb(Tabla, Campo);
            return Items;
        }
    }
}
