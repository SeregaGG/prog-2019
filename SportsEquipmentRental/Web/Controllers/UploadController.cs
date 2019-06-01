using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Web.Models;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using Web.Models.DataAccessPostgreSqlProvider;

namespace Sport.Controllers
{
    public class UploadController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DoUpload(IFormFile file)
        {
            using (var stream = file.OpenReadStream())
            {
                var xs = new XmlSerializer(typeof(SportsEquipmentRental.CompletingForm));
                var form= (SportsEquipmentRental.CompletingForm)xs.Deserialize(stream);

                using (var db = new SportDbContext())
                {
                    var dbs = new DBSport()
                    {
                        Name = form.Buyer.Name
                    };
                    dbs.Journal = new Collection<DbEquip>();
                    foreach(var e in form.Journal)
                    {
                        dbs.Journal.Add(new DbEquip()
                        {
                            Form = form.Equip
                        });
                    }
                    
                    db.Sport.Add(dbs);
                    //db.SaveChanges();
                }
                return View(form);
            }
        }
        

        public ActionResult List()
        {
            List<DBSport> list;
            using (var db = new SportDbContext())
            {
                list = db.Sport.Include(s => s.Journal).ToList();
            }

            return View(list);
        }
    }
}