﻿using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIRev.Data.Provider.MongoDB.Interfaces
{
    public interface IDocument
    {
        ObjectId Id { get; set; }
        DateTime CreatedAt { get; }
    }
}
