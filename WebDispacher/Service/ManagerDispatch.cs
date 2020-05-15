using BaceModel.ModelInspertionDriver;
using DaoModels.DAO.DTO;
using DaoModels.DAO.Enum;
using DaoModels.DAO.Models;
using DaoModels.DAO.Models.Settings;
using Google.Type;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WebDispacher.Dao;
using WebDispacher.Notify;
using WebDispacher.Service.EmailSmtp;
using Xamarin.Forms.Internals;

namespace WebDispacher.Service
{
    public class ManagerDispatch
    {
        public SqlCommadWebDispatch _sqlEntityFramworke = null;

        public ManagerDispatch()
        {
            _sqlEntityFramworke = new SqlCommadWebDispatch();
        }
        
        public async Task<List<Driver>> GetDrivers(string idCompany)
        {
            return await _sqlEntityFramworke.GetDriversInDb(idCompany);
        }

        //public async Task<List<Driver>> GetDrivers()
        //{
        //    return await _sqlEntityFramworke.GetDriversInDb();
        //}

        public void DeletedOrder(string id)
        {
            _sqlEntityFramworke.RecurentOnDeleted(id);
        }

        public void ArchvedOrder(string id)
        {
            _sqlEntityFramworke.RecurentOnArchived(id);
        }

        internal List<CompanyDTO> GetCompanies()
        {
            return _sqlEntityFramworke.GetCompanies()
                .Select(z => new CompanyDTO()
                {
                    Id = z.Id,
                    Active = z.Active,
                    Name = z.Name,
                    Type = z.Type == TypeCompany.BaseCommpany ? "Home Company" : z.Type == TypeCompany.NormalCompany ? "Regular company" : "Unknown",
                    DateRegistration = z.DateRegistration
                }).ToList();
        }

        internal List<ProfileSettings> GetSetingsTruck(string idCompany, int idProfile)
        {
            List<ProfileSettings> profileSettings = new List<ProfileSettings>();
            List<ProfileSetting> profileSettings1 = _sqlEntityFramworke.GetSetingsDb(idCompany, TypeTransportVehikle.Truck);
            profileSettings.Add(new ProfileSettings()
            {
                Name = "Standart",
                TypeTransportVehikle = "Truck",
                Id = 0,
                IsSelect = 0 == idProfile,
                IsUsed = profileSettings1.FirstOrDefault(p => p.IsUsed) == null,
                IdCompany = 0
            });
            if (profileSettings1.Count != 0)
            {
                profileSettings.AddRange(profileSettings1.Select(z => new ProfileSettings()
                { 
                    Id = z.Id,
                    IsChange = true,
                    IsSelect = z.Id == idProfile,
                    Name = z.Name,
                    TransportVehicles = z.TransportVehicles,
                    TypeTransportVehikle = z.TypeTransportVehikle,
                    IsUsed = z.IsUsed,
                    IdCompany = z.IdCompany
                }));
            }
            return profileSettings;
        }

        internal List<ProfileSettings> GetSetingsTrailer(string idCompany, int idProfile)
        {
            List<ProfileSettings> profileSettings = new List<ProfileSettings>();
            List<ProfileSetting> profileSettings1 = _sqlEntityFramworke.GetSetingsDb(idCompany, TypeTransportVehikle.Trailer);
            profileSettings.Add(new ProfileSettings()
            {
                Name = "Standart",
                TypeTransportVehikle = "Trailer",
                Id = 0,
                IsSelect = 0 == idProfile,
                IsUsed = profileSettings1.FirstOrDefault(p => p.IsUsed) == null,
                IdCompany = 0
            });
            if (profileSettings1.Count != 0)
            {
                profileSettings.AddRange(profileSettings1.Select(z => new ProfileSettings()
                {
                    Id = z.Id,
                    IsChange = true,
                    IsSelect = z.Id == idProfile,
                    Name = z.Name,
                    TransportVehicles = z.TransportVehicles,
                    TypeTransportVehikle = z.TypeTransportVehikle,
                    IsUsed = z.IsUsed,
                    IdCompany = z.IdCompany
                }));
            }
            return profileSettings;
        }

