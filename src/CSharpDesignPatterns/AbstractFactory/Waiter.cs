﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class Waiter:Staff
    {
        private readonly IStaffDetailsFactory _staffDetailsFactory;

        public Waiter(IStaffDetailsFactory staffDetailsFactory)
        {
            _staffDetailsFactory = staffDetailsFactory;
        }

        public override string GetInfo()
        {
            Name = _staffDetailsFactory.CreateName();
            Experience = _staffDetailsFactory.CreateExperience();
            Role = _staffDetailsFactory.CreateRole();
            WineKnowledge = _staffDetailsFactory.CreateWineKnowledge();

            var sb = new StringBuilder();

            sb.Append("Name: " + Name.GetName() + "\n");
            sb.Append("Experience: " + Experience.GetExperience() + "\n");
            sb.Append("Role: " + Role.GetRole() + "\n");
            sb.Append("Wine Knowledge: " + WineKnowledge.GetWineKnowledge() + "\n");

            return sb.ToString();
        }
    }
}
