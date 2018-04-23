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
            ViewBag.Message = Session["Message"];
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult County()
        {
            return View();
        }

        public ActionResult Pizza()
        {
            return View();
        }

        public ActionResult Schools()
        {
            return View();
        }

        public ActionResult Entertainment()
        {
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
            message.From = new MailAddress("connerg@uac4u.com");  // replace with valid value                   

            message.Subject = "Your Free Ad, Confirmed";
            var body = "<body style='width: 100%; background-color: #d4d4d4;'><table style='width: 70%;  border: solid 1px #000; padding: 35px; background-color: #fff;' align='center'>" +
                "<th colspan='2' style='border-bottom: solid 2px #000; text-align: center; font-size: 2.2em; padding: 25px;'>Thank You for Contacting Us</th>" +
                "<tr><td colspan='2' style='padding: 10px; text-align: center; font-size: 1.1em;'>We've received your request and can't wait to show you what out team comes up with. Our designers are crazy good and super experienced so it won't take long.</td></tr>" +
                "<tr><td colspan='2' style='padding: 10px; text-align: center; font-size: 1.1em;'>If you have any questions, please call us at (817) 617-2750</td></tr>" +
                "<tr><td colspan='2' style='padding: 10px; text-align: center; font-size: 1.1em;'>Ask for Design Team 4.</td></tr>" +
                "<tr><td colspan='2' style='padding: 10px; text-align: center; font-size: 1.1em;'>Thank You, <br /> UAC Advertising</td></tr>" +
                "<tr><td colspan='2' style='text-align: center; padding: 25px;'><img style='width: 100%;' src='https://lh3.googleusercontent.com/hzmvYoaCY1MlABiQ0x6OG2aamoksGvFw1iK_ow2P8MRv7SHik-G_M-L-_gdz4gCoyZJjOZYUG-rgTvarS4OI_NwpkLEtKXYF6RlDW2jnEwyMIH9IjIYuKbB8OZz-CHc0PS_sq3Nfjg2iymtiaw208D6NJf6eydIk9Dc4wULqzJ1P4aJbgLY_L8reMNKDsIgN1ImtQHqx8XnmRqPRdCkxQMrK5NEdr1A95_-vcRI_XvU7IcsPQHGpEpj6TAHJ_5hS7aHVeFkfEIpq1BY2HK8Hz14ZTHlwm-L8GCdJJ4k60p6aoNpffpI_6R4qRTh_5WTMksYlXhRcAdZxcIBSiJAkxb_1CsStlvFKg7ygqq7t3J8F5O2PmklsIfwNDmV7BvDnO6vGpXDCiehqM5qWxtBxsWgIL0L1BQiGcjy87T-AetcvMpTiljEG87k4gNx72mZu97qY8aPn3KA496niq7NvA1iLgWa5p-3JaNpipah7YkHFtoQKvQwDhG91BNDZ1fykDgPSUbxUWbrGOZHJdQTyGUIV3DtS15TjT9vUzEQZ0rsF3OIMtWuamJOqpTvGjIWV-FZomxeokO0aNa0VBnphTCFVwVOutTGv0Xt-8A=w700-h642-no'></td></tr>" +
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
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AboutContact(CampaignContact model)
        {
            if (ModelState.IsValid)
            {
                var message = new SendGridMessage();
                message.AddTo("chrisg@universalad.com");
                message.From = new MailAddress("connerg@uac4u.com");
                message.Subject = "UAC4U Advertising Specialist";
                var bodyCampaign = "<h1>Request More Info About Campaign</h1> <br />First Name: {0} <br /> Last Name: {1} <br /> Phone: {2} {3} <br /> Email: {4}";
                var bodyDistributor = "<h1>Request To Become a Distributor</h1> <br />First Name: {0} <br /> Last Name: {1} <br /> Phone: {2} {3} <br /> Email: {4}";

                if (model.Hidden == true)
                {
                    message.Html = String.Format(bodyCampaign, model.FirstName, model.LastName, model.CountryPrefix, model.Phone, model.Email);
                }
                else
                {
                    message.Html = String.Format(bodyDistributor, model.FirstName, model.LastName, model.CountryPrefix, model.Phone, model.Email);
                }
                

                var username = ConfigurationManager.AppSettings["sendGridUser"];
                var pswd = ConfigurationManager.AppSettings["sendGridPassword"];

                var credentials = new NetworkCredential(username, pswd);
                var transportWeb = new Web(credentials);

                Session["Message"] = "Message Sent";

                transportWeb.DeliverAsync(message);
                if (model.Hidden == true)
                {

                    return RedirectToAction("RequestForm", "Home", new { model.FirstName, model.Email });
                }

                else
                {
                    return RedirectToAction("DistributorForm", "Home", new { model.FirstName, model.Email });
                }

            }
            return View();
        }

        public ActionResult RequestForm(string FirstName, string Email)
        {
            var message = new SendGridMessage();

            message.AddTo(Email);
            message.From = new MailAddress("connerg@uac4u.com");
            message.Subject = "UAC4U Advertising Specialist";
            var body = "<body style='width: 100%; background-color: #d4d4d4;'><table style='width: 60%;  border: solid 1px #000; padding: 35px; background-color: #fff;' align='center'>" +
                "<th colspan='2' style='border-bottom: solid 2px #000; text-align: center; font-size: 2.2em; padding: 25px;'>How Can We Help?</th>" +
                "<tr><td colspan='2' style='padding: 10px;'>Hello {0}!,</td></tr>" +
                "<tr><td colspan='2' style='padding: 10px;'>To better help our team provide you with the best assistance possible, please respond to this email with your Customer ID Number and/or the Invoice Number associated with the particular order in question. </td></tr>" +
                "<tr><td colspan='2' style='padding: 10px;'>If you do not know either of those numbers, please respond with your business name, phone number and reason for contacting us.</td></tr>" +
                "<tr><td colspan='2' style='padding: 10px;'>We'll get back to you as soon as we can!</td></tr>" +
                "<tr><td colspan='2' style='padding: 10px;'>Thank You, <br />Conner <br />Director - UAC</td></tr>" +
                "<tr><td colspan='2' style='text-align: center; padding: 10px;'><img style='width: 100%;' src='https://lh3.googleusercontent.com/ALGXc76_ZuFTRjreDzKpVMMgnoTf3z-q7DJ7MET4X9Nyndm_Gnr-KOGVHt_oFnfvCZywFjlhZ-kRsqEIXUe41T2IE0FHwglIFM3jO50a6VqHx3AzX0bt--zHfQoRN3z0qHXte30iOAQeLYizjSdXL-_0CCzMh9Y3BcrHo8BUKSNndakfzStVanu3gJoVYD5WpB2Pt5Ow7x2SrzbeL7ayihXSbymNK7-YUuRl5gMi3JRJqAP1RqzU5KHbF81PPRTcCB-TW31RiDjuNCr1A51EW4h5nwuG1pL9mAS5q20ROJyNvm_qCwcZuqOs_4_7aI20oh46iNMAHvWqQc2kwg3rEihYMI_kXn6R__cs51_CxPzzblYN8NbN9IVKzPqdZSNm_-XgpqfDBBft8fHiH5Hd5sc1JaDnOqAO9-2EJZCqbOtnjk9IEGDD7WIJXsj178qROyW1FTzG5PfuOxqZ5ov9KdWaEfsBVCX27kiy_5fA5zue4HFcbPLf8V4FBMEyqZGhRYMhafX4bxkQrDigawp3dY4WxsUneR5s5FgJ7GLblpy7QyHx1tozbYGRM1S8u5MzWNirDIlJjrXRSg9lmSB3XNAi007mgRaMem0HEA=w460-h240-no'></td></tr>" +
                "<tr><td style='padding: 10px; text-align: center; font-size: 1.1em; border-right: solid 1px #d4d4d4; color: #000;'>2922 Avenue East, Arlington,<br /> TX, 76011 </td>" +
                "<td style='padding: 10px; text-align: center; font-size: 1.1em; color: #000;'><a href='https://www.facebook.com/uacadvertising/' target='_blank'>Check out our Facebook ></a></td></tr></body>";
            message.Html = String.Format(body, FirstName);

            var username = ConfigurationManager.AppSettings["sendGridUser"];
            var pswd = ConfigurationManager.AppSettings["sendGridPassword"];

            var credentials = new NetworkCredential(username, pswd);
            var transportWeb = new Web(credentials);

            transportWeb.DeliverAsync(message);

            return RedirectToAction("HowItWorks", "Home");
        }

        public ActionResult DistributorForm(string FirstName, string Email)
        {
            var message = new SendGridMessage();

            message.AddTo(Email);
            message.From = new MailAddress("connerg@uac4u.com");
            message.Subject = "UAC4U Advertising Specialist";
            var body = "<body style='width: 100%; background-color: #d4d4d4;'><table style='width: 60%;  border: solid 1px #000; padding: 35px; background-color: #fff;' align='center'>" +
                "<th colspan='2' style='border-bottom: solid 2px #000; text-align: center; font-size: 2.2em; padding: 25px;'>Thank You for Your Request</th>" +
                "<tr><td colspan='2' style='text-align: center; padding: 25px;'>{0}, We're getting into our system now and locating all of our awesome distributors in or around your area. Please, feel free to respond to this email with a more detailed location to better narrow down our search, or you could send us your logo and we'll have a free ad created for you in no time!</td></tr>" +
                "<tr><td colspan='2' style='text-align: center; padding: 25px;'><img style='width: 100%;' src='https://lh3.googleusercontent.com/B-s9AHVW-l17suVDXlJ_0voDsOBuaRjqPNcw9kR1zVUXpyQgVLWzEK7J3owQgOyZw-A3x2d4BqtInM5N9PYJWSM8hEMejcwEQuCoGAu9_Zqo7RnktDXKyRKXHWS2SNt8ceE2-igdq1X2nWZlr_g-7S16IpSGuo_2yzHME9kJ8opCnc--6f6oaSO1WnnHdQGGX_D2VUJqxLOASMh1cloQd2_WUgE8CzB0QE6wdtmEYADEHH2ZdiRLqZ2Fkzp6cYAxxbVUA6bwsN9MBrAkPI9om256ziha7xe4dwIb9mrohIX7KWwHRQD5vavmA8lybsxmrS93vkywbekon0s5ZdP7k3AZ2o6klrXnEB03rA6dcMCw7CT7LyoJJ7CP78mFV9kD_OC9HiNbTf8RP2x9PUi5FcvxaZHCqU94IYd9OaQV1ICkHjRCa7_UHI2j_g0VOcBnyhrjWqDvOxC0ygta-oZMis-PazvciwpxnsESWdNLufVHyVlb8v8X9R7Se48KZwqmHaQ2AAgVHnTNkvYiGf_r6_9fwii8pqD8ZX4c1H0iIN2Z6cOyZTKDOYC66x3E1r5eZq8YL-d1YS68b1ZbFRv1Xdyvp9VrUxq5Xi-XEA=w700-h219-no'></td></tr>" +
                "<tr><td style='padding: 25px; text-align: center; font-size: 1.1em; border-right: solid 1px #d4d4d4; color: #000;'>2922 Avenue East, Arlington,<br /> TX, 76011 </td>" +
                "<td style='padding: 25px; text-align: center; font-size: 1.1em; color: #000;'><a href='https://www.facebook.com/uacadvertising/' target='_blank'>Check out our Facebook ></a></td></tr></body>";
            message.Html = String.Format(body, FirstName);

            var username = ConfigurationManager.AppSettings["sendGridUser"];
            var pswd = ConfigurationManager.AppSettings["sendGridPassword"];

            var credentials = new NetworkCredential(username, pswd);
            var transportWeb = new Web(credentials);

            transportWeb.DeliverAsync(message);

            return RedirectToAction("HowItWorks", "Home");
        }
    }
}