        internal ProfileSettings GetSelectSetingTruck(string idCompany, int idProfile)
        {
            ProfileSettings profileSetting = null;
            if(idProfile != 0)
            {
                ProfileSetting profileSetting1 = _sqlEntityFramworke.GetSelectSeting(idCompany, idProfile);
                if (profileSetting1 != null)
                {
                    profileSetting = new ProfileSettings()
                    {
                        Id = profileSetting1.Id,
                        IsChange = true,
                        IsSelect = idProfile == profileSetting1.Id,
                        Name = profileSetting1.Name,
                        TransportVehicles = profileSetting1.TransportVehicles,
                        TypeTransportVehikle = profileSetting1.TypeTransportVehikle,
                        IsUsed = profileSetting1.IsUsed,
                        IdCompany = profileSetting1.IdCompany
                    };
                }
            }
            else
            {
                profileSetting = new ProfileSettings()
                {
                    Id = 0,
                    Name = "Standart",
                    TransportVehicles = new StandartProfileSettings(TypeTransportVehikle.Truck).TransportVehicles,
                    TypeTransportVehikle = "Truck",
                    IsChange = false,
                    IsUsed = true,
                    IdCompany = 0
                };
            }
            profileSetting.TransportVehicles.ForEach((TransportVehicle) =>
            {
                TransportVehicle.Layouts = TransportVehicle.Layouts.OrderBy(l => l.OrdinalIndex).ToList();
            });
            return profileSetting;
        }

        internal void SelectLayout(int idLayout)
        {
            _sqlEntityFramworke.SelectLayout(idLayout);
        }

        internal void RemoveProfile(string idCompany, int idProfile)
        {
            _sqlEntityFramworke.RemoveProfiledb(idCompany, idProfile);
        }

        internal int AddProfile(string idCompany, TypeTransportVehikle typeTransportVehikle)
        {
            ProfileSetting profileSetting = new ProfileSetting()
            {
                TransportVehicles = new StandartProfileSettings(typeTransportVehikle).TransportVehicles,
                IdCompany = Convert.ToInt32(idCompany),
                Name = "Custom",
                TypeTransportVehikle = typeTransportVehikle.ToString(),
            };
            return _sqlEntityFramworke.AddProfileDb(profileSetting);
        }

        internal ProfileSettings GetSelectSetingTrailer(string idCompany, int idProfile)
        {
            ProfileSettings profileSetting = null;
            if (idProfile != 0)
            {
                ProfileSetting profileSetting1 = _sqlEntityFramworke.GetSelectSeting(idCompany, idProfile);
                if (profileSetting1 != null)
                {
                    profileSetting = new ProfileSettings()
                    {
                        Id = profileSetting1.Id,
                        IsChange = true,
                        IsSelect = idProfile == profileSetting1.Id,
                        Name = profileSetting1.Name,
                        TransportVehicles = profileSetting1.TransportVehicles,
                        TypeTransportVehikle = profileSetting1.TypeTransportVehikle,
                        IsUsed = profileSetting1.IsUsed,
                        IdCompany = profileSetting1.IdCompany
                    };
                }
            }
            else
            {
                profileSetting = new ProfileSettings()
                {
                    Id = 0,
                    Name = "Standart",
                    TransportVehicles = new StandartProfileSettings(TypeTransportVehikle.Trailer).TransportVehicles,
                    TypeTransportVehikle = "Trailer",
                    IsChange = false,
                    IsUsed = true,
                    IdCompany = 0
                };
            }
            profileSetting.TransportVehicles.ForEach((TransportVehicle) =>
            {
                TransportVehicle.Layouts = TransportVehicle.Layouts.OrderBy(l => l.OrdinalIndex).ToList();
            });
            return profileSetting;
        }

        internal void LayoutUP(int idLayout, int idTransported)
        {
            _sqlEntityFramworke.LayoutUPDb(idLayout, idTransported);
        }

        internal void UnSelectLayout(int idLayout)
        {
            _sqlEntityFramworke.UnSelectLayout(idLayout);
        }

        internal bool IsPermission(string key, string idCompany, string route)
        {
            bool isPermission = false;
            Users users = _sqlEntityFramworke.GetUserByKey(key);
            Commpany commpany = _sqlEntityFramworke.GetCompanyById(idCompany);
            if(users != null && commpany != null)
            {
                isPermission = ValidCompanyRoute(commpany.Type, route);
            }
            return isPermission;
        }

        internal string GetTypeNavBar(string key, string idCompany)
        {
            string typeNavBar = "";
            Users users = _sqlEntityFramworke.GetUserByKey(key);
            Commpany commpany = _sqlEntityFramworke.GetCompanyById(idCompany);
            if (users != null && commpany != null)
            {
                if (commpany.Type == TypeCompany.BaseCommpany)
                {
                    typeNavBar = "BaseCommpany";
                }
                else if (commpany.Type == TypeCompany.NormalCompany)
                {
                    typeNavBar = "NormaCommpany";
                }
            }
            return typeNavBar;
        }

