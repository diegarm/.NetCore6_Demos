using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingAutoFac
{
    public class ConsoleNotificationNew : INotificationService
    {
        public void NotifyChanged(User user)
        {
            Console.WriteLine($">>>>> O novo nome é {user.UserName}");
        }
    }
}
