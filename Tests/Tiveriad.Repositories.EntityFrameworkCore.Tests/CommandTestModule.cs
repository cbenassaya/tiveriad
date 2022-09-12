﻿using Faker;
using Microsoft.EntityFrameworkCore;
using Tiveriad.Commons.Extensions;
using Tiveriad.IdGenerators;
using Tiveriad.Repositories.Tests.Models;
using Tiveriad.UnitTests;
using Xunit;
using Xunit.Sdk;
using Company = Faker.Company;
using Enum = Faker.Enum;

namespace Tiveriad.Repositories.EntityFrameworkCore.Tests;

public class CommandTestModule : TestBase<Startup>
{
    [Fact]
    public async Task Add_Entity()
    {
        var repository = GetRequiredService<CourseRepository>();
        var course = new Course { Name = Company.Name() };
        await repository.AddOneAsync(course);
    }

    [Fact]
    public async Task Add_Entities_Many_To_Many()
    {
        var courseRepository = GetRequiredService<CourseRepository>();
        var studentRepository = GetRequiredService<StudentRepository>();
        var context = GetRequiredService<DbContext>();

        var initialStudentsCount = studentRepository.Count();

        var student = new Student
        {
            Firstname = Name.First(),
            Lastname = Name.Last(),
            Email = Internet.Email(),
            City = Address.City(),
            Country = Address.Country(),
            StreetAddress = Address.StreetAddress(),
            Courses = new HashSet<Course>()
        };

        var course = courseRepository.Queryable.RandomElement(x => true);
        if (course == null)
            throw new NullException("Course");

        student.Courses.Add(course);

        await studentRepository.AddOneAsync(student);

        context.SaveChanges(true);
        Assert.Equal(initialStudentsCount + 1, studentRepository.Count());
    }

    [Fact]
    public async Task Add_Entities_Many_To_Many_With_NewChild()
    {
        var courseRepository = GetRequiredService<CourseRepository>();
        var studentRepository = GetRequiredService<StudentRepository>();
        var context = GetRequiredService<DbContext>();

        var initialStudentsCount = studentRepository.Count();


        var course = courseRepository.Queryable.RandomElement(x => true);

        var student = new Student
        {
            Firstname = Name.First(),
            Lastname = Name.Last(),
            Email = Internet.Email(),
            City = Address.City(),
            Country = Address.Country(),
            StreetAddress = Address.StreetAddress(),
            Courses = new HashSet<Course>()
        };

        if (course == null)
            throw new NullException("course");

        var newCourse = new Course
        {
            Name = Company.Name(),
            Professor = course.Professor
        };

        await courseRepository.AddOneAsync(newCourse);

        var oldCourse = courseRepository.GetById(course.Id);
        if (oldCourse == null)
            throw new NullException("oldCourse");
        student.Courses.Add(oldCourse);
        student.Courses.Add(newCourse);


        await studentRepository.AddOneAsync(student);

        context.SaveChanges(true);


        Assert.Equal(initialStudentsCount + 1, studentRepository.Count());
    }


    [Fact]
    public async Task Add_Entities_One_To_Many()
    {
        var companyRepository = GetRequiredService<CompanyRepository>();
        var invoiceRepository = GetRequiredService<InvoiceRepository>();
        var context = GetRequiredService<DbContext>();


        var companyFrom = companyRepository.Queryable.RandomElement(x => true);
        var toFrom = companyRepository.Queryable.RandomElement(x => true);

        if (companyFrom == null)
            throw new NullException("companyFrom");

        if (toFrom == null)
            throw new NullException("toFrom");

        var invoice = new Invoice
        {
            InvoiceState = Enum.Random<InvoiceState>(),
            From = companyFrom,
            To = toFrom
        };
        invoice.InvoiceDetails = new List<InvoiceDetail>
        {
            new()
                { Amount = Finance.Coupon(), Label = Finance.Credit.BondName() },
            new()
                { Amount = Finance.Coupon(), Label = Finance.Credit.BondName() },
            new()
                { Amount = Finance.Coupon(), Label = Finance.Credit.BondName() }
        };
        await invoiceRepository.AddOneAsync(invoice);

        context.SaveChanges(true);
    }

