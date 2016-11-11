using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace RTO.Models
{
    [MetadataType(typeof(RegDetailMetaData))]
    public partial class RegDetail
    {

    }
    [DataContract]
    public class RegDetailMetaData
    {
        [DataMember]
        [Required]
        [Display(Name="Month of Manufacture")]
        [RegularExpression("^(0?[1-9]|1[012])$",ErrorMessage="Enter valid Month")]
        public Int32 MonthOfManu {get; set;}

        [DataMember]
        [Required]
        [Display(Name = "Year of Manufacture")]
        [RegularExpression("20[0-9][0-9]",ErrorMessage="Enter year greater than 2000")]
        public Int32 YearOfManu { get; set; }

        [DataMember]
        [Required]
        [Display(Name="Type")]
        public string VehicleType { get; set; }

        [DataMember]
        [Required]
        [Display(Name="Vehicle Make")]
        public string VehicleMake { get; set; }

        [DataMember]
        [Required]
        [Display(Name = "Model")]
        public string VehicleName { get; set; }

        [DataMember]
        [Required]
        [Display(Name = "Owner")]
        public string OwnerName { get; set; }

        [DataMember]
        [Required]
        [Display(Name = "Chassis No")]
        public string ChassisNumber { get; set; }

        [DataMember]
        [Required]
        [Display(Name = "Engine No")]
        public string Engine { get; set; }

        [DataMember]
        [Required]
        [Display(Name = "Fuel")]
        public string FuelUsed { get; set; }

        [DataMember]
        [Required]
        [DataType(DataType.Date)]
        public DateTime ValidFrom { get; set; }

        [DataMember]
        [Required]
        [DataType(DataType.Date)]
        public DateTime ValidUntil { get; set; }

        [DataMember]
        [Required]
        [Display(Name = "Reg Number")]
        public string RegNumber { get; set; }

        [DataMember]
        [Required]
        public string Color { get; set; }

        [DataMember]
        [Required]
        [RegularExpression("[1-4]",ErrorMessage="Enter values between 1 and 4")]
        public int NoOfCylinder { get; set; }
        
    }
}