        internal void LayoutDown(int idLayout, int idTransported)
        {
            _sqlEntityFramworke.LayoutDownDb(idLayout, idTransported);
        }

        private bool ValidCompanyRoute(TypeCompany typeCompany, string route)
        {
            bool validCompany = false;
            if(route == "Company")
            {
                if (typeCompany == TypeCompany.BaseCommpany)
                {
                    validCompany = true;
                }
            }
            else
            {
                validCompany = true;
            }
            return validCompany;
        }

        internal async Task AddNewOrder(string urlPage)
        {
            GetDataCentralDispatch getDataCentralDispatch = new GetDataCentralDispatch();
            Shipping shipping = await getDataCentralDispatch.GetShipping(urlPage);
            _sqlEntityFramworke.AddOrder(shipping);
        }

        public List<Truck> GetTrucks(string idCompany)
        {
            return _sqlEntityFramworke.GetTrucs(idCompany);
        }

        public List<Contact> GetContacts(string idCompany)
        {
            return _sqlEntityFramworke.GetContactsDB(idCompany);
        }

        internal int[] GetIdTruckAdnTrailar(string idDriver)
        {
            return _sqlEntityFramworke.GetIdTruckAdnTrailarDb(idDriver);
        }

        internal async Task<Trailer> GetTrailer(string idDriver)
        {
            return await _sqlEntityFramworke.GetTrailerDb(idDriver);
        }

        internal Commpany GetUserByKeyUser(int key)
        {
            return _sqlEntityFramworke.GetUserByKeyUser(key);
        }

        internal void AddUser(string idCompany, string login, string password)
        {
            Users users = new Users()
            {
                CompanyId = Convert.ToInt32(idCompany),
                Date = DateTime.Now.ToString(),
                Login = login,
                Password = password
            };
            _sqlEntityFramworke.AddUserDb(users);
        }

        internal int GetUserByKey(int key)
        {
            return _sqlEntityFramworke.GetComapnyIdByKeyUser(key);
        }

        internal async Task<Truck> GetTruck(string idDriver)
        {
            return await _sqlEntityFramworke.GetTruckDb(idDriver);
        }

        public async void SaveVechi(string idVech, string VIN, string Year, string Make, string Model, string Type, string Color, string LotNumber)
        {
            VehiclwInformation vehiclwInformation = new VehiclwInformation();
            vehiclwInformation.VIN = VIN;
            vehiclwInformation.Year = Year;
            vehiclwInformation.Make = Make;
            vehiclwInformation.Model = Model;
            vehiclwInformation.Type = Type;
            vehiclwInformation.Color = Color;
            vehiclwInformation.Lot = LotNumber;
            _sqlEntityFramworke.SavevechInDb(idVech, vehiclwInformation);
        }

        internal void AddCommpany(string nameCommpany, IFormFile MCNumberConfirmation, IFormFile IFTA, IFormFile KYU, IFormFile logbookPapers, IFormFile COI, IFormFile permits)
        {
            Commpany commpany = new Commpany()
            {
                Active = true,
                DateRegistration = DateTime.Now.ToString(),
                Name = nameCommpany,
                Type = TypeCompany.NormalCompany
            };
            int id = _sqlEntityFramworke.AddCommpany(commpany);
            _sqlEntityFramworke.CreateUserForCompanyId(id, nameCommpany, CreateToken(nameCommpany, new Random().Next(10, 1000).ToString()));
            SaveDocCpmmpany(MCNumberConfirmation, "MC number confirmation", id.ToString());
            SaveDocCpmmpany(IFTA, "IFTA (optional for 26000+)", id.ToString());
            SaveDocCpmmpany(KYU, "KYU", id.ToString());
            SaveDocCpmmpany(logbookPapers, "Logbook Papers (manual, certificate, malfunction letter)", id.ToString());
            SaveDocCpmmpany(COI, "COI (certificate of insurance)", id.ToString());
            SaveDocCpmmpany(permits, "Permits (optional OR, FL, NM)", id.ToString());

        }

        internal void RemoveUserById(string idUser)
        {
            _sqlEntityFramworke.RemoveUserByIdDb(idUser);
        }

