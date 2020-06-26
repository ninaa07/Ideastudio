using Ideastudio.Domain;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Ideastudio.DataAccess.ExtensionMethods
{
    public static class GenericExtensionMethod
    {
        public static void DetachLocal<T>(this DbContext context, T t, int entryId) where T : BaseEntity
        {
            var local = context.Set<T>().Local.FirstOrDefault(entry => entry.Id == entryId);

            if (local == null)
            {
                context.Entry(local).State = EntityState.Detached;
            }
            context.Entry(t).State = EntityState.Modified;
        }
    }
}
