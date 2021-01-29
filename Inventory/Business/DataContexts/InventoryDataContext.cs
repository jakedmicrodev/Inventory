using Business.Core;
using Business.Entities;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web.Mvc;

namespace Business.DataContexts
{
    public class InventoryDataContext : IInventoryDataContext
    {

        #region Private

        private List<SelectListItem> FillAppraisers(List<Appraiser> v)
        {
            List<SelectListItem> l = new List<SelectListItem>();

            foreach (Appraiser c in v)
            {
                l.Add(new SelectListItem { Text = c.Name, Value = c.Id.ToString() });
            }
            return l;
        }

        private List<SelectListItem> FillAppraisers(List<Appraiser> v, int Id)
        {
            List<SelectListItem> l = new List<SelectListItem>();

            foreach (Appraiser c in v)
            {
                l.Add(new SelectListItem { Text = c.Name, Value = c.Id.ToString(), Selected = (c.Id == Id) });
            }
            return l;
        }

        private List<SelectListItem> FillArtworks(List<Artwork> v)
        {
            List<SelectListItem> l = new List<SelectListItem>();

            foreach (Artwork c in v)
            {
                l.Add(new SelectListItem { Text = c.Title, Value = c.Id.ToString() });
            }
            return l;
        }

        private List<SelectListItem> FillArtworks(List<Artwork> v, int Id)
        {
            List<SelectListItem> l = new List<SelectListItem>();

            foreach (Artwork c in v)
            {
                l.Add(new SelectListItem { Text = c.Title, Value = c.Id.ToString(), Selected = (c.Id == Id) });
            }
            return l;
        }

        private List<SelectListItem> FillCompanies(List<Company> v)
        {
            List<SelectListItem> l = new List<SelectListItem>();

            foreach (Company c in v)
            {
                l.Add(new SelectListItem { Text = c.Name, Value = c.Id.ToString() });
            }
            return l;
        }

        private List<SelectListItem> FillCompanies(List<Company> v, int Id)
        {
            List<SelectListItem> l = new List<SelectListItem>();

            foreach (Company c in v)
            {
                l.Add(new SelectListItem { Text = c.Name, Value = c.Id.ToString(), Selected = (c.Id == Id) });
            }
            return l;
        }

        private List<SelectListItem> FillItems(List<Item> v)
        {
            List<SelectListItem> l = new List<SelectListItem>();

            foreach (Item c in v)
            {
                l.Add(new SelectListItem { Text = c.Name, Value = c.Id.ToString() });
            }
            return l;
        }

        private List<SelectListItem> FillItems(List<Item> v, int Id)
        {
            List<SelectListItem> l = new List<SelectListItem>();

            foreach (Item c in v)
            {
                l.Add(new SelectListItem { Text = c.Name, Value = c.Id.ToString(), Selected = (c.Id == Id) });
            }
            return l;
        }

        private List<SelectListItem> FillList(List<IdName> v)
        {
            List<SelectListItem> l = new List<SelectListItem>();

            foreach (IdName c in v)
            {
                l.Add(new SelectListItem { Text = c.Name, Value = c.Id.ToString() });
            }
            return l;

        }

        private List<SelectListItem> FillList(List<IdName> v, int Id)
        {
            List<SelectListItem> l = new List<SelectListItem>();

            foreach (IdName c in v)
            {
                l.Add(new SelectListItem { Text = c.Name, Value = c.Id.ToString(), Selected = (c.Id == Id) });
            }
            return l;

        }

        private List<SelectListItem> FillModels(List<Model> v)
        {
            List<SelectListItem> l = new List<SelectListItem>();

            foreach (Model c in v)
            {
                l.Add(new SelectListItem { Text = c.Name, Value = c.Id.ToString() });
            }
            return l;

        }

        private List<SelectListItem> FillModels(List<Model> v, int Id)
        {
            List<SelectListItem> l = new List<SelectListItem>();

            foreach (Model c in v)
            {
                l.Add(new SelectListItem { Text = c.Name, Value = c.Id.ToString(), Selected = (c.Id == Id) });
            }
            return l;

        }

        private List<SelectListItem> FillProducts(List<Product> v)
        {
            List<SelectListItem> l = new List<SelectListItem>();

            foreach (Product c in v)
            {
                l.Add(new SelectListItem { Text = c.Item, Value = c.Id.ToString() });
            }
            return l;

        }

        private List<SelectListItem> FillProducts(List<Product> v, int Id)
        {
            List<SelectListItem> l = new List<SelectListItem>();

            foreach (Product c in v)
            {
                l.Add(new SelectListItem { Text = c.Item, Value = c.Id.ToString(), Selected = (c.Id == Id) });
            }
            return l;

        }


        #endregion

        #region Create

