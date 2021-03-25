﻿using IdentityServer4;
using IdentityServer4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TablesReach.API
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

    public static IEnumerable<Client> Clients = new List<Client>
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

    public static IEnumerable<IdentityResource> IdentityResources = new List<IdentityResource>
    {
        new IdentityResources.OpenId(),
        new IdentityResources.Profile(),
        new IdentityResources.Email(),
    };

    public static IEnumerable<ApiResource> Apis = new List<ApiResource>
    {
        // local API
        new ApiResource(IdentityServerConstants.LocalApi.ScopeName),
    };
}
}
