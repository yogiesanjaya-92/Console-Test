namespace EntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Game_Logger
    {
        public Guid ID { get; set; }

        [Required]
        [StringLength(50)]
        public string First_Name { get; set; }

        [StringLength(50)]
        public string Last_Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Game { get; set; }

        public int Hours { get; set; }
    }
}
