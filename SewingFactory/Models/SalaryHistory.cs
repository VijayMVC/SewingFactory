//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SewingFactory.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class SalaryHistory
    {
        public SalaryHistory()
        {
            this.PaymentHistory = new HashSet<PaymentHistory>();
        }
    
        public short Id { get; set; }
        public Nullable<byte> Emploees { get; set; }
        public Nullable<double> Sum { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<int> PostOrder { get; set; }
        public Nullable<double> Payment { get; set; }
    
        public virtual Employees Employees { get; set; }
        public virtual ICollection<PaymentHistory> PaymentHistory { get; set; }
        public virtual PostOrder PostOrder1 { get; set; }
        public virtual PostEmploees PostEmplees1 { get; set; }
        public double? Pay()
        {
            return Sum - Payment;
        }
    }
}
