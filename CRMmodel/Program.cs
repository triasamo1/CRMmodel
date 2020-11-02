using CRMmodel.models;
using CRMmodel.services;
using System;
using System.Collections.Generic;

namespace CRMmodel
{
    class Program
    {
        static void Main(string[] args)
        {
            EshopService eshop = new EshopService();
            eshop.MainProcess();

        }

        
    }
}
