﻿namespace CrowdChat.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using MongoDB.Driver;
    using MongoDB.Driver.Builders;
    using MongoDB.Driver.Linq;

    using CrowdChat.Models;

    public class MongoDbContext
    {
        private readonly MongoDatabase mongoDatabase;

        public MongoDbContext()
        {
        }

        public MongoDbContext(string connectionString, string databaseName)
        {
            var mongoClient = new MongoClient(connectionString);
            var mongoServer = mongoClient.GetServer();
            this.mongoDatabase = mongoServer.GetDatabase(databaseName);
        }

        public ICollection<T> GetICollection<T>()
        {
            return this.GetList<T>();
        }

        public IQueryable<T> GetIQueryable<T>()
        {
            return this.GetMongoCollection<T>().AsQueryable();
        }
        public IList<T> GetList<T>()
        {
            return this.GetMongoCollection<T>().FindAll().ToList();
        }

        public MongoCollection<T> GetMongoCollection<T>()
        {
            var typeOfModel = typeof(T);
            return this.mongoDatabase.GetCollection<T>(typeOfModel.Name);
        }

        public void Insert<T>(T genericObject)
        {
            this.GetMongoCollection<T>().Insert(genericObject);
        }

        public IList<Message> GetMessagesSince(DateTime time)
        {
            var postSinceQuery = Query<Message>.Where(log => log.PostedOn > time);
            return this.GetMongoCollection<Message>().Find(postSinceQuery).ToList();
        }
    }
}
