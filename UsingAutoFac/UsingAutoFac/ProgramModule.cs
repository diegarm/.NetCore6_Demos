using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingAutoFac
{
    public class ProgramModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ConsoleNotificationNew>().As<INotificationService>();
            builder.RegisterType<UserService>().AsSelf();
        }
    }
}
