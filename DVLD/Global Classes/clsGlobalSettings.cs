using DVLD_BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD
{
    internal static class clsGlobalSettings
    {
        public static event Action OnCurrentUserUpdated;

        public static clsUser CurrentUser { get; set; }

        public static void TriggerCurrentUserUpdated()
        {
            OnCurrentUserUpdated?.Invoke();
        }
    }
}
