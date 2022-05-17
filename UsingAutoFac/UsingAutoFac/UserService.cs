using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingAutoFac
{
    public class UserService
    {
        private INotificationService _notificationService;

        public UserService(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }

        public void ChangeUserName(User user,User newUser)
        {
            user = newUser;
            _notificationService.NotifyChanged(user);
        }
    }
}
