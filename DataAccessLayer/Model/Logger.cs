using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLayer.Model
{
    public partial class Logger
    {
        [Column("LoggerID")]
        public int LoggerId { get; set; }
        [Column("operationDate", TypeName = "date")]
        public DateTime? OperationDate { get; set; }
        [Column("operationDescription")]
        [StringLength(100)]
        public string OperationDescription { get; set; }
    }
}
