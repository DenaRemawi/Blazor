using BlazorWeb.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWeb.Reposetry
{
    public class ContactReposetry : IContactReposetry
    {
        BlazorContext context;

        public ContactReposetry(BlazorContext contexts)
        {
            context = contexts;
        }


     public List<Contact> GetAllContact()
        {
            List<Contact> contacts = context.Contants.ToList();
            return contacts;
        }

        public void Removes(int id)
        {

            Contact contact = context.Contants.Find(id);
            context.Contants.Remove(contact);
            context.SaveChanges();


        }
        public Contact GetContactById(int id)
        {
            return context.Contants.Find(id);
        }

        public void Inseart(Contact contact)
        {
            context.Contants.Add(contact);
            context.SaveChanges();

        }

        public void UpdateContact(Contact model)
        {
            context.Update(model);
            context.SaveChanges();
        }
    }
}
