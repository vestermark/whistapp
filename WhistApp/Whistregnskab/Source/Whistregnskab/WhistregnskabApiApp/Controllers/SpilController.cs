using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WhistregnskabApiApp.Models;

namespace WhistregnskabApiApp.Controllers
{
    public class SpilController : ApiController
    {

        WhistregnskabsModel ctx = new WhistregnskabsModel();

        public IEnumerable<Spil> GetSpil(int id)
        {
            return ctx.Spil.Where(s => s.SpilId == id).ToList();
        }

        public bool PostSpil(Spil nytSpil)
        {
            ctx.Spil.Add(nytSpil);
            ctx.SaveChanges();
            return true;
        }

        public bool PutSpil(Spil retSpil)
        {
            ctx.Entry(retSpil).State = System.Data.Entity.EntityState.Modified;
            ctx.SaveChanges();
            return true;
        }

        public bool DeleteSpil(int? Id)
        {
            Spil spil = ctx.Spil.Find(Id);
            ctx.Spil.Remove(spil);
            ctx.SaveChanges();
            return true;
        }

    }
}
