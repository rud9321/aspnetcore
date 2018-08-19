using System;
using System.ComponentModel.DataAnnotations;

namespace coreapp2.Models
{
    public class student
    {
        [Key]
        public int Id{get;set;}
        public string Name{get;set;}
        public int Age{get;set;}
        public string Address{get;set;}
    }
}