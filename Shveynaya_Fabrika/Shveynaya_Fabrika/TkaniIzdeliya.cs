//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Shveynaya_Fabrika
{
    using System;
    using System.Collections.Generic;
    
    public partial class TkaniIzdeliya
    {
        public int Id { get; set; }
        public string IdTkani { get; set; }
        public string IdIzdeliya { get; set; }
    
        public virtual Izdeliya Izdeliya { get; set; }
        public virtual Tkani Tkani { get; set; }
    }
}
