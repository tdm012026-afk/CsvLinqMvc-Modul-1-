# CsvLinqMvc

## Project Description

This project reads product data from a CSV file and maps each row to a Product object.

The project uses an MVC structure and LINQ to filter, select and sort products.

The dataset used in the project is the 80 Cereals dataset from the beginner-friendly datasets collection provided in the assignment.

The user can choose different operations from a console menu.

## MVC Structure

- Product (Model) contains information about each cereal product.
- ProductReader (Reader) reads the CSV file and maps each row to a Product object.
- ProductRepository (Repository) stores and provides the products.
- ProductController (Controller) handles the program logic and controls which LINQ operation is performed.
- ProductView (View) is responsible for displaying the results to the user.

## CSV Reading and Mapping

The program uses `File.ReadAllLines()` to read the CSV file.

The first line contains the column headers and is skipped.

Each following line is divided into separate values using `Split(',')`.

The values are then mapped to properties in the Product class.

The program uses `int.Parse()` and `double.Parse()` to convert CSV values to the correct C# types.

`CultureInfo.InvariantCulture` is used when parsing decimal values.

## LINQ Operations

- `Where()` filters products based on a condition.
- `Select()` selects a property or creates a new value from an element.
- `OrderBy()` sorts products in ascending order.
- `OrderByDescending()` sorts products in descending order.

### Examples

- Show products with more than 100 calories.
- Show names of products with more than 10 grams of sugar.
- Create product descriptions containing name, calories and rating.
- Sort products by calories.
- Sort products by rating.

## Pseudocode

1. Start program
2. Read products from the CSV file
3. Create the MVC components
4. Display the menu
5. Ask the user to choose an operation
6. Send the user's choice to the controller
7. Execute the selected LINQ operation
8. Display the result
9. Return to the menu
10. If the user chooses Exit, end the program

## Flow Sketch

START
  ↓
Read products from cereal.csv
  ↓
Create Controller
  ↓
Display menu
  ↓
Get user choice
  ↓
Is choice = 7?
  ├── YES → END
  │
  └── NO
       ↓
   Send choice to Controller
       ↓
   Execute selected LINQ operation
       ↓
   Display result
       ↓
   Return to menu
       ↓
   Display menu

## Project Update

The project was initially developed using a small test dataset.

The dataset was later replaced with the 80 Cereals dataset from the beginner-friendly datasets collection provided in the assignment.

The Product model and CSV reader were updated to match the new dataset.

The LINQ queries and console menu were also adapted to work with the new data.

## How to Run

Run the project from Visual Studio.

The program reads product data from `cereal.csv` and displays a menu in the console.

Choose an option from 1 to 7.

Choose option 7 to exit the program.