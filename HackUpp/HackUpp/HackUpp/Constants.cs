using System;
using System.Collections.Generic;
using System.Text;

namespace HackUpp
{
    public static class Constants
    {
        public static readonly string tenantName = "Hackupp";
        public static readonly string tenantId = "Hackupp.onmicrosoft.com";
        public static readonly string clientId = "2b136628-5f81-4ff2-b66b-ca5d32e3b80d";
        public static readonly string policySignin = "B2C_1_SignupSignin";
        public static readonly string policyPassword = "B2C_1_PasswordReset";
        public static readonly string iosKeychainSecurityGroup = "com.companyname.HackUpp";
       
        static readonly string[] scopes = { "" };
        static readonly string authorityBase = $"https://Hackupp.b2clogin.com/tfp/Hackupp.onmicrosoft.com/";
        public static string ClientId
        {
            get
            {
                return clientId;
            }
        }
        public static string AuthoritySignin
        {
            get
            {
                return $"{authorityBase}{policySignin}";
            }
        }
        public static string AuthorityPasswordReset
        {
            get
            {
                return $"{authorityBase}{policyPassword}";
            }
        }
        public static string[] Scopes
        {
            get
            {
                return scopes;
            }
        }
        public static string IosKeychainSecurityGroups
        {
            get
            {
                return iosKeychainSecurityGroup;
            }
        }
    }
}
