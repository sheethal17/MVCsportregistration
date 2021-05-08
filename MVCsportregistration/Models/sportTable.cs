namespace MVCsportregistration.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using MVCsportregistration.Models;

    [Table("sportTable")]
    public partial class sportTable
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "This field is required!")]
        [StringLength(50)]
        public string Name { get; set; }


        [Required(ErrorMessage = "This field is required!")]
        public int Idnum { get; set; }

        [Required(ErrorMessage = "This field is required!")]
        [StringLength(50)]
        public string IdType { get; set; }




        [Required(ErrorMessage = "This field is required!")]
        [StringLength(50)]
        [EmailAddress()]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "This field is required!")]
        [RegularExpression(@"\+91[0-9]{10}",ErrorMessage="invalid mobile")]
        public string Mobile { get; set; }



        [Required(ErrorMessage = "This field is required!")]
        [StringLength(50)]
        public string Address { get; set; }


        [Required(ErrorMessage = "This field is required!")]
        public Nullable<int> Pin { get; set; }
       



        [Required(ErrorMessage = "This field is required!")]
        [StringLength(50)]
        public string Sport { get; set; }



        [Required(ErrorMessage = "This field is required!")]
        [StringLength(50)]
        public string Role { get; set; }



        [Required(ErrorMessage = "This field is required!")]
        [StringLength(50,MinimumLength =8,ErrorMessage="password should have minimum 8 charecters")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
