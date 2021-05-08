

namespace MVCsportregistration.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using MVCsportregistration.Models;







    [Table("TournTable")]
    public class Class1
    {
        [Key]
        public int id { get; set; }

        [Required(ErrorMessage = "This field is required!")]
        public string TName { get; set; }
        


        [Required(ErrorMessage = "This field is required!")]
        public string TFormat { get; set; }

        [Required(ErrorMessage = "This field is required!")]
        [StringLength(50)]
        public string ADate { get; set; }




        [Required(ErrorMessage = "This field is required!")]
    
        
       
        public string EDate { get; set; }

        [Required(ErrorMessage = "This field is required!")]
        
        public string SDate { get; set; }



        [Required(ErrorMessage = "This field is required!")]
        [StringLength(50)]
        public string EnDate { get; set; }


        [Required(ErrorMessage = "This field is required!")]
        public Nullable<int> Rules { get; set; }




        [Required(ErrorMessage = "This field is required!")]
        [StringLength(50)]
        public string Fee { get; set; }



        
    }
}






    
