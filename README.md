# RulePatternBuilder

This prototype was used to create a rule pattern from an expression. Depending on the pattern selected a rule mask is created for the expression. These rule masks used to be created manually and the idea behind this example was to automate the creation of these rule masks from a given expression. 

## Usage
Select the “Measure” option, and enter “SUM(MAX(y+r)) + POWER(y)”, for instance, you will see the rule pattern generated. A generic function library helps the tool recognize operators and valid functions. You can type this into the text box or you can paste it. The pattern should be recognised. If not, just add a key stroke space at the end.
