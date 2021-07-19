﻿namespace ContractManagement.Domain.Services.Contracts
{
    public class ContractCsvRow
    {
        public string RegistrationNumber { get; set; }

        public string Institution { get; set; }

        public string Client { get; set; }

        public string Administrator { get; set; }

        public string ConclusionDate { get; set; }

        public string ValidFromDate { get; set; }

        public string TerminationDate { get; set; }
    }
}