        internal void RemoveCompany(string idCompany)
        {
            _sqlEntityFramworke.RemoveCompanyDb(idCompany);
            Task.Run(() =>
            {
                List<Driver> drivers = _sqlEntityFramworke.GetDriversByIdCompany(idCompany);
                foreach(Driver driver in drivers)
                {
                    RemoveDrive(driver.Id, "The site administration deleted the company in which this driver worked");
                }
            });
        }

        private string CreateToken(string login, string password)
        {
            string token = "";
            for (int i = 0; i < login.Length; i++)
            {
                token += i * new Random().Next(1, 1000) + login[i];
            }
            for (int i = 0; i < password.Length; i++)
            {
                token += i * new Random().Next(1, 1000) + password[i];
            }
            return token;
        }

        internal async Task<Truck> GetTruckByPlate(string truckPlate)
        {
            return await _sqlEntityFramworke.GetTruckByPlateDb(truckPlate);
        }

        internal int CheckTokenFoDriver(string idDriver, string token)
        {
            return _sqlEntityFramworke.CheckTokenFoDriverDb(idDriver, token);
        }

        internal async Task<int> ResetPasswordFoDriver(string newPassword, string idDriver, string token)
        {
            int isStateActual = _sqlEntityFramworke.ResetPasswordFoDriver(newPassword, idDriver, token);
            if(isStateActual == 2)
            {
                string emailDriver = _sqlEntityFramworke.GetEmailDriverDb(idDriver);
                string patern = new PaternSourse().GetPaternDataAccountDriver(emailDriver, newPassword);
                await new AuthMessageSender().Execute(emailDriver, "Password changed successfully", patern);
            }
            else
            {
                string emailDriver = _sqlEntityFramworke.GetEmailDriverDb(idDriver);
                string patern = new PaternSourse().GetPaternNoRestoreDataAccountDriver();
                await new AuthMessageSender().Execute(emailDriver, "Password reset attempt failed", patern);
            }
            return isStateActual;
        }

        internal void AddHistory(string key, string idConmpany, string idOrder, string idVech, string idDriver, string action)
        {
            HistoryOrder historyOrder = new HistoryOrder();
            int idUser = _sqlEntityFramworke.GetUserIdByKey(key);
            if(action == "Assign")
            {
                historyOrder.TypeAction = "Assign";
            }
            else if(action == "Unassign")
            {
                idDriver = _sqlEntityFramworke.GetDriverIdByIdOrder(idOrder);
                historyOrder.TypeAction = "Unassign";
            }
            else if (action == "Solved")
            {
                historyOrder.TypeAction = "Solved";
            }
            else if (action == "ArchivedOrder")
            {
                historyOrder.TypeAction = "ArchivedOrder";
            }
            else if (action == "DeletedOrder")
            {
                historyOrder.TypeAction = "DeletedOrder";
            }
            else if (action == "Creat")
            {
                historyOrder.TypeAction = "Creat";
            }
            else if (action == "SavaOrder")
            {
                historyOrder.TypeAction = "SavaOrder";
            }
            else if (action == "SavaVech")
            {
                idOrder = _sqlEntityFramworke.GetIdOrderByIdVech(idVech);
                historyOrder.TypeAction = "SavaVech";
            }
            else if (action == "RemoveVech")
            {
                idOrder = _sqlEntityFramworke.GetIdOrderByIdVech(idVech);
                historyOrder.TypeAction = "RemoveVech";
            }
            else if (action == "AddVech")
            {
                historyOrder.TypeAction = "AddVech";
            }

            historyOrder.IdConmpany = Convert.ToInt32(idConmpany);
            historyOrder.IdDriver = Convert.ToInt32(idDriver);
            historyOrder.IdOreder = Convert.ToInt32(idOrder);
            historyOrder.IdVech = Convert.ToInt32(idVech);
            historyOrder.IdUser = idUser;
            historyOrder.DateAction = DateTime.Now.ToString();
            _sqlEntityFramworke.AddHistory(historyOrder);
        }

        internal List<UserDTO> GetUsers()
        {
            List<Commpany> commpanies = _sqlEntityFramworke.GetCompanies();
            return _sqlEntityFramworke.GetUsers()
                .Select(z => new UserDTO()
                {
                    CompanyName = commpanies.FirstOrDefault(c => c.Id == z.CompanyId) != null ? commpanies.FirstOrDefault(c => c.Id == z.CompanyId).Name : "", 
                    Id = z.Id,
                    Login = z.Login,
                    Password = z.Password,
                    CompanyId = z.CompanyId,
                    Date = z.Date
                })
                .ToList();
        }

