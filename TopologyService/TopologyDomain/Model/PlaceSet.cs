using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Domain.CrossCutting.Model;
using NetTopologySuite.Geometries;

namespace TopologyDomain.Model
{

    /// <summary>
    /// Set of places. It is represented by a <see cref="Geometry"/> and correlates the places through a <see cref="IEnumerable{SortedPlace}"/>
    /// </summary>
    public class PlaceSet : BaseEntity
    {
        /// <summary>
        /// Given name for the PlaceSet, for instance, Line, Route, Building
        /// </summary>
        [Required, StringLength(256)]
        public string Name { get; set; }

        /// <summary>
        /// It represents the place in the map through a a figure of type <see cref="Geometry"/>
        /// </summary>
        [Required]
        public Geometry Location { get; set; }

        /// <summary>
        /// It is the group of places that compose the current PlaceSet. 
        /// </summary>
        public IEnumerable<SortedPlace> Places { get; set; }


    }
}
