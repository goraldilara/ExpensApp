//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ExpensApp.DataAccess.Concrete.EntityFramework.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Expense
    {
        public int ExpenseID { get; set; }
        public int FormID { get; set; }
        public System.DateTime Date { get; set; }
        public int Cost { get; set; }
        public string Explanation { get; set; }
        public string Type { get; set; }
    
        public virtual Form Form { get; set; }
    }
}