        internal List<UserDTO> GetUsers(int idCompanySelect)
        {
            List<Commpany> commpanies = _sqlEntityFramworke.GetCompanies();
            return _sqlEntityFramworke.GetUsers()
                .Where(u => idCompanySelect == 0 || u.CompanyId == idCompanySelect)
                .Select(z => new UserDTO()
                {
                    CompanyName = commpanies.FirstOrDefault(c => c.Id == z.CompanyId) != null ? commpanies.FirstOrDefault(c => c.Id == z.CompanyId).Name : "",
                    Id = z.Id,
                    Login = z.Login,
                    Password = z.Password,
                    CompanyId = z.CompanyId,
                    Date = z.Date
                })
                .ToList();
        }

        public string GetStrAction(string key, string idConmpany, string idOrder, string idVech, string idDriver, string action)
        {
            string strAction = "";
            //int idUser = _sqlEntityFramworke.GetUserIdByKey(key);
            if (action == "Assign")
            {
                string fullNameUser = _sqlEntityFramworke.GetFullNameUserByKey(key);
                string fullNameDriver = _sqlEntityFramworke.GetFullNameDriverById(idDriver);
                strAction = $"{fullNameUser} assign the driver ordered {fullNameDriver}";
            }
            else if (action == "Unassign")
            {
                string fullNameUser = _sqlEntityFramworke.GetFullNameUserByKey(key);
                string fullNameDriver = _sqlEntityFramworke.GetFullNameDriverById(idDriver);
                strAction = $"{fullNameUser} withdrew an order from {fullNameDriver} driver";
            }
            else if (action == "Solved")
            {
                string fullNameUser = _sqlEntityFramworke.GetFullNameUserByKey(key);
                strAction = $"{fullNameUser} clicked on the \"Solved\" button";
            }
            else if (action == "ArchivedOrder")
            {
                string fullNameUser = _sqlEntityFramworke.GetFullNameUserByKey(key);
                strAction = $"{fullNameUser} transferred the order to the archive";
            }
            else if (action == "DeletedOrder")
            {
                string fullNameUser = _sqlEntityFramworke.GetFullNameUserByKey(key);
                strAction = $"{fullNameUser} transferred the order to deleted orders";
            }
            else if (action == "Creat")
            {
                string fullNameUser = _sqlEntityFramworke.GetFullNameUserByKey(key);
                strAction = $"{fullNameUser} created an order";
            }
            else if (action == "SavaOrder")
            {
                string fullNameUser = _sqlEntityFramworke.GetFullNameUserByKey(key);
                strAction = $"{fullNameUser} edited the order";
            }
            else if (action == "SavaVech")
            {
                string fullNameUser = _sqlEntityFramworke.GetFullNameUserByKey(key);
                VehiclwInformation vehiclwInformation = _sqlEntityFramworke.GetVechById(idVech);
                strAction = $"{fullNameUser} edited the vehicle {vehiclwInformation.Year} y. {vehiclwInformation.Make} {vehiclwInformation.Model}";
            }
            else if (action == "RemoveVech")
            {
                string fullNameUser = _sqlEntityFramworke.GetFullNameUserByKey(key);
                VehiclwInformation vehiclwInformation = _sqlEntityFramworke.GetVechById(idVech);
                strAction = $"{fullNameUser} removed the vehicle {vehiclwInformation.Year} y. {vehiclwInformation.Make} {vehiclwInformation.Make}";
            }
            else if (action == "AddVech")
            {
                string fullNameUser = _sqlEntityFramworke.GetFullNameUserByKey(key);
                strAction = $"{fullNameUser} created a vehicle";
            }
            return strAction;
        }

        internal int CheckReportDriver(string fullName, string driversLicenseNumber)
        {
            return _sqlEntityFramworke.CheckReportDriverDb(fullName, driversLicenseNumber);
        }

        internal async Task<Trailer> GetTrailerkByPlate(string trailerPlate)
        {
            return await _sqlEntityFramworke.GetTrailerByPlateDb(trailerPlate);
        }

        internal List<DriverReport> GetDriversReport(string nameDriver, string driversLicense)
        {
            return _sqlEntityFramworke.GetDriversReportsDb(nameDriver, driversLicense);
        }

        internal void AddNewReportDriver(string fullName, string driversLicenseNumber, string description)
        {
            _sqlEntityFramworke.AddNewReportDriverDb(fullName, driversLicenseNumber, description);
        }

