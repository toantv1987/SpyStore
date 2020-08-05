﻿using System;
using System.Collections.Generic;
using System.Text;
using SpyStore.Dal.EfStructures;
using SpyStore.Dal.Initialization;

namespace SpyStore.Service.Tests.TestClasses.Base
{
    public abstract class BaseTestClass : IDisposable{
        protected string ServiceAddress = "http://localhost:55882/";
        protected string RootAdress = String.Empty;
        public virtual void Dispose()
        {
            throw new NotImplementedException();
        }
    protected void ResetTheDatabase()
        {
            SampleDataInitializer.InitializeData(
                new StoreContextFactory().CreateDbContext(null));
        }

    }
}
