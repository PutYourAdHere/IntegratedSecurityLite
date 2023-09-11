using System.ComponentModel.DataAnnotations;
using Microsoft.SqlServer.Types;

namespace TopologyApi.Model
{
    public class SortedPlaceDto : BaseDto
    {

        [Required(ErrorMessage = "Place is required")]
        public PlaceDto Place { get; set; }

        [Required(ErrorMessage = "PlaceSet is required")]
        public PlaceSetDto PlaceSet { get; set; }

        [Required(ErrorMessage = "Level is required")]
        public SqlHierarchyId Level { get; set; }
    }
}
