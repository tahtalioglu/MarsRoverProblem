using System;
using System.Collections.Generic;
using System.Text;
using AutoFixture;
using Xunit;

namespace MarsRoverProblem.Tests
{
    public abstract class TestBase : IDisposable
    {

        protected IFixture FixtureRepository { get; set; }
        protected bool VerifyAll { get; set; }

        public TestBase()
        {

            this.FixtureRepository = new Fixture();
            this.VerifyAll = true;
            this.FinalizeSetUp();
        }

        protected T Create<T>()
        {
            return this.FixtureRepository.Create<T>();
        }
        protected IEnumerable<T> CreateMany<T>()
        {
            return this.FixtureRepository.CreateMany<T>();
        }
        protected IEnumerable<T> CreateMany<T>(int count)
        {
            return this.FixtureRepository.CreateMany<T>(count);
        }
        protected void EnableCustomization(ICustomization customization)
        {
            customization.Customize(this.FixtureRepository);
        }
        protected virtual void FinalizeTearDown()
        {
        }
        protected virtual void FinalizeSetUp()
        {

        }

        public void Dispose()
        {
            FinalizeTearDown();
        }
    }
}
