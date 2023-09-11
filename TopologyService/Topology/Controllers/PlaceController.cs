using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.CrossCutting.DataAccess;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TopologyDomain.Model;

namespace TopologyApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PlaceController
    {
        private IRepositoryWriter<Place> PlaceRepository { get; }

        public PlaceController(IRepositoryWriter<Place> placeRepository)
        {
            PlaceRepository = placeRepository;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IAsyncEnumerable<Place> Get() => PlaceRepository.GetAsync();

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ValueTask<Place> Get(Guid id) => PlaceRepository.GetAsync(id);

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public void Create(Place place) => PlaceRepository.Insert(place);

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public void Update(Guid id, Place place) => PlaceRepository.Update(place);

        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public void Delete(Guid id) => PlaceRepository.Delete(id);

    }
}
