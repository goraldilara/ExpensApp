using ExpensApp.DataAccess.Absract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Migrations;
using ExpensApp.DataAccess.Concrete.EntityFramework.Models;

namespace ExpensApp.DataAccess.Concrete.EntityFramework.Repository
{
    public class EFFormRepository : IFormDal
    {

        MasrafEntities MasrafEntities = new MasrafEntities();

        public int AddForm(Form entity)     //Adding new form to the database
        {
            MasrafEntities.Form.AddOrUpdate(entity);
            MasrafEntities.SaveChanges();

            return entity.FormID;
        }

        public Form GetForm(int FormID)    //Getting one form for 
        {
            return MasrafEntities.Form.AsNoTracking().Where(x => x.FormID == FormID).SingleOrDefault();   //if form ID that I sent is equal to form's ID get one single
        }

        public List<Form> GetFormsForStaff(int EmployeeID)   //Getting all forms of an employee
        {
            return MasrafEntities.Form.AsNoTracking().Where(x => x.EmployeeID == EmployeeID).ToList();
        }

        public List<Form> GetFormsFromStatus(string Status)    //Getting all forms with a specific status
        {
            return MasrafEntities.Form.AsNoTracking().Where(x => x.Status == Status).ToList();
        }

        public List<Form> ListForms()    //Getting all forms for listing
        {
            return MasrafEntities.Form.AsNoTracking().ToList();
        }

        public void UpdateForm(Form entity)      //Updating form
        {
            Form form = new Form();
            form = MasrafEntities.Form.AsNoTracking().Where(x => x.FormID == entity.FormID).SingleOrDefault();
            form.Date = entity.Date;
            form.TotalAmount = entity.TotalAmount;
            MasrafEntities.SaveChanges();
        }

        public void UpdateFormStatus(int FormID, string Status)    //Updating form's status
        {
            Form form = new Form();
            form = MasrafEntities.Form.AsNoTracking().Where(x => x.FormID == FormID).SingleOrDefault();
            form.Status = Status;
            MasrafEntities.SaveChanges();
        }
    }
}
