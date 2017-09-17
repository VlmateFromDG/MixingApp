﻿using System.Net;

namespace MixingApp.Services.SpotifyWeb.Models
{
    public class ResponseInfo
    {
        public WebHeaderCollection Headers { get; set; }

        public HttpStatusCode StatusCode { get; set; }

        public static readonly ResponseInfo Empty = new ResponseInfo();
    }
}