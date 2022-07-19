﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using _0_Framework.Infrastructure;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace _0_Framework.Application
{
    public class AuthHelper : IAuthHelper
    {
        private readonly IHttpContextAccessor _contextAccessor;

        public AuthHelper(IHttpContextAccessor contextAccessor)
        {
            _contextAccessor = contextAccessor;
        }

        public List<int> GetPermissions()
        {
            if (!IsAuthenticated())
                return new List<int>();

            var permissions = _contextAccessor.HttpContext.User.Claims.FirstOrDefault(x => x.Type == "permissions")
                ?.Value;
            return JsonConvert.DeserializeObject<List<int>>(permissions);
        }

        //public long CurrentAccountId()
        //{
        //    return IsAuthenticated()
        //        ? long.Parse(_contextAccessor.HttpContext.User.Claims.First(x => x.Type == "AccountId")?.Value)
        //        : 0;
        //}

        //public string CurrentAccountMobile()
        //{
        //    return IsAuthenticated()
        //        ? _contextAccessor.HttpContext.User.Claims.First(x => x.Type == "Mobile")?.Value
        //        : "";
        //}

        public string CurrentAccountRole()
        {
            if (IsAuthenticated())
                return _contextAccessor.HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Role)?.Value;
            return null;
        }

        public AuthViewModel CurrentUserInfo()
        {
            var result = new AuthViewModel();
            if (!IsAuthenticated())
                return result;
            var claim = _contextAccessor.HttpContext.User.Claims.ToList();
            result.Id = long.Parse(claim.FirstOrDefault(x => x.Type == "AccountId").Value);
            result.Username = claim.FirstOrDefault(x => x.Type == "Username").Value;
            result.RoleId = long.Parse(claim.FirstOrDefault(x => x.Type == ClaimTypes.Role).Value);
            result.Fname = claim.FirstOrDefault(x => x.Type == ClaimTypes.Name).Value;
            result.Lname = claim.FirstOrDefault(x => x.Type == ClaimTypes.Name).Value;
            result.Role = Roles.GetRole(result.RoleId);
            result.ProfilePhoto = claim.FirstOrDefault(x => x.Type == ClaimTypes.GivenName).Value; //profilePhoto

            return result;
        }

        public bool IsAuthenticated()
        {
            return _contextAccessor.HttpContext.User.Identity.IsAuthenticated;
            //var claims = _contextAccessor.HttpContext.User.Claims.ToList();
            //////if (claims.Count > 0)
            //////    return true;
            //////return false;
            //return claims.Count > 0;
        }

        public void SignIn(AuthViewModel account)
        { 
            var permissions = JsonConvert.SerializeObject(account.Permissions);
            var claims = new List<Claim>
            {
                new Claim("AccountId", account.Id.ToString()),
                new Claim(ClaimTypes.Name, account.Fname+" "+account.Lname),
                new Claim(ClaimTypes.GivenName, account.ProfilePhoto),
                new Claim(ClaimTypes.Role, account.RoleId.ToString()),
                new Claim("Username", account.Username), // Or Use ClaimTypes.NameIdentifier
                new Claim("permissions", permissions)
            };

            var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

            var authProperties = new AuthenticationProperties
            {
                ExpiresUtc = DateTimeOffset.UtcNow.AddDays(1)
            };

            _contextAccessor.HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                new ClaimsPrincipal(claimsIdentity),
                authProperties);
        }

        public void SignOut()
        {
            _contextAccessor.HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
        }

    }
}