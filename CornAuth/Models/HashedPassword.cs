using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CornAuth.Models
{
    public class HashedPassword
    {
        private string Hash;
        private string Salt;
        private string Iteration;
    }
}