        internal List<Trailer> GetTrailers(string idCompany)
        {
            return _sqlEntityFramworke.GetTrailersDb(idCompany);
        }

        internal void RemoveTruck(string id)
        {
            _sqlEntityFramworke.RemoveTruck(id);
        }

        public async void RemoveVechi(string idVech)
        {
            _sqlEntityFramworke.RemoveVechInDb(idVech);
        }

        public async Task<VehiclwInformation> AddVechi(string idOrder)
        {
            return await _sqlEntityFramworke.AddVechInDb(idOrder);
        }

        public async Task<Shipping> CreateShiping()
        {
            return await _sqlEntityFramworke.CreateShipping();
        }

        public Shipping GetShipingCurrentVehiclwIn(string id)
        {
            return _sqlEntityFramworke.GetShipingCurrentVehiclwInDb(id);
        }

        public bool Avthorization(string login, string password)
        {
            return _sqlEntityFramworke.ExistsDataUser(login, password);
        }

        public bool CheckKey(string key)
        {
            return key != null && _sqlEntityFramworke.CheckKeyDb(key);
        }

        public List<Driver> GetDrivers(int pag, string idCompany)
        {
            return _sqlEntityFramworke.GetDrivers(pag, idCompany);
        }

        public async void Assign(string idOrder, string idDriver)
        {
            bool isDriverAssign = _sqlEntityFramworke.CheckDriverOnShipping(idOrder);
            string tokenShope = null;
            if (isDriverAssign)
            {
                tokenShope = _sqlEntityFramworke.GerShopTokenForShipping(idOrder);
            }
            List<VehiclwInformation> vehiclwInformations = await _sqlEntityFramworke.AddDriversInOrder(idOrder, idDriver);
             Task.Run(() =>
            {
                ManagerNotifyWeb managerNotify = new ManagerNotifyWeb();
                string tokenShope1 = _sqlEntityFramworke.GerShopTokenForShipping(idOrder);
                if (!isDriverAssign)
                {
                    managerNotify.SendNotyfyAssign(idOrder, tokenShope1, vehiclwInformations);
                }
                else
                {
                    managerNotify.SendNotyfyAssign(idOrder, tokenShope1, vehiclwInformations);
                    managerNotify.SendNotyfyUnassign(idOrder, tokenShope, vehiclwInformations);
                }
            });
        }

        public async void CreateTruk(string nameTruk, string yera, string make, string model, string typeTruk, string state, string exp, string vin, string owner, string plateTruk, 
            string color, string idCompany, IFormFile registrationDoc, IFormFile ensuresDoc, IFormFile _3Doc)
        {
            int id = _sqlEntityFramworke.CreateTrukDb(nameTruk, yera, make, model, typeTruk, state, exp, vin, owner, plateTruk, color, idCompany);
                 SaveDocTruck(registrationDoc, "Registration", id.ToString());
                 SaveDocTruck(ensuresDoc, "Inshurance", id.ToString());
                 SaveDocTruck(_3Doc, "3", id.ToString());
          
        }

        public void CreateContact(string fullName, string emailAddress, string phoneNumbe, string idCompany)
        {
            Contact contact = new Contact();
            contact.Email = emailAddress;
            contact.Name = fullName;
            contact.Phone = phoneNumbe;
            contact.Phone = phoneNumbe;
            contact.CompanyId = Convert.ToInt32(idCompany);
            _sqlEntityFramworke.SaveNewContact(contact);
        }

        public async void Unassign(string idOrder)
        {
            ManagerNotifyWeb managerNotify = new ManagerNotifyWeb();
            string tokenShope = _sqlEntityFramworke.GerShopTokenForShipping(idOrder);
            List<VehiclwInformation> vehiclwInformations = await _sqlEntityFramworke.RemoveDriversInOrder(idOrder);
            Task.Run(() =>
            {
                managerNotify.SendNotyfyUnassign(idOrder, tokenShope, vehiclwInformations);
            });
        }

        public void Solved(string idOrder)
        {
            _sqlEntityFramworke.Solved(idOrder);
        }

        //public Shipping GetDriver()
        //{
        //    return _sqlEntityFramworke.GetShipping(id);
        //}

        public int Createkey(string login, string password)
        {
            Random random = new Random();
            int key = random.Next(1000, 1000000000);
            _sqlEntityFramworke.SaveKeyDatabays(login, password, key);
            return key;
        }

