using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using MyEvernote.DataAccessLayer_Infastructure.Abstract;

namespace MyEvernote.DataAccessLayer_Infastructure.EntityFramework
{
    //where yazma nedenimiz db.Set<T> içierisinde int tipinde de değer gelebilir 

    //where ile sadece instance alınabilen yani new lenen bir class gelebilir şekline çekildi
    public class Reporsitory<T>:RepositoryBase,IRepository<T> where T : class
    {
        private DbSet<T> _objectSet;
        public Reporsitory()
        {
            
            //db.Set<T>() sürekli tekrarlandığı için bu class ilk oluşuyrken elde etmeyi amaçladı
            _objectSet = db.Set<T>();
        }
        public List<T> List()
        {
            //db.Set<T> anlamı gelen dinamic tipi db den bul 
            return _objectSet.ToList();
        }

        public IQueryable<T> ListQueryable()
        {
            return _objectSet.AsQueryable<T>();
        }
        public List<T> List(Expression<Func<T,bool>> where)
        {
            return _objectSet.Where(where).ToList();
        }

        public int Insert(T obj)
        {
            _objectSet.Add(obj);
            return Save();
        }

        public int Update(T obj)
        {
          return Save();
        }

        public int Delete(T obj)
        {
            _objectSet.Remove(obj);
            return Save();
        }
        public int Save()
        {
            return db.SaveChanges();
        }

        public T Find(Expression<Func<T, bool>> where)
        {
            return _objectSet.Where(where).FirstOrDefault();
        }
        
    }
}
