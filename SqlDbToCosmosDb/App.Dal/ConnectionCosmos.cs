using App.Model;
using Microsoft.Azure.Cosmos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace App.Dal
{
    
    public class ConnectionCosmos
    {
        public ConnectionCosmos()
        {
            cosmosClient = new CosmosClient(EndpointUri, PrimaryKey, new CosmosClientOptions() { ApplicationName = "CosmosDBDotnetQuickstart" });
            productsDB = new List<ProductsCM>();
        }
        // The Azure Cosmos DB endpoint for running this sample.
        private static readonly string EndpointUri = "https://localhost:8081";

        // The primary key for the Azure Cosmos account.
        private static readonly string PrimaryKey = "C2y6yDjf5/R+ob0N8A7Cgv30VRDJIWEHLM+4QDU5DE2nQ9nDuVTqobD4b8mGGyPMbIZnqyMsEcaGQy67XIw/Jw==";

        // The Cosmos client instance
        private CosmosClient cosmosClient;

        // The database we will create
        private Database database;

        // The container we will create.
        private Microsoft.Azure.Cosmos.Container container;

        // The name of the database and container we will create
        private string databaseId = "NorthwindDB";
        private string containerId = "products";

        List<ProductsCM> productsDB;

        public async Task<object> GetStartedDemoAsync(List<ProductsCM> productList)
        {
            try
            {
                //create the database
                database = await cosmosClient.CreateDatabaseIfNotExistsAsync(databaseId);

                //create the container
                container = await database.CreateContainerIfNotExistsAsync(containerId, "/ProductName", 400);

                //import all the products
                await AddProductsToContainerAsync(productList);

                await GetAllProductsFromCosmos();

                return productsDB;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private async Task AddProductsToContainerAsync(List<ProductsCM> productList)
        {
            try
            {
                ProductsCM ProductCheck = productList.First();
                // Read the item to see if it exists
                ItemResponse<ProductsCM> cosmosProduct = await this.container.ReadItemAsync<ProductsCM>(ProductCheck.ID, new PartitionKey(ProductCheck.ProductName));
            }
            catch (CosmosException ex) when (ex.StatusCode == HttpStatusCode.NotFound)
            {
                foreach (ProductsCM product in productList)
                {
                    await container.CreateItemAsync<ProductsCM>(product, new PartitionKey(product.ProductName));
                }
            }
        }

        private async Task GetAllProductsFromCosmos()
        {
            string cosmosQuary = "select * from NorthwindDB";

            QueryDefinition queryDefinition = new QueryDefinition(cosmosQuary);

            FeedIterator<ProductsCM> feedIterator = container.GetItemQueryIterator<ProductsCM>(queryDefinition);

            while (feedIterator.HasMoreResults)
            {
                FeedResponse<ProductsCM> currentResultSet = await feedIterator.ReadNextAsync();

                foreach (ProductsCM product in currentResultSet)
                {
                    productsDB.Add(product);
                }
            }
        }
    }
    }
