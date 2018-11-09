using MyFirstAsp.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstAsp.Core.Interfaces
{
    public interface IModule
    {
        void Initialize(IInjectionContainer container);
    }
}
