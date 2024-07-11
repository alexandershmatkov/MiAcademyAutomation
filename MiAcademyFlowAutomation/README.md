# MiAcademyAutomation
This project contains automated tests for the application process on the MiAcademy website.

Overview
In this project, I have written a test that navigates through the application process for the MiaPrep Online High School (MOHS). The test is divided into three test cases because the Online High School page contains three Apply to MOHS buttons. Each test case verifies the flow when clicking on each of these buttons.

Test Flow
- Navigate to the homepage.
- Click on the link to MiaPrep Online High School.
- Click on one of the three Apply to MOHS buttons.
- Proceed to the Parent Information page and fill out the form.
- Proceed to the Student Information page.
- At the end of the test, it checks that we are on the "Student Information" page by verifying the form header. If this check passes, the test is considered successfully completed.

Test Cases
- ApplyButton1: Verifies the flow when clicking on the first Apply to MOHS button.
- ApplyButton2: Verifies the flow when clicking on the second Apply to MOHS button.
- ApplyButton3: Verifies the flow when clicking on the third Apply to MOHS button.
Assertions
- The test asserts that the "Student Information" page is reached by checking the presence of the form header.

How to Run
1. Clone the repository.
2. Open the solution in Visual Studio.
3. Restore NuGet packages.
4. Build the solution.
5. Run the tests using the Test Explorer.
