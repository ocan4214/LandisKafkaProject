using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DataModels.ReportingServiceModels
{
    public class ReportingDataModel
    {
        [Key]
        public required string UUID { get; set; }
        public DateTime RequestedDate { get; set; }
        public ushort ReportState { get; set; }
        public required string ReportDescription { get; set; }


    }
}
