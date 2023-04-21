﻿using Models_and_Steps.Models;
using Selenium_Wrapper.Utilities;

namespace Models_and_Steps.Data;

public abstract class UserProfileModelFactory
{
    public static readonly UserProfileModel UserProfile1 = new()
    {
        Name = Helper.GenUniqueRandomString(),
        Position = Helper.GenUniqueRandomString()
    };
}