    [Fact]
    public void Update_Entity_One_To_Many()
    {
        var companyRepository = GetRequiredService<CompanyRepository>();
        var invoiceRepository = GetRequiredService<InvoiceRepository>();
        var context = GetRequiredService<DbContext>();


        var companyFrom = companyRepository.Queryable.RandomElement(x => true);
        var toFrom = companyRepository.Queryable.RandomElement(x => true);

        if (companyFrom == null)
            throw new NullException("companyFrom");

        if (toFrom == null)
            throw new NullException("toFrom");

        var invoice = invoiceRepository.Queryable.RandomElement(x => true);

        if (invoice == null)
            throw new NullException("invoice");
        //BEWARE SET THE ID BECAUSE NOT INCREMENTAL
        invoice.InvoiceDetails.Add(new InvoiceDetail
            { Amount = Finance.Coupon(), Label = Finance.Credit.BondName(), Id = KeyGenerator.NewId<string>() });

        var invoiceDetail = invoice.InvoiceDetails.First();
        invoiceDetail.Amount = Finance.Coupon();
        invoiceDetail.Label = Finance.Credit.BondName();

        context.SaveChanges(true);
    }


    [Fact]
    public async Task Update_Detached_Entity_One_To_Many_With_Context()
    {
        var companyRepository = GetRequiredService<CompanyRepository>();
        var invoiceRepository = GetRequiredService<InvoiceRepository>();
        var context = GetRequiredService<DbContext>();

        var initialInvoiceCount = invoiceRepository.Count();

        var fromCompany = companyRepository.Queryable.RandomElement(x => true);
        var toCompany = companyRepository.Queryable.RandomElement(x => true);

        if (fromCompany == null)
            throw new NullException("companyFrom");

        if (toCompany == null)
            throw new NullException("toFrom");

        var invoice = invoiceRepository.Queryable.RandomElement(x => true);
        if (invoice == null)
            throw new NullException("invoice");
        var initialInvoiceDetailsCount = invoice.InvoiceDetails.Count();

        if (invoice.Clone() is not Invoice newInvoice)
            throw new NullException("newInvoice");

        newInvoice.From = fromCompany;
        newInvoice.To = toCompany;

        var invoiceDetail = newInvoice.InvoiceDetails.First();
        invoiceDetail.Amount = Finance.Coupon();
        invoiceDetail.Label = Finance.Credit.BondName();
        newInvoice.InvoiceDetails.Remove(newInvoice.InvoiceDetails.Last());

        //BEWARE SET THE ID BECAUSE NOT INCREMENTAL
        newInvoice.InvoiceDetails.Add(new InvoiceDetail
            { Amount = Finance.Coupon(), Label = Finance.Credit.BondName(), Id = KeyGenerator.NewId<string>() });
        newInvoice.InvoiceDetails.Add(new InvoiceDetail
            { Amount = Finance.Coupon(), Label = Finance.Credit.BondName(), Id = KeyGenerator.NewId<string>() });
        newInvoice.InvoiceDetails.Add(new InvoiceDetail
            { Amount = Finance.Coupon(), Label = Finance.Credit.BondName(), Id = KeyGenerator.NewId<string>() });


        //ALGO SAVE DETACHED ENTITY
        //Update Properties
        invoice.From = newInvoice.From;
        invoice.To = newInvoice.To;

        //Update Collections
        foreach (var invoiceDetailFromNewInvoice in newInvoice.InvoiceDetails)
        {
            var existingInvoiceDetail = invoice.InvoiceDetails
                .FirstOrDefault(p => p.Id == invoiceDetailFromNewInvoice.Id);

            if (existingInvoiceDetail == null)
            {
                invoice.InvoiceDetails.Add(invoiceDetailFromNewInvoice);
            }
            else
            {
                existingInvoiceDetail.Amount = invoiceDetailFromNewInvoice.Amount;
                existingInvoiceDetail.Label = invoiceDetailFromNewInvoice.Label;
            }
        }

        foreach (var detail in invoice.InvoiceDetails)
            if (newInvoice.InvoiceDetails.All(p => p.Id != detail.Id))
                context.Remove(detail);


        await context.SaveChangesAsync(true);

        var finalInvoiceCount = invoiceRepository.Count();


        var afterSaveChangesInvoice = invoiceRepository.Queryable
            .Include(x => x.InvoiceDetails)
            .Include(x => x.From)
            .Include(x => x.To).FirstOrDefault(x => x.Id == invoice.Id);


        if (afterSaveChangesInvoice == null)
            throw new NullException("afterSaveChangesInvoice");


        Assert.Equal(initialInvoiceCount, finalInvoiceCount);
        Assert.Equal(initialInvoiceDetailsCount + 2, afterSaveChangesInvoice.InvoiceDetails.Count());
        Assert.Equal(fromCompany.Id, afterSaveChangesInvoice.From.Id);
        Assert.Equal(toCompany.Id, afterSaveChangesInvoice.To.Id);
    }
}