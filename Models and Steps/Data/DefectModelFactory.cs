﻿using Models_and_Steps.Models;
using Utilities.Utilities;

namespace Models_and_Steps.Data;

public static class DefectModelFactory
{
    public static readonly DefectModel Model = new()
    {
        DefectTitle = Helper.GenUniqueRandomString(),
        ActualResult = Helper.GenUniqueRandomString()
    };
}