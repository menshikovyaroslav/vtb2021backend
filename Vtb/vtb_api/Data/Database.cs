using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vtb_api.Classes;
using vtb_api.Models;

namespace vtb_api.Data
{
    /// <summary>
    /// Класс для выполнения запросов в БД
    /// </summary>
    public static class DataBase
    {
        /// <summary>
        /// Строка подключения к БД. Сервер находится в локальной сети, поэтому в настройки не вынесено. Надеюсь не страшно )
        /// </summary>
        const string connString = "Server=192.168.1.21;Port=5432;User Id=backenduser;Password=Qwerty123;Database=vtbhack;CommandTimeOut=5000";

        /// <summary>
        /// Получить список датасетов
        /// </summary>
        /// <returns></returns>
        public static List<WorkDataset> GetDatasets()
        {
            var result = new List<WorkDataset>();
            try
            {
                using (var db = new BackendDb(new DbContextOptionsBuilder<BackendDb>().UseNpgsql(connString).Options))
                {
                    result = db.Datasets.ToList();
                }
            }
            catch (Exception ex)
            {
                Log.Instance.Error(1, ex.Message);
            }

            return result;
        }
    }
}
