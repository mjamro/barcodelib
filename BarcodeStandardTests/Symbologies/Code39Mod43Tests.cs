﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using BarcodeStandard;
using Type = BarcodeStandard.Type;

namespace BarcodeStandardTests.Symbologies
{
    [TestClass]
    public class Code39Mod43Tests
    {
        private readonly Barcode _barcode = new Barcode
        {
            EncodedType = Type.Code39Mod43,
        };

        [DataTestMethod]
        [DataRow("038000356216", "10010110110101010011011010110110010101011010010110101010011011010101001101101010100110110101101100101010110100110101010110011010101011001010110110100101011010110011010101100101101010100101101101")]
        [DataRow("123456789012", "10010110110101101001010110101100101011011011001010101010011010110110100110101010110011010101010010110110110100101101010110010110101010011011010110100101011010110010101101101001101010100101101101")]
        [DataRow("192794729478", "10010110110101101001010110101100101101010110010101101010010110110101100101101010100110101101010010110110101100101011010110010110101010011010110101001011011011010010110101010101100110100101101101")]
        public void EncodeBarcode(
            string data,
            string expected)
        {
            try
            {
                _barcode.Encode(data);
            }
            catch when (expected == null)
            {
            }
            Assert.AreEqual(expected, _barcode.EncodedValue, $"{_barcode.EncodedType}");
        }
    }
}
