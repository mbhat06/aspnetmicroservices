using Catalog.API.Entities;
using MongoDB.Driver;
using System.Collections.Generic;

namespace Catalog.API.Data
{
    public class CatalogContextSeed
    {
        public static void SeedData(IMongoCollection<Product> mongoCollection)
        {
            bool existsProducts = mongoCollection.Find(c => true).Any();
            if (!existsProducts)
            {
                mongoCollection.InsertMany(
                [
                    new() {
                        Id = "66f302b32e56e905f6964038",
                        Name = "Skin Care Gadget",
                        Summary = "Morbi in ullamcorper sapien",
                        Description = "Fusce at nunc lacinia, bibendum neque in, pharetra elit. Fusce orci justo, elementum vel mi sit amet, ultrices tempor eros. Ut placerat massa et velit tempor, id congue urna mollis. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam dignissim neque non mattis blandit. Integer eget placerat erat. Donec tempor lorem ipsum, sed imperdiet sem rhoncus vel. Nullam nulla ligula, malesuada quis enim vel, ultrices dapibus mauris. In et justo non elit molestie dapibus sed eu velit. Donec semper, orci ut cursus egestas, nibh urna fringilla tortor, a blandit tellus libero vitae massa. Suspendisse fermentum ex vel volutpat luctus. Etiam ut venenatis leo.",
                        ImageFile = "https://picsum.photos/200/300",
                        Price = "96.99",
                        Category = "Beauty"
                    },
                    new() {
                        Id = "66f302b32e56e905f6964039",
                        Name = "Skin Care Component",
                        Summary = "Donec lacus sapien, mollis nec consequat at, sodales sit amet orci",
                        Description = "Sed nec dictum sem. Pellentesque dictum ante ac quam lobortis placerat. Suspendisse consectetur, sapien consectetur ornare venenatis, ante quam mollis lorem, a vehicula est enim sed quam. Etiam volutpat lacus diam, in elementum erat pharetra eget. Pellentesque lacus nisi, dapibus non volutpat non, lacinia nec nulla. Fusce eget purus suscipit, sagittis lacus sed, posuere mauris. Vivamus porttitor elementum iaculis. Nam id iaculis erat. Maecenas sit amet leo a magna aliquam suscipit id ut dolor. Cras vulputate nisl a scelerisque bibendum. In condimentum viverra congue. Fusce vitae ex vitae dolor venenatis aliquet. Vivamus id blandit lectus, eget vehicula nulla. Quisque laoreet ullamcorper consequat. Donec vitae risus vel lacus eleifend scelerisque.",
                        ImageFile = "https://picsum.photos/200/300",
                        Price = "73.95",
                        Category = "Beauty"
                    },
                    new() {
                        Id = "66f302b32e56e905f6964040",
                        Name = "Game Gear",
                        Summary = "Aenean ultricies nisl mauris, ac gravida dolor tempus et",
                        Description = "Fusce at nunc lacinia, bibendum neque in, pharetra elit. Fusce orci justo, elementum vel mi sit amet, ultrices tempor eros. Ut placerat massa et velit tempor, id congue urna mollis. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam dignissim neque non mattis blandit. Integer eget placerat erat. Donec tempor lorem ipsum, sed imperdiet sem rhoncus vel. Nullam nulla ligula, malesuada quis enim vel, ultrices dapibus mauris. In et justo non elit molestie dapibus sed eu velit. Donec semper, orci ut cursus egestas, nibh urna fringilla tortor, a blandit tellus libero vitae massa. Suspendisse fermentum ex vel volutpat luctus. Etiam ut venenatis leo.",
                        ImageFile = "https://picsum.photos/200/300",
                        Price = "16",
                        Category = "Entertainment"
                    }
                ]);
            }
        }
    }
}
