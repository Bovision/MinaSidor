using Bovision;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using NuGet.Protocol;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cluster.Controllers.bvadmin
    {
    public class AgentController : Controller
        {
        public IActionResult Index()
        {
            
            return View();
            }
        private List<Customer> list = new List<Customer>();
        private Customer c;
        [HttpGet("getall")]
        public async Task<string> getall(string id)
        {
            list.AddRange(Customer.Find());
            var x = JsonConvert.SerializeObject(list.Select(x => x.DisplayName), new JsonSerializerSettings { ReferenceLoopHandling  = ReferenceLoopHandling.Ignore });
            return x;
        }
        [HttpGet("api/Agent/autocomplete")]
        public async Task<string> autocomplete(string id)
        {
            int id2 = 0;
            if(!id.IsNullOrEmpty())
            if (id.Length > 1)
                {
                
                if (int.TryParse(id, out id2))
                    {
                    c = Customer.ById(id2); 

                    //   c.address = c.address;
                    if (c != null)
                        list.Add(c);
                    if (id.Length > 6)
                        {

                        var inv = Invoice.Get(Expr.Eq("invoiceid", id));
                        if (inv != null)
                            {
                            var c = Customer.ById(inv.CustomerId);
                            if (c != null)
                                list.Add(Customer.ById(inv.CustomerId));
                            //  flowlayoutpanel1.controls.add(new searchrow(c, inv, null));
                                
                            }

                        }
                    } 

                else if (id.Length > 2)
                    {
                    var cs = Customer.Find(Expr.Like("name", "%" + id + "%"));
                    var orgnr = Customer.Find(Expr.Like("orgnr", id + "%"));
                    list.AddRange(cs.Concat(orgnr));
                    //  list = id.length > 7 ? list.asenumerable() : list.take(15);

                    }
                }
            var y = (from b in list select new { id = b.Id, displayname = b.DisplayName }).ToList();
            //  var x = jsonconvert.serializeobject(list.select( x => x.displayname ), new jsonserializersettings { referenceloophandling = referenceloophandling.ignore });

            return y.ToJson();
            }
        }
    }
    
