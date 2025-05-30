﻿namespace WebApp.Entities;

public class OrderInfoNO
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Address1 { get; set; }
    public string? Address2 { get; set; }
    public string? City { get; set; }
    public string? ZipCode { get; set; }
    public string? Email { get; set; }
    public string? PhoneNumber { get; set; }
    public CreditCardInfo CreditCard { get; set; } = new();
}
