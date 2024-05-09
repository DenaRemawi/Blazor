using BlazorWeb.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWeb.Reposetry
{
  public  interface IContactReposetry
    {
        List<Contact> GetAllContact();
        void Removes(int id);
        void Inseart(Contact contact);
        void UpdateContact(Contact model);
        Contact GetContactById(int id);
    }
}
