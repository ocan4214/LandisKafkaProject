using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DataModels
{
    public class ReportingDataModel
    {
        [Key]
        public required string UUID { get; set; }
        public DateTime RequestedDate { get; set; }
        public ReportStatusEnum ReportState { get; set; }
        public required string ReportDescription { get; set; }
    }

    public enum ReportStatusEnum
    {
        Undefined,
        Pending,
        Processing,
        Shipped,
        Delivered,
        Canceled
    }

}
