using Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DataContexts
{
    public interface IInventoryDataContext
    {
        #region Create

        #endregion

        #region Delete

        #endregion

        #region Edit

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
        IdName GetState();
        IdName GetState(int Id);
        List<IdName> GetStates();
        List<IdName> GetSubCategories();
        IdName GetSubCategory();
        IdName GetSubCategory(int Id);


        #endregion
    }
}
