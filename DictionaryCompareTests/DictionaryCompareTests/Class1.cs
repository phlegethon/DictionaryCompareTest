using KellermanSoftware.CompareNetObjects;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DictionaryCompareTests
{
    public class Class1 : Dictionary<string, string>
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public override bool Equals(object value)
        {
            bool returnValue;
            CompareLogic compareLogic;
            ComparisonResult result;

            try
            {
                compareLogic = new CompareLogic();
                result = compareLogic.Compare(this, value);

                returnValue = result.AreEqual;
            }
            catch (Exception ex)
            {
                Debug.Print(ex.Message);
                Debugger.Break();
                throw;
            }

            return returnValue;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}