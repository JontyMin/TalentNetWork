namespace TalentNetWork.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Mailing")]
    public partial class Mailing
    {
        public int ID { get; set; }

        public int? State { get; set; }

        public DateTime? Time { get; set; }

        public int? CompanyID { get; set; }

        public int? UserID { get; set; }
    }
}
