﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiPrac.ApiControllers
{
    public class StudentDataController : ApiController
    { 
        [HttpGet]
        public int GetData1()
        {
            return 10;
        }

        [HttpGet]
        public int GetData2(int a, int b)
        {
            return a + b;
        }
        [HttpPost]
        public string Save(StudentDTO dto)
        {
            return dto.name + "testing";
        }


    }


    public class StudentDTO
    {
        public int id { get; set; }
        public string name {get;set;}
    }
}