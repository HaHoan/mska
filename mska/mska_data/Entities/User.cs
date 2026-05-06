using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mska_data.Models
{
    public partial class User
    {
        public string DisplayName => Username;
    }
}
