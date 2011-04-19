﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SharpOAuth2.Provider.Services
{
    public interface IResourceOwnerService
    {
        bool CredentialsAreValid(string resourceOwnerUsername, string resourceOwnerPassword);
    }
}