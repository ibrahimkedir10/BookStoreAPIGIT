using MongoDB.Bson.Serialization.Attributes;


namespace BookStore1.core
{
    public class Book
    {
        // attrubutes used in  mongoDB
        [BsonId] 
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)] // allows for object to be used as string 

        
        // properties 

        public string Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }
        public string Author { get; set; }


    }
}
