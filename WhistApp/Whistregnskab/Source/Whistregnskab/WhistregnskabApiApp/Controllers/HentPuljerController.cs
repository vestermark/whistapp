using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WhistregnskabApiApp.Models;

namespace WhistregnskabApiApp.Controllers
{
    public class HentPuljerController : ApiController
    {
        WhistregnskabsModel ctx = new WhistregnskabsModel();

        public IEnumerable<Pulje> GetEjerPuljer(string id)
        {
            return ctx.Puljer.Where(p => p.Ejer == id).ToList();
        }

        public IEnumerable<Pulje> GetAllePuljer()
        {
            return ctx.Puljer.ToList();
        }

        public bool PostPuljer(Pulje nyPulje)
        {
            ctx.Puljer.Add(nyPulje);
            ctx.SaveChanges();
            return true;
        }

        public bool PutPulje(Pulje retPulje)
        {
            ctx.Entry(retPulje).State = System.Data.Entity.EntityState.Modified;
            ctx.SaveChanges();
            return true;
        }

        public bool DeletePulje(int Id)
        {
            Pulje pulje = ctx.Puljer.Find(Id);
            ctx.Puljer.Remove(pulje);
            ctx.SaveChanges();
            return true;
        }

    }
}
