﻿

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace KoNorBeadando
{

using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;


public partial class eDiaryModelDB : DbContext
{
    public eDiaryModelDB()
        : base("name=eDiaryModelDB")
    {

    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }


    public virtual DbSet<Class> Class { get; set; }

    public virtual DbSet<Lesson> Lesson { get; set; }

    public virtual DbSet<Score> Score { get; set; }

    public virtual DbSet<Student> Student { get; set; }

    public virtual DbSet<Teacher> Teacher { get; set; }

    public virtual DbSet<Test> Test { get; set; }

    public virtual DbSet<User> User { get; set; }

}

}

