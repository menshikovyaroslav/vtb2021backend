using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace vtb_api.Models
{
    /// <summary>
    /// Модель объекта датасета
    /// </summary>
    [Table("dataset")]
    public class WorkDataset
    {
        /// <summary>
        /// Id датасета
        /// </summary>
        [Column("id")]
        public int Id { get; set; }

        /// <summary>
        /// Название датасета
        /// </summary>
        [Column("name")]
        public string Name { get; set; }

        /// <summary>
        /// Описание датасета
        /// </summary>
        [Column("description")]
        public string Description { get; set; }
    }
}
