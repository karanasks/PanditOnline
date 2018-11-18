using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using EPandit.Repository.DataModel;

namespace EPandit.Api.Controllers
{
    public class UserMasterController : ApiController
    {
        private EPanditEntities db = new EPanditEntities();

        // GET: api/UserMaster
        [Route("GetAllUsers")]
        public IHttpActionResult GetUserMasters()
        {
            var result = db.UserMasters.ToList();

            var finalResult = result.Select(aff => aff.FirstName);

            return Json(finalResult);
        }

        // GET: api/UserMaster/5
        [ResponseType(typeof(UserMaster))]
        public IHttpActionResult GetUserMaster(long id)
        {
            UserMaster userMaster = db.UserMasters.Find(id);
            if (userMaster == null)
            {
                return NotFound();
            }

            return Ok(userMaster);
        }

        // PUT: api/UserMaster/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutUserMaster(long id, UserMaster userMaster)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != userMaster.UserMasterId)
            {
                return BadRequest();
            }

            db.Entry(userMaster).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserMasterExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/UserMaster
        [ResponseType(typeof(UserMaster))]
        public IHttpActionResult PostUserMaster(UserMaster userMaster)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.UserMasters.Add(userMaster);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = userMaster.UserMasterId }, userMaster);
        }

        // DELETE: api/UserMaster/5
        [ResponseType(typeof(UserMaster))]
        public IHttpActionResult DeleteUserMaster(long id)
        {
            UserMaster userMaster = db.UserMasters.Find(id);
            if (userMaster == null)
            {
                return NotFound();
            }

            db.UserMasters.Remove(userMaster);
            db.SaveChanges();

            return Ok(userMaster);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool UserMasterExists(long id)
        {
            return db.UserMasters.Count(e => e.UserMasterId == id) > 0;
        }
    }
}