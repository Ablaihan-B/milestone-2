using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Project_Ablaihan.Models.Goods;

namespace Project_Ablaihan.Services
{
    public class GoodsService
    {


        private readonly IGoodsRepository _goodRepo;

        public GoodsService(IGoodsRepository goodRepo)
        {
            _goodRepo = goodRepo;
        }

        public async Task<List<Good>> GetGoods()
        {
            return await _goodRepo.GetAll();
        }

        public async Task AddAndSave(Good good)
        {
            _goodRepo.Add(good);
            await _goodRepo.Save();
        }


        public async Task Save(Good good)
        {
            _goodRepo.Add(good);
            await _goodRepo.Save();
        }


        public async Task<List<Good>> Search(string text)
        {
            text = text.ToLower();
            var searchedGoods = await _goodRepo.GetGoods(good => good.Name.ToLower().Contains(text));

            return searchedGoods;
        }



    }
}