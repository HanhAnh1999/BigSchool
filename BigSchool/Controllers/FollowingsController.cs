using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BigSchool.Controllers
{
    private readonly ApplicationDbContext _dbContext;

    public class FollowingsController : ApiController
    {
        private readonly ApplicationDbContext _dbContext;
        
        public FollowingsController()
        {
            _dbContext = new ApplicationDbContext();

        }

        [HttpPost]
        public IHttpActionResult Follow (FollowingDTO followingDTO)
        {
            //var userId = User.Identity.GetUserId();
            //    if(_dbContext.Attendances.Any(a => a.FollowerId == userId && a.FolloweeId == followingDTO.FolloweeId))
            //    return BadRequest("Following already exists!")

            //    var following = new Following
            //    {
            //        FollowerId = userId,
            //        FolloweeId = followingDTO.FolloweeId()
            //    };

            //    _dbContext.Following.Add(following);
            //    _dbContext.SaveChangges();

            //    return Ok();
        }


    }
}
