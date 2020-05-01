using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project_Ablaihan.Data;
using Project_Ablaihan.Models.Goods;

namespace Project_Ablaihan.Services
{
    public class GoodRepository : IGoodsRepository
    {

        readonly GoodsContext _context;

        public GoodRepository(GoodsContext context)
        {
            _context = context;
        }

        public void Add(Good good)
        {
            _context.Add(good);
        }

        public void Update(Good good)
        {
            _context.SaveChanges(good);
        }

        public Task<List<Good>> GetAll()
        {
            return _context.Goods.ToListAsync();
        }

        public Task<List<Good>> GetGoods(Expression<Func<Good, bool>> predicate)
        {
            return _context.Goods.Where(predicate).ToListAsync();
        }

        public Task Save()
        {
            return _context.SaveChangesAsync();
        }


    }
}