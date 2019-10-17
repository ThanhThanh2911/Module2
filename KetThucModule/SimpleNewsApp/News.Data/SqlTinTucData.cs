using News.Core;
using System;
using System.Collections.Generic;
using System.Linq;

namespace News.Data
{
    public class SqlTinTucData : ITinTucData
    {
        private readonly TinTucDataContext dbContext;

        public SqlTinTucData(TinTucDataContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public TinTuc Add(TinTuc newTinTuc)
        {
            throw new NotImplementedException();
        }

        public int Commit()
        {
            throw new NotImplementedException();
        }

        public TinTuc Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public TinTuc Detail(int Id)
        {
            throw new NotImplementedException();
        }

        public TinTuc GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TinTuc> GetAll()
        {
            var result = from t in dbContext.TinTucDatas
                         orderby t.TieuDe
                         select t;
            return result;
        }
    }
}
