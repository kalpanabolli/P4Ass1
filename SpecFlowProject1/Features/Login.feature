Feature: Login
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](SpecFlowProject1/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**
Feature: User Login
@Login
  Scenario: Successful Login
    Given the user is on the login page
    When the user enters valid credentials (username "Sam" and password "Sam@123")
    And clicks the login button
    Then the user should be redirected to the dashboard
@Login
  Scenario: Invalid Login
    Given the user is on the login page
    When the user enters invalid credentials (username "invalid_user" and password "invalid_password")
    And clicks the login button
    Then an error message should be displayed