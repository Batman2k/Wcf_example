using System.Collections.Generic;
using WcfExample.DataAcessLayer;
using WcfExample.Models;

namespace WcfExample
{
    public class Client : IClient
    {
        private readonly EntityDal _entityDal;

        public Client()
        {
            _entityDal = new EntityDal();
        }

        public IEnumerable<User> ReturnAllCleanersByCity(string city)
        {
            return _entityDal.GetAllCleanersByCity(city);
        }

        public User CreateUser(User user)
        {
            return _entityDal.CreateUser(user);
        }

        public User GetUserData(string userName, string userPassword)
        {
            return _entityDal.GetUserData(userName, userPassword);
        }

        public void UpdateUserData(User changesToUser, string userName, string userPassword)
        {
            _entityDal.UpdateUserData(changesToUser, userName, userPassword);
        }

        public void CreateJob(Job job)
        {
            _entityDal.CreateJob(job);
        }

        public void ChangeJob(Job changedJob, string jobId)
        {
            _entityDal.UpdateJob(changedJob, jobId);
        }

        public void DeleteCompany(string companyId)
        {
            _entityDal.DeleteCompany(companyId);
        }

        public void DeleteJob(string jobId)
        {
            _entityDal.DeleteJob(jobId);
        }

        public void DeleteUser(string userId)
        {
            _entityDal.DeleteUser(userId);
        }

        public IEnumerable<User> GetAllCleaners()
        {
            return _entityDal.GetAllCleaners();
        }

        public IEnumerable<Company> GetAllCompanies()
        {
            return _entityDal.GetAllCompanies();
        }

        public IEnumerable<User> GetAllCustomers()
        {
            return _entityDal.GetAllCustomers();
        }

        public IEnumerable<Job> GetALlJobs(string cleanerId)
        {
            return _entityDal.GetAllJobsForCleaner(cleanerId);
        }

        public void GetCompanyDataByName(string companyName)
        {
            _entityDal.GetCompanyData(companyName);
        }
    }
}