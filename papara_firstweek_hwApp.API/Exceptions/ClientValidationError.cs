﻿namespace papara_firstweek_hwApp.API.Exceptions
{
    public class ClientValidationError:Exception
    {
        public ClientValidationError(string message) : base(message)
        {
        }
    }
}
