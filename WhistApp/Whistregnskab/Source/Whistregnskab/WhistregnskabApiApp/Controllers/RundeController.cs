using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WhistregnskabApiApp.Models;

namespace WhistregnskabApiApp.Controllers
{
    public class RundeController : ApiController
    {
        WhistregnskabsModel ctx = new WhistregnskabsModel();

        public IEnumerable<Runde> GetRunde(int id)
        {
            return ctx.Runder.Where(s => s.PuljeId == id).ToList();
        }

        public bool PostRunde(Runde nyRunde)
        {
            ctx.Runder.Add(nyRunde);
            ctx.SaveChanges();
            return true;
        }

        public bool PutRunde(Runde retRunde)
        {
            ctx.Entry(retRunde).State = System.Data.Entity.EntityState.Modified;
            ctx.SaveChanges();
            return true;
        }

        public bool DeleteRunde(int? Id)
        {
            Runde runde = ctx.Runder.Find(Id);
            ctx.Runder.Remove(runde);
            ctx.SaveChanges();
            return true;
        }

    }
}
