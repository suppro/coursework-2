//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ARU
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order_Grave
    {
        public int id { get; set; }
        public int deceased_id { get; set; }
        public int status_id { get; set; }
        public int order_id { get; set; }
        public int grave_id { get; set; }
        public System.DateTime burial_date { get; set; }
    
        public virtual Deceased Deceased { get; set; }
        public virtual Grave Grave { get; set; }
        public virtual Order Order { get; set; }
        public virtual Status Status { get; set; }
    }
}
