using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CodeFirst
{
    public class StudentBll
    {
        private SchoolContext _context;
        public StudentBll()
        {
               _context=new SchoolContext();
        }

        public List<Student> GetList()
        {

            // 如果通过特性将名称改为StudentMaster，Exception: 'StudentMaster' could not be resolved in the current scope or context. Make sure that all referenced variables are in scope, that required schemas are loaded, and that namespaces are referenced correctly.

            var eSqlQuery = "select VAlUE b from Students As b";
            var objectContext = ((IObjectContextAdapter) _context).ObjectContext;
           // var objectQuery = objectContext.CreateDatabaseScript();
           // Debug.Write(objectQuery);
          //  Console.WriteLine(objectQuery);

            var query = objectContext.CreateQuery<Student>(eSqlQuery);

            return query.ToList();

        }

    }
}
