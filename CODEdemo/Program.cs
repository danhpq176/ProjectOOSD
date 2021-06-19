﻿using System;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //SINGLETON
            //Login.getInstance().checkUser("taikhoan", "matkhaau");

            //BUILDER
            //var userBuilder = new ConcreteBuilder()
            //    .setFirstName("Hoang")
            //    .setLastName("Tran")
            //    .setDayOfBirth("07/11/200");
            //Console.WriteLine(userBuilder.build());

            //BRIDGE
            //Account teacherAccount = new TeacherAccount(new TeacherNotification());
            //Account studentAccount = new StudentAccount(new StudentNotification());
            //teacherAccount.addNotification();
            //studentAccount.addNotification();

            //FACTORY
            //Console.WriteLine("Add subject with teacher's account!");
            //Subject teacherAccount = SubjectFactory.getAccount(AccountType.TEACHER);
            //teacherAccount.addSubject("Mathematics");
            //Console.WriteLine("Add subject with student's account!");
            //Subject studentAccount = SubjectFactory.getAccount(AccountType.STUDENT);
            //studentAccount.addSubject("Mathematics");

            //CHAIN OF RESPONSIBILITY
            //Logger logger = AppLogger.getLogger();

            //logger.log(LogLevel.PENDING, "Pending message");
            //logger.log(LogLevel.SUCCESS, "Success message");
            //logger.log(LogLevel.ERROR, "Error message");

            //VISITOR
            User student = new Student();
            User teacher = new Teacher();
            User admin = new Admin();
            Visitor v = new VisitorImpl();
            student.search(v);
            teacher.search(v);
            admin.search(v);
        }
       
    }
    public enum AccountType
    {
        TEACHER, STUDENT
    }

}
