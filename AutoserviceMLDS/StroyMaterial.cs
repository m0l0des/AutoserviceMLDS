//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AutoserviceMLDS
{
    using System;
    using System.Collections.Generic;
    
    public partial class StroyMaterial
    {
        public int Num { get; set; }
        public string Title { get; set; }
        public string Edlzm { get; set; }
        public int Ost { get; set; }
        public int SkladNum { get; set; }
    
        public virtual Sklad Sklad { get; set; }
    }
}
