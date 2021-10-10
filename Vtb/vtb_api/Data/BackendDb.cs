using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vtb_api.Models;

namespace vtb_api.Data
{
    /// <summary>
    /// Контест для работы с БД
    /// </summary>
    public class BackendDb : DbContext
    {
        /// <summary>
        /// Данные всех  датасетов
        /// </summary>
        public DbSet<WorkDataset> Datasets { get; set; }

        /// <summary>
        /// Инициализация контекста работы с БД
        /// </summary>
        /// <param name="options"></param>
        public BackendDb(DbContextOptions<BackendDb> options) : base(options) { }
    }
}
