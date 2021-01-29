using Business.DataContexts;
using Business.Entities;
using System.Collections.Generic;

namespace Business.Services
{
    public class InventoryService : IInventoryService
    {
        #region Create

        #endregion

        #region Delete

        #endregion

        #region Edit

        #endregion

        #region Get
        public Appraisal GetAppraisal()
        {
            return new InventoryDataContext().GetAppraisal();
        }
        public Appraisal GetAppraisal(int Id)
        {
            return new InventoryDataContext().GetAppraisal(Id);
        }
        public List<Appraisal> GetAppraisals()
        {
            return new InventoryDataContext().GetAppraisals();
        }

        public Appraiser GetAppraiser()
        {
            return new InventoryDataContext().GetAppraiser();
        }
        public Appraiser GetAppraiser(int Id)
        {
            return new InventoryDataContext().GetAppraiser(Id);
        }
        public List<Appraiser> GetAppraisers()
        {
            return new InventoryDataContext().GetAppraisers();
        }

        public IdName GetArtist()
        {
            return new InventoryDataContext().GetArtist();
        }
        public IdName GetArtist(int Id)
        {
            return new InventoryDataContext().GetArtist(Id);
        }
        public List<IdName> GetArtists()
        {
            return new InventoryDataContext().GetArtists();
        }

        public IdName GetArtType()
        {
            return new InventoryDataContext().GetArtType();
        }
        public IdName GetArtType(int Id)
        {
            return new InventoryDataContext().GetArtType(Id);
        }
        public List<IdName> GetArtTypes()
        {
            return new InventoryDataContext().GetArtTypes();
        }

        public Artwork GetArtwork()
        {
            return new InventoryDataContext().GetArtwork();
        }
        public Artwork GetArtwork(int Id)
        {
            return new InventoryDataContext().GetArtwork(Id);
        }
        public List<Artwork> GetArtworks()
        {
            return new InventoryDataContext().GetArtworks();
        }

        public List<IdName> GetCategories()
        {
            return new InventoryDataContext().GetCategories();
        }
        public IdName GetCategory()
        {
            return new InventoryDataContext().GetCategory();
        }
        public IdName GetCategory(int Id)
        {
            return new InventoryDataContext().GetCategory(Id);
        }

        public List<IdName> GetCities()
        {
            return new InventoryDataContext().GetCities();
        }
        public IdName GetCity()
        {
            return new InventoryDataContext().GetCity();
        }
        public IdName GetCity(int Id)
        {
            return new InventoryDataContext().GetCity(Id);
        }

        public List<Company> GetCompanies()
        {
            return new InventoryDataContext().GetCompanies();
        }
        public Company GetCompany()
        {
            return new InventoryDataContext().GetCompany();
        }
        public Company GetCompany(int Id)
        {
            return new InventoryDataContext().GetCompany(Id);
        }

        public List<IdName> GetCountries()
        {
            return new InventoryDataContext().GetCountries();
        }
        public IdName GetCountry()
        {
            return new InventoryDataContext().GetCountry();
        }
        public IdName GetCountry(int Id)
        {
            return new InventoryDataContext().GetCountry(Id);
        }

        public Item GetItem(int Id)
        {
            return new InventoryDataContext().GetItem(Id);
        }
        public Item GetItem()
        {
            return new InventoryDataContext().GetItem();
        }
        public List<Item> GetItems()
        {
            return new InventoryDataContext().GetItems();
        }

        public Manual GetManual(int Id)
        {
            return new InventoryDataContext().GetManual(Id);
        }
        public Manual GetManual()
        {
            return new InventoryDataContext().GetManual();
        }
        public List<Manual> GetManuals()
        {
            return new InventoryDataContext().GetManuals();
        }

        public List<Company> GetMerchants()
        {
            return new InventoryDataContext().GetMerchants();
        }
        public Company GetMerchant()
        {
            return new InventoryDataContext().GetMerchant();
        }
        public Company GetMerchant(int Id)
        {
            return new InventoryDataContext().GetMerchant(Id);
        }

        public Model GetModel(int Id)
        {
            return new InventoryDataContext().GetModel(Id);
        }
        public Model GetModel()
        {
            return new InventoryDataContext().GetModel();
        }
        public List<Model> GetModels()
        {
            return new InventoryDataContext().GetModels();
        }

        public Product GetProduct(int Id)
        {
            return new InventoryDataContext().GetProduct(Id);
        }
        public Product GetProduct()
        {
            return new InventoryDataContext().GetProduct();
        }
        public List<Product> GetProducts()
        {
            return new InventoryDataContext().GetProducts();
        }

        public IdName GetState(int Id)
        {
            return new InventoryDataContext().GetState(Id);
        }
        public IdName GetState()
        {
            return new InventoryDataContext().GetState();
        }
        public List<IdName> GetStates()
        {
            return new InventoryDataContext().GetStates();
        }

        public List<IdName> GetSubCategories()
        {
            return new InventoryDataContext().GetSubCategories();
        }
        public IdName GetSubCategory()
        {
            return new InventoryDataContext().GetSubCategory();
        }
        public IdName GetSubCategory(int Id)
        {
            return new InventoryDataContext().GetSubCategory(Id);
        }

        #endregion
    }
}
