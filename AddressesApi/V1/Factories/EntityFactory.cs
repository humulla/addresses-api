using BaseApi.V1.Domain;
using BaseApi.V1.Infrastructure;

namespace BaseApi.V1.Factories
{
    public static class EntityFactory
    {
        public static Entity ToDomain(this DatabaseEntity databaseEntity)
        {
            //TODO: Map the rest of the fields in the domain object.
            // More information on this can be found here https://github.com/LBHackney-IT/lbh-base-api/wiki/Factory-object-mappings

            return new Entity
            {
                Line1 = databaseEntity.Line1,
                Line2 = databaseEntity.Line2,
                Line3 = databaseEntity.Line3,
                Line4 = databaseEntity.Line4,
                Postcode = databaseEntity.Postcode
                
            };
        }

        public static DatabaseEntity ToDatabase(this Entity entity)
        {
            //TODO: Map the rest of the fields in the database object.

            return new DatabaseEntity
            {
                Line1 = entity.Line1,
                Line2 = entity.Line2,
                Line3 = entity.Line3,
                Line4 = entity.Line4,
                Postcode = entity.Postcode
            };
        }
    }
}
