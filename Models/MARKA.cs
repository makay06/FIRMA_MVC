namespace FIRMA_MVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MARKA")]
    public partial class MARKA
    {
        [Key]
        public int MARKA_REFNO { get; set; }

        [StringLength(20)]
        public string MARKA_ADI { get; set; }
    }
}