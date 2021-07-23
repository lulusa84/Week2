using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2
 {
   /* public class EFRepository<T> : IRepository<T> where T : class

    {

        private readonly ContextDb ctx;

        public EFRepository(ContextDb ctx)
        {
            this.ctx = ctx;
        }

        public bool Add(T item)
        {
           ctx.Add(item);
            return true;
        }

        public bool GetItem(T item)
        {
            ctx.Set<T>().Fild(item);
            return true;
        }

        public bool Remove(T item)
        {
            ctx.Remove(item);
            return true;
        }

        public bool Update(T item)
        {
            ctx.Attch(item);
           
            return true;


        }
    } */
} 
