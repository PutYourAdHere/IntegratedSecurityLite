using System.ComponentModel.DataAnnotations;
using Domain.CrossCutting.Model;
using NetTopologySuite.Geometries;

namespace TopologyDomain.Model
{
    /// <summary>
    /// It represents a place that could be anything: room, floor, building, station...
    /// </summary>
    public class Place : BaseEntity
    {
        /// <summary>
        /// Given name of the place
        /// </summary>
        [Required,  StringLength(256)]
        public string Name { get; set; }

        /// <summary>
        /// It represents the place in the map through a <see cref="Geometry"/> that could be a point, line, polygon
        /// </summary>
        [Required]
        public Geometry Location { get; set; }

    }
}
