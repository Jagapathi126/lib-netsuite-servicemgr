﻿using Celigo.ServiceManager.NetSuite;
using SuiteTalk;
using System;

namespace Tests.Celigo.ServiceManager.NetSuite.Meta
{
    class TestConfiguration
    {
        public string ApplicationId { get; set; }
        public IPassportProvider PassportProvider { get; set; }
        public ITokenPassportProvider TokenPassportProvider { get; set; }

        public TestConfiguration()
        {
            this.ApplicationId = Environment.GetEnvironmentVariable("NS_APP_ID");
            this.PassportProvider = new EnvVariablePassportProvider();
            this.TokenPassportProvider = new EnvVariableTokenPassportProvider();
        }
    }
}
