using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DataModels
{
    public class CounterDataModel
    {
        [Key]
        public required string UUID { get; set; }
        [Required]
        public required string SerialNo { get; set; }
        public DateTime ReadDate { get; set; }
        public decimal LastIndexValue { get; set; }
        public decimal ReadVoltageValue { get; set; }
        public decimal ReadAmperValue { get; set; }

        [MaxLength(25)]
        public string? ReaderName { get; set; }
    }
}
