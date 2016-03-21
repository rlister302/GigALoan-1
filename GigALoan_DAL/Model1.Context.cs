﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GigALoan_DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class DB_42039_gigEntities1 : DbContext
    {
        public DB_42039_gigEntities1()
            : base("name=DB_42039_gigEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CHLD_ClientImages> CHLD_ClientImages { get; set; }
        public virtual DbSet<CHLD_GigImages> CHLD_GigImages { get; set; }
        public virtual DbSet<CHLD_StudentImages> CHLD_StudentImages { get; set; }
        public virtual DbSet<CHLD_StudentLoans> CHLD_StudentLoans { get; set; }
        public virtual DbSet<CHLD_StudentReferences> CHLD_StudentReferences { get; set; }
        public virtual DbSet<CORE_Clients> CORE_Clients { get; set; }
        public virtual DbSet<CORE_GigAlerts> CORE_GigAlerts { get; set; }
        public virtual DbSet<CORE_Gigs> CORE_Gigs { get; set; }
        public virtual DbSet<CORE_Students> CORE_Students { get; set; }
        public virtual DbSet<LOG_Events> LOG_Events { get; set; }
        public virtual DbSet<SPRT_Colleges> SPRT_Colleges { get; set; }
        public virtual DbSet<SPRT_GigCategories> SPRT_GigCategories { get; set; }
        public virtual DbSet<SPRT_GigTypes> SPRT_GigTypes { get; set; }
        public virtual DbSet<SPRT_LoanCompanies> SPRT_LoanCompanies { get; set; }
        public virtual DbSet<SPRT_Majors> SPRT_Majors { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
    
        public virtual int proc_AddClient(string firstName, string lastName, string email, string pass, string gender, string phoneNumber)
        {
            var firstNameParameter = firstName != null ?
                new ObjectParameter("FirstName", firstName) :
                new ObjectParameter("FirstName", typeof(string));
    
            var lastNameParameter = lastName != null ?
                new ObjectParameter("LastName", lastName) :
                new ObjectParameter("LastName", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var passParameter = pass != null ?
                new ObjectParameter("Pass", pass) :
                new ObjectParameter("Pass", typeof(string));
    
            var genderParameter = gender != null ?
                new ObjectParameter("Gender", gender) :
                new ObjectParameter("Gender", typeof(string));
    
            var phoneNumberParameter = phoneNumber != null ?
                new ObjectParameter("PhoneNumber", phoneNumber) :
                new ObjectParameter("PhoneNumber", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("proc_AddClient", firstNameParameter, lastNameParameter, emailParameter, passParameter, genderParameter, phoneNumberParameter);
        }
    
        public virtual int proc_AddClientImage(Nullable<int> clientID, string imageURL, string imageUUID, string imageName)
        {
            var clientIDParameter = clientID.HasValue ?
                new ObjectParameter("ClientID", clientID) :
                new ObjectParameter("ClientID", typeof(int));
    
            var imageURLParameter = imageURL != null ?
                new ObjectParameter("ImageURL", imageURL) :
                new ObjectParameter("ImageURL", typeof(string));
    
            var imageUUIDParameter = imageUUID != null ?
                new ObjectParameter("ImageUUID", imageUUID) :
                new ObjectParameter("ImageUUID", typeof(string));
    
            var imageNameParameter = imageName != null ?
                new ObjectParameter("ImageName", imageName) :
                new ObjectParameter("ImageName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("proc_AddClientImage", clientIDParameter, imageURLParameter, imageUUIDParameter, imageNameParameter);
        }
    
        public virtual int proc_AddGigAlert(Nullable<int> clientID, Nullable<int> typeID, string title, string comment, Nullable<double> paymentAmt, Nullable<double> @long, Nullable<double> lat)
        {
            var clientIDParameter = clientID.HasValue ?
                new ObjectParameter("ClientID", clientID) :
                new ObjectParameter("ClientID", typeof(int));
    
            var typeIDParameter = typeID.HasValue ?
                new ObjectParameter("TypeID", typeID) :
                new ObjectParameter("TypeID", typeof(int));
    
            var titleParameter = title != null ?
                new ObjectParameter("Title", title) :
                new ObjectParameter("Title", typeof(string));
    
            var commentParameter = comment != null ?
                new ObjectParameter("Comment", comment) :
                new ObjectParameter("Comment", typeof(string));
    
            var paymentAmtParameter = paymentAmt.HasValue ?
                new ObjectParameter("PaymentAmt", paymentAmt) :
                new ObjectParameter("PaymentAmt", typeof(double));
    
            var longParameter = @long.HasValue ?
                new ObjectParameter("Long", @long) :
                new ObjectParameter("Long", typeof(double));
    
            var latParameter = lat.HasValue ?
                new ObjectParameter("Lat", lat) :
                new ObjectParameter("Lat", typeof(double));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("proc_AddGigAlert", clientIDParameter, typeIDParameter, titleParameter, commentParameter, paymentAmtParameter, longParameter, latParameter);
        }
    
        public virtual int proc_AddGigImage(Nullable<int> gigID, string imageURL, string imageUUID, string imageName)
        {
            var gigIDParameter = gigID.HasValue ?
                new ObjectParameter("GigID", gigID) :
                new ObjectParameter("GigID", typeof(int));
    
            var imageURLParameter = imageURL != null ?
                new ObjectParameter("ImageURL", imageURL) :
                new ObjectParameter("ImageURL", typeof(string));
    
            var imageUUIDParameter = imageUUID != null ?
                new ObjectParameter("ImageUUID", imageUUID) :
                new ObjectParameter("ImageUUID", typeof(string));
    
            var imageNameParameter = imageName != null ?
                new ObjectParameter("ImageName", imageName) :
                new ObjectParameter("ImageName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("proc_AddGigImage", gigIDParameter, imageURLParameter, imageUUIDParameter, imageNameParameter);
        }
    
        public virtual int proc_AddStudent(string firstName, string lastName, string email, string pass, Nullable<int> majorID, Nullable<int> collegeID, string gender, Nullable<bool> employed, string employer, string phoneNumber)
        {
            var firstNameParameter = firstName != null ?
                new ObjectParameter("FirstName", firstName) :
                new ObjectParameter("FirstName", typeof(string));
    
            var lastNameParameter = lastName != null ?
                new ObjectParameter("LastName", lastName) :
                new ObjectParameter("LastName", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var passParameter = pass != null ?
                new ObjectParameter("Pass", pass) :
                new ObjectParameter("Pass", typeof(string));
    
            var majorIDParameter = majorID.HasValue ?
                new ObjectParameter("MajorID", majorID) :
                new ObjectParameter("MajorID", typeof(int));
    
            var collegeIDParameter = collegeID.HasValue ?
                new ObjectParameter("CollegeID", collegeID) :
                new ObjectParameter("CollegeID", typeof(int));
    
            var genderParameter = gender != null ?
                new ObjectParameter("Gender", gender) :
                new ObjectParameter("Gender", typeof(string));
    
            var employedParameter = employed.HasValue ?
                new ObjectParameter("Employed", employed) :
                new ObjectParameter("Employed", typeof(bool));
    
            var employerParameter = employer != null ?
                new ObjectParameter("Employer", employer) :
                new ObjectParameter("Employer", typeof(string));
    
            var phoneNumberParameter = phoneNumber != null ?
                new ObjectParameter("PhoneNumber", phoneNumber) :
                new ObjectParameter("PhoneNumber", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("proc_AddStudent", firstNameParameter, lastNameParameter, emailParameter, passParameter, majorIDParameter, collegeIDParameter, genderParameter, employedParameter, employerParameter, phoneNumberParameter);
        }
    
        public virtual int proc_AddStudentImage(Nullable<int> studentID, string imageURL, string imageUUID, string imageName)
        {
            var studentIDParameter = studentID.HasValue ?
                new ObjectParameter("StudentID", studentID) :
                new ObjectParameter("StudentID", typeof(int));
    
            var imageURLParameter = imageURL != null ?
                new ObjectParameter("ImageURL", imageURL) :
                new ObjectParameter("ImageURL", typeof(string));
    
            var imageUUIDParameter = imageUUID != null ?
                new ObjectParameter("ImageUUID", imageUUID) :
                new ObjectParameter("ImageUUID", typeof(string));
    
            var imageNameParameter = imageName != null ?
                new ObjectParameter("ImageName", imageName) :
                new ObjectParameter("ImageName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("proc_AddStudentImage", studentIDParameter, imageURLParameter, imageUUIDParameter, imageNameParameter);
        }
    
        public virtual ObjectResult<proc_GetClientImage_Result> proc_GetClientImage(Nullable<int> clientID, Nullable<int> imageID)
        {
            var clientIDParameter = clientID.HasValue ?
                new ObjectParameter("ClientID", clientID) :
                new ObjectParameter("ClientID", typeof(int));
    
            var imageIDParameter = imageID.HasValue ?
                new ObjectParameter("ImageID", imageID) :
                new ObjectParameter("ImageID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<proc_GetClientImage_Result>("proc_GetClientImage", clientIDParameter, imageIDParameter);
        }
    
        public virtual ObjectResult<proc_GetClientImages_Result> proc_GetClientImages(Nullable<int> clientID)
        {
            var clientIDParameter = clientID.HasValue ?
                new ObjectParameter("ClientID", clientID) :
                new ObjectParameter("ClientID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<proc_GetClientImages_Result>("proc_GetClientImages", clientIDParameter);
        }
    
        public virtual ObjectResult<proc_GetGigImage_Result> proc_GetGigImage(Nullable<int> gigID, Nullable<int> imageID)
        {
            var gigIDParameter = gigID.HasValue ?
                new ObjectParameter("GigID", gigID) :
                new ObjectParameter("GigID", typeof(int));
    
            var imageIDParameter = imageID.HasValue ?
                new ObjectParameter("ImageID", imageID) :
                new ObjectParameter("ImageID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<proc_GetGigImage_Result>("proc_GetGigImage", gigIDParameter, imageIDParameter);
        }
    
        public virtual ObjectResult<proc_GetGigImages_Result> proc_GetGigImages(Nullable<int> gigID)
        {
            var gigIDParameter = gigID.HasValue ?
                new ObjectParameter("GigID", gigID) :
                new ObjectParameter("GigID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<proc_GetGigImages_Result>("proc_GetGigImages", gigIDParameter);
        }
    
        public virtual ObjectResult<proc_GetGigTypes_Result> proc_GetGigTypes()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<proc_GetGigTypes_Result>("proc_GetGigTypes");
        }
    
        public virtual ObjectResult<proc_GetGigTypesByID_Result> proc_GetGigTypesByID(Nullable<int> typeID)
        {
            var typeIDParameter = typeID.HasValue ?
                new ObjectParameter("TypeID", typeID) :
                new ObjectParameter("TypeID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<proc_GetGigTypesByID_Result>("proc_GetGigTypesByID", typeIDParameter);
        }
    
        public virtual ObjectResult<proc_GetLoanCompanies_Result> proc_GetLoanCompanies()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<proc_GetLoanCompanies_Result>("proc_GetLoanCompanies");
        }
    
        public virtual ObjectResult<proc_GetStudentImage_Result> proc_GetStudentImage(Nullable<int> studentID, Nullable<int> imageID)
        {
            var studentIDParameter = studentID.HasValue ?
                new ObjectParameter("StudentID", studentID) :
                new ObjectParameter("StudentID", typeof(int));
    
            var imageIDParameter = imageID.HasValue ?
                new ObjectParameter("ImageID", imageID) :
                new ObjectParameter("ImageID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<proc_GetStudentImage_Result>("proc_GetStudentImage", studentIDParameter, imageIDParameter);
        }
    
        public virtual ObjectResult<proc_GetStudentImages_Result> proc_GetStudentImages(Nullable<int> studentID)
        {
            var studentIDParameter = studentID.HasValue ?
                new ObjectParameter("StudentID", studentID) :
                new ObjectParameter("StudentID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<proc_GetStudentImages_Result>("proc_GetStudentImages", studentIDParameter);
        }
    
        public virtual int proc_UpdateClient(Nullable<int> clientID, string firstName, string lastName, string email, string pass, string gender, string phoneNumber, Nullable<bool> active)
        {
            var clientIDParameter = clientID.HasValue ?
                new ObjectParameter("ClientID", clientID) :
                new ObjectParameter("ClientID", typeof(int));
    
            var firstNameParameter = firstName != null ?
                new ObjectParameter("FirstName", firstName) :
                new ObjectParameter("FirstName", typeof(string));
    
            var lastNameParameter = lastName != null ?
                new ObjectParameter("LastName", lastName) :
                new ObjectParameter("LastName", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var passParameter = pass != null ?
                new ObjectParameter("Pass", pass) :
                new ObjectParameter("Pass", typeof(string));
    
            var genderParameter = gender != null ?
                new ObjectParameter("Gender", gender) :
                new ObjectParameter("Gender", typeof(string));
    
            var phoneNumberParameter = phoneNumber != null ?
                new ObjectParameter("PhoneNumber", phoneNumber) :
                new ObjectParameter("PhoneNumber", typeof(string));
    
            var activeParameter = active.HasValue ?
                new ObjectParameter("Active", active) :
                new ObjectParameter("Active", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("proc_UpdateClient", clientIDParameter, firstNameParameter, lastNameParameter, emailParameter, passParameter, genderParameter, phoneNumberParameter, activeParameter);
        }
    
        public virtual int proc_UpdateStudent(Nullable<int> studentID, string firstName, string lastName, string email, string pass, Nullable<int> majorID, Nullable<int> collegeID, string gender, Nullable<bool> employed, string employer, string phoneNumber, Nullable<bool> active)
        {
            var studentIDParameter = studentID.HasValue ?
                new ObjectParameter("StudentID", studentID) :
                new ObjectParameter("StudentID", typeof(int));
    
            var firstNameParameter = firstName != null ?
                new ObjectParameter("FirstName", firstName) :
                new ObjectParameter("FirstName", typeof(string));
    
            var lastNameParameter = lastName != null ?
                new ObjectParameter("LastName", lastName) :
                new ObjectParameter("LastName", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var passParameter = pass != null ?
                new ObjectParameter("Pass", pass) :
                new ObjectParameter("Pass", typeof(string));
    
            var majorIDParameter = majorID.HasValue ?
                new ObjectParameter("MajorID", majorID) :
                new ObjectParameter("MajorID", typeof(int));
    
            var collegeIDParameter = collegeID.HasValue ?
                new ObjectParameter("CollegeID", collegeID) :
                new ObjectParameter("CollegeID", typeof(int));
    
            var genderParameter = gender != null ?
                new ObjectParameter("Gender", gender) :
                new ObjectParameter("Gender", typeof(string));
    
            var employedParameter = employed.HasValue ?
                new ObjectParameter("Employed", employed) :
                new ObjectParameter("Employed", typeof(bool));
    
            var employerParameter = employer != null ?
                new ObjectParameter("Employer", employer) :
                new ObjectParameter("Employer", typeof(string));
    
            var phoneNumberParameter = phoneNumber != null ?
                new ObjectParameter("PhoneNumber", phoneNumber) :
                new ObjectParameter("PhoneNumber", typeof(string));
    
            var activeParameter = active.HasValue ?
                new ObjectParameter("Active", active) :
                new ObjectParameter("Active", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("proc_UpdateStudent", studentIDParameter, firstNameParameter, lastNameParameter, emailParameter, passParameter, majorIDParameter, collegeIDParameter, genderParameter, employedParameter, employerParameter, phoneNumberParameter, activeParameter);
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    
        public virtual ObjectResult<proc_GetColleges_Result> proc_GetColleges()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<proc_GetColleges_Result>("proc_GetColleges");
        }
    
        public virtual int proc_AddCollegeTest(string collegeName)
        {
            var collegeNameParameter = collegeName != null ?
                new ObjectParameter("CollegeName", collegeName) :
                new ObjectParameter("CollegeName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("proc_AddCollegeTest", collegeNameParameter);
        }
    
        public virtual ObjectResult<proc_GetMajors_Result> proc_GetMajors()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<proc_GetMajors_Result>("proc_GetMajors");
        }
    
        public virtual ObjectResult<proc_GetGigCategories_Result> proc_GetGigCategories()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<proc_GetGigCategories_Result>("proc_GetGigCategories");
        }
    }
}
