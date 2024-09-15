1. **Static Conversion Class**:  
   The conversion of strings to integers has been moved to a static class


2. **Input Validation for Numbers and Operators**:  
   - The program now re-prompts the user for input if an invalid number or operator is entered.  
   - Help text has been added to guide users.
     `"Enter '+' or 'plus' for addition. Valid operations are add, subtract, multiply, divide."`
     
3. **Input Validation for Numbers and Operators**:  
   - The program now re-prompts the user for input if an invalid number or operator is entered.  
   - Text has been added to guide users:  
     `"Enter '+' or 'plus' for addition. Valid operations are add, subtract, multiply, divide, and more."`

4. **Improved Output Formatting**:  
   - Results are now displayed in a human-readable format. Example:  
     `"The value 1 plus the value 2 is equal to 3."`  

5. **CalculatorEngine Class in a Separate DLL**:  
   - The `CalculatorEngine` class has been moved to its own project, compiled into a DLL, and referenced in the main project
   - A new function (**modulus**) has been implemented.
