﻿namespace App.Domain.Core.HomeService.Result
{
    public class Result
    {
        public bool IsSucces { get; set; }
        public string? Message { get; set; }

        public Result(bool isSuccess, string? message = null)
        {
            IsSucces = isSuccess;
            Message = message;
        }

    }
}
