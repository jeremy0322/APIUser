using APIUser.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace APIUser.Controllers
{
    public class UserController : ApiController
    {
        public IHttpActionResult getUserEmail(string search)
        {
            DBModel sd = new DBModel();
            var result = sd.users.Where(x => x.email.Contains(search) || search == null).ToList();
            return Ok(result);
        }
    }
}
