#region Using

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#endregion

namespace SmartAdminSaludsa.Models
{
    public class IndexAdminViewModel
    {
        
        public Administradores Administradores { get; internal set; }
        public Gestores Gestores { get; internal set; }
        public Clientes Clientes { get; internal set; }

        
    }

    public class Administradores: UserCantidad
    {
    }
    public class Gestores : UserCantidad
    {
    }
    public class Clientes : UserCantidad
    {
    }
    public class UserCantidad 
    {
        public int Cantidad { get; set; }
    }

    public class UserFecha
    {
        public DateTime Fecha { get; set; }
        public int Cantidad { get; set; }
    }
}
