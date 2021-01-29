using Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public interface IInventoryService
    {
        #region Create

        void CreateAppraisal(Appraisal a);
        void CreateAppraiser(Appraiser a);
        void CreateArtist(IdName a);
        void CreateArtType(IdName a);
        void CreateArtwork(Artwork a);
        void CreateCategory(IdName a);
        void CreateCity(IdName a);
        void CreateCompany(Company a);
        void CreateItem(Item a);
        void CreateManual(Manual a);
        void CreateMerchant(Company a);
        void CreateModel(Model a);
        void CreateProduct(Product a);
        void CreateState(IdName a);
        void CreateSubCategory(IdName a);

        #endregion

        #region Delete

        #endregion

        #region Edit

        void UpdateAppraisal(Appraisal a);
        void UpdateAppraiser(Appraiser a);
        void UpdateArtist(IdName a);
        void UpdateArtType(IdName a);
        void UpdateArtwork(Artwork a);
        void UpdateCategory(IdName a);
        void UpdateCity(IdName a);
        void UpdateCompany(Company a);
        void UpdateItem(Item a);
        void UpdateManual(Manual a);
        void UpdateMerchant(Company a);
        void UpdateModel(Model a);
        void UpdateProduct(Product a);
        void UpdateState(IdName a);
        void UpdateSubCategory(IdName a);

        #endregion

        #region Get
        Appraisal GetAppraisal();
        Appraisal GetAppraisal(int Id);
        List<Appraisal> GetAppraisals();

        Appraiser GetAppraiser();
        Appraiser GetAppraiser(int Id);
        List<Appraiser> GetAppraisers();

        IdName GetArtist();
        IdName GetArtist(int Id);
        List<IdName> GetArtists();

        IdName GetArtType();
        IdName GetArtType(int Id);
        List<IdName> GetArtTypes();

        Artwork GetArtwork();
        Artwork GetArtwork(int Id);
        List<Artwork> GetArtworks();

        List<IdName> GetCategories();
        IdName GetCategory();
        IdName GetCategory(int Id);

        List<IdName> GetCities();
        IdName GetCity();
        IdName GetCity(int Id);

        List<Company> GetCompanies();
        Company GetCompany();
        Company GetCompany(int Id);

        List<IdName> GetCountries();
        IdName GetCountry();
        IdName GetCountry(int Id);

        Item GetItem();
        Item GetItem(int Id);
        List<Item> GetItems();

        Manual GetManual();
        Manual GetManual(int Id);
        List<Manual> GetManuals();

        List<Company> GetMerchants();
        Company GetMerchant();
        Company GetMerchant(int Id);

        Model GetModel();
        Model GetModel(int Id);
        List<Model> GetModels();

        Product GetProduct();
        Product GetProduct(int Id);
        List<Product> GetProducts();

        IdName GetState();
        IdName GetState(int Id);
        List<IdName> GetStates();

        List<IdName> GetSubCategories();
        IdName GetSubCategory();
        IdName GetSubCategory(int Id);

        #endregion

    }
}
