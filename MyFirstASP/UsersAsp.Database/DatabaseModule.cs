using MyFirstAsp.Core.Interfaces;
using MyFirstAsp.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace UsersAsp.Database
{
    public class DatabaseModule : IModule
    {
        private IInjectionContainer container;

        public void Initialize(IInjectionContainer container)
        {
            this.container = container;
        }
    }
}
