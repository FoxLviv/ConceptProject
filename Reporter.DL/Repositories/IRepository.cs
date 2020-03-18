using System;
using System.Collections.Generic;
using System.Text;

namespace Reporter.DL.Repositories {
    interface IRepository<T> where T:class {
        IEnumerable<T> ReadAll();
        T GetById(int Id);
        void Create(T entity);
        void Update(T entity);
        void Delete(int id);
    }
}
