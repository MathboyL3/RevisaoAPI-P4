﻿using APIRev.Data.Provider.MongoDB.Interfaces;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIRev.Data.Provider.MongoDB
{
    public class Document : IDocument
    {
        public ObjectId Id { get; set; }
        public DateTime CreatedAt { get => Id.CreationTime; }
    }
}
