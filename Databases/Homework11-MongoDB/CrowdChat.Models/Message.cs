﻿namespace CrowdChat.Models
{
    using System;

    using MongoDB.Bson;
    using MongoDB.Bson.Serialization.Attributes;

    public class Message
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string Content { get; set; }

        public DateTime PostedOn { get; set; }

        public string PostedBy { get; set; }

        public override bool Equals(object obj)
        {
            var other = obj as Message;
            return other != null && this.Id.Equals(other.Id);
        } 
    }
}
