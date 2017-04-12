using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace CornAuth.Models
{
    public class Vendor
    {
        private ObjectId Id;
        private string Email;
        private HashedPassword Password;
        private string EmailCheckToken;
    }
}
