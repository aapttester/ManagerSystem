using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ManagerSystem.Models.DBModels
{
    public partial class DBManagerReposity
    {
        private ManagerSystemDataContext managerSystemDataContext = new ManagerSystemDataContext();

        #region Login Operations
        public bool Login(LoginModel loginModel)
        {
            IQueryable<Manager> managerQuery = managerSystemDataContext.Managers.Where(manager => manager.Name.Equals(loginModel.UserName) && manager.Password.Equals(loginModel.Password));
            if (managerQuery.Count() == 1)
            {
                return true;
            }
            else
            { return false; }
        }
        #endregion

        #region Manage Account
        public Manager GetManager(int managerId)
        {
            Manager managered = managerSystemDataContext.Managers.Where(manager => manager.ManagerId == managerId).SingleOrDefault();
            if (managered != null)
            {
                return managered;
            }
            throw new Exception(string.Format("The Manager with ID: {0} doesn't exist or has been deleted.", managered));
        }

        public IQueryable<Manager> GetAllManagers()
        {
            return from manager in managerSystemDataContext.Managers
                   select manager;
        }

        public void AddNewManager(Manager manager)
        {
            managerSystemDataContext.Managers.InsertOnSubmit(manager);
        }

        public void DeleteManager(Manager manager)
        {
            managerSystemDataContext.Managers.DeleteOnSubmit(manager);
        }

        public void Save()
        {
            managerSystemDataContext.SubmitChanges();
        }
        #endregion
    }
}