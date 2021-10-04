
using System;

namespace CommonArea
{
    public partial class ExpenseCommon
    {
        public int ExpenseID { get; set; }
        public int FormID { get; set; }
        public DateTime Date { get; set; }
        public int Cost { get; set; }
        public string Explanation { get; set; }
        public string Type { get; set; }

        public ExpenseCommon()
        {

        }
        public ExpenseCommon(int ExpenseID, int FormID, System.DateTime Date, int Cost, string Explanation, string Type)
        {
            this.ExpenseID = ExpenseID;
            this.FormID = FormID;
            this.Date = Date;
            this.Cost = Cost;
            this.Explanation = Explanation;
            this.Type = Type;
        }
    }
}
