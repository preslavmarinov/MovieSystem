﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSystem.Domain.DTO
{
    public abstract class BaseDTO
    {
        public Guid Id { get; set; }
    }
}
