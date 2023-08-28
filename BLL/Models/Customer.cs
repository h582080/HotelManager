using System;
using System.Collections.Generic;

namespace BLL.Models;

public  class Customer
{
    public int CustomerId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Username { get; set; }

    public string? Password { get; set; }

}
