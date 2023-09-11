using System.ComponentModel.DataAnnotations;
using Domain.CrossCutting.Model;
using Microsoft.SqlServer.Types;

namespace TopologyDomain.Model
{
    /// <summary>
    /// It represents a place that belongs to a PlaceSet with a predefined sort (hierarchycal level)
    /// The Level is defined by a <see cref="SqlHierarchyId"/> that set the position of the element within the tree
    /// </summary>
    public class SortedPlace : BaseEntity
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
        public string Level { get; set; }
    }
}
