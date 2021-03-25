﻿using IdentityServer4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TablesReach.IdentityServer
{
    public class Config
    {
        public static IEnumerable<ApiScope> GetAllApiResources()
        {
            return new List<ApiScope>
            {
                new ApiScope("TablesReachApi", "Api for solution")
            };
        }

        public static IEnumerable<Client> GetClients()
        {
            return new List<Client>
            {
                new Client
                {
                    ClientId = "client",
                    AllowedGrantTypes = GrantTypes.ClientCredentials,
                    ClientSecrets =
                    {
                        new Secret("secret".Sha256())
                    },
                    AllowedScopes = { "TablesReachApi" }
                }
            };
        }
    }
}
