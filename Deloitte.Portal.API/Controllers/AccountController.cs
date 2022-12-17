using Deloitte.Portal.Model.ViewModels;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Deloitte.Portal.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [EnableCors]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;

        public AccountController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        [AcceptVerbs("Get","Post")]
        public async Task<IActionResult> IsEmailInUse(string email)
        {
            var user = await userManager.FindByEmailAsync(email);
            if(user == null)
            {
                return Ok();
            }
            else
            {
                return BadRequest("Email "+email+" is already in use.");
            }
        }

            [HttpPost]
        public async Task<IActionResult> Register(RegisterUserViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                var user = new IdentityUser { UserName = model.Email, Email = model.Email };
                var result = await userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    //await signInManager.SignInAsync(user, isPersistent: false);
                    return Ok("User Registered");
                }
                List<string> lsterrors = new List<string>();
                if (!result.Succeeded)
                {
                    string error = string.Empty;
                    foreach(var item in result.Errors)
                    {
                       lsterrors.Add(item.Code);
                    }
                    return BadRequest(lsterrors);
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }

                //foreach(var error in result.Errors)
                //{
                //    ModelState.AddModelError("",error.Description);
                //}
               return StatusCode(500);

        }


        [HttpPost]
        public async Task<IActionResult> Login(LoginUserViewModel model, string returnUrl)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var result = await signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, false);
            if(result.Succeeded)
            {
                if (!string.IsNullOrEmpty(returnUrl) && Url.IsLocalUrl(returnUrl))
                {
                    return Ok("Success Login");
                }
                return Ok("Success Login");
            }
            else
            {
                return Unauthorized("Invalid Credential");
            }

            
        }
        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return Ok("Logout Success");
        }
    }
}
