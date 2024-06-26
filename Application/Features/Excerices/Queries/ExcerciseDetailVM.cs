﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Excerices.Queries
{
    public class ExcerciseDetailVM
    {
        public Guid Id { get; set; }
        public string User { get; set; }
        public string ExcerciseType { get; set; }
        public string ExampleDescription { get; set; }
        public bool Monday { get; set; }
        public bool Thuesday { get; set; }
        public bool Wednesday { get; set; }
        public bool Thursday { get; set; }
        public bool Friday { get; set; }
    }
}
