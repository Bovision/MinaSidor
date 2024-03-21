using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace Core.Models.shared
{
    public class AddressModel
    {
        [Key]
        public int AddressId { get; set; }

 
        [DataMember(Name = "streetAddress", EmitDefaultValue = false)]
        public string StreetAddress { get; set; }

        [DataMember(Name = "zipCode", EmitDefaultValue = false)]
        public string ZipCode { get; set; }

        [DataMember(Name = "city", EmitDefaultValue = false)]
        public string City { get; set; }

        [DataMember(Name = "areaName", EmitDefaultValue = false)]
        public string AreaName { get; set; }

        [DataMember(Name = "countryCode", EmitDefaultValue = false)]
        public string CountryCode { get; set; }

        [DataMember(Name = "countyMunicipalityParishCode", EmitDefaultValue = false)]
        public string CountyMunicipalityParishCode { get; set; }

        [DataMember(Name = "wgs84Coordinate", EmitDefaultValue = false)]
        public Wgs84Coordinate Wgs84Koordinater { get; set; } = new Wgs84Coordinate();

        [DataMember(Name = "directions", EmitDefaultValue = false)]
        public string Directions { get; set; }

    }

    public class Wgs84Coordinate
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("AddressModel")]
        public int AddressId { get; set; }

        public double? Longitude { get; set; }

        public double? Latitude { get; set; }

    }
}
