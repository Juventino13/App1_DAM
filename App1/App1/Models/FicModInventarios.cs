using System;
using System.Collections.Generic;
using System.Text;

namespace App1.Models
{

    public class zt_cat_cedis
    {

        public int Id { get; set; }
        public string IdCEDI { get; set; }
        public string CEDI { get; set; }
        public string FechaReg { get; set; }
        public string UsuarioReg { get; set; }
        public string FechaUltMod { get; set; }
        public string UsuarioMod { get; set; }
        public bool Activo { get; set; }
        public bool Borrado { get; set; }

    }

    public class zt_cat_almacenes
    {
       
        public int Id { get; set; }//PK
        public string IdCEDI { get; set; }
        public string IdAlmacen { get; set; }
        public string Almacen { get; set; }
        public string FechaReg { get; set; }
        public string UsuarioReg { get; set; }
        public string FechaUltMod { get; set; }
        public string UsuarioMod { get; set; }
        public string Activo { get; set; }
        public string Borrado { get; set; }



    }


    public class zt_cat_productos
    {

        public int Id { get; set; }
        public string SKU { get; set; }
        public string CodigoBarras { get; set; }
        public string Material { get; set; }
        public string FechaReg { get; set; }
        public string UsuarioReg { get; set; }
        public string FechaUltMod { get; set; }
        public string UsuarioMod { get; set; }
        public bool Activo { get; set; }
        public bool Borrado { get; set; }


    }


  
    public class zt_cat_unidad_medidas
    {

        public Int64 Id { get; set; }
        public string IdUMedida { get; set; }
        public string UMedida { get; set; }
        public int CantidadPZA { get; set; }
        public string FechaReg { get; set; }
        public string UsuarioReg { get; set; }
        public string FechaUltMod { get; set; }
        public string UsuarioMod { get; set; }
        public string Activo { get; set; }
        public string Borrado { get; set; }


    }



   
    public class zt_inventarios
    {

        public int Id { get; set; }
        public string IdInventario { get; set; }
        public string IdCEDI { get; set; }
        public string FechaReg { get; set; }
        public string Hora { get; set; }
        public string UsuarioReg { get; set; }
        public string FechaUltMod { get; set; }
        public string UsuarioMod { get; set; }
        public string Activo { get; set; }
        public string Borrado { get; set; }


    }



    
    public class zt_inventarios_acomulados
    {

        public int Id { get; set; }
        public string IdInventario { get; set; }
        public string SKU { get; set; }
        public string Material { get; set; }
        public float CantTeorica { get; set; }
        public float CantFisica { get; set; }
        public float Diferencia { get; set; }
        public string UMedida { get; set; }
        public string FechaReg { get; set; }
        public string UsuarioReg { get; set; }
        public string FechaUltMod { get; set; }
        public string UsuarioMod { get; set; }
        public bool Activo { get; set; }
        public bool Borrado { get; set; }


    }


    public class zt_inventarios_conteos
    {

       

    }
    
    public class zt_cat_cedis
    {

        public int Id { get; set; }
        public string IdCEDI { get; set; }
        public string CEDI { get; set; }
        public string FechaReg { get; set; }
        public string UsuarioReg { get; set; }
        public string FechaUltMod { get; set; }
        public string UsuarioMod { get; set; }
        public string Activo { get; set; }
        public string Borrado { get; set; }

    }
   
  
    public class zt_cat_almacenes
    {

        public int Id { get; set; }
        public string IdCEDI { get; set; }
        public string IdAlmacen { get; set; }
        public string Almacen { get; set; }
        public string FechaReg { get; set; }
        public string UsuarioReg { get; set; }
        public string FechaUltMod { get; set; }
        public string UsuarioMod { get; set; }
        public string Activo { get; set; }
        public string Borrado { get; set; }

    }
  
    public class zt_cat_productos
    {

        public int Id { get; set; }
        public string SKU { get; set; }
        public string CodigoBarras { get; set; }
        public string Material { get; set; }
        public string FechaReg { get; set; }
        public string UsuarioReg { get; set; }
        public string FechaUltMod { get; set; }
        public string UsuarioMod { get; set; }
        public string Activo { get; set; }
        public string Borrado { get; set; }

    }
    
    public class zt_cat_Unidad_medidas
    {

        public Int64 Id { get; set; }
        public string IdUMedida { get; set; }
        public string UMedida { get; set; }
        public int CantidadPZA { get; set; }
        public string FechaReg { get; set; }
        public string UsuarioReg { get; set; }
        public string FechaUltMod { get; set; }
        public string UsuarioMod { get; set; }
        public string Activo { get; set; }
        public string Borrado { get; set; }


    }
    
    public class zt_inventarios
    {

        public int Id { get; set; }
        public string IdInventario { get; set; }
        public string IdCEDI { get; set; }
        public string FechaReg { get; set; }
        public string Hora { get; set; }
        public string UsuarioReg { get; set; }
        public string FechaUltMod { get; set; }
        public string UsuarioMod { get; set; }
        public string Activo { get; set; }
        public string Borrado { get; set; }


    }
  

  
    public class zt_inventarios_conteos
    {


        public string IdInventario { get; set; }
        public string SKU { get; set; }
        public int IdConteo { get; set; }
        public string IdUbicacion { get; set; }
        public string IdCEDI { get; set; }
        public string IdAlmacen { get; set; }
        public string Almacen { get; set; }
        public string Lote { get; set; }
        public string CodBarras { get; set; }
        public string Material { get; set; }
        public float CantFisica { get; set; }
        public string IdUMedida { get; set; }
        public float CantidadPZA { get; set; }
        public String FechaReg { get; set; }
        public String HoraReg { get; set; }
        public String FechaUltMod { get; set; }
        public String HoraUltMod { get; set; }
        public string UsuarioReg { get; set; }


    }
}
