using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsWPFExample.Repositories
{
    /// <summary>
    /// Представляет абстрактный базовый класс репозитория.
    /// </summary>
    internal abstract class BaseRepository
    {
        /// <summary>
        /// Строка подключения к базе данных.
        /// </summary>
        protected string _connectionString = null!;
    }

}
