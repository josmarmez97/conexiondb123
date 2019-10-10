using Microsoft.AspNetCore.Mvc;
using postgres.Models;
using System;
using System.Linq;
namespace postgres.Controllers
{
    public class Registro: Controller
    { 
        
        public ActionResult Index()
        {                                   
            var context = new usuariosContext();
            var usr = context.Usuarios.ToList();                        
            return View(usr);
        }
        public IActionResult Altas()
        {                                    
            return View();
        }
        
        public IActionResult Aniadir()
        {
            try{
                Usuarios datos = new Usuarios();
                datos.Userid=Request.Form["userid"];
                datos.Nombre=Request.Form["nombre"];
                datos.Pass=Request.Form["pass"];
                var context = new usuariosContext();
                context.Add(new Usuarios{ Userid = datos.Userid ,Nombre=datos.Nombre,Pass=datos.Pass});                                
                context.SaveChanges();                 
            }
            catch(Exception ex)
            {   
                string error = ex.Message;
            }   
                return View("Index()");  
        }
        
    }
}