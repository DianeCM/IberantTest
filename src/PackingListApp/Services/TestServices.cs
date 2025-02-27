﻿using PackingListApp.EntityFramework;
using PackingListApp.Interfaces;
using PackingListApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PackingListApp.Services
{
    public class TestServices : ITestServices
    {
        private readonly TestContext _context;
        public TestServices(TestContext context)
        {
            _context = context;
        }

        public int Add(NewTestModel TestModel)
        {
            var newtest = new TestModel()
            {
                Title = TestModel.Title,
                Description = TestModel.Description
            };
            _context.TestModels.Add(newtest
            );
            _context.SaveChanges();
            return newtest.Id;
        }

        public TestModel Get(int id)
        {
            return _context.TestModels.FirstOrDefault(t => t.Id == id);
        }

        public List<TestModel> GetAll()
        {
            return _context.TestModels.ToList();
        }

        public int Put(int id, TestModel item)
        {
            var itemput = _context.TestModels.FirstOrDefault(t => t.Id == id);
            itemput.Description = item.Description;
            itemput.Title = item.Title;
            _context.SaveChanges();
            return id;

        }

        public int Delete(int id)
        {
            var item_to_remove = _context.TestModels.FirstOrDefault(t => t.Id == id);
            _context.TestModels.Remove(item_to_remove);
            _context.SaveChanges();
            return id;
        }

    }
}
