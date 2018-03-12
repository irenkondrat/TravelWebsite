﻿using System;

namespace Travel.BL.Exceptions
{
    public class IncorrectDataException : Exception
    {
        public IncorrectDataException(string message) : base(message)
        {}
    }
}