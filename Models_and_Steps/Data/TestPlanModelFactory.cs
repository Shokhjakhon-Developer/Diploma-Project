﻿using Models_and_Steps.Models;
using Utilities.Utilities;

namespace Models_and_Steps.Data;

public static class TestPlanModelFactory
{
    public static readonly TestPlanModel Model1 = new()
    {
        Title = Faker.GenUniqueRandomString(),
        Description = Faker.GenUniqueRandomString()
    };
}