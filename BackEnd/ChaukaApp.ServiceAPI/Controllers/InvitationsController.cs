﻿namespace ChaukaApp.ServiceAPI.Controllers
{
    using System;
    using System.Web.Http;
    using BusinessLogic;
    using Model.Object;
    using Model.Result;

    public class InvitationsController : ApiController
    {
        // GET api/invitations?userId=1
        public IResult<EventsInvitation> Get(int userId)
        {
            IInvitationsDelivery invitationsDelivery = new InvitationsDelivery();
            IResult<EventsInvitation> resultEvent = new ResultEntity<EventsInvitation>();
            try
            {
                resultEvent = invitationsDelivery.GetInvitations(userId);
            }
            catch (Exception)
            {
                resultEvent.Success = false;
                resultEvent.Message = "The service could not respond to your request";
            }

            return resultEvent;
        }

        public ResultSimplified Patch(Guest guest)
        {
            ResultSimplified result = new ResultSimplified();

            try
            {
                IInvitationsDelivery invitationsDelivery = new InvitationsDelivery();
                //result = invitationsDelivery.ChangeInvitatioReponse(guest);
            }
            catch (Exception)
            {
                result.Success = false;
                result.Message = "The service could not respond to your request";
            }

            return result;
        }
    }
}
