using System;

  struct myDetails
{
    public String firstname;
    public String lastname;
    public int ages;

    public myDetails(String fname, String lname,int age)
    {
        firstname = fname;
        lastname = lname;
        ages = age;
    }

    public void DisplayDetails()
    {
        Console.WriteLine("Firstname is " + firstname + ",Lastname is " + lastname + ", My age is"+ ages);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        myDetails details = new myDetails("supriya","Budhathoki",21);
        details.DisplayDetails();

        // Modifying the struct
        details.firstname = "sup";
        details.lastname = "budhathoki";
        details.ages = 22;
        details.DisplayDetails();
    }
}
