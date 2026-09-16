# CsvLinqMvc

## Project Description
This project reads product data from a CSV file and maps each row to a Product object.

The program uses MVC structure and LINQ to search, filter, select and sort products.

The user can choose different operations from a console menu.

## MVC Structure
- Product (Model) contains information about the products.
- ProductView (View) is responsible for displaying information to the user.
- ProductController (Controller) is responsible for the program logic and controls which operations are performed.

## LINQ Operations
- Where() filters elements based on a condition.
- Select() selects a property or creates a new value from an element.
- OrderBy() sorts elements in ascending order.
- OrderByDescending() sorts elements in descending order.
- FirstOrDefault() returns the first matching element or the default value if no element is found.

## Pseudocode
1. Start program
2. Read data from CSV file
3. Display menu
4. Ask the user to choose an operation
5. Execute the selected operation
6. Display the result
7. Return to the menu
8. If the user chooses Exit, end the program

## Flow Sketch
START
  ↓
Read products from CSV
  ↓
Display menu
  ↓
Get user choice
  ↓
Is choice = 8?
  ├── YES → END
  │
  └── NO
       ↓
   Execute selected operation
       ↓
   Display result
       ↓
   Return to menu
       ↓
   Display menu

## How to Run
Run the program from Visual Studio.

The program reads product data from Products.csv and displays a menu in the console.

Choose an option from 1 to 8 and follow the instructions.
Choose option 8 to exit the program.