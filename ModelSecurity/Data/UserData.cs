using Entity.Contexts;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    // <summary>
    ///Repositorio encargado de la gestion de la entidad User en la base de datos
    /// </summary>
    class UserData
    {

        private readonly ApplicationDbContext _context;

        private readonly Microsoft.Extensions.Logging.ILogger _logger;


        /// <summary>
        /// Constructor que recibe el contexto de base de datos 
        /// </summary>
        /// < param name="context">Instania de <see cref="ApplicationDbContext"/> para la conexion con la base de datos</param>
        
        public UserData(ApplicationDbContext context, ILogger logger)
        {
            _context = context;
            _logger = logger;
        }

        /// <summary>
        /// obtiene todos los almacenados en la base de datos.
        /// </summary>
        /// <returns>Lista de roles.</returns>
        
        public












    }
}

