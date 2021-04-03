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
    
    public partial class Developer
    {
        public Developer()
        {
            this.Articles = new HashSet<Article>();
            this.Categories = new HashSet<Category>();
            this.Comments = new HashSet<Comment>();
        }
    
        public int ObjectID { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsDeleted { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<System.DateTime> DeletedDate { get; set; }
    
        public virtual ICollection<Article> Articles { get; set; }
        public virtual ICollection<Category> Categories { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
}
