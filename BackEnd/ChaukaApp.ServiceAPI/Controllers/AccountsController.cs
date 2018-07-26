﻿namespace ChaukaApp.ServiceAPI.Controllers
{
    using System.Web.Http;
    using BusinessLogic;
    using DataAccess;
    using Model.Core;
    using Model.Object;
    using Model.Result;

    public class AccountsController : ApiController
    {
        // GET api/accounts
        [HttpGet]
        public IResult<Account> Get(string accountName)
        {
            IEventHost userVerifier = new EventHost();
            IUserRepository<User> userRepository = new UserRepository();
            userVerifier.Repository = userRepository;
            return userVerifier.Authentication(accountName);
        }        

        // PATCH: api/accounts/
        [HttpPatch]
        public void UpdateGoogleMapPosition([FromBody] User user)
        {
            IMapPositioner positioner = new MapPositioner();
            var result = positioner.UpdateUserPosition(user);
        }
    }
}
