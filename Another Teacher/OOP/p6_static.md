# static keyword in c#
- variable (data member)
- methods
- construsctors
- cclass


- static members (variable or method) can be accessible by using class name no need any object to access static data
`
class Demo
{
	int x;
	static int y =11;
	,,,,,,,
}
`

- Here `x` is no-static 
 - For each object x has separate memory , store diffrent values for each object

- `y` is static 
 - for whole calss memory is allocated to y can store common value for each object


# static methods
- void show() {.....}
- static void disp() {.....}
 - that why `Main method` is static cuz that time it's impossible to create object ^^)
	
