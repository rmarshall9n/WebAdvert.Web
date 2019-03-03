using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebAdvert.Web.Models.Password;
using Amazon.AspNetCore.Identity.Cognito;
using Amazon.Extensions.CognitoAuthentication;

namespace WebAdvert.Web.Controllers
{
    public class PasswordController : Controller
    {
        private readonly UserManager<CognitoUser> _userManager;
        private readonly CognitoUserPool _pool;

        public PasswordController(UserManager<CognitoUser> userManager, CognitoUserPool pool)
        {
            _userManager = userManager;
            _pool = pool;
        }

        public async Task<IActionResult> Forgot()
        {
            var model = new ForgotModel();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Forgot(ForgotModel model)
        {
            if (ModelState.IsValid)
            {
                var user = _pool.GetUser(model.Email);

                if (user != null)
                {
                    await user.ForgotPasswordAsync();
                }
            }

            return View(model);
        }

        public async Task<IActionResult> Reset()
        {
            var model = new ResetModel();
            return View(model);
        }



        [HttpPost]
        public async Task<IActionResult> Reset(ResetModel model)
        {
            if (ModelState.IsValid)
            {
                var user = _pool.GetUser(model.Email);

                if (user != null)
                {
                    await user.ConfirmForgotPasswordAsync(model.Code, model.Password);

                    RedirectToAction("Index", "Home");
                    // if (result.Succeeded)
                    // {
                    // }
                    // else
                    // {
                    //     foreach (var item in result.Errors)
                    //     {
                    //         ModelState.AddModelError(item.Code, item.Description);
                    //     }
                    // }
                }
            }

            return View(model);
        }
    }
}