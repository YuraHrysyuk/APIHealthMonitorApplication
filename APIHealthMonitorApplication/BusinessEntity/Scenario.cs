﻿using System;

namespace BusinessEntity
{
    public class Scenario
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime CreatedOn { get; set; } = DateTime.Now;
    }
}