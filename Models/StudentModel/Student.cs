﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASPCore.Models.StudentModel
{
    public class Student
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Can't be empty!!")]
        [MinLength(10)]
        public string Name { get; set; }

        [Range(18, 65, ErrorMessage = "Can be betwen 18 and 65")]
        public int Age { get; set; }

        public string City { get; set; }

        [MinLength(7)]
        public string Phone { get; set; }

        [DataType(DataType.MultilineText)]
        public string Profile { get; set; }

    }
}