        internal void RestoreDrive(int id)
        {
            _sqlEntityFramworke.RestoreDriveInDb(id);
        }

        public async Task<int> GetCountPage(string status)
        {
            return await _sqlEntityFramworke.GetCountPageInDb(status);
        }

        internal void RemoveTrailer(string id)
        {
            _sqlEntityFramworke.RemoveTrailerDb(id);
        }

        public async Task<List<Shipping>> GetOrders(string status, int page)
        {
            return await _sqlEntityFramworke.GetShippings(status, page);
        }

        public Shipping GetOrder(string id)
        {
            return _sqlEntityFramworke.GetShipping(id);
        }

        public Driver GetDriver(int id)
        {
            return _sqlEntityFramworke.GetDriver(id);
        }

        public Driver GetDriver(string idInspection)
        {
            return _sqlEntityFramworke.GetDriver(idInspection);
        }


        public void Updateorder(string idOrder, string idLoad, string internalLoadID, string driver, string status, string instructions, string nameP, string contactP,
            string addressP, string cityP, string stateP, string zipP, string phoneP, string emailP, string scheduledPickupDateP, string nameD, string contactD, string addressD,
            string cityD, string stateD, string zipD, string phoneD, string emailD, string ScheduledPickupDateD, string paymentMethod, string price, string paymentTerms, string brokerFee)
        {
            _sqlEntityFramworke.UpdateorderInDb(idOrder, idLoad, internalLoadID, driver, status, instructions, nameP, contactP, addressP, cityP, stateP, zipP,
                        phoneP, emailP, scheduledPickupDateP, nameD, contactD, addressD, cityD, stateD, zipD, phoneD, emailD, ScheduledPickupDateD, paymentMethod,
                        price, paymentTerms, brokerFee);
        }

        public void CreateOrder(string idOrder, string idLoad, string internalLoadID, string driver, string status, string instructions, string nameP, string contactP,
            string addressP, string cityP, string stateP, string zipP, string phoneP, string emailP, string scheduledPickupDateP, string nameD, string contactD, string addressD,
            string cityD, string stateD, string zipD, string phoneD, string emailD, string ScheduledPickupDateD, string paymentMethod, string price, string paymentTerms, string brokerFee)
        {
            _sqlEntityFramworke.UpdateorderInDb(idOrder, idLoad, internalLoadID, driver, status, instructions, nameP, contactP, addressP, cityP, stateP, zipP,
                        phoneP, emailP, scheduledPickupDateP, nameD, contactD, addressD, cityD, stateD, zipD, phoneD, emailD, ScheduledPickupDateD, paymentMethod,
                        price, paymentTerms, brokerFee);
        }

        internal  void CreateTrailer(string name, string typeTrailer, string year, string make, string howLong, string vin, string owner, string color, string plate, string exp, string annualIns,
           string idCompany, IFormFile registrationDoc, IFormFile ensuresDoc, IFormFile _3Doc)
        {
            int id = _sqlEntityFramworke.CreateTrailerDb(name, typeTrailer, year, make, howLong, vin, owner, color, plate, exp, annualIns, idCompany);
            SaveDocTrailer(registrationDoc, "Registration", id.ToString());
            SaveDocTrailer(ensuresDoc, "Inshurance", id.ToString());
            SaveDocTrailer(_3Doc, "3", id.ToString());
        }

        public void CreateDriver(string fullName, string emailAddress, string password, string phoneNumbe, string trailerCapacity, string driversLicenseNumber, string idCompany)
        {
            Driver driver = new Driver();
            driver.FullName = fullName;
            driver.EmailAddress = emailAddress;
            driver.Password = password;
            driver.PhoneNumber = phoneNumbe;
            driver.TrailerCapacity = trailerCapacity;
            driver.DriversLicenseNumber = driversLicenseNumber;
            driver.DateRegistration = DateTime.Now.ToString();
            driver.CompanyId = Convert.ToInt32(idCompany);
            _sqlEntityFramworke.AddDriver(driver);
        }

        internal void SavePath(string id, string path)
        {
            _sqlEntityFramworke.SavePathDb(id, path);
        }

        public List<InspectionDriver> GetInspectionTrucks(string idDriver, string idTruck, string idTrailer, string date)
        {
            return _sqlEntityFramworke.GetInspectionTrucksDb(idDriver, idTruck, idTrailer, date);
        }

        public void RemoveDrive(int id, string comment)
        {
            _sqlEntityFramworke.RemoveDriveInDb(id, comment);
        }

