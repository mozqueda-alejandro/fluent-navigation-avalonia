﻿namespace CustomerDemo.Models;

public class Client
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Address { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public string Source { get; set; }
    
    public Client()
    {
    }
    
    public Client(string firstName, string lastName, string address, string email, string phone, string source)
    {
        FirstName = firstName;
        LastName = lastName;
        Address = address;
        Email = email;
        Phone = phone;
        Source = source;
    }
}