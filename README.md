# Automation Assessment for Automation Exercise Website

## Overview

This project contains **automated tests** for the [Automation Exercise](https://automationexercise.com) website.  
It includes **Selenium UI tests** and **API tests**, covering functionality such as login, signup, and account creation.

Test results are generated using **Allure Reports**, which include **test suites, sub-suites, severity levels, and stories** for better test reporting and traceability.

---

## Tech Stack

- **C# / .NET 9**
- **Selenium WebDriver**
- **NUnit** (Test Framework)
- **Allure Report** (Test Reporting)
- **GitHub Actions** (CI/CD)
- **RestSharp** (API Testing)

---

## File Structure

AutomationAssessment.Tests/
│── Drivers/
│ └── WebDriverSetup.cs
│
├── Pages/
│ ├── AuthPage.cs
│ └── SignUpInfoPage.cs
│
├── Utils/
│ ├── Selenium/
│ │ └── CsvReader.cs
│ ├── API/
│ │ └── ApiSetup.cs
│ └── SharedMethods.cs
│
├── Tests/
│ ├── Selenium/
│ │ ├── BaseTests.cs
│ │ ├── HomePageTests.cs
│ │ ├── LoginFormTests.cs
│ │ └── SignUpFormTests.cs
│ └── API/
│ └── CreateAccountTests.cs
│
├── TestData/
│ └── invalidLoginData.csv
│
├── Usings.cs
├── .gitignore
└── README.md

---

## Test Categories

### **Selenium Tests**

- **Navigation**: Verify page navigation flows.
- **UI**: Validate visibility of elements.
- **Login**: Valid and invalid login scenarios.
- **Signup / Account Creation**: Valid account creation flows.

### **API Tests**

- **Account Creation**: Create accounts with valid/invalid data.

Each test includes **Allure annotations** for:

- **Epic** (high-level module)
- **Suite / SubSuite** (feature group)
- **Story** (specific scenario)
- **Severity** (critical, normal, minor)

---

## CI/CD (GitHub Actions)

- Runs tests automatically on `push` or `pull_request` to `main` branch.
- Generates **Allure report** after test execution.
- Reports are deployed to **GitHub Pages**.
- Uses a **Windows runner** and sets up .NET 9, Selenium, and Allure CLI.

---

## Prerequisites

Before running tests locally, make sure you have:

1. **The repo cloned**
   git clone <repo-url>
   cd AutomationAssessment.Tests
2. **.NET 9 SDK**
3. **Google Chorme** (latest stable)
4. **ChromeDriver** matching your Chrome version
5. **NuGet Dependencies**
   Allure.Net.Commons 2.12.1
   Allure.NUnit 2.12.1
   coverlet.collector 6.0.2
   DotNetSeleniumExtras.WaitHelpers 3.11.0
   ExcelDataReader 3.7.0
   ExcelDataReader.DataSet 3.7.0
   Microsoft.NET.Test.Sdk 17.11.1
   Newtonsoft.Json 13.0.3
   NUnit 4.2.2
   NUnit.Analyzers 4.3.0
   NUnit3TestAdapter 4.6.0
   RestSharp 112.1.0
   Selenium.Support 4.35.0
   Selenium.WebDriver 4.35.0
6. **Allure CLI** installed

## Test Execution

### Restore dependencies

dotnet restore

### Run all tests

dotnet test

### Generate Allure report

allure generate bin\Debug\net9.0 allure-results -o allure-report

### Open Allure report

allure open allure-report

## Notes

- **Selenium Tests** run on Chrome by default.

- Allure Reports **categorize** tests by severity, epic, suite, subsuite, and story, providing a clear overview of test results.

- Invalid login scenarios are read from **TestData/invalidLoginData.csv**.

- The SharedMethods.cs file contains utility methods used across **both** Selenium and API tests.
