using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CoffeeShopApp.Models
{
    public class AddMember
    {
        //Commented out a bunch of code here to see if the test page would work. It's Not....WHHHYYYYYYYYYY C# God Help me!
        [Required]
        [RegularExpression("^[a-zA-Z]{2,}$")]
        public string FirstName { set; get; }

        [Required]
        [RegularExpression("^[a-zA-Z]{2,}$")]
        public string LastName { set; get; }

        /*[Required]
        [RegularExpression("/^[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?/g")] //I got this code from Regex, I am not sure why it isn't work.
        public string Email { set; get; }  */

        [Required]
        [RegularExpression("^[0 - 9]{3}-[0-9]{3}-[0-9]{4}$")]  
        public string PhoneNumber { set; get; }  //Ask later why turning this into an Int it won't work in the constructor See below

        /*[Required]
        [RegularExpression("^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[a-zA-Z]).{8,}$")] //Same with this one and the email one. Need to find out why they aren't working
        public string Password { set; get; }*/

        public AddMember()
        {
            FirstName = " ";
            LastName = " ";
            //Email = " ";
            PhoneNumber = " " ; //How to print the Int on here.
            //Password = " ";
        }


    }
}