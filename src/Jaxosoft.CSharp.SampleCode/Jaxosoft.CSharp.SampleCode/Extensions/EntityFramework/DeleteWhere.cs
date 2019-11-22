using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace System.Data.Entity
{
    public static partial class EntityFrameworkExtensions
    {
        /// <summary>
        /// Extension method that deletes entities via a provided query.
        /// This does NOT execute SaveChanges()!!!
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="entities"></param>
        /// <param name="selector"></param>
        /// <returns></returns>
        public static int DeleteWhere<TEntity>(this DbSet<TEntity> entities, Expression<Func<TEntity, bool>> selector)
            where TEntity : class
        {
            var records = entities.Where(selector);
            int numberAffected = records.Count();
            entities.RemoveRange(records);
            return numberAffected;
        }
    }
}
