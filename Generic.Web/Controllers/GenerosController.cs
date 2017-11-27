using AutoMapper;
using Generic.Data.Infrastructure;
using Generic.Data.Repositories;
using Generic.Entities;
using Generic.Web.Infrastructure.Core;
using Generic.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Generic.Web.Controllers
{
    [RoutePrefix("api/generos")]
    public class GenerosController : ApiControllerBase
    {
        private readonly IEntityBaseRepository<Genero> _generosRepository;

        public GenerosController(IEntityBaseRepository<Genero> generosRepository,
             IEntityBaseRepository<Error> _errorsRepository, IUnitOfWork _unitOfWork)
            : base(_errorsRepository, _unitOfWork)
        {
            _generosRepository = generosRepository;
        }

        [AllowAnonymous]
        public HttpResponseMessage Get(HttpRequestMessage request)
        {
            return CreateHttpResponse(request, () =>
            {
                HttpResponseMessage response = null;
                var generos = _generosRepository.GetAll().ToList();

                var generosVM = Mapper.Map<List<Genero>, List<GeneroViewModel>>(generos);

                response = request.CreateResponse<IEnumerable<GeneroViewModel>>(HttpStatusCode.OK, generosVM);

                return response;
            });
        }
    }
}
