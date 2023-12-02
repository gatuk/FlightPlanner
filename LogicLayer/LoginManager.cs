﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicLayerInterfaces;
using DataAccessLayer;
using DataAccessInterfaces;
using DataObjects;

namespace LogicLayer
{
    public class ILoginManager : ILoginManager
    {
        private ILoginAccessor loginAccessor = new LoginAccessor();

        public string verifyUser(string username, string password)
        {
            string role = "";
            role = loginAccessor.verifyUser(username, password);
            return role;
        }
    }
}