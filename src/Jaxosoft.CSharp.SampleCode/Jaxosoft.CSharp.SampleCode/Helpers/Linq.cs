using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jaxosoft.CSharp.SampleCode.Helpers
{
    /// <summary>
    /// Here's the scenario... you have the user submitting data from the web in a list.
    /// It's a list of some sort of items. These are ViewModels of type L.
    /// You have your data in a database and you are using EntityFramework.
    /// You need to know three things based on a comparison of the list submitted from the
    /// web and the list of items that are in the database.
    /// The EF data type is R.
    /// Which items did the user DELETE? ADD? EDIT?
    /// HINT: L = Left, R = Right... or L = web, R = db
    /// </summary>
    public class Linq
    {
        /// <summary>
        /// This is the implementation. The rest is the sample.
        /// </summary>
        /// <typeparam name="L"></typeparam>
        /// <typeparam name="R"></typeparam>
        /// <param name="models"></param>
        /// <param name="dos"></param>
        /// <param name="comparer"></param>
        /// <returns></returns>
        public (IEnumerable<L> insert, IEnumerable<R> update, IEnumerable<R> delete) GetChanges<L, R>(IEnumerable<L> models, IEnumerable<R> dos, Func<L, R, bool> comparer)
        {
            IEnumerable<L> itemsToInsert;
            IEnumerable<R> itemsToUpdate;
            IEnumerable<R> itemsToDelete;

            if (models == null)
                itemsToInsert = new List<L>();
            else if (dos == null)
                itemsToInsert = models;
            else
                itemsToInsert = models.Where(x => !dos.Any(y => comparer(x, y))).ToList();

            if (models == null || dos == null)
                itemsToUpdate = new List<R>();
            else
                itemsToUpdate = dos.Where(x => models.Any(y => comparer(y, x))).ToList();

            if (models == null)
                itemsToDelete = dos;
            else if (dos == null)
                itemsToDelete = new List<R>();
            else
                itemsToDelete = dos.Where(x => !models.Any(y => comparer(y, x))).ToList();

            return (itemsToInsert, itemsToUpdate, itemsToDelete);
        }

        public void Test()
        {
            // input
            List<WebViewModel> web = new List<WebViewModel>();
            // data in the database
            List<EntityFrameworkModel> efm = new List<EntityFrameworkModel>();

            // How we compare the two differing types. The property names don't even need to be
            // of the same type. Do your own logic WITHIN the Func.
            Func<WebViewModel, EntityFrameworkModel, bool> objectComparer = (compDto, compDo) =>
            {
                return compDto.Id == compDo.ID;
            };

            // todo now has three properties with the information that...
            // 1. needs to be inserted into the DB... List<WebViewModel>
            // 2. needs to be updated in the DB... List<EntityFrameworkModel>();
            // 3. needs to be deleted in the DB... List<EntityFrameworkModel>();
            var todo = GetChanges(web, efm, objectComparer);

        }

    }

    public class WebViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string OtherData { get; set; }
    }

    public class EntityFrameworkModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Payload { get; set; }
    }

    // C# 5 version...
    // the C# 7.0+ version uses ValueTuple
    public class EnumerableComparer<L, R>
    {
        public EnumerableComparerResult GetChanges(IEnumerable<L> models, IEnumerable<R> dos, Func<L, R, bool> comparer)
        {
            EnumerableComparerResult result = new EnumerableComparerResult();

            if (models == null)
                result.ItemsToAdd = new List<L>();
            else if (dos == null)
                result.ItemsToAdd = models;
            else
                result.ItemsToAdd = models.Where(x => !dos.Any(y => comparer(x, y))).ToList();

            if (models == null || dos == null)
                result.ItemsToUpdate = new List<R>();
            else
                result.ItemsToUpdate = dos.Where(x => models.Any(y => comparer(y, x))).ToList();

            if (models == null)
                result.ItemsToDelete = dos;
            else if (dos == null)
                result.ItemsToDelete = new List<R>();
            else
                result.ItemsToDelete = dos.Where(x => !models.Any(y => comparer(y, x))).ToList();

            return result;
        }

        public class EnumerableComparerResult
        {
            public IEnumerable<L> ItemsToAdd { get; set; }
            public IEnumerable<R> ItemsToUpdate { get; set; }
            public IEnumerable<R> ItemsToDelete { get; set; }
        }
    }
}
