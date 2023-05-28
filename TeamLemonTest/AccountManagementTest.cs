using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TeamLemon.Models;
using TeamLemon.Mock;
using System.Linq;

namespace TeamLemonTest
{
    [TestClass]
    public class AccountManagementTest
    {
        [TestMethod]
        public void ValidateFromAccount_ShouldReturnTrue_WhenUserAndAccountNumbersIsCorrect()
        {
            var mock = new ValidationMock();
            var currentUser = User.AllUsers.First();
            var fromAcc = 0;
            var toAcc = 100401;
            var res = ValidationMock.ValidateFromAccount(currentUser, fromAcc, toAcc);
            Assert.IsTrue(res);
        }
        [TestMethod]
        public void ValidateFromAccount_ShouldReturnFalse_WhenUserAndAccountNumbersIsIncorrect()
        {
            var mock = new ValidationMock();
            var currentUser = User.AllUsers.First();
            var fromAcc = 14;
            var toAcc = 10401;
            var res = ValidationMock.ValidateFromAccount(currentUser, fromAcc, toAcc);
            Assert.IsFalse(res);
        }


        [TestMethod]
        public void ValidateAmmount_ShouldReturnFalse_WhenExpectedTransferIsGreaterThanBalance()
        {
            var mock = new ValidationMock();
            var currentUser = User.AllUsers.First();
            var fromAcc = 1;
            var amount = 9000401.12m;
            var res = ValidationMock.ValidateAmount(currentUser, amount, fromAcc);
            Assert.IsFalse(res);
        }
        [TestMethod]
        public void ValidateAmmount_ShouldReturnTrue_WhenExpectedTransferIsLessThanOrEqualToBalance()
        {
            var mock = new ValidationMock();
            var currentUser = User.AllUsers.First();
            var fromAcc = 1;
            var amount = 401.12m;
            var res = ValidationMock.ValidateAmount(currentUser, amount, fromAcc);
            Assert.IsTrue(res);
        }
        [TestMethod]
        public void ValidateAccountNumber_ShouldReturnAccountID_WhenAccountNumberExist()
        {
            var mock = new ValidationMock();
            var currentUser = User.AllUsers.First();
            var acc = "100402";
            var res = ValidationMock.ValidateAccountNumber(acc);
            Assert.AreEqual(1004, res);
        }
        [TestMethod]
        public void ValidateAccountNumber_ShouldReturnZero_WhenAccountNumberDoesNotExist()
        {
            var mock = new ValidationMock();
            var currentUser = User.AllUsers.First();
            var acc = "110402";
            var res = ValidationMock.ValidateAccountNumber(acc);
            Assert.AreEqual(0, res);
        }
    }
}
