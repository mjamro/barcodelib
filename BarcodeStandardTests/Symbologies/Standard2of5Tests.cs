﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using BarcodeStandard;
using Type = BarcodeStandard.Type;

namespace BarcodeStandardTests.Symbologies
{
    [TestClass]
    public class Standard2of5Tests
    {
        private readonly Barcode _barcode = new Barcode
        {
            EncodedType = Type.Standard2Of5,
        };

        [DataTestMethod]
        [DataRow("19279472947812", "1101101011101010101110101110101110101011101010111010101011101110101110101110101010111010111010101011101110101110101011101011101011101010101110101110101010111011101110101011101011101010101110101110101011101101011")]
        [DataRow("12345678901274", "1101101011101010101110101110101011101110111010101010101110101110111010111010101011101110101010101011101110111010101110101011101011101010101110111010111010101011101011101010111010101011101110101011101011101101011")]
        [DataRow("192794729478", "110110101110101010111010111010111010101110101011101010101110111010111010111010101011101011101010101110111010111010101110101110101110101010111010111010101011101110111010101110101101011")]
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
