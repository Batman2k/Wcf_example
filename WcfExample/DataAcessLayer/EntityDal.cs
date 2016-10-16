using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using WcfExample.Enums;
using WcfExample.Models;

namespace WcfExample.DataAcessLayer
{
    public class EntityDal 
    {
        private readonly ApplicationDbContext _context;

        public EntityDal()
        {
            _context = new ApplicationDbContext();
        }
        
        public IEnumerable<User> GetAllCleanersByCity(string city)
        {
            return
                _context
                    .Users
                    .Include(u => u.ContactInformation)
                    .Where(u => u.AccountType == AccountType.Cleaner)
                    .Where(c => c.ContactInformation.City.Contains(city));
        }

        public IEnumerable<User> GetAllCleaners()
        {
            return
                _context
                    .Users
                    .Include(u => u.ContactInformation)
                    .Where(u => u.AccountType == AccountType.Cleaner);
        }

        public IEnumerable<User> GetAllCustomers()
        {
            return
                _context
                    .Users
                    .Include(u => u.ContactInformation)
                    .Where(u => u.AccountType == AccountType.Customer);
        }

        public User CreateUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();

            return user;
        }

        public void DeleteUser(string userId)
        {
            var deletedUser = _context
                .Users
                .FirstOrDefault(u => u.Id + "" == userId);

            deletedUser?.DeleteUser();

            _context.SaveChanges();
        }

        public User GetUserData(string userName, string password)
        {
            return _context
                .Users
                .FirstOrDefault(u => u.UserName == userName && u.Password == password);
        }

        public User UpdateUserData(User user, string userName, string password)
        {
            var uppdatedUser = _context
                .Users
                .FirstOrDefault(u => u.UserName == userName && u.Password == password);

            //update more in the user?
            if (uppdatedUser != null)
            {
                uppdatedUser.UserName = user.UserName;
                uppdatedUser.Password = user.Password;

                _context.SaveChanges();
            }

            return user;
        }

        public Company GetCompanyData(string companyName)
        {
            return _context
                .Companies
                .FirstOrDefault(c => c.Name.Contains(companyName));
        }

        public void DeleteCompany(string companyId)
        {
            var deletedCompany = _context
                .Companies
                .FirstOrDefault(c => c.Id + "" == companyId);

            deletedCompany?.DeleteCompany();

             _context.SaveChanges();
        }

        public IEnumerable<Company> GetAllCompanies()
        {
            return
                _context.Companies.ToList();
        }



        public Job CreateJob(Job job)
        {
            job.Created = DateTime.Now;

            _context.Jobs.Add(job);
            //_context.SaveChanges();

            return job;
        }

        //update what to the job?
        public Job UpdateJob(Job job, string jobId)
        {
            var updatedJob = _context
                .Jobs
                .FirstOrDefault(j => j.Id + "" == jobId);

            if (updatedJob != null)
            {
                updatedJob.Price = job.Price;
                updatedJob.Type = job.Type;
                updatedJob.AssignedCleaner = job.AssignedCleaner;

                //     _context.SaveChanges();
            }

            return updatedJob;
        }

        public void DeleteJob(string jobId)
        {
            var deletedJob = _context
                .Jobs
                .FirstOrDefault(j => j.Id + "" == jobId);
            
            deletedJob?.DeleteJob();

            _context.SaveChanges();
        }

        public IEnumerable<Job> GetAllJobsForCleaner(string userId)
        {
            return _context
                .Jobs
                .Where(j => j.AssignedCleaner == userId);

            //get only future jobs? 
            // .Where(j => j.ForDateTime > DateTime.Now)
            //

        }
    }
}