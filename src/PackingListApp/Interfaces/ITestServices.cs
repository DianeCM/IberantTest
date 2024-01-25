using PackingListApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PackingListApp.Interfaces
{
    public interface ITestServices
    {
        List<TestModel> GetAll();

        int Add(NewTestModel TestModel);

        TestModel Get(int id);

        int Put(int id, TestModel item);

        int Delete(int id);
    }

    public interface IUserServices
    {
        List<User> GetAll();

        int Add(NewUser newUser);

        User Get(int id);

        int Put(int id, User item);

        int Delete(int id);     

    }
}
