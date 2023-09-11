using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using NetTopologySuite.Geometries;

namespace TopologyApi.Model
{
    public class PlaceSetDto : BaseDto
    {
        [Required(ErrorMessage = "Name is required"), StringLength(128, ErrorMessage = "Only 128 characters maximum allowed"), MinLength(5, ErrorMessage = "Name must have at least 5 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Location is required")]
        public Geometry Location { get; set; }

        public IEnumerable<SortedPlaceDto> Places { get; set; }


    }
}
