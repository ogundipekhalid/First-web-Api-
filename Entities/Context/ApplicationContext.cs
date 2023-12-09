using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LinkedOut.Entites;
using LinkedOut.Entites.Identity;
using Microsoft.EntityFrameworkCore;

namespace LinkedOut.Context
{
    public class ApplicationContext : DbContext 
    {
        public ApplicationContext (DbContextOptions<ApplicationContext> options): base(options)
        {

        }
        public DbSet<User> Users {get; set;}
        public DbSet<Admin> Admins{get;set;}
        public DbSet<Advertisement> Advertisements {get;set;}
        public DbSet<Applicant> Applicants {get;set;}
        public DbSet<Application> Applications {get;set;}
        public DbSet<Company> Companies {get;set;}
        public DbSet<Contact> Contacts {get;set;}
        public DbSet<Vacancy> Vacancies {get;set;}
        public DbSet<Role> Roles {get;set;}
    }
}