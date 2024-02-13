using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using FirstRealProject.Data;
using FirstRealProject.Models;
using FirstRealProject.Repository.IRepository;
using FirstRealProject.Repository.Repository;

namespace FirstRealProject.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDBContext _db;
        public ICategoryRepository Category {get; private set;}
        public IProductRepository Product {get; private set;}
        public ICompanyRepository Company {get; private set;}


        public UnitOfWork(ApplicationDBContext db)
        {
            _db = db;
            Category = new CategoryRepository(_db);
            Product = new ProductRepository(_db);
            Company = new CompanyRepository(_db);
        }

        public void Save()
        {
           _db.SaveChanges();
        }
    }
}