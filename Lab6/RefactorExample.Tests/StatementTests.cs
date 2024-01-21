using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using NUnit.Framework;
using RefactorExample.DTOs;

namespace RefactorExample.Tests
{
    public class StatementTests
    {
        private readonly string baseDirectory;

        public StatementTests() => baseDirectory = AppDomain.CurrentDomain.BaseDirectory;

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ShouldGenerateStatementIfValidInput()
        {
            // Arrange
            var inputPlays = JsonConvert.DeserializeObject<Dictionary<string, Play>>(File.ReadAllText(Path.Combine(baseDirectory, "GoldenFiles\\inputPlays.json")));
            var inputInvoice = JsonConvert.DeserializeObject<Invoice>(File.ReadAllText(Path.Combine(baseDirectory, "GoldenFiles\\inputInvoices.json")));
            var _sut = new Statement(inputInvoice, inputPlays);

            var expected = File.ReadAllText(Path.Combine(baseDirectory, "GoldenFiles\\expectedOutput.txt"));

            // Act
            var actual = _sut.CreateStatement();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
