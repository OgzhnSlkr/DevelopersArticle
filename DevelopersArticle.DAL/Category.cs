//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DevelopersArticle.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Category
    {
        public Category()
        {
            this.Articles = new HashSet<Article>();
            this.Developers = new HashSet<Developer>();
        }
    
        public int ObjectID { get; set; }
        public string CategoryName { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public bool IsDeleted { get; set; }
        public Nullable<System.DateTime> DeletedDate { get; set; }
    
        public virtual ICollection<Article> Articles { get; set; }
        public virtual ICollection<Developer> Developers { get; set; }
    }
}
