using System.ComponentModel.DataAnnotations;
using Domain.CrossCutting.Model;
using Microsoft.SqlServer.Types;
using TopologyDomain.Model;

namespace TopologyDataAccess.Model
{
    class SortedPlaceEF : BaseEntity
    {
        /// <summary>
        /// The place within the PlaceSet and the given hierarchycal level
        /// </summary>
        [Required]
        public Place Place { get; set; }

        /// <summary>
        /// The PlaceSet 
        /// </summary>
        [Required]
        public PlaceSet PlaceSet { get; set; }

        [Required]
        public SqlHierarchyId Level { get; set; }
    }
}
