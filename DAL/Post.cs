//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Post
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string ShortContent { get; set; }
        public string PostContent { get; set; }
        public int CatagoryID { get; set; }
        public int ViewCount { get; set; }
        public string SeoLink { get; set; }
        public bool Slider { get; set; }
        public bool Area1 { get; set; }
        public bool Area2 { get; set; }
        public bool Area3 { get; set; }
        public bool Notification { get; set; }
        public string LanguageName { get; set; }
        public System.DateTime AddDate { get; set; }
        public int addUserID { get; set; }
        public bool isDeleted { get; set; }
        public Nullable<System.DateTime> DeletedDate { get; set; }
        public int LastUpdateUserID { get; set; }
        public System.DateTime LastUpdateDate { get; set; }
    
        public virtual T_User T_User { get; set; }
    }
}