        public void CreateAppraisal(Appraisal v)
        {
            var parameters = new DynamicParameters();

            parameters.Add("@AppraiserId", v.AppraiserId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@AppraisalDate", v.AppraisalDate, DbType.DateTime, ParameterDirection.Input);
            parameters.Add("@AppraisedValue", v.AppraisedValue, DbType.Currency, ParameterDirection.Input);
            parameters.Add("@ArtworkId", v.ArtworkId, DbType.Int32, ParameterDirection.Input);

            using (IDbConnection conn = new SqlConnection(Settings.InventoryConnectionString))
            {
                conn.Execute(StoredProcedures.CREATEAPPRAISAL, parameters, commandType: CommandType.StoredProcedure);
            }
        }
        public void CreateAppraiser(Appraiser v)
        {
            var parameters = new DynamicParameters();

            parameters.Add("@Name", v.Name, DbType.String, ParameterDirection.Input, v.Name.Length);
            parameters.Add("@CompanyId", v.CompanyId, DbType.Int32, ParameterDirection.Input);

            using (IDbConnection conn = new SqlConnection(Settings.InventoryConnectionString))
            {
                conn.Execute(StoredProcedures.CREATEAPPRAISER, parameters, commandType: CommandType.StoredProcedure);
            }
        }
        public void CreateArtist(IdName a)
        {
            var parameters = new DynamicParameters();

            parameters.Add("@Name", a.Name, DbType.String, ParameterDirection.Input, a.Name.Length);

            using (IDbConnection conn = new SqlConnection(Settings.InventoryConnectionString))
            {
                conn.Execute(StoredProcedures.CREATEARTIST, parameters, commandType: CommandType.StoredProcedure);
            }
        }
        public void CreateArtType(IdName a)
        {
            var parameters = new DynamicParameters();

            parameters.Add("@Name", a.Name, DbType.String, ParameterDirection.Input, a.Name.Length);

            using (IDbConnection conn = new SqlConnection(Settings.InventoryConnectionString))
            {
                conn.Execute(StoredProcedures.CREATEARTTYPE, parameters, commandType: CommandType.StoredProcedure);
            }
        }
        public void CreateArtwork(Artwork v)
        {
            var parameters = new DynamicParameters();

            parameters.Add("@Title", v.Title, DbType.String, ParameterDirection.Input, v.Title.Length);
            parameters.Add("@ArtTypeId", v.ArtTypeId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@ArtistId", v.ArtistId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@Notes", v.Notes, DbType.String, ParameterDirection.Input, v.Notes.Length);
            parameters.Add("@ItemId", v.ItemId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@ImageName", v.ImageName, DbType.String, ParameterDirection.Input, v.ImageName.Length);

            using (IDbConnection conn = new SqlConnection(Settings.InventoryConnectionString))
            {
                conn.Execute(StoredProcedures.CREATEARTWORK, parameters, commandType: CommandType.StoredProcedure);
            }
        }
        public void CreateCategory(IdName a)
        {
            var parameters = new DynamicParameters();

            parameters.Add("@Name", a.Name, DbType.String, ParameterDirection.Input, a.Name.Length);

            using (IDbConnection conn = new SqlConnection(Settings.InventoryConnectionString))
            {
                conn.Execute(StoredProcedures.CREATECATEGORY, parameters, commandType: CommandType.StoredProcedure);
            }
        }
        public void CreateCity(IdName a)
        {
            var parameters = new DynamicParameters();

            parameters.Add("@Name", a.Name, DbType.String, ParameterDirection.Input, a.Name.Length);

            using (IDbConnection conn = new SqlConnection(Settings.InventoryConnectionString))
            {
                conn.Execute(StoredProcedures.CREATECITY, parameters, commandType: CommandType.StoredProcedure);
            }
        }
        public void CreateCompany(Company v)
        {
            var parameters = new DynamicParameters();

            parameters.Add("@Name", v.Name, DbType.String, ParameterDirection.Input, v.Name.Length);
            parameters.Add("@Address1", v.Address1, DbType.String, ParameterDirection.Input, v.Address1.Length);
            parameters.Add("@Address2", v.Address2, DbType.String, ParameterDirection.Input, v.Address2.Length);
            parameters.Add("@CityId", v.CityId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@StateId", v.StateId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@CountryId", v.CountryId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@PostalCode", v.PostalCode, DbType.String, ParameterDirection.Input, v.PostalCode.Length);
            parameters.Add("@Phone", v.Phone, DbType.String, ParameterDirection.Input, v.Phone.Length);
            parameters.Add("@Fax", v.Fax, DbType.String, ParameterDirection.Input, v.Fax.Length);
            parameters.Add("@Email", v.Email, DbType.String, ParameterDirection.Input, v.Email.Length);

            using (IDbConnection conn = new SqlConnection(Settings.InventoryConnectionString))
            {
                conn.Execute(StoredProcedures.CREATECOMPANY, parameters, commandType: CommandType.StoredProcedure);
            }
        }
        public void CreateItem(Item a)
        {
            var parameters = new DynamicParameters();

            parameters.Add("@Name", a.Name, DbType.String, ParameterDirection.Input, a.Name.Length);

            using (IDbConnection conn = new SqlConnection(Settings.InventoryConnectionString))
            {
                conn.Execute(StoredProcedures.CREATEITEM, parameters, commandType: CommandType.StoredProcedure);
            }
        }
        public void CreateManual(Manual v)
        {
            var parameters = new DynamicParameters();

            parameters.Add("@Name", v.Name, DbType.String, ParameterDirection.Input, v.Name.Length);
            parameters.Add("@ModelId", v.ModelId, DbType.Int32, ParameterDirection.Input);

            using (IDbConnection conn = new SqlConnection(Settings.InventoryConnectionString))
            {
                conn.Execute(StoredProcedures.CREATEMANUAL, parameters, commandType: CommandType.StoredProcedure);
            }
        }
        public void CreateMerchant(Company v)
        {
            var parameters = new DynamicParameters();

            parameters.Add("@Name", v.Name, DbType.String, ParameterDirection.Input, v.Name.Length);
            parameters.Add("@Address1", v.Address1, DbType.String, ParameterDirection.Input, v.Address1.Length);
            parameters.Add("@Address2", v.Address2, DbType.String, ParameterDirection.Input, v.Address2.Length);
            parameters.Add("@CityId", v.CityId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@StateId", v.StateId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@CountryId", v.CountryId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@PostalCode", v.PostalCode, DbType.String, ParameterDirection.Input, v.PostalCode.Length);
            parameters.Add("@Phone", v.Phone, DbType.String, ParameterDirection.Input, v.Phone.Length);
            parameters.Add("@Fax", v.Fax, DbType.String, ParameterDirection.Input, v.Fax.Length);
            parameters.Add("@Email", v.Email, DbType.String, ParameterDirection.Input, v.Email.Length);

            using (IDbConnection conn = new SqlConnection(Settings.InventoryConnectionString))
            {
                conn.Execute(StoredProcedures.CREATEMERCHANT, parameters, commandType: CommandType.StoredProcedure);
            }
        }
        public void CreateModel(Model v)
        {
            var parameters = new DynamicParameters();

            parameters.Add("@Name", v.Name, DbType.String, ParameterDirection.Input, v.Name.Length);
            parameters.Add("@ProductId", v.ProductId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@ModelNumber", v.ModelNumber, DbType.String, ParameterDirection.Input, v.ModelNumber.Length);
            parameters.Add("@SerialNumber", v.SerialNumber, DbType.String, ParameterDirection.Input, v.SerialNumber.Length);
            parameters.Add("@ImageName", v.ImageName, DbType.String, ParameterDirection.Input, v.ImageName.Length);

            using (IDbConnection conn = new SqlConnection(Settings.InventoryConnectionString))
            {
                conn.Execute(StoredProcedures.CREATEMODEL, parameters, commandType: CommandType.StoredProcedure);
            }
        }
        public void CreateProduct(Product v)
        {
            var parameters = new DynamicParameters();

            parameters.Add("@CompanyId", v.CompanyId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@ItemId", v.ItemId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@MerchantId", v.MerchantId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@SupportUrl", v.SupportUrl, DbType.String, ParameterDirection.Input, v.SupportUrl.Length);
            parameters.Add("@AddDate", v.AddDate, DbType.DateTime, ParameterDirection.Input);
            parameters.Add("@RemoveDate", v.RemoveDate, DbType.DateTime, ParameterDirection.Input);

            using (IDbConnection conn = new SqlConnection(Settings.InventoryConnectionString))
            {
                conn.Execute(StoredProcedures.CREATEPRODUCT, parameters, commandType: CommandType.StoredProcedure);
            }
        }
        public void CreateState(IdName a)
        {
            var parameters = new DynamicParameters();

            parameters.Add("@Name", a.Name, DbType.String, ParameterDirection.Input, a.Name.Length);

            using (IDbConnection conn = new SqlConnection(Settings.InventoryConnectionString))
            {
                conn.Execute(StoredProcedures.CREATESTATE, parameters, commandType: CommandType.StoredProcedure);
            }
        }
        public void CreateSubCategory(IdName a)
        {
            var parameters = new DynamicParameters();

            parameters.Add("@Name", a.Name, DbType.String, ParameterDirection.Input, a.Name.Length);

            using (IDbConnection conn = new SqlConnection(Settings.InventoryConnectionString))
            {
                conn.Execute(StoredProcedures.CREATESUBCATEGORY, parameters, commandType: CommandType.StoredProcedure);
            }
        }

        #endregion

        #region Delete

        #endregion

        #region Edit

        public void UpdateAppraisal(Appraisal v)
        {
            var parameters = new DynamicParameters();

            parameters.Add("@Id", v.Id, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@AppraiserId", v.AppraiserId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@AppraisalDate", v.AppraisalDate, DbType.DateTime, ParameterDirection.Input);
            parameters.Add("@AppraisedValue", v.AppraisedValue, DbType.Currency, ParameterDirection.Input);
            parameters.Add("@ArtworkId", v.ArtworkId, DbType.Int32, ParameterDirection.Input);

            using (IDbConnection conn = new SqlConnection(Settings.InventoryConnectionString))
            {
                conn.Execute(StoredProcedures.UPDATEAPPRAISAL, parameters, commandType: CommandType.StoredProcedure);
            }
        }
        public void UpdateAppraiser(Appraiser v)
        {
            var parameters = new DynamicParameters();

            parameters.Add("@Id", v.Id, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@Name", v.Name, DbType.String, ParameterDirection.Input, v.Name.Length);
            parameters.Add("@CompanyId", v.CompanyId, DbType.Int32, ParameterDirection.Input);

            using (IDbConnection conn = new SqlConnection(Settings.InventoryConnectionString))
            {
                conn.Execute(StoredProcedures.UPDATEAPPRAISER, parameters, commandType: CommandType.StoredProcedure);
            }
        }
        public void UpdateArtist(IdName v)
        {
            var parameters = new DynamicParameters();

            parameters.Add("@Id", v.Id, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@Name", v.Name, DbType.String, ParameterDirection.Input, v.Name.Length);

            using (IDbConnection conn = new SqlConnection(Settings.InventoryConnectionString))
            {
                conn.Execute(StoredProcedures.UPDATEARTIST, parameters, commandType: CommandType.StoredProcedure);
            }
        }
        public void UpdateArtType(IdName v)
        {
            var parameters = new DynamicParameters();

            parameters.Add("@Id", v.Id, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@Name", v.Name, DbType.String, ParameterDirection.Input, v.Name.Length);

            using (IDbConnection conn = new SqlConnection(Settings.InventoryConnectionString))
            {
                conn.Execute(StoredProcedures.UPDATEARTTYPE, parameters, commandType: CommandType.StoredProcedure);
            }
        }
        public void UpdateArtwork(Artwork v)
        {
            var parameters = new DynamicParameters();

            parameters.Add("@Id", v.Id, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@Title", v.Title, DbType.String, ParameterDirection.Input, v.Title.Length);
            parameters.Add("@ArtTypeId", v.ArtTypeId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@ArtistId", v.ArtistId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@Notes", v.Notes, DbType.String, ParameterDirection.Input, v.Notes.Length);
            parameters.Add("@ItemId", v.ItemId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@ImageName", v.ImageName, DbType.String, ParameterDirection.Input, v.ImageName.Length);

            using (IDbConnection conn = new SqlConnection(Settings.InventoryConnectionString))
            {
                conn.Execute(StoredProcedures.UPDATEARTWORK, parameters, commandType: CommandType.StoredProcedure);
            }
        }
        public void UpdateCategory(IdName v)
        {
            var parameters = new DynamicParameters();

            parameters.Add("@Id", v.Id, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@Name", v.Name, DbType.String, ParameterDirection.Input, v.Name.Length);

            using (IDbConnection conn = new SqlConnection(Settings.InventoryConnectionString))
            {
                conn.Execute(StoredProcedures.UPDATECATEGORY, parameters, commandType: CommandType.StoredProcedure);
            }
        }
        public void UpdateCity(IdName v)
        {
            var parameters = new DynamicParameters();

            parameters.Add("@Id", v.Id, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@Name", v.Name, DbType.String, ParameterDirection.Input, v.Name.Length);

            using (IDbConnection conn = new SqlConnection(Settings.InventoryConnectionString))
            {
                conn.Execute(StoredProcedures.UPDATECITY, parameters, commandType: CommandType.StoredProcedure);
            }
        }
        public void UpdateCompany(Company v)
        {
            var parameters = new DynamicParameters();

            parameters.Add("@Id", v.Id, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@Name", v.Name, DbType.String, ParameterDirection.Input, v.Name.Length);
            parameters.Add("@Address1", v.Address1, DbType.String, ParameterDirection.Input, v.Address1.Length);
            parameters.Add("@Address2", v.Address2, DbType.String, ParameterDirection.Input, v.Address2.Length);
            parameters.Add("@CityId", v.CityId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@StateId", v.StateId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@CountryId", v.CountryId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@PostalCode", v.PostalCode, DbType.String, ParameterDirection.Input, v.PostalCode.Length);
            parameters.Add("@Phone", v.Phone, DbType.String, ParameterDirection.Input, v.Phone.Length);
            parameters.Add("@Fax", v.Fax, DbType.String, ParameterDirection.Input, v.Fax.Length);
            parameters.Add("@Email", v.Email, DbType.String, ParameterDirection.Input, v.Email.Length);

            using (IDbConnection conn = new SqlConnection(Settings.InventoryConnectionString))
            {
                conn.Execute(StoredProcedures.UPDATECOMPANY, parameters, commandType: CommandType.StoredProcedure);
            }
        }
        public void UpdateItem(Item v)
        {
            var parameters = new DynamicParameters();

            parameters.Add("@Id", v.Id, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@Name", v.Name, DbType.String, ParameterDirection.Input, v.Name.Length);

            using (IDbConnection conn = new SqlConnection(Settings.InventoryConnectionString))
            {
                conn.Execute(StoredProcedures.UPDATEITEM, parameters, commandType: CommandType.StoredProcedure);
            }
        }
        public void UpdateManual(Manual v)
        {
            var parameters = new DynamicParameters();

            parameters.Add("@Id", v.Id, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@Name", v.Name, DbType.String, ParameterDirection.Input, v.Name.Length);
            parameters.Add("@ModelId", v.ModelId, DbType.Int32, ParameterDirection.Input);

            using (IDbConnection conn = new SqlConnection(Settings.InventoryConnectionString))
            {
                conn.Execute(StoredProcedures.UPDATEMANUAL, parameters, commandType: CommandType.StoredProcedure);
            }
        }
        public void UpdateMerchant(Company v)
        {
            var parameters = new DynamicParameters();

            parameters.Add("@Id", v.Id, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@Name", v.Name, DbType.String, ParameterDirection.Input, v.Name.Length);
            parameters.Add("@Address1", v.Address1, DbType.String, ParameterDirection.Input, v.Address1.Length);
            parameters.Add("@Address2", v.Address2, DbType.String, ParameterDirection.Input, v.Address2.Length);
            parameters.Add("@CityId", v.CityId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@StateId", v.StateId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@CountryId", v.CountryId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@PostalCode", v.PostalCode, DbType.String, ParameterDirection.Input, v.PostalCode.Length);
            parameters.Add("@Phone", v.Phone, DbType.String, ParameterDirection.Input, v.Phone.Length);
            parameters.Add("@Fax", v.Fax, DbType.String, ParameterDirection.Input, v.Fax.Length);
            parameters.Add("@Email", v.Email, DbType.String, ParameterDirection.Input, v.Email.Length);

            using (IDbConnection conn = new SqlConnection(Settings.InventoryConnectionString))
            {
                conn.Execute(StoredProcedures.UPDATEMERCHANT, parameters, commandType: CommandType.StoredProcedure);
            }
        }
        public void UpdateModel(Model v)
        {
            var parameters = new DynamicParameters();

            parameters.Add("@Id", v.Id, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@Name", v.Name, DbType.String, ParameterDirection.Input, v.Name.Length);
            parameters.Add("@ProductId", v.ProductId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@ModelNumber", v.ModelNumber, DbType.String, ParameterDirection.Input, v.ModelNumber.Length);
            parameters.Add("@SerialNumber", v.SerialNumber, DbType.String, ParameterDirection.Input, v.SerialNumber.Length);
            parameters.Add("@ImageName", v.ImageName, DbType.String, ParameterDirection.Input, v.ImageName.Length);

            using (IDbConnection conn = new SqlConnection(Settings.InventoryConnectionString))
            {
                conn.Execute(StoredProcedures.UPDATEMODEL, parameters, commandType: CommandType.StoredProcedure);
            }
        }
        public void UpdateProduct(Product v)
        {
            var parameters = new DynamicParameters();

            parameters.Add("@Id", v.Id, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@CompanyId", v.CompanyId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@ItemId", v.ItemId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@MerchantId", v.MerchantId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@SupportUrl", v.SupportUrl, DbType.String, ParameterDirection.Input, v.SupportUrl.Length);
            parameters.Add("@AddDate", v.AddDate, DbType.DateTime, ParameterDirection.Input);
            parameters.Add("@RemoveDate", v.RemoveDate, DbType.DateTime, ParameterDirection.Input);

            using (IDbConnection conn = new SqlConnection(Settings.InventoryConnectionString))
            {
                conn.Execute(StoredProcedures.UPDATEPRODUCT, parameters, commandType: CommandType.StoredProcedure);
            }
        }
        public void UpdateState(IdName v)
        {
            var parameters = new DynamicParameters();

            parameters.Add("@Id", v.Id, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@Name", v.Name, DbType.String, ParameterDirection.Input, v.Name.Length);

            using (IDbConnection conn = new SqlConnection(Settings.InventoryConnectionString))
            {
                conn.Execute(StoredProcedures.UPDATESTATE, parameters, commandType: CommandType.StoredProcedure);
            }
        }
        public void UpdateSubCategory(IdName v)
        {
            var parameters = new DynamicParameters();

            parameters.Add("@Id", v.Id, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@Name", v.Name, DbType.String, ParameterDirection.Input, v.Name.Length);

            using (IDbConnection conn = new SqlConnection(Settings.InventoryConnectionString))
            {
                conn.Execute(StoredProcedures.UPDATESUBCATEGORY, parameters, commandType: CommandType.StoredProcedure);
            }
        }

        #endregion

        #region Get

        public Appraisal GetAppraisal()
        {
            Appraisal a = new Appraisal();
            a.Appraisers = FillAppraisers(GetAppraisers());
            a.Artworks = FillArtworks(GetArtworks());

            return a;
        }
        public Appraisal GetAppraisal(int Id)
        {
            Appraisal a = null;

            using (IDbConnection conn = new SqlConnection(Settings.InventoryConnectionString))
            {
                var parameters = new DynamicParameters();

                parameters.Add("@Id", Id, DbType.Int32, ParameterDirection.Input);
                a = conn.QueryFirst<Appraisal>(StoredProcedures.GETAPPRAISALS + " @Id", parameters);
            }

            a.Appraisers = FillAppraisers(GetAppraisers(), a.AppraiserId);
            a.Artworks = FillArtworks(GetArtworks(), a.ArtworkId);

            return a;
        }
        public List<Appraisal> GetAppraisals()
        {
            using (IDbConnection conn = new SqlConnection(Settings.InventoryConnectionString))
            {
                return conn.Query<Appraisal>(StoredProcedures.GETAPPRAISALS).ToList<Appraisal>();
            }
        }
        
        public Appraiser GetAppraiser()
        {
            Appraiser a = new Appraiser();
            a.Companies = FillCompanies(GetCompanies());

            return a;
        }
        public Appraiser GetAppraiser(int Id)
        {
            Appraiser a = null;

            using (IDbConnection conn = new SqlConnection(Settings.InventoryConnectionString))
            {
                var parameters = new DynamicParameters();

                parameters.Add("@Id", Id, DbType.Int32, ParameterDirection.Input);
                a = conn.QueryFirst<Appraiser>(StoredProcedures.GETAPPRAISERS + " @Id", parameters);
            }

            a.Companies = FillCompanies(GetCompanies(), a.CompanyId);

            return a;
        }
        public List<Appraiser> GetAppraisers()
        {
            using (IDbConnection conn = new SqlConnection(Settings.InventoryConnectionString))
            {
                return conn.Query<Appraiser>(StoredProcedures.GETAPPRAISERS).ToList<Appraiser>();
            }
        }

        public Artwork GetArtwork()
        {
            Artwork a = new Artwork();
            a.Artists = FillList(GetArtists());
            a.ArtTypes = FillList(GetArtTypes());
            a.Items = FillItems(GetItems());

            return a;
        }
        public Artwork GetArtwork(int Id)
        {
            Artwork a = null;

            using (IDbConnection conn = new SqlConnection(Settings.InventoryConnectionString))
            {
                var parameters = new DynamicParameters();

                parameters.Add("@Id", Id, DbType.Int32, ParameterDirection.Input);
                a = conn.QueryFirst<Artwork>(StoredProcedures.GETARTWORKS + " @Id", parameters);
            }

            a.Artists = FillList(GetArtists(), a.ArtistId);
            a.ArtTypes = FillList(GetArtTypes(), a.ArtTypeId);
            a.Items = FillItems(GetItems(), a.ItemId);

            return a;
        }
        public List<Artwork> GetArtworks()
        {
            using (IDbConnection conn = new SqlConnection(Settings.InventoryConnectionString))
            {
                return conn.Query<Artwork>(StoredProcedures.GETARTWORKS).ToList<Artwork>();
            }
        }

        public IdName GetArtist()
        {
            IdName a = new IdName();

            return a;
        }
        public IdName GetArtist(int Id)
        {
            using (IDbConnection conn = new SqlConnection(Settings.InventoryConnectionString))
            {
                var parameters = new DynamicParameters();

                parameters.Add("@Id", Id, DbType.Int32, ParameterDirection.Input);
                return conn.QueryFirst<IdName>(StoredProcedures.GETARTISTS + " @Id", parameters);
            }
        }
        public List<IdName> GetArtists()
        {
            using (IDbConnection conn = new SqlConnection(Settings.InventoryConnectionString))
            {
                return conn.Query<IdName>(StoredProcedures.GETARTISTS).ToList<IdName>();
            }
        }

        public IdName GetArtType()
        {
            IdName a = new IdName();

            return a;
        }
        public IdName GetArtType(int Id)
        {
            using (IDbConnection conn = new SqlConnection(Settings.InventoryConnectionString))
            {
                var parameters = new DynamicParameters();

                parameters.Add("@Id", Id, DbType.Int32, ParameterDirection.Input);
                return conn.QueryFirst<IdName>(StoredProcedures.GETARTTYPES + " @Id", parameters);
            }
        }
        public List<IdName> GetArtTypes()
        {
            using (IDbConnection conn = new SqlConnection(Settings.InventoryConnectionString))
            {
                return conn.Query<IdName>(StoredProcedures.GETARTTYPES).ToList<IdName>();
            }
        }

        public IdName GetCategory()
        {
            IdName a = new IdName();

            return a;
        }
        public IdName GetCategory(int Id)
        {
            using (IDbConnection conn = new SqlConnection(Settings.InventoryConnectionString))
            {
                var parameters = new DynamicParameters();

                parameters.Add("@Id", Id, DbType.Int32, ParameterDirection.Input);
                return conn.QueryFirst<IdName>(StoredProcedures.GETCATEGORIES + " @Id", parameters);
            }
        }
        public List<IdName> GetCategories()
        {
            using (IDbConnection conn = new SqlConnection(Settings.InventoryConnectionString))
            {
                return conn.Query<IdName>(StoredProcedures.GETCATEGORIES).ToList<IdName>();
            }
        }

        public List<IdName> GetCities()
        {
            using (IDbConnection conn = new SqlConnection(Settings.InventoryConnectionString))
            {
                return conn.Query<IdName>(StoredProcedures.GETCITIES).ToList<IdName>();
            }
        }
        public IdName GetCity()
        {
            IdName a = new IdName();

            return a;
        }
        public IdName GetCity(int Id)
        {
            using (IDbConnection conn = new SqlConnection(Settings.InventoryConnectionString))
            {
                var parameters = new DynamicParameters();

                parameters.Add("@Id", Id, DbType.Int32, ParameterDirection.Input);
                return conn.QueryFirst<IdName>(StoredProcedures.GETCITIES + " @Id", parameters);
            }
        }

        public List<Company> GetCompanies()
        {
            using (IDbConnection conn = new SqlConnection(Settings.InventoryConnectionString))
            {
                return conn.Query<Company>(StoredProcedures.GETCOMPANIES).ToList<Company>();
            }
        }
        public Company GetCompany()
        {
            Company c = new Company();

            c.Cities = FillList(GetCities());
            c.States = FillList(GetStates());
            c.Countries = FillList(GetCountries());

            return c;
        }
        public Company GetCompany(int Id)
        {
            Company c = null;

            using (IDbConnection conn = new SqlConnection(Settings.InventoryConnectionString))
            {
                var parameters = new DynamicParameters();

                parameters.Add("@Id", Id, DbType.Int32, ParameterDirection.Input);
                c = conn.QueryFirst<Company>(StoredProcedures.GETCOMPANIES + " @Id", parameters);
            }

            c.Cities = FillList(GetCities(), c.CityId);
            c.States = FillList(GetStates(), c.StateId);
            c.Countries = FillList(GetCountries(), c.CountryId);

            return c;
        }

        public List<IdName> GetCountries()
        {
            using (IDbConnection conn = new SqlConnection(Settings.InventoryConnectionString))
            {
                return conn.Query<IdName>(StoredProcedures.GETCOUNTRIES).ToList<IdName>();
            }
        }
        public IdName GetCountry()
        {
            return new IdName();
        }
        public IdName GetCountry(int Id)
        {
            using (IDbConnection conn = new SqlConnection(Settings.InventoryConnectionString))
            {
                var parameters = new DynamicParameters();

                parameters.Add("@Id", Id, DbType.Int32, ParameterDirection.Input);
                return conn.QueryFirst<IdName>(StoredProcedures.GETCOUNTRIES + " @Id", parameters);
            }
        }

        public Item GetItem()
        {
            Item a = new Item();

            a.Categories = FillList(GetCategories());
            a.SubCategories = FillList(GetSubCategories());

            return a;
        }
        public Item GetItem(int Id)
        {
            Item a = null;

            using (IDbConnection conn = new SqlConnection(Settings.InventoryConnectionString))
            {
                var parameters = new DynamicParameters();

                parameters.Add("@Id", Id, DbType.Int32, ParameterDirection.Input);
                a = conn.QueryFirst<Item>(StoredProcedures.GETITEMS + " @Id", parameters);
            }

            a.Categories = FillList(GetCategories(), a.CategoryId);
            a.SubCategories = FillList(GetSubCategories(), a.SubCategoryId);

            return a;
        }
        public List<Item> GetItems()
        {
            using (IDbConnection conn = new SqlConnection(Settings.InventoryConnectionString))
            {
                return conn.Query<Item>(StoredProcedures.GETITEMS).ToList<Item>();
            }

        }

        public Manual GetManual()
        {
            Manual a = new Manual();

            a.Models = FillModels(GetModels());

            return a;
        }
        public Manual GetManual(int Id)
        {
            Manual a = new Manual();

            using (IDbConnection conn = new SqlConnection(Settings.InventoryConnectionString))
            {
                var parameters = new DynamicParameters();

                parameters.Add("@Id", Id, DbType.Int32, ParameterDirection.Input);
                a = conn.QueryFirst<Manual>(StoredProcedures.GETMANUALS + " @Id", parameters);
            }

            a.Models = FillModels(GetModels(), a.ModelId);

            return a;
        }
        public List<Manual> GetManuals()
        {
            using (IDbConnection conn = new SqlConnection(Settings.InventoryConnectionString))
            {
                return conn.Query<Manual>(StoredProcedures.GETMANUALS).ToList<Manual>();
            }

        }

        public Company GetMerchant()
        {
            Company c = new Company();

            c.Cities = FillList(GetCities());
            c.States = FillList(GetStates());
            c.Countries = FillList(GetCountries());

            return c;
        }
        public Company GetMerchant(int Id)
        {
            Company c = null;

            using (IDbConnection conn = new SqlConnection(Settings.InventoryConnectionString))
            {
                var parameters = new DynamicParameters();

                parameters.Add("@Id", Id, DbType.Int32, ParameterDirection.Input);
                c = conn.QueryFirst<Company>(StoredProcedures.GETMERCHANTS + " @Id", parameters);
            }

            c.Cities = FillList(GetCities(), c.CityId);
            c.States = FillList(GetStates(), c.StateId);
            c.Countries = FillList(GetCountries(), c.CountryId);

            return c;
        }
        public List<Company> GetMerchants()
        {
            using (IDbConnection conn = new SqlConnection(Settings.InventoryConnectionString))
            {
                return conn.Query<Company>(StoredProcedures.GETMERCHANTS).ToList<Company>();
            }
        }

        public Model GetModel()
        {
            Model a = new Model();

            a.Products = FillProducts(GetProducts());

            return a;
        }
        public Model GetModel(int Id)
        {
            Model a = null;

            using (IDbConnection conn = new SqlConnection(Settings.InventoryConnectionString))
            {
                var parameters = new DynamicParameters();

                parameters.Add("@Id", Id, DbType.Int32, ParameterDirection.Input);
                a = conn.QueryFirst<Model>(StoredProcedures.GETMODELS + " @Id", parameters);
            }

            a.Products = FillProducts(GetProducts(), a.ProductId);

            return a;
        }
        public List<Model> GetModels()
        {
            using (IDbConnection conn = new SqlConnection(Settings.InventoryConnectionString))
            {
                return conn.Query<Model>(StoredProcedures.GETMODELS).ToList<Model>();
            }

        }

        public Product GetProduct()
        {
            Product a = new Product();

            a.Companies = FillCompanies(GetCompanies());
            a.Merchants = FillCompanies(GetMerchants());
            a.Items = FillItems(GetItems());

            return a;
        }
        public Product GetProduct(int Id)
        {
            Product a = null;

            using (IDbConnection conn = new SqlConnection(Settings.InventoryConnectionString))
            {
                var parameters = new DynamicParameters();

                parameters.Add("@Id", Id, DbType.Int32, ParameterDirection.Input);
                a = conn.QueryFirst<Product>(StoredProcedures.GETPRODUCTS + " @Id", parameters);
            }

            a.Companies = FillCompanies(GetCompanies(), a.CompanyId);
            a.Merchants = FillCompanies(GetMerchants(), a.MerchantId);
            a.Items = FillItems(GetItems(), a.ItemId);

            return a;
        }
        public List<Product> GetProducts()
        {
            using (IDbConnection conn = new SqlConnection(Settings.InventoryConnectionString))
            {
                return conn.Query<Product>(StoredProcedures.GETPRODUCTS).ToList<Product>();
            }

        }

        public IdName GetState()
        {
            IdName a = new IdName();

            return a;
        }
        public IdName GetState(int Id)
        {
            using (IDbConnection conn = new SqlConnection(Settings.InventoryConnectionString))
            {
                var parameters = new DynamicParameters();

                parameters.Add("@Id", Id, DbType.Int32, ParameterDirection.Input);
                return conn.QueryFirst<IdName>(StoredProcedures.GETSTATES + " @Id", parameters);
            }
        }
        public List<IdName> GetStates()
        {
            using (IDbConnection conn = new SqlConnection(Settings.InventoryConnectionString))
            {
                return conn.Query<IdName>(StoredProcedures.GETSTATES).ToList<IdName>();
            }
        }

        public List<IdName> GetSubCategories()
        {
            using (IDbConnection conn = new SqlConnection(Settings.InventoryConnectionString))
            {
                return conn.Query<IdName>(StoredProcedures.GETSUBCATEGORIES).ToList<IdName>();
            }
        }
        public IdName GetSubCategory()
        {
            IdName a = new IdName();

            return a;
        }
        public IdName GetSubCategory(int Id)
        {
            using (IDbConnection conn = new SqlConnection(Settings.InventoryConnectionString))
            {
                var parameters = new DynamicParameters();

                parameters.Add("@Id", Id, DbType.Int32, ParameterDirection.Input);
                return conn.QueryFirst<IdName>(StoredProcedures.GETSUBCATEGORIES + " @Id", parameters);
            }
        }

#endregion

    }
}
