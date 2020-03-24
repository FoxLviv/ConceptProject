using System;
using System.Collections.Generic;
using System.Text;

namespace Reporter.DL.Repositories {
    public interface IRepository<T> where T:class {
        /// <summary>
        ///     Read all values
        /// </summary>
        /// <returns></returns>
        IEnumerable<T> ReadAll();

        /// <summary>
        ///     Create entity in database
        /// </summary>
        /// <param name="entity"></param>
        void Create(T entity);

        /// <summary>
        ///     Update entiry
        /// </summary>
        /// <param name="entity"></param>
        void Update(T entity);

    }
}
