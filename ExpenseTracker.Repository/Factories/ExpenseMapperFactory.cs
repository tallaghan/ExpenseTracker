using ExpenseTracker.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker.Repository.Factories
{
    public class ExpenseMapperFactory<T> where T : IDTOEntity
    {

        public IExpenseTrackerMapper CreateInstance()
        {
            Object retVal = null;

            var type = typeof(IExpenseTrackerMapper);
            var types = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(p => type.IsAssignableFrom(p));

            foreach (IExpenseTrackerMapper mapType in types)
            {
                MethodInfo myMethodinfo = ((Type)mapType).GetMethod("CreateDTOFromEntity");

                if (myMethodinfo.ReturnType == typeof(T))
                {
                    retVal = Activator.CreateInstance(mapType.GetType());
                    break;
                }
            }

            return (IExpenseTrackerMapper)retVal;

        }
    }
}
