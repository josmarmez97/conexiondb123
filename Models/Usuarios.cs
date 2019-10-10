using System;
using System.Collections.Generic;
using Npgsql;
using NpgsqlTypes;


namespace postgres.Models
{
    public partial class Usuarios
    {
        public int IdUsuarios { get; set; }
        public string Userid { get; set; }
        public string Nombre { get; set; }
        public string Pass { get; set; }

    }    
}
