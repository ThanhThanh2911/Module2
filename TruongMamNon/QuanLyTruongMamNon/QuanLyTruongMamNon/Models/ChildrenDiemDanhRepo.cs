using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System;

namespace QuanLyTruongMamNon.Models
{
    public class ChildrenDiemDanhRepo : IChildrenDiemDanhRePo
    {
        private readonly AppDbContext dbContext;

        public ChildrenDiemDanhRepo(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IEnumerable<ChildrenDiemDanh> GetAll()
        {
            var result = from child in dbContext.ChildrenDiemDanhs
                         .Include(d => d.DiemDanh).Include(c => c.Children).Include(p => p.Children.PhuHuynh)                          
                         select child;
            return result;
        }
    }
}
