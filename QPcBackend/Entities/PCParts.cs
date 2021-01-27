using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QPcBackend.Entities{

    public enum Category{
        CPU = 0,
        Motherboard = 1,
        RAM = 2,
        GraphicCard = 3,
        HDD = 4,
        SSD = 5,
        CPUCooler = 6,
        LiquidCooler = 7,
        OpticalDrive = 8,
        PSU = 9,
        Case = 10
    }

    public class PCPart{
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required]
        public int SKU { get; set; }
        [Required]
        public string Manufacturer { get; set; }
        [Required]
        public string ProducName { get; set; }
        [Required]
        public string Price { get; set; }
        [Required]
        public int Warranty { get; set; }
        [Required]
        public Category Category { get; set; }
        [Required]
        public string ImgUrl { get; set; }
     
    }
}