        internal async Task<string> GetDocument(string id)
        {
            return _sqlEntityFramworke.GetDocumentDb(id);
        }

        public void EditDrive(int id, string fullName, string emailAddress, string password, string phoneNumbe, string trailerCapacity, string driversLicenseNumber)
        {
            Driver driver = new Driver();
            driver.Id = id;
            driver.FullName = fullName;
            driver.EmailAddress = emailAddress;
            driver.Password = password;
            driver.PhoneNumber = phoneNumbe;
            driver.TrailerCapacity = trailerCapacity;
            driver.DriversLicenseNumber = driversLicenseNumber;
            _sqlEntityFramworke.UpdateDriver(driver);
        }

        public async Task<List<DocumentTruckAndTrailers>> GetTruckDoc(string id)
        {
            return await _sqlEntityFramworke.GetTruckDocDB(id);
        }

        public async Task<List<DucumentCompany>> GetCompanyDoc(string id)
        {
            return await _sqlEntityFramworke.GetCompanyDocDB(id);
        }

        public InspectionDriver GetInspectionTruck(string idInspection)
        {
            return _sqlEntityFramworke.GetInspectionTruck(idInspection);
        }

        internal void SaveDocTruck(IFormFile uploadedFile, string nameDoc, string id)
        {
            string path = $"../Document/Truck/{id}/" + uploadedFile.FileName;
            if(!Directory.Exists("../Document/Truck"))
            {
                Directory.CreateDirectory($"../Document/Truck");
            }
            if (!Directory.Exists($"../Document/Truck/{id}"))
            {
                Directory.CreateDirectory($"../Document/Truck/{id}");
            }
            using (var fileStream = new FileStream(path, FileMode.Create))
            {
                uploadedFile.CopyTo(fileStream);
            }
            _sqlEntityFramworke.SaveDocTruckDb(path, id, nameDoc);
        }

        internal void SaveDocTrailer(IFormFile uploadedFile, string nameDoc, string id)
        {
            string path = $"../Document/Traile/{id}/" + uploadedFile.FileName;
            if (!Directory.Exists("../Document/Traile"))
            {
                Directory.CreateDirectory($"../Document/Traile");
            }
            if (!Directory.Exists($"../Document/Traile/{id}"))
            {
                Directory.CreateDirectory($"../Document/Traile/{id}");
            }
            using (var fileStream = new FileStream(path, FileMode.Create))
            {
                uploadedFile.CopyTo(fileStream);
            }
            _sqlEntityFramworke.SaveDocTrailekDb(path, id, nameDoc);
        }

        internal  void SaveDocCpmmpany(IFormFile uploadedFile, string nameDoc, string id)
        {
            string path = $"../Document/Copmpany/{id}/" + uploadedFile.FileName;
            if (!Directory.Exists("../Document/Copmpany"))
            {
                Directory.CreateDirectory($"../Document/Copmpany");
            }
            if (!Directory.Exists($"../Document/Copmpany/{id}"))
            {
                Directory.CreateDirectory($"../Document/Copmpany/{id}");
            }
            using (var fileStream = new FileStream(path, FileMode.Create))
            {
                uploadedFile.CopyTo(fileStream);
            }
            _sqlEntityFramworke.SaveDocCommpanyDb(path, id, nameDoc);
        }

        internal async Task<List<DocumentTruckAndTrailers>> GetTraileDoc(string id)
        {
            return await _sqlEntityFramworke.GetTrailerDocDB(id);
        }

        internal void RemoveDoc(string idDock)
        {
            _sqlEntityFramworke.RemoveDocDb(idDock);
        }

        internal void RemoveDocCompany(string idDock)
        {
            _sqlEntityFramworke.RemoveDocCompanyDb(idDock);
        }

        internal bool SendRemindInspection(int idDriver)
        {
            ManagerNotifyWeb managerNotifyWeb = new ManagerNotifyWeb();
            bool isInspactionDriverToDay = _sqlEntityFramworke.CheckInspactionDriverToDay(idDriver);
            if (!isInspactionDriverToDay)
            {
                string tokenShiping = _sqlEntityFramworke.GerShopToken(idDriver.ToString());
                managerNotifyWeb.SendSendNotyfyRemindInspection(tokenShiping);
            }
            return isInspactionDriverToDay;
        }

        internal List<HistoryOrder> GetHistoryOrder(string idOrder)
        {
            return _sqlEntityFramworke.GetHistoryOrderByIdOrder(idOrder);
        }
    }
}