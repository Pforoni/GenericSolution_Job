using Generic.Data.Infrastructure;
using Generic.Data.Repositories;
using Generic.Entities;
using Generic.Web.Infrastructure.Core;
using Generic.Web.Infrastructure.Extensions;
using Generic.Web.Models;
using GenericServices.Abstract;
using GenericServices.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Generic.Web.Controllers
{
    //[Authorize(Roles = "Admin")]
    [Authorize]
    [RoutePrefix("api/Account")]
    public class AccountController : ApiControllerBase
    {
        private readonly IMembershipService _membershipService;
        private readonly IEntityBaseRepository<DoctorUser> _userRepository;

        public AccountController(IMembershipService membershipService, IEntityBaseRepository<DoctorUser> userRepository,
            IEntityBaseRepository<Error> _errorsRepository, IUnitOfWork _unitOfWork)
            : base(_errorsRepository, _unitOfWork)
        {
            _membershipService = membershipService;
            _userRepository = userRepository;
        }

        [AllowAnonymous]
        [Route("authenticate")]
        [HttpPost]
        public HttpResponseMessage Login(HttpRequestMessage request, LoginViewModel user)
        {
            return CreateHttpResponse(request, () =>
            {
                HttpResponseMessage response = null;

                if (ModelState.IsValid)
                {
                    MembershipContext _userContext = _membershipService.ValidateUser(user.Username, user.Password);

                    if (_userContext.User != null)
                    {
                        response = request.CreateResponse(HttpStatusCode.OK, new { success = true });
                    }
                    else
                    {
                        response = request.CreateResponse(HttpStatusCode.OK, new { success = false });
                    }
                }
                else
                    response = request.CreateResponse(HttpStatusCode.OK, new { success = false });

                return response;
            });
        }

        [Route("loadUsers")]
        [HttpGet]
        public HttpResponseMessage GetUsers(HttpRequestMessage request)
        {
            return CreateHttpResponse(request, () =>
            {
                HttpResponseMessage response = null;

                if (ModelState.IsValid)
                {
                    var _userContext = _membershipService.GetUsers();

                    if (_userContext != null)
                    {
                        //Substituir por viewmodel a entidade User
                        response = request.CreateResponse<List<DoctorUser>>(HttpStatusCode.OK, _userContext);
                    }
                    else
                    {
                        response = request.CreateResponse(HttpStatusCode.OK, new { success = false });
                    }
                }
                else
                    response = request.CreateResponse(HttpStatusCode.OK, new { success = false });

                return response;
            });
        }

        [AllowAnonymous]
        [Route("register")]
        [HttpPost]
        public HttpResponseMessage Register(HttpRequestMessage request, RegistrationViewModel user)
        {
            return CreateHttpResponse(request, () =>
            {
                HttpResponseMessage response = null;

                if (!ModelState.IsValid)
                {
                    response = request.CreateResponse(HttpStatusCode.BadRequest, new { success = false });
                }
                else
                {
                    User _user = _membershipService.CreateUser(user.Username, user.Email, user.Password);
                    
                    if (_user != null)
                    {
                        var newUser = _userRepository.GetSingle(_user.ID);
                        newUser.UpdateUser(user);
                        
                        _userRepository.Edit(newUser);

                        _unitOfWork.Commit();

                        response = request.CreateResponse(HttpStatusCode.OK, new { success = true });
                    }
                    else
                    {
                        response = request.CreateResponse(HttpStatusCode.OK, new { success = false });
                    }
                }

                return response;
            });
        }
    }
}
