﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OnSale.Common.Entities
{
  public   class City
    {
        public int Id { get; set; }

        [MaxLength(50, ErrorMessage = "The filed {0} must contain less than {1} characteres.")]

        [Required]

        public string Name { get; set; }


        //public Department Department  { get; set; }
        [JsonIgnore]

        [NotMapped]

        public int IdDepartment { get; set; }
    }
}
