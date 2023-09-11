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
    public class PlaceSetController
    {

        private IRepositoryWriter<PlaceSet> PlaceSetRepository { get;  }

        public PlaceSetController(IRepositoryWriter<PlaceSet> placeSetRepository)
        {
            PlaceSetRepository = placeSetRepository;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IAsyncEnumerable<PlaceSet> Get() => PlaceSetRepository.GetAsync();

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ValueTask<PlaceSet> Get(Guid id) => PlaceSetRepository.GetAsync(id);

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public void Create(PlaceSet place) => PlaceSetRepository.Insert(place);

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public void Update(Guid id, PlaceSet place) => PlaceSetRepository.Update(place);

        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public void Delete(Guid id) => PlaceSetRepository.Delete(id);
    }
}
