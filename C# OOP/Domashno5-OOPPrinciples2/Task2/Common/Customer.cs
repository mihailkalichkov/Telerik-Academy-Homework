using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bank.Common
{
    public class Customer
    {
        // individual customer
        private CustomerType type;
        private string firstName;
        private string lastName;
        private string personalNumber; // ЕГН - 10 цифри
        private string documentNumber; // л.к. номер - 9 цифри
        private string residence; // постоянен адрес
        private List<Account> personalAcc = new List<Account>();

        public Customer(string firstName, string lastName, string personalNumber, string documentNumber, string residence)
        {
            CheckPersolanNumber(personalNumber);
            CheckDocumentNumber(documentNumber);
            this.firstName = firstName.Trim();
            this.lastName = lastName.Trim();
            this.personalNumber = personalNumber.Trim();
            this.documentNumber = documentNumber.Trim();
            this.residence = residence.Trim();
            this.type = CustomerType.Indidual;
        }

        public string PersonName
        {
            get { return this.firstName + " " + this.lastName; }
        }

        public string PersonalNumber
        {
            get { return this.personalNumber; }
        }

        public string DocumentNumber
        {
            get { return this.documentNumber; }
        }

        public string Residence
        {
            get { return this.residence; }
        }

        private void CheckDocumentNumber(string documentNumber)
        {
            if (documentNumber.Trim().Length != 9)
            {
                throw new ArgumentException("Invalid document number!");
            }
            for (int i = 0; i < 9; i++)
            {
                if (!char.IsDigit(documentNumber[i]))
                {
                    throw new ArgumentException("Invalid document number!");
                }
            }
        }

        private void CheckPersolanNumber(string personalNumber)
        {
            if (personalNumber.Trim().Length != 10)
            {
                throw new ArgumentException("Invalid personal number!");
            }
            for (int i = 0; i < 10; i++)
            {
                if (!char.IsDigit(personalNumber[i]))
                {
                    throw new ArgumentException("Invalid personal number!");
                }
            }
        }

        // company customer
        private string companyName;
        private string idNo; // булстат - 9 цифри
        private string vatNo = null; // регистрация по ДДС - BG + булстат
        private string custodianOfTheProperty; // МОЛ
        private List<Account> companyAcc = new List<Account>();

        public Customer(string companyName, string idNo, VAT YesNo, string custodianOfTheProperty)
        {
            CheckIdNumber(idNo);
            this.companyName = companyName.Trim();
            this.idNo = idNo.Trim();
            this.custodianOfTheProperty = custodianOfTheProperty.Trim();
            if (YesNo == VAT.Yes)
            {
                this.vatNo = "BG" + this.idNo;
            }
            this.type = CustomerType.Company;
        }

        string CompanyName
        {
            get { return this.companyName; }
        }

        string IDNo
        {
            get { return this.idNo; }
        }

        string VATNo
        {
            get { return this.vatNo; }
        }

        string CustodianOfTheProperty
        {
            get { return this.custodianOfTheProperty; }
        }

        private void CheckIdNumber(string idNo)
        {
            if (idNo.Trim().Length != 9)
            {
                throw new ArgumentException("Invalid ID number!");
            }
            for (int i = 0; i < 9; i++)
            {
                if (!char.IsDigit(idNo[i]))
                {
                    throw new ArgumentException("Invalid ID number!");
                }
            }
        }

        public void AddAccount(Account account)
        {
            if (type == CustomerType.Indidual)
            {
                if (account.Type == CustomerType.Indidual)
                {
                    this.personalAcc.Add(account);
                    account.Customer = this.PersonName;
                }
                else throw new ArgumentException("Cannot add company account to individual!");
            }
            else
            {
                if (account.Type == CustomerType.Company)
                {
                    this.companyAcc.Add(account);
                    account.Customer = this.companyName;
                }
                else throw new ArgumentException("Cannot add individual account to company!");
            }
        }

        public void CloseAccount(Account account)
        {
            if (account.Type == CustomerType.Indidual)
            {
                this.personalAcc.Remove(account);
            }
            else
            {
                this.companyAcc.Remove(account);
            }
        }

        public override string ToString()
        {
            var customer = new StringBuilder();
            if (type == CustomerType.Indidual)
            {
                customer.AppendFormat("Customer: {0}\nPersonal number: {1}\nDocument number: {2}\nResidence: {3}\n",
                    this.PersonName, this.PersonalNumber, this.DocumentNumber, this.Residence);
                foreach (var acc in personalAcc)
                {
                    customer.AppendLine(acc.ToString());
                    customer.AppendLine();
                }
                return customer.ToString();
            }
            else
            {
                customer.AppendFormat("Customer: {0}\nID number: {1}\nVAT number: {2}\nCustodian of the property: {3}\n",
                    this.CompanyName, this.IDNo, this.VATNo, this.CustodianOfTheProperty);
                foreach (var acc in companyAcc)
                {
                    customer.AppendLine(acc.ToString());
                    customer.AppendLine();
                }
                return customer.ToString();
            }
        }
    }
}