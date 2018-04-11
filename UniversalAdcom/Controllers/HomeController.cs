using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UniversalAdcom.Models;
using SendGrid;
using System.Net.Mail;
using System.Net;
using System.Configuration;
using System.Net.Mime;
using System.IO;
using System.Web.Services.Description;
using System.Text.RegularExpressions;

namespace UniversalAdcom.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult HowItWorks()
        {
            ViewBag.Message = Session["Message"];
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult FreeArtworkContact(FreeArtworkContact model)
        {
            if (ModelState.IsValid)
            {
                var message = new SendGridMessage();
                //message.AddTo("partnerrelations@universalad.com");
                /* message.AddTo("connerg@universalad.com");*/  // replace with valid value 
                message.AddTo("chrisg@universalad.com");
                message.From = new MailAddress("partnerrelations@universalad.com");  // replace with valid value
                message.Subject = "Create My Free Artwork";
                var body = "Name: {0} <br /> Email: {1} <br /> Phone: {2} <br /> Business Name: {3} <br /> Position: {4} <br /> Website/Facebook {5}";
                message.Html = string.Format(body, model.Name, model.Email, model.Phone, model.BusinessName, model.Position, model.Website);

                var username = ConfigurationManager.AppSettings["sendGridUser"];
                var pswd = ConfigurationManager.AppSettings["sendGridPassword"];

                var credentials = new NetworkCredential(username, pswd);
                var transportWeb = new Web(credentials);

                transportWeb.DeliverAsync(message);

                Session["Message"] = "Message Sent";

                ModelState.Clear(); //clears form when page reload

                return RedirectToAction("EmailRedirect", "Home", new { model.Name, model.Email });
            }
            return View(model);
        }

        public ActionResult EmailRedirect(string Name, string Email)
        {
            var message = new SendGridMessage();
            message.AddTo(Email);
            message.From = new MailAddress("partnerrelations@universalad.com");  // replace with valid value                   

            message.Subject = "Your Free Ad, Confirmed";
            var body = "<body style='width: 100%; background-color: #d4d4d4; '><table style='width: 70%;  border: solid 1px #d4d4d4; padding: 10px; background-color: #fff;' align='center'>" +
                "<th colspan='2' style='border-bottom: solid 2px #000; text-align: center; font-size: 2.2em; padding: 10px;'>Thank You for Contacting Us</th>" +
                "<tr><td colspan='2' style='padding: 10px; text-align: center; font-size: 1.1em;'>We've received your request and can't wait to show you what out team comes up with. Our designers are crazy good and super experienced so it won't take long.</td></tr>" +
                "<tr><td colspan='2' style='padding: 10px; text-align: center; font-size: 1.1em;'>If you have any questions, please call us at (817) 617-2750</td></tr>" +
                "<tr><td colspan='2' style='padding: 10px; text-align: center; font-size: 1.1em;'>Ask for Design Team 4.</td></tr>" +
                "<tr><td colspan='2' style='padding: 10px; text-align: center; font-size: 1.1em;'>Thank You, <br /> UAC Advertising</td></tr>" +
                "<tr><td colspan='2' style='text-align: center; padding: 10px;'><img src='https://lh3.googleusercontent.com/hzmvYoaCY1MlABiQ0x6OG2aamoksGvFw1iK_ow2P8MRv7SHik-G_M-L-_gdz4gCoyZJjOZYUG-rgTvarS4OI_NwpkLEtKXYF6RlDW2jnEwyMIH9IjIYuKbB8OZz-CHc0PS_sq3Nfjg2iymtiaw208D6NJf6eydIk9Dc4wULqzJ1P4aJbgLY_L8reMNKDsIgN1ImtQHqx8XnmRqPRdCkxQMrK5NEdr1A95_-vcRI_XvU7IcsPQHGpEpj6TAHJ_5hS7aHVeFkfEIpq1BY2HK8Hz14ZTHlwm-L8GCdJJ4k60p6aoNpffpI_6R4qRTh_5WTMksYlXhRcAdZxcIBSiJAkxb_1CsStlvFKg7ygqq7t3J8F5O2PmklsIfwNDmV7BvDnO6vGpXDCiehqM5qWxtBxsWgIL0L1BQiGcjy87T-AetcvMpTiljEG87k4gNx72mZu97qY8aPn3KA496niq7NvA1iLgWa5p-3JaNpipah7YkHFtoQKvQwDhG91BNDZ1fykDgPSUbxUWbrGOZHJdQTyGUIV3DtS15TjT9vUzEQZ0rsF3OIMtWuamJOqpTvGjIWV-FZomxeokO0aNa0VBnphTCFVwVOutTGv0Xt-8A=w700-h642-no'></td></tr>" +
                "<tr><td style='padding: 10px; text-align: center; font-size: 1.1em; border-right: solid 1px #d4d4d4; color: #000;'>2922 Avenue East, Arlington,<br /> TX, 76011 </td>" +
                "<td style='padding: 10px; text-align: center; font-size: 1.1em; color: #000;'><a href='https://www.facebook.com/uacadvertising/' target='_blank'>Check out our Facebook ></a></td></tr></body>";

            message.Html = string.Format(body);

            var username = ConfigurationManager.AppSettings["sendGridUser"];
            var pswd = ConfigurationManager.AppSettings["sendGridPassword"];

            var credentials = new NetworkCredential(username, pswd);
            var transportWeb = new Web(credentials);

            transportWeb.DeliverAsync(message);

            return RedirectToAction("HowItWorks", "Home");
        }
    }
}