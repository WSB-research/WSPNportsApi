﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WSBNports.Models
{
    public abstract class Entity
    {
        /// <summary>
        /// Entity identifier
        /// </summary>
        /// <example>5fe3fc2a-cbac-4df0-8031-fdca0f682989</example>
        public string Id { get; set; }
    }
}
