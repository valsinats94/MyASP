using Microsoft.VisualStudio.Web.CodeGeneration;
using MyFirstAsp.Core.Interfaces;
using MyFirstAsp.Core.Interfaces.Services;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstASP.ShellServices
{
    public class ShellService : IShellService
    {

        /// <summary>
        /// Shell Configuring Dependency Injection
        /// Registering Modules -> Modularity
        /// Exceptions:
        /// T:System.InvalidOperationException:
        ///   Thrown when the registration of instances was invalid.
        ///
        /// T:SimpleInjector.DiagnosticVerificationException:
        ///   Thrown in case there are diagnostic errors and the SimpleInjector.VerificationOption.VerifyAndDiagnose
        ///   option is supplied.
        ///
        /// T:System.ArgumentException:
        ///   Thrown when option has an invalid value.
        /// 
        /// </summary>
        /// <returns></returns>
        public bool ConfigureDependancyInjection()
        {
            Container container = new Container();
            container.Register<IInjectionContainer, InjectionContainer>(Lifestyle.Singleton);
            
            try
            {
                container.Verify(VerificationOption.VerifyOnly);
            }
            catch(InvalidOperationException ex)
            {
                ILogger logger = new ConsoleLogger();
                logger.LogMessage(ex.ToString() + Environment.NewLine + ex.StackTrace, LogMessageLevel.Error);

                return false;
            }
            catch(DiagnosticVerificationException ex)
            {
                ILogger logger = new ConsoleLogger();
                logger.LogMessage(ex.ToString() + Environment.NewLine + ex.StackTrace, LogMessageLevel.Error);

                return false;
            }
            catch(ArgumentException ex)
            {
                ILogger logger = new ConsoleLogger();
                logger.LogMessage(ex.ToString() + Environment.NewLine + ex.StackTrace, LogMessageLevel.Error);

                return false;
            }
            catch(Exception ex)
            {
                ILogger logger = new ConsoleLogger();
                logger.LogMessage(ex.ToString() + Environment.NewLine + ex.StackTrace, LogMessageLevel.Error);

                return false;
            }

            return true;
        }
    }
}
