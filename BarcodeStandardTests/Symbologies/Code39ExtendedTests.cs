﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using BarcodeStandard;

namespace BarcodeStandardTests.Symbologies
{
    [TestClass]
    public class Code39ExtendedTests
    {
        private readonly Barcode _barcode = new()
        {
            EncodedType = Type.Code39Extended,
        };

        [DataTestMethod]
        [DataRow("19d27c947294z78a", "100101101101011010010101101011001011010100101001001010101100101101011001010110101001011011010010100100101101101001010101100101101010100110101101010010110110101100101011010110010110101010011010110100101001001010011011010101010010110110110100101101010010100100101101010010110100101101101")]
        [DataRow("123*56?890&2", "10010110110101101001010110101100101011011011001010101101001101010101100110101010100100100101010110011010110100101101010110010110101010011011010100100101001010110110010101011001010110100101101101")]
        public void EncodeBarcode(string data, string expected)
        {
            _barcode.Encode(data);
            Assert.AreEqual(expected, _barcode.EncodedValue, $"{_barcode.EncodedType}");
        }
    }
}