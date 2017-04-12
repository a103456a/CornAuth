using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace CornAuth.Models
{
    public struct Client
    {
        private ObjectId Id;
        private string Name;
        private ObjectId Vendor;
        private ClientType Type;
        private HashedPassword Secret;

        enum ClientType { Public, Confidential }
    }

